#ifndef quantlib_mc_vanillapricer_engine_hpp
#define quantlib_mc_vanillapricer_engine_hpp

#include <boost/shared_ptr.hpp>

#include <src/Engine/MonteCarlo/MCPricer.hpp>
#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>
#include <ql/termstructures/yieldtermstructure.hpp>
//-----------------------------	Pricer -----------------------------------------

namespace QuantLib {

    class VanillaPricer : public MCPricer {
      public:
        VanillaPricer(const boost::shared_ptr<EventTriggerInfo>& eventTriggerInfo,
				      const boost::shared_ptr<YieldTermStructure>& discountCurve);

		void initializeImpl(const TimeGrid& timeGrid,
						const boost::shared_ptr<YieldTermStructure>& discountCurve,
						const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

		

		Real calculate(const MultiPath& path,Size endPosition = 0) const;

		std::vector<Date> fixingDates() const;
		std::vector<Date> payoffDates() const;
	protected:
		void resetImpl() const;


      private:
		  boost::shared_ptr<EventTriggerInfo> eventTriggerInfo_;
		  boost::shared_ptr<YieldTermStructure> discountCurve_;
	};
}

#endif