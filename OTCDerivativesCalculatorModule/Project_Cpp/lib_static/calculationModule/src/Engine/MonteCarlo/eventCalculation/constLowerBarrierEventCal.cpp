#include "constLowerBarrierETI.hpp"
#include <random>
#include <ql/time/daycounters/all.hpp>
#include <ql/settings.hpp>
#include <ql/math/matrix.hpp>
#include <valarray>
#include <ql/math/matrixutilities/choleskydecomposition.hpp>
#include <iostream>

namespace QuantLib {


ConstLowerBarrierETI::ConstLowerBarrierETI(const boost::shared_ptr<DateInformation>& barrierDateInfo,
											const boost::shared_ptr<ReferenceCalculation>& referenceCal,
											Real barrier,
											Date pastEventOccDate,
											Real pastEventValue,
											const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList )
: EventTriggerInfo(usingVariableInfoList), barrierDateInfo_(barrierDateInfo), barrier_(barrier),
  pastEventOccDate_(pastEventOccDate), pastEventValue_(pastEventValue)
{
	//this->definedVarNameList_.push_back("eventOccDate");
	//this->definedVarNameList_.push_back("eventOccValue");
	this->referenceCal_ = referenceCal;

	this->definedVarNameList_.push_back("refVariableFlag_eventOccDate");
	this->definedVarNameList_.push_back("refVariableFlag_eventOccValue");

	pastEventOcc_ = false;

	if ( pastEventOccDate.serialNumber() != 0 )
	{
		pastEventOcc_ = false;	
	}

}

void ConstLowerBarrierETI::initializeImpl(const TimeGrid& timeGrid,
									  const boost::shared_ptr<YieldTermStructure>& discountCurve,
									  const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	EventTriggerInfo::setRefVariable(pathGenFactory);

	this->timeGrid_ = timeGrid;
	this->assetNum_ = pathGenFactory->numAssets();
	//this->pathSize_ = pathGenFactory->pathSize();

	barrierDateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);
	referenceCal_->initialize(timeGrid,discountCurve,pathGenFactory);

	this->fixingDatePositions_ = barrierDateInfo_->fixingDatePositions();
	fixingDatePositionsNum_ = this->fixingDatePositions_.size();

}

bool ConstLowerBarrierETI::pastEventOcc()
{
	return pastEventOcc_;
}

//normal ¸¸ ¹Þ¾Æ¿È?
bool ConstLowerBarrierETI::autoCallEvent(const MultiPath& path)
{
	return false;
}

bool ConstLowerBarrierETI::checkEvent(const MultiPath& path,Size endPosition)
{
	bool occ = pastEventOcc_;
	
	if ( occ == false )
	{
		for ( Size asset=0 ;asset < assetNum_ ; ++asset )
		{
			for( Size t=0 ;t < fixingDatePositionsNum_ ; ++t )
			{
				Real refVal = this->referenceCal_->calSlice(path,this->fixingDatePositions_[t]);

				//std::cout << "fixingDatePositionsNum : " << t << " " << refVal << std::endl;

				if ( refVal < barrier_ )
				{
					//eventOccDate
					//autoCallEventOccPosition_ = t;

					if ( this->usedVarFlagList_[0] == true )
					{
						this->valueTypeRefPosition_[0]->value_ = t;
					}
					
					//eventOccValue
					if ( this->usedVarFlagList_[1] == true )
					{
						this->valueTypeRefPosition_[1]->value_ = refVal;
					}

					return true;
				}
			}
		}
	}

	return occ;
}

Real ConstLowerBarrierETI::payoffImpl(const MultiPath& path,Size endPosition)
{
	return 0.0;
}

std::vector<Date> ConstLowerBarrierETI::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();
	helper.mergeDates(fixingDates,this->barrierDateInfo_->fixingDates());

	return fixingDates;
}

std::vector<Date> ConstLowerBarrierETI::payoffDates() const
{
	std::vector<Date> payoffDates;

	return payoffDates;
}

}