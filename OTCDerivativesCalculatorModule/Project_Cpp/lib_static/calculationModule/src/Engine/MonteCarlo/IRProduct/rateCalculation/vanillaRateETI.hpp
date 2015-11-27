#ifndef quantlib_vanillaRateETI_hpp
#define quantlib_vanillaRateETI_hpp

#include <valarray>
#include <ql/time/daycounter.hpp>
#include <src/Engine/MonteCarlo/IRProduct/RateCalculation.hpp>

namespace QuantLib {

	class VanillaRateETI : public RateCalculation
	{
		public:
			VanillaRateETI(const DayCounter& dayCounter,
								const Date& calculationStartDate,
								const Date& calculationEndDate,
								const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
								const boost::shared_ptr<ReferenceCalculation>& refCalc,
								Real gearing,
								Real spread,
								Real outGearing,
								Real outSpread,
								Real cap,
								Real floor,
								const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList = std::vector<boost::shared_ptr<VariableInfo>>() );

			void initializeImpl(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			Real payoffImpl(const MultiPath& path,Size endPosition);
			bool pastEventOcc();;
			bool checkEvent(const MultiPath& path,Size endPosition);;
			Real payoffImplEarlyEx(const MultiPath& path,Size endPosition);

			std::vector<Date> fixingDates() const;
			std::vector<Date> payoffDates() const;

			Real accrualRate(const MultiPath& path,const Date& refDate) const;

		protected:
			boost::shared_ptr<ReferenceCalculation> refCalc_;

			Real gearing_;
			Real spread_;
			Real outGearing_;
			Real outSpread_;
			Real cap_;
			Real floor_;

	};
}

#endif