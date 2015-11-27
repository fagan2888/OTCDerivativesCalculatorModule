#include "AutoCallablePricer.hpp"
#include <src/util/DateHelper.hpp>
#include <src/Engine/MonteCarlo/fixedFixingDateInfo.hpp>

namespace QuantLib {

AutoCallablePricer::AutoCallablePricer(const std::vector<boost::shared_ptr<EventTriggerInfo>>& eventTriggerList,
									   Real notional,
									   std::string currency,
									   const boost::shared_ptr<FixingDateInfo>& payoffDateInfo)
{
	this->eventTriggerList_ = eventTriggerList;
	this->payoffDateInfo_ = payoffDateInfo;
	this->currency_ = currency;
	this->notional_ = notional;
}

void AutoCallablePricer::initializeImpl(const TimeGrid& timeGrid,
									   const boost::shared_ptr<YieldTermStructure>& discountCurve,
									   const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	Date today = Settings::instance().evaluationDate();

	this->payoffDateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);

	this->remainEventPosition_ = 0;
	//earlyExEventPosition_ = timeGrid.size() - 1;
	this->earlyExEventPosition_ = this->payoffDateInfo_->fixingDatePosition();

	this->eventTriggerNum_ = eventTriggerList_.size();

	this->cf_results_ = std::vector<boost::shared_ptr<CashFlowResult>>(this->eventTriggerNum_);
	this->calcValue_results_ = std::vector<boost::shared_ptr<CalcValueResult>>(1);

	this->calcValue_results_[0] = boost::shared_ptr<CalcValueResult>(
									new CalcValueResult("NET","KRW"));

	this->valueTimeHorizon_ = std::valarray<Real>(this->eventTriggerNum_);
	this->earlyExCount_ = std::valarray<Real>(this->eventTriggerNum_);

	for ( Size i = 0 ; i < this->eventTriggerNum_ ; i++ )
	{
		this->eventTriggerList_[i]->initialize(timeGrid,discountCurve,pathGenFactory);
		this->eventTriggerList_[i]->reset();

		this->cf_results_[i] =  boost::shared_ptr<CashFlowResult>( 
								new CashFlowResult(i+1,
											   this->eventTriggerList_[i]->getEventDate(),
											   this->eventTriggerList_[i]->getPayoffDate(),
											   "NET",
											   this->currency_,
											   this->eventTriggerList_[i]->discount() ) );
		
		this->calcValue_results_[0]->accrualAmt_ += 
				this->eventTriggerList_[i]->accrualRate( pathGenFactory->next(false),today);

		bool kk = eventTriggerList_[i]->isExpired();

		if ( eventTriggerList_[i]->getEventDate() < today )
		{
			remainEventPosition_ = i + 1;
			this->cf_results_[i]->isExpired_ = true;

		}
	}

	
	this->valueTimeHorizon_ = std::valarray<Real>(eventTriggerList_.size());

}

Real AutoCallablePricer::calculate(const MultiPath& path,Size endPosition) const
{
	bool autoCall = false;
	bool callable = false;
	double dummy = 0.0;
	double notionalPayment = 0.0;
	Real v = 0.0 ;
	this->value_ = 0.0;
	
	Size earlyExOccEventTriggerNum = this->eventTriggerNum_ -1;
	//Size earlyExEventPosition = this->earlyExEventPosition_;
	Size earlyExEventPosition = this->earlyExEventPosition_;

	for ( Size i = 0 ; i < this->eventTriggerNum_ ; i++ )
	{
		if (  i < this->remainEventPosition_ )
		{
			dummy = eventTriggerList_[i]->payoff(path,endPosition);
		}else
		{
			Real cf = eventTriggerList_[i]->payoff(path,endPosition);
			this->valueTimeHorizon_[i] = cf;
			
			this->cf_results_[i]->cashFlow_ = cf;
			//this->cf_results_[i]->discount_ = eventTriggerList_[i]->discount();
			this->cf_results_[i]->value_ = cf * this->cf_results_[i]->discount_;

			autoCall = eventTriggerList_[i]->autoCallEvent();	

			if(autoCall)
			{
				earlyExEventPosition = eventTriggerList_[i]->autoCallEventPosition();
				earlyExOccEventTriggerNum = i;
			
				this->cf_results_[i]->exProb_ = 1.0;
				this->cf_results_[i]->notionalPayment_ = this->notional_;
				this->cf_results_[i]->value_ += this->notional_ * this->payoffDateInfo_->discountAt(earlyExEventPosition);

				break;
			}

		}
	}
	
	if ( !autoCall )
	{
		this->cf_results_[earlyExOccEventTriggerNum]->exProb_ = 1.0;
		this->cf_results_[earlyExOccEventTriggerNum]->notionalPayment_ = this->notional_;
		this->cf_results_[earlyExOccEventTriggerNum]->value_ 
			+= this->notional_ * this->payoffDateInfo_->discount();
			//+= this->notional_ * this->payoffDateInfo_->discountAt(earlyExEventPosition);

		//notionalPayment += this->notional_ * this->payoffDateInfo_->discountAt(earlyExEventPosition);
	}
	
	for ( Size i=this->remainEventPosition_ ;i<this->eventTriggerNum_; i++ )
	{
		this->value_ += this->cf_results_[i]->value_;
	}
	
	//this->calcValue_results_[0]->dirty_ += v;
	
	this->value_ = this->callableCalculate(path,earlyExOccEventTriggerNum);

	return this->value_;
}

