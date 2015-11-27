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

/*! \file MCStructuredProductEngine.hpp
    \brief European basket MC Engine
*/

#ifndef quantlib_mc_structuredproduct_engine_hpp
#define quantlib_mc_structuredproduct_engine_hpp

#include <calculationModule/src/instrument/structuredproduct/structuredproduct.hpp>
#include <calculationModule/src/instrument/structuredproduct/structuredproductpayoff.hpp>

#include <calculationModule/src/engine/montecarlo/structuredproduct/symbolmanager/pathinformation.hpp>
#include <calculationModule/src/engine/montecarlo/structuredproduct/symbolmanager/payoffinformation.hpp>

#include <ql\methods\montecarlo\multipathgeneratorFixedPath.hpp>

#include <ql/processes/geometricbrownianprocess.hpp>

#include <ql/pricingengines/mcsimulation.hpp>
#include <ql/processes/blackscholesprocess.hpp>
#include <ql/processes/stochasticprocessarray.hpp>


#include <ql/exercise.hpp>
#include <ql/indexes/indexmanager.hpp>
#include <fstream>
#include <iostream>

#include <time.h>

namespace QuantLib {

	//-----------------------------	Pricer -----------------------------------------

    class StructuredProductPricer {
      public:
        StructuredProductPricer(const boost::shared_ptr<StructuredProductPayoff>& sp_payoff)
		: sp_payoff_(sp_payoff) {
		
		}
                                //DiscountFactor discount);

		Real calculate() const
		{
			sp_payoff_->calculate();
			return 0;
		}

		void reset()
		{
			sp_payoff_->reset();
		}

      private:
        boost::shared_ptr<StructuredProductPayoff> sp_payoff_;
        //DiscountFactor discount_;

    };

//------------------------------------------------------------------------------

    template <class RNG = PseudoRandom, class S = Statistics>
    class MCStructuredProductEngine  : public StructuredProduct::engine {
									   
      public:
		  //PaySide McSimulation
        typedef typename MultiVariateFixedPath<RNG>::path_generator_type path_generator_type;
        typedef typename StructuredProductPricer path_pricer_type;
        typedef typename S stats_type;

		// constructor

        MCStructuredProductEngine(
					//const boost::shared_ptr<StochasticProcessArray>& proArrPay,
					// const boost::shared_ptr<YieldTermStructure>& discountCurve,
                       Size simulSamples,
                       BigNatural seed);

        void calculate() const {

			const boost::shared_ptr<StructuredProductPricer> pp = this->pathSPPricer();
			const boost::shared_ptr<path_generator_type>& pg = this->pathGenerator();
			
			this->arguments_.sp_payoff->variablePtrBind();
			this->arguments_.sp_payoff->validFixingDates();
			this->arguments_.sp_payoff->historyCalculate();

			Real value = 0;

			int start = std::clock();
			//std::cout << std::clock() << std::endl;
			

			for(Size j = 1; j <= simulSamples_; j++) {
				pg->next();
				value = pp->calculate();
				pp->reset();
				//std::cout << "simul count : " << j << std::endl;
				//sampleAccumulator_.add(pp.calculate(),1.0);
			}

			std::cout << static_cast<double>((std::clock() - start))/1000 << std::endl;

            //results_.value = this->mcModel_->sampleAccumulator().mean();
            
			//if (RNG::allowsErrorEstimate)
			//{
			//	results_.errorEstimate = this->mcModel_->sampleAccumulator().errorEstimate();
			//}
			results_.value = 0.0;

        }
      protected:
        // McSimulation implementation
        TimeGrid timeGrid() const;
		//TimeGrid wholeTimeGrid() const;

        boost::shared_ptr<path_generator_type> pathGenerator() const {

            Size numAssets = processes_->size();

            TimeGrid grid = timeGrid();

			Calendar calendar = this->arguments_.sp_payoff->calendar();
			
            typename RNG::rsg_type gen =
                RNG::make_sequence_generator(numAssets*(grid.size()-1),seed_);

			boost::shared_ptr<path_generator_type> pgPtr 
				= boost::shared_ptr<path_generator_type>(
					       new path_generator_type(processes_,
                                                 grid, 
												 gen));

			PathInformation::instance().initialize(pgPtr->multiPath(),calendar);

			//history setting here..

			//index의 Calendar와 product의 Calendar(calculation Date Calendar)는 따로 가야함
			//과거 index fixing은 각각 클래스에서 fixing하는데 그 방법은 pathmanager가 indexHistory를 가지고 있어서 거기에 문의해서, 
			//따로 클래스 내에 가져와서 fixing 시켜놈. 결과만 저장해서 나중에 함침.
			//그러므로 path에 따로 무언가를 붙일 필요는 없음.
			//MultiPath Grid는 product calendar로 grid숫자 계산함.

            return pgPtr;
        }
        boost::shared_ptr<StructuredProductPricer> pathSPPricer() const;
		boost::shared_ptr<path_pricer_type> pathPricer() const
		{
			return boost::shared_ptr<path_pricer_type>();
		}
        // data members
        boost::shared_ptr<StochasticProcessArray> processes_;
        Size simulSamples_;
        BigNatural seed_;
    };




