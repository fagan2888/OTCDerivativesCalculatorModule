#ifndef quantlib_mc_stepdownkieventpricer_hpp
#define quantlib_mc_stepdownkieventpricer_hpp

#include <boost/shared_ptr.hpp>

#include <src/Engine/MonteCarlo/MCPricer.hpp>
#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>
#include <ql/termstructures/all.hpp>

namespace QuantLib {

    class HifivePricer : public MCPricer {
      public:
        HifivePricer(const std::vector<boost::shared_ptr<EventTriggerInfo>>& eventInfoList,
					const boost::shared_ptr<EventTriggerInfo>& kiBarrierEventTrigger,
					Real notional,
					std::string currency,
					const boost::shared_ptr<FixingDateInfo>& payoffDateInfo );

		//interface
		void initializeImpl(const TimeGrid& timeGrid,
						const boost::shared_ptr<YieldTermStructure>& discountCurve,
						const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

		Real calculate(const MultiPath& path,Size endPosition = 0) const;
		
		//std::vector<boost::shared_ptr<EventTriggerInfo>> getEtiList() const;
		//Real getNotional() const;
		//std::string getCurrency() const;
		//boost::shared_ptr<FixingDateInfo> getPayoffDateInfo() const;

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

		  std::vector<boost::shared_ptr<EventTriggerInfo>> autoCallEtiList_;
		  boost::shared_ptr<EventTriggerInfo> kiBarrierEventTrigger_;

		  //boost::shared_ptr<PayoffCalculation> occBarrierPayoffCalculation_;
		  //boost::shared_ptr<EventTriggerInfo> nonOccBarrierEventTrigger_;
		  boost::shared_ptr<YieldTermStructure> discountCurve_;
          //Array discount_;

		  std::vector<Date> fixingDates_;
		  std::vector<Date> payoffDates_;
	};
}

#endif