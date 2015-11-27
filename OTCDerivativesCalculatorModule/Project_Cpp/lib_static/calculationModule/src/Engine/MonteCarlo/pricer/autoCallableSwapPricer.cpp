#include "autoCallableSwapPricer.hpp"
#include <src/util/DateHelper.hpp>
#include <src/util/comparision.hpp>

namespace QuantLib {
AutoCallableSwapPricer::AutoCallableSwapPricer(const boost::shared_ptr<QuantLib::MCPricer>& rec_pricer,
											   const boost::shared_ptr<QuantLib::MCPricer>& pay_pricer,
								   			   Real notional,
											   std::string currency)
{
	this->notional_ = notional;
	this->currency_ = currency;

	this->rec_etiList_ = rec_pricer->getEtiList();
	this->rec_notional_ = rec_pricer->getNotional();
	this->rec_currency_ = rec_pricer->getCurrency();

	this->pay_etiList_ = pay_pricer->getEtiList();
	this->pay_notional_ = pay_pricer->getNotional();
	this->pay_currency_ = pay_pricer->getCurrency();
	
	this->rec_payoffDateInfo_ = rec_pricer->getPayoffDateInfo();
	this->pay_payoffDateInfo_ = pay_pricer->getPayoffDateInfo();

}

//AutoCallableSwapPricer::AutoCallableSwapPricer(const std::vector<boost::shared_ptr<EventTriggerInfo>>& rec_etiList,
//									   Real rec_notional,
//									   std::string rec_currency,
//									   //const boost::shared_ptr<FixingDateInfo>& rec_payoffDateInfo,
//									   const std::vector<boost::shared_ptr<EventTriggerInfo>>& pay_etiList,
//									   Real pay_notional,
//									   std::string pay_currency,
//									   const boost::shared_ptr<FixingDateInfo>& payoffDateInfo)
//: rec_etiList_(rec_etiList), rec_notional_(rec_notional), rec_currency_(rec_currency),rec_payoffDateInfo_(rec_payoffDateInfo),
//  pay_etiList_(pay_etiList), pay_notional_(pay_notional), pay_currency_(pay_currency),pay_payoffDateInfo_(pay_payoffDateInfo)
//{
//			
//}

//AutoCallableSwapPricer::AutoCallableSwapPricer(const boost::shared_ptr<MCPricer>& payPart,
//											   const boost::shared_ptr<MCPricer>& recievePart,
//											   bool accruedPay)
//: payPart_(payPart), recievePart_(recievePart), accruedPay_(accruedPay)
//
//{
//			
//}

void AutoCallableSwapPricer::initializeImpl(const TimeGrid& timeGrid,
									   const boost::shared_ptr<YieldTermStructure>& discountCurve,
									   const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	Date today = Settings::instance().evaluationDate();

	this->startPos_ = 0;
	
	this->rec_payoffDateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);
	this->pay_payoffDateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);

	this->earlyExEventPosition_ = std::max(this->rec_payoffDateInfo_->fixingDatePosition() ,
										   this->pay_payoffDateInfo_->fixingDatePosition() );

	//this->earlyExEventPosition_ = this->pay_payoffDateInfo_->fixingDatePosition();
	
	this->rec_etiNum_ = this->rec_etiList_.size();
	this->pay_etiNum_ = this->pay_etiList_.size();

	this->total_eventTriggerNum_ = this->rec_etiList_.size() + 
								   this->pay_etiList_.size();

	this->cf_results_ = std::vector<boost::shared_ptr<CashFlowResult>>(this->total_eventTriggerNum_);

	this->calcValue_results_ = std::vector<boost::shared_ptr<CalcValueResult>>(3);

	this->calcValue_results_[0] = boost::shared_ptr<CalcValueResult>(
								new CalcValueResult("NET","KRW"));
	this->calcValue_results_[1] = boost::shared_ptr<CalcValueResult>(
								new CalcValueResult("PAY","KRW"));
	this->calcValue_results_[2] = boost::shared_ptr<CalcValueResult>(
								new CalcValueResult("RECEIVE","KRW"));


	this->valueTimeHorizon_ = std::valarray<Real>(this->total_eventTriggerNum_);
	this->earlyExCount_ = std::valarray<Real>(this->total_eventTriggerNum_);

	this->legPostionMap_ = std::vector<Size>(this->total_eventTriggerNum_,0);
	this->legPostionSide_ = std::vector<bool>(this->total_eventTriggerNum_);

	this->legTotalReceivePostionMap_ = std::vector<Size>(this->rec_etiNum_,0);
	this->legTotalPayPostionMap_ = std::vector<Size>(this->pay_etiNum_,0);

	Size rec_count = 0;
	Size pay_count = 0;

	//for ( Size i=0 ; i< this->rec_etiList_.size() ; i++ )
	//{
	//	this->eventTriggerList_.push_back(this->rec_etiList_[i]);
	//}

	//for ( Size i=0 ; i< this->pay_etiList_.size() ; i++ )
	//{
	//	this->eventTriggerList_.push_back(this->pay_etiList_[i]);
	//}

	//for ( Size i=0 ; i< this->eventTriggerList_.size() ; i++ )
	//{
	//	std::cout << i << " : " <<  this->eventTriggerList_[i] << " : " << this->eventTriggerList_[i]->getEventDate() << "\n";
	//}

	//std::cout << "-------------------------------------" << "\n";

	//std::sort (this->eventTriggerList_.begin(), this->eventTriggerList_.end(), ComparisonFunction::compETIEventDate); 

	//for ( Size i=0 ; i< this->eventTriggerList_.size() ; i++ )
	//{
	//	std::cout << i << " : " <<  this->eventTriggerList_[i] << " : " << this->eventTriggerList_[i]->getEventDate() << "\n";
	//}

	//다 넣어졌나 확인해야함.

	for ( Size i=0 ; i< this->total_eventTriggerNum_ ; i++ )
	{

		// receive pay mapping
		if ( this->convReceiveEventDate(rec_count) <  
			 this->convPayEventDate(pay_count) )
		{
			this->eventTriggerList_.push_back(this->rec_etiList_[rec_count]);
			this->eventTriggerList_[i]->initialize(timeGrid,discountCurve,pathGenFactory);

			this->legPostionMap_[i] = rec_count;
			this->legPostionSide_[i] = true; // true : Receive
			this->legTotalReceivePostionMap_[rec_count] = i;

			this->cf_results_[i] =  boost::shared_ptr<CashFlowResult>( 
						new CashFlowResult(i+1,
										this->eventTriggerList_[i]->getEventDate(),
										this->eventTriggerList_[i]->getPayoffDate(),
										"RECEIVE",
										this->rec_currency_,
										this->eventTriggerList_[i]->discount() ) );

			this->calcValue_results_[2]->accrualAmt_ += 
				this->eventTriggerList_[i]->accrualRate( pathGenFactory->next(false) , today );

			rec_count += 1;

		}
		else if ( this->convReceiveEventDate(rec_count) >=
				  this->convPayEventDate(pay_count) )

		{
			this->eventTriggerList_.push_back(this->pay_etiList_[pay_count]);
			this->eventTriggerList_[i]->initialize(timeGrid,discountCurve,pathGenFactory);

			this->legPostionMap_[i] = pay_count;
			this->legPostionSide_[i] = false; // false : Pay
			this->legTotalPayPostionMap_[pay_count] = i;

			this->cf_results_[i] =  boost::shared_ptr<CashFlowResult>( 
						new CashFlowResult(i+1,
										this->eventTriggerList_[i]->getEventDate(),
										this->eventTriggerList_[i]->getPayoffDate(),
										"PAY",
										this->pay_currency_,
										this->eventTriggerList_[i]->discount() ) );

			this->calcValue_results_[1]->accrualAmt_ += 
				this->eventTriggerList_[i]->accrualRate( pathGenFactory->next(false) , today );

			pay_count += 1;
		}
		else
		{
		
		}

		// expired check
		if ( eventTriggerList_[i]->getEventDate() < today )
		{
			remainEventPosition_ = i + 1;
			this->cf_results_[i]->isExpired_ = true;

		}

	}

	if ( eventTriggerList_.size() != this->total_eventTriggerNum_ )
	{
		QL_FAIL("total eventNum must be same to rec + pay eventNum");
	}

	for ( Size i = 0 ; i < this->total_eventTriggerNum_ ; i++ )
	{
		//this->eventTriggerList_[i]->initialize(timeGrid,discountCurve,pathGenFactory);

		bool kk = eventTriggerList_[i]->isExpired();

		if ( eventTriggerList_[i]->getEventDate() < today )
		{
			startPos_ = startPos_ + 1;
		}
	}

}

