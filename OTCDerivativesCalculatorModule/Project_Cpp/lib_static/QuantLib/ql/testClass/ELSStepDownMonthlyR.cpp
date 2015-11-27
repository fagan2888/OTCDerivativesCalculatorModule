#include <ql/testClass/ELSStepDownMonthlyR.hpp>

namespace QuantLib{

ELSStepDownMonthlyR::ELSStepDownMonthlyR(Real notional,
						const Date& issueDate,
						Natural settlementDays,
						//const std::vector<boost::shared_ptr<Index>>& refIndex,
						const std::vector<boost::shared_ptr<StockIndex>>& refIndex,
						const Schedule& schedule,
						std::vector<Real>& earlyExTriggers,
						std::vector<Real>& redemCoupon,
						Real KILossCoupon,
						const std::vector<Real>& KIbarrier,
						CheckKIType checkKIType,
						const DayCounter& daycount,
						const Calendar& calendar
						)
	:ELSStepDown(notional,issueDate,settlementDays,refIndex,schedule,earlyExTriggers,redemCoupon,
	KIbarrier,checkKIType,daycount,calendar),
	KILossCoupon_(KILossCoupon),checkKIType_(checkKIType)
	{
		pastKICount_=0;
		

		for(Size i=0;i<schedule.size();++i){
			if(earlyExTriggers[i]>0.0){
				fixingExDates_.push_back(schedule[i]);
			}
		}
		
	}

	
void ELSStepDownMonthlyR::setupArguments(PricingEngine::arguments* args) const{

		ELSStepDownMonthlyR::arguments* arguments =
        dynamic_cast<ELSStepDownMonthlyR::arguments*>(args);
		Size pastFixingDateNum=0;
        QL_REQUIRE(arguments != 0, "wrong argument type");
		

		//ELSStepDown
		arguments->redemCoupon          =   redemCoupon_;
		arguments->KIbarrier			=   KIbarrier_;
		arguments->KIflag				=   KIflag_;
		arguments->checkKIType			=   checkKIType_;
		arguments->notional				=   notional_;
		arguments->issueDate			=   issueDate_;
		arguments->refIndex				=   refIndex_;
		arguments->dayCounter			=   dayCounter_;
		arguments->maturityDate			=   maturityDate_;

		// argument
		arguments->KILossCoupon          =   KILossCoupon_;
		arguments->pastKICount			=   pastKICount_;

	
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
		arguments->pastFixingDateNum		=   pastFixingDateNum;


}

void ELSStepDownMonthlyR::fetchResults(const PricingEngine::results* r) const {

        Instrument::fetchResults(r);

        const EquityLinkedSecurity::results* results =
            dynamic_cast<const EquityLinkedSecurity::results*>(r);
        QL_ENSURE(results != 0, "wrong result type");

		//settlementValue_ = results->settlementValue;
		
}
//bool ELSStepDownMonthlyR::checkKI() {
	
	//pastKICount_ = 0;

	//Size indexNum=refIndex_.size();
	//Date today=Settings::instance().evaluationDate();
	//Date roopDate=Date();
	//const Date& issueDate=issueDate_;

	//std::vector<Real> knockInValue;
	//std::vector<Real> initialValue;

	//const std::string& lowSuffix="_LOW";

	//Real indexFixing=0.0;
	//
	//for(Size i=0;i<indexNum;++i){
	//	
	//	Size j=1;
	//	initialValue.push_back(refIndex_[i]->fixing(calendar_.advance(issueDate,-1,Days)));
	//	knockInValue.push_back(initialValue[i]*KIbarrier_[i]);	
	//	roopDate=issueDate_;
	//	switch (checkKIType_) {
	//		case Conti:
	//		{
	//			const std::string& low=refIndex_[i]->name() + lowSuffix;
	//			const TimeSeries<Real>& lowSeries=IndexManager::instance().getHistory(low);

	//			QL_REQUIRE(lowSeries.size()>0,low + " index does not exist");

	//			const std::vector<Date> lowSeriesDate=lowSeries.dates(issueDate_,today);
	//			const std::vector<Real> lowSeriesValue=lowSeries.values(issueDate_,today);
	//			
	//			//while(roopDate<today){
	//				
	//			//	roopDate=calendar_.advance(issueDate_,j,Days);
	//			//	indexFixing=lowSeries[roopDate];
	//			const Size numlowDates=lowSeriesValue.size();
	//			for(Size k=0;k<numlowDates;++k){
	//				
	//				if(lowSeriesValue[k]<knockInValue[i]){
	//					KIDate_=roopDate;
	//					return true;}
	//			}
	//		}
	//		case Daily : 
	//			{
	//				const std::string& last=refIndex_[i]->name();
	//				const TimeSeries<Real>& lastSeries=IndexManager::instance().getHistory(last);

	//				QL_REQUIRE(lastSeries.size()>0,last + " index does not exist");

	//				const std::vector<Date> lastSeriesDate=lastSeries.dates(issueDate_,today);
	//				const std::vector<Real> lastSeriesValue=lastSeries.values(issueDate_,today);
	//				
	//				//while(roopDate<today){
	//					
	//				//	roopDate=calendar_.advance(issueDate_,j,Days);
	//				//	indexFixing=lowSeries[roopDate];
	//				const Size numlastDates=lastSeriesValue.size();
	//				for(Size k=0;k<numlastDates;++k){
	//					
	//					if(lastSeriesValue[k]<knockInValue[i]){
	//						KIDate_=roopDate;
	//						return true;
	//					}
	//				}
	//			}
	//		case Monthly : 
	//			{
	//				Size numScheduleDates=schedule_.dates().size();
	//				for(Size j=0;j<numScheduleDates;++j){	
	//					indexFixing=refIndex_[i]->fixing(schedule_[j]);
	//					
	//					if(indexFixing<knockInValue[i]){
	//						KIDate_=roopDate;
	//						pastKICount_+=pastKICount_;
	//						return true;
	//					}
	//				}
	//			}
	//	}
	//}

	//return false;

//}

}