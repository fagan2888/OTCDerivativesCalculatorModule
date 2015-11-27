#include <xmlFactory/Factory/instrument/structuredProduct/eventCheckFactory.hpp>

namespace XmlFactory {

	EventCheckFactory::EventCheckFactory(){}

	void EventCheckFactory::parseXml(TiXmlNode* node)
	{
	
		if(!(node->Attribute("symID")))
		{
			EventSymbolManager::instance().setSymbol(node->Attribute("symID")));
		}

		//eventDate가 event내에 전체에 쓰일수 있으므로 가장 먼저 세팅함.
		//dateManager로 들어갈 예정
		TiXmlNode* eventDateNode = XNp_xpath_node(node,"./eventDate");
		eventDate_ = boost::shared_ptr<DateFacotry>(
									new DateFacotry(eventDateNode));

		//parsing Code
		TiXmlNode* eventCheckIndexTransNode = XNp_xpath_node(node,"./eventIndexTransformation");
		eventCheckIndexTrans_ = boost::shared_ptr<IndexTransMFactory>(
									new IndexTransMFactory(eventCheckIndexTransNode));
		//
		TiXmlNode* fucntionEventsNode = XNp_xpath_node(node,"./functionEvents");
		functionEvents_ = boost::shared_ptr<FunctionEventsFactory>(
									new FunctionEventsFactory(fucntionEventsNode));

		TiXmlNode* payoffNode = XNp_xpath_node(node,"./payoff");
		payoff_ = boost::shared_ptr<PayoffMFactory>(
									new IndexMFactory(payoffNode));

		TiXmlNode* subJointNode = XNp_xpath_node(node,"./subJointEvent");
		subJointEvent_ = boost::shared_ptr<JointEventFactory>(
									new JointEventFactory(subJointNode));

		TiXmlNode* fsNode = XNp_xpath_node(node,"./functionAndSubJointEvent");
		functionAndSubEvent_ = boost::shared_ptr<JointEventFactory>(
									new JointEventFactory(fsNode));

		TiXmlNode* timeNode = XNp_xpath_node(node,"./timeJointEvent");
		timeJointEvent_ = boost::shared_ptr<JointEventFactory>(
									new JointEventFactory(timeNode));




		this.build();

	}

	void EventCheckFactory::build()
	{

		eventCheck_ = boost::shared_ptr<EventCheck>(
										new EventCheck(
														));
	}
}