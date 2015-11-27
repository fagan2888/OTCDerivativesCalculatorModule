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

			//timeEvent �迭���� ����Ұ���.
			//void initialize(const std::vector<Date>& eventDates);

			// daily �� ��� today ������ setting�� �ǰ� �� ���Ĵ� ������ ��� 
			// std::vector<Date> ���⿡ �����.
			

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