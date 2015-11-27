#ifndef calculationModule_complexTimeVariableValue_hpp
#define calculationModule_complexTimeVariableValue_hpp

#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/variablevalue/variablevalue.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/IndexTran/IndexTransBase.hpp>
#include <calculationModule/src/index/underlyingIndex.hpp>

namespace QuantLib {
	
	class ComplexTimeVariableValue : public VariableValue , public boost::enable_shared_from_this<ComplexTimeVariableValue> {
	
		public:
			//not binding �Ȱ��, ���� ���ε� ��.
			//-----------------�׳� ������ symbol�� �Ѿ�� ���-------------------
			ComplexTimeVariableValue(const std::string& symbolName);

			//�� �����ڴ� qlVariableValueFactory���� �ȸ���� ���� transFactory���� �������
			//-----------------defind�� symbol�� �Ѿ�� ���-------------------
			ComplexTimeVariableValue(const boost::shared_ptr<IndexTransBase>& itb,
									 const std::string& symbolName,
									 const std::vector<boost::shared_ptr<VariableValue>>& addedVariableValues
									 );

			//override interface
			void initialize(const std::vector<Date>& eventDates);
			void variableBind(const std::vector<std::string>& circulationCheckString);
			void variablePtrBind();
			void validFixingDates(const std::vector<Date>& eventDates);
			Date calculateLastIndexFixing();
			std::vector<Date> indexFixingDates();

			void calculate(Size timePosition);
			void registManager();

		private:
			//void setHistoryValue(const Date& eventDates);

			boost::shared_ptr<IndexTransBase> itb_;
			std::vector<boost::shared_ptr<VariableValue>> addedVariableValues_;
	};

}

#endif