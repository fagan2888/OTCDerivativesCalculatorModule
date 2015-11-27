#ifndef calculationModule_constVariableValue_hpp
#define calculationModule_constVariableValue_hpp

#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/variablevalue/variablevalue.hpp>

namespace QuantLib {
	
	class ConstVariableValue : public VariableValue , public boost::enable_shared_from_this<ConstVariableValue> {
	
		public:
			ConstVariableValue(Real constValue,
								const std::string& symbolName,
								const Date& date);

			ConstVariableValue(Real constValue);

			ConstVariableValue(Real constValue,const Date& fixingDate);

			//override from interface
			void variablePtrBind();
			Date calculateLastIndexFixing();

			void variableBind(const std::vector<std::string>& circulationCheckString);
			void validFixingDates(const std::vector<Date>& eventDates);

			//std::vector<Date> indexFixingDates(const std::vector<Date>& remainEventDates);
			std::vector<Date> indexFixingDates();

			void registManager();

		private:
	};

}

#endif