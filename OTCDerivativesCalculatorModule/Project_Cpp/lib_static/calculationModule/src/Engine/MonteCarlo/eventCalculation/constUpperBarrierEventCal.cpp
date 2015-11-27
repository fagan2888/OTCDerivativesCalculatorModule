#include "constUpperBarrierETI.hpp"
#include <random>
#include <ql/time/daycounters/all.hpp>
#include <ql/settings.hpp>
#include <ql/math/matrix.hpp>
#include <valarray>
#include <ql/math/matrixutilities/choleskydecomposition.hpp>

namespace QuantLib {

ConstUpperBarrierETI::ConstUpperBarrierETI(const boost::shared_ptr<DateInformation>& barrierDateInfo,
										   const boost::shared_ptr<ReferenceCalculation>& referenceCal,
										   Real barrier,
										   Date pastEventOccDate,
										   Real pastEventOccValue,
										   const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: EventTriggerInfo(usingVariableInfoList), barrierDateInfo_(barrierDateInfo), barrier_(barrier),
  pastEventOccDate_(pastEventOccDate), pastEventOccValue_(pastEventOccValue)
{
	this->referenceCal_ = referenceCal; 
	this->pastEventOcc_ = false;

	//if ( pastEventOccDate.serialNumber() != 0 )
	//{
	//	pastEventOcc_ = true;	
	//}
}

void ConstUpperBarrierETI::initializeImpl(const TimeGrid& timeGrid,
									  const boost::shared_ptr<YieldTermStructure>& discountCurve,
									  const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	this->timeGrid_ = timeGrid;
	this->assetNum_ = pathGenFactory->numAssets();
	//this->pathSize_ = pathGenFactory->pathSize();
	
	referenceCal_->initialize(timeGrid,discountCurve,pathGenFactory);
	barrierDateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);

	this->fixingDatePositions_ = barrierDateInfo_->fixingDatePositions();
	fixingDatePositionsNum_ = this->fixingDatePositions_.size();

}

bool ConstUpperBarrierETI::pastEventOcc()
{
	return pastEventOcc_;
}

////normal ¸¸ ¹Þ¾Æ¿È?
//bool ConstUpperBarrierETI::autoCallEvent(const MultiPath& path)
//{
//	return false;
//}

bool ConstUpperBarrierETI::checkEvent(const MultiPath& path,Size endPosition)
{
	bool occ = pastEventOcc_;
	
	if ( occ == false )
	{
		//for ( Size asset=0 ;asset < assetNum_ ; ++asset )
		//{
		for( Size t=0 ;t < fixingDatePositionsNum_ ; ++t )
		{
			Real refVal = this->referenceCal_->calSlice(path,this->fixingDatePositions_[t]);

			if ( refVal > barrier_ )
			{
				return true;
			}
		}
		//}
	}

	return occ;
}

Real ConstUpperBarrierETI::payoffImpl(const MultiPath& path,Size endPosition)
{
	return 0.0;
}

std::vector<Date> ConstUpperBarrierETI::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();
	helper.mergeDates(fixingDates,this->barrierDateInfo_->fixingDates());

	return fixingDates;
}

std::vector<Date> ConstUpperBarrierETI::payoffDates() const
{
	std::vector<Date> payoffDates;

	return payoffDates;
}


}