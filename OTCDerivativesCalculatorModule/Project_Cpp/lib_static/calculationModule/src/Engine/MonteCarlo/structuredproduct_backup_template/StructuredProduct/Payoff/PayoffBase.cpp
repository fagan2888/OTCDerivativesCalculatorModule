#include <src/Engine/MonteCarlo/StructuredProduct/payoff/payoffBase.hpp>
#include <ql/settings.hpp>

namespace QuantLib {

PayoffBase::PayoffBase(const std::string& symbolName,
						const Date& payoffDate,
						std::string payoffExpr)
		: symbolName_(symbolName), payoffDate_(payoffDate), payoffExpr_(payoffExpr)
{
	
		IndexSymbolManager::instance().setSymbol(symbolName);

}

void PayoffBase::initialize(const TimeGrid& timeGrid, const Calendar& calendar){
			
		Date today = Settings::instance().evaluationDate();
		Date issueDate = Date(27,Sep,2012);

		payoffDatesPosition_ = calendar.businessDaysBetween(issueDate,payoffDate_,true,false);
}
void PayoffBase::defineConst(const std::string& varStr,Real constValue){}
void PayoffBase::defineVar(const std::string& varStr){}
void PayoffBase::defineBaseIndex(const std::string& varStr){}
void PayoffBase::removeSymbol(std::string symbolName){}

}