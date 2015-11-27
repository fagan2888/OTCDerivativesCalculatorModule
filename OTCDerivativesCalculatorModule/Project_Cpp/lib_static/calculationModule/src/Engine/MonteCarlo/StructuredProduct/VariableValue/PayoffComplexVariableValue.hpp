#ifndef calculationModule_PayoffComplexVariableValue_hpp
#define calculationModule_PayoffComplexVariableValue_hpp

#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/variablevalue/variablevalue.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/payoff/payoffBase.hpp>
#include <calculationModule/src/index/underlyingIndex.hpp>
#include <ql/math/statistics/statistics.hpp>


namespace QuantLib {
	
	//template< class S = Statistics >
	class PayoffComplexVariableValue : public VariableValue , public boost::enable_shared_from_this<PayoffComplexVariableValue> {
	
		public:
			PayoffComplexVariableValue(const std::string& symbolName);

			PayoffComplexVariableValue(const boost::shared_ptr<PayoffBase>& pb,
										 const std::string& symbolName,
										 const std::vector<boost::shared_ptr<VariableValue>>& addedVariableValues);

			//override interface
			void variablePtrBind();
			void variableBind(const std::vector<std::string>& circulationCheckString);
			void validFixingDates(const std::vector<Date>& eventDates);
			Date calculateLastIndexFixing();
			std::vector<Date> indexFixingDates();

			void calculate();
			void addSample();

			void registManager();

		private:
			//void setHistoryValue(const Date& eventDates);

			boost::shared_ptr<PayoffBase> pb_;
			Statistics sampleAccumulator_;
			std::vector<boost::shared_ptr<VariableValue>> addedVariableValues_;


	};

}

#endif