#ifndef xmlFactory_qlcalendarfactory_hpp
#define xmlFactory_qlcalendarfactory_hpp

#include <ql/time/calendar.hpp>
#include <ql/time/calendars/all.hpp>
#include <string>

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
				calendarType irt = this->dcType(typeStr);
				QuantLib::Calendar cal;

				switch (irt) 
				{
					case KOR :
						cal = SouthKorea();
						break;
					default:
						QL_FAIL("unknown type calendar");
						break;
				}

				return cal;

			}
		private:
			calendarType dcType(const std::string& typeStr)
			{
				if(typeStr=="KOR"){return KOR;}
				else
				{
					QL_FAIL("unknown type calendar string");
				}
			}

	};

}
#endif