#include "fixingInformation.hpp"
#include <ql/math/comparison.hpp>

namespace QuantLib {

FixingInformation::FixingInformation(Real initialValue,
									const std::vector<Date>& fixingDates,
									const std::vector<Real>& fixingValues)
: initialValue_(initialValue) , fixingDates_(fixingDates), fixingValues_(fixingValues)
{
	
}

Real FixingInformation::fixingValue(const Date& date)
{
	Real v = this->initialValue_;
	
	std::vector<std::pair<Date,Real>> pairVec = std::vector<std::pair<Date,Real>>();

	for (Size i=0 ; i<fixingDates_.size() ; i++)
	{
		pairVec.push_back(std::pair<Date,Real>(fixingDates_[i],fixingValues_[i]));
	}

	std::sort(pairVec.begin(),pairVec.end());

	for (Size i=0 ; i<pairVec.size() ; i++)
	{
		if (pairVec[i].first < date )
		{
			v = pairVec[i].second;
		}
	}

	return v;
}

}

