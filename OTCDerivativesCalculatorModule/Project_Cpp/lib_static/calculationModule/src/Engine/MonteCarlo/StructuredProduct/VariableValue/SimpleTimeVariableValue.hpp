#ifndef calculationModule_SimpleTimeVariableValue_hpp
#define calculationModule_SimpleTimeVariableValue_hpp

#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/variablevalue/variablevalue.hpp>
#include <calculationModule/src/index/underlyingIndex.hpp>


namespace QuantLib {
	
	class SimpleTimeVariableValue : public VariableValue{
	
		public:
			
			//�� timeStyle VariableValue �� timestyle event���� �ѹ��� ��� �Ǹ�,
			// �ٸ� timestyle event���� ��� �� �� ����.
			// timeStyle �� �ƴϸ� timeStyle�� ���� �� ����.
			//�̰� ��� ó�� ����..?
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