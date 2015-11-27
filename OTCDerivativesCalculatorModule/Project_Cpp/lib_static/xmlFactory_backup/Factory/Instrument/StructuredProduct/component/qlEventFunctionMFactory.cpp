#include <xmlFactory/Factory/Instrument/StructuredProduct/Component/qlEventFunctionMFactory.hpp>
#include <boost/algorithm/string/case_conv.hpp>

using boost::algorithm::to_upper_copy;

using namespace ConvertFunction;
using namespace TinyXPath;

namespace XmlFactory {

	qlEventFunctionMFactory::qlEventFunctionMFactory(TiXmlNode* xmlNode)
	{
		this->parseXml(xmlNode);
	}

	void qlEventFunctionMFactory::parseXml(TiXmlNode* xmlNode)
	{
		boost::shared_ptr<EventFunction> ptr;
		
		//bool equality = getElementBool(node,"equality");
		bool equality = xmlNode->FirstChild("checkValue").Attribute("equality");
		double checkValue = d_xpath_double(xmlNode,"//checkValue/text()");
		std::string functionType = getElementValue(xmlNode,"functionType");

		if(to_upper_copy(functionType)=="UPEVENTCHECK"){ptr = boost::shared_ptr<EventFunction>(new UpEventCheck(checkValue,equality));}
		else if(to_upper_copy(functionType)=="DOWNEVENTCHECK"){ptr = boost::shared_ptr<EventFunction>(new DownEventCheck(checkValue,equality));}
		else if(to_upper_copy(functionType)=="UPDOWNEVENTCHECK"){ptr = boost::shared_ptr<EventFunction>(
					new UpDownEventCheck(checkValue,equality,checkValue,equality));}
		//else if(functionType=="RangeCheck"){ptr = boost::shared_ptr<EventFunction>(new IdentityEventCheck(checkValue,equality));}
		else{ptr = boost::shared_ptr<EventFunction>(new IdentityEventCheck(equality));}

		//std::string value = node->FirstChildElement()->GetText();

		std::string functionSymbol = getElementValue(node,"functionSymbol");
		std::string indexSymbol = getElementValue(node,"indexSymbol");

		eventFunctionM_ = boost::shared_ptr<EventFunctionManager>(
									new EventFunctionManager(functionSymbol,
															 indexSymbol,
															 ptr));



		
		
	}

	void qlEventFunctionMFactory::build()
	{
		
	}


}