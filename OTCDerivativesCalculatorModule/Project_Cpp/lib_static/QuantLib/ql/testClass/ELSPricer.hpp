#ifndef quantlib_testClass_ELS_ELSPricer_hpp
#define quantlib_testClass_ELS_ELSPricer_hpp

#include <ql/processes/stochasticprocessarray.hpp>
#include <ql/math/matrix.hpp>
//#include <ql/testClass/PayoffLeg.hpp>
#include <ql/math/statistics/statistics.hpp>
#include <ql/math/matrixutilities/choleskydecomposition.hpp>

#include <ql/math/randomnumbers/rngtraits.hpp>


namespace QuantLib {

class ELSPricer {
      public:
        ELSPricer(//const boost::shared_ptr<PayoffLeg> & payoffLeg,
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

        //Real operator()(const MultiPath& multiPath) const;
		Real values(Size simul) const;

	  protected:
		  bool KIflag(){return KIflag_;}

      private:

        //boost::shared_ptr<PayoffLeg> payoffLeg_;
        std::vector<Time> times_;
		Array x0_;
		boost::shared_ptr<StochasticProcessArray>  process_;
        Array discounts_;
		Array KIRedemPayoff_;
		Matrix earlyExValues_Chg_;
	
		Matrix KIbarrierValues_Chg_;
		Matrix chol_;
		//Matrix vol_;
		Array vol_;
		Matrix sigmaDt_;
		std::vector<Real> redemCoupon_;
		Size pastFixingNum_;
		Size seed_;

		mutable std::vector<Statistics>& additionalStats_;
		Size countMe_;

		Array corrCoff_;
		bool KIflag_;

		
    };


}

#endif