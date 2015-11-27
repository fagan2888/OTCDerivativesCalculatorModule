#include <ql/payoff.hpp>
#include <ql/math/functional.hpp>
#include <ql/math/integrals/simpsonintegral.hpp>
#include <ql/instruments/basketoption.hpp>
#include <ql/experimental/finitedifferences/fdmmesher.hpp>
#include <ql/experimental/finitedifferences/fdminnervaluecalculator.hpp>

#include <deque>

namespace QuantLib {

    FdmExprInnerValue::FdmExprInnerValue(
                                const boost::shared_ptr<PayoffExpr>& payoffExpr,
                                const boost::shared_ptr<FdmMesher>& mesher)
    : payoff_(payoff),mesher_(mesher) 
	{
		const std::vector<std::string>& baseSymbol = payoffExpr->baseSymbol();
		
		indexValues_.resize(baseSymbol.size());

		for(Size i=0 ; i < baseSymbol.size() ; ++i)
		{
			this->parser_.DefineVar(baseSymbol[i],&(indexValues_[i]));
		}
		
		parser_.SetExpr(payoffExpr->expr());

	}

    Real FdmExprInnerValue::innerValue(const FdmLinearOpIterator& iter) {
        Array x(mesher_->layout()->dim().size());
        for (Size i=0; i < x.size(); ++i) {
            indexValuePtrs_[i] = std::exp(mesher_->location(iter, i));
        }
        
        return parser_.Eval();
    }
    
    Real 
    FdmExprInnerValue::avgInnerValue(const FdmLinearOpIterator& iter) {
        return innerValue(iter);
    }
}