//std::vector<boost::shared_ptr<EventTriggerInfo>> AutoCallablePricer::getEtiList() const
//{
//	return this->eventTriggerList_;
//}
//
//Real AutoCallablePricer::getNotional() const
//{
//	return this->notional_;
//}
//
//std::string AutoCallablePricer::getCurrency() const
//{
//	return this->currency_;
//}
//
//boost::shared_ptr<FixingDateInfo> AutoCallablePricer::getPayoffDateInfo() const
//{
//	return this->payoffDateInfo_;
//}

//Real AutoCallablePricer::calculate(const MultiPath& path,Size endPosition) const
//{
//	bool autoCall = false;
//
//	value_ = 0.0;
//
//	for ( Size i = remainEventPosition_ ; i < eventTriggerList_.size() ; i++ )
//	{
//		value_ += eventTriggerList_[i]->payoff(path);
//		
//		autoCall = eventTriggerList_[i]->autoCallEvent();	
//
//		if(autoCall)
//		{
//			earlyExEventPosition_ = eventTriggerList_[i]->autoCallEventPosition();
//			break;
//		}
//	}
//
//	return value_;
//}

//Real AutoCallablePricer::calculateEarlyEx(const MultiPath& path,Size endPosition) const
//{
//	bool autoCall = false;
//
//	value_ = 0.0;
//
//	for ( Size i = remainEventPosition_ ; i < eventTriggerList_.size() ; i++ )
//	{
//		value_ += eventTriggerList_[i]->payoffEarlyEx(path,endPosition);
//	}
//
//	return value_;
//}

Real AutoCallablePricer::callableCalculate(const MultiPath& multiPath,Size earlyExOccEventTriggerNum) const
{
	Size cfNum = this->cf_results_.size();
	Size declareCallPos = earlyExOccEventTriggerNum;
	Size optionType = 0;
	Real callPutFlag = 1.0;

	//첫날이랑 막날은 뺌
	//for ( Size i=1 ; i < cfNum - 1 ; i++)
	for ( Size i=1 ; i < earlyExOccEventTriggerNum ; i++)
	{
		optionType = this->eventTriggerList_[i]->getAdditionalOption();

		// 0 : none , 1 : callable , 2 : puttable
		if ( optionType == 1 )
		{
			Real v = 0.0;
			
			for ( Size k=i+1 ; k < cfNum ; k++ )
			{
				v += this->cf_results_[k]->value();
			}

			v *= ( 1.0 / this->eventTriggerList_[i]->discount() );

			// call 할 경우 추가 payoff , 원래 cf는 지불 되고 그다음에 call 여부 판단함.
			v += this->eventTriggerList_[i]->payoffEarlyEx(multiPath,9999);
			
			if ( optionType == 1 ) { callPutFlag = 1.0; }
			else if ( optionType == 2 ) { callPutFlag = -1.0; }
			else{ }

			if ( ( v * callPutFlag ) > this->notional_ )
			{
				declareCallPos = i;

				this->cf_results_[i]->exProb_ = 1.0;
				this->cf_results_[i]->notionalPayment_ = this->notional_;
				this->cf_results_[i]->value_ += 
					this->notional_ * this->eventTriggerList_[i]->discount();

				// 뒤에꺼 다 0 처리함.
				for ( Size k=i+1 ; k < cfNum ; k++ )
				{
					this->cf_results_[k]->reset();
				}

				break;
			}
		}
	}

	//
	Real callableValue = 0.0;

	for ( Size i=0; i < cfNum ; i++ )
	{
		callableValue += this->cf_results_[i]->value_;
	}

	this->calcValue_results_[0]->dirty_ += callableValue;
	this->calcValue_results_[0]->option_ += this->value_ - callableValue ;
	
	return callableValue;
}

std::vector<Date> AutoCallablePricer::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();

	for ( Size i = 0 ; i < eventTriggerList_.size() ; i++ )
	{
		helper.mergeDates(fixingDates,eventTriggerList_[i]->fixingDates());

	}

	return fixingDates;
}

std::vector<Date> AutoCallablePricer::payoffDates() const
{
	std::vector<Date> payoffDates;

	return payoffDates;
}

void AutoCallablePricer::resetImpl() const
{
	this->value_ = 0.0;

	for ( Size i = 0 ; i < eventTriggerList_.size() ; i++ )
	{
		eventTriggerList_[i]->reset();
		this->valueTimeHorizon_[i] = 0.0;
		this->cf_results_[i]->reset();
	}

	this->calcValue_results_[0]->dirty_ = 0.0;
	this->calcValue_results_[0]->option_ = 0.0;

	//this->earlyExEventPosition_ = eventTriggerList_[0]->pa;
}

Size AutoCallablePricer::autoCallEventPosition()
{
	return this->earlyExEventPosition_;
}

Real AutoCallablePricer::autoCallPayoff(Size position)
{
	return value_;
}

}
