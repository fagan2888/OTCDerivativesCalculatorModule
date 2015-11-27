#ifndef quantlib_MultiConditionMultiRngAccrualCouponRateETI_hpp
#define quantlib_MultiConditionMultiRngAccrualCouponRateETI_hpp

#include <valarray>
#include <ql/time/daycounter.hpp>
#include <src/Engine/MonteCarlo/IRProduct/RateCalculation.hpp>
#include <src/Engine/MonteCarlo/IRProduct/rateCalculation/rangeND.hpp>

namespace QuantLib {

	class MultiConditionMultiRngAccrualCouponRateETI : public RateCalculation
	{
		public:
			MultiConditionMultiRngAccrualCouponRateETI(const DayCounter& dayCounter,
											const std::vector<boost::shared_ptr<RangeND>>& rangeNDList,
											const std::vector<boost::shared_ptr<ReturnCalculation>>& returnCalcList,
											Real accrualDateNum, // �̰� accrual�� rate�� �������� �����.
											const boost::shared_ptr<DateInformation>& dateInfo, // interval ��.
											const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
											bool isExpired,
											const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList = std::vector<boost::shared_ptr<VariableInfo>>() );

			void initializeImpl(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			Real payoffImpl(const MultiPath& path,Size endPosition);
			//Real payoffImplEarlyEx(const MultiPath& path,Size endPosition);

			bool pastEventOcc();
			bool checkEvent(const MultiPath& path,Size endPosition);

			std::vector<Date> fixingDates() const;
			std::vector<Date> payoffDates() const;

		private:
			bool eventOcc_;

			std::vector<boost::shared_ptr<RangeND>> rangeNDList_;
			std::vector<boost::shared_ptr<ReturnCalculation>> returnCalcList_;
			
			boost::shared_ptr<DateInformation> dateInfo_; // interval ��.
			std::valarray<Size> fixingDatePosition_;
			boost::shared_ptr<FixingDateInfo> payoffDateInfo_;
			
			Real accrualDateNum_; // accrual �� rate�� ��Ȯ�� ���������� ����.
			Real convertedAccrualDateNumFactor_;// �̰� ������ ����
			bool isExpired_;
	};
}

#endif