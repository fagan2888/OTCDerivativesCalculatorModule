#ifndef quantlib_redemptionNotionalETI_hpp
#define quantlib_redemptionNotionalETI_hpp

#include <valarray>
#include <ql/time/daycounter.hpp>
#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>

namespace QuantLib {

	class RedemptionNotionalETI : public EventTriggerInfo
	{
		public:
			RedemptionNotionalETI(Real notionalAmount,
								  const boost::shared_ptr<QuantLib::FixingDateInfo>& payoffDateInfo,
								  const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList);

			void initializeImpl(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			std::vector<Date> fixingDates() const;
			std::vector<Date> payoffDates() const;

			Real payoffImpl(const MultiPath& path,Size endPosition);
			bool pastEventOcc();;
			bool checkEvent(const MultiPath& path,Size endPosition);;

		protected:
			Real notionalAmount_;
			Date payoffDate_;


	};
}

#endif