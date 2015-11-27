#include "structuredProduct.hpp"

namespace QuantLib {

StructuredProduct::StructuredProduct(const std::string& productType,
									const std::string& instrumentID,
									Real notional,
									const Date& issueDate,
									const Date& maturityDate,
									const boost::shared_ptr<StructuredProductPayoff>& sp_payoff)
: productType_(productType), instrumentID_(instrumentID), notional_(notional), 
issueDate_(issueDate), maturityDate_(maturityDate), sp_payoff_(sp_payoff) {

}

void StructuredProduct::setupArguments(PricingEngine::arguments* args) const
{
	//Instrument::setupArguments(args);

    StructuredProduct::arguments* moreArgs =
				dynamic_cast<StructuredProduct::arguments*>(args);

    QL_REQUIRE(moreArgs != 0, "wrong argument type");

    moreArgs->notional = notional_;
    moreArgs->issueDate = issueDate_;
    moreArgs->maturityDate = maturityDate_;
	moreArgs->calendar = sp_payoff_->calendar();
	//moreArgs->dayCounter = rebate_;
	//moreArgs->settlementDays = rebate_;
	moreArgs->sp_payoff = sp_payoff_;
	//moreArgs->indexFixingDates = rebate_;
	
}
					  
}//namespace End