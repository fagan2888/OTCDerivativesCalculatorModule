#include <xmlFactory/Factory/Instrument/StructuredProduct/indexTransMFactory.hpp>

using namespace QuantLib;
using namespace TinyXPath;

namespace XmlFactory {

//payoff�� ���� indexTrans�� daily�� �����ؼ� ��������� �����Ƿ�  observationDates�� payoffDate �ϳ��� �������.
std::vector<std::pair<std::string,boost::shared_ptr<IndexTransManager>>>
IndexTransMFactory::getIndexTransMs(TiXmlNode* xmlNode){
	
	std::vector< std::pair<std::string,boost::shared_ptr<IndexTransManager>> > itms;
	
	if(xmlNode != 0) {
		TiXmlNode* indexTransNode = XNp_xpath_node(xmlNode,"./indexTrans");

		//XmlNodeList^ xn_IndexTranList = xnode->SelectNodes( "./indexTrans" );
		
		//observationDates �� payoffDate�� �ϳ� ������..
		//
		//payoff���� �����;߰���.. �̰� eventCheck���鶧 �����ؼ� �־�������. daily�� �����°Ŷ� �����ؼ���..

		//observationDates size�� �׻� 1.

		bool averageFlag=false;
		bool AbsRelFlag=false;

		TiXmlNode* eventDatesNode = XNp_xpath_node(xmlNode, "./dateType" );
		Date observationDate = ConvertFunction::dates(eventDatesNode).back();

		TiXmlNode* indexTransAverNode = XNp_xpath_node(xmlNode, "./indexTrans/average" );

		std::vector<Date> averDates;
		std::vector<std::string> addedSymbols;

		averDates = ConvertFunction::dates(indexTransAverNode); // date�� �ΰ�������. �˻� �ڵ� �־����.

		for(TiXmlNode* node = indexTransNode ; node ;){

			std::string symbol = ConvertFunction::getElementValue(node,"symbol");
			std::string expr = ConvertFunction::getElementValue(node,"expr");
			
			itms.push_back(std::make_pair(symbol,boost::shared_ptr<IndexTransManager>(
									new IndexTransManager(symbol,
														  addedSymbols,
														  expr,
														  AbsRelFlag,
														  observationDate,
														  averageFlag,
														  averDates))));

			addedSymbols.push_back(symbol);

			node = node->NextSibling("indexTrans");

		}
	}

	return itms;

}

}