#include "ConstDualBarrierETI.hpp"
#include <random>
#include <ql/time/daycounters/all.hpp>
#include <ql/settings.hpp>
#include <ql/math/matrix.hpp>
#include <valarray>
#include <ql/math/matrixutilities/choleskydecomposition.hpp>

namespace QuantLib {

ConstDualBarrierETI::ConstDualBarrierETI(const boost::shared_ptr<DateInformation>& barrierDateInfo,
										const boost::shared_ptr<ReferenceCalculation>& referenceCal,									 
										Real upperBarrier,
										 Real lowerBarrier,
										 Date pastEventOccDate,
										 Real pastEventOccValue,
										 const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: EventTriggerInfo(usingVariableInfoList), barrierDateInfo_(barrierDateInfo), upperBarrier_(upperBarrier), lowerBarrier_(lowerBarrier),
  pastEventOccDate_(pastEventOccDate), pastEventOccValue_(pastEventOccValue)
{
	pastEventOcc_ = false;

	this->referenceCal_ = referenceCal;

	if ( pastEventOccDate.serialNumber() != 0 )
	{
		pastEventOcc_ = true;	
	}
}

void ConstDualBarrierETI::initializeImpl(const TimeGrid& timeGrid,
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

bool ConstDualBarrierETI::pastEventOcc()
{
	return pastEventOcc_;
}

//normal ¸¸ ¹Þ¾Æ¿È?
bool ConstDualBarrierETI::autoCallEvent(const MultiPath& path)
{
	return false;
}

bool ConstDualBarrierETI::checkEvent(const MultiPath& path,Size endPosition)
{
	bool occ = pastEventOcc_;
	
	if ( occ == false )
	{
		for ( Size asset=0 ;asset < assetNum_ ; ++asset )
		{
			for( Size t=0 ;t < fixingDatePositionsNum_ ; ++t )
			{
				Real refVal = this->referenceCal_->calSlice(path,this->fixingDatePositions_[t]);

				if ( refVal > upperBarrier_ || refVal < lowerBarrier_ )
				{
					return true;
				}
			}
		}
	}

	return occ;
}

Real ConstDualBarrierETI::payoffImpl(const MultiPath& path,Size endPosition)
{
	return 0.0;
}

std::vector<Date> ConstDualBarrierETI::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();
	helper.mergeDates(fixingDates,this->barrierDateInfo_->fixingDates());

	return fixingDates;
}

std::vector<Date> ConstDualBarrierETI::payoffDates() const
{
	std::vector<Date> payoffDates;

	return payoffDates;
}

}