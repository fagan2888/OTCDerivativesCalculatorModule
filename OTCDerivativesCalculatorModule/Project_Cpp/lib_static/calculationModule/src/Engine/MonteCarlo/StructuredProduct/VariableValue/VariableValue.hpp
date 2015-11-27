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
			
			//not binding �Ȱ��, ���� ���ε� ��.
			
			bool variableBindingFlag();
			Date fixingDate();
			Real* getPtr();

			//time�� ��쿡 ���ÿ�
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

			//complex�ΰ�츸 �����.
			virtual void calculate(){}

			//time�� ��츸 �����.
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
			
			//bool itbBindingFlag_; // Complex�� ��쿡 IndexTransBase �� ��� ����� �ǹ��ϴµ�, �̰� ���ε� �Ǿ�� ������.
			bool variableBindingFlag_; // Complex�� ��쿡 VariableValue�� added�� ��� added �Ǿ�� ������. �� add�ȰŴ� �� variable ���� �˻���(�˻�� indexSymbolmanger���� �˻��Ұ���), ���Ŀ� ��������� �ƴ� ptr swap�� �����.

			bool ptrBindingFlag_;
			bool setSymbolManagerFlag_;
			bool initializeFlag_;

			void setHistoryValue(const Date& eventDates); // ?

			std::vector< boost::shared_ptr<VariableValue> > addedVariableValues_;

			std::vector<Date> indexFixingDates_; 
			std::vector<Date> eventDates_; 
			std::string symbolName_; //�̰� ������� �ʴ� variableValue �� ����.
			Date lastFixingDate_;

	};

}

#endif