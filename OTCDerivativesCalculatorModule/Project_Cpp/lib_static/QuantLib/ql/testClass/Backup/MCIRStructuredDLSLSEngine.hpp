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

/*! \file MCIRStructuredDLSLSEngine.hpp
    \brief Path-dependent European basket MC engine
*/

#ifndef quantlib_mc_structured_dls_callable_engine_hpp
#define quantlib_mc_structured_dls_callable_engine_hpp

#include <ql/pricingengines/mcsimulation.hpp>
#include <ql/instruments/basketoption.hpp>
#include <ql/processes/stochasticprocessarray.hpp>
//#include <ql/processes/hullwhiteprocess.hpp>
#include <ql/termstructures/yieldtermstructure.hpp>
#include <ql/timegrid.hpp>

#include "IRStructuredDLS.hpp"
#include "IRStructuredDLSCallablePricer.hpp"

#include <ql/cashflows/simplecashflow.hpp>
#include <ql/cashflows/cashflows.hpp>

#include <iostream>

using namespace QuantLib;

namespace QuantLib {
    template <class RNG = PseudoRandom, class S = Statistics>
    class MCIRStructuredDLSLSEngine : public IRStructuredDLS::engine,
                                public McSimulation<MultiVariate,RNG,S> {
      public:
        typedef typename McSimulation<MultiVariate,RNG,S>::path_generator_type
                                                          path_generator_type;
        typedef typename McSimulation<MultiVariate,RNG,S>::path_pricer_type
                                                             path_pricer_type;
        typedef typename McSimulation<MultiVariate,RNG,S>::stats_type
                                                                   stats_type;
        // constructor
        MCIRStructuredDLSLSEngine(const boost::shared_ptr<StochasticProcessArray>&,
						   const Handle<YieldTermStructure> & discountTS,
                           Size timeSteps,
                           Size timeStepsPerYear,
                           bool brownianBridge,
                           bool antitheticVariate,
                           bool controlVariate,
                           Size requiredSamples,
                           Real requiredTolerance,
                           Size maxSamples,
                           BigNatural seed,
						   Size nCalibrationSamples = 500);

        void calculate() const {

			for(Size i=0;i<additionalStats_.size();++i) {
				additionalStats_[i].reset();
			}

			pathPricer_ = this->lsmPathPricer();
			this->mcModel_ = boost::shared_ptr<MonteCarloModel<MultiVariate,RNG,S> >(
							  new MonteCarloModel<MultiVariate,RNG,S>
								  (pathGenerator(), pathPricer_,
								   stats_type(), this->antitheticVariate_));
			
			this->mcModel_->addSamples(nCalibrationSamples_);
			this->pathPricer_->calibrate();

			McSimulation<MultiVariate,RNG,S>::calculate(requiredTolerance_,
											  requiredSamples_,
											  maxSamples_);
			Real impliedCall = this->mcModel_->sampleAccumulator().mean();
			results_.additionalResults["ImpliedCall"] = impliedCall;

			if (RNG::allowsErrorEstimate) {
				this->results_.errorEstimate =
					this->mcModel_->sampleAccumulator().errorEstimate();
			}

			const std::vector<Date> & fixings=this->arguments_.fixingDates;
			Size sizeOfCouponNum=fixings.size();

			Leg expectedCashflows;
			Leg pastLeg = arguments_.payoffLeg->leg();
			expectedCashflows=pastLeg;

			std::vector<Real> cashflows(sizeOfCouponNum);
			std::vector<Real> cashflowsDates(sizeOfCouponNum);
			
			for(Size i=0;i<additionalStats_.size();++i) {
				expectedCashflows[sizeOfCouponNum-i-1]=boost::shared_ptr<CashFlow>(
							new SimpleCashFlow(additionalStats_[sizeOfCouponNum-i-1].mean(),fixings[sizeOfCouponNum-i-1]));
				cashflows[sizeOfCouponNum-i-1]=additionalStats_[sizeOfCouponNum-i-1].mean();
			
				//std::cout << additionalStats_[i].mean() << std::endl;
			}
			results_.additionalResults["cashflows"] = cashflows;
			for(Size i=0;i<sizeOfCouponNum;++i){
				cashflowsDates[i]=static_cast<Real>(fixings[i].serialNumber());
			}
			
			results_.additionalResults["cashflowsDates"] = cashflowsDates;
			//results_.additionalResults["EarlyExProbability"] = pathPricer_->earlyExProbability()/(this->mcModel_->sampleAccumulator().samples()) ;
			
			//pricer에서 Notional을 더해서옴. 언제 상환될지 모르므로...

			//Real Notional=arguments_.Notional;
			//expectedCashflows.push_back(boost::shared_ptr<CashFlow>(new SimpleCashFlow(Notional,fixings.back())));

			results_.expectedCashflows=expectedCashflows;
			//expected Bond Price도 넣어야하나..?

			QL_REQUIRE(!discountTS_.empty(),
					   "discounting term structure handle is empty");

			results_.valuationDate = Settings::instance().evaluationDate();
			
			bool includeRefDateFlows =false;

			results_.additionalResults["nonCallableValue"] = pathPricer_->expectedBondPrice()/(this->mcModel_->sampleAccumulator().weightSum());

			results_.value = CashFlows::npv(results_.expectedCashflows,
											**discountTS_,
											includeRefDateFlows,
											results_.valuationDate,
											results_.valuationDate);

			results_.settlementValue = CashFlows::npv(results_.expectedCashflows,
													  **discountTS_,
													  false,
													  arguments_.settlementDate,
													  arguments_.settlementDate);

		}

      protected:

        // McSimulation implementation
        TimeGrid timeGrid() const;
		boost::shared_ptr<IRStructuredDLSCallablePricer> 
											   lsmPathPricer() const;
        boost::shared_ptr<path_generator_type> pathGenerator() const;

        boost::shared_ptr<path_pricer_type> pathPricer() const{

			QL_REQUIRE(pathPricer_, "path pricer unknown");
			return pathPricer_;
		}

        // data members
		mutable boost::shared_ptr<IRStructuredDLSCallablePricer> pathPricer_;
        boost::shared_ptr<StochasticProcessArray> process_;
		Handle<YieldTermStructure> discountTS_;
        Size timeSteps_;
        Size timeStepsPerYear_;
        Size requiredSamples_;
        Size maxSamples_;
        Real requiredTolerance_;
        bool brownianBridge_;
        BigNatural seed_;
		Size nCalibrationSamples_;
		mutable std::vector<S> additionalStats_;
		std::vector<S> resultAccumulators;		

    };
	
