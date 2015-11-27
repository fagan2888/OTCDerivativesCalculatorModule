#include "FdmAddPayoffCondition.hpp"

namespace QuantLib {
    
FdmAddPayoffCondition::
		FdmAddPayoffCondition(const boost::shared_ptr<FdmExprInnerValue>& payoffGrid,
								const std::vector<boost::shared_ptr<Domain>>& domain,
								Time t)
: domain_(domain), t_(t)
{
	const boost::shared_ptr<Mesher>& mesher = payoffGrid->mesher();
	const boost::shared_ptr<FdmLinearOpLayout> layout = mesher->layout();

	const FdmLinearOpIterator endIter = layout->end();

	Array x(mesher_->layout()->dim().size());

	for (FdmLinearOpIterator iter = layout->begin(); iter != endIter; ++iter) 
	{

		for (Size i=0 ; i < x.size(); ++i) 
		{
			x[i] = mesher_->location(iter, i);
		}
				
		if(domain[j](x))
		{
			locationIndexes_.push_back(iter.index());
			payoffValues_.push_back(innerValue(iter));
		}
	}
}

FdmAddPayoffCondition::
		FdmAddPayoffCondition(Real payoff,
								const boost::shared_ptr<FdmMesher>& mesher,
								const std::vector<boost::shared_ptr<Domain>>& domain,
								Time t)
: domain_(domain), t_(t)
{
	const boost::shared_ptr<Mesher>& mesher = payoffGrid->mesher();
	const boost::shared_ptr<FdmLinearOpLayout> layout = mesher->layout();

	const FdmLinearOpIterator endIter = layout->end();

	Array x(mesher_->layout()->dim().size());

	for (FdmLinearOpIterator iter = layout->begin(); iter != endIter; ++iter) 
	{

		for (Size i=0 ; i < x.size(); ++i) 
		{
			x[i] = mesher_->location(iter, i);
		}
				
		if(domain[j](x))
		{
			locationIndexes_.push_back(iter.index());
			payoffValues_.push_back(payoff);
		}
	}
}

void FdmAddPayoffCondition::applyTo(Array& a , Time t ) const
{
	QL_FAIL("not yet implimented");
}

    
}

#endif