#ifndef quantlib_mc_StopLossEventPricer_hpp
#define quantlib_mc_StopLossEventPricer_hpp

#include <boost/shared_ptr.hpp>

#include <src/Engine/MonteCarlo/MCPricer.hpp>
#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>
#include <src/Engine/MonteCarlo/returnCalculation/returnCalculation.hpp>
#include <ql/termstructures/all.hpp>

namespace QuantLib {

    class StopLossEventPricer : public MCPricer {
      public:
        StopLossEventPricer(const std::vector<boost::shared_ptr<EventTriggerInfo>>& eventTriggerList,
							const boost::shared_ptr<EventTriggerInfo>& barrierEventTrigger,
							const boost::shared_ptr<ReturnCalculation>& returnCalculation,
							const boost::shared_ptr<FixingDateInfo>& payoffDateInfo );

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
		  Size maturityPosition_;
		  

		  bool pastkiBarrierEventOcc_;
		  Size remainEventPosition_;

		  std::vector<boost::shared_ptr<EventTriggerInfo>> eventTriggerList_;
		  boost::shared_ptr<EventTriggerInfo> barrierInfoTrigger_;
		  boost::shared_ptr<ReturnCalculation> returnCalculation_;

          //Array discount_;
		  boost::shared_ptr<FixingDateInfo> payoffDateInfo_;

	};
}

#endif