#include <ql/testClass/ELSStepDown.hpp>

namespace QuantLib{

ELSStepDown::ELSStepDown(Real notional,
						const Date& issueDate,
						Natural settlementDays,
						//const std::vector<boost::shared_ptr<Index>>& refIndex,
						const std::vector<Real>& initialValue,
						const std::vector<Date>& autoCallDates,
						std::vector<Real>& earlyExTriggers,
						std::vector<Real>& redemCoupon,
						const std::vector<Real>& KIbarrier,
						CheckKIType checkKIType,
						const DayCounter& daycount,
						const Calendar& calendar
						)
	:EquityLinkedSecurity(notional,issueDate,settlementDays,initialValue,autoCallDates,daycount,calendar),
	earlyExTriggers_(earlyExTriggers),redemCoupon_(redemCoupon),KIbarrier_(KIbarrier),checkKIType_(checkKIType),KIflag_(false)
	{
		// 2012-06-15 기초자산 각각 마다 KI이 설정되는 경우 수정함.
		pastKICount_=0;
		Size numAssets=initialValue.size();
		// numAssets 만큼 KIbarrier 에서 읽어옴
		
		std::vector<Real> KIbarrier_M(numAssets);

		QL_REQUIRE(KIbarrier.size() >= numAssets, "KIbarrier Num is not same to Underlying Num");
		QL_REQUIRE(earlyExTriggers_.size()==autoCallDates_.size(), "trigger Number is not same to schedule Dates");
		QL_REQUIRE(redemCoupon.size() > 0, "redemCoupon must be positive");
		QL_REQUIRE(redemCoupon.size()==earlyExTriggers.size(), "trigger Number is not same to schedule Dates");

		for(Size i=0;i<numAssets;++i){
			KIbarrier_M[i]=KIbarrier[i];
			QL_REQUIRE(KIbarrier[i] >= 0, "KIbarrier must be positive");
		}
		
		KIbarrier_=KIbarrier_M;
		KIflag_=false;

	}

ELSStepDown::ELSStepDown(Real notional,
						const Date& issueDate,
						Natural settlementDays,
						//const std::vector<boost::shared_ptr<Index>>& refIndex,
						const std::vector<Real>& initialValue,
						const std::vector<Date>& autoCallDates,
						std::vector<Real>& earlyExTriggers,
						std::vector<Real>& redemCoupon,
						const std::vector<Real>& KIbarrier,
						CheckKIType checkKIType,
						const DayCounter& daycount,
						const Calendar& calendar,
						bool PastKIEvent)
	:EquityLinkedSecurity(notional,issueDate,settlementDays,initialValue,autoCallDates,daycount,calendar),
	earlyExTriggers_(earlyExTriggers),redemCoupon_(redemCoupon),KIbarrier_(KIbarrier),checkKIType_(checkKIType),KIflag_(PastKIEvent)
	{
		// 2012-06-15 기초자산 각각 마다 KI이 설정되는 경우 수정함.
		pastKICount_=0;
		Size numAssets=initialValue.size();
		// numAssets 만큼 KIbarrier 에서 읽어옴
		
		std::vector<Real> KIbarrier_M(numAssets);
		this->autoCallDates_ = autoCallDates;
		this->initialValues_ = initialValue;
		QL_REQUIRE(KIbarrier.size() >= numAssets, "KIbarrier Num is not same to Underlying Num");
		QL_REQUIRE(earlyExTriggers_.size()==autoCallDates_.size(), "trigger Number is not same to schedule Dates");
		QL_REQUIRE(redemCoupon.size() > 0, "redemCoupon must be positive");
		QL_REQUIRE(redemCoupon.size()==earlyExTriggers.size(), "trigger Number is not same to schedule Dates");
		
		for(Size i=0;i<numAssets;++i){
			KIbarrier_M[i]=KIbarrier[i];
			QL_REQUIRE(KIbarrier[i] >= 0, "KIbarrier must be positive");
		}
		
		KIbarrier_=KIbarrier_M;
		
	}
	
void ELSStepDown::setupArguments(PricingEngine::arguments* args) const{

		ELSStepDown::arguments* arguments =
        dynamic_cast<ELSStepDown::arguments*>(args);
		Size pastFixingDateNum=0;
        QL_REQUIRE(arguments != 0, "wrong argument type");
		
		arguments->redemCoupon          =   redemCoupon_;
		arguments->KIbarrier			=   KIbarrier_;

		arguments->KIflag				=   KIflag_;
		arguments->checkKIType			=   checkKIType_;
		
		arguments->notional				=   notional_;
		arguments->issueDate			=   issueDate_;
		//arguments->schedule				=   schedule_;
		//arguments->refIndex				=   refIndex_;
		arguments->dayCounter			=   dayCounter_;
		arguments->maturityDate			=   maturityDate_;
		arguments->initialValues		=   initialValues_;

		Size numOfSchedule=autoCallDates_.size();

		std::vector<Date> remainFixings;
		std::vector<Real> earlyExTriggers;
		Date today=Settings::instance().evaluationDate();

		for(Size i=0;i<numOfSchedule;++i){
			if(autoCallDates_[i]>today){
				remainFixings.push_back(autoCallDates_[i]);
				earlyExTriggers.push_back(earlyExTriggers_[i]);

			}
			else{pastFixingDateNum=pastFixingDateNum+1;}
		}

		arguments->fixingDates			=   remainFixings;
		
		//arguments->dividends			=   dividends;
		arguments->earlyExTriggers		=   earlyExTriggers;
		arguments->pastFixingDateNum		=   pastFixingDateNum;


}

void ELSStepDown::fetchResults(const PricingEngine::results* r) const {

        Instrument::fetchResults(r);

        const EquityLinkedSecurity::results* results =
            dynamic_cast<const EquityLinkedSecurity::results*>(r);
        QL_ENSURE(results != 0, "wrong result type");

		//settlementValue_ = results->settlementValue;
		
}
}