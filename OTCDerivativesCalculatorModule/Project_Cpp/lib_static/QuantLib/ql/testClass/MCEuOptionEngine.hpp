/* -*- mode: c++; tab-width: 4; indent-tabs-mode: nil; c-basic-offset: 4 -*- */

/*
 Copyright (C) 2004 Neil Firth
 Copyright (C) 2007, 2008 StatPro Italia srl

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

/*! \file MCEuOptionEngine.hpp
    \brief European basket MC Engine
*/

#ifndef quantlib_mc_euoption_engine_hpp
#define quantlib_mc_euoption_engine_hpp

#include <ql/instruments/basketoption.hpp>
#include <ql/pricingengines/mcsimulation.hpp>
#include <ql/processes/blackscholesprocess.hpp>
#include <ql/processes/stochasticprocessarray.hpp>
#include <ql/testClass/euoption.hpp>
#include <ql/testClass/payoff/optionpayoff.hpp>
#include <ql/exercise.hpp>
#include <fstream>
#include <iostream>
namespace QuantLib {

    //! Pricing engine for European options using Monte Carlo simulation
    /*! \ingroup basketengines

        \test the correctness of the returned value is tested by
              reproducing results available in literature.
    */

    template <class RNG = PseudoRandom, class S = Statistics>
    class MCEuOptionEngine  : public EuOption::engine,
                              public McSimulation<MultiVariate,RNG,S> {
      public:
        typedef typename McSimulation<MultiVariate,RNG,S>::path_generator_type
            path_generator_type;
        typedef typename McSimulation<MultiVariate,RNG,S>::path_pricer_type
            path_pricer_type;
        typedef typename McSimulation<MultiVariate,RNG,S>::stats_type
            stats_type;
        // constructor
        MCEuOptionEngine(const boost::shared_ptr<StochasticProcessArray>& processes,
                               Size timeSteps,
                               Size timeStepsPerYear,
                               bool brownianBridge,
                               bool antitheticVariate,
                               Size requiredSamples,
                               Real requiredTolerance,
                               Size maxSamples,
                               BigNatural seed);
        void calculate() const {
            McSimulation<MultiVariate,RNG,S>::calculate(requiredTolerance_,
                                                        requiredSamples_,
                                                        maxSamples_);
            results_.value = this->mcModel_->sampleAccumulator().mean();
            if (RNG::allowsErrorEstimate)
            results_.errorEstimate =
                this->mcModel_->sampleAccumulator().errorEstimate();
        }
      protected:
        // McSimulation implementation
        TimeGrid timeGrid() const;
        boost::shared_ptr<path_generator_type> pathGenerator() const {

            //boost::shared_ptr<BasketPayoff> payoff =
            //    boost::dynamic_pointer_cast<BasketPayoff>(arguments_.payoff);
            //QL_REQUIRE(payoff, "non-basket payoff given");

            Size numAssets = processes_->size();

            TimeGrid grid = timeGrid();
            typename RNG::rsg_type gen =
                RNG::make_sequence_generator(numAssets*(grid.size()-1),seed_);

            return boost::shared_ptr<path_generator_type>(
                         new path_generator_type(processes_,
                                                 grid, gen, brownianBridge_));
        }
        boost::shared_ptr<path_pricer_type> pathPricer() const;
        // data members
        boost::shared_ptr<StochasticProcessArray> processes_;
        Size timeSteps_, timeStepsPerYear_;
        Size requiredSamples_;
        Size maxSamples_;
        Real requiredTolerance_;
        bool brownianBridge_;
        BigNatural seed_;
    };


//-----------------------------	Pricer -----------------------------------------

    class EuOptionPricer : public PathPricer<MultiPath> {
      public:
        EuOptionPricer(const boost::shared_ptr<OptionPayoff>& optionpayoff,
                                DiscountFactor discount);

