#include <xmlFactory/Factory/instrument/structuredProduct/EventFunctionMFactory.hpp>
#include <boost/algorithm/string/case_conv.hpp>

using boost::algorithm::to_upper_copy;

using namespace ConvertFunction;
using namespace TinyXPath;

namespace XmlFactory {

	EventFunctionMFactory::EventFunctionMFactory(TiXmlNode* xmlNode)
	{
		this->parseXml(xmlNode);
	}

	void EventFunctionMFactory::parseXml(TiXmlNode* node)
	{
		boost::shared_ptr<EventFunction> ptr;
		
		//bool equality = getElementBool(node,"equality");
		bool equality = node->FirstChild("checkValue").Attribute("equality");
		double checkValue = d_xpath_double(node,"//checkValue/text()");
		std::string functionType = getElementValue(node,"functionType");

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

	void EventFunctionMFactory::build()
	{
		
	}


}