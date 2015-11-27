#include "MultiEventCouponETI.hpp"

namespace QuantLib {

MultiEventCouponETI::MultiEventCouponETI(const std::vector<boost::shared_ptr<EventCalculation>>& eventCalList,
										const std::vector<boost::shared_ptr<ReturnCalculation>>& returnCalList,
										const boost::shared_ptr<ReturnCalculation>& complementReturnCal,
										const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
										bool isExpired,
										const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: CouponCalculation(usingVariableInfoList), eventCalList_(eventCalList), returnCalList_(returnCalList),
  complementReturnCal_(complementReturnCal)
{
	this->payoffDateInfo_ = payoffDateInfo;
	this->isExpired_ = isExpired;

	multiEventSize_ = eventCalList_.size();

	QL_REQUIRE( eventCalList_.size() == returnCalList.size() , "eventCalNum must be equal to returnCalNum");
}

void MultiEventCouponETI::initializeImpl(const TimeGrid& timeGrid,
				const boost::shared_ptr<YieldTermStructure>& discountCurve,
				const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	for ( Size i=0 ; i<multiEventSize_; i++)
	{
		this->eventCalList_[i]->initialize(timeGrid,discountCurve,pathGenFactory);
		this->returnCalList_[i]->initialize(timeGrid,discountCurve,pathGenFactory);
	}

	this->complementReturnCal_->initialize(timeGrid,discountCurve,pathGenFactory);
	this->payoffDateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);

}

bool MultiEventCouponETI::pastEventOcc()
{
	return true;
}

bool MultiEventCouponETI::checkEvent(const MultiPath& path,Size endPosition)
{
	//bool tf = this->eventCal_->checkEvent(path);
	bool tf = true;

	return tf;
}

Real MultiEventCouponETI::payoffImpl(const MultiPath& path,Size endPosition)
{
	Real value = 0.0;

	bool tf = false;

	for ( Size i=0 ; i<multiEventSize_ ; i++)
	{
		tf = this->eventCalList_[i]->checkEvent(path);

		if( tf )
		{
			//value = this->returnCalList_[i]->calculate(path,endPosition) * payoffDateInfo_->discount();
			value = this->returnCalList_[i]->calculate(path,endPosition);
			break;
		}
		
	}

	if ( !tf )
	{
		//value = complementReturnCal_->calculate(path,endPosition) * payoffDateInfo_->discount();
		value = complementReturnCal_->calculate(path,endPosition) ;
	}

	value += this->autoTermination(path);

	return value;
}

std::vector<Date> MultiEventCouponETI::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();
	
	for ( Size i=0 ; i<multiEventSize_ ; i++)
	{
		helper.mergeDates(fixingDates,this->eventCalList_[i]->fixingDates());
		helper.mergeDates(fixingDates,this->returnCalList_[i]->fixingDates());

	}

	return fixingDates;
}

std::vector<Date> MultiEventCouponETI::payoffDates() const
{
	std::vector<Date> payoffDates;
	return payoffDates;
}


}

