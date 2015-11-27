#ifndef quantlib_fixedRateETI_hpp
#define quantlib_fixedRateETI_hpp

#include <valarray>
#include <ql/time/daycounter.hpp>
#include <src/Engine/MonteCarlo/IRProduct/RateCalculation.hpp>

namespace QuantLib {

	//autoCallPayoffDate�� ���� �޾Ƽ� ����ؾ���... �׷��� ������ �ɵ�

	class FixedRateETI : public RateCalculation
	{
		public:
			//FixedRateETI(const DayCounter& dayCounter,
			//			Real fixedRate,
			//			const Date& calculationStartDate,
			//			const Date& calculationEndDate,
			//			const Date& paymentDate,
			//			bool isExpired);

			FixedRateETI(const DayCounter& dayCounter,
						Real fixedRate,
						const Date& calculationStartDate,
						const Date& calculationEndDate,
						const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
						bool isExpired,
						const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList = std::vector<boost::shared_ptr<VariableInfo>>() );


			void initializeImpl(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);
			
			std::vector<Date> fixingDates() const;
			std::vector<Date> payoffDates() const;

			Real autoCallPayoff(const MultiPath& path,Size position);

			Real payoffImpl(const MultiPath& path,Size endPosition);
			bool pastEventOcc();;
			bool checkEvent(const MultiPath& path,Size endPosition);;

			Real accrualRate(const MultiPath& path,const Date& refDate) const;
			//Real accrualAmount();

		protected:
			boost::shared_ptr<FixingDateInfo> payoffDateInfo_;
			Real fixedRate_;


	};
}

#endif