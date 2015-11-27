#ifndef quantlib_mc_engine_hpp
#define quantlib_mc_engine_hpp

#include <fstream>
#include <iostream>
#include <boost/shared_ptr.hpp>

#include <time.h>
#include <src/Engine/MonteCarlo/MCPricer.hpp>
#include <ql/processes/all.hpp>
//#include <src/Engine/MonteCarlo/pathGenerator.hpp>
#include <src/Engine/MonteCarlo/PathGeneratorFactory.hpp>
#include <ql/methods/montecarlo/mctraits.hpp>
#include <src/util/MyResultCalculator.hpp>
#include <src/Engine/MonteCarlo/instrument/noteInst.hpp>


namespace QuantLib {

//------------------------------------------------------------------------------
// inst를 받아서 pricer를 돌리는 일을 함.

    class MonteEngine : public NoteInst::engine {
									   
      public:

        //typedef typename MultiVariateFixedPath<PseudoRandom>::path_generator_type path_generator_type;
        //typedef typename S stats_type;

		// constructor
        MonteEngine(const boost::shared_ptr<MCPricer>& pricer,
					//const boost::shared_ptr<StochasticProcessArray>& proArrPay,
					const boost::shared_ptr<ProcessArrayWrapper>& processArrWrapper,
					const boost::shared_ptr<YieldTermStructure>& discountCurve,
                    Size simulSamples,
                    BigNatural seed);

        void calculate() const;
		boost::shared_ptr<MyResultCalculator> resultCalc() const;

		std::string getLogList();

      protected:
        TimeGrid timeGridWithPast() const;
		TimeGrid timeOneDayGrid() const;
		boost::shared_ptr<PathGeneratorFactory> pathGeneratorFactory() const;
		boost::shared_ptr<YieldTermStructure> discountCurve_;

        //boost::shared_ptr<StochasticProcessArray> processes_;
		boost::shared_ptr<ProcessArrayWrapper> processArrWrapper_;
		boost::shared_ptr<MCPricer> pricer_;

		boost::shared_ptr<PathGeneratorFactory> pathGeneratorFactory_;

		mutable std::vector<std::vector<std::string>> logList_;
		mutable std::vector<Date> fixingsFromToday_;
		
		boost::shared_ptr<MyResultCalculator> resultCalc_;
		//TimeGrid timeGrid_;
        Size simulSamples_;
        BigNatural seed_;
    };

}

#endif
