#include "qlDateIntervalMakerFactory.hpp"
#include <boost/algorithm/string/case_conv.hpp>

using boost::algorithm::to_upper_copy;
//using namespace TinyXPath;

namespace XmlFactory {
	
	void qlDateIntervalMakerFactory::setSerialClass(const boost::shared_ptr<FpmlSerialized::EventDate>& serial_Class)
	{
		const Date& date = serial_Class->getDateSingle()->dateValue();

		this->dim_ = boost::shared_ptr<DateIntervalMaker>(
										new DateIntervalMaker(date));
	}

	void qlDateIntervalMakerFactory::setSerialClass(const boost::shared_ptr<FpmlSerialized::EventDates>& serial_Class)
	{
		const std::string& eventDatesTypeStr = serial_Class->getChoiceStr_eventDateType();

		if(eventDatesTypeStr == "dateList")
		{
			std::vector<Date> datesList;
			const std::vector<boost::shared_ptr<FpmlSerialized::XsdTypeDate>>& serial_dates = serial_Class->getDateList()->getDate();

			for(Size i=0 ; i < serial_dates.size() ; i++)
				datesList.push_back(serial_dates[i]->dateValue());

			this->dim_ = boost::shared_ptr<DateIntervalMaker>(
								new DateIntervalMaker(datesList));

		}
		else if(eventDatesTypeStr == "dateInterval")
		{
			const Date& firstDate = serial_Class->getDateInterval()->getFirstDate()->dateValue() ;
			const Date& lastDate = serial_Class->getDateInterval()->getLastDate()->dateValue();

			const Period& tenor = Period(10,QuantLib::Days);

			const Calendar& calendar = PathInformation::instance().getCalendar();

			//choice timeType에 관한 코드 필요

			this->dim_ = boost::shared_ptr<DateIntervalMaker>(
								new DateIntervalMaker(firstDate,
														lastDate,
														tenor, // skip에 사용할 tenor
														calendar));

		}else
		{
			QL_FAIL("unknown ChoiceStr or not set ChoiceStr. string : " << eventDatesTypeStr);
		}

	}

	boost::shared_ptr<QuantLib::DateIntervalMaker> qlDateIntervalMakerFactory::getDIM()
	{
		QL_REQUIRE(dim_,"DateIntervalMaker_Ptr is null ptr");
		return this->dim_;
	}

	std::string qlDateIntervalMakerFactory::getDateStr(const std::string& refStr)
	{
		QL_FAIL("not implemented");
		return refStr;

	}

}