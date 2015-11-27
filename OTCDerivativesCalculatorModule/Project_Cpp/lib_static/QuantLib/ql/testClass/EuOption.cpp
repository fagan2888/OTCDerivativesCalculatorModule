#include <ql/testClass/EuOption.hpp>

namespace QuantLib{

EuOption::EuOption(Real notional,
					const Date& issueDate,
					Natural settlementDays,
					//const std::vector<boost::shared_ptr<Index>>& refIndex,
					const std::vector<boost::shared_ptr<StockIndex>>& refIndex,
					const Date& maturityDate,
					const boost::shared_ptr<OptionPayoff>& optionPayoff,
					const DayCounter& dayCounter,
					const Calendar& calendar
					)
	:notional_(notional),issueDate_(issueDate),settlementDays_(settlementDays),refIndex_(refIndex),
	maturityDate_(maturityDate),optionPayoff_(optionPayoff),dayCounter_(dayCounter),calendar_(calendar)
	{
		
	}

	
void EuOption::setupArguments(PricingEngine::arguments* args) const{

		EuOption::arguments* arguments =
        dynamic_cast<EuOption::arguments*>(args);
        QL_REQUIRE(arguments != 0, "wrong argument type");
		
		arguments->notional				=   notional_;
		arguments->issueDate			=   issueDate_;
		arguments->refIndex				=   refIndex_;
		arguments->dayCounter			=   dayCounter_;
		arguments->maturityDate			=   maturityDate_;
		arguments->optionPayoff			=	optionPayoff_;


		Date today=Settings::instance().evaluationDate();

		//arguments->initialValues		=   initialValues;

}

void EuOption::fetchResults(const PricingEngine::results* r) const {

        Instrument::fetchResults(r);

        const EuOption::results* results =
            dynamic_cast<const EuOption::results*>(r);
        QL_ENSURE(results != 0, "wrong result type");

		//settlementValue_ = results->settlementValue;
		
}

}