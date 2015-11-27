#ifndef calculationModule_complexVariableValue_hpp
#define calculationModule_complexVariableValue_hpp

#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/variablevalue/variablevalue.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/IndexTran/IndexTransBase.hpp>
#include <calculationModule/src/index/underlyingIndex.hpp>

namespace QuantLib {
	
	class ComplexVariableValue : public VariableValue {
	
		public:
			//not binding �Ȱ��, ���� ���ε� ��.
			//-----------------�׳� ������ symbol�� �Ѿ�� ���-------------------
			ComplexVariableValue(const std::string& symbolName);

			//-----------------defind�� symbol�� �Ѿ�� ���-------------------
			ComplexVariableValue(boost::shared_ptr<IndexTranseBase> itb,
								 const std::string& symbolName);

			//override interface
			void addVariableValue(const boost::shared_ptr<VariableValue>& variableValue);
			void valuePtrBinding();
			void calculateLastIndexFixing(const std::vector<std::string>& circulationCheckString);
			std::vector<Date> indexFixingDates();

		private:
			//void setHistoryValue(const Date& eventDates);

			boost::shared_ptr<IndexTranseBase> itb_;

	};

}

#endif