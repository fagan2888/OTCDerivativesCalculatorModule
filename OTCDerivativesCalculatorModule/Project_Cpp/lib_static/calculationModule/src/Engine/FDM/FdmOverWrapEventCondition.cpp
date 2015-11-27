#include "OverWrapCondition.hpp"

namespace QuantLib {
    
OverWrapCondition::OverWrapCondition(const boost::shared_ptr<FdmMesher>& mesher,
								  const std::vector<boost::shared_ptr<Domain>>& domain,
								  Time t)
: mesher_(mesher), domain_(domain), t_(t)
{
	const boost::shared_ptr<FdmLinearOpLayout> layout = mesher->layout();
	const FdmLinearOpIterator endIter = layout->end();

	Array x(mesher_->layout()->dim().size());

	for (FdmLinearOpIterator iter = layout->begin(); iter != endIter; ++iter) 
	{
		for (Size i=0 ; i < x.size(); ++i) {
			x[i] = mesher_->location(iter, i);
		}
				
		for(Size j=0 ; j < domain.size() ; ++j)
		{
			if(domain[j](x))
			{
				locationIndexes_.push_back(iter.index());
			}
		}
	}
}

void OverWrapCondition::applyTo(std::valarray<Array>& a , Time t ) const 
{
	const Array& targerArr = a[0];

	for(Size i=1 ; i < a.size() ; ++i)
	{
		if(locationTimes_[i] == t)
		{
			const valarray<Size>& indexes = locationIndexes_[i];
			const valarray<Real>& overWrapArr = a[i];

			Size iterNum = indexes.size();

			for(Size j = 0 ; j < iterNum ; ++j )
				targerArr[locationIndexes_[j]] = overWrapArr[locationIndexes_[j]];
		}
	}
}

}

#endif