#ifndef calculationModule_complexTimeFunctionVariableValue_hpp
#define calculationModule_complexTimeFunctionVariableValue_hpp

#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/variablevalue/variablevalue.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/IndexTran/IndexTransBase.hpp>
#include <calculationModule/src/index/underlyingIndex.hpp>

namespace QuantLib {
	
	class ComplexTimeFunctionVariableValue : public VariableValue , public boost::enable_shared_from_this<ComplexTimeFunctionVariableValue> {
	
		public:
			//not binding 된경우, 차후 바인딩 됨.
			//-----------------그냥 껍데기 symbol이 넘어온 경우-------------------
			ComplexTimeFunctionVariableValue(const std::string& symbolName);

			//이 생성자는 qlVariableValueFactory에서 안만들고 각각 transFactory에서 만들거임
			//-----------------defind할 symbol이 넘어온 경우-------------------
			ComplexTimeFunctionVariableValue(const boost::shared_ptr<IndexTransBase>& itb,
											 const std::vector<Date>& calDates,
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

			void calculate();
			void registManager();

		private:
			//void setHistoryValue(const Date& eventDates);
			Size timePositionNum_;
			std::vector<Date> calDates_;
			boost::shared_ptr<IndexTransBase> itb_;
			std::vector<boost::shared_ptr<VariableValue>> addedVariableValues_;
	};

}

#endif