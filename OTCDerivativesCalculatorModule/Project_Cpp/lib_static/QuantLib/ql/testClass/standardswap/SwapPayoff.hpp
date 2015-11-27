#ifndef quantlib_SwapPayoff_hpp
#define quantlib_SwapPayoff_hpp

#include <ql/payoff.hpp>
#include <ql/math/array.hpp>
#include <ql/timegrid.hpp>

#include <ql/testClass/standardswap/eventcheck.hpp>

#include <iostream>

namespace QuantLib {

	class SwapPayoff  {
		public:
			SwapPayoff(const std::vector<boost::shared_ptr<EventCheck>>& eventChecksPay,
					   Calendar payCalendar,
					   const std::vector<boost::shared_ptr<EventCheck>>& eventChecksReceive,
					   Calendar receiveCalendar);
		 
			Size assetNumPay() const;
			Size assetNumReceive() const;
			
			const Array& payValue() const;
			const Array& receiveValue() const;

			void reset() const;
			void setGridInitialize(const TimeGrid& timeGrid);
			void calculate(const MultiPath& multiPath);
			//payReceive -> 0 : pay , 1 : Receive , 2 : both
			
			//void setTimeGrid(const TimeGrid& timeGrid);
			
		private:
			int sampleCount_;
			Size assetNumPay_;
			Size assetNumReceive_;
			Array payValue_;
			Array receiveValue_;

			std::vector<Size> payoffIndexLocationPay_;
			std::vector<Size> payoffIndexLocationReceive_;
			TimeGrid timeGrid_;
			//DayCounter payDayCounter_;
			//DayCounter receiveDayCounter_;

			Calendar payCalendar_;
			Calendar receiveCalendar_;

			Size pathSize_;

			//체크해야할 이벤트를 죄다 모아놈 
			Size initialNotionalPay_;
			Size initialNotionalReceive_;

			Size RemainNotionalPay_;
			Size RemainNotionalReceive_;

			std::vector<boost::shared_ptr<EventCheck>> eventChecksPay_;
			std::vector<boost::shared_ptr<EventCheck>> eventChecksReceive_;

	};
}

#endif