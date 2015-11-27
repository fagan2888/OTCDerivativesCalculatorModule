
#include "makeSwap.h"


#include <ql/testclass/standardSwap/jointEvent.hpp>
#include <ql/testclass/standardSwap/eventFunctionManager.hpp>
#include <ql/testclass/standardSwap/eventsymbolmanager.hpp>

#include <standardSwap/Factory/EventFunctionMFactory.hpp>
#include <standardSwap/Factory/indexTransMFactory.hpp>
#include <standardSwap/Factory/payoffManagerFactory.hpp>

using namespace TinyXPath;
using namespace QuantLib;

namespace XmlTest {

	
		//TiXmlDocument doc(pFilename);
		//if (!doc.LoadFile()) return;
		//
		//

		//TiXmlHandle hDoc(&doc);
		//TiXmlElement* pElem;
		//TiXmlHandle hRoot(0);
		//
		//TiXmlElement* Root = doc.RootElement();


void XmlStandardSwap::initialize(const char* pFilename){
	
	//std::string filename = "testSwap.xml";

	TiXmlDocument doc(pFilename);
	doc.LoadFile();
	TiXmlElement* Root = doc.RootElement();

	xpath_processor xp(Root,"/");
	//std::vector< boost::shared_ptr<EventCheck> > eventChecks; // 요기 안에는 subEvent가 또 없음.
	std::vector< boost::shared_ptr<EventCheck> > subEventChecks; 
	//
	//boost::shared_ptr<EventFunction> mainEventFunction;
	//std::vector<boost::shared_ptr<IndexTransManager>> indexM_Events;
	//boost::shared_ptr<PayoffManager> mainPm;

	
	std::string kkk = S_xpath_string(Root,"./instrument/trade/text()");

	// issueInformation
	{
		TiXmlNode* issueinfoNode = XNp_xpath_node(Root,"/instrument/issueInformation");

		std::string productType = ConvertFunction::getElementValue(issueinfoNode,"productType");
		std::string instrumentID = ConvertFunction::getElementValue(issueinfoNode,"instrumentID");
		std::string notionalAmount = ConvertFunction::getElementValue(issueinfoNode,"notionalAmount");
		std::string issueDate = ConvertFunction::getElementValue(issueinfoNode,"issueDate");
		std::string maturityDate = ConvertFunction::getElementValue(issueinfoNode,"maturityDate");
	}

	// paySide\baseInformation
	{
		TiXmlNode* paySideNode = XNp_xpath_node(Root,"/instrument/paySide");
		{
			TiXmlNode* baseInformationNode = XNp_xpath_node(paySideNode,"./baseInformation");
			{
				TiXmlNode* baseIndexNode = baseInformationNode->FirstChild("baseIndex");
					std::vector<std::string> indexes = ConvertFunction::getElementValues(baseIndexNode,"Index");
			}
			{
				TiXmlNode* infoNode = baseInformationNode->FirstChild("information");
					std::string businessDay = ConvertFunction::getElementValue(infoNode,"businessDay");
					std::string businessDayConvenction = ConvertFunction::getElementValue(infoNode,"businessDayConvenction");
					std::string daycounter = ConvertFunction::getElementValue(infoNode,"daycounter");
					std::string currency = ConvertFunction::getElementValue(infoNode,"currency");
					std::string imbededOption = ConvertFunction::getElementValue(infoNode,"imbededOption");
					std::string inarrear = ConvertFunction::getElementValue(infoNode,"inarrear");
			}

			TiXmlNode* payScheduleNode = XNp_xpath_node(paySideNode,"./payoffSchedule");

			{
				TiXmlNode* eventCheckNode = XNp_xpath_node(payScheduleNode,"./eventCheck");;

				for(TiXmlNode* node = eventCheckNode ; node ; )
				{
					std::string value = node->FirstChildElement()->GetText();

					//subEventChecks.push_back(this->getEventChecks(xn2,this->baseIndex()));

						eventChecks_.push_back(this->getEventChecks(node,this->baseIndex()));
					

					node = node->NextSibling("eventCheck");

					// eventCheck 만드는 함수로 ㄱㄱ makeEventCheck(symbol,indexTrans,eventFunction,eventDate,subEventCheck)

				}
			}
		}
	}
	this->setConstVar(Root);

}

std::vector<std::string> XmlStandardSwap::baseIndex(){
	std::vector<std::string> thisbaseIndex;
	//thisbaseIndex.push_back("KOSPI200_Last");
	//thisbaseIndex.push_back("CD91");
	thisbaseIndex.push_back("S1");
	thisbaseIndex.push_back("S2");
	return thisbaseIndex; 
}

void XmlStandardSwap::setConstVar(TiXmlNode* xmlNode){
	
	//eventChecks 가 계산되었는지 확인.

	constVar_.push_back(std::pair<std::string , double >("Notional",100000));
	constVar_.push_back(std::pair<std::string , double >("initialS1",1665.25));
	constVar_.push_back(std::pair<std::string , double >("initialS2",115.01));

	
	//pay랑 receive랑 양분.
	for(Size i=0;i<eventChecks_.size();++i){
		for(Size j=0;j<constVar_.size();++j){	
			eventChecks_[i]->defineConst(constVar_[j].first,constVar_[j].second);
		}
	}


	//switch (payReceive) {
	//	case 0 : //Pay
	//		for(Size i=0;i<eventChecksPay_.size();++i){
	//			for(Size j=0;j<constVar.size();++j){
	//				eventChecksPay_[i]->defineConst(constVar[j].first,constVar[j].second);
	//			}
	//		}
	//		
	//		break;
	//	case 1 : //Receive
	//		for(Size i=0;i<eventChecksReceive_.size();++i){
	//			for(Size j=0;j<constVar.size();++j){
	//				eventChecksReceive_[i]->defineConst(constVar[j].first,constVar[j].second);
	//			}
	//		}

	//		break;
	//	
	//	case 2 : //Both
	//		for(Size i=0;i<eventChecksPay_.size();++i){
	//			for(Size j=0;j<constVar.size();++j){
	//				eventChecksPay_[i]->defineConst(constVar[j].first,constVar[j].second);
	//			}
	//		}

	//		for(Size i=0;i<eventChecksReceive_.size();++i){
	//			for(Size j=0;j<constVar.size();++j){
	//				eventChecksReceive_[i]->defineConst(constVar[j].first,constVar[j].second);
	//			}
	//		}
	//		break;
	//	default:
 //           QL_FAIL("type must pay,receive or both");


	//}


	
}


boost::shared_ptr<EventCheck> XmlStandardSwap::getEventChecks(TiXmlNode* xmlNode,const std::vector<std::string>& baseIndex){

	std::string symbol = ConvertFunction::getElementValue(xmlNode,"symbol");

	boost::shared_ptr<EventCheck> eventCheck;

	if(EventSymbolManager::instance().hasSymbol(symbol)){
		
		return EventSymbolManager::instance().getSymbol(symbol);
	}

	EventFunctionMFactory eventFunctionFactory = EventFunctionMFactory();
	IndexTransMFactory indexTransMFactory = IndexTransMFactory();
	PayoffManagerFactory payoffManagerFactory = PayoffManagerFactory();
	//std::string symbol = xnode["symbol"]->InnerText;
	
	
	std::vector<std::pair<std::string, boost::shared_ptr<IndexTransManager>>> indexM_Event;

	TiXmlNode* payScheduleNode = XNp_xpath_node(xmlNode,"./functionEvents");

	std::vector<boost::shared_ptr<EventFunctionManager>> efms = eventFunctionFactory.getEventFuncManager(payScheduleNode);
	
	TiXmlNode* jointFunctionEventTFNode = XNp_xpath_node(payScheduleNode,"./jointFunctionEventTF");
	boost::shared_ptr<JointEvent> functionJointEvent = eventFunctionFactory.getJointEventTF(jointFunctionEventTFNode);

	std::vector<Date> eventDates; 
	std::vector<Date> observationDates; // eventCheck에 속한 indexTrans에서는 daily check 때문에(평균을 위한것이 아님) eventDates를 넣고(여러개가 될수 있음 ex) KI )
										// payoff에서 속한 indexTrans를 할때에는 daily check가 없기에 하나만 들어감.. 아 헷갈려.. ㅅㅍ...ㅡ.ㅡ;
	
	TiXmlNode* datesNode = XNp_xpath_node(xmlNode,"./dateType");
	eventDates = ConvertFunction::dates(datesNode);
	bool dailyFlag =  ConvertFunction::dailyFlag(datesNode);
	
	indexM_Event = indexTransMFactory.getIndexTransMs(xmlNode);
	
	std::vector<boost::shared_ptr<IndexTransManager>> itms;

	for(Size i=0;i<indexM_Event.size();++i) {
		itms.push_back(indexM_Event[i].second);
	}

//
//	// payoffManager 만듬
//
////			xnSingle = xn2->SelectSingleNode( "./eventaggregateTF" );
//
	

	boost::shared_ptr<PayoffManager> payoffM;
	payoffM = payoffManagerFactory.getPayoffManager(xmlNode);

	TiXmlNode* payoffNode = XNp_xpath_node(xmlNode,"./payoff");
	//std::vector<std::pair<std::string,boost::shared_ptr<IndexTransManager>>> itmPayoff;
	//itmPayoff = indexTransMFactory.getIndexTransMs(payoffNode);

	//----------------------------------- subEvent -----------------------------

	std::vector< boost::shared_ptr<EventCheck> > subEventChecks;

	TiXmlNode* subEventNode = XNp_xpath_node(xmlNode , "./subEventCheck/eventCheck" );
	
	for(TiXmlNode* node = subEventNode ; node ; )
	{
		std::string value = node->FirstChildElement()->GetText();
		subEventChecks.push_back(this->getEventChecks(node,this->baseIndex()));
		node = node->NextSibling("eventCheck");
	}

	bool autoCallable =  false;

	

	TiXmlNode* jointSubEventTFNode = XNp_xpath_node(xmlNode,"./jointSubEventTF");
	boost::shared_ptr<JointEvent> subJointEvent = eventFunctionFactory.getJointEventTF(jointSubEventTFNode);

	TiXmlNode* functionAndSubEventNode = XNp_xpath_node(xmlNode,"./functionAndSubEventTF");
	boost::shared_ptr<JointEvent> functionAndSubEvent = eventFunctionFactory.getJointEventTF(functionAndSubEventNode);
			
	TiXmlNode* timeJointEventTFNode = XNp_xpath_node(xmlNode,"./timeJointEventTF");
	boost::shared_ptr<JointEvent> timeJointEvent = eventFunctionFactory.getJointEventTF(timeJointEventTFNode);


	eventCheck = boost::shared_ptr<EventCheck>(
					  	   new EventCheck(symbol,
										  baseIndex,
										  dailyFlag,
										  eventDates,
										  itms,
										  efms,
										  payoffM,
										  functionJointEvent,
										  subJointEvent,
										  functionAndSubEvent,
										  timeJointEvent,
										  autoCallable,
										  subEventChecks));

	EventSymbolManager::instance().setSymbol(symbol,eventCheck);

	return eventCheck;

}


