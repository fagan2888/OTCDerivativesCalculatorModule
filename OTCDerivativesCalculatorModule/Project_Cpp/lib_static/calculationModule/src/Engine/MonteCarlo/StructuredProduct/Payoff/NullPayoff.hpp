#ifndef calculationModule_nullpayoff_hpp
#define calculationModule_nullpayoff_hpp

#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/IndexTran/EventIndexTransformation.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/Payoff/payoffbase.hpp>

namespace QuantLib {

	class NullPayoff : public PayoffBase {
	  public:
		NullPayoff(){}
		//NullPayoff(const Date& payoffDate)

		std::vector<Date> payoffDates()
		{
			std::vector<Date> dates;
			return dates;
		}

		void calculate(){}

		bool expired()
		{
			return false;
		}

		void variableBind(){}
		void variablePtrBind(){}
		


	};

}

#endif
