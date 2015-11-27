#include <xmlFactory/Factory/instrument/structuredProduct/dateFactory.hpp>
#include <boost/algorithm/string/case_conv.hpp>

using boost::algorithm::to_upper_copy;
using namespace TinyXPath;

namespace XmlFactory {

	DateFactory::DateFactory(std::string factoryName)
	: factoryName_(factoryName)
	{
	
	}
	void DateFactory::parseXml(TiXmlNode* xmlNode)
	{
		std::strinf dateStr;
		if(!(xmlNode->Attribute("symID")))
		{
			dateStr = xmlNode->FirstChild("adjustableDate").FirstChild("unadjustedDate").Element();
			data_[xmlNode->Attribute("symID")] = ConvertFunction::strToDate(dateStr);
				
		}

	}
	void DateFactory::build()
	{
	
	}
	bool DateFactory::isFactory(std::string fName)
	{
		if(factoryName_ == fName)
		{
			return true;
		}else
		{
			return false;
		}
	}

	Date DateFactory::getDate()
	{
		return refDate_;
	}
	}

	std::string DateFactory::getDateStr(std::string refStr)
	{
		// ¹Ì±¸Çö
		return refStr;

	}







}