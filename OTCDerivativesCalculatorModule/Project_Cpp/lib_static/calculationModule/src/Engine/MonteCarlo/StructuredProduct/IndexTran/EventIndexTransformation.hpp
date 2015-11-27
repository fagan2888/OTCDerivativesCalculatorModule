#ifndef calculationModule_eventIndexTransformation_hpp
#define calculationModule_eventIndexTransformation_hpp

#include <vector>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/IndexTran/IndexTransSetting.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/IndexTran/IndexTransBase.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/VariableValue/VariableValue.hpp>


namespace QuantLib {
	
	class EventIndexTransformation {
		public:	
			EventIndexTransformation(std::vector<boost::shared_ptr<VariableValue>> variableValues);
				//std::vector<boost::shared_ptr<IndexTransBase>> transBases);

			Size size();
			void initialize(const std::vector<Date>& eventDates);
			//void setTimeInformation(const std::vector<Date>& eventDates);

			void calculate();
			void calculate(Size timePosition);
			//요기 ㄱㄱㄱ
			void variableBind();
			void variablePtrBind();
			void validFixingDates(const std::vector<Date>& eventDates);

			std::vector<Date> indexFixingDates();

		private:

			//mu::Parser parser_;
			const std::vector<std::string> symbolList_;
			
			// transBasesPtr_ 와 pair 같이 소멸
			std::vector<boost::shared_ptr<VariableValue>> variableValues_;
			VariableValue *variableValuesPtr_[INDEXMAXNUM]; //
			Size variableValueNum_;
			
	
	};

}

#endif