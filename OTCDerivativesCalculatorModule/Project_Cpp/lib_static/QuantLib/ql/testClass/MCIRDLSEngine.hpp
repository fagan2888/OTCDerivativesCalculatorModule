#ifndef quantlib_mc_ir_dls_engine_hpp
#define quantlib_mc_ir_dls_engine_hpp

#include <ql/processes/stochasticprocessarray.hpp>
#include <ql/timegrid.hpp>
#include <ql/testClass/IRDLS.hpp>
#include <ql/testClass/IRDLSPricer.hpp>
#include <ql/cashflows/simplecashflow.hpp>
#include <ql/cashflows/cashflows.hpp>
#include <ql/math/randomnumbers/rngtraits.hpp>
#include <ql/math/statistics/statistics.hpp>
#include <ql/testClass/sethistoryparametor.hpp>

#include <iostream>

namespace QuantLib {

    //! Pricing engine for path dependent basket options using
    //  Monte Carlo simulation
    class MCIRDLSEngine  : public IRDLS::engine ,
						   public SetHistoryParametor
	{
      public:
        // constructor
        MCIRDLSEngine(const boost::shared_ptr<StochasticProcessArray>&,
						   const Handle<YieldTermStructure> & discountTS,
                           Size maxSamples,
                           BigNatural seed);

		// historyCal¿ª ¿ß«— method
		void setProcess(const boost::shared_ptr<StochasticProcessArray>& process) const{
			QL_REQUIRE(process_->size() == process->size() , "Instrument process size is " << process_->size() << " but Input process size is " << process->size());
			process_=process;}

        void calculate() const;

      protected:

        TimeGrid timeGrid() const;
		Size randNum() const;
        boost::shared_ptr<Pricer> pathPricer() const;

        // data members
        mutable boost::shared_ptr<StochasticProcessArray> process_;
		mutable boost::shared_ptr<Pricer> pathPricer_;
		//mutable boost::shared_ptr<PseudoRandom::rsg_type> pathGenerator_;
		Handle<YieldTermStructure> discountTS_;
        Size maxSamples_;
        BigNatural seed_;
		mutable std::vector<Statistics> additionalStats_;

		std::vector<Statistics> resultAccumulators;		 
		
    };

}


#endif
