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

/*! \file MCELSEngine.hpp
    \brief Path-dependent European basket MC engine
*/ 

#ifndef quantlib_mc_els_notionalProtectedengine_hpp
#define quantlib_mc_els_notionalProtectedengine_hpp

#include <ql/processes/stochasticprocessarray.hpp>
#include <ql/timegrid.hpp>
#include <ql/cashflows/simplecashflow.hpp>
#include <ql/cashflows/cashflows.hpp>
#include <ql/testClass/EquityLinkedSecurity.hpp>
#include <ql/testClass/ELSNotionalProtected.hpp>
#include <ql/testClass/ELSNotionalProtectedPricer.hpp>
#include <ql/termstructures/yieldtermstructure.hpp>
#include <iostream>
#include <ql/testClass/sethistoryparametor.hpp>

namespace QuantLib {

    //  Monte Carlo simulation
    class MCELSNotionalProtectedEngine  : public ELSNotionalProtected::engine ,
										  public SetHistoryParametor
	{
      public:
        // constructor
        MCELSNotionalProtectedEngine(const boost::shared_ptr<StochasticProcessArray>& process,
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
			
			pathPricer_=pathPricer();
			
			results_.value = this->arguments_.notional*(pathPricer_->values(maxSamples_)/maxSamples_);
			results_.additionalResults["unitPrice"]=10000*(results_.value)/(this->arguments_.notional);
			std::vector<Real> earlyExProbability(additionalStats_.size());
			for(Size i=0;i<additionalStats_.size();++i) {
				earlyExProbability[i]=static_cast<Real>(additionalStats_[i].samples())/static_cast<Real>(maxSamples_);
			}
			
			results_.additionalResults["underlyingValue"]=underlyingValue_;
			results_.additionalResults["earlyExProbability"]=earlyExProbability;
			results_.additionalResults["initialValues"]=this->arguments_.initialValues;
			results_.additionalResults["dividends"]=this->arguments_.dividends;
			results_.additionalResults["remainFixings"]=this->arguments_.fixingDates;
			
			
        }

      protected:

        // McSimulation implementation
        TimeGrid timeGrid() const;
		boost::shared_ptr<ELSNotionalProtectedPricer> pathPricer() const;

        // data members
        mutable boost::shared_ptr<StochasticProcessArray> process_;
		Handle<YieldTermStructure> discountTS_;
        Size timeSteps_;
        Size timeStepsPerYear_;
        Size maxSamples_;
        BigNatural seed_;
		mutable std::vector<Statistics> additionalStats_;
		mutable boost::shared_ptr<ELSNotionalProtectedPricer> pathPricer_;

		std::vector<Statistics> resultAccumulators;
		mutable std::vector<Real> underlyingValue_;
		
    };

}


#endif
