#ifndef calculationModule_complexVariableValue_hpp
#define calculationModule_complexVariableValue_hpp

#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/variablevalue/variablevalue.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/IndexTran/IndexTransBase.hpp>
#include <calculationModule/src/index/underlyingIndex.hpp>

namespace QuantLib {
	
	class ComplexVariableValue : public VariableValue , public boost::enable_shared_from_this<ComplexVariableValue> {
	
		public:
			//not binding �Ȱ��, ���� ���ε� ��.
			//-----------------�׳� ������ symbol�� �Ѿ�� ���-------------------
			ComplexVariableValue(const std::string& symbolName);

			//-----------------defind�� symbol�� �Ѿ�� ���-------------------
			ComplexVariableValue(boost::shared_ptr<IndexTransBase> itb,
								 const std::string& symbolName,
								 const std::vector<boost::shared_ptr<VariableValue>>& addedVariableValues);

			//override interface
			void initialize(const std::vector<Date>& eventDates);
			
			void variablePtrBind();
			void variableBind(const std::vector<std::string>& circulationCheckString);
			void validFixingDates(const std::vector<Date>& eventDates);
			Date calculateLastIndexFixing();
			std::vector<Date> indexFixingDates();

			void calculate();
			void calculate(Size timePosition);
			void registManager();

		private:
			//void setHistoryValue(const Date& eventDates);


			boost::shared_ptr<IndexTransBase> itb_;
			std::vector<boost::shared_ptr<VariableValue>> addedVariableValues_;


	};

}

#endif