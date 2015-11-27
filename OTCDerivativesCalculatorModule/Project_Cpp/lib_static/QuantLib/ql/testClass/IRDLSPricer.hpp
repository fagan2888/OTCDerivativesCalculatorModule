#ifndef quantlib_dls_pricer_hpp
#define quantlib_dls_pricer_hpp


#include <ql/testClass/Pricer.hpp>
#include <ql/processes/stochasticprocessarray.hpp>
#include <ql/testClass/PayoffLeg.hpp>
#include <ql/math/statistics/statistics.hpp>

namespace QuantLib {

class IRDLSPricer : public Pricer {
      public:
        IRDLSPricer(const boost::shared_ptr<PayoffLeg> & payoffLeg,
                             const std::vector<Size> & timePositions,
							 const boost::shared_ptr<StochasticProcessArray>& process,
                             const Array & discounts,
							 std::vector<Statistics>& additionalStats);
		Real values(const std::vector<Real>& rand,Size simul) const;

      private:
        boost::shared_ptr<PayoffLeg> payoffLeg_;
        std::vector<Size> timePositions_;
		boost::shared_ptr<StochasticProcessArray>  process_;
        Array discounts_;
		mutable std::vector<Statistics>& additionalStats_;
		Size countMe_;
		Matrix chol_;
		Array corrCoff_;
		std::vector<IndexType> indexType_;
    };

}



#endif
