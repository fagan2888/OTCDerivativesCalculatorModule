#include "FdmContingentPayoffComposite.hpp"

namespace QuantLib {

FdmContingentPayoffComposite
	::FdmContingentPayoffComposite(const ContigentPayoffs& contigentPayoffs)  // 각각을 어떻게 적용할지 정의하는 class
: contigentPayoffs_(contigentPayoffs)
{
	for(Size i=0 ; i < contigentPayoffs_.size() ; ++i )
	{
		const std::vector<Time>& times = contigentPayoffs_[i].stoppingTimes();
		stoppingTimes_.insert(stoppingTimes.begin(), times.begin(),times.end());
	}

}

Size FdmContingentPayoffComposite::size()
{
	return contigentPayoffs.size();
}

void FdmContingentPayoffComposite::build(const boost::shared_ptr<FdmMesher>& mesher)
{

	for(Size i=0 ; i < contigentPayoffs_.size() ; ++i )
		contigentPayoffs_[i]->build(mesher);
}

void FdmContingentPayoffComposite::applyTo(std::valarray<Array>& a, Time t) const
{
	for(Size i=0 ; i < contigentPayoffs_.size() ; ++i )
		contigentPayoffs_[i]->applyTo(a,t);
}

const std::vector<Date>& FdmContingentPayoffComposite::stoppingDates() const
{
	return this->stoppingDates_;
}

void FdmContingentPayoffComposite::payoffCalculate(std::valarray<Array>& payoffs)
{
	for(Size i=0 ; i < contigentPayoffs_.size() ; ++i )
		contigentPayoffs_[i]->payoffRhs(rhs[i]);

	//count
}

const ContigentPayoffs& FdmContingentPayoffComposite::payoffs() const
{
	return payoffs_;
}


}
#endif
