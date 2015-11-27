#ifndef quantlib_RangeConditionOperator1D_hpp
#define quantlib_RangeConditionOperator1D_hpp

#include <ql/types.hpp>
#include <string>
#include <src/Engine/MonteCarlo/operator/operator1D.hpp>
#include <src/Engine/MonteCarlo/IRProduct/rateCalculation/range1D.hpp>

namespace QuantLib {

	class RangeConditionOperator1D : public Operator1D
	{
		public:

			RangeConditionOperator1D(const boost::shared_ptr<Range1D>& range1D,
									 Real constValue);

			RangeConditionOperator1D(const boost::shared_ptr<Range1D>& range1D,
									 const std::string& refName);

			Real operation1D(Real v);
			boost::shared_ptr<Range1D> range1D_;

	};

}

#endif