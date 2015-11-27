#ifndef calculationModule_SimpleTimeVariableValue_hpp
#define calculationModule_SimpleTimeVariableValue_hpp

#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/variablevalue/variablevalue.hpp>
#include <calculationModule/src/index/underlyingIndex.hpp>


namespace QuantLib {
	
	class SimpleTimeVariableValue : public VariableValue{
	
		public:
			
			//이 timeStyle VariableValue 는 timestyle event에서 한번만 사용 되며,
			// 다른 timestyle event에서 사용 할 수 없음.
			// timeStyle 이 아니면 timeStyle을 가질 수 없음.
			//이거 어떻게 처리 하지..?
			SimpleTimeVariableValue(const boost::shared_ptr<Index>& baseIndex,
							    Integer fixingDays = 0,
							    const std::string& symbolName = std::string());

			//override interface

			void initialize(const std::vector<Date>& eventDates);

			void variablePtrBind();
			void variableBind(const std::vector<std::string>& circulationCheckString);
			Date calculateLastIndexFixing();
			std::vector<Date> indexFixingDates();
			
			void validFixingDates(const std::vector<Date>& eventDates);

			void registManager(){};

			void calculate();
			void calculate(Size timePosition);

		private:
			//add method
			bool eventDatesInitializeFlag_;
			boost::shared_ptr<Index> baseIndex_;
			Size timePositionNum_;
			Integer fixingDays_;

			std::valarray<double*> timePtr_;
			std::valarray<double> timeValue_;

	};

}

#endif