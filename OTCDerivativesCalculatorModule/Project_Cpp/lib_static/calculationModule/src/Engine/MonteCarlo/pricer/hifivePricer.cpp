#include "hifivePricer.hpp"
#include <src/util/DateHelper.hpp>

namespace QuantLib {

HifivePricer::HifivePricer(const std::vector<boost::shared_ptr<EventTriggerInfo>>& autoCallEtiList,
						const boost::shared_ptr<EventTriggerInfo>& kiBarrierEventTrigger,
						Real notional,
						std::string currency,
						const boost::shared_ptr<FixingDateInfo>& payoffDateInfo )
						//const boost::shared_ptr<PayoffCalculation>& occBarrierPayoffCalculation,
						//const boost::shared_ptr<EventTriggerInfo>& nonOccBarrierEventTrigger)
: autoCallEtiList_(autoCallEtiList), kiBarrierEventTrigger_(kiBarrierEventTrigger)//, nonOccBarrierEventTrigger_(nonOccBarrierEventTrigger)
{

	this->eventTriggerList_ = autoCallEtiList;
	this->eventTriggerList_.push_back(kiBarrierEventTrigger);
	this->notional_ = notional;
	this->payoffDateInfo_ = payoffDateInfo;
	this->currency_ = currency;
}

void HifivePricer::initializeImpl(const TimeGrid& timeGrid,
									   const boost::shared_ptr<YieldTermStructure>& discountCurve,
									   const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	//this->discount_ = Array(eventTriggerList_.size(),1.0);

	//for ( Size i = 0 ; i < eventTriggerList_.size() ; i++ )
	//{
	//	eventTriggerList_[i]->initialize(timeGrid,discountCurve);

	//	if ( eventTriggerList_[i]->isExpired() )
	//	{
	//		remainEventPosition_ = i + 1;
	//		this->discount_[i] = 1.0;
	//	}else
	//	{
	//		this->discount_[i] = discountCurve_->discount(eventTriggerList_[i]->payoffDate());
	//	}
	//}

	Date today = Settings::instance().evaluationDate();

	remainEventPosition_ = 0;
	autoCallEventPosition_ = timeGrid.size() - 1;

	this->cf_results_ = std::vector<boost::shared_ptr<CashFlowResult>>( this->eventTriggerList_.size() );
	this->calcValue_results_ = std::vector<boost::shared_ptr<CalcValueResult>>(1);

	this->calcValue_results_[0] = boost::shared_ptr<CalcValueResult>(
									new CalcValueResult("NET","KRW"));

	for ( Size i = 0 ; i < eventTriggerList_.size() ; i++ )
	{
		this->eventTriggerList_[i]->initialize(timeGrid,discountCurve,pathGenFactory);
		this->cf_results_[i] =  boost::shared_ptr<CashFlowResult>( 
							new CashFlowResult(i+1,
											   this->eventTriggerList_[i]->getEventDate(),
											   this->eventTriggerList_[i]->getPayoffDate(),
											   "NET",
											   this->currency_,
											   this->payoffDateInfo_->discount()) );

		bool kk = eventTriggerList_[i]->isExpired();

		if ( eventTriggerList_[i]->isExpired() )
		{
			remainEventPosition_ = i + 1;
		}
	}

	this->kiBarrierEventTrigger_->initialize(timeGrid,discountCurve,pathGenFactory);
	//this->nonOccBarrierEventTrigger_->initialize(timeGrid,discountCurve,pathGenFactory);
	//pastkiBarrierEventOcc_ = kiBarrierEventTrigger_->pastEventOcc();

}

Real HifivePricer::calculate(const MultiPath& path,Size endPosition) const
{
	
	//for ( Size i=0 ; i < path.assetNumber() ; i++)
	//{
	//	for ( Size j=0 ; j < path.pathSize() ; j++)
	//	{
	//		std::cout << path[i][j] << " : ";
	//	}
	//	std::cout << std::endl;
	//}
	//std::cout << std::endl;

	bool autoCall = false;

	value_ = 0.0;

	#ifdef LogPrint

	std::ostringstream ss;

	ss << "HifivePricer remainEventPos : " << remainEventPosition_;
		
	path.log_.push_back(ss.str());
	ss.str("");ss.clear();
	
	ss << "-------------------------------------------";
	path.log_.push_back(ss.str());
	ss.str("");ss.clear();

	#endif

	for ( Size i = remainEventPosition_ ; i < eventTriggerList_.size() ; i++ )
	{
		#ifdef LogPrint

		ss << "event[" << i << "] start";
		path.log_.push_back(ss.str());
		ss.str("");ss.clear();
		
		#endif

		value_ += eventTriggerList_[i]->payoff(path,endPosition);

		autoCall = eventTriggerList_[i]->autoCallEvent();	

		if(autoCall)
		{
			autoCallEventPosition_ = eventTriggerList_[i]->autoCallEventPosition();
			
			#ifdef LogPrint
			
			ss << "event[" << i << "] autoCall occ end , payoff value : " << value_ ;
			path.log_.push_back(ss.str());
			ss.str("");ss.clear();
			
			#endif

			break;
		}
		
		#ifdef LogPrint

		ss << "event[" << i << "] end , payoff value : " << value_ ;
		path.log_.push_back(ss.str());
		ss.str("");ss.clear();

		ss << "-------------------------------------------";
		path.log_.push_back(ss.str());
		ss.str("");ss.clear();

		#endif
	}

	if(!autoCall)
	{
		double kiValue = kiBarrierEventTrigger_->payoff(path,endPosition);

		#ifdef LogPrint

		ss << "autoCall TF : false , KiBarrier Start";
		path.log_.push_back(ss.str());
		ss.str("");ss.clear();
		//if(kiBarrierEventTrigger_->checkEvent(path))
		//{

		ss << "KiBarrier End , ki value : " << kiValue;
		path.log_.push_back(ss.str());
		ss.str("");ss.clear();

		#endif

		value_ += kiValue;

		//}
		//else if (nonOccBarrierEventTrigger_->checkEvent(path))
		//{
		//value_ += nonOccBarrierEventTrigger_->payoff(path,endPosition);
		//}else
		//{
			//value = 0.0;
		//}

		//value = value * this->discount_[eventTriggerList_.size()-1];
	}

	#ifdef LogPrint

	ss << "HifivePricer End , pricer value : " << value_ ;
	path.log_.push_back(ss.str());
	ss.str("");ss.clear();

	#endif

	this->calcValue_results_[0]->dirty_ = this->value_;

	return value_;
}

//std::vector<boost::shared_ptr<EventTriggerInfo>> HifivePricer::getEtiList() const
//{
//
//}
//
//Real HifivePricer::getNotional() const
//{
//
//}
//
//std::string HifivePricer::getCurrency() const
//{
//
//}
//
//boost::shared_ptr<FixingDateInfo> HifivePricer::getPayoffDateInfo() const
//{
//
//}

std::vector<Date> HifivePricer::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();

