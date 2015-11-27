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

			//multiPath �� ������� �Ŀ� position ��ġ ���ε� ��Ŵ
			//indexFixing �� ��������鼭 binding �� �ȵǹǷ�.. .���..�Ѥ�

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