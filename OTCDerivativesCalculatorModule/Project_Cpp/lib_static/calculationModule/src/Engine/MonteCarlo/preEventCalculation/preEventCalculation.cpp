#include "PreEventCalculation.hpp"

namespace QuantLib {

PreEventCalculation::PreEventCalculation(const std::vector<boost::shared_ptr<EventCalculation>>& eventCalList,
								const std::vector<boost::shared_ptr<JointEventCalculation>>& jointEventCalList)
: eventCalList_(eventCalList), jointEventCalList_(jointEventCalList)
{
}

void PreEventCalculation::initialize(const TimeGrid& timeGrid,
								const boost::shared_ptr<YieldTermStructure>& discountCurve,
								const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	//single Event
	for( Size i=0 ; i<eventCalList_.size() ; i++)
	{
		this->eventCalList_[i]->initialize(timeGrid,discountCurve,pathGenFactory);
	}

	//joint Event
	for( Size i=0 ; i<jointEventCalList_.size() ; i++)
	{
		this->jointEventCalList_[i]->initialize(timeGrid,discountCurve,pathGenFactory);
	}


}

//bool PreEventCalculation::checkEvent(const MultiPath& path,Size endPosition)
//{
//	bool tf = this->pastEventOcc_;
//
//	if (tf == false)
//	{
//		bool eventOcc = this->checkEventImpl(path);
//
//		if ( this->eventRefOccFlag_ )
//		{
//			eventRefOccPtr_->value_ = static_cast<double>(eventOcc);
//		}
//
//		tf = eventOcc;
//	}
//
//	return tf;
//	
//}

void PreEventCalculation::preEventCalculate(const MultiPath& path,Size endPosition)
{
	//single Event
	for( Size i=0 ; i<eventCalList_.size() ; i++)
	{
		this->eventCalList_[i]->checkEvent(path,endPosition);
	}

	//joint Event
	for( Size i=0 ; i<jointEventCalList_.size() ; i++)
	{
		this->jointEventCalList_[i]->checkEvent(path,endPosition);
	}
}

void PreEventCalculation::preEventCalculateEarlyEx(const MultiPath& path,Size endPosition)
{
	//single Event
	for( Size i=0 ; i<eventCalList_.size() ; i++)
	{
		this->eventCalList_[i]->checkEventEarlyEx(path,endPosition);
	}

	//joint Event
	for( Size i=0 ; i<jointEventCalList_.size() ; i++)
	{
		this->jointEventCalList_[i]->checkEventEarlyEx(path,endPosition);
	}
}

//void PreEventCalculation::preEventCalculateEarlyEx(const MultiPath& path,Size endPosition)
//{
//	//single Event
//	for( Size i=0 ; i<eventCalList_.size() ; i++)
//	{
//		this->eventCalList_[i]->checkEventEarlyEx(path,endPosition);
//	}
//
//	//joint Event
//	for( Size i=0 ; i<jointEventCalList_.size() ; i++)
//	{
//		this->jointEventCalList_[i]->checkEventEarlyEx(path,endPosition);
//	}
//}

}