        Real operator()(const MultiPath& multiPath) const;
      private:
        boost::shared_ptr<OptionPayoff> optionpayoff_;
        DiscountFactor discount_;
		

    };

//------------------------------------------------------------------------------

    // template definitions

    template<class RNG, class S>
    inline MCEuOptionEngine<RNG,S>::MCEuOptionEngine(
                   const boost::shared_ptr<StochasticProcessArray>& processes,
                   Size timeSteps,
                   Size timeStepsPerYear,
                   bool brownianBridge,
                   bool antitheticVariate,
                   Size requiredSamples,
                   Real requiredTolerance,
                   Size maxSamples,
                   BigNatural seed)
    : McSimulation<MultiVariate,RNG,S>(antitheticVariate, false),
      processes_(processes), timeSteps_(timeSteps),
      timeStepsPerYear_(timeStepsPerYear),
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
                   "timeStepsPerYear must be positive, " << timeStepsPerYear <<
                   " not allowed");
        registerWith(processes_);
	}

    template <class RNG, class S>
    inline TimeGrid MCEuOptionEngine<RNG,S>::timeGrid() const {

		Date today = Settings::instance().evaluationDate();
        Time residualTime = arguments_.dayCounter.yearFraction(today,arguments_.maturityDate);
		// 수정?해야함 2012-09-21
		const std::vector<Date>& eventDates=(arguments_.optionPayoff->eventChecks())[0]->eventDates();
        
		if (timeSteps_ != Null<Size>()) {
			
			QL_FAIL("Do not Use the timeSteps. use timeStepsPerYear");
			//const TimeGrid& timeGrid = TimeGrid(residualTime, timeSteps_);
			return TimeGrid(residualTime, timeSteps_);
			//return timeGrid;

        } else if (timeStepsPerYear_ != Null<Size>()) {
            Size steps = static_cast<Size>(timeStepsPerYear_*residualTime);
			const TimeGrid& timeGrid = TimeGrid(residualTime, std::max<Size>(steps, 1));
			
			//timeGrid를 사용해서 각각 Event에다가 DateIndex를 변환하여 setting함.
			//시뮬레이션 돌때에 Date를 사용하지 않고 IndexNum만 가지고 EventDate를 판별하기 위한 setting.
			Size eventNum = arguments_.optionPayoff->eventChecks().size();
			for(Size i=0 ; i<eventNum ; ++i){
				
				const std::vector<Date>& eventDates=(arguments_.optionPayoff->eventChecks())[i]->eventDates();
				std::vector<Size> dateIndex;

				for (Size j=0;j<eventDates.size();++j){
					dateIndex.push_back(timeGrid.index(arguments_.dayCounter.yearFraction(today,eventDates[j])));
				}
				(arguments_.optionPayoff->eventChecks())[i]->setDateIndex(dateIndex);

			}

            //return TimeGrid(residualTime, std::max<Size>(steps, 1));
			return timeGrid;

        } else {
            QL_FAIL("time steps not specified");
        }
    }

    template <class RNG, class S>
    inline
    boost::shared_ptr<typename MCEuOptionEngine<RNG,S>::path_pricer_type>
    MCEuOptionEngine<RNG,S>::pathPricer() const {

        /*boost::shared_ptr<BasketPayoff> payoff =
            boost::dynamic_pointer_cast<BasketPayoff>(arguments_.payoff);
        QL_REQUIRE(payoff, "non-basket payoff given");*/

        boost::shared_ptr<GeometricBrownianMotionProcess> process =
            boost::dynamic_pointer_cast<GeometricBrownianMotionProcess>(
                                                      processes_->process(0));
        QL_REQUIRE(process, "Black-Scholes process required");

        return boost::shared_ptr<
                    typename MCEuOptionEngine<RNG,S>::path_pricer_type>(
								 new EuOptionPricer(arguments_.optionPayoff,0.0286));
                                 //process->riskFreeRate()->discount(arguments_.maturityDate)));
    }

}


#endif
