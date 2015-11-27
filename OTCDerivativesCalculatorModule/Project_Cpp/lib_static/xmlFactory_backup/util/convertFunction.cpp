#pragma once

#include "convertFunction.hpp"
#include <boost/algorithm/string/case_conv.hpp>

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
		Size strToSize(std::string str)
		{
			return std::atol(str.c_str());
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