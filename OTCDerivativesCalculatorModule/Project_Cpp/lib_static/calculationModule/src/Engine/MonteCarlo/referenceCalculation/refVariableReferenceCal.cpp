#include "refVariableReferenceCal.hpp"

namespace QuantLib {

RefVariableReferenceCal::RefVariableReferenceCal(const std::string& refName,
												 const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList )
: ReferenceCalculation(usingVariableInfoList), refName_(refName)
{

}

void RefVariableReferenceCal::initializeImpl(const TimeGrid& timeGrid,
						const boost::shared_ptr<YieldTermStructure>& discountCurve,
						const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	//IRefVariable::setRefVariable(pathGenFactory);
	//fixingDateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);

	//this->assetPosition_ = pathGenFactory->getProcessNum(this->code_);
	this->valueTypeRefPosition_ = std::valarray<boost::shared_ptr<variableStore>>(1);
	this->valueTypeRefPosition_[0] = pathGenFactory->getValueTypeReference(refName_);
}

Real RefVariableReferenceCal::calculateImpl(const MultiPath& path,Size endPosition)
{
	//Size position = fixingDateInfo_->fixingDatePosition();

	//return path[assetPosition_][position];

	return this->valueTypeRefPosition_[0]->value_;
}

Real RefVariableReferenceCal::calSlice(const std::valarray<Real>& val)
{
	return val[assetPosition_];
}

Real RefVariableReferenceCal::calSlice(const MultiPath& path,Size position)
{
	return 0.0;
}

std::vector<Date> RefVariableReferenceCal::fixingDates() const
{
	std::vector<Date> fixingDates;

	return fixingDates;
}


}