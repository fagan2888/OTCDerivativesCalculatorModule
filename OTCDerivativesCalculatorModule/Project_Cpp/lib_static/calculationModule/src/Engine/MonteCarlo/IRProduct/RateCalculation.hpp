#ifndef quantlib_RateCalculation_hpp
#define quantlib_RateCalculation_hpp

#include <valarray>
#include <ql/time/daycounter.hpp>
#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>

namespace QuantLib {

	class RateCalculation : public EventTriggerInfo
	{
		public:
			//yearFraction계산될때 calStartDate와 calEndDate 모두 포함대서 계산됨.
			//그러므로 넣을때 알아서 넣어야함.
			RateCalculation(const DayCounter& dayCounter,
							const Date& calculationStartDate,
							const Date& calculationEndDate,
							const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList);
			

			//virtual Real accrualRate(const MultiPath& path,const Date& refDate) const { return 0.0; }
			//virtual Real accrualAmount() const { return 0.0; }

		protected:
			void setYearFracValues(const TimeGrid& timeGrid);
			//Real accrualAmount(const MultiPath& path,Size endPosition);
			
		protected:

			DayCounter dayCounter_;
			Date calculationStartDate_;
			Date calculationEndDate_;

			Size calculationStartPosition_;
			Size calculationEndPosition_;

			Real couponYearFraction_;

			//autoCall을 대비한 yearFraction 계산용,,,?

			std::valarray<Real> yearFracValues_;

	};
}

#endif