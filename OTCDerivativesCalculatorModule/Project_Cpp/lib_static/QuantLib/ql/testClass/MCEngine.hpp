#ifndef quantlib_mc_engine_hpp
#define quantlib_mc_engine_hpp

#include <ql/processes/stochasticprocessarray.hpp>
#include <ql/timegrid.hpp>
#include <ql/testClass/IRStructuredDLS.hpp>
#include <ql/cashflows/simplecashflow.hpp>
#include <ql/cashflows/cashflows.hpp>
#include <ql/testClass/Pricer.hpp>
#include <ql/testClass/DLSPricer.hpp>
#include <ql/handle.hpp>
#include <ql/termstructures/yieldtermstructure.hpp>
#include <ql/math/statistics/statistics.hpp>
#include <ql/math/randomnumbers/rngtraits.hpp>


#include <iostream>

namespace QuantLib {

	class MCEngine  : public IRStructuredDLS::engine {
        
		// constructor
	public:
        MCEngine(const boost::shared_ptr<StochasticProcessArray>&,
				   const Handle<YieldTermStructure> & discountTS,
				   Size timeSteps,
				   Size maxSamples,
                   BigNatural seed);

        void calculate() const {

			for(Size i=0;i<additionalStats_.size();++i) {
				additionalStats_[i].reset();
			}

			pathPricer_=pathPricer();
			pathGenerator_=pathGenerator();
			//results_.value = (pathPricer_->(pathGenerator_,maxSamples_)/maxSamples_);
			
			
        }

      protected:

        TimeGrid timeGrid() const;
		boost::shared_ptr<PseudoRandom::rsg_type> pathGenerator() const;
        // data members
        boost::shared_ptr<StochasticProcessArray> process_;
		Handle<YieldTermStructure> discountTS_;
        Size timeSteps_;
        Size maxSamples_;
        BigNatural seed_;
		mutable std::vector<Statistics> additionalStats_;
		mutable boost::shared_ptr<Pricer> pathPricer_;
		mutable boost::shared_ptr<PseudoRandom::rsg_type> pathGenerator_;

		std::vector<Statistics> resultAccumulators;		 
		
    };



}


#endif