Date AutoCallableSwapPricer::convReceiveEventDate(Size i)
{
	if ( i < this->rec_etiList_.size() )
	{
		return this->rec_etiList_[i]->getEventDate();
	}else
	{
		return Date(99999);
	}
	
}

Date AutoCallableSwapPricer::convPayEventDate(Size i)
{
	if ( i < this->pay_etiList_.size() )
	{
		return this->pay_etiList_[i]->getEventDate();
	}else
	{
		return Date(99999);
	}
	
}


Real AutoCallableSwapPricer::calculate(const MultiPath& path,Size endPosition) const
{
	this->value_ = 0.0;

	Real payPartValue = 0.0;
	Real recievePartValue = 0.0;
	
	Size position = 999;
	Size earlyExOccEventTriggerNum = this->eventTriggerList_.size() - 1;
	Size earlyExEventPosition = this->earlyExEventPosition_;

	bool autoCall = false;

	for ( Size i=this->startPos_ ; i < this->eventTriggerList_.size() ; i++)
	{
		Real cf = this->eventTriggerList_[i]->payoff(path,endPosition);

		//this->valueTimeHorizon_[i] = cf;

		this->cf_results_[i]->cashFlow_ = cf;
		this->cf_results_[i]->value_ = cf * this->cf_results_[i]->discount_;

		autoCall = eventTriggerList_[i]->autoCallEvent();	

		if ( autoCall )
		{
			earlyExEventPosition = eventTriggerList_[i]->autoCallEventPosition();
			earlyExOccEventTriggerNum = i;

			this->cf_results_[i]->exProb_ = 1.0;
			
			Real notionalSide = this->getNotionalSide(i);

			Real discountAtSide = this->getDiscountAtSide(i,earlyExEventPosition);

			this->cf_results_[i]->notionalPayment_ = notionalSide;
			this->cf_results_[i]->value_ += notionalSide * discountAtSide;

			this->earlyExCount_[i] += 1;
			
			Size pos = this->nextOppositePos(i);

			// 반대쪽 accural amout 를 더함.
			if ( pos != 999 )
			{
				notionalSide = this->getNotionalSide(pos);

				this->cf_results_[pos]->exProb_ = 1.0;
				this->cf_results_[pos]->notionalPayment_ = notionalSide;

				Real accrual = this->eventTriggerList_[pos]->accrualRate(path,this->eventTriggerList_[i]->getEventDate());

				// autoCall 이 일어났을때 반대쪽 notioal도 그날에 pay됨.
				this->cf_results_[pos]->value_ += notionalSide * discountAtSide + accrual;
			}

			break;
		}
	}

	if ( !autoCall )
	{
		this->cf_results_[ this->legTotalReceivePostionMap_[ this->rec_etiNum_ - 1 ] ]->exProb_ = 1.0;
		this->cf_results_[ this->legTotalReceivePostionMap_[ this->rec_etiNum_ - 1 ] ]->notionalPayment_ = this->rec_notional_;
		this->cf_results_[ this->legTotalReceivePostionMap_[ this->rec_etiNum_ - 1 ] ]->value_ 
			+= this->rec_notional_ * this->rec_payoffDateInfo_->discount();

		this->cf_results_[ this->legTotalPayPostionMap_[ this->pay_etiNum_ - 1 ] ]->exProb_ = 1.0;
		this->cf_results_[ this->legTotalPayPostionMap_[ this->pay_etiNum_ - 1 ] ]->notionalPayment_ = this->pay_notional_;
		this->cf_results_[ this->legTotalPayPostionMap_[ this->pay_etiNum_ - 1 ] ]->value_ 
			+= this->pay_notional_ * this->pay_payoffDateInfo_->discount();

	}

	for ( Size i=this->startPos_ ;i<this->eventTriggerList_.size() ; i++ )
	{
		if ( legPostionSide_[i] )
		{
			recievePartValue += this->cf_results_[i]->value_;
		}else
		{
			payPartValue += this->cf_results_[i]->value_;
		}

	}

	//net

	this->value_ += recievePartValue - payPartValue;

	this->value_ = this->callableCalculate(path,earlyExOccEventTriggerNum);

	//Real rec_notionalPayment = this->rec_notional_ * this->rec_payoffDateInfo_->discountAt(earlyExEventPosition);; // * fxrate?
	//Real pay_notionalPayment = this->pay_notional_ * this->pay_payoffDateInfo_->discountAt(earlyExEventPosition);; // * fxrate?

	#ifdef LogPrint
	
	std::ostringstream ss;
	
	ss << "- pricer calc start" ;
			path.log_.push_back(ss.str());
			ss.str("");ss.clear();


	ss << "value : " << this->value_  << " receive : " << recievePartValue << " pay" << payPartValue;
			path.log_.push_back(ss.str());
			ss.str("");ss.clear();

	ss << "- pricer calc end";
			path.log_.push_back(ss.str());
			ss.str("");ss.clear();
		
	#endif

	//this->valueTimeHorizon_[] += notionalPayment;
	//this->valueTimeHorizon_[earlyExOccEventTriggerNum] += notionalPayment;

	return value_;
}

