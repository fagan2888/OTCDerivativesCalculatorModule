#ifndef xmlFactory_qltimeunitfactory_hpp
#define xmlFactory_qltimeunitfactory_hpp

#include <ql/time/period.hpp>
#include <string>

using namespace QuantLib;

namespace XmlFactory {

	class qlTimeUnitFactory {
		public:
			qlTimeUnitFactory()
			{
				
			}

			QuantLib::Period timeUnit(Integer n,const std::string& unit)
			{
				if (unit == "M")
					return QuantLib::Period(n,Months);

				return QuantLib::Period(n,Months);
					
			}

			QuantLib::Period timeUnit(TiXmlNode* node)
			{
				TiXmlNode* thisNode = node->FirstChildElement("tenor");

				if(!thisNode)
					thisNode = node;

				TiXmlElement* periodMultiNode = thisNode->FirstChildElement("periodMultiplier");
				TiXmlElement* periodNode = thisNode->FirstChildElement("period");

				Integer multi = std::atoi(periodMultiNode->GetText());
				std::string period = periodNode->GetText();

				return this->timeUnit(multi,period);
			}

			std::string periodStr(QuantLib::Period period)
			{
				std::string str;

				if ( period.units() == Days )
				{
					str = "D";
				}
				else if( period.units() == Weeks )
				{
					str = "W";
				}
				else if( period.units() == Months )
				{
					str = "M";
				}
				else if( period.units() == Years )
				{
					str = "Y";
				}
				else
				{
					//Error
				}

				return str;
			
			}

	};
}

#endif