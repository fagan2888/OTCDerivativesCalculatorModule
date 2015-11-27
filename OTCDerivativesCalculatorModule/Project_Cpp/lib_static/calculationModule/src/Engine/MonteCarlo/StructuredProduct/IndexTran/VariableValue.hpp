#ifndef calculationModule_variableValue_hpp
#define calculationModule_variableValue_hpp

#include <calculationModule/src/index/underlyingIndex.hpp>

namespace QuantLib {
	
	class VariableValue {
	
		public:
			//VariableValueManager(const boost::shared_ptr<Index>& baseIndex,
			//					 const std::string& symbolName);
			
			//not binding 된경우, 차후 바인딩 됨.
			
			bool itbBindingFlag();
			Date fixingDate();
			Real* getPtr();

			virtual void addVariableValue(const boost::shared_ptr<VariableValue>& variableValue) = 0;
			virtual void valuePtrBinding() = 0;
			virtual void calculateLastIndexFixing(const std::vector<std::string>& circulationCheckString) = 0;
			virtual std::vector<Date> indexFixingDates() = 0;

			//std::vector<Date> indexFixingDates(const std::vector<Date>& remainEventDates) = 0;
			

		protected:
			Real value_;
			Real* valuePtr_;
			bool historyFixingFlag_; // ?
			bool itbBindingFlag_;
			bool ptrBindingFlag_;

			void setHistoryValue(const Date& eventDates); // ?

			std::vector< boost::shared_ptr<VariableValue> > addedVariableValues_;

			std::vector<Date> indexFixingDates_;
			std::string symbolName_;
			Date lastFixingDate_;


	};

}

#endif