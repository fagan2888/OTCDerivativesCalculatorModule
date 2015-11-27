#ifndef quantlib_PreConditionEvent_hpp
#define quantlib_PreConditionEvent_hpp

#include <ql/timegrid.hpp>
#include <ql/termstructures/yieldtermstructure.hpp>
#include <src/Engine/MonteCarlo/PathGeneratorFactory.hpp>

namespace QuantLib {

	class PreConditionEvent 
	{
		public:
			PreConditionEvent(const std::string& refEventName);

			void initialize(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			//bool checkEvent(const MultiPath& path,Size endPosition = 0);
			bool checkEvent();
			void reset();

	};
}

#endif