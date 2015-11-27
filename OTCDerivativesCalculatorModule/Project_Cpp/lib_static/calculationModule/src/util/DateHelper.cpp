#include "DateHelper.hpp"

namespace QuantLib {

DateHelper::DateHelper()
{
}

std::vector<Date> DateHelper::remainDates(Date referenceDate, 
								std::vector<Date> dates,
								bool includeRefDate)
{
	std::vector<Date> results;

	for ( Size i=0 ; i < dates.size() ; i++ )
	{
		results.push_back(dates[i]);
	}

	std::sort(results.begin(), results.end());

	return results;
}

std::vector<Date> DateHelper::removeDuplicateDate(std::vector<Date> dates)
{
	std::vector<Date> results;
				
	for ( Size i=0 ; i < dates.size() ; i++ )
	{
		bool check = false;

		for ( Size j=0 ; j < results.size() ; j++ )
		{
			if ( dates[i] == results[j] )
			{
				check = true;
			}
		}

		if ( check == false )
		{
			results.push_back(dates[i]);
		}
	}

	std::sort(results.begin(), results.end());

	return results;
}

void DateHelper::mergeDates(std::vector<Date>& targer,const std::vector<Date>& newDates)
{
	Size newNum = newDates.size();

	for ( Size j=0 ; j < newNum ; j++ )
	{
		targer.push_back(newDates[j]);
	}

}

void DateHelper::mergeDates(std::vector<Date>& targer,const Date& newDate)
{
	targer.push_back(newDate);
}

//bool DateHelper::compETIEventDate(const boost::shared_ptr<EventTriggerInfo>& _first ,
//								  const boost::shared_ptr<EventTriggerInfo>& _second)
//{
//	return ( _first->getEventDate() < _second->getEventDate() );
//}

}