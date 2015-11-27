#ifndef calculationModule_simpleVariableValue_hpp
#define calculationModule_simpleVariableValue_hpp

#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/variablevalue/variablevalue.hpp>
#include <calculationModule/src/index/underlyingIndex.hpp>

namespace QuantLib {
	
	class SimpleVariableValue : public VariableValue{
	
		public:
			SimpleVariableValue(const boost::shared_ptr<Index>& baseIndex,
							    const Date& date,
							    const std::string& symbolName = std::string());
			
			//이거 어떻게 처리 하지..?
			SimpleVariableValue(const boost::shared_ptr<Index>& baseIndex,
							    Integer fixingDays,
							    const std::string& symbolName = std::string());

			//override interface
			void addVariableValue(const boost::shared_ptr<VariableValue>& variableValue);
			void valuePtrBinding();
			void calculateLastIndexFixing(const std::vector<std::string>& circulationCheckString);
			std::vector<Date> indexFixingDates();

		private:
			//add method
			boost::shared_ptr<Index> baseIndex_;


	};

}

#endif