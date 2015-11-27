//#ifndef calculationModule_PayoffConstVariableValue_hpp
//#define calculationModule_PayoffConstVariableValue_hpp
//
//#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/variablevalue/variablevalue.hpp>
//#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/payoff/payoffBase.hpp>
//
//#include <calculationModule/src/index/underlyingIndex.hpp>
//#include <ql/math/statistics/statistics.hpp>
//
//
//namespace QuantLib {
//	
//	//template< class S = Statistics >
//	class PayoffConstVariableValue : public VariableValue {
//	
//		public:
//			PayoffConstVariableValue(boost::shared_ptr<PayoffBase> pb,
//									 const std::string& symbolName,
//									 Real constValue);
//
//			//override interface
//			void variablePtrBind();
//			void variableBind(const std::vector<std::string>& circulationCheckString);
//			void validFixingDates(const std::vector<Date>& eventDates);
//			Date calculateLastIndexFixing();
//			std::vector<Date> indexFixingDates();
//
//			void calculate();
//			void addSample();
//
//		private:
//			//void setHistoryValue(const Date& eventDates);
//
//			boost::shared_ptr<PayoffBase> pb_;
//			Statistics sampleAccumulator_;
//			Real constValue_;
//
//	};
//
//}
//
//#endif