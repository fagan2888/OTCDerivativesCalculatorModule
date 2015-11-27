#ifndef quantlib_couponCalculation_hpp
#define quantlib_couponCalculation_hpp

#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>

namespace QuantLib {

	class CouponCalculation : public EventTriggerInfo
	{
		public:
			CouponCalculation(const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList);
		
	};
}

#endif