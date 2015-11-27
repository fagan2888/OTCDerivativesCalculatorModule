#ifndef calculationModule_MinimumTrans_hpp
#define calculationModule_MinimumTrans_hpp

#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/IndexTran/IndexTransBase.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/symbolmanager/pathinformation.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/variableValue/variableValue.hpp>
#include <calculationModule/src/index/underlyingIndex.hpp>

namespace QuantLib {
	
	class MinimumTrans : public IndexTransBase {
	
		public:
			MinimumTrans(const std::string& symbolName,
						   const std::vector<boost::shared_ptr<VariableValue>>& refVariableValue);

			void initialize();
			Size size();

			void variableBind();
			void variablePtrBind();

			void calculate();
			
			std::vector<Date> indexFixingDates();

		private:
			void calValue();
			std::vector<Real*> refVariablePtr_;
			
			// 과거에 fix되는 경우에 사용함.
			std::vector<boost::shared_ptr<VariableValue>> refVariableValue_;
			Size refVariableSize_;
	};

}

#endif