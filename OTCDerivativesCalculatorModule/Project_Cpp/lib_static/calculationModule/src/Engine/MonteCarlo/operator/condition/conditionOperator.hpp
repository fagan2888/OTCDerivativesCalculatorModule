#ifndef quantlib_ConditionOperator_hpp
#define quantlib_ConditionOperator_hpp

#include <ql/types.hpp>
#include <string>
#include <src/Engine/MonteCarlo/operator/operator1D.hpp>
#include <src/Engine/MonteCarlo/operator/condition/rangeConditionOperator1D.hpp>
#include <vector>

namespace QuantLib {

	class ConditionOperator
	{
		public:

			ConditionOperator(const std::vector<boost::shared_ptr<RangeConditionOperator1D>>& rangeConditionOper1DList);

			Real operation1D(Real v);

		private:
			std::vector<boost::shared_ptr<RangeConditionOperator1D>> rangeConditionOper1DList_;

	};

}

#endif