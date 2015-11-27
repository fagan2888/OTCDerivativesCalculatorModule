/* -*- mode: c++; tab-width: 4; indent-tabs-mode: nil; c-basic-offset: 4 -*- */

/*
 Copyright (C) 2008 Andrea Odetti

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

/*! \file MCELSGeneralEngine.hpp
    \brief Path-dependent European basket MC engine
*/ 

#ifndef quantlib_mc_els_general_engine_hpp
#define quantlib_mc_els_general_engine_hpp

#include <ql/processes/stochasticprocessarray.hpp>
#include <ql/timegrid.hpp>
#include <ql/cashflows/simplecashflow.hpp>
#include <ql/cashflows/cashflows.hpp>
#include <ql/testClass/EquityLinkedSecurity.hpp>
#include <ql/testClass/ELSStepDown.hpp>
#include <ql/testClass/ELSStepDownPricer.hpp>
#include <ql/testClass/ELSGeneralPricer.hpp>
#include <ql/testClass/checkKIType.hpp>
#include <ql/testClass/sethistoryparametor.hpp>
#include <ql/termstructures/yieldtermstructure.hpp>
#include <iostream>

namespace QuantLib {

    //! Pricing engine for path dependent basket options using
    //  Monte Carlo simulation
    class MCELSGeneralEngine  : public ELSStepDown::engine , 
								public SetHistoryParametor
	{
      public:
        // constructor
        MCELSGeneralEngine(const boost::shared_ptr<StochasticProcessArray>& process,
						   const Handle<YieldTermStructure> & discountTS,
                           Size maxSamples,
						   BigNatural seed);
		
		// historyCal을 위한 method
		void setProcess(const boost::shared_ptr<StochasticProcessArray>& process) const{
			QL_REQUIRE(process_->size() == process->size() , "Instrument process size is " << process_->size() << " but Input process size is " << process->size());
			process_=process;}
		//여기서는 종합된 거 던질뿐.
        void calculate() const {
			
			for(Size i=0;i<additionalStats_.size();++i) {
				additionalStats_[i].reset();
			}
			
  /*          McSimulation<MultiVariate,RNG,S>::calculate(requiredTolerance_,
                                                        requiredSamples_,
                                                        maxSamples_);*/

			//loop
			//random
			pathPricer_=pathPricer();
			


			results_.value = this->arguments_.notional*pathPricer_->values(maxSamples_);

			results_.additionalResults["unitPrice"]=10000*(results_.value)/(this->arguments_.notional);

			results_.additionalResults["Delta"]=pathPricer_->delta();
			results_.additionalResults["Gamma"]=pathPricer_->gamma();
			results_.additionalResults["Vega"]=pathPricer_->vega();

			results_.additionalResults["Sup"]=pathPricer_->Sup();
			results_.additionalResults["SDown"]=pathPricer_->SDown();
			results_.additionalResults["VolUp"]=pathPricer_->VolUp();
			results_.additionalResults["VolDown"]=pathPricer_->VolDown();

			results_.additionalResults["step_h"]=pathPricer_->step_h();

			std::vector<Real> earlyExProbability(additionalStats_.size());
			std::vector<Real> expectedRedem(additionalStats_.size());

			for(Size i=0;i<additionalStats_.size();++i) {
				earlyExProbability[i]=static_cast<Real>(additionalStats_[i].samples())/static_cast<Real>(maxSamples_);
				if(additionalStats_[i].samples()==0){
					expectedRedem[i]=0.0;
				}else{
					expectedRedem[i]=additionalStats_[i].mean()*earlyExProbability[i];
				}
			}
			
			results_.additionalResults["underlyingValue"]=underlyingValue_;
			results_.additionalResults["earlyExProbability"]=earlyExProbability;
			results_.additionalResults["initialValues"]=this->arguments_.initialValues;
			results_.additionalResults["dividends"]=this->arguments_.dividends;
			results_.additionalResults["remainFixings"]=this->arguments_.fixingDates;
			results_.additionalResults["expectedRedem"]=expectedRedem;
			results_.additionalResults["DiscountCurveForSwap"]=discountTS_;			

			
            /*results_.value = this->mcModel_->sampleAccumulator().mean();

            if (RNG::allowsErrorEstimate)
                results_.errorEstimate =
                    this->mcModel_->sampleAccumulator().errorEstimate();*/
			
			
        }

      protected:

        // McSimulation implementation
        TimeGrid timeGrid() const;
		boost::shared_ptr<ELSGeneralPricer> pathPricer() const;

        // data members
        mutable boost::shared_ptr<StochasticProcessArray> process_;
		Handle<YieldTermStructure> discountTS_;
        Size timeSteps_;
        Size timeStepsPerYear_;
        Size maxSamples_;
        BigNatural seed_;
		mutable std::vector<Statistics> additionalStats_;
		mutable boost::shared_ptr<ELSGeneralPricer> pathPricer_;

		std::vector<Statistics> resultAccumulators;
		mutable std::vector<Real> underlyingValue_;
		
    };

}


#endif
