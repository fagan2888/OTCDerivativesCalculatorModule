#ifndef quantlib_mc_AutoCallablePricer_hpp
#define quantlib_mc_AutoCallablePricer_hpp

#include <src/Engine/MonteCarlo/MCPricer.hpp>
#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>
#include <ql/termstructures/all.hpp>

namespace QuantLib {

    class AutoCallablePricer : public MCPricer {
      public:
        AutoCallablePricer(const std::vector<boost::shared_ptr<EventTriggerInfo>>& eventInfoList,
							Real notional,
							std::string currency,
							const boost::shared_ptr<FixingDateInfo>& payoffDateInfo);

		//interface
		void initializeImpl(const TimeGrid& timeGrid,
						const boost::shared_ptr<YieldTermStructure>& discountCurve,
						const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

		Real calculate(const MultiPath& path,Size endPosition) const;

		Real callableCalculate(const MultiPath& multiPath,Size earlyExOccEventTriggerNum) const;

		Size autoCallEventPosition();
		Real autoCallPayoff(Size position);

		std::vector<Date> fixingDates() const;
		std::vector<Date> payoffDates() const;

	protected:
		void resetImpl() const;

      private:

		  mutable Real value_;
		  mutable Size eventTriggerNum_;

		  bool pastkiBarrierEventOcc_;
		  Size remainEventPosition_;


	};
}

#endif