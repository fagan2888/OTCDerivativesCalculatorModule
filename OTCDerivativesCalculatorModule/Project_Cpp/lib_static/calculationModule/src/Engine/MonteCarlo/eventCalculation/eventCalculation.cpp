#include "eventCalculation.hpp"


namespace QuantLib {

EventCalculation::EventCalculation(const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: IRefVariable(usingVariableInfoList)
{
	//this->eventRefOccFlag_ = false;
	this->pastEventOcc_ = false;
	//this->preCondiEvent_ = boost::shared_ptr<PreConditionEvent>(new null
	//if ( usingVariableInfoList
	this->eventOccVariableEventInfo_ = boost::shared_ptr<NullVariableEventInfo>(new NullVariableEventInfo());
}

void EventCalculation::initialize(const TimeGrid& timeGrid,
								const boost::shared_ptr<YieldTermStructure>& discountCurve,
								const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	//if ( this->eventRefOccFlag_ )
	//{
	//	eventRefOccPtr_ = pathGenFactory->registCountTypeReferenceValue(this->eventRefName_);
	//}

	//if ( this->eventOccVariableEventInfo_ != 0 )
	//{
	eventOccVariableEventInfo_->initialize(pathGenFactory); 
	//}

	this->initializeImpl(timeGrid,discountCurve,pathGenFactory);

}


void EventCalculation::setPastEventOcc(bool pastOccTF)
{
	this->pastEventOcc_ = pastOccTF;
}

void EventCalculation::setPreConditionEvent(const boost::shared_ptr<PreConditionEvent>& preCondiEvent)
{
	this->preCondiEvent_ = preCondiEvent;
}

void EventCalculation::setRefVariableEventOcc(const boost::shared_ptr<VariableEventInfo>& eventOccVariableEventInfo)
{
	this->eventOccVariableEventInfo_ = eventOccVariableEventInfo;
}

bool EventCalculation::checkEvent(const MultiPath& path,Size endPosition)
{
	bool tf = this->pastEventOcc_;

	bool preCondi = this->preCondiEvent();

	if ( tf == false  )
	{
		if ( preCondi == true )
		{
			bool eventOcc = this->checkEventImpl(path,endPosition);

			tf = this->eventOccVariableEvent(eventOcc);
		}
	}

	return tf;
	
}

bool EventCalculation::checkEventEarlyEx(const MultiPath& path,Size endPosition)
{
	bool tf = this->pastEventOcc_;
	bool preCondi = this->preCondiEvent();

	if ( tf == false  )
	{
		if ( preCondi == true )
		{
			bool eventOcc = this->checkEventEarlyExImpl(path,endPosition);

			tf = this->eventOccVariableEvent(eventOcc);
		}
	}

	return tf;
	
}

bool EventCalculation::checkEventEarlyExImpl(const MultiPath& path,Size endPosition)
{
	bool tf = false;

	QL_FAIL("not yet implemented");

	return tf;
	
}

bool EventCalculation::preCondiEvent()
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

bool EventCalculation::eventOccVariableEvent(bool eventOcc)
{
	//bool tf = eventOcc;

	return eventOccVariableEventInfo_->execute(eventOcc);

	/*if ( this->eventOccVariableEventInfo_ != 0 )
	{
		return eventOccVariableEventInfo_->execute(eventOcc);
	}
	else
	{
		return tf;
	}*/
}

}