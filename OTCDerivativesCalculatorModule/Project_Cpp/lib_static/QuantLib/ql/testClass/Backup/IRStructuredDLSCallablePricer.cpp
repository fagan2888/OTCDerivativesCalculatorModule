/* -*- mode: c++; tab-width: 4; indent-tabs-mode: nil; c-basic-offset: 4 -*- */

/*
 Copyright (C) 2009 Andrea Odetti

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

#include "IRStructuredDLSCallablePricer.hpp"
#include <ql/utilities/tracing.hpp>
#include <iostream>

namespace QuantLib {

    IRStructuredDLSCallablePricer::PathInfo::PathInfo(Size numberOfTimes)
        : payments(numberOfTimes, 0.0),
          exercises(numberOfTimes, 0.0),
          states(numberOfTimes) {
    }

    Size IRStructuredDLSCallablePricer::PathInfo::pathLength() const {
        return states.size();
    }


    IRStructuredDLSCallablePricer::IRStructuredDLSCallablePricer(
        const boost::shared_ptr<PayoffLeg>& payoff,
        const std::vector<Size> & timePositions,
        const boost::shared_ptr<StochasticProcessArray>& process,
        const Array & discounts,
		std::vector<Statistics>& additionalStats,
        Size polynomOrder,
        LsmBasisSystem::PolynomType polynomType)
    : calibrationPhase_(true),
      payoff_(payoff),
      coeff_     (new Array[timePositions.size() - 1]),
      lowerBounds_(new Real[timePositions.size()]),
      timePositions_(timePositions),
	  process_(process),
      dF_        (discounts),
	  additionalStats_(additionalStats),
	  earlyExProbability_(additionalStats.size()),
      v_         (LsmBasisSystem::multiPathBasisSystem(process->size(),
                                                       polynomOrder,
                                                       polynomType)) {
        QL_REQUIRE(   polynomType == LsmBasisSystem::Monomial
                   || polynomType == LsmBasisSystem::Laguerre
                   || polynomType == LsmBasisSystem::Hermite
                   || polynomType == LsmBasisSystem::Hyperbolic
                   || polynomType == LsmBasisSystem::Chebyshev2nd,
                   "insufficient polynom type");
		dummydF_=Array(discounts.size(),1.0);

		for(Size i=1;i<discounts.size();++i)
			dummydF_[i]=discounts[i-1];
	
		expectedBondPrice_=0.0;


    }

    /*
      Extract the relevant information from the whole path
     */
    IRStructuredDLSCallablePricer::PathInfo 
    IRStructuredDLSCallablePricer::transformPath(const MultiPath& multiPath)
    const {
        const Size numberOfAssets = multiPath.assetNumber();
        const Size numberOfTimes = timePositions_.size();

        Matrix path(numberOfAssets, numberOfTimes, Null<Real>());

        //for (Size i = 0; i < numberOfTimes; ++i) {
        //    const Size pos = timePositions_[i];
        //    for (Size j = 0; j < numberOfAssets; ++j)
        //        path[j][i] = multiPath[j][pos];
        //}

        for (Size i = 0; i <numberOfTimes; ++i) {
            const Size pos = timePositions_[i];

            for (Size j = 0; j < numberOfAssets; ++j)
				path[j][i] = process_->process(j)->indexAdjustment(multiPath[j][pos],pos);
        }

		Real nominal=payoff_->nominal();
        PathInfo info(numberOfTimes);

        payoff_->value(path, info.payments, info.exercises, info.states);
		
			Real discountedBondValue=0.0;
			/*std::cout << " Coupon : " << std::endl;
			for(Size i=0;i<numberOfTimes;i++){
				std::cout << "["<< i << "] "<< info.payments[i] <<  " - " ;
				std::cout << std::endl;
			}
			
			std::cout << " Bond   : " << std::endl ;*/
			for(Size i=1;i<numberOfTimes;i++){
				
				/*discountedBondValue = std::inner_product(info.payments.begin()+i,info.payments.end(),
														dF_.begin()+i,nominal*dF_.back())/dummydF_[i];*/
				discountedBondValue = std::inner_product(info.payments.begin()+i,info.payments.end(),
														dF_.begin()+i,nominal*dF_.back())/dummydF_[i];
				info.exercises[i-1] = std::max( discountedBondValue - nominal, 0.0);
				/*std::cout << "["<< i << "] "<< discountedBondValue <<  " - " ;
				std::cout << std::endl;*/
			}
			/*std::cout << " df : " << std::endl;
			for(Size i=0;i<numberOfTimes;i++){
				std::cout << "["<< i << "] "<< dF_[i] <<  " - " << std::endl;
				
			}
			std::cout << " states : " << std::endl ;
			for(Size i=0;i<numberOfTimes;i++){
				
				std::cout << "["<< i << "] "<< info.states[i][0] <<  " - " ;
				std::cout << "["<< i << "] "<< info.states[i][1] <<  " - " << std::endl;
			}
			std::cout << std::endl;*/
			expectedBondPrice_+=std::inner_product(info.payments.begin(),info.payments.end(),
														dF_.begin(),nominal*dF_.back());;
			//std::cout << " coupon["<< i <<"] : "<<discountedBondValue << std::endl;
			//std::cout << " bond Price: "<<discountedBondValue << std::endl;
			//std::cout << std::endl;

        return info;
    }

    Real IRStructuredDLSCallablePricer::operator()(
                                            const MultiPath& multiPath) const {
        PathInfo path = transformPath(multiPath);

        if (calibrationPhase_) {
            // store paths for the calibration
            // only the relevant part
            paths_.push_back(path);
            // result doesn't matter
            return 0.0;
        }

        // exercise at time t, cancels all payment AFTER t
		Real nominal=payoff_->nominal();
        const Size len = path.pathLength();
        Real price = 0.0;
		Size exerciseTimeFlag=len - 1;

        // this is the last event date
        {
            const Real payoff = path.payments[len - 1];
            const Real exercise = path.exercises[len - 1];
            const Array & states = path.states[len - 1];
            //이거 처리 생각 ㄱㄱ
			const bool canExercise = true;//!states.empty();

            // at the end the continuation value is 0.0
            //if (exercise > nominal)
                price += exercise;
            //price += payoff;
					
			//additionalStats_[len - 1].add(payoff);
		
        }

        for (Integer i = len - 2; i >= 0; --i) {
            price *= dF_[i + 1] / dF_[i];

            const Real exercise = path.exercises[i];

            /*
              coeff_[i].size()
              - 0 => never exercise
              - v_.size() => use estimated continuation value 
                (if > lowerBounds_[i])
              - v_.size() + 1 => always exercise

              In any case if states is empty, no exercise is allowed.
             */
			/*Real a[3];
			Real b[3];
			*/

            const Array & states = path.states[i];
            const bool canExercise = true;//!states.empty();

            if (canExercise) {
                //if (coeff_[i].size() == v_.size() + 1) {   
                //    // special value always exercise -> ?
                //    price = exercise;
                //}
                //{
				if (!coeff_[i].empty() && exercise > 0.0) {//lowerBounds_[i]) {
                    
                    Real continuationValue = 0.0;
					
					/*a[0]=coeff_[i][0];
					a[1]=coeff_[i][1];
					a[2]=coeff_[i][2];

					b[0]=v_[0](states);
					b[1]=v_[1](states);
					b[2]=v_[2](states);*/

                    for (Size l = 0; l < v_.size(); ++l) {
                        continuationValue += coeff_[i][l] * v_[l](states);
                    }
                    
                    if ( exercise > continuationValue) {
						price = exercise;
						exerciseTimeFlag=i;
						 
                    }
                }
                //}
            }
            //const Real payoff = path.payments[i];
            //price += payoff;
			//additionalStats_[i].add(payoff);

        }

		
		earlyExProbability_[exerciseTimeFlag] += 1.0;

		for(Size i = 0;i<len;++i){
			if(i<exerciseTimeFlag){
				additionalStats_[i].add(path.payments[i]);
			}
			else if(i==exerciseTimeFlag){
				additionalStats_[i].add(path.payments[i]+nominal);
			}
			else{
				additionalStats_[i].add(0.0);
			}
		}
		//std::cout << "price : " << price * dF_[0] << std::endl;
        return price * dF_[0];
    }

    void IRStructuredDLSCallablePricer::calibrate() {
        const Size n = paths_.size(); // number of paths
        Array prices(n, 0.0), exercise(n, 0.0);

        const Size basisDimension = process_->size();

        const Size len = paths_[0].pathLength();

        /*
          We try to estimate the lower bound of the continuation value,
          so that only itm paths contribute to the regression.
         */
		const bool canExercise = true;//!states.empty();
        for (Size j = 0; j < n; ++j) {
            const Real payoff = paths_[j].payments[len - 1];
            const Real exercise = paths_[j].exercises[len - 1];
            const Array & states = paths_[j].states[len - 1];
            

            // at the end the continuation value is 0.0
            if (canExercise && exercise > 0.0)
                prices[j] += exercise;
            //prices[j] += payoff;
        }

        lowerBounds_[len - 1] = *std::min_element(prices.begin(), prices.end());

        std::vector<bool> lsExercise(n);

        for (Integer i = len - 2 ; i >= 0; --i) {
            std::vector<Real>  y;
            std::vector<Array> x;

            // prices are discounted up to time i
            const Real discountRatio = dF_[i + 1] / dF_[i];
            prices *= discountRatio;
            lowerBounds_[i + 1] *= discountRatio;

            //roll back step
            for (Size j = 0; j < n; ++j) {
                exercise[j] = paths_[j].exercises[i];

                // If states is empty, no exercise in this path
                // and the path will not partecipate to the Lesat Square regression

                const Array & states = paths_[j].states[i];
                QL_REQUIRE(states.empty() || states.size() == basisDimension, 
                           "Invalid size of basis system");

                // only paths that could potentially create exercise opportunities
                // partecipate to the regression

                // if exercise is lower than minimum continuation value, no point in considering it
				if (canExercise && exercise[j] > 0.0 ) {//lowerBounds_[i + 1]) {
                    x.push_back(states);
                    y.push_back(prices[j]);
                }

				//const Real payoff = paths_[j].payments[i];
				//prices[j] += payoff;	

            }
	/*		Real a[3];
			Real b[3];
			Real c[3];*/

            if (v_.size() <=  x.size()) {
                coeff_[i] = LinearLeastSquaresRegression<Array>(x, y, v_)
                                                            .coefficients();
			/*	a[0]=coeff_[i][0];
				a[1]=coeff_[i][1];
				a[2]=coeff_[i][2];*/
            }
            else {
            // if number of itm paths is smaller then the number of
            // calibration functions -> never exercise
                QL_TRACE("Not enough itm paths: default decision is NEVER");
                coeff_[i] = Array(0);
            }

            /* attempt to avoid static arbitrage given by always or never exercising.

               always is absolute: regardless of the lowerBoundContinuationValue_ (this could be changed)
               but it still honours "canExercise"
             */

		}
        // remove calibration paths
        paths_.clear();
        // entering the calculation phase
		calibrationPhase_ = false;
		expectedBondPrice_=0.0;
		
	}

}
