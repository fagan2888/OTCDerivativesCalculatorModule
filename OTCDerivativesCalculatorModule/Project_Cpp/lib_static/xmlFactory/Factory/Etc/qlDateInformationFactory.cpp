#include "qlDateInformationFactory.hpp"

#include <Factory/Etc/all.hpp>

using namespace QuantLib;

namespace XmlFactory {

qlDateInformationFactory::qlDateInformationFactory()
{

}

boost::shared_ptr<QuantLib::DateInformation> qlDateInformationFactory::dateInfo(const boost::shared_ptr<FpmlSerialized::DateInformation>& xml_serial)
{
	boost::shared_ptr<QuantLib::DateInformation> dateInfo;

	std::string dateType = xml_serial->getType()->SValue();

	if ( dateType == "dailyInterval" )
	{
		const boost::shared_ptr<FpmlSerialized::DailyInterval> xml_dateInterval
			= xml_serial->getDailyInterval();

		dateInfo = this->dailyInterval(xml_dateInterval);
	}
	else if ( dateType == "dateList" )
	{
		const boost::shared_ptr<FpmlSerialized::DateList> xml_dateList
			= xml_serial->getDateList();

		dateInfo = this->dateList(xml_dateList);

	}
	else
	{
		QL_FAIL("unknown dateInformationType : " << dateType);
	}

	return dateInfo;
}

boost::shared_ptr<QuantLib::DateInformation> qlDateInformationFactory::dailyInterval(const boost::shared_ptr<FpmlSerialized::DailyInterval>& xml_serial)
{
	boost::shared_ptr<QuantLib::DateInformation> dateInfo;

	Date obserbationStartDate = xml_serial->getObservationStartDate()->dateValue();
	Date obserbationEndDate = xml_serial->getObservationEndDate()->dateValue();

	dateInfo = boost::shared_ptr<QuantLib::DateInformation>(
			new QuantLib::DailyInterval(obserbationStartDate,obserbationEndDate));

	return dateInfo;
}

boost::shared_ptr<QuantLib::DateInformation> qlDateInformationFactory::dateList(const boost::shared_ptr<FpmlSerialized::DateList>& xml_serial)
{
	boost::shared_ptr<QuantLib::DateInformation> dateInfo;

	std::vector<boost::shared_ptr<FpmlSerialized::XsdTypeDate>> xml_dateList
		= xml_serial->getDate();
	
	std::vector<Date> ql_dateList;

	for ( Size i=0 ; i < xml_dateList.size() ; i++)
	{
		Date date = xml_dateList[i]->dateValue();	
		ql_dateList.push_back(date);
	}

	dateInfo = boost::shared_ptr<QuantLib::DateInformation>(
			new QuantLib::DateList(ql_dateList));

	return dateInfo;
}

}

