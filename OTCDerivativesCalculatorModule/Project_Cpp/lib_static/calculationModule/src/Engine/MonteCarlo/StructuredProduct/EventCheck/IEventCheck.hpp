#ifndef calculationModule_ieventcheck_hpp
#define calculationModule_ieventcheck_hpp

#include <ql/timegrid.hpp>
#include <ql/time/calendar.hpp>
#include <ql/methods/montecarlo/multipath.hpp>


namespace QuantLib {

	class IEventCheck {

		public:
			~IEventCheck(){}

			virtual void calculate() = 0;
			virtual Real payoff() = 0;

			virtual void reset() = 0;

			virtual void historyCalculate() = 0;
			virtual bool eventOcc() = 0;
			virtual bool eventHistoryOcc() = 0;
			virtual void variableBind() = 0;
			virtual void variablePtrBind() = 0;
			virtual void validFixingDates() = 0;

			//multiPath 가 만들어진 후에 position 위치 바인딩 시킴
			//indexFixing 이 만들어지면서 binding 이 안되므로.. .흐어..ㅡㅠ

			virtual bool bindingFlag() = 0;

			virtual std::vector<Date> indexFixingDates() = 0;
			virtual std::vector<Date> payoffDates() = 0;

		protected:
			
			bool isExpired_;
			bool isCalFlag_;
			bool eventOccFlag_;
			bool eventOccHistoryFlag_;
			bool bindingFlag_;
			
			bool isHistoryCalFlag_;
	};

}

#endif