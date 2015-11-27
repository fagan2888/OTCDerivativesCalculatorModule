#ifndef quantlib_mycomparison_hpp
#define quantlib_mycomparison_hpp

#include <boost/shared_ptr.hpp>
#include <src/engine/montecarlo/pricer/event/eventTriggerInfo.hpp>

namespace ComparisonFunction {
	bool compETIEventDate(const boost::shared_ptr<QuantLib::EventTriggerInfo>& _first ,
								  const boost::shared_ptr<QuantLib::EventTriggerInfo>& _second);

}

#endif