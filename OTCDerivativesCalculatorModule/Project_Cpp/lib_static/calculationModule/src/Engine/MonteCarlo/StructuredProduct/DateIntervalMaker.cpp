#include "DateIntervalMaker.hpp"

namespace QuantLib {

DateIntervalMaker::DateIntervalMaker(const Date& date)
{
	DateType dateType_ = OneDay;
	dates_.push_back(date);
	firstDate_ = date;
	Lastdate_ = date;
}

DateIntervalMaker::DateIntervalMaker(const Date& firstDate,
									  const Date& Lastdate,
									  const Period& skipTenor, // skip에 사용할 tenor
									  const Calendar& calendar)
: firstDate_(firstDate), Lastdate_(Lastdate), skipTenor_(skipTenor), calendar_(calendar)
{
	DateType dateType_ = Daily;

	const Date& today = Settings::instance().evaluationDate();
			
	BusinessDayConvention convention = BusinessDayConvention::ModifiedFollowing;
	BusinessDayConvention terminationDateConvention = BusinessDayConvention::ModifiedFollowing;
	DateGeneration::Rule rule = DateGeneration::Rule::Backward;
	bool endOfMonth = false;

	Schedule historySchedule = Schedule(firstDate,
										today,
										Period(1,Days),
										calendar,
										convention,
										terminationDateConvention,
										rule,
										endOfMonth);

	Schedule skippedRemainSchedule = Schedule(today,
										Lastdate,
										skipTenor,
										calendar,
										convention,
										terminationDateConvention,
										rule,
										endOfMonth);

	Schedule nonSkippedRemainSchedule = Schedule(today,
										Lastdate,
										Period(1,Days),
										calendar,
										convention,
										terminationDateConvention,
										rule,
										endOfMonth);


	historyDates_ = historySchedule.dates();
	
	skippedRemainDates_ = skippedRemainSchedule.dates();
	nonSkippedRemainDates_ = nonSkippedRemainSchedule.dates();

	this->duplicateRemove(historyDates_);
	this->duplicateRemove(skippedRemainDates_);
	this->duplicateRemove(nonSkippedRemainDates_);

	dates_.insert(dates_.begin(),nonSkippedRemainDates_.begin(),nonSkippedRemainDates_.end());
	dates_.insert(dates_.begin(),historyDates_.begin(),historyDates_.end());

	this->duplicateRemove(dates_);

	skippedDates_.insert(skippedDates_.begin(),skippedRemainDates_.begin(),skippedRemainDates_.end());
	skippedDates_.insert(skippedDates_.begin(),historyDates_.begin(),historyDates_.end());

	this->duplicateRemove(skippedDates_);

	

}

void DateIntervalMaker::duplicateRemove(std::vector<Date>& dates)
{
	for (std::vector<Date>::iterator iter = dates.begin() ; iter != dates.end()-1; ++iter)
	{
		if(*iter == *(iter+1))
		{
			dates.erase(iter+1);
			iter -= 1;
		}
	}
}

//DateIntervalMaker::DateIntervalMaker(const Date& firstDate,
//									  const Date& Lastdate,
//									  const Calendar& calendar,
//									  DateType type)
//: firstDate_(firstDate), Lastdate_(Lastdate), calendar_(calendar)
//{
//	QL_FAIL("not implemated yet"); //  이거 schedule 관한 기초 정보 어디서 받아 올지 아직 미확정 2013-02-18
//
//	DateType dateType_ = type;
//	Period tenor = Period(1,Days);
//
//	switch (dateType_)
//	{
//		case Weekly :
//			tenor = Period(7,Days);
//		default:
//			
//	}
//
//	BusinessDayConvention convention = BusinessDayConvention::ModifiedFollowing;
//	BusinessDayConvention terminationDateConvention = BusinessDayConvention::ModifiedFollowing;
//	DateGeneration::Rule rule = DateGeneration::Rule::Backward;
//	bool endOfMonth = false;
//
//	Schedule schedule = Schedule(firstDate,
//								Lastdate,
//								tenor,
//								calendar,
//								convention,
//								terminationDateConvention,
//								rule,
//								endOfMonth);
//
//	this->dates_ = schedule.dates();
//}

DateIntervalMaker::DateIntervalMaker(const std::vector<Date> dates)
: firstDate_(dates.front()), Lastdate_(dates.back())
{
	DateType dateType_ = Dates;

	const Date& today = Settings::instance().evaluationDate();

	for(std::vector<Date>::iterator iter ; iter != dates.end() ; iter++)
	{
		if(*iter < today)
		{
			historyDates_.push_back(*iter);
		}
		else
		{
			nonSkippedRemainDates_.push_back(*iter);
		}
		
		dates_.push_back(*iter);
	}

}



}
