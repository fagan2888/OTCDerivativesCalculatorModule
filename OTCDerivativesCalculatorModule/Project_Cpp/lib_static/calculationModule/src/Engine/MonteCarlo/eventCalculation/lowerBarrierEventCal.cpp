#include "LowerBarrierEventCal.hpp"

namespace QuantLib {

LowerBarrierEventCal::LowerBarrierEventCal(const std::vector<boost::shared_ptr<DateInformation>>& dateInfoList,
										 const std::vector<Real>& lowerTrrigerList,
										 const boost::shared_ptr<ReferenceCalculation>& refCal,
										 const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: EventCalculation(usingVariableInfoList), dateInfoList_(dateInfoList),
  lowerTrrigerList_(lowerTrrigerList), refCal_(refCal)
{
	//couponYearFraction_ = dayCounter_.yearFraction(calculationStartDate,calculationEndDate);
}

LowerBarrierEventCal::LowerBarrierEventCal(const boost::shared_ptr<DateInformation>& dateInfo,
									 const Real lowerTrriger,
									 const boost::shared_ptr<ReferenceCalculation>& refCal,
									 const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList )
:EventCalculation(usingVariableInfoList), refCal_(refCal)
{
	dateInfoList_.push_back(dateInfo);
	lowerTrrigerList_.push_back(lowerTrriger);
}

void LowerBarrierEventCal::initializeImpl(const TimeGrid& timeGrid,
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
	//this->todayPosition_ = pathGenFactory->getTodayPosition();

	this->pastEventOcc_ = false;
	this->pastBarrierStartCount_ = 0;

	this->pastBarrierStartPosition_ = 0; // 걍 0 씀 왜냐면 전체 그냥 다 조사할거니까

	this->barrierNum_ = lowerTrrigerList_.size();

	
}

Real LowerBarrierEventCal::accrualNum(const MultiPath& path,Size endPosition)
{
	Real tf = this->checkEventImpl(path,endPosition);
	return tf;
}

bool LowerBarrierEventCal::pastEventOcc()
{
	return true;
}

bool LowerBarrierEventCal::checkEventImpl(const MultiPath& path,Size endPosition)
{
	bool tf = this->pastEventOcc_;
	Real refVal = 0.0;

	#ifdef LogPrint

	std::ostringstream ss;

	#endif

	if ( tf == false )
	{
		for ( Size b = this->pastBarrierStartCount_ ; b < this->barrierNum_ ; b++)
		{
			//const std::valarray<Size>& v 17.7
			const std::valarray<Size>& v = this->fixingDatePositionList_[b];

			for( Size t = this->pastBarrierStartPosition_ ;t < fixingDatePositionSizeList_[b] ; ++t )
			{
				refVal = this->refCal_->calSlice(path,v[t]);

				if ( refVal < this->lowerTrrigerList_[b] )
				{
					#ifdef LogPrint
						ss << "LowerBarrierEventCal TF : 1 , obDateNum :" <<  fixingDatePositionSizeList_[b] ;
						//ss << "pastBarrStartPos : " << this->pastBarrierStartPosition_;
						ss << " refVal[" << v[t] << "] : " << refVal << " , barrier Check ( " << refVal << "< barrier : " << this->lowerTrrigerList_[b] << ")";

						path.log_.push_back(ss.str());

					#endif

					return true;
				}
			}
		}
		//}
	}

	#ifdef LogPrint

	ss << "LowerBarrierEventCal TF : 0 , " ;
	ss << "barrier : " << this->lowerTrrigerList_[0];
	path.log_.push_back(ss.str());

	#endif

	return tf;
}

std::vector<Date> LowerBarrierEventCal::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();

	return fixingDates;
}

std::vector<Date> LowerBarrierEventCal::payoffDates() const
{
	std::vector<Date> payoffDates;

	return payoffDates;
}

bool LowerBarrierEventCal::inRange(const std::valarray<Real>& val)
{
	return false;
}

}

