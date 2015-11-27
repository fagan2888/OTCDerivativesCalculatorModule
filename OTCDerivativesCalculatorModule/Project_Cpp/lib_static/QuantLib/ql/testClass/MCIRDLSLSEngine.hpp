#ifndef quantlib_mc_ls_engine_hpp
#define quantlib_mc_ls_engine_hpp

#include <ql/processes/stochasticprocessarray.hpp>
#include <ql/termstructures/yieldtermstructure.hpp>
#include <ql/timegrid.hpp>

#include <ql/testClass/IRDLS.hpp>
#include <ql/testClass/IRDLSCallablePricer.hpp>

#include <ql/cashflows/simplecashflow.hpp>
#include <ql/cashflows/cashflows.hpp>
#include <ql/math/randomnumbers/rngtraits.hpp>
#include <ql/math/statistics/statistics.hpp>
#include <ql/testClass/sethistoryparametor.hpp>

#include <iostream>

using namespace QuantLib;

//훗날 랜덤을 Poisson으로 받아야 할때 template로 가자.

namespace QuantLib {
	class MCIRDLSLSEngine : public IRDLS::engine ,
							public SetHistoryParametor
	{
	  public:
		// constructor
        MCIRDLSLSEngine(const boost::shared_ptr<StochasticProcessArray>&,
						   const Handle<YieldTermStructure> & discountTS,
                           Size maxSamples,
                           BigNatural seed,
						   Size nCalibrationSamples = 500);

		// historyCal을 위한 method
		void setProcess(const boost::shared_ptr<StochasticProcessArray>& process) const{
			QL_REQUIRE(process_->size() == process->size() , "Instrument process size is " << process_->size() << " but Input process size is " << process->size());
			process_=process;}

		void calculate() const;

      protected:

        TimeGrid timeGrid() const;
		boost::shared_ptr<IRDLSCallablePricer> lsmPathPricer() const;
        Size randNum() const;

		mutable boost::shared_ptr<PseudoRandom::rsg_type> pathGenerator_;
		mutable boost::shared_ptr<IRDLSCallablePricer> pathPricer_;
        mutable boost::shared_ptr<StochasticProcessArray> process_;
		Handle<YieldTermStructure> discountTS_;
        Size maxSamples_;
        BigNatural seed_;
		Size nCalibrationSamples_;
		mutable std::vector<Statistics> additionalStats_;
		std::vector<Statistics> resultAccumulators;		

    };
    
}


#endif
