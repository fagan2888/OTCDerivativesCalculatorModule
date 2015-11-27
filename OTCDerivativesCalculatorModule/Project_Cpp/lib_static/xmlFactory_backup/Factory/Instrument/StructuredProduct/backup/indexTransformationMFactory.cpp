#include <xmlFactory/Factory/Instrument/StructuredProduct/indexTransformationMFactory.hpp>

using namespace QuantLib;
using namespace TinyXPath;

namespace XmlFactory {

//payoff�� ���� indexTrans�� daily�� �����ؼ� ��������� �����Ƿ�  observationDates�� payoffDate �ϳ��� �������.
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