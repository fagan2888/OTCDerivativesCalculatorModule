#ifndef quantlib_mc_VanillaStandardStreamPricer_hpp
#define quantlib_mc_VanillaStandardStreamPricer_hpp

#include <boost/shared_ptr.hpp>

#include <src/Engine/MonteCarlo/MCPricer.hpp>
#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>
#include <ql/termstructures/yieldtermstructure.hpp>
//-----------------------------	Pricer -----------------------------------------

namespace QuantLib {

    class VanillaStandardStreamPricer : public MCPricer {
      public:
        VanillaStandardStreamPricer(const std::vector<boost::shared_ptr<EventTriggerInfo>>& eventTriggerList);

		void initialize(const TimeGrid& timeGrid,
						const boost::shared_ptr<YieldTermStructure>& discountCurve,
						const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

		

		Real calculate(const MultiPath& path,Size endPosition = 0) const;

		std::vector<Date> fixingDates() const;
		std::vector<Date> payoffDates() const;
		void reset() const;


      private:
		  Size eventTriggerInfoListNum_;
		  std::vector<boost::shared_ptr<EventTriggerInfo>> eventTriggerList_;
		  boost::shared_ptr<YieldTermStructure> discountCurve_;
		  Array discount_;
	};
}

#endif