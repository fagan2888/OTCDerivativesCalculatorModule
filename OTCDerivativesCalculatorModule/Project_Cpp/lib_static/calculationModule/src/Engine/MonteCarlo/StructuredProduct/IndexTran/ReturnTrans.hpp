#ifndef calculationModule_returnTrans_hpp
#define calculationModule_returnTrans_hpp

#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/IndexTran/IndexTransBase.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/symbolmanager/pathinformation.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/variableValue/variableValue.hpp>

namespace QuantLib {
	
	class ReturnTrans : public IndexTransBase {
	
		public:
			ReturnTrans(const boost::shared_ptr<VariableValue>& numerVariableValue,
						const boost::shared_ptr<VariableValue>& denumerVariableValue,
						const std::string& symbolName);

			void initialize();
			Size size();

			void variableBind();
			void variablePtrBind();
			void calculate();

			std::vector<Date> indexFixingDates();

		private:
			void calValue();

			Real* numerPtr_;
			Real* denumerPtr_;

			boost::shared_ptr<VariableValue> numerVariableValue_;
			boost::shared_ptr<VariableValue> denumerVariableValue_;

			// 과거에 fix되는 경우에 사용함.
			Real numerFixedValue_;
			Real denumerFixedValue_;
	};

}

#endif