Real AutoCallableSwapPricer::callableCalculate(const MultiPath& multiPath,Size earlyExOccEventTriggerNum) const
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
		if ( optionType != 0 )
		{
			Real v = 0.0;
			
			for ( Size k=i+1 ; k < cfNum ; k++ )
			{
				v += this->cf_results_[k]->value();
			}

			v *= ( 1.0 / this->eventTriggerList_[i]->discount() );

			// call 할 경우 추가 payoff , 원래 cf는 지불 되고 그다음에 call 여부 판단함.
			Real additionalExPayoff = this->eventTriggerList_[i]->payoffEarlyEx(multiPath,9999);
			v += additionalExPayoff;

			if ( optionType == 1 ) { callPutFlag = 1.0; }
			else if ( optionType == 2 ) { callPutFlag = -1.0; }
			else{ }

			if ( v * callPutFlag > 0 )
			{
				declareCallPos = i;

				Real notionalSide = this->getNotionalSide(i);
				Real discountSide = this->eventTriggerList_[i]->discount();

				this->cf_results_[i]->cashFlow_ += additionalExPayoff;
				this->cf_results_[i]->exProb_ = 1.0;
				this->cf_results_[i]->notionalPayment_ = notionalSide;
				this->cf_results_[i]->value_ += 
					( additionalExPayoff + notionalSide ) * discountSide;

				// 뒤에꺼 다 0 처리함.
				for ( Size k=i+1 ; k < cfNum ; k++ )
				{
					this->cf_results_[k]->reset();
				}

				// 반대쪽 accrual 된거랑 원금있으면 원금 더함.
				Size pos = this->nextOppositePos(i);

				Real notionalOppSide = this->getNotionalSide(pos);
				Real discountOppSide = this->eventTriggerList_[pos]->discount();

				// autoCall 이 일어났을때 반대쪽 notioal도 그날에 pay됨.
				Real accrual = this->eventTriggerList_[pos]->accrualRate(multiPath,this->eventTriggerList_[i]->getEventDate());
				
				this->cf_results_[pos]->cashFlow_ = accrual;
				this->cf_results_[pos]->exProb_ = 1.0;
				this->cf_results_[pos]->notionalPayment_ = notionalOppSide;
				this->cf_results_[pos]->value_ = ( notionalSide + accrual ) * discountSide ;

				break;
			}
		}
	}

	//
	Real callableValue = 0.0;
	Real recievePartValue = 0.0;
	Real payPartValue = 0.0;

	//for ( Size i=0; i <= declareCallPos ; i++ )
	//	{ callableValue += this->cf_results_[i]->value_; }

	for ( Size i=0;i < cfNum ; i++ )
	{
		if ( legPostionSide_[i] )
		{
			recievePartValue += this->cf_results_[i]->value_;
		}else
		{
			payPartValue += this->cf_results_[i]->value_;
		}
	}

	callableValue = recievePartValue - payPartValue;

	this->calcValue_results_[1]->dirty_ = payPartValue;
	this->calcValue_results_[2]->dirty_ = recievePartValue;

	this->calcValue_results_[0]->dirty_ += callableValue;
	this->calcValue_results_[0]->option_ += this->value_ - callableValue ;
	
	return callableValue;
}

