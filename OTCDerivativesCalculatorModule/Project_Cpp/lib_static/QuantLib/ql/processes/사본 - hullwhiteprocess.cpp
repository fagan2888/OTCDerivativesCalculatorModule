/* -*- mode: c++; tab-width: 4; indent-tabs-mode: nil; c-basic-offset: 4 -*- */

/*
 Copyright (C) 2006, 2007 Banca Profilo S.p.A.

 This file is part of QuantLib, a free-software/open-source library
 for financial quantitative analysts and developers - http://quantlib.org/

 QuantLib is free software: you can redistribute it and/or modify it
 under the terms of the QuantLib license.  You should have received a
 copy of the license along with this program; if not, please email
 <quantlib-dev@lists.sf.net>. The license is also available online at
 <http://quantlib.org/license.shtml>.

 This program is distributed in the hope that it will be useful, but WITHOUT
 ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
 FOR A PARTICULAR PURPOSE.  See the license for more details.
*/

#include <ql/processes/hullwhiteprocess.hpp>
#include <iostream>

namespace QuantLib {

    HullWhiteProcess::HullWhiteProcess(const Handle<YieldTermStructure>& h,
                                       Real a,
                                       Real sigma)
    : process_(new OrnsteinUhlenbeckProcess(
                   a, sigma, h->forwardRate(0.0,0.0,Continuous,NoFrequency))),
      h_(h), a_(a), sigma_(sigma) {
        QL_REQUIRE(a_ >= 0.0, "negative a given");
        QL_REQUIRE(sigma_ >= 0.0, "negative sigma given");
		savedDataFlag_=false;

    }
	HullWhiteProcess::HullWhiteProcess(const Handle<YieldTermStructure>& h,
                                       Period& tenor,
									   Real a,
                                       Real sigma)
    : process_(new OrnsteinUhlenbeckProcess(
                   a, sigma, h->forwardRate(0.0,years(tenor),Continuous,NoFrequency))),
      h_(h), a_(a), sigma_(sigma),tenor_(tenor) {
        QL_REQUIRE(a_ >= 0.0, "negative a given");
        QL_REQUIRE(sigma_ >= 0.0, "negative sigma given");
		QL_REQUIRE(tenor.length() >= 0, "tenor no given");

		savedDataFlag_=false;

    }



    Real HullWhiteProcess::x0() const {
        return process_->x0();
    }

    Real HullWhiteProcess::drift(Time t, Real x) const {
        Real alpha_drift = sigma_*sigma_/(2*a_)*(1-std::exp(-2*a_*t));
        Real shift = 0.0001;
        Real f = h_->forwardRate(t, t, Continuous, NoFrequency);
        Real fup = h_->forwardRate(t+shift, t+shift, Continuous, NoFrequency);
        Real f_prime = (fup-f)/shift;
        alpha_drift += a_*f+f_prime;
        return process_->drift(t, x) + alpha_drift;
    }

    Real HullWhiteProcess::diffusion(Time t, Real x) const{
        return process_->diffusion(t, x);
    }

    Real HullWhiteProcess::expectation(Time t0, Real x0, Time dt) const {
        return process_->expectation(t0, x0, dt)
             + alpha(t0 + dt) - alpha(t0)*std::exp(-a_*dt);
    }

    Real HullWhiteProcess::stdDeviation(Time t0, Real x0, Time dt) const{
        return process_->stdDeviation(t0, x0, dt);
    }

    Real HullWhiteProcess::variance(Time t0, Real x0, Time dt) const{
        return process_->variance(t0, x0, dt);
    }

    Real HullWhiteProcess::alpha(Time t) const {
        Real alfa = a_ > QL_EPSILON ?
                    (sigma_/a_)*(1 - std::exp(-a_*t)) :
                    sigma_*t;
        alfa *= 0.5*alfa;
        alfa += forwardRate(t);//h_->forwardRate(t, t, Continuous, NoFrequency);
        return alfa;
    }


    Real HullWhiteProcess::a() const {
        return a_;
    }

    Real HullWhiteProcess::sigma() const {
        return sigma_;
    }

	Time HullWhiteProcess::time(const Date& d) const {
        return h_->dayCounter().yearFraction(h_->referenceDate(), d);
    }

	// Customized by Ansang (2011-12-02)

	// 저장된 데이터를 사용하기 위한 인터페이스
	
	//Forward 데이터 저장용 (생성할때 만들어짐)
	Real HullWhiteProcess::forwardRate(Time t) const{
		if(!savedDataFlag_){
			return h_->forwardRate(t, t, Continuous, NoFrequency);
		}
		else{
			return savedForwardData_[z_];
		}
	}

