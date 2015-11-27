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

/*! \file MCSwapEngine.hpp
    \brief European basket MC Engine
*/

#ifndef quantlib_mc_euoption_engine_hpp
#define quantlib_mc_euoption_engine_hpp

#include <ql/instruments/basketoption.hpp>
#include <ql/pricingengines/mcsimulation.hpp>
#include <ql/processes/blackscholesprocess.hpp>
#include <ql/processes/stochasticprocessarray.hpp>
#include <ql/testClass/standardswap/swappayoff.hpp>
#include <ql/testClass/standardswap/standardswap.hpp>

#include <ql/exercise.hpp>
#include <fstream>
#include <iostream>

namespace QuantLib {

    template <class RNG = PseudoRandom, class S = Statistics>
    class MCSwapEngine  : public StandardSwap::engine,
                              public McSimulation<MultiVariatePast,RNG,S> {
      public:
		  //PaySide McSimulation
        typedef typename McSimulation<MultiVariatePast,RNG,S>::path_generator_type
            path_generator_type;
        typedef typename McSimulation<MultiVariatePast,RNG,S>::path_pricer_type
            path_pricer_type;
        typedef typename McSimulation<MultiVariatePast,RNG,S>::stats_type
            stats_type;

		// constructor

        MCSwapEngine(const boost::shared_ptr<StochasticProcessArray>& proArrPay,
					 const boost::shared_ptr<YieldTermStructure>& discountCurve,
                       Size timeSteps,
                       Size requiredSamples,
                       Real requiredTolerance,
                       Size maxSamples,
                       BigNatural seed);

        void calculate() const {

            McSimulation<MultiVariatePast,RNG,S>::calculate(requiredTolerance_,
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
		TimeGrid wholeTimeGrid() const;

        boost::shared_ptr<path_generator_type> pathGenerator() const {

            //boost::shared_ptr<BasketPayoff> payoff =
            //    boost::dynamic_pointer_cast<BasketPayoff>(arguments_.payoff);
            //QL_REQUIRE(payoff, "non-basket payoff given");

            Size numAssets = processes_->size();

            TimeGrid grid = timeGrid();
			TimeGrid wholeGrid = wholeTimeGrid();

			Size shift = wholeGrid.size() - grid.size();

            typename RNG::rsg_type gen =
                RNG::make_sequence_generator(numAssets*(grid.size()-1),seed_);

			MultiPath path = MultiPath(numAssets, wholeGrid);
			//history setting here..

            return boost::shared_ptr<path_generator_type>(
                         new path_generator_type(processes_,
                                                 grid, 
												 path,
												 gen, 
												 shift,
												 brownianBridge_));
        }
        boost::shared_ptr<path_pricer_type> pathPricer() const;
        // data members
        boost::shared_ptr<StochasticProcessArray> processes_;
        Size timeSteps_;
        Size requiredSamples_;
        Size maxSamples_;
        Real requiredTolerance_;
        bool brownianBridge_;
        BigNatural seed_;
    };


//-----------------------------	Pricer -----------------------------------------

    class SwapPricer : public PathPricer<MultiPath> {
      public:
        SwapPricer(const boost::shared_ptr<SwapPayoff>& swappayoff,
                                DiscountFactor discount);

        Real operator()(const MultiPath& multiPath) const;
      private:
        boost::shared_ptr<SwapPayoff> swappayoff_;
        DiscountFactor discount_;

		Size numAssetsPay_;
		Size numAssetsReceive_;
		

    };

//------------------------------------------------------------------------------

    // template definitions

    template<class RNG, class S>
    inline MCSwapEngine<RNG,S>::MCSwapEngine(
                   const boost::shared_ptr<StochasticProcessArray>& processes,
				   const boost::shared_ptr<YieldTermStructure>& discountCurve,
                   Size timeSteps,
                   Size requiredSamples,
                   Real requiredTolerance,
                   Size maxSamples,
                   BigNatural seed)
    : McSimulation<MultiVariatePast,RNG,S>(false, false),
      processes_(processes), timeSteps_(timeSteps),
      requiredSamples_(requiredSamples), maxSamples_(maxSamples),
      requiredTolerance_(requiredTolerance),
      brownianBridge_(false), seed_(seed) {
        QL_REQUIRE(timeSteps > 0,
                   "timeSteps must be positive, " << timeSteps <<
                   " not allowed");
        registerWith(processes_);
	}

    template <class RNG, class S>
    inline TimeGrid MCSwapEngine<RNG,S>::timeGrid() const {

		Date today = Settings::instance().evaluationDate();
		Date issueDate = arguments_.issueDate;
        Time residualTime = arguments_.dayCounter.yearFraction(today,arguments_.maturityDate);
		Size residualTimeSize = static_cast<Size>(residualTime * timeSteps_);
        TimeGrid timeGrid = TimeGrid(residualTime, residualTimeSize);

		return timeGrid;

     
    }
    
	template <class RNG, class S>
    inline TimeGrid MCSwapEngine<RNG,S>::wholeTimeGrid() const {

		Date today = Settings::instance().evaluationDate();
		Date issueDate = arguments_.issueDate;
        Time residualTime = arguments_.dayCounter.yearFraction(issueDate,arguments_.maturityDate);
		Size residualTimeSize = static_cast<Size>(residualTime * timeSteps_);
        TimeGrid timeGrid = TimeGrid(residualTime, residualTimeSize);

		this->arguments_.swappayoff->setGridInitialize(timeGrid);

			//QL_FAIL("Do not Use the timeStepsPerYear. use timeSteps");

			return timeGrid;

     
    }

    template <class RNG, class S>
    inline
    boost::shared_ptr<typename MCSwapEngine<RNG,S>::path_pricer_type>
    MCSwapEngine<RNG,S>::pathPricer() const {

        return boost::shared_ptr<
                    typename MCSwapEngine<RNG,S>::path_pricer_type>(
								 new SwapPricer(arguments_.swappayoff,0.0286));
                                 //process->riskFreeRate()->discount(arguments_.maturityDate)));
	}

}


#endif

/*else if (timeStepsPerYear_ != Null<Size>()) {
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
        } */