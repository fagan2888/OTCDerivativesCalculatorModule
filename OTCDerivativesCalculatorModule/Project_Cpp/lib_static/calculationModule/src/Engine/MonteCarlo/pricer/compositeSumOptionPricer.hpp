#ifndef quantlib_compositeSumOptionPricer_hpp
#define quantlib_compositeSumOptionPricer_hpp

#include <boost/shared_ptr.hpp>

#include <src/Engine/MonteCarlo/MCPricer.hpp>
#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>
//-----------------------------	Pricer -----------------------------------------

namespace QuantLib {

    class CompositeSumOptionPricer : public MCPricer {
      public:
        CompositeSumOptionPricer(//const boost::shared_ptr<QuantLib::FixingDateInfo>& fixingDateInfo,
								 //const boost::shared_ptr<QuantLib::FixingDateInfo>& payoffDateInfo,
								 //const boost::shared_ptr<ReferenceCalculation> referenceCal,
								 Real notionalPayment,
								 const boost::shared_ptr<QuantLib::FixingDateInfo>& payoffDateInfo, // notional pay용 나머지는 각각의 안에 있음.
								 const std::vector<boost::shared_ptr<EventTriggerInfo>>& optionList);

		void initializeImpl(const TimeGrid& timeGrid,
						const boost::shared_ptr<YieldTermStructure>& discountCurve,
						const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

		Real calculate(const MultiPath& path,Size endPosition = 0) const;

		std::vector<Date> fixingDates() const ;
		std::vector<Date> payoffDates() const;
	protected:
		void resetImpl() const;

      private:

		  Real notionalPayment_;
		  Size optionListNum_;
		  //boost::shared_ptr<ReferenceCalculation> referenceCal_;
		  std::vector<boost::shared_ptr<EventTriggerInfo>> optionList_;

		  //boost::shared_ptr<QuantLib::FixingDateInfo> fixingDateInfo_;
		  boost::shared_ptr<QuantLib::FixingDateInfo> payoffDateInfo_;

		  Array discount_;
	};
}

#endif