    // template definitions
	
    template<class RNG, class S>
    inline MCIRStructuredDLSLSEngine<RNG,S>::MCIRStructuredDLSLSEngine(
             const boost::shared_ptr<StochasticProcessArray>& process,
			 const Handle<YieldTermStructure> & discountTS,
             Size timeSteps,
             Size timeStepsPerYear,
             bool brownianBridge,
             bool antitheticVariate,
             bool controlVariate,
             Size requiredSamples,
             Real requiredTolerance,
             Size maxSamples,
             BigNatural seed,
			 Size nCalibrationSamples)
    : McSimulation<MultiVariate,RNG,S>(antitheticVariate, controlVariate),
      process_(process), discountTS_(discountTS),timeSteps_(timeSteps), timeStepsPerYear_(timeStepsPerYear),
      requiredSamples_(requiredSamples), maxSamples_(maxSamples),
      requiredTolerance_(requiredTolerance),
      brownianBridge_(brownianBridge), seed_(seed),nCalibrationSamples_(nCalibrationSamples) {
        QL_REQUIRE(timeSteps != Null<Size>() ||
                   timeStepsPerYear != Null<Size>(),
                   "no time steps provided");
        QL_REQUIRE(timeSteps == Null<Size>() ||
                   timeStepsPerYear == Null<Size>(),
                   "both time steps and time steps per year were provided");
        QL_REQUIRE(timeSteps != 0,
                   "timeSteps must be positive, " << timeSteps <<
                   " not allowed");
        QL_REQUIRE(timeStepsPerYear != 0,
                   "timeStepsPerYear must be positive, "
                   << timeStepsPerYear << " not allowed");
		QL_REQUIRE(nCalibrationSamples > 0,
                   "nCalibrationSamples must be strict positive, "
                   << nCalibrationSamples << " not allowed");
		QL_REQUIRE(discountTS_->referenceDate() == Settings::instance().evaluationDate(),
					"TS's referenceDate("<< discountTS_->referenceDate() <<") isn't same to evaluationDate("
					<< Settings::instance().evaluationDate() <<")");
        this->registerWith(process_);
    }

    

    template<class RNG, class S>
    inline
    boost::shared_ptr<typename MCIRStructuredDLSLSEngine<RNG,S>::path_generator_type>
    MCIRStructuredDLSLSEngine<RNG,S>::pathGenerator() const {

        boost::shared_ptr<PayoffLeg> payoffLeg = arguments_.payoffLeg;
		
        QL_REQUIRE(payoffLeg, "IRStructuredDLS payoffLeg given");

		Size numAssets = process_->size();
				
		QL_REQUIRE(arguments_.refIndexTenor.size()==process_->size(),
				"Process Size (" << numAssets << ") must be Same to IndexSize (" << arguments_.refIndexTenor.size() << ")");

		for(Size i=0 ; i<numAssets ; ++i){
			QL_REQUIRE(arguments_.refIndexTenor[i]==process_->process(i)->tenor(), 
				"Process Tenor must be Same to refIndex Tenor");
		}

		TimeGrid grid = timeGrid();

		for(Size i=0 ; i<numAssets ; ++i){
			process_->process(i)->setPreCalculation(grid); // 속도를 위해 수정되었음.
		}
		
        typename RNG::rsg_type gen =
            RNG::make_sequence_generator(numAssets * (grid.size() - 1), seed_);

        return boost::shared_ptr<path_generator_type>(
                         new path_generator_type(process_,
                                                 grid, gen, brownianBridge_));
    }

