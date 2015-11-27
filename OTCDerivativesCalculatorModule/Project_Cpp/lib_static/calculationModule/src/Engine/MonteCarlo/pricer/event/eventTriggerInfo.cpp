#include "eventTriggerInfo.hpp"

namespace QuantLib {

EventTriggerInfo::EventTriggerInfo(const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: IRefVariable(usingVariableInfoList) 
{
	//discount_ = Array(1,0.0);
	this->optionType_ = 0;
	this->autoCallOccFlag_ = false;
}


void EventTriggerInfo::initialize(const TimeGrid& timeGrid,
					const boost::shared_ptr<YieldTermStructure>& discountCurve,
					const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	if ( !this->preEventCal_ == 0 )
	{
		this->preEventCal_->initialize(timeGrid,discountCurve,pathGenFactory);
	}

	this->initializeImpl(timeGrid,discountCurve,pathGenFactory);

	if ( !this->autoTerminationETI_ == 0 )
	{
		this->autoTerminationETI_->initialize(timeGrid,discountCurve,pathGenFactory);
	}

	this->eventDatePosition_ = timeGrid.dateIndex(this->eventDate_);
}

bool EventTriggerInfo::autoCallEvent() 
{ 
	return this->autoCallOccFlag_;
}

Size EventTriggerInfo::autoCallEventPosition() 
{
	//autoCallEventOccPosition_ = 999;
	return eventDatePosition_;
}

Real EventTriggerInfo::payoff(const MultiPath& path,Size endPosition)
{
	Real value = 0.0;

	if ( this->eventDatePosition_ <= endPosition )
	{
		if ( this->preEventCal_ != 0 )
		{
			this->preEventCal_->preEventCalculate(path,endPosition);
		}

		if ( this->preCondiEvent() )
		{
			double v = this->payoffImpl(path,endPosition) ;
			value = v;

			double autoCalVal = this->autoTermination(path,endPosition) ;
			value += autoCalVal;

			#ifdef LogPrint

			std::ostringstream ss;

			//ss << "schedule calc start" << " eventDate : " << this->getEventDate().year() << " " << this->getEventDate().month() << " " << this->getEventDate().dayOfMonth();
			ss << "schedule calc start" << " eventDate : " << this->getEventDate() << "===========================";
			path.log_.push_back(ss.str());
			ss.str("");ss.clear();

			ss << "schedule calc End , payoff value : " << value << "( " << v << " + " << autoCalVal << " )";
			path.log_.push_back(ss.str());
			ss.str("");ss.clear();

			#endif


		}
	}else
	{
		value = this->payoffEarlyEx(path,endPosition);
		//this->autoCallOccFlag_ = true;
	}

	return value;
}

Real EventTriggerInfo::payoffEarlyEx(const MultiPath& path,Size endPosition)
{
	Real value = 0.0;

	//if ( this->preEventCal_ != 0 )
	//{
	//	this->preEventCal_->preEventCalculateEarlyEx(path,endPosition);
	//}

	//if ( this->preCondiEvent() )
	//{
	//	value = this->payoffImplEarlyEx(path,endPosition);
	//}

	return value;
}

// --------------------------- set base function ---------------------------------------------------
void EventTriggerInfo::setEventDate(const Date& eventDate)
{
	this->eventDate_ = eventDate;
}

Date EventTriggerInfo::getEventDate()
{
	return this->eventDate_;
}
Size EventTriggerInfo::getEventDatePosition()
{
	return this->eventDatePosition_;
}


void EventTriggerInfo::setAdditionalOption(const boost::shared_ptr<AdditionalOption>& option)
{
	this->additionalOption_ = option;

	if ( this->additionalOption_->optionType() == "callable")
	{
		this->optionType_ = 1;
	}
	else if ( this->additionalOption_->optionType() == "puttable")
	{
		this->optionType_ = 2;
	}
	else 
	{
		this->optionType_ = 0;
	}

}

//boost::shared_ptr<AdditionalOption> EventTriggerInfo::getAdditionalOption()
Size EventTriggerInfo::getAdditionalOption()
{
	return this->optionType_;
}

Date EventTriggerInfo::getPayoffDate()
{
	return this->payoffDateInfo_->fixingDate();
}

void EventTriggerInfo::setPreEventCalcaultion(const boost::shared_ptr<PreEventCalculation>& preEventCal)
{
	this->preEventCal_ = preEventCal;
}

void EventTriggerInfo::setPreConditionEvent(const boost::shared_ptr<PreConditionEvent>& preCondiEvent)
{
	this->preCondiEvent_ = preCondiEvent;
}

void EventTriggerInfo::setAutoTerminationETI(const boost::shared_ptr<EventTriggerInfo>& autoTerminationETI)
{
	autoTerminationETI_ = autoTerminationETI;
}


bool EventTriggerInfo::preCondiEvent()
{
	if ( this->preCondiEvent_ != 0 )
	{
		return this->preCondiEvent_->checkEvent();
	}
	else
	{
		return true;
	}
}

// 기본적으로 미구현되고 accrual일 경우에 구현함
Real EventTriggerInfo::payoffImplEarlyEx(const MultiPath& path,Size endPosition)
{
	return 0.0;
}

//Real EventTriggerInfo::payoffEarlyEx(const MultiPath& path,Size endPosition)
//{
//	
//	Real value = 0.0;
//
//	if ( this->preEventCal_ != 0 )
//	{
//		this->preEventCal_->preEventCalculateEarlyEx(path,endPosition);
//	}
//
//	value = this->payoffImplEarlyEx(path,endPosition);
//
//	value += this->autoTerminationEarlyEx(path,endPosition);
//
//	return value;
//}

Real EventTriggerInfo::autoTermination(const MultiPath& path,Size endPosition)
{
	Real value = 0.0;

	if ( this->autoTerminationETI_ != 0 )
	{
		bool autoTermTF = this->autoTerminationETI_->checkEvent(path);

		if ( autoTermTF )
		{
			//this->autoCallEventPosition_ = 0;
			value = this->autoTerminationETI_->payoff(path,endPosition);
			this->autoCallOccFlag_ = true;
		}else
		{
			this->autoCallOccFlag_ = false;
		}

		#ifdef LogPrint

		std::ostringstream ss;

		ss << "autoCall Calc start";
		path.log_.push_back(ss.str());
		ss.str("");ss.clear();

		ss << "autoCall End , TF : "<< this->autoCallOccFlag_  << ", value : " << value;
		//value = value * this->discount_[i];

		path.log_.push_back(ss.str());
		ss.str("");ss.clear();

		#endif
	}

	return value;
}

//Real EventTriggerInfo::autoTerminationEarlyEx(const MultiPath& path,Size endPosition)
//{
//	Real value = 0.0;
//
//	if ( this->autoTerminationETI_ != 0 )
//	{
//		if ( this->autoTerminationETI_->checkEventEarlyEx(path,endPosition) )
//		{
//			//this->autoCallEventPosition_ = 0;
//			value = this->autoTerminationETI_->payoffEarlyEx(path,endPosition);
//			this->autoCallOccFlag_ = true;
//		}
//	}
//
//	return value;
//}


bool EventTriggerInfo::isExpired() 
{
	Date today = Settings::instance().evaluationDate();
	
	
	if ( this->eventDate_ < today )
		return true;

	return false; 

	//return isExpired_; 
}

void EventTriggerInfo::reset() 
{
	this->autoCallOccFlag_ = false;
}

//

//std::vector<Date> EventTriggerInfo::fixingDates()
//{
//	std::vector<Date> fixingDates;
//
//	return fixingDates;
//}
//
//std::vector<Date> EventTriggerInfo::payoffDates()
//{
//	std::vector<Date> fixingDates;
//
//	return fixingDates;
//}


}
