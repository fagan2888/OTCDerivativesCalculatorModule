#include <xmlFactory/Factory/instrument/structuredProduct/payoffMFactory.hpp>

using namespace QuantLib;
using namespace TinyXPath;

namespace XmlFactory {

PayoffMFactory::PayoffMFactory()
: IndexTransMFactory_(IndexTransMFactory()) {}

boost::shared_ptr<PayoffBase> 
PayoffMFactory::getPayoff(TiXmlNode* xmlNode){
	
	if(!(node->Attribute("symID")))
	{
		EventSymbolManager::instance().setSymbol(node->Attribute("symID")));
	}

	if(payoffType=="averPayoff"){ptr = boost::shared_ptr<Factory::IPayoff>(new Factory::AverPayoff(xmlNode));}
	  else if(payoffType=="constPayoff"){ptr = boost::shared_ptr<Factory::IPayoff>(new Factory::ConstPayoff(xmlNode));}
	  else if(payoffType=="exprPayoff"){ptr = boost::shared_ptr<Factory::IPayoff>(new ExprPayoff(xmlNode));}
	  else if(payoffType=="preFixPayoff"){ptr = boost::shared_ptr<Factory::IPayoff>(new PreFixPayoff(xmlNode));}
	  else{ptr = boost::shared_ptr<Factory::IPayoff>(new NullPayoff(xmlNode));}

	return ptr->getPayoff();

	}
	

//---------------------------------------------------------------------------
//						각각의 payoff Factory
//---------------------------------------------------------------------------
	namespace Factory {

	AverPayoff::AverPayoff(TiXmlNode* xmlNode)
	{
		
	}

	ConstPayoff::ConstPayoff(TiXmlNode* xmlNode)
	{
		std::string symbol = node->Attribute("symID");

		if(!(node->Attribute("symID")))
		{
			EventSymbolManager::instance().setSymbol(node->Attribute("symID")));
		}

		TiXmlNode* dateNode = xmlNode->FirstChild("payoffDate");
		DateFactory df = DateFactory();
		df.parseXml(dateNode);
		std::string value = xmlNode->FirstChildElement("constant")->GetText();
		
		// string to double 변환 필요.

		thisPayoff_ = boost::shared_ptr<PayoffBase>(
						      new XmlTest::ConstPayoff(symbol,df.getDate(),value));

	}




	}

}