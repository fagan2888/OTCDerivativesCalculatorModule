#include "choiceReferenceCal.hpp"

namespace QuantLib {

ChoiceReferenceCal::ChoiceReferenceCal(const boost::shared_ptr<QuantLib::FixingDateInfo>& fixingDateInfo,
									   const std::string& code,
									   const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: ReferenceCalculation(usingVariableInfoList), code_(code) 
{
	this->fixingDateInfo_ = fixingDateInfo;

}

void ChoiceReferenceCal::initializeImpl(const TimeGrid& timeGrid,
										const boost::shared_ptr<YieldTermStructure>& discountCurve,
										const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	this->fixingDateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);

	this->choiceAssetNum_ = pathGenFactory->getProcessNum(this->code_);
}

Real ChoiceReferenceCal::calculateImpl(const MultiPath& path,Size endPosition)
{
	return path[choiceAssetNum_][fixingDateInfo_->fixingDatePosition()];
}

Real ChoiceReferenceCal::calSlice(const MultiPath& path,Size position)
{
	return path[choiceAssetNum_][position];
}

Real ChoiceReferenceCal::calSlice(const std::valarray<Real>& val)
{
	return val[0];
}

std::vector<Date> ChoiceReferenceCal::fixingDates() const
{
	return std::vector<Date>();
}

}