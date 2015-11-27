#include "constKiMinLossPayoffTriggerETI.hpp"
#include <src/util/DateHelper.hpp>

namespace QuantLib {

ConstKiMinLossPayoffTriggerETI::ConstKiMinLossPayoffTriggerETI(const boost::shared_ptr<ReferenceCalculation>& referenceCal,
															   const boost::shared_ptr<DateInformation>& kiBarrierDate,
															   const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
															   std::vector<Real> kiValues,
															   bool pastEventOcc,
															   const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: EventTriggerInfo(usingVariableInfoList), referenceCal_(referenceCal), kiBarrierDate_(kiBarrierDate)
{
	pastEventOcc_ = pastEventOcc;
	this->payoffDateInfo_ = payoffDateInfo;

	kiValues_ = std::valarray<Real>(kiValues.size());
	
	for ( Size i=0 ; i < kiValues.size() ; i++ )
	{
		kiValues_[i] = kiValues[i];
	}
	
}


void ConstKiMinLossPayoffTriggerETI::initializeImpl(const TimeGrid& timeGrid,
				const boost::shared_ptr<YieldTermStructure>& discountCurve,
				const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	referenceCal_->initialize(timeGrid,discountCurve,pathGenFactory);
	kiBarrierDate_->initialize(timeGrid,discountCurve,pathGenFactory);
	payoffDateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);

	assetNum_ = pathGenFactory->numAssets();
}

bool ConstKiMinLossPayoffTriggerETI::pastEventOcc()
{
	return this->pastEventOcc_;
}

bool ConstKiMinLossPayoffTriggerETI::autoCallEvent(const MultiPath& path)
{
	return false;
}

bool ConstKiMinLossPayoffTriggerETI::checkEvent(const MultiPath& path,Size endPosition)
{
	if ( pastEventOcc_ == false )
	{
		for ( Size t=0 ; t < fixingDateNum_ ; t++ )
		{
			for ( Size asset=0 ; asset < assetNum_ ; asset++ )
			{
				if ( path[asset][fixingDatePosition_[t]] < kiValues_[asset] )
				{
					return true;
				}
			}
		}
	}

	return pastEventOcc_;

}

Real ConstKiMinLossPayoffTriggerETI::payoffImpl(const MultiPath& path,Size endPosition)
{
	return this->referenceCal_->calculate(path,endPosition) * payoffDateInfo_->discount();
}

std::vector<Date> ConstKiMinLossPayoffTriggerETI::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();
	helper.mergeDates(fixingDates,this->referenceCal_->fixingDates());
	helper.mergeDates(fixingDates,this->kiBarrierDate_->fixingDates());

	return fixingDates;
}

std::vector<Date> ConstKiMinLossPayoffTriggerETI::payoffDates() const
{
	std::vector<Date> payoffDates;

	payoffDates.push_back(payoffDateInfo_->fixingDate());

	return payoffDates;
}

}

