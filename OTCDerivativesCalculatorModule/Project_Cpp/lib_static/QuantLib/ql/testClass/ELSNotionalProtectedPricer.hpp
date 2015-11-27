#ifndef quantlib_testClass_ELS_NotionalProtectedPricer_hpp
#define quantlib_testClass_ELS_NotionalProtectedPricer_hpp

#include <ql/processes/stochasticprocessarray.hpp>
#include <ql/math/matrix.hpp>
#include <ql/math/statistics/statistics.hpp>
#include <ql/math/matrixutilities/choleskydecomposition.hpp>

#include <ql/math/randomnumbers/rngtraits.hpp>


namespace QuantLib {

class ELSNotionalProtectedPricer {
      public:
        ELSNotionalProtectedPricer(//const boost::shared_ptr<PayoffLeg> & payoffLeg,
                             const std::vector<Time> & times,
							 const boost::shared_ptr<StochasticProcessArray>& process,
							 const Array & x0,
                             const Array & discounts,
						     const Matrix & earlyExValues_Chg,
						     Real redemCoupon,
							 Size pastFixingNum,
							 std::vector<Statistics>& additionalStats);

        //Real operator()(const MultiPath& multiPath) const;
		Real values(Size simul) const;
        bool checkEarlyRedem(Array& SumdZ,Size i) const;
      private:

        //boost::shared_ptr<PayoffLeg> payoffLeg_;
        std::vector<Time> times_;
		Array x0_;
		boost::shared_ptr<StochasticProcessArray>  process_;
        Array discounts_;
		Matrix earlyExValues_Chg_;
	
		Matrix chol_;
		Matrix vol_;
		Matrix sigmaDt_;
		Real redemCoupon_;
		Size pastFixingNum_;
		Size numberOfAssets_;

		mutable std::vector<Statistics>& additionalStats_;

		Array corrCoff_;
		
    };


}

#endif