    // template definitions

    template<class RNG, class S>
    inline MCStructuredProductEngine<RNG,S>::MCStructuredProductEngine(
										   Size simulSamples,
										   BigNatural seed)
    : simulSamples_(simulSamples), seed_(seed) 
	{
        registerWith(processes_);

		std::vector<boost::shared_ptr<StochasticProcess1D>> process_vec;

		boost::shared_ptr<StochasticProcess1D> process1D_1 = 
			boost::shared_ptr<GeometricBrownianMotionProcess>(new GeometricBrownianMotionProcess(100,0.03,0.35));
		boost::shared_ptr<StochasticProcess1D> process1D_2 =
			boost::shared_ptr<GeometricBrownianMotionProcess>(new GeometricBrownianMotionProcess(200,0.04,0.45));;

		process_vec.push_back(process1D_1);
		process_vec.push_back(process1D_2);

		Matrix corr = Matrix(2,2);
		corr[0][0] = 1; corr[0][1] = 0.2;
		corr[1][0] = 0.2; corr[1][1] = 1;

		processes_ = boost::shared_ptr<StochasticProcessArray>(
					new StochasticProcessArray(process_vec,corr));

	}

    template <class RNG, class S>
    inline TimeGrid MCStructuredProductEngine<RNG,S>::timeGrid() const {

		const std::vector<Date>& fixings = this->arguments_.sp_payoff->indexFixingDates();
		const std::vector<Date>& payoffDates = this->arguments_.sp_payoff->payoffDates();
        
		Date today = Settings::instance().evaluationDate();

		//const std::vector<Date> & fixings = PathInformation::instance().indexFixingDates();
		
		const Size numberOfFixings = fixings.size();
		const Size numberOfPayoffDates = payoffDates.size();

		DayCounter dayCounter = Actual365Fixed();
        
		std::vector<Time> fixingTimes;

        for (Size i = 0; i < numberOfFixings ; ++i) 
			PathInformation::instance().addIndexFixingDate(fixings[i]);

		for (Size i = 0; i < numberOfPayoffDates; ++i) 
			PayoffInformation::instance().addPayoffDate(payoffDates[i]);

		PayoffInformation::instance().initialize();

		const std::vector<Date> & adjustedFixings = PathInformation::instance().indexFixingDates();
		const Size numberOfAdjustedFixings = adjustedFixings.size();

		#ifdef DEBUG

		bool containFlag = false;

		for(Size i = 0; i < numberOfFixings; ++i)
		{
			containFlag = false;

			for(Size j = 0; j < numberOfAdjustedFixings ; ++j)
			{
				if(fixings[i] == adjustedFixings[j])
					containFlag = true;
			}		
			
			QL_REQUIRE(containFlag,"indexFixing Generation Fail");

		}

		#endif 

		for (Size i = 0; i < numberOfAdjustedFixings ; ++i) {
			if(today < adjustedFixings[i])
				fixingTimes.push_back(dayCounter.yearFraction(today,adjustedFixings[i])) ;
		}
		//const Size timeStepsPerYear = 25;

        //const Size numberOfTimeSteps = timeStepsPerYear_ * fixingTimes.back();

        return TimeGrid(fixingTimes.begin(), fixingTimes.end());

  //      
		//Time residualTime = arguments_.dayCounter.yearFraction(today,arguments_.maturityDate);
		//
		//Size residualTimeSize = arguments_.calendar.businessDaysBetween(today,arguments_.maturityDate,true,false);
  //      TimeGrid timeGrid = TimeGrid(residualTime, residualTimeSize);

		//return timeGrid;

     
    }
    
    template <class RNG, class S>
    inline
    boost::shared_ptr<StructuredProductPricer>
    MCStructuredProductEngine<RNG,S>::pathSPPricer() const {

        return boost::shared_ptr<StructuredProductPricer>(
								 new StructuredProductPricer(arguments_.sp_payoff));
	}

}

#endif
