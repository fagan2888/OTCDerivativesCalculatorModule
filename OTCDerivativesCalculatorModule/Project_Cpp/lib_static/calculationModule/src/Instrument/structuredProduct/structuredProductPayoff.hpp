#ifndef calculationModule_structuredproductpayoff_hpp
#define calculationModule_structuredproductpayoff_hpp

#include <ql/payoff.hpp>
#include <ql/math/array.hpp>
#include <ql/timegrid.hpp>

#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/EventCheck/IEventCheck.hpp>
#include <iostream>

namespace QuantLib {

	const int EVENTMAXNUM = 64;

	class StructuredProductPayoff  {
		public:
			StructuredProductPayoff(const std::vector<boost::shared_ptr<IEventCheck>>& eventChecks,
									Calendar calendar);
		 
			Size assetNum() const;
			
			const Array& value() const;

			void reset() const;
			void setGridInitialize(const TimeGrid& timeGrid);

			Calendar calendar() const;
			void calculate();

			void autoCall();
			void variableBind();
			void variablePtrBind();
			void validFixingDates();
			void historyCalculate();

			std::vector<Date> indexFixingDates();
			std::vector<Date> payoffDates();
			//payReceive -> 0 : pay , 1 : Receive , 2 : both
			
			//void setTimeGrid(const TimeGrid& timeGrid);
			
		private:
			

			int sampleCount_;
			Size assetNum_;
			Array value_;

			std::vector<Size> payoffIndexLocation_;
			TimeGrid timeGrid_;
			//DayCounter payDayCounter_;
			//DayCounter receiveDayCounter_;

			Calendar calendar_;

			Size pathSize_;

			mutable bool autoCall_;

			//체크해야할 이벤트를 죄다 모아놈 
			Size initialNotional_;

			Size RemainNotional_;
			Size ECNum_;

			IEventCheck *eventChecksPtr_[EVENTMAXNUM];
			std::vector<boost::shared_ptr<IEventCheck>> eventChecks_;

	};
}

#endif