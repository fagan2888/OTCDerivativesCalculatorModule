#ifndef quantlib_testClass_ELS_ELSStepDownPricer_hpp
#define quantlib_testClass_ELS_ELSStepDownPricer_hpp

#include <ql/testClass/ELSPricer.hpp>


namespace QuantLib {

	class ELSStepDownPricer : public ELSPricer {
      public:
        ELSStepDownPricer(//const boost::shared_ptr<PayoffLeg> & payoffLeg,
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
							 bool KIfalg);

    };


}

#endif