	//std::string productType = XNp_xpath_node(issueinfoNode,"./productType")->ToText();
	


//	XmlNodeList^ xnLists = xml->SelectNodes( "/instrument" );

//	for each (XmlNode^ xn in xnLists)
//   {
//	XmlNode^ xnSingle = xn->SelectSingleNode("./issueInformation"); 

//
//	xnSingle = xn->SelectSingleNode("./paySide/baseInformation");
//	
//	
//	std::string Index = xnSingle["baseIndex"]->InnerText;
//	std::string information = xnSingle["information"]->InnerText;
//	
//	//information 을 따로 모듈화 해서 나눌건지 아니면 그냥 쓸건지

//	std::string daycounter = xnSingle["information"]["daycounter"]->InnerText;
//	std::string currency = xnSingle["information"]["currency"]->InnerText;
//	std::string imbededOption = xnSingle["information"]["imbededOption"]->InnerText;
//	std::string calendar = xnSingle["information"]["calendar"]->InnerText;
//	std::string inarrear = xnSingle["information"]["inarrear"]->InnerText;


//	XmlNodeList^ xnEventCheckLists = xn->SelectNodes("./paySide/payoffSchedule/eventCheck");

//	for each (XmlNode^ xn2 in xnEventCheckLists)
//	{
//		subEventChecks.push_back(this->getEventChecks(xn2,this->baseIndex()));

//		// eventCheck 만드는 함수로 ㄱㄱ makeEventCheck(symbol,indexTrans,eventFunction,eventDate,subEventCheck)

//	}
//}


}
//
//double XmlStandardSwap::test(){
//		// Make xml: <?xml ..><Hello>World</Hello>
//	/*TiXmlDocument doc;
//	TiXmlDeclaration * decl = new TiXmlDeclaration( "1.0", "", "" );
//	TiXmlElement * element = new TiXmlElement( "Hello" );
//	TiXmlText * text = new TiXmlText( "World" );
//	element->LinkEndChild( text );
//	doc.LinkEndChild( decl );
//	doc.LinkEndChild( element );
//	doc.SaveFile( "madeByHand.xml" );*/
//	//TiXmlDocument doc1("madeByHand.xml");
//	TiXmlDocument doc1("testSwap.xml");
//	doc1.LoadFile();
//
//	
//	return 0.0;
//}



