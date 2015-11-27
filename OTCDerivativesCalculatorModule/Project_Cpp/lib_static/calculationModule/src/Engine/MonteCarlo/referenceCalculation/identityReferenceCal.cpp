#include "identityReferenceCal.hpp"

namespace QuantLib {

//IdentityReferenceCal::IdentityReferenceCal(const Date& fixingDates,
//										   const std::string& code)
//: code_(code)
//{
//	this->fixingDates_.push_back(fixingDates);
//	fixingDatePositions_ = std::valarray<Size>(1);
//}

IdentityReferenceCal::IdentityReferenceCal(const boost::shared_ptr<FixingDateInfo>& fixingDateInfo,
										   const std::string& code,
										   const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList )
: ReferenceCalculation(usingVariableInfoList), code_(code)
{
	this->fixingDateInfo_ = fixingDateInfo;
}

void IdentityReferenceCal::initializeImpl(const TimeGrid& timeGrid,
						const boost::shared_ptr<YieldTermStructure>& discountCurve,
						const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{

	fixingDateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);

	this->assetPosition_ = pathGenFactory->getProcessNum(this->code_);
}

Real IdentityReferenceCal::calculateImpl(const MultiPath& path,Size endPosition)
{
	Size position = fixingDateInfo_->fixingDatePosition();

	return path[assetPosition_][position];
}

Real IdentityReferenceCal::calSlice(const std::valarray<Real>& val)
{
	return val[assetPosition_];
}

Real IdentityReferenceCal::calSlice(const MultiPath& path,Size position)
{
	return 0.0;
}

std::vector<Date> IdentityReferenceCal::fixingDates() const
{
	std::vector<Date> fixingDates;
	fixingDates.push_back(fixingDateInfo_->fixingDate());

	return fixingDates;
}


}