#ifndef quantlib_fdm_expr_inner_value_calculator_hpp
#define quantlib_fdm_expr_inner_value_calculator_hpp

#include <ql/types.hpp>
#include <boost/shared_ptr.hpp>
#include <vector>

#include <ql/experimental/finitedifferences/fdminnervaluecalculator.hpp>

// 2013-03-18 아직 미완성

namespace QuantLib {

    class FdmExprInnerValue : public FdmInnerValueCalculator {
      public:
        FdmExprInnerValue(const boost::shared_ptr<PayoffExpr>& payoffExpr,
                         const boost::shared_ptr<FdmMesher>& mesher,
                         Size direction);

        Real innerValue(const FdmLinearOpIterator& iter);
        Real avgInnerValue(const FdmLinearOpIterator& iter);

      private:

        Real avgInnerValueCalc(const FdmLinearOpIterator& iter);

        const boost::shared_ptr<PayoffExpr> payoff_;
        const boost::shared_ptr<FdmMesher> mesher_;
        std::vector<Real> avgInnerValues_;

		std::valarray<double*> indexValuePtrs_;
		mu::Parser parser_;

    };

}

#endif
