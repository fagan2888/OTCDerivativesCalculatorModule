#pragma once

#include "convertFunction.hpp"
#include <boost/algorithm/string/case_conv.hpp>
#include <ql/errors.hpp>

using boost::algorithm::to_upper_copy;
//using namespace TinyXPath;

namespace ConvertFunction {

		bool getElementBool(TiXmlNode* xmlNode , const std::string& elementName){
			//element이름 getText()하는 부분에서 오류남.

			if((xmlNode->FirstChildElement(elementName.c_str())) != 0){
				std::string str = xmlNode->FirstChildElement(elementName.c_str())->GetText();
				if( to_upper_copy(str) == "TRUE" || to_upper_copy(str) == "T")	{
					return true;
				}else{
					return false;
				}
			}
			return false;
		}

		std::string getElementValue(TiXmlNode* xmlNode , const std::string& elementName){
				
				//element이름 getText()하는 부분에서 오류남.

			if((xmlNode->FirstChildElement(elementName.c_str())) != 0){
				return xmlNode->FirstChildElement(elementName.c_str())->GetText();	
			}else{
				return "";
			}
		}

		std::vector<std::string> getElementValues(TiXmlNode* xmlNode , const std::string& elementName){
			
			std::vector<std::string> values;

			if(xmlNode != 0){
				TiXmlElement* iterElement = xmlNode->FirstChildElement(elementName.c_str());

				while(iterElement != 0){
					values.push_back(iterElement->GetText());		
					iterElement = iterElement->NextSiblingElement(elementName.c_str());

				}
			}
		
			return values;

		}
		
		Date strToDate(const std::string& str){

			return Date(Day(std::atoi(str.substr(8,2).c_str())),
						Month(std::atoi(str.substr(5,2).c_str())),
						Year(std::atoi(str.substr(0,4).c_str())));
		}

		std::string dateToStr(Date date)
		{
			if ( date.serialNumber() > 0)
			{
				std::ostringstream ss;
				int month = static_cast<int>(date.month());
				int days = static_cast<int>(date.dayOfMonth());

				if ( month < 10 )
				{
					ss << date.year() << "-" << "0" << month ;
				}else
				{
					ss << date.year() << "-" << month ;
				}

				if ( days < 10 )
				{
					ss << "-" << "0" << days;
				}
				else
				{
					ss << "-" << days;
				}

				return ss.str();
			}
			else
			{
				return "1900-01-01";
			
			}

			//QL_FAIL("not implemented");
			//
			//std::string str = "2013-08-21";

			//return str;
		}

		std::vector<Date> dates(TiXmlNode* xmlNode){
			
			std::vector<Date> dates;

			if(xmlNode != 0){
				std::vector<std::string> datesStrs = getElementValues(xmlNode,"date");
				for(Size i = 0 ; i < datesStrs.size() ; ++i){
					dates.push_back(strToDate(datesStrs[i]));
				}
			}

			return dates;
		}

		double strToDouble(std::string str)
		{
			return std::atof(str.c_str());;
		}

		std::string doubleToStr(double d)
		{
			std::ostringstream strs;
			strs << d;
			return strs.str();
		}

		Size strToSize(std::string str)
		{
			return std::atol(str.c_str());
		}

		std::string tiXmlToStr(TiXmlNode* xmlNode)
		{
				//print
			TiXmlPrinter printer;
			printer.SetIndent( "\t" );

			xmlNode->Accept( &printer );
			const std::string& result = printer.Str();

			return result;
		}

		std::string to_string(double x)
		{
		  std::ostringstream ss;
		  ss << x;
		  return ss.str();
		}

		std::string to_string(bool x)
		{
		  std::ostringstream ss;
		  ss << x;
		  return ss.str();
		}

		std::string to_string2(unsigned int x)
		{
		  std::ostringstream ss;
		  ss << x;
		  return ss.str();
		}

		//bool dailyFlag(TiXmlNode* xmlNode){

		//	std::string type = S_xpath_string(xmlNode,"@type");
		//	std::string check = "daily"; 
		//	if(to_upper_copy(type) == to_upper_copy(check)){
		//		return true;
		//	}else{
		//		return false;
		//	}

		//}

	}