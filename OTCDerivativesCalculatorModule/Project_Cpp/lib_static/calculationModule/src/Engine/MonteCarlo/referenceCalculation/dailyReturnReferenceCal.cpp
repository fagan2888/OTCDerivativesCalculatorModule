#include "dailyReturnReferenceCal.hpp"

namespace QuantLib {

DailyReturnReferenceCal::DailyReturnReferenceCal(const boost::shared_ptr<FixingDateInfo>& fixingDateInfo,
												const std::string& code,
												const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: ReferenceCalculation(usingVariableInfoList), fixingDateInfo_(fixingDateInfo), code_(code)
{
}

void DailyReturnReferenceCal::initializeImpl(const TimeGrid& timeGrid,
						const boost::shared_ptr<YieldTermStructure>& discountCurve,
						const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	fixingDateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);

	this->assetPosition_ = pathGenFactory->getProcessNum(this->code_);
}

Real DailyReturnReferenceCal::calculateImpl(const MultiPath& path,Size endPosition)
{
	Size position = fixingDateInfo_->fixingDatePosition();

	return path[assetPosition_][position] / path[assetPosition_][position-1];
}

Real DailyReturnReferenceCal::calSlice(const std::valarray<Real>& val)
{
	return val[assetPosition_];
}

Real DailyReturnReferenceCal::calSlice(const MultiPath& path,Size position)
{
	Real value = 0.0;

	if (position == 0 )
	{
		value = 1.0;
		return value;
	}
	else
	{
		value = path[assetPosition_][position] / path[assetPosition_][position-1];
		return value;
	}

}

std::vector<Date> DailyReturnReferenceCal::fixingDates() const
{
	std::vector<Date> fixingDates;

	fixingDates.push_back(fixingDateInfo_->fixingDate());

	return fixingDates;
}


}