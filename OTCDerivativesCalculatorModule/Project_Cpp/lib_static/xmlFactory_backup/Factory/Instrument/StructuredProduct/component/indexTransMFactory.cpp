#include <xmlFactory/Factory/Instrument/StructuredProduct/indexTransMFactory.hpp>

using namespace QuantLib;
using namespace TinyXPath;

namespace XmlFactory {

//payoff에 들어가는 indexTrans는 daily로 연속해서 사용할일이 없으므로  observationDates에 payoffDate 하나만 들어오면됨.
std::vector<std::pair<std::string,boost::shared_ptr<IndexTransManager>>>
IndexTransMFactory::getIndexTransMs(TiXmlNode* xmlNode){
	
	std::vector< std::pair<std::string,boost::shared_ptr<IndexTransManager>> > itms;
	
	if(xmlNode != 0) {
		TiXmlNode* indexTransNode = XNp_xpath_node(xmlNode,"./indexTrans");

		//XmlNodeList^ xn_IndexTranList = xnode->SelectNodes( "./indexTrans" );
		
		//observationDates 에 payoffDate에 하나 들어가야함..
		//
		//payoff에서 가져와야겠지.. 이건 eventCheck만들때 구분해서 넣어져서옴. daily로 들어오는거랑 구분해서리..

		//observationDates size는 항상 1.

		bool averageFlag=false;
		bool AbsRelFlag=false;

		TiXmlNode* eventDatesNode = XNp_xpath_node(xmlNode, "./dateType" );
		Date observationDate = ConvertFunction::dates(eventDatesNode).back();

		TiXmlNode* indexTransAverNode = XNp_xpath_node(xmlNode, "./indexTrans/average" );

		std::vector<Date> averDates;
		std::vector<std::string> addedSymbols;

		averDates = ConvertFunction::dates(indexTransAverNode); // date가 두개여야함. 검사 코드 넣어야함.

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