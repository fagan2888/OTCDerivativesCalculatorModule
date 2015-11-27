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
		swapTenorDt_=0.5;       //years(6M); swap Tenor 6M 고정
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
		swapTenorDt_=0.5;       //years(6M); swap Tenor 6M 고정
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
	
	Real HullWhiteProcess::forwardRate(Time t) const{
		
		return h_->forwardRate(t, t, Continuous, NoFrequency);
		
	}
	
	// Customized by Ansang (2011-12-02)
	// 저장된 데이터를 사용하기 위한 인터페이스

	void HullWhiteProcess::setPreCalculation(const TimeGrid& timeGrid) const{

		//std::cout << "calculating setTforwardRate in HullWhiteProcess class....." <<std::endl;
		tenorDt_=years(tenor_); //수정 필요 0.25 고정


		Size gridNum=timeGrid.size();
		Size swapTenorNum=static_cast<Size>(tenorDt_*2); // 정수 이외의 숫자 처리..?

		Array paraA_node(swapTenorNum,0.0);
		paraCMSB_=Array(swapTenorNum,0.0);
		paraA_=std::vector<Array>(gridNum,Array(swapTenorNum));
		
		paraLnA_=Array(gridNum,0.0);
		savedDrift_=Array(gridNum,0.0);
		savedVol_=Array(gridNum,0.0);
		multiple_=Array(gridNum,0.0);
		
		Array time=Array(gridNum,0.0);
		Array ForwardData=Array(gridNum,0.0);
		Array DiscountData=Array(gridNum,0.0);
		Array DiscountDataT=Array(gridNum,0.0);
		
		paraCMTB_=(1-std::exp(-a_*tenorDt_))/a_;

			time[0]=timeGrid[0];
			
			ForwardData[0]=h_->forwardRate(time[0], timeGrid[0]+0.01, Continuous, NoFrequency);
			DiscountData[0]=h_->discount(time[0]);
			DiscountDataT[0]=h_->discount(time[0]+tenorDt_);

			paraLnA_[0]=std::log(DiscountDataT[0]/DiscountData[0])+
			paraCMTB_*ForwardData[0]-((sigma_*sigma_)/(4*a_*a_*a_))*
			(std::exp(-a_*(time[0]+tenorDt_))-std::exp(-a_*time[0]))*(std::exp(-a_*(time[0]+tenorDt_))-std::exp(-a_*time[0]))
			*(std::exp(2*a_*time[0])-1);
			
			for(Size j=0;j<swapTenorNum;++j){
				paraCMSB_[j]=(1/a_)*(1-std::exp(-a_*(j+1)*swapTenorDt_));
				paraA_node[j]=(h_->discount(time[0]+(j+1)*swapTenorDt_))/h_->discount(time[0])
					*std::exp(paraCMSB_[j]*ForwardData[0]-(sigma_*sigma_/(4*a_))*(1-std::exp(-2*a_*time[j]))*paraCMSB_[j]*paraCMSB_[j]) ;
			}

			paraA_[0]=paraA_node;

			savedDrift_[0]=10000;
			savedVol_[0]=10000;
			multiple_[0]=10000;



		for(Size i=1 ;i < gridNum ; i++){
				
			time[i]=timeGrid[i];
			
			ForwardData[i]=h_->forwardRate(time[i], time[i]+0.01, Continuous, NoFrequency);
			DiscountData[i]=h_->discount(time[i]);
			DiscountDataT[i]=h_->discount(time[i]+tenorDt_);

			savedDrift_[i]=ForwardData[i]+( (1-std::exp(-a_*time[i]))*(1-std::exp(-a_*time[i])) )*(sigma_*sigma_)/(2*a_*a_)
				- ( ForwardData[i-1]+( (1-std::exp(-a_*time[i-1]))*(1-std::exp(-a_*time[i-1])) )*(sigma_*sigma_)/(2*a_*a_) ) * std::exp(-a_*timeGrid.dt(i-1)); // dt(i) 가 어디에서 어디 사이인가
			savedVol_[i]=std::pow((1-std::exp(-2*a_*timeGrid.dt(i-1)))*(sigma_*sigma_)/(2*a_),0.5);

			multiple_[i]=std::exp(-a_*timeGrid.dt(i-1));
			paraLnA_[i]=std::log(DiscountDataT[i]/DiscountData[i])+
			paraCMTB_*ForwardData[i]-((sigma_*sigma_)/(4*a_*a_*a_))*
			(std::exp(-a_*(time[i]+tenorDt_))-std::exp(-a_*time[i]))*(std::exp(-a_*(time[i]+tenorDt_))-std::exp(-a_*time[i]))
			*(std::exp(2*a_*time[i])-1);

			for(Size j=0;j<swapTenorNum;++j){
				paraCMSB_[j]=(1/a_)*(1-std::exp(-a_*(j+1)*swapTenorDt_));
				paraA_node[j]=(h_->discount(time[i]+(j+1)*swapTenorDt_))/h_->discount(time[i])
					*std::exp(paraCMSB_[j]*ForwardData[i]-(sigma_*sigma_/(4*a_))*(1-std::exp(-2*a_*time[j]))*paraCMSB_[j]*paraCMSB_[j]) ;
			}
			paraA_[i]=paraA_node;


		}
	}

    Real HullWhiteProcess::evolve(Time t0, Real x0,
                                     Time dt, Real dw) const {

		 return apply(expectation(t0,x0,dt), stdDeviation(t0,x0,dt)*dw);
    }

	void HullWhiteProcess::indexAdjustment(std::vector<Array>& path,std::vector<Real>& randz,IndexType type) const{
		
		std::vector<Real>::const_iterator randSeqIter = randz.begin();		
		const Size simul=path.size();
		const Size numberOfTimes=path[0].size();
		const Size paraCMSB_Num=paraCMSB_.size();

		QL_REQUIRE(randz.size()+1 > (simul*numberOfTimes),"not enough random variable");

		if(type==CMT){
			Real initialRate = (path[0][0] * tenorDt_ + paraLnA_[0]) / paraCMTB_; //path[0][0] 에 공시된 시작 이자율이며, 그걸 shortRate으로 변환하여 사용함.
			for(Size k=0;k<simul;++k){
				Real shortRate = initialRate;
				/*std::cout << "multiple_ : "<< multiple_ << std::endl;
				std::cout << "savedDrift_ : "<< savedDrift_ << std::endl;
				std::cout << "savedVol_ : "<< savedVol_ << std::endl;
				std::cout << "paraLnA_ : "<< paraLnA_ << std::endl;
				std::cout << "paraCMTB_ : "<< paraCMTB_ << std::endl;*/

				for(Size i=0;i<numberOfTimes;++i){
					shortRate=shortRate*multiple_[i+1]+savedDrift_[i+1]+savedVol_[i+1]*(*randSeqIter);
					path[k][i]= -(paraLnA_[i+1]-paraCMTB_*shortRate)/tenorDt_;
					//std::cout <<"shortRate : " << shortRate << "path : "<< path[k][i] << std::endl;
					randSeqIter++;
				}
				
			}
		}
		else if(type==CMS){
			CMSRate cmsRate(this,path[0][0]);
			Bisection solver=Bisection();
			
			Real initialRate = solver.solve(cmsRate,0.0001,path[0][0],path[0][0]-0.02,path[0][0]+0.02); //path[0][0] 에 공시된 시작 이자율이며, 그걸 shortRate으로 변환하여 사용함.
			for(Size k=0;k<simul;++k){
				Real shortRate = initialRate;
				for(Size i=0;i<numberOfTimes;++i){
					Real PtT=0.0;
					Real PtTsum=0.0;
					shortRate=shortRate*multiple_[i+1]+savedDrift_[i+1]+savedVol_[i+1]*(*randSeqIter);

					for(Size j=0;j<paraCMSB_Num;++j){
						PtT=paraA_[i+1][j]*std::exp(-paraCMSB_[j]*shortRate);
						PtTsum = PtTsum + PtT * swapTenorDt_;
					}

					path[k][i] = (1-PtT) / PtTsum;
					
					randSeqIter++;
				}
			}
		}

		else{QL_REQUIRE(false,"unknown Index type");}

		
	}
	
	Real HullWhiteProcess::CMSRate::operator()(Real x) const{
		const Size paraCMSB_Num=hw_->paraCMSB_.size();
		Real PtT=0.0;
		Real PtTsum=0.0;

		for(Size j=0;j<paraCMSB_Num;++j){
						PtT=hw_->paraA_[0][j]*std::exp(-hw_->paraCMSB_[j]*x);
						PtTsum = PtTsum + PtT * hw_->swapTenorDt_;
					}
		
		return (1-PtT) / PtTsum - initialX_;
	}
	/*Real HullWhiteProcess::evolveSaved(vector<Real>& x0,vector<Real> z) const{
		
		return (x0*multiple_[i]+savedDrift_[i]+savedVol_[i]*z);
	}*/


























	// HullWhiteForwardProcess -----------------------------------------------------------------------------

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

