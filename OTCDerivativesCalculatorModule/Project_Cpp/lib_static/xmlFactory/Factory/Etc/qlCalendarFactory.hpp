#ifndef xmlFactory_qlcalendarfactory_hpp
#define xmlFactory_qlcalendarfactory_hpp

#include <ql/time/calendar.hpp>
#include <ql/time/calendars/all.hpp>
#include <string>
#include <boost/algorithm/string.hpp>

namespace XmlFactory {
	
	enum calendarType 
	{
		KOR = 0
			
	};

	class qlCalendarFactory {
		public:
			qlCalendarFactory()
			{
			
			}

			QuantLib::Calendar calendar(TiXmlNode* node)
			{
				TiXmlElement* calNode = node->FirstChildElement("calendar");

				return this->calendar(calNode->GetText());

			}

			QuantLib::Calendar calendar(const std::string& typeStr)
			{
				QuantLib::Calendar calendar;
				std::string upperStr = boost::to_upper_copy(typeStr);

				if(upperStr=="KOR") {
					calendar = SouthKorea();
				}
				else if(upperStr=="NULL") {
					calendar = NullCalendar();
				}
				else if(upperStr=="NULLCALENDAR") {
					calendar = NullCalendar();
				}
				else {
					QL_FAIL("unknown type calendar");
				}

				return calendar;

			}
	};

}
#endif