	void HullWhiteProcess::setPreCalculation(const TimeGrid& timeGrid) const{

		//std::cout << "calculating setTforwardRate in HullWhiteProcess class....." <<std::endl;
		gridNum=timeGrid.size();
		savedTime_=Array(gridNum,0.0);
		savedForwardData_=Array(gridNum,0.0);
		savedDiscountData_=Array(gridNum,0.0);
		savedDiscountDataT_=Array(gridNum,0.0);
		savedDrift_=Array(gridNum,0.0);
		savedVol_=Array(gridNum,0.0);
		//refRateData_=Array(timeGrid.size(),0.0);
		
		paraB_=(-1/dt)*(1-std::exp(-a_*dt))/a_;
		

		Real f=0.0;		Real fup=0.0;	
		Real dt=years(tenor_); //수정 필요 0.25 고정
		Size n=savedForwardData_.size();

		if ( (timeGrid[timeGrid.size()-1]/(timeGrid.size())) < 0.25 ){ 
			
			for(Size i=0 ;i < n-1 ; i++){
				
				savedTime_[i]=timeGrid[i];
				savedForwardData_[i]=h_->forwardRate(timeGrid[i], timeGrid[i]+timeGrid.dt(i), Continuous, NoFrequency);
				savedDiscountData_[i]=h_->discount(timeGrid[i]);
				savedDiscountDataT_[i]=h_->discount(timeGrid[i]+dt);

				savedDrift_[i]=savedForwardData_[i]+( (1-std::exp(-a_*savedTime_[i]))^2 )*(sigma_*sigma_)/2*a_*a_
					- ( savedForwardData_[i-1]+( (1-std::exp(-a_*savedTime_[i-1]))^2 )*(sigma_*sigma_)/2*a_*a_ ) * std::exp(-a_*timeGrid.dt(i)); // dt(i) 가 어디에서 어디 사이인가
				savedvol_[i]=(1-std::exp(-2*a_*timeGrid.dt(i)))*(sigma_*sigma_)/2*a_;

				multiple_[i]=std::exp(-a*timeGrid.dt(i));
				paraLnA_[i]=std::log(savedDiscountDataT_[i]/savedDiscountData_[i])+
				paraB_*savedForwardData_[i]-((sigma_*sigma_)/(4*a_*a_*a_))*
				(std::exp(-a_*(savedTime_[i]+dt))-std::exp(-a_*savedTime_[i]))*(std::exp(2*a_*savedTime_[i])-1);

				//std::cout << i << " : " << savedForwardData_[i] ;
				//std::cout << " , " << savedDiscountData_[i] << std::endl;
			}
				savedTime_[n-1]=timeGrid[n-1];
				savedForwardData_[n-1]=h_->forwardRate(timeGrid[n-1], timeGrid[n-1]+timeGrid.dt(n-2), Continuous, NoFrequency);
				savedDiscountData_[n-1]=h_->discount(timeGrid[n-1]);
				savedDiscountDataT_[n-1]=h_->discount(timeGrid[n-1]+dt);
				
				
				paraLnA_[n-1]=(-1/dt) *(std::log(savedDiscountDataT_[n-1]/savedDiscountData_[n-1])+
				paraB_*savedForwardData_[n-1]-((sigma_*sigma_)/(4*a_*a_*a_))*
				(std::exp(-a_*(savedTime_[n-1]+dt))-std::exp(-a_*savedTime_[n-1]))*(std::exp(2*a_*savedTime_[n-1])-1));

		}
		else{

			for(Size i=0;i<savedForwardData_.size();++i){
			
				savedForwardData_[i]=h_->forwardRate(timeGrid[i], timeGrid[i]+0.25, Continuous, NoFrequency);
				savedDiscountData_[i]=h_->discount(timeGrid[i]);
				savedDiscountDataT_[i]=h_->discount(timeGrid[i]+dt);

				//std::cout << i << " : " << savedForwardData_[i] ;
				//std::cout << " , " << savedDiscountData_[i] << std::endl;
			}
		
		}
		savedDataFlag_=true;
	}

    Real HullWhiteProcess::evolve(Time t0, Real x0,
                                     Time dt, Real dw) const {

		 return apply(expectation(t0,x0,dt), stdDeviation(t0,x0,dt)*dw);
    }

