#include "UpperBarrierEventCal.hpp"

namespace QuantLib {

UpperBarrierEventCal::UpperBarrierEventCal(const std::vector<boost::shared_ptr<DateInformation>>& dateInfoList,
										 const std::vector<Real>& upperTrrigerList,
										 const boost::shared_ptr<ReferenceCalculation>& refCal,
										 const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: EventCalculation(usingVariableInfoList), dateInfoList_(dateInfoList),
  upperTrrigerList_(upperTrrigerList), refCal_(refCal)
{
	//couponYearFraction_ = dayCounter_.yearFraction(calculationStartDate,calculationEndDate);
}

void UpperBarrierEventCal::initializeImpl(const TimeGrid& timeGrid,
				const boost::shared_ptr<YieldTermStructure>& discountCurve,
				const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	for ( Size i=0 ; i < dateInfoList_.size() ; i++ )
	{
		this->dateInfoList_[i]->initialize(timeGrid,discountCurve,pathGenFactory);
		this->fixingDatePositionList_.push_back(this->dateInfoList_[i]->fixingDatePositions());
		this->fixingDatePositionSizeList_.push_back(this->fixingDatePositionList_[i].size());
	}

	this->refCal_->initialize(timeGrid,discountCurve,pathGenFactory);

	this->pastEventOcc_ = false;
	this->pastBarrierStartCount_ = 0;
	this->pastBarrierStartPosition_ = 0;
	this->barrierNum_ = upperTrrigerList_.size();

}

Real UpperBarrierEventCal::accrualNum(const MultiPath& path,Size endPosition)
{
	Real tf = this->checkEventImpl(path,endPosition);
	return tf;
}

bool UpperBarrierEventCal::pastEventOcc()
{
	return true;
}

bool UpperBarrierEventCal::checkEventImpl(const MultiPath& path,Size endPosition)
{
	bool tf = this->pastEventOcc_;

	if ( tf == false )
	{
		for ( Size b = this->pastBarrierStartCount_ ; b < this->barrierNum_ ; b++)
		{
			//const std::valarray<Size>& v

			for( Size t = this->pastBarrierStartPosition_ ;t < fixingDatePositionSizeList_[b] ; ++t )
			{
				Real refVal = this->refCal_->calSlice(path,this->fixingDatePositionList_[b][t]);

				if ( refVal > this->upperTrrigerList_[b] )
				{
					return true;
				}
			}
		}
		//}
	}


	return tf;
}

std::vector<Date> UpperBarrierEventCal::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();

	return fixingDates;
}

std::vector<Date> UpperBarrierEventCal::payoffDates() const
{
	std::vector<Date> payoffDates;

	return payoffDates;
}

bool UpperBarrierEventCal::inRange(const std::valarray<Real>& val)
{
	return false;
}

}

