#ifndef calculationModule_variableValue_hpp
#define calculationModule_variableValue_hpp

#include <calculationModule/src/index/underlyingIndex.hpp>
#include <valarray>
#include <boost/enable_shared_from_this.hpp>

namespace QuantLib {
	
	class VariableValue  {
	
		public:
			VariableValue();
			virtual ~VariableValue()
			{
				3;
			};
			//VariableValueManager(const boost::shared_ptr<Index>& baseIndex,
			//					 const std::string& symbolName);
			
			//not binding 된경우, 차후 바인딩 됨.
			
			bool variableBindingFlag();
			Date fixingDate();
			Real* getPtr();

			//time의 경우에 세팅용
			virtual void initialize(const std::vector<Date>& eventDates)
			{
				eventDates_ = eventDates;
			}
			std::vector<Date> eventDates(){return this->eventDates_;}
			virtual void variablePtrBind() = 0;
			virtual Date calculateLastIndexFixing() = 0;
			virtual void variableBind(const std::vector<std::string>& circulationCheckString = std::vector<std::string>()) = 0;
			virtual void validFixingDates(const std::vector<Date>& eventDates) = 0;

			virtual std::vector<Date> indexFixingDates() = 0;
			
			virtual void registManager() = 0;

			//complex인경우만 사용함.
			virtual void calculate(){}

			//time인 경우만 사용함.
			virtual void calculate(Size timePosition)
			{
				this->calculate();
			}

			std::string symbolName();
			//std::vector<Date> indexFixingDates(const std::vector<Date>& remainEventDates) = 0;
			

		protected:
			Real value_;
			Real* valuePtr_;
			bool historyFixingFlag_; // ?
			
			//bool itbBindingFlag_; // Complex의 경우에 IndexTransBase 가 계산 방법을 의미하는데, 이게 바인딩 되어야 동작함.
			bool variableBindingFlag_; // Complex의 경우에 VariableValue가 added된 경우 added 되어야 동작함. 그 add된거는 그 variable 에서 검사함(검사는 indexSymbolmanger에서 검사할거임), 차후에 등록형식이 아닌 ptr swap을 사용함.

			bool ptrBindingFlag_;
			bool setSymbolManagerFlag_;
			bool initializeFlag_;

			void setHistoryValue(const Date& eventDates); // ?

			std::vector< boost::shared_ptr<VariableValue> > addedVariableValues_;

			std::vector<Date> indexFixingDates_; 
			std::vector<Date> eventDates_; 
			std::string symbolName_; //이걸 사용하지 않는 variableValue 도 있음.
			Date lastFixingDate_;

	};

}

#endif