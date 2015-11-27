#include <xmlFactory/Factory/Instrument/StructuredProduct/indexMFactory.hpp>

//using namespace QuantLib;
using namespace TinyXPath; 

namespace XmlFactory {

	IndexMFactory::IndexMFactory()
	{
	}
	IndexMFactory::IndexMFactory(TiXmlNode* xmlNode)
	{
		parseXml(xmlNode);
	}

	void IndexMFactory::parseXml(TiXmlNode* xmlNode)
	{

		ITBs_.clear(); //여러번 호출되는 경우 쌓이는 거 방지용. 여러번 호출될지는 잘 모르겠음.
		std::string symbol = "";

		if(!(xmlNode->Attribute("symID")))
		{
			symbol = xmlNode->Attribute("symID");
			//EventSymbolManager::instance().setSymbol(node->Attribute("symID")));
		}

		TiXmlElement* indexTranNode = xmlNode->FirstChild().Element();

		for( indexTranNode; indexTranNode; indexTranNode=indexTranNode->NextSiblingElement())
		{
			ITBs_.push_back(this->selectEachTran(indexTranNode));
		}

		itm_ = boost::shared_ptr<IndexTransManager>(new IndexTransManager(symbol,ITBs_));
	}

	void IndexMFactory::build()
	{
		
	}
	boost::shared_ptr<IndexTransManager> IndexMFactory::getIndexTransM(){
		
		return itm_;

	}
	boost::shared_ptr<IndexTransBase> selectTran(TiXmlNode* xmlNode,refDates)
	{
		return boost::shared_ptr<IndexTransBase>(Return(xmlNode).getTran());
		return boost::shared_ptr<IndexTransBase>(Average(xmlNode).getTran());
		return boost::shared_ptr<IndexTransBase>(Basket(xmlNode).getTran());
	}

}

//std::vector<std::string> IndexMFactory::getBaseIndexSymbol(TiXmlNode* xmlNode){
//
//	
//	return ConvertFunction::getElementValues(xmlNode,"Index");
//
//}

}