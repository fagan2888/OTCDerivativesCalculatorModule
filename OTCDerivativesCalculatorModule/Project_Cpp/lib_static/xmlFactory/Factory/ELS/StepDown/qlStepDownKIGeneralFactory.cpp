//#include "qlStepDownKIGeneralFactory.hpp"
//#include <util\convertFunction.hpp>
//#include <ql\time\calendars\all.hpp>
//#include <factory\Etc\qlYieldTermStructureFactory.hpp>
//#include <boost/lexical_cast.hpp>
//
//#include <Factory\Etc\all.hpp>
//
//#include <src/Engine/MonteCarlo/MonteEngine.hpp>
//#include <src/Engine/MonteCarlo/pricer/stepDownKIEventPricer.hpp>
//#include <src/Engine/MonteCarlo/pricer/event/constBarriereventTriggerInfo.hpp>
//#include <src/Engine/MonteCarlo/pricer/event/autoCallConstReturneventTriggerInfo.hpp>
//#include <src/Engine/MonteCarlo/pricer/event/constPayoffEventTriggerInfo.hpp>
//
//using namespace QuantLib;
//using namespace ConvertFunction;
//
//namespace XmlFactory {
//
//qlStepDownKIGeneralFactory::qlStepDownKIGeneralFactory()
//{
//}
//
//void qlStepDownKIGeneralFactory::calculate(const std::string& instInfoStr,
//									const std::string& paraInfoStr)
//{
//	this->instInfo_ = instInfoStr;
//	this->paraInfo_ = paraInfoStr;
//
//	this->factoryStepDownKI();
//
//	value_ = inst_->NPV();
//	//std::cout << value << std::endl;
//	//this->buildResultXml(inst_->additionalResults());
//	
//}
//
//boost::shared_ptr<PricingEngine> qlStepDownKIGeneralFactory::engine(boost::shared_ptr<FpmlSerialized::PayoffInfo> xml_payoff)
//{
//	TiXmlDocument document;
//	document.Parse(paraInfo_.c_str(), 0, TIXML_ENCODING_UTF8);
//
//	TiXmlNode* pricingNode = document.FirstChildElement("pricing");
//	FpmlSerialized::Pricing xml_pricing = FpmlSerialized::Pricing(pricingNode);
//
//	Date referenceDate = xml_pricing.getEvaluationTime()->dateValue();
//	Settings::instance().evaluationDate() = referenceDate ;
//
//	boost::shared_ptr<FpmlSerialized::PricingParameter> xml_pricingPara = xml_pricing.getPricingParameter();
//	boost::shared_ptr<FpmlSerialized::Method> xml_method = xml_pricingPara->getMethod();
//	boost::shared_ptr<FpmlSerialized::Monte> xml_monte = xml_method->getMonte();
//
//	boost::shared_ptr<FpmlSerialized::Standard_para> xml_standardPara = xml_pricingPara->getStandard_para();
//
//	Size simulNum = xml_monte->getSimulationNum()->IValue();
//
//	boost::shared_ptr<FpmlSerialized::UnderlyingInfo_para> xml_underyingInfopara = xml_standardPara->getUnderlyingInfo_para();
//
//	qlProcessFactory process_factory = qlProcessFactory();
//	process_factory.setProcessCode(this->underListCode_);
//	process_factory.makeProcess(xml_underyingInfopara);
//
//	boost::shared_ptr<StochasticProcessArray> gbmProcess 
//		= process_factory.getProcessArr();
//
//	qlYieldTermStructureFactory factory = qlYieldTermStructureFactory();
//
//	//Handle<YieldTermStructure> yieldCurve = factory.yieldTSHandle(pricingParameterNode);
//	//boost::shared_ptr<YieldTermStructure> yieldTS = boost::shared_ptr<YieldTermStructure>(
//	//				new FlatForward(referenceDate,discount,Actual365Fixed()));
//	boost::shared_ptr<FpmlSerialized::DiscountCurve_para> xml_discount = xml_standardPara->getDiscountCurve_para();
//
//	boost::shared_ptr<YieldTermStructure> yieldTS = factory.yieldTSBoost(xml_discount->getYieldTermstructure());
//	
//	this->discountCurve_ = yieldTS;
//
//	Handle<YieldTermStructure> yieldCurve = Handle<YieldTermStructure>(yieldTS);
//		
//	this->pricer(xml_payoff);
//
//	boost::shared_ptr<PricingEngine> monteEngine(
//								new MonteEngine(pricer_,
//												gbmProcess,
//												yieldTS,
//												simulNum,//simulNum
//												1));
//
//
//	return monteEngine;
//}
//
//boost::shared_ptr<EventTriggerInfo> qlStepDownKIGeneralFactory::kiEventInfo(const boost::shared_ptr<FpmlSerialized::KiEventInfo>& xml_kiEventInfo)
//{
//	boost::shared_ptr<EventTriggerInfo> kiEventTriggerInfo;
//	
//	boost::shared_ptr<FpmlSerialized::ConstKiTrigger> xml_constKITrriger = xml_kiEventInfo->getConstKiTrigger();
//
//	std::vector<double> kiTriggers; // = kiTrigger(elsNode);
//
//	bool pastKI = xml_constKITrriger->getPastKI()->BValue();
//
//	Date eventDate = xml_kiEventInfo->getEventDate()->dateValue();
//	Date payoffDate = xml_kiEventInfo->getPayoffDate()->dateValue();
//
//	for ( Size i = 0 ; i< xml_constKITrriger->getValue().size() ; ++i)
//	{
//		double kiValue = xml_constKITrriger->getValue()[0]->DValue();
//
//		kiTriggers.push_back( kiValue * this->basePrices_[i]);
//	}
//
//	kiEventTriggerInfo = boost::shared_ptr<ConstBarrierEventTriggerInfo>(new ConstBarrierEventTriggerInfo(eventDate,payoffDate,basePrices_,kiTriggers, pastKI));
//
//	return kiEventTriggerInfo;
//}
//
//boost::shared_ptr<EventTriggerInfo> qlStepDownKIGeneralFactory::nonkiEventInfo(const boost::shared_ptr<FpmlSerialized::NonKiEventInfo>& xml_nonkiEventInfo)
//{
//	boost::shared_ptr<EventTriggerInfo> nonkiEventTriggerInfo;
//	
//	double constReturn = xml_nonkiEventInfo->getConstNonKiTrigger()->getReturn()->DValue();
//
//	Date eventDate = xml_nonkiEventInfo->getEventDate()->dateValue();
//	Date payoffDate = xml_nonkiEventInfo->getPayoffDate()->dateValue();
//
//	nonkiEventTriggerInfo = boost::shared_ptr<EventTriggerInfo>(new ConstPayoffEventTriggerInfo(eventDate,payoffDate,constReturn));
//
//	return nonkiEventTriggerInfo;
//}
//
//std::vector<boost::shared_ptr<EventTriggerInfo>> qlStepDownKIGeneralFactory::redemInfo(const boost::shared_ptr<FpmlSerialized::RedemptionInfo>& xml_redemEventInfo)
//{
//	
//	boost::shared_ptr<FpmlSerialized::AutoCallRedem> xml_autoCallRedem = xml_redemEventInfo->getAutoCallRedem();
//
//	std::vector<boost::shared_ptr<FpmlSerialized::EventTrigger>> xml_eventTriggerList = xml_autoCallRedem->getEventTrigger();
//
//	std::vector<boost::shared_ptr<EventTriggerInfo>> eventTriggerList;
//		
//	for(Size i = 0 ; i<xml_eventTriggerList.size(); ++i )
//	{
//		const boost::shared_ptr<FpmlSerialized::AutoCallConstReturnTrigger>& xml_autoCallConstReturnTri 
//			= xml_eventTriggerList[i]->getAutoCallConstReturnTrigger();
//
//		Date eventDate = xml_autoCallConstReturnTri->getDate()->dateValue();
//		Date payoffDate = eventDate ;
//		Real trigger = xml_autoCallConstReturnTri->getTrigger()->DValue();
//		Real constReturn = xml_autoCallConstReturnTri->getReturn()->DValue();
//		bool isExpired = xml_autoCallConstReturnTri->getIsExpired()->BValue();
//
//		boost::shared_ptr<EventTriggerInfo> eventTriggerInfo 
//				= boost::shared_ptr<EventTriggerInfo>(
//				new AutoCallConstReturnEventTriggerInfo(eventDate,
//														payoffDate,
//														constReturn,
//														this->basePrices_,
//														trigger,
//														isExpired));
//
//		eventTriggerList.push_back(eventTriggerInfo);
//	}
//
//	return eventTriggerList;
//
//}
//
//void qlStepDownKIGeneralFactory::pricer(boost::shared_ptr<FpmlSerialized::PayoffInfo> xml_payoffInfo)
//{
//	boost::shared_ptr<FpmlSerialized::StepDownKIPayoff> xml_stepDownKI = xml_payoffInfo->getStepDownKIPayoff();
//
//	boost::shared_ptr<FpmlSerialized::RedemptionInfo> xml_redemInfo = xml_stepDownKI->getRedemptionInfo();
//	boost::shared_ptr<FpmlSerialized::KiEventInfo> xml_kiInfo = xml_stepDownKI->getKiEventInfo();
//	boost::shared_ptr<FpmlSerialized::NonKiEventInfo> xml_nonkiInfo = xml_stepDownKI->getNonKiEventInfo();
//
//	std::vector<boost::shared_ptr<EventTriggerInfo>> eventTriggerList = this->redemInfo(xml_redemInfo);
//	boost::shared_ptr<EventTriggerInfo> kiInfo = this->kiEventInfo(xml_kiInfo);
//	boost::shared_ptr<EventTriggerInfo> nonkiInfo = this->nonkiEventInfo(xml_nonkiInfo);
//
//	boost::shared_ptr<FpmlSerialized::ConstKiTrigger> xml_constKITrriger = xml_stepDownKI->getKiEventInfo()->getConstKiTrigger();
//
//	this->pricer_ = boost::shared_ptr<StepDownKIEventPricer>(
//			new StepDownKIEventPricer(eventTriggerList,kiInfo,nonkiInfo,discountCurve_));
//
//}
//
//void qlStepDownKIGeneralFactory::factoryStepDownKI()
//{
//	//TiXmlText* rootNode = new TiXmlText(instInfo_.c_str());
//	TiXmlDocument document;
//	document.Parse(instInfo_.c_str(), 0, TIXML_ENCODING_UTF8);
//
//	//rootNode.SetValue;
//
//	TiXmlNode* instNode = document.FirstChild("instrument");
//
//	FpmlSerialized::Instrument xml_instrument = FpmlSerialized::Instrument(instNode);
//	boost::shared_ptr<FpmlSerialized::InstPositionInfo> xml_positionInfo = xml_instrument.getInstPositionInfo();
//	this->krCode_ = xml_positionInfo->getKrCode()->SValue();
//
//	boost::shared_ptr<FpmlSerialized::InstrumentInfo> xml_instrumentInfo = xml_instrument.getInstrumentInfo();
//
//	boost::shared_ptr<FpmlSerialized::StandardInstrument> xml_standardInst = xml_instrumentInfo->getStandardInstrument();
//
//	DayCounter daycounter = Actual365Fixed();
//	Calendar calendar = SouthKorea(); // ?
//
//	boost::shared_ptr<FpmlSerialized::IssueInformation> xml_issueInfo = xml_standardInst->getIssueInformation();
//	boost::shared_ptr<FpmlSerialized::NoteInfo> xml_noteInfo = xml_issueInfo->getNoteInfo();
//
//	//Date tradeDate = xml_noteInfo->getTradeDate()->dateValue();
//	Date effectiveDate = xml_noteInfo->getEffectiveDate()->dateValue();
//	Date maturityDate = xml_noteInfo->getMaturityDate()->dateValue();
//	notional_ = xml_noteInfo->getNotional()->DValue();
//
//	//Size premium = strToSize(infoNode->FirstChildElement("premium")->GetText());
//
//	boost::shared_ptr<FpmlSerialized::UnderlyingInformation> xml_underlyingInfo = xml_standardInst->getUnderlyingInformation();
//
//	boost::shared_ptr<FpmlSerialized::IndexUnderInfo> xml_indexUnderInfo =  xml_underlyingInfo->getIndexUnderInfo();
//
//	std::vector<boost::shared_ptr<FpmlSerialized::Index>> xml_indexList = xml_indexUnderInfo->getIndex();
//
//	for(Size i=0 ; i < xml_indexList.size() ; ++i)
//	{
//		double value = 0.0;
//		value = xml_indexList[i]->getStockIndex()->getBasePrice()->DValue();
//		underListCode_.push_back(xml_indexList[i]->getStockIndex()->getKrCode()->SValue());
//		basePrices_.push_back(value);
//	}
//
//	inst_ = boost::shared_ptr<NoteInst>( new NoteInst(10000.0,
//													effectiveDate,
//													maturityDate,
//													daycounter,
//													calendar));
//
//	
//	// --------------------------------- Payoff ---------------------------------------------
//
//	boost::shared_ptr<FpmlSerialized::PayoffInfo> xml_payoff = xml_standardInst->getPayoffInfo();
//
//	boost::shared_ptr<PricingEngine> elsEngine = engine(xml_payoff);
//
//
//
//	//std::cout << "Start" << std::endl;
//	inst_->setPricingEngine(elsEngine);
//	//std::cout << "Eu price                    : " << els100.NPV() << std::endl;
//
//	//std::cout << "Calculation End" << std::endl;
//}
//
//void qlStepDownKIGeneralFactory::buildResultXml(std::map<std::string,boost::any> addedResult)
//{
//
//	std::vector<double> _delta = boost::any_cast<std::vector<double>>(addedResult.find("Delta")->second);
//	std::vector<double> _gamma = boost::any_cast<std::vector<double>>(addedResult.find("Gamma")->second);
//	std::vector<double> _vega = boost::any_cast<std::vector<double>>(addedResult.find("Vega")->second);
//	std::vector<double> _sup = boost::any_cast<std::vector<double>>(addedResult.find("Sup")->second);
//	std::vector<double> _sdown = boost::any_cast<std::vector<double>>(addedResult.find("SDown")->second);
//	std::vector<double> _volup = boost::any_cast<std::vector<double>>(addedResult.find("VolUp")->second);
//	std::vector<double> _voldown = boost::any_cast<std::vector<double>>(addedResult.find("VolDown")->second);
//
//	std::vector<double> _step_h = boost::any_cast<std::vector<double>>(addedResult.find("step_h")->second);
//
//	std::vector<double> _underlyingValue = boost::any_cast<std::vector<double>>(addedResult.find("underlyingValue")->second);
//	std::vector<double> _earlyExProbability = boost::any_cast<std::vector<double>>(addedResult.find("earlyExProbability")->second);
//	std::vector<double> _initialValues = boost::any_cast<std::vector<double>>(addedResult.find("initialValues")->second);
//	std::vector<double> _expectedRedem = boost::any_cast<std::vector<double>>(addedResult.find("expectedRedem")->second);
//
//	TiXmlDocument doc;  
//	//TiXmlElement* msg;
// //	TiXmlDeclaration* decl = new TiXmlDeclaration( "1.0", "", "" );  
//	//doc.LinkEndChild( decl );  
// 
//	TiXmlElement * pricingResultNode = new TiXmlElement( "pricingResult" );  
//	doc.LinkEndChild( pricingResultNode );  
//
//	//TiXmlComment * comment = new TiXmlComment();
//	//comment->SetValue(" Settings for MyApp " );  
//	//root->LinkEndChild( comment );  
// 
//		TiXmlElement * priceNode = new TiXmlElement( "price" );  
//		priceNode->LinkEndChild( new TiXmlText(  boost::lexical_cast<std::string>( static_cast<long>(notional_ * value_ / 10000) ) ) );  
//		this->price_ = static_cast<long>(notional_ * value_ / 10000);
//		pricingResultNode->LinkEndChild( priceNode );  
// 
//		TiXmlElement * unitPriceNode = new TiXmlElement( "unitPrice" );  
//		unitPriceNode->SetAttribute("unit", 10000 );
//		unitPriceNode->LinkEndChild( new TiXmlText( ConvertFunction::doubleToStr(value_) ));  
//		pricingResultNode->LinkEndChild( unitPriceNode );  
// 
//		TiXmlElement * greekNode = new TiXmlElement( "greek" );  
//
//			for ( Size i=0 ;i < _underlyingValue.size() ;++i)
//			{
//				TiXmlElement * underNode = new TiXmlElement("underlying");
//
//					TiXmlElement * deltaNode = new TiXmlElement("delta");
//						TiXmlElement * deltaValueNode = new TiXmlElement("value");
//							deltaValueNode->LinkEndChild( new TiXmlText( ConvertFunction::doubleToStr( _delta[i]) ) );
//						deltaNode->LinkEndChild(deltaValueNode);
//					underNode->LinkEndChild(deltaNode);
//
//					TiXmlElement * gammaNode = new TiXmlElement("gamma");
//						TiXmlElement * gammaValueNode = new TiXmlElement("value");
//							gammaValueNode->LinkEndChild( new TiXmlText( ConvertFunction::doubleToStr( _gamma[i]) ) );
//						gammaNode->LinkEndChild(gammaValueNode);
//					underNode->LinkEndChild(gammaNode);
//
//					TiXmlElement * vegaNode = new TiXmlElement("vega");
//						TiXmlElement * vegaValueNode = new TiXmlElement("value");
//							vegaValueNode->LinkEndChild( new TiXmlText(  ConvertFunction::doubleToStr( _vega[i]) ) );
//						vegaNode->LinkEndChild(vegaValueNode);
//					underNode->LinkEndChild(vegaNode);
//
//				greekNode->LinkEndChild(underNode);
//			}
//
//			TiXmlElement * thetaNode = new TiXmlElement("theta");
//				TiXmlElement * thetaValueNode = new TiXmlElement("value");
//					thetaValueNode->LinkEndChild( new TiXmlText( "100" ) );
//				thetaNode->LinkEndChild(thetaValueNode);
//			greekNode->LinkEndChild(thetaNode);
//
//		pricingResultNode->LinkEndChild( greekNode );
//	
//		this->result_ = operator<<( this->result_ , *pricingResultNode);
// 
//	//std::cout << "_delta" << " : " << "_gamma" << " : " << "_vega" << std::endl;
//	//
//
//	//for(Size i=0;i<_delta.size();++i){
//	//	std::cout << _delta[i] << " : " << _gamma[i] << " : " << _vega[i] << std::endl;
//	//}
//
//	//std::cout << "_sup" << " : " << "_sdown" << " : " << "_step_h" << std::endl;
//
//	//for(Size i=0;i<_delta.size();++i){
//	//	std::cout << _sup[i] << " : " << _sdown[i] << " : " << _step_h[i] << std::endl;
//	//}
//
//	//std::cout << "_volup" << " : " << "_voldown" << std::endl;
//
//	//for(Size i=0;i<_delta.size();++i){
//	//	std::cout << _volup[i] << " : " << _voldown[i] << std::endl;
//	//}
//	 
//	//result ¾²±â
//}
//
//}