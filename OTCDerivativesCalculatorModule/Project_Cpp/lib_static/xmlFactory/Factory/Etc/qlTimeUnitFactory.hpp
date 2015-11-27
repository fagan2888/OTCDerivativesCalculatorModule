#ifndef xmlFactory_qltimeunitfactory_hpp
#define xmlFactory_qltimeunitfactory_hpp

#include <ql/time/period.hpp>
#include <string>
#include <boost/algorithm/string.hpp>

using namespace QuantLib;

namespace XmlFactory {

	class qlTimeUnitFactory {
		public:
			qlTimeUnitFactory()
			{
				
			}

			QuantLib::Period timeUnit(const std::string& tenorStr)
			{
				Size length = tenorStr.length();
				int n = atoi(tenorStr.substr(0 , length - 1  ).c_str()); 
				std::string unit = tenorStr.substr(length - 1 , 1 );

				std::string upperStr = boost::to_upper_copy(unit);

				QuantLib::Period period;

				if (upperStr == "D")
				{
					 period = QuantLib::Period(n,Days);
				}
				else if (upperStr == "W")
				{
					period = QuantLib::Period(n,Weeks);
				}
				else if (upperStr == "M")
				{
					period = QuantLib::Period(n,Months);
				}
				else if (upperStr == "Y")
				{
					period = QuantLib::Period(n,Years);
				}
				else
				{
				}

				return period;
					
			}

			QuantLib::Period timeUnit(Integer n,const std::string& unit)
			{
				std::string upperStr = boost::to_upper_copy(unit);
				
				QuantLib::Period period;

				if (upperStr == "D")
				{
					 period = QuantLib::Period(n,Days);
				}
				else if (upperStr == "W")
				{
					period = QuantLib::Period(n,Weeks);
				}
				else if (upperStr == "M")
				{
					period = QuantLib::Period(n,Months);
				}
				else if (upperStr == "Y")
				{
					period = QuantLib::Period(n,Years);
				}
				else
				{
				}

				return period;
					
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

			//QuantLib::Period timeUnitTenor(TiXmlNode* node)
			//{
			//	TiXmlElement* thisNode = node->FirstChildElement("tenor");
			//	std::string tenorStr = thisNode->GetText();

			//}

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