#include "compositeSumOptionETI.hpp"
#include <src/util/DateHelper.hpp>
#include <ql/settings.hpp>

namespace QuantLib {

//CompositeSumOptionETI::CompositeSumOptionETI(const Date& fixingDate,
//					const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
//					const boost::shared_ptr<ReferenceCalculation> referenceCal,
//					const std::vector<boost::shared_ptr<EventTriggerInfo>>& optionList)
//: EventTriggerInfo(), optionList_(optionList)
//{
//	this->fixingDates_.push_back(fixingDate);
//	this->payoffDateInfo_ = payoffDateInfo;
//	this->referenceCal_ =referenceCal;
//	this->payoffDatePositions_ = std::valarray<Size>(1);
//	
//	this->optionListNum_ = optionList_.size();
//
//	for ( Size i=0 ; i < optionListNum_ ; i++ )
//	{
//		optionList_[i]->setReferenceCal(referenceCal);
//	}
//
//}

CompositeSumOptionETI::CompositeSumOptionETI(const boost::shared_ptr<ReferenceCalculation> referenceCal,
											const std::vector<boost::shared_ptr<EventTriggerInfo>>& optionList,
											const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: EventTriggerInfo(usingVariableInfoList), optionList_(optionList)
{
	this->referenceCal_ =referenceCal;
	
	this->optionListNum_ = optionList_.size();
}

void CompositeSumOptionETI::initializeImpl(const TimeGrid& timeGrid,
								       const boost::shared_ptr<YieldTermStructure>& discountCurve,
									   const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	for ( Size i=0 ; i<optionListNum_ ; i++ )
	{
		optionList_[i]->initialize(timeGrid,discountCurve,pathGenFactory);
	}
}

bool CompositeSumOptionETI::pastEventOcc()
{
	return false;
}

bool CompositeSumOptionETI::checkEvent(const MultiPath& path,Size endPosition)
{
	return false;	
}

std::vector<Date> CompositeSumOptionETI::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();

	for ( Size i=0 ; i<optionList_.size() ; i++ )
	{
		helper.mergeDates(fixingDates,this->optionList_[i]->fixingDates());
	}

	helper.mergeDates(fixingDates,this->referenceCal_->fixingDates());

	return fixingDates;
}

std::vector<Date> CompositeSumOptionETI::payoffDates() const
{
	std::vector<Date> payoffDates;

	DateHelper helper = DateHelper();

	for ( Size i=0 ; i<optionList_.size() ; i++ )
	{
		helper.mergeDates(payoffDates,this->optionList_[i]->payoffDates());
	}
	
	return payoffDates;
}

Real CompositeSumOptionETI::payoffImpl(const MultiPath& path,Size endPosition)
{
	Real value = 0.0;

	for ( Size i=0 ; i<optionListNum_ ; i++ )
	{
		value += optionList_[i]->payoff(path,endPosition);
	}

	return value;// * discount_[0];

}


}

