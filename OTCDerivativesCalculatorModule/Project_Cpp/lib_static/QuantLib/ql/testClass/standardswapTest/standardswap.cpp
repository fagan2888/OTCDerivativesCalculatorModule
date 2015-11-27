#include <ql/testClass/standardswapTest/standardswap.hpp>

namespace QuantLib {

StandardSwap::StandardSwap(const Date& issueDate,
						   const Date& maturityDate,
						   Natural settlementDays,
						   const boost::shared_ptr<SwapPayoff>& swappayoff,
						   const DayCounter& dayCounter)
		: issueDate_(issueDate), maturityDate_(maturityDate), settlementDays_(settlementDays),
		  swappayoff_(swappayoff), dayCounter_(dayCounter) {
		
		}
		
		//Instrument interface
		
void StandardSwap::setupArguments(PricingEngine::arguments* args) const{
		
		StandardSwap::arguments* arguments =
        dynamic_cast<StandardSwap::arguments*>(args);
		
        QL_REQUIRE(arguments != 0, "wrong argument type");

		arguments->issueDate         =   issueDate_;
		arguments->maturityDate	=	maturityDate_;
        arguments->settlementDays		=	settlementDays_;
        arguments->swappayoff			=	swappayoff_;
		arguments->dayCounter	=   dayCounter_;
		
}


}