	for ( Size i = 0 ; i < eventTriggerList_.size() ; i++ )
	{
		helper.mergeDates(fixingDates,eventTriggerList_[i]->fixingDates());

	}

	helper.mergeDates(fixingDates,this->kiBarrierEventTrigger_->fixingDates());
	//helper.mergeDates(fixingDates,this->nonOccBarrierEventTrigger_->fixingDates());

	return fixingDates;
}

std::vector<Date> HifivePricer::payoffDates() const
{
	std::vector<Date> payoffDates;

	//for ( Size i = 0 ; i < eventTriggerList_.size() ; i++ )
	//{
	//	payoffDates.push_back(eventTriggerList_[i]->payoffDate());
	//}

	////payoffDates.push_back(this->kiBarrierEventTrigger_->payoffDate());
	////payoffDates.push_back(this->nonOccBarrierEventTrigger_->payoffDate());
	//
	//DateHelper helper = DateHelper ();

	//std::vector<Date> results = helper.removeDuplicateDate(payoffDates);

	return payoffDates;
}

void HifivePricer::resetImpl() const
{
	for ( Size i=0 ; i<this->eventTriggerList_.size() ; i++ )
	{
		this->eventTriggerList_[i]->reset();
		this->valueTimeHorizon_[i] = 0.0;
		this->cf_results_[i]->reset();

		//this->earlyExCount_[i] = 0.0;
	}

	this->calcValue_results_[0]->dirty_ = 0.0;

	
}

Size HifivePricer::autoCallEventPosition()
{
	return this->autoCallEventPosition_;
}

Real HifivePricer::autoCallPayoff(Size position)
{
	return value_;
}

}
