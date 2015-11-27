#pragma once

#include <xmlFactory/util/xmlUtilHeader.hpp>
#include <ql/time/date.hpp>
//#include <tinyXml/tinyxml.h>

using namespace QuantLib;

namespace ConvertFunction {

	bool getElementBool(TiXmlNode* xmlNode , const std::string& elementName);
	std::string getElementValue(TiXmlNode* xmlNode , const std::string& elementName);
	std::vector<std::string> getElementValues(TiXmlNode* xmlNode , const std::string& elementName);
	std::vector<Date> dates(TiXmlNode* xmlNode);
	
	Date strToDate(const std::string& str);

	std::string dateToStr(Date date);

	bool dailyFlag(TiXmlNode* xmlNode);
	double strToDouble(std::string str);
	std::string doubleToStr(double d);
	
	Size strToSize(std::string str);
	std::string tiXmlToStr(TiXmlNode* xmlNode);

	std::string to_string(double x);

	std::string to_string(bool x);

	std::string to_string2(unsigned int x);

}