    template <class RNG, class S>
    inline TimeGrid MCIRStructuredDLSLSEngine<RNG,S>::timeGrid() const {
        const std::vector<Date> & fixings = this->arguments_.fixingDates;

		std::vector<Date> remainfixings;
		Date today = Settings::instance().evaluationDate();
		
		const Size numberOfFixings = fixings.size();

		for(Size i=0;i<numberOfFixings;++i){
			if(fixings[i]>today){
				remainfixings.push_back(fixings[i]);
			}
		}
        
		const Size numberOfRemainFixings = remainfixings.size();

        std::vector<Time> fixingTimes;//(numberOfFixings);
        for (Size i = 0; i < numberOfRemainFixings; ++i) {
            if(remainfixings[i]>today){
				fixingTimes.push_back(discountTS_->dayCounter().yearFraction(
                                           today, remainfixings[i]));
			}
        }
		
        const Size numberOfTimeSteps = timeSteps_ != Null<Size>() ? timeSteps_ : timeStepsPerYear_ * static_cast<int>(fixingTimes.back());
		
        return TimeGrid(fixingTimes.begin(), fixingTimes.end(), numberOfTimeSteps);
    }	



	template<class RNG, class S>
    inline boost::shared_ptr<IRStructuredDLSCallablePricer>
    MCIRStructuredDLSLSEngine<RNG,S>::lsmPathPricer() const {
		
        boost::shared_ptr<StochasticProcessArray> processArray =
            boost::dynamic_pointer_cast<StochasticProcessArray>(this->process_);
        QL_REQUIRE(processArray && processArray->size()>0,
                   "Stochastic process array required");


		boost::shared_ptr<PayoffLeg> payoffLeg = arguments_.payoffLeg;
        QL_REQUIRE(payoffLeg, "IRStructuredDLS payoffLeg given");

		//const Handle<YieldTermStructure> &df=arguments_.df;
		//Frequency freq = arguments_.freq;

        const TimeGrid theTimeGrid = this->timeGrid();

        const std::vector<Time> & times = theTimeGrid.mandatoryTimes();
        const Size numberOfTimes = times.size();

        const std::vector<Date> & fixings = this->arguments_.fixingDates;
		std::vector<Date> remainfixings;

		Date today = Settings::instance().evaluationDate();
		const Size numberOfFixings = fixings.size();
		for(Size i=0;i<numberOfFixings;++i){
			if(fixings[i]>today){
				remainfixings.push_back(fixings[i]);
			}
		}
        const Size numberOfRemainFixings = remainfixings.size();

		additionalStats_.resize(numberOfTimes);

        QL_REQUIRE(numberOfRemainFixings == numberOfTimes, "Invalid dates/times");

        std::vector<Size> timePositions(numberOfTimes);
        Array discountFactors(numberOfTimes);
        //std::vector<Handle<YieldTermStructure> > forwardTermStructures(numberOfTimes);

        //const Handle<YieldTermStructure> & riskFreeRate = process->riskFreeRate();

		for (Size i = 0; i < numberOfTimes; ++i){
            timePositions[i] = theTimeGrid.index(times[i]);
            discountFactors[i] = discountTS_->discount(times[i]);
		}
          //  forwardTermStructures[i] = Handle<YieldTermStructure>(
            //            new ImpliedTermStructure(riskFreeRate, fixings[i]));
        

        const Size polynomialOrder = 2;
        const LsmBasisSystem::PolynomType polynomType = LsmBasisSystem::Monomial;

        return boost::shared_ptr<IRStructuredDLSCallablePricer> (
            new IRStructuredDLSCallablePricer(	 payoffLeg,
                                                 timePositions,
												 process_,
												 discountFactors,
												 additionalStats_,
                                                 polynomialOrder,
                                                 polynomType));
    }
    //! Monte Carlo Path Basket engine factory
    template <class RNG = PseudoRandom, class S = Statistics>
    class MakeMCIRStructuredDLSLSEngine {
      public:
        MakeMCIRStructuredDLSLSEngine(const boost::shared_ptr<StochasticProcessArray>&);
        // named parameters
        MakeMCIRStructuredDLSLSEngine& withSteps(Size steps);
        MakeMCIRStructuredDLSLSEngine& withStepsPerYear(Size steps);
        MakeMCIRStructuredDLSLSEngine& withBrownianBridge(bool b = true);
        MakeMCIRStructuredDLSLSEngine& withSamples(Size samples);
        MakeMCIRStructuredDLSLSEngine& withAbsoluteTolerance(Real tolerance);
        MakeMCIRStructuredDLSLSEngine& withMaxSamples(Size samples);
        MakeMCIRStructuredDLSLSEngine& withSeed(BigNatural seed);
        MakeMCIRStructuredDLSLSEngine& withAntitheticVariate(bool b = true);
        MakeMCIRStructuredDLSLSEngine& withControlVariate(bool b = true);
        // conversion to pricing engine
        operator boost::shared_ptr<PricingEngine>() const;
      private:
        boost::shared_ptr<StochasticProcessArray> process_;
        bool antithetic_, controlVariate_;
        Size steps_, stepsPerYear_, samples_, maxSamples_;
        Real tolerance_;
        bool brownianBridge_;
        BigNatural seed_;
		//discountTS_;
    };

