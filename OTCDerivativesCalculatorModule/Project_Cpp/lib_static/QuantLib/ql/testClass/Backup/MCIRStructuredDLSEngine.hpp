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

/*! \file MCIRStructuredDLSEngine.hpp
    \brief Path-dependent European basket MC engine
*/

#ifndef quantlib_mc_structured_dls_engine_hpp
#define quantlib_mc_structured_dls_engine_hpp

//#include <ql/experimental/mcbasket/pathmultiassetoption.hpp>
#include <ql/experimental/mcbasket/pathpayoff.hpp>
#include <ql/pricingengines/mcsimulation.hpp>
//#include <ql/processes/blackscholesprocess.hpp>
#include <ql/processes/stochasticprocessarray.hpp>
//#include <ql/termstructures/yield/impliedtermstructure.hpp>
#include <ql/timegrid.hpp>
//#include <ql/instruments/bond.hpp>
#include "IRStructuredDLS.hpp"
#include <ql/cashflows/simplecashflow.hpp>
#include <ql/cashflows/cashflows.hpp>

#include <iostream>

namespace QuantLib {

    //! Pricing engine for path dependent basket options using
    //  Monte Carlo simulation
    template <class RNG = PseudoRandom, class S = Statistics>
    class MCIRStructuredDLSEngine  : public IRStructuredDLS::engine,
                                public McSimulation<MultiVariate,RNG,S> {
      public:
        typedef typename McSimulation<MultiVariate,RNG,S>::path_generator_type
                                                          path_generator_type;
        typedef typename McSimulation<MultiVariate,RNG,S>::path_pricer_type
                                                             path_pricer_type;
        typedef typename McSimulation<MultiVariate,RNG,S>::stats_type
                                                                   stats_type;
        // constructor
        MCIRStructuredDLSEngine(const boost::shared_ptr<StochasticProcessArray>&,
						   const Handle<YieldTermStructure> & discountTS,
                           Size timeSteps,
                           Size timeStepsPerYear,
                           bool brownianBridge,
                           bool antitheticVariate,
                           bool controlVariate,
                           Size requiredSamples,
                           Real requiredTolerance,
                           Size maxSamples,
                           BigNatural seed);

		//여기서는 종합된거 던질뿐.
        void calculate() const {

			for(Size i=0;i<additionalStats_.size();++i) {
				additionalStats_[i].reset();
			}

			//이놈이 실제 계산해서 쌓아놓음.
            McSimulation<MultiVariate,RNG,S>::calculate(requiredTolerance_,
                                                        requiredSamples_,
                                                        maxSamples_);
			//value 떨구는건 McSimul에서 함 그 외에 잡다 결과물은 pricer에서 축정후 던져줌.

            results_.value = this->mcModel_->sampleAccumulator().mean();

            if (RNG::allowsErrorEstimate)
                results_.errorEstimate =
                    this->mcModel_->sampleAccumulator().errorEstimate();

			
			
			const std::vector<Date> & fixings=this->arguments_.fixingDates;
			Size sizeOfCouponNum=fixings.size();
		
			//Leg expectedCashflows(sizeOfCouponNum);
			Leg expectedCashflows;
			//과거꺼
			Leg pastLeg = arguments_.payoffLeg->leg();
			//각각의 통계량을 result에 붙이는 작업.
			//expectedCashflows.insert(expectedCashflows.begin(),pastLeg.begin(),pastLeg.end());
			expectedCashflows=pastLeg;
			std::vector<Real> cashflows(sizeOfCouponNum);
			std::vector<Real> cashflowsDates(sizeOfCouponNum);
			Real accruedAmount=0.0;

			for(Size i=0;i<additionalStats_.size();++i) {
				//additionalResults.insert(std::pair<Date,Real>(fixings[i],resultAccumulators[i].mean())) ;
				//results_.expectedCashflows[i]=boost::shared_ptr<CashFlow>(new SimpleCashFlow(additionalStats_[i].mean(),fixings[i]);
				
				//밀어넣기로 수정전.
				//expectedCashflows[i]=boost::shared_ptr<CashFlow>(new SimpleCashFlow(additionalStats_[i].mean(),fixings[i]));
				//arguments_.payoffLeg->leg().

				//expectedCashflows.push_back(boost::shared_ptr<CashFlow>(new SimpleCashFlow(additionalStats_[sizeOfCouponNum-i-1].mean(),fixings[sizeOfCouponNum-i-1])));

				expectedCashflows[sizeOfCouponNum-i-1]=boost::shared_ptr<CashFlow>(
							new SimpleCashFlow(additionalStats_[sizeOfCouponNum-i-1].mean(),fixings[sizeOfCouponNum-i-1]));
				cashflows[sizeOfCouponNum-i-1]=additionalStats_[sizeOfCouponNum-i-1].mean();


				//pastLeg[sizeOfCouponNum-i-1]->setCalRate(additionalStats_[sizeOfCouponNum-i-1].mean(),)

				//std::cout << additionalStats_[i].mean() << std::endl;
			}
			
			results_.additionalResults["cashflows"] = cashflows;
			for(Size i=0;i<sizeOfCouponNum;++i){
				cashflowsDates[i]=static_cast<Real>(fixings[i].serialNumber());
			}
			
			results_.additionalResults["cashflowsDates"] = cashflowsDates;
			//results_.additionalResults["accruedAmount"] = accruedAmount;

			Real Notional=arguments_.Notional;
			expectedCashflows.push_back(boost::shared_ptr<CashFlow>(new SimpleCashFlow(Notional,fixings.back())));
			//payments.back()=payments.back()+payoff_.back()->nominal();

			results_.expectedCashflows=expectedCashflows;
			
			//Leg는 이놈이 만들어서 떨궈주거나 Result에 leg만들어놓거 거기다가 박음.
			
			QL_REQUIRE(!discountTS_.empty(),
					   "discounting term structure handle is empty");

			results_.valuationDate = Settings::instance().evaluationDate();
			
			//기본적으로 우선 false로 놓자. 돈 받고 시작하는건 
			bool includeRefDateFlows =false;
				/*includeSettlementDateFlows_ ?
				*includeSettlementDateFlows_ :
				Settings::instance().includeReferenceDateCashFlows();*/

			results_.value = CashFlows::npv(results_.expectedCashflows,
											**discountTS_,
											includeRefDateFlows,
											results_.valuationDate,
											results_.valuationDate);

			// a bond's cashflow on settlement date is never taken into account
			results_.settlementValue = CashFlows::npv(results_.expectedCashflows,
													  **discountTS_,
													  false,
													  arguments_.settlementDate,
													  arguments_.settlementDate);
			
        }

      protected:

        // McSimulation implementation
        TimeGrid timeGrid() const;
        boost::shared_ptr<path_generator_type> pathGenerator() const;
        boost::shared_ptr<path_pricer_type> pathPricer() const;

        // data members
        boost::shared_ptr<StochasticProcessArray> process_;
		Handle<YieldTermStructure> discountTS_;
        Size timeSteps_;
        Size timeStepsPerYear_;
        Size requiredSamples_;
        Size maxSamples_;
        Real requiredTolerance_;
        bool brownianBridge_;
        BigNatural seed_;
		mutable std::vector<S> additionalStats_;

		//Bond
		//사용할 쿠폰을 담을 곳.


		//결과물을 담기위한 것 Pricer에서 담아줌.

		//boost::shared_ptr<CashFlow> mcCashFlow;
		std::vector<S> resultAccumulators;		 
		
    };


