#ifndef quantlib_vanillaFloatingRateRTI_hpp
#define quantlib_vanillaFloatingRateRTI_hpp

#include <valarray>
#include <ql/time/daycounter.hpp>
#include <src/Engine/MonteCarlo/IRProduct/RateCalculation.hpp>

namespace QuantLib {

	class VanillaFloatingRateRTI : public RateCalculation
	{
		public:
			VanillaFloatingRateRTI(const DayCounter& dayCounter,
								  const Date& calculationStartDate,
								  const Date& calculationEndDate,
								  const Date& paymentDate,
								  Real gearing,
								  Real spread,
								  boost::shared_ptr<EventTriggerInfo> couponCalculation,
								  bool isExpired);

			void initialize(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			Real payoff(const MultiPath& path);
			bool pastEventOcc();;
			bool checkEvent(const MultiPath& path);;

		protected:
			Date calculationStartDate_;
			Date calculationEndDate_;
			Date paymentDate_;
			boost::shared_ptr<EventTriggerInfo> couponCalculation_;
			Real gearing_;
			Real spread_;
	};
}

#endif