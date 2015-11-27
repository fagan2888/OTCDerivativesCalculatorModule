#include <ql/testClass/ELSNotionalProtected.hpp>

namespace QuantLib{

ELSNotionalProtected::ELSNotionalProtected(Real notional,
						const Date& issueDate,
						Natural settlementDays,
						const std::vector<boost::shared_ptr<StockIndex>> refIndex,
						const Schedule& schedule,
						std::vector<Real>& earlyExTriggers,
						Real redemCoupon,
						const DayCounter& daycount,
						const Calendar& calendar
						)
	:EquityLinkedSecurity(notional,issueDate,settlementDays,refIndex,schedule,daycount,calendar),
	earlyExTriggers_(earlyExTriggers),redemCoupon_(redemCoupon)
	{
		QL_REQUIRE(earlyExTriggers_.size()==schedule_.size(), "trigger Number is not same to schedule Dates");
		QL_REQUIRE(redemCoupon > 0, "redemCoupon must be positive");
	
	}

	
void ELSNotionalProtected::setupArguments(PricingEngine::arguments* args) const{

		ELSNotionalProtected::arguments* arguments =
        dynamic_cast<ELSNotionalProtected::arguments*>(args);
		Size pastFixingDateNum=0;
        QL_REQUIRE(arguments != 0, "wrong argument type");
		
		arguments->redemCoupon          =   redemCoupon_;
		
		arguments->notional				=   notional_;
		arguments->issueDate			=   issueDate_;
		//arguments->schedule				=   schedule_;
		arguments->refIndex				=   refIndex_;
		arguments->dayCounter			=   dayCounter_;
		arguments->maturityDate			=   maturityDate_;


		std::vector<Real> initialValues;
		std::vector<Real> dividends;
		for(Size i=0;i<refIndex_.size();++i){
			initialValues.push_back(refIndex_[i]->fixing(calendar_.advance(issueDate_,-1,Days)));//이거 날짜 확인해서 해야댐.
			dividends.push_back(refIndex_[i]->dividend());

		}
		Size numOfSchedule=schedule_.size();
		std::vector<Date> remainFixings;
		std::vector<Real> earlyExTriggers;
		Date today=Settings::instance().evaluationDate();

		for(Size i=0;i<numOfSchedule;++i){
			if(schedule_.dates()[i]>today){
				remainFixings.push_back(schedule_.dates()[i]);
				earlyExTriggers.push_back(earlyExTriggers_[i]);

			}
			else{pastFixingDateNum=pastFixingDateNum+1;}
		}
		arguments->fixingDates			=   remainFixings;
		arguments->initialValues		=   initialValues;
		arguments->dividends			=   dividends;
		arguments->earlyExTriggers		=   earlyExTriggers;
		arguments->pastFixingDateNum	=   pastFixingDateNum;


}

void ELSNotionalProtected::fetchResults(const PricingEngine::results* r) const {

        Instrument::fetchResults(r);

        const EquityLinkedSecurity::results* results =
            dynamic_cast<const EquityLinkedSecurity::results*>(r);
        QL_ENSURE(results != 0, "wrong result type");

		//settlementValue_ = results->settlementValue;
		
}
}