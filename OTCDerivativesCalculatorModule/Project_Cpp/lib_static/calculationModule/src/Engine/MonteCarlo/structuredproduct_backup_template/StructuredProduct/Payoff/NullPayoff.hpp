#ifndef calculationModule_nullpayoff_hpp
#define calculationModule_nullpayoff_hpp

#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/IndexTran/indextransmanager.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/Payoff/payoffbase.hpp>

namespace QuantLib {

	class NullPayoff : public PayoffBase {
	  public:
		NullPayoff(const Date& payoffDate);

		void initialize(const TimeGrid& timeGrid, const Calendar& calendar);

		Date payoffDate(){return payoffDate_;}
		Size payoffDatesPosition(){return payoffDatesPosition_;}
		
		Real value(){return 0.0;}

	};

}
#endif
