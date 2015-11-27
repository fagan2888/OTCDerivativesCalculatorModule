#include <ql/testClass/ELSStepDownPricer.hpp>


namespace QuantLib {

ELSStepDownPricer::ELSStepDownPricer(//const boost::shared_ptr<PayoffLeg> & payoffLeg,
                       const std::vector<Time> & times,
					   const boost::shared_ptr<StochasticProcessArray>& process,
					   const Array & x0,
					   const Array & discounts,
					   const Array & KIRedemPayoff,
                       const Matrix & earlyExValues_Chg,
					   const Matrix & KIbarrierValues_Chg,
					   const std::vector<Real>& redemCoupon,
					   Size pastFixingNum,
					   Size seed,
					   std::vector<Statistics>& additionalStats,
					   bool KIflag=false)
    :  ELSPricer(times,process,x0,discounts,KIRedemPayoff,
	   earlyExValues_Chg,KIbarrierValues_Chg,redemCoupon,pastFixingNum,
	   seed,additionalStats,KIflag) {


}	
}
