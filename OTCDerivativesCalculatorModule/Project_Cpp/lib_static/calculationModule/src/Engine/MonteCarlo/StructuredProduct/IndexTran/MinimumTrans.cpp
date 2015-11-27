#include "MinimumTrans.hpp"
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/symbolmanager/IndexSymbolManager.hpp>

namespace QuantLib {
	
MinimumTrans::MinimumTrans(const std::string& symbolName,
						   const std::vector<boost::shared_ptr<VariableValue>>& refVariableValue)
: IndexTransBase(symbolName), refVariableValue_(refVariableValue)
{
	refVariableSize_ = refVariableValue.size();
	refVariablePtr_.resize(refVariableSize_);

	QL_REQUIRE(refVariableSize_ > 0,"refVariable must be positive Size");
}

Size MinimumTrans::size()
{
	return refVariableSize_;
}

void MinimumTrans::initialize()
{
				
}

void MinimumTrans::variableBind()
{
	this->thisVariableValue_ = IndexSymbolManager::instance().getSymbol(this->symbolName_);

	for(Size i=0 ; i < refVariableSize_ ; ++i)
	{
		const std::string& refString = refVariableValue_[i]->symbolName();
		if(refString != "No_Symbol")
		{
			refVariableValue_[i] = IndexSymbolManager::instance().getSymbol(refString);
		}
	}

}

void MinimumTrans::variablePtrBind()
{
	thisPtr_ = thisVariableValue_->getPtr();

	for(Size i=0 ; i < refVariableSize_ ; ++i)
	{
		refVariablePtr_[i] = refVariableValue_[i]->getPtr();
	}

}

std::vector<Date> MinimumTrans::indexFixingDates()
{
	std::vector<Date> indexFixings;

	indexFixings = this->thisVariableValue_->indexFixingDates();

	return indexFixings;

}

void MinimumTrans::calculate()
{
	this->calValue();
}

inline void MinimumTrans::calValue()
{
	*thisPtr_ = *refVariablePtr_[0];

	for(Size i=0 ; i<refVariableSize_ - 1 ; ++i)
		*thisPtr_ = std::min(*refVariablePtr_[i],*refVariablePtr_[i+1]);

}

}