    template <class RNG, class S>
    inline MakeMCIRStructuredDLSLSEngine<RNG,S>::MakeMCIRStructuredDLSLSEngine(
        const boost::shared_ptr<StochasticProcessArray>& process)
    : process_(process),
      antithetic_(false), controlVariate_(false),
      steps_(Null<Size>()), stepsPerYear_(Null<Size>()),
      samples_(Null<Size>()), maxSamples_(Null<Size>()),
      tolerance_(Null<Real>()), brownianBridge_(false), seed_(0) {}

    template <class RNG, class S>
    inline MakeMCIRStructuredDLSLSEngine<RNG,S>&
    MakeMCIRStructuredDLSLSEngine<RNG,S>::withSteps(Size steps) {
        steps_ = steps;
        return *this;
    }

    template <class RNG, class S>
    inline MakeMCIRStructuredDLSLSEngine<RNG,S>&
    MakeMCIRStructuredDLSLSEngine<RNG,S>::withStepsPerYear(Size steps) {
        stepsPerYear_ = steps;
        return *this;
    }

    template <class RNG, class S>
    inline MakeMCIRStructuredDLSLSEngine<RNG,S>&
    MakeMCIRStructuredDLSLSEngine<RNG,S>::withSamples(Size samples) {
        QL_REQUIRE(tolerance_ == Null<Real>(),
                   "tolerance already set");
        samples_ = samples;
        return *this;
    }

    template <class RNG, class S>
    inline MakeMCIRStructuredDLSLSEngine<RNG,S>&
    MakeMCIRStructuredDLSLSEngine<RNG,S>::withAbsoluteTolerance(Real tolerance) {
        QL_REQUIRE(samples_ == Null<Size>(),
                   "number of samples already set");
        QL_REQUIRE(RNG::allowsErrorEstimate,
                   "chosen random generator policy "
                   "does not allow an error estimate");
        tolerance_ = tolerance;
        return *this;
    }

    template <class RNG, class S>
    inline MakeMCIRStructuredDLSLSEngine<RNG,S>&
    MakeMCIRStructuredDLSLSEngine<RNG,S>::withMaxSamples(Size samples) {
        maxSamples_ = samples;
        return *this;
    }

    template <class RNG, class S>
    inline MakeMCIRStructuredDLSLSEngine<RNG,S>&
    MakeMCIRStructuredDLSLSEngine<RNG,S>::withSeed(BigNatural seed) {
        seed_ = seed;
        return *this;
    }

    template <class RNG, class S>
    inline MakeMCIRStructuredDLSLSEngine<RNG,S>&
    MakeMCIRStructuredDLSLSEngine<RNG,S>::withBrownianBridge(bool brownianBridge) {
        brownianBridge_ = brownianBridge;
        return *this;
    }

    template <class RNG, class S>
    inline MakeMCIRStructuredDLSLSEngine<RNG,S>&
    MakeMCIRStructuredDLSLSEngine<RNG,S>::withAntitheticVariate(bool b) {
        antithetic_ = b;
        return *this;
    }

    template <class RNG, class S>
    inline MakeMCIRStructuredDLSLSEngine<RNG,S>&
    MakeMCIRStructuredDLSLSEngine<RNG,S>::withControlVariate(bool b) {
        controlVariate_ = b;
        return *this;
    }

    template <class RNG, class S>
    inline
    MakeMCIRStructuredDLSLSEngine<RNG,S>::operator boost::shared_ptr<PricingEngine>()
                                                                       const {
        return boost::shared_ptr<PricingEngine>(new
            MCIRStructuredDLSLSEngine<RNG,S>(process_,
									  discountTS_,
                                      steps_,
                                      stepsPerYear_,
                                      brownianBridge_,
                                      antithetic_,
                                      controlVariate_,
                                      samples_,
                                      tolerance_,
                                      maxSamples_,
                                      seed_));
    }

}


#endif