   class IRStructuredDLSPricer : public PathPricer<MultiPath> {
      public:
        IRStructuredDLSPricer(const boost::shared_ptr<PayoffLeg> & payoffLeg,
                             const std::vector<Size> & timePositions,
							 const boost::shared_ptr<StochasticProcessArray>& process,
                             const Array & discounts,
							 std::vector<Statistics>& additionalStats);
        Real operator()(const MultiPath& multiPath) const;

      private:
        boost::shared_ptr<PayoffLeg> payoffLeg_;
        std::vector<Size> timePositions_;
		boost::shared_ptr<StochasticProcessArray>  process_;
        //std::vector<Handle<YieldTermStructure> > forwardTermStructures_;
        Array discounts_;
		mutable std::vector<Statistics>& additionalStats_;
		Size countMe_;
    };


    // template definitions

    template<class RNG, class S>
    inline MCIRStructuredDLSEngine<RNG,S>::MCIRStructuredDLSEngine(
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
             BigNatural seed)
    : McSimulation<MultiVariate,RNG,S>(antitheticVariate, controlVariate),
      process_(process),discountTS_(discountTS), timeSteps_(timeSteps), timeStepsPerYear_(timeStepsPerYear),
      requiredSamples_(requiredSamples), maxSamples_(maxSamples),
      requiredTolerance_(requiredTolerance),
      brownianBridge_(brownianBridge), seed_(seed) {
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
		QL_REQUIRE(discountTS_->referenceDate() == Settings::instance().evaluationDate(),
					"TS's referenceDate("<< discountTS_->referenceDate() <<") isn't same to evaluationDate("
					<< Settings::instance().evaluationDate() <<")");
        this->registerWith(process_);
    }


