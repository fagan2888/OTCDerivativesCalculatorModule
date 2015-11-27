#include <xmlFactory/Factory/Instrument/StructuredProduct/indexTransformationMFactory.hpp>

using namespace QuantLib;
using namespace TinyXPath;

namespace XmlFactory {

//payoff에 들어가는 indexTrans는 daily로 연속해서 사용할일이 없으므로  observationDates에 payoffDate 하나만 들어오면됨.
boost::shared_ptr<IndexTransformationMFactory>
IndexTransformationMFactory::parseXml(TiXmlNode* xmlNode){
	
	std::vector<boost::shared_ptr<IndexTransBase> > itms;
	
	if(xmlNode != 0) {
		TiXmlNode* indexTransNode = xmlNode->FirstChild();

		for(TiXmlNode* node = indexTransNode ; node ;){

			std::string symbol = ConvertFunction::getElementValue(node,"symbol");
			std::string expr = ConvertFunction::getElementValue(node,"expr");
			
			itms.push_back(std::make_pair(symbol,boost::shared_ptr<IndexTransManager>(
									new IndexTransManager(symbol,
														  averDates))));

			addedSymbols.push_back(symbol);

			node = node->NextSibling("indexTrans");

		}
	}

	return itms;

}

}