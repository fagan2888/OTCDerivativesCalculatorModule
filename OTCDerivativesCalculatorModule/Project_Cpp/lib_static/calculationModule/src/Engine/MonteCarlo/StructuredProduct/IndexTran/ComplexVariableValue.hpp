#ifndef calculationModule_complexVariableValue_hpp
#define calculationModule_complexVariableValue_hpp

#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/variablevalue/variablevalue.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/IndexTran/IndexTransBase.hpp>
#include <calculationModule/src/index/underlyingIndex.hpp>

namespace QuantLib {
	
	class ComplexVariableValue : public VariableValue {
	
		public:
			//not binding 된경우, 차후 바인딩 됨.
			//-----------------그냥 껍데기 symbol이 넘어온 경우-------------------
			ComplexVariableValue(const std::string& symbolName);

			//-----------------defind할 symbol이 넘어온 경우-------------------
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