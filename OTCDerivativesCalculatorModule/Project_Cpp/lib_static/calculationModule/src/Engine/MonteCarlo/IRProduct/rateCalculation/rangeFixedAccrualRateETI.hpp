#ifndef quantlib_RangeFixedAccrualRateETI_hpp
#define quantlib_RangeFixedAccrualRateETI_hpp

#include <valarray>
#include <ql/time/daycounter.hpp>
#include <src/Engine/MonteCarlo/IRProduct/rateCalculation.hpp>
#include <src/Engine/MonteCarlo/referenceCalculation/referenceTimeCalculation.hpp>
#include <src/Engine/MonteCarlo/eventCalculation/jointEventCalculation/rangeJointCal/range1DJointCalculation.hpp>

namespace QuantLib {

	class RangeFixedAccrualRateETI : public RateCalculation
	{
		public:
			RangeFixedAccrualRateETI(const DayCounter& dayCounter,
									const Date& calculationStartDate,
									const Date& calculationEndDate,
									const std::vector<Real>& weight,
									const std::vector<boost::shared_ptr<EventCalculation>>& eventCals,
									const std::vector<boost::shared_ptr<ReturnCalculation>>& returnCals,
									const boost::shared_ptr<ReturnCalculation>& complementReturnCal,
									const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
									bool isExpired,
									const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList);

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

			Size rangeEventSize_;
			std::valarray<Real> accrualNumArr_;
			std::vector<Real> weight_;
			std::vector<boost::shared_ptr<EventCalculation>> eventCals_;
			std::vector<boost::shared_ptr<ReturnCalculation>> returnCals_;
			boost::shared_ptr<ReturnCalculation> complementReturnCal_;

	};
}

#endif