	Real HullWhiteProcess::evolve(Time t0, Real x0,
                                     Time dt, Real dw,Size z) const {
		z_=z;
		//setRefRate(x0,t0,dt);
        return apply(expectation(t0,x0,dt), stdDeviation(t0,x0,dt)*dw);
    }
	Real HullWhiteProcess::indexAdjustment(Real x,Size z) const{
		
		return paraLnA_[z]-paraB_*(drift[z]+vol[z]*x);
	}
/*
	void HullWhiteProcess::setRefRate(Real x0,Time t, Time dt) const{
		
		Size n=refRateData_.size();
		Real B=(1-std::exp(-a_*dt))/a_;
		Real A=(savedDiscountData_[z_+1]/savedDiscountData_[z_]) * std::exp(
			B*savedForwardData_[z_]-((sigma_*sigma_)/(4*a_))*(1-std::exp(-2*a_*t)*B*B)
			);
		Real lnA=std::log(savedDiscountData_[z_+1]/savedDiscountData_[z_])+
			B*savedForwardData_[z_]-((sigma_*sigma_)/(4*a_*a_*a_))*
			(std::exp(-a_*(t+dt))-std::exp(-a_*t))*(std::exp(2*a_*t)-1);
		refRateData_[z_]=(-1/dt) * (lnA-B*x0);

		if (z_==n-2){
			Real A=(h_->discount(t+dt+dt) /savedDiscountData_[n-1]) * std::exp(
			B*savedForwardData_[n-1]-((sigma_*sigma_)/(4*a_))*(1-std::exp(-2*a_*t)*B*B)
			);
		Real lnA=std::log(savedDiscountData_[z_+1]/savedDiscountData_[n-1])+
			B*savedForwardData_[n-1]-((sigma_*sigma_)/(4*a_*a_*a_))*
			(std::exp(-a_*(t+dt))-std::exp(-a_*t))*(std::exp(2*a_*t)-1);
		refRateData_[n-1]=(-1/dt) * (lnA-B*x0);
	
		}

	}*/

	const Array& HullWhiteProcess::getForwardData() const{
		return savedForwardData_;
	}
	const Array& HullWhiteProcess::getDiscountData() const{
		return savedDiscountData_;
	}
	const Array& HullWhiteProcess::getDiscountTData() const{
		return savedDiscountDataT_;
	}



	// HullWhiteForwardProcess

    HullWhiteForwardProcess::HullWhiteForwardProcess(
                                          const Handle<YieldTermStructure>& h,
                                          Real a,
                                          Real sigma)
    : process_(new OrnsteinUhlenbeckProcess(
                   a, sigma, h->forwardRate(0.0,0.0,Continuous,NoFrequency))),
      h_(h), a_(a), sigma_(sigma) {}

    Real HullWhiteForwardProcess::x0() const {
        return process_->x0();
    }

    Real HullWhiteForwardProcess::drift(Time t, Real x) const {
        Real alpha_drift = sigma_*sigma_/(2*a_)*(1-std::exp(-2*a_*t));
        Real shift = 0.0001;
        Real f = h_->forwardRate(t, t, Continuous, NoFrequency);
        Real fup = h_->forwardRate(t+shift, t+shift, Continuous, NoFrequency);
        Real f_prime = (fup-f)/shift;
        alpha_drift += a_*f+f_prime;
        return process_->drift(t, x) + alpha_drift - B(t, T_)*sigma_*sigma_;
    }

    Real HullWhiteForwardProcess::diffusion(Time t, Real x) const{
        return process_->diffusion(t, x);
    }

    Real HullWhiteForwardProcess::expectation(Time t0, Real x0,
                                              Time dt) const {
        return process_->expectation(t0, x0, dt)
             + alpha(t0 + dt) - alpha(t0)*std::exp(-a_*dt)
             - M_T(t0, t0+dt, T_);
    }

    Real HullWhiteForwardProcess::stdDeviation(Time t0, Real x0,
                                               Time dt) const {
        return process_->stdDeviation(t0, x0, dt);
    }

    Real HullWhiteForwardProcess::variance(Time t0, Real x0, Time dt) const{
        return process_->variance(t0, x0, dt);
    }

    Real HullWhiteForwardProcess::alpha(Time t) const {
        Real alfa = a_ > QL_EPSILON ?
                    (sigma_/a_)*(1 - std::exp(-a_*t)) :
                    sigma_*t;
        alfa *= 0.5*alfa;
        alfa += h_->forwardRate(t, t, Continuous, NoFrequency);

        return alfa;
    }

    Real HullWhiteForwardProcess::M_T(Real s, Real t, Real T) const {
        if (a_ > QL_EPSILON) {
            Real coeff = (sigma_*sigma_)/(a_*a_);
            Real exp1 = std::exp(-a_*(t-s));
            Real exp2 = std::exp(-a_*(T-t));
            Real exp3 = std::exp(-a_*(T+t-2.0*s));
            return coeff*(1-exp1)-0.5*coeff*(exp2-exp3);
        } else {
            // low-a algebraic limit
            Real coeff = (sigma_*sigma_)/2.0;
            return coeff*(t-s)*(2.0*T-t-s);
        }
    }

    Real HullWhiteForwardProcess::B(Time t, Time T) const {
        return a_ > QL_EPSILON ?
               1/a_ * (1-std::exp(-a_*(T-t))) :
               T-t;
    }

    Real HullWhiteForwardProcess::a() const {
        return a_;
    }

    Real HullWhiteForwardProcess::sigma() const {
        return sigma_;
    }

	Time HullWhiteForwardProcess::time(const Date& d) const {
        return h_->dayCounter().yearFraction(
                                           h_->referenceDate(), d);
    }


}

