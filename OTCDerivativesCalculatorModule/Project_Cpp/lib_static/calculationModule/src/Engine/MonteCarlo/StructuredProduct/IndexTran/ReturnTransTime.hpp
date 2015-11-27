#ifndef calculationModule_ReturnTransTime_hpp
#define calculationModule_ReturnTransTime_hpp

#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/IndexTran/IndexTransBase.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/symbolmanager/pathinformation.hpp>
#include <calculationModule/src/index/underlyingIndex.hpp>

namespace QuantLib {
	
	class ReturnTransTime : public IndexTransBase {
	
		public:
			ReturnTransTime(const boost::shared_ptr<VariableValue>& numerVariableValue,
						    const boost::shared_ptr<VariableValue>& denumerVariableValue,
							const std::string& symbolName);
							//const boost::shared_ptr<EventFunction>& domainSet);

			void initialize();

			Size size();

			//timeEvent 계열에서 사용할것임.
			//void initialize(const std::vector<Date>& eventDates);

			// daily 의 경우 today 까지만 setting이 되고 그 이후는 적당히 끊어서 
			// std::vector<Date> 여기에 저장됨.
			

			std::vector<Date> indexFixingDates();

		private:
			void calValue(int refDatePosition);

			boost::shared_ptr<VariableValue> numerVariableValue_;
			boost::shared_ptr<VariableValue> denumerVariableValue_;

			Real* thisPtr_;
			Real* numerPtr_;
			Real* denumerPtr_;

			std::vector<Real> numerFixedValue_;
			std::vector<Real> denumerFixedValue_;

	};

}

#endif