std::vector<boost::shared_ptr<EventTriggerInfo>> AutoCallableSwapPricer::getEtiList() const
{
	return this->eventTriggerList_;
}

Real AutoCallableSwapPricer::getNotional() const
{
	return 1.0;
}

std::string AutoCallableSwapPricer::getCurrency() const
{
	return "KRW";
}

Size AutoCallableSwapPricer::nextOppositePos(Size i) const
{
	bool currentSide = this->legPostionSide_[i];

	for ( Size k=i+1 ; k < this->total_eventTriggerNum_ ; k++ )
	{
		if ( this->legPostionSide_[k] != currentSide)
		{
			return k;
		}
	}

	return 999;
}

Real AutoCallableSwapPricer::getNotionalSide(Size i) const
{
	Real notional = 1.0;

	// true : Receive , false : Pay
	if ( this->legPostionSide_[i] )
	{
		notional = this->rec_notional_;
	}
	else
	{
		notional = this->pay_notional_;
	}

	return notional;
}


Real AutoCallableSwapPricer::getDiscountSide(Size i) const
{
	Real discount = 1.0;

	// true : Receive , false : Pay
	if ( this->legPostionSide_[i] )
	{
		discount = this->rec_payoffDateInfo_->discount();
	}
	else
	{
		discount = this->pay_payoffDateInfo_->discount();
	}

	return discount;
}

Real AutoCallableSwapPricer::getDiscountAtSide(Size i,Size position) const
{
	Real discount = 1.0;

	// true : Receive , false : Pay
	if ( this->legPostionSide_[i] )
	{
		discount = this->rec_payoffDateInfo_->discountAt(position);
	}
	else
	{
		discount = this->pay_payoffDateInfo_->discountAt(position);
	}

	return discount;
}

std::vector<Date> AutoCallableSwapPricer::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();

	return fixingDates;
}

std::vector<Date> AutoCallableSwapPricer::payoffDates() const
{
	std::vector<Date> payoffDates;

	return payoffDates;
}

void AutoCallableSwapPricer::resetImpl() const
{
	this->value_ = 0.0;

	for ( Size i=0 ; i<this->eventTriggerList_.size() ; i++ )
	{
		this->eventTriggerList_[i]->reset();
		this->valueTimeHorizon_[i] = 0.0;
		this->cf_results_[i]->reset();
		//this->earlyExCount_[i] = 0.0;
	}
	
	this->calcValue_results_[0]->dirty_ = 0.0; // net
	this->calcValue_results_[1]->dirty_ = 0.0; // pay
	this->calcValue_results_[2]->dirty_ = 0.0; // receive

}

}
