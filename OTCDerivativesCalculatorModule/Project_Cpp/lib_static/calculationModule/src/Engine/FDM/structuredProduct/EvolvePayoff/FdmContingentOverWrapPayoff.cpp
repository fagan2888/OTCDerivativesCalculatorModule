#include "FdmContingentOverWrapPayoff.hpp"

namespace QuantLib {

FdmContingentOverWrapPayoff::FdmContingentOverWrapPayoff(const Date& payoffDate,
										const std::vector<FdmPayoffFunction>& payoffFunction,
										const std::vector<boost::shared_ptr<Domain>>& domains,
										Size fixingDays,
										const ContingentEvent& eventInfo,
										const FdmContingentStepConditionComposite& conditions);
: payoffDate_(payoffDate), payoffFunction_(payoffFunction), domains_(domains),fixingDays_(fixingDays),
  eventInfo_(eventInfo), conditions_(conditions)										
{
	
}

std::vector<Time> FdmContingentOverWrapPayoff::stoppingTimes()
{
	std::vector<Time> stoppingTimes;

	stoppingTimes_.attach(this->eventInfo.eventTimes());

	return stoppingTimes;
}

void FdmContingentOverWrapPayoff::applyTo(std::valarray<Array>& a , Time t ) const
{
	//conditions_->applyTo();  //? 먼저 적용해야대나..?

	Size overwrap_t_Num = overwrap_t.size();
	bool tf = false;

	//overwrap t
	for(Size i=0 ; i < overwrap_t_Num ; ++i)
	{
		if(overwrap_t[i] == t)
			tf = true;
	}
	
	if(tf)
	{
		Size indexPositionNum = indexPosition_.size()
		for(Size k = 0 ; k < indexPositionNum ; ++ k)
		{
			a[0][indexPosition_[payoffPosition]] = a[payoffPosition][k];
		}
	}

	//conditions_->applyTo();   //? 먼저 적용해야대나..?
}

}