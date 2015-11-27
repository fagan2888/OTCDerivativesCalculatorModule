#include <ql/testClass/EquityLinkedSecurity.hpp>

namespace QuantLib{

	EquityLinkedSecurity::EquityLinkedSecurity(Real notional,
							const Date& issueDate,
							Natural settlementDays,
							//const std::vector<boost::shared_ptr<Index>>& refIndex,//stock으로 바꿀것?.
							const std::vector<Real>& initialValues,
							const std::vector<Date>& autoCallDates,
							const DayCounter& dayCounter,
							const Calendar& calendar)
				//			const Payoff& payoff)
				: notional_(notional),issueDate_(issueDate),settlementDays_(settlementDays),
				initialValues_(initialValues),autoCallDates_(autoCallDates),dayCounter_(dayCounter),calendar_(calendar)
				,maturityDate_(autoCallDates.back()){
		
//		refIndex_=boost::shared_ptr<StockIndex>(new StockIndex(refIndex[i],))
		fixingDates_=autoCallDates;
        registerWith(Settings::instance().evaluationDate());
	}

void EquityLinkedSecurity::setupArguments(PricingEngine::arguments* args) const
{
        EquityLinkedSecurity::arguments* arguments =
        dynamic_cast<EquityLinkedSecurity::arguments*>(args);
		
        QL_REQUIRE(arguments != 0, "wrong argument type");

		arguments->notional         =   notional_;
		arguments->issueDate		=   issueDate_;
		arguments->autoCallDates		=   autoCallDates_;
		//arguments->refIndex			=   refIndex_;
		arguments->dayCounter		=   dayCounter_;
		
		arguments->initialValues		=   initialValues_;
		//arguments->dividends			=   dividends;

}

void EquityLinkedSecurity::fetchResults(const PricingEngine::results* r) const {

        Instrument::fetchResults(r);

        const EquityLinkedSecurity::results* results =
            dynamic_cast<const EquityLinkedSecurity::results*>(r);
        QL_ENSURE(results != 0, "wrong result type");

		//settlementValue_ = results->settlementValue;
		
}
	
Date EquityLinkedSecurity::nextCashFlowDate(Date d) const{return Date();}	
Real EquityLinkedSecurity::notional() const{return notional_;}
Date EquityLinkedSecurity::issueDate() const{return issueDate_;}
Date EquityLinkedSecurity::maturityDate() const{return maturityDate_;}
std::string EquityLinkedSecurity::description() const{return "ELS";}

bool EquityLinkedSecurity::isExpired() const {
        return false;
		/*CashFlows::isExpired(cashflows_,
                                    true,
                                    Settings::instance().evaluationDate());*/
}


void EquityLinkedSecurity::arguments::validate() const{
	//구현해야함
}

void EquityLinkedSecurity::results::reset() const{
	//구현해야함
}


}