//void XmlStandardSwap::load(const char* pFilename)
//{ 
//	TiXmlDocument doc(pFilename);
//	if (!doc.LoadFile()) return;
//	
//	
//
//	TiXmlHandle hDoc(&doc);
//	TiXmlElement* pElem;
//	TiXmlHandle hRoot(0);
//	
//	TiXmlElement* Root = doc.RootElement();
//
//	const char* m_name;
//	
//	std::string kkka = "/instrument/trade/text()";
//	//std::string kkk = S_xpath_string(&doc,"/instrument/issueInformation/instrumentID/");
//	std::string kkk = S_xpath_string(Root,kkka.c_str());
//
//	// block: name
//	{
//		pElem=hDoc.FirstChildElement().Element();
//		// should always have a valid root but handle gracefully if it does
//		if (!pElem) return;
//		m_name=pElem->Value();
//
//		// save this for later
//		hRoot=TiXmlHandle(pElem);
//
//		
//	}

	//// block: string table
	//{
	//	m_messages.clear(); // trash existing table

	//	pElem=hRoot.FirstChild( "Messages" ).FirstChild().Element();
	//	for( pElem; pElem; pElem=pElem->NextSiblingElement())
	//	{
	//		const char *pKey=pElem->Value();
	//		const char *pText=pElem->GetText();
	//		if (pKey && pText) 
	//		{
	//			m_messages[pKey]=pText;
	//		}
	//	}
	//}

	//// block: windows
	//{
	//	m_windows.clear(); // trash existing list

	//	TiXmlElement* pWindowNode=hRoot.FirstChild( "Windows" ).FirstChild().Element();
	//	for( pWindowNode; pWindowNode; pWindowNode=pWindowNode->NextSiblingElement())
	//	{
	//		WindowSettings w;
	//		const char *pName=pWindowNode->Attribute("name");
	//		if (pName) w.name=pName;
	//		
	//		pWindowNode->QueryIntAttribute("x", &w.x); // If this fails, original value is left as-is
	//		pWindowNode->QueryIntAttribute("y", &w.y);
	//		pWindowNode->QueryIntAttribute("w", &w.w);
	//		pWindowNode->QueryIntAttribute("hh", &w.h);

	//		m_windows.push_back(w);
	//	}
	//}

	//// block: connection
	//{
	//	pElem=hRoot.FirstChild("Connection").Element();
	//	if (pElem)
	//	{
	//		m_connection.ip=pElem->Attribute("ip");
	//		pElem->QueryDoubleAttribute("timeout",&m_connection.timeout);
	//	}
	//}



