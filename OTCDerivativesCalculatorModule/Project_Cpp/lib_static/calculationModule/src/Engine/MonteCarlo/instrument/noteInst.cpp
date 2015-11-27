#include "noteInst.hpp"

namespace QuantLib {

NoteInst::NoteInst(std::string code,
					Real notional,
					const Date& issueDate,
					const Date& maturityDate,
					const DayCounter& dayCounter,
					const Calendar& calendar)
: code_(code), notional_(notional), issueDate_(issueDate), maturityDate_(maturityDate),
settlementDays_(settlementDays_), calendar_(calendar), dayCounter_(dayCounter)
{
}

void NoteInst::setupArguments(PricingEngine::arguments* args) const
{
	NoteInst::arguments* arguments =
		dynamic_cast<NoteInst::arguments*>(args);
	QL_REQUIRE(arguments != 0, "wrong argument type");

	arguments->code = this->code_;
	arguments->notional = this->notional_;
	arguments->issueDate = this->issueDate_;
	arguments->maturityDate = this->maturityDate_;
	arguments->calendar = this->calendar_;
	arguments->dayCounter = this->dayCounter_;

}

void NoteInst::fetchResults(const PricingEngine::results* r) const
{
	Instrument::fetchResults(r);
}


bool NoteInst::isExpired() const {
        return false;
		/*CashFlows::isExpired(cashflows_,
                                    true,
                                    Settings::instance().evaluationDate());*/
}


void NoteInst::arguments::validate() const{
	//구현해야함
}

void NoteInst::results::reset() const{
	//구현해야함
}

}

