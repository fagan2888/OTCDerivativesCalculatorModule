#ifndef quantlib_mc_stepDownNoKIEventPricer_hpp
#define quantlib_mc_stepDownNoKIEventPricer_hpp

#include <boost/shared_ptr.hpp>

#include <src/Engine/MonteCarlo/MCPricer.hpp>
#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>
#include <ql/termstructures/all.hpp>

namespace QuantLib {

    class StepDownNoKIEventPricer : public MCPricer {
      public:
        StepDownNoKIEventPricer(const std::vector<boost::shared_ptr<EventTriggerInfo>>& eventTriggerList,
								const boost::shared_ptr<EventTriggerInfo>& noAutoCallTrigger);

		//interface
		void initializeImpl(const TimeGrid& timeGrid,
						const boost::shared_ptr<YieldTermStructure>& discountCurve,
						const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

		

		Real calculate(const MultiPath& path,Size endPosition = 0) const;

		Size autoCallEventPosition();
		Real autoCallPayoff(Size position);

		std::vector<Date> fixingDates() const;
		std::vector<Date> payoffDates() const;
	protected:
		void resetImpl() const;

      private:

		  mutable Real value_;
		  mutable Size autoCallEventPosition_;
		  
		  bool pastkiBarrierEventOcc_;
		  Size remainEventPosition_;

		  std::vector<boost::shared_ptr<EventTriggerInfo>> eventTriggerList_;
		  boost::shared_ptr<EventTriggerInfo> noAutoCallTrigger_;
		  boost::shared_ptr<YieldTermStructure> discountCurve_;
          //Array discount_;

		  std::vector<Date> fixingDates_;
		  std::vector<Date> payoffDates_;
	};
}

#endif