#ifndef quantlib_mc_vanillacrediteventpricer_engine_hpp
#define quantlib_mc_vanillacrediteventpricer_engine_hpp

#include <boost/shared_ptr.hpp>

#include <src/Engine/MonteCarlo/MCPricer.hpp>
#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>
#include <ql/termstructures/yieldtermstructure.hpp>
#include <ql/termstructures/defaulttermstructure.hpp>
//-----------------------------	Pricer -----------------------------------------

namespace QuantLib {

    class VanillaCreditEventPricer : public MCPricer {
      public:
        VanillaCreditEventPricer(
					  const std::vector<boost::shared_ptr<EventTriggerInfo>>& eventTriggerInfo,
				      //const boost::shared_ptr<YieldTermStructure>& discountCurve,
					  const boost::shared_ptr<DefaultProbabilityTermStructure>& defaultCurve);

		void initializeImpl(const TimeGrid& timeGrid,
						const boost::shared_ptr<YieldTermStructure>& discountCurve,
						const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

		Real calculate(const MultiPath& path,Size endPosition = 0) const;

		std::vector<Date> fixingDates() const;
		std::vector<Date> payoffDates() const;
	  
	  protected:
		void resetImpl() const;

      private:
		  std::vector<boost::shared_ptr<EventTriggerInfo>> eventTriggerInfoList_;
		  boost::shared_ptr<YieldTermStructure> discountCurve_;
		  boost::shared_ptr<DefaultProbabilityTermStructure> defaultCurve_;
	};
}

#endif