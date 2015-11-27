#include "CallPutCompositeReturnCal.hpp"

namespace QuantLib {

CallPutCompositeReturnCal::CallPutCompositeReturnCal(const std::vector<Real>& weight,
													const boost::shared_ptr<ReferenceCalculation>& refCal,
													const std::vector<boost::shared_ptr<OptionPayoffFunction>>& optionPayoff,
													const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList )
: ReturnCalculation(usingVariableInfoList), refCal_(refCal), optionPayoff_(optionPayoff)
{

}

void CallPutCompositeReturnCal::initializeImpl(const TimeGrid& timeGrid,
						const boost::shared_ptr<YieldTermStructure>& discountCurve,
						const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	this->refCal_->initialize(timeGrid,discountCurve,pathGenFactory);
	this->payoffNum_ = optionPayoff_.size();
}

Real CallPutCompositeReturnCal::calculateImpl(const MultiPath& path,Size endPosition)
{
	Real refValue = this->refCal_->calculate(path,endPosition);
	Real value = 0.0;

	for ( Size i=0 ; i<payoffNum_ ; i++ )
	{
		value += this->optionPayoff_[i]->calculate(refValue);
	}

	return value;

}


Real CallPutCompositeReturnCal::calSlice(const std::valarray<Real>& val)
{
	return 0.0;
}

Real CallPutCompositeReturnCal::calSlice(const MultiPath& path,Size position)
{
	return 0.0;
}

std::vector<Date> CallPutCompositeReturnCal::fixingDates() const
{
	return this->fixingDates_;
}


}