    template<class RNG, class S>
    inline
    boost::shared_ptr<typename MCIRStructuredDLSEngine<RNG,S>::path_generator_type>
    MCIRStructuredDLSEngine<RNG,S>::pathGenerator() const {

        boost::shared_ptr<PayoffLeg> payoffLeg = arguments_.payoffLeg;
		//std::vector<Real> dt = arguments_.refIndexMaturity;

        QL_REQUIRE(payoffLeg, "IRStructuredDLS payoffLeg given");

        Size numAssets = process_->size();

		QL_REQUIRE(arguments_.refIndexTenor.size()==process_->size(),
				"Process Size must be Same to IndexSize");
		
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
    inline TimeGrid MCIRStructuredDLSEngine<RNG,S>::timeGrid() const {
        const std::vector<Date> & fixings = this->arguments_.fixingDates;
		const Size numberOfFixings = fixings.size();
		std::vector<Date> remainfixings;
		
		Date today = Settings::instance().evaluationDate();
		
		for(Size i=0;i<numberOfFixings;++i){
			if(fixings[i]>today){
				remainfixings.push_back(fixings[i]);
			}
		}
        const Size numberOfRemainFixings = remainfixings.size();


        std::vector<Time> fixingTimes;//(numberOfFixings); //이거 내가 추가한건가..?
        for (Size i = 0; i < numberOfRemainFixings; ++i) {
            //fixingTimes[i] = this->process_->time(fixings[i]);
			if(fixings[i]>today){
				fixingTimes.push_back(discountTS_->dayCounter().yearFraction(
                                           today, remainfixings[i]));
			}
        }

        const Size numberOfTimeSteps = timeSteps_ != Null<Size>() ? timeSteps_ : timeStepsPerYear_ * static_cast<int>(fixingTimes.back());

        //return TimeGrid(fixingTimes.begin(), fixingTimes.end(), numberOfTimeSteps);
		return TimeGrid(fixingTimes.begin(), fixingTimes.end(), numberOfTimeSteps);
    }

    template <class RNG, class S>
    inline
    boost::shared_ptr<typename MCIRStructuredDLSEngine<RNG,S>::path_pricer_type>
    MCIRStructuredDLSEngine<RNG,S>::pathPricer() const {

        boost::shared_ptr<PayoffLeg> payoffLeg = arguments_.payoffLeg;
        QL_REQUIRE(payoffLeg, "IRStructuredDLS payoffLeg given");

		

		//수정 필요.
        //boost::shared_ptr<GeneralizedBlackScholesProcess> process =
        //    boost::dynamic_pointer_cast<GeneralizedBlackScholesProcess>(
        //                                               process_->process(0));
        //QL_REQUIRE(process, "Black-Scholes process required");

        const TimeGrid theTimeGrid = timeGrid();

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
		
		// 쿠폰 statistics //추가 조기상환 확률 이딴거.
		//resultStatistics.resize(numberOfTimes);
		
		//sampleAccumulator();
        std::vector<Size> timePositions(numberOfTimes);
        Array discountFactors(numberOfTimes);

        for (Size i = 0; i < numberOfTimes; ++i) {
            timePositions[i] = theTimeGrid.index(times[i]);
            discountFactors[i] = discountTS_->discount(times[i]);
        }

        return boost::shared_ptr<
            typename MCIRStructuredDLSEngine<RNG,S>::path_pricer_type>(
                        new IRStructuredDLSPricer(payoffLeg, timePositions,process_,
                                                        discountFactors,additionalStats_));
    }


    //! Monte Carlo Path Basket engine factory
    template <class RNG = PseudoRandom, class S = Statistics>
    class MakeMCIRStructuredDLSEngine {
      public:
        MakeMCIRStructuredDLSEngine(const boost::shared_ptr<StochasticProcessArray>&);
        // named parameters
        MakeMCIRStructuredDLSEngine& withSteps(Size steps);
        MakeMCIRStructuredDLSEngine& withStepsPerYear(Size steps);
        MakeMCIRStructuredDLSEngine& withBrownianBridge(bool b = true);
        MakeMCIRStructuredDLSEngine& withSamples(Size samples);
        MakeMCIRStructuredDLSEngine& withAbsoluteTolerance(Real tolerance);
        MakeMCIRStructuredDLSEngine& withMaxSamples(Size samples);
        MakeMCIRStructuredDLSEngine& withSeed(BigNatural seed);
        MakeMCIRStructuredDLSEngine& withAntitheticVariate(bool b = true);
        MakeMCIRStructuredDLSEngine& withControlVariate(bool b = true);
        // conversion to pricing engine
        operator boost::shared_ptr<PricingEngine>() const;
      private:
        boost::shared_ptr<StochasticProcessArray> process_;
        bool antithetic_, controlVariate_;
        Size steps_, stepsPerYear_, samples_, maxSamples_;
        Real tolerance_;
        bool brownianBridge_;
        BigNatural seed_;
    };

    template <class RNG, class S>
    inline MakeMCIRStructuredDLSEngine<RNG,S>::MakeMCIRStructuredDLSEngine(
        const boost::shared_ptr<StochasticProcessArray>& process)
    : process_(process),
      antithetic_(false), controlVariate_(false),
      steps_(Null<Size>()), stepsPerYear_(Null<Size>()),
      samples_(Null<Size>()), maxSamples_(Null<Size>()),
      tolerance_(Null<Real>()), brownianBridge_(false), seed_(0) {}

    template <class RNG, class S>
    inline MakeMCIRStructuredDLSEngine<RNG,S>&
    MakeMCIRStructuredDLSEngine<RNG,S>::withSteps(Size steps) {
        steps_ = steps;
        return *this;
    }

    template <class RNG, class S>
    inline MakeMCIRStructuredDLSEngine<RNG,S>&
    MakeMCIRStructuredDLSEngine<RNG,S>::withStepsPerYear(Size steps) {
        stepsPerYear_ = steps;
        return *this;
    }

    template <class RNG, class S>
    inline MakeMCIRStructuredDLSEngine<RNG,S>&
    MakeMCIRStructuredDLSEngine<RNG,S>::withSamples(Size samples) {
        QL_REQUIRE(tolerance_ == Null<Real>(),
                   "tolerance already set");
        samples_ = samples;
        return *this;
    }

    template <class RNG, class S>
    inline MakeMCIRStructuredDLSEngine<RNG,S>&
    MakeMCIRStructuredDLSEngine<RNG,S>::withAbsoluteTolerance(Real tolerance) {
        QL_REQUIRE(samples_ == Null<Size>(),
                   "number of samples already set");
        QL_REQUIRE(RNG::allowsErrorEstimate,
                   "chosen random generator policy "
                   "does not allow an error estimate");
        tolerance_ = tolerance;
        return *this;
    }

    template <class RNG, class S>
    inline MakeMCIRStructuredDLSEngine<RNG,S>&
    MakeMCIRStructuredDLSEngine<RNG,S>::withMaxSamples(Size samples) {
        maxSamples_ = samples;
        return *this;
    }

    template <class RNG, class S>
    inline MakeMCIRStructuredDLSEngine<RNG,S>&
    MakeMCIRStructuredDLSEngine<RNG,S>::withSeed(BigNatural seed) {
        seed_ = seed;
        return *this;
    }

    template <class RNG, class S>
    inline MakeMCIRStructuredDLSEngine<RNG,S>&
    MakeMCIRStructuredDLSEngine<RNG,S>::withBrownianBridge(bool brownianBridge) {
        brownianBridge_ = brownianBridge;
        return *this;
    }

    template <class RNG, class S>
    inline MakeMCIRStructuredDLSEngine<RNG,S>&
    MakeMCIRStructuredDLSEngine<RNG,S>::withAntitheticVariate(bool b) {
        antithetic_ = b;
        return *this;
    }

    template <class RNG, class S>
    inline MakeMCIRStructuredDLSEngine<RNG,S>&
    MakeMCIRStructuredDLSEngine<RNG,S>::withControlVariate(bool b) {
        controlVariate_ = b;
        return *this;
    }

    template <class RNG, class S>
    inline
    MakeMCIRStructuredDLSEngine<RNG,S>::operator boost::shared_ptr<PricingEngine>()
                                                                       const {
        return boost::shared_ptr<PricingEngine>(new
            MCIRStructuredDLSEngine<RNG,S>(process_,
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
