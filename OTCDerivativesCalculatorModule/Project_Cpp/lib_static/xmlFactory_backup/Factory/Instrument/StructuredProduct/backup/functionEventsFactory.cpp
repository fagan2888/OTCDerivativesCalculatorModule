#include <xmlFactory/Factory/instrument/structuredProduct/functionEventsFactory.hpp>
#include <xmlFactory/test/convertFunction.hpp>
#include <boost/algorithm/string/case_conv.hpp>

using boost::algorithm::to_upper_copy;

using namespace QuantLib;
using namespace TinyXPath;
using namespace ConvertFunction;

namespace XmlFactory {

FunctionEventsFactory::FunctionEventsFactory()
{

}

FunctionEventsFactory::FunctionEventsFactory(TiXmlNode* xmlNode)
{
	this->parseXml(xmlNode);
}

void FunctionEventsFactory::parseXml(TiXmlNode* node)
{
	//parsing Code
	//if(!(node->Attribute("symID")))
	//{
	//	EventSymbolManager::instance().setSymbol(node->Attribute("symID")));
	//}

	const Size functionNum = 2;
	TiXmlNode* fucntionEventsNode = XNp_xpath_node(node,"./eventFunction");

	std::vector<boost::shared_ptr<EventFunctionManager>> eventFunctionMs;
	boost::shared_ptr<JointEvent> jointEvent;

	EventFunctionMFactory efmF = EventFunctionMFactory();
	JointEventFactory feF = JointEventFactory();

	for(TiXmlNode* roopNode = fucntionEventsNode ; roopNode ; )
	{
		eventFunctionMs.push_back(efmF.parseXml(roopNode));

		//std::string value = node->FirstChildElement()->GetText();

		roopNode = roopNode->NextSibling("eventFunction");
	}

	TiXmlNode* fucntionJointNode = XNp_xpath_node(node,"./jointFunctionEvent");

	jointEvent = feF.parseXml(fucntionJointNode);

	functionEvents_ = 
		boost::shared_ptr<FunctionEvents>(new FunctionEvents(eventFunctionMs,jointEvent));

}

void FunctionEventsFactory::build()
{

}

}
