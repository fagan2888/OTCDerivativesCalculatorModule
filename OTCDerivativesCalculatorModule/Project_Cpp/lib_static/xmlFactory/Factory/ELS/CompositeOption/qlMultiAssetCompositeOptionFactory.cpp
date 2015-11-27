#include "qlMultiAssetCompositeOptionFactory.hpp"
#include <util\convertFunction.hpp>
#include <ql\time\calendars\all.hpp>
#include <factory\Etc\qlYieldTermStructureFactory.hpp>
#include <boost/lexical_cast.hpp>
#include <GenClass\RiskMonitor-0-1\all.hpp>
#include <Factory\Etc\all.hpp>

#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>
#include <src/Engine/MonteCarlo/pricer/all.hpp>
#include <src/Engine/MonteCarlo/MonteEngine.hpp>

using namespace QuantLib;
using namespace ConvertFunction;

namespace XmlFactory {

qlMultiAssetCompositeOptionFactory::qlMultiAssetCompositeOptionFactory()
{
}

void qlMultiAssetCompositeOptionFactory::calculate()
{
	this->factoryMultiAssetCompositeOption();
	
	//this->engine_->calculate();
	value_ = this->instrument_->NPV();
	//std::cout << value_ << std::endl;
	//this->buildResultXml(inst_->additionalResults());
	//
}


void qlMultiAssetCompositeOptionFactory::calculate(const std::string& instInfoStr,
								const std::string& paraInfoStr)
{
	this->instInfo_ = instInfoStr;
	this->paraInfo_ = paraInfoStr;

	this->factoryMultiAssetCompositeOption();
	
	//this->engine_->;
	//value_ = inst_->NPV();
	//std::cout << value_ << std::endl;
	//this->buildResultXml(inst_->additionalResults());
	//
}

boost::shared_ptr<MonteEngine> qlMultiAssetCompositeOptionFactory::engine()
{
	TiXmlDocument document;
	document.Parse(paraInfo_.c_str(), 0, TIXML_ENCODING_UTF8);

	TiXmlNode* pricingNode = document.FirstChildElement("pricing");
	FpmlSerialized::Pricing xml_pricing = FpmlSerialized::Pricing(pricingNode);

	Date referenceDate = xml_pricing.getEvaluationTime()->dateValue();
	Settings::instance().evaluationDate() = referenceDate ;

	boost::shared_ptr<FpmlSerialized::Excel_parameter> xml_para = xml_pricing.getExcel_parameter();

	boost::shared_ptr<FpmlSerialized::Excel_standardPara> xml_standard_para = xml_para->getExcel_standardPara();
	
	boost::shared_ptr<FpmlSerialized::Excel_underlyingCalcInfo_para> xml_excelUnderyingCalcInfo_para = xml_standard_para->getExcel_underlyingCalcInfo_para();

	qlProcessFactory process_factory = qlProcessFactory();
	
	//process_factory.setProcessCode(this->underListCode_);
	process_factory.buildProcess(xml_excelUnderyingCalcInfo_para);

	const boost::shared_ptr<ProcessArrayWrapper>& prrArrWrapper
		= process_factory.getProcessArrWrapper();

	qlYieldTermStructureFactory ql_tysf = qlYieldTermStructureFactory();

	//Handle<YieldTermStructure> yieldCurve = factory.yieldTSHandle(pricingParameterNode);
	//boost::shared_ptr<YieldTermStructure> yieldTS = boost::shared_ptr<YieldTermStructure>(
	//				new FlatForward(referenceDate,discount,Actual365Fixed()));

	boost::shared_ptr<FpmlSerialized::Excel_discountCurve_para> xml_discount = xml_standard_para->getExcel_discountCurve_para();

	std::vector<boost::shared_ptr<YieldTermStructure>> yieldTSList
		= ql_tysf.e_yieldTermStructureList(xml_discount);

	//Handle<YieldTermStructure> yieldCurve = Handle<YieldTermStructure>(yieldTS);
	
	boost::shared_ptr<MonteEngine> engine(
								new MonteEngine(this->pricer_,
												prrArrWrapper,
												yieldTSList[0],
												10000,//simulNum
												1));

	

	return engine;
}


void qlMultiAssetCompositeOptionFactory::factoryMultiAssetCompositeOption()
{
	//TiXmlText* rootNode = new TiXmlText(instInfo_.c_str());
	TiXmlDocument document;
	document.Parse(instInfo_.c_str(), 0, TIXML_ENCODING_UTF8);

	//rootNode.SetValue;

	TiXmlNode* instNode = document.FirstChild("instrument");
	std::string code = instNode->FirstChild("code")->ToElement()->GetText();

	FpmlSerialized::Instrument xml_instrument = FpmlSerialized::Instrument(instNode);
	//boost::shared_ptr<FpmlSerialized::InstPositionInfo> xml_positionInfo = xml_instrument.getInstPositionInfo();
	//this->krCode_ = xml_positionInfo->getKrCode()->SValue();

	boost::shared_ptr<FpmlSerialized::Excel_interface> xml_interface = xml_instrument.getExcel_interface();

	boost::shared_ptr<FpmlSerialized::Excel_multiAssetCompositeOption> xml_multiAssetCompOption = xml_interface->getExcel_multiAssetCompositeOption();

	DayCounter daycounter = Actual365Fixed();
	Calendar calendar = SouthKorea(); // ?

	boost::shared_ptr<FpmlSerialized::Excel_noteInfo> xml_noteInfo = xml_multiAssetCompOption->getExcel_issueInfo()->getExcel_noteInfo();

	//Date tradeDate = xml_noteInfo->getTradeDate()->dateValue();
	Date effectiveDate = xml_noteInfo->getEffectiveDate()->dateValue();
	Date maturityDate = xml_noteInfo->getMaturityDate()->dateValue();
	notional_ = xml_noteInfo->getNotional()->DValue();

	std::vector<boost::shared_ptr<FpmlSerialized::Excel_multiAsset_compositeOption_subtype>> xml_multiAssetCompOptionSubList = xml_multiAssetCompOption->getExcel_multiAsset_compositeOption_subtype();
	std::vector<boost::shared_ptr<QuantLib::EventTriggerInfo>> ql_etiList;

	qlEventTriggerInfoFactory qetif = qlEventTriggerInfoFactory();

	for(Size i = 0 ; i<xml_multiAssetCompOptionSubList.size(); ++i )
	{
		const boost::shared_ptr<EventTriggerInfo>& ql_eti
			= qetif.multiAssetCompOptionSubType(xml_multiAssetCompOptionSubList[i]);

		ql_etiList.push_back(ql_eti);

	}

	qlFixingDateInfoFactory ql_fdf = qlFixingDateInfoFactory();

	Real notionalPayment = xml_multiAssetCompOption->getNotionalMaturityPayment()->DValue();

	Date notionalPayment_PayoffDate = xml_multiAssetCompOption->getPayoffDate()->dateValue();

	const boost::shared_ptr<QuantLib::FixingDateInfo>& ql_fdi = ql_fdf.fixingDateInfo(notionalPayment_PayoffDate);

	/*const boost::shared_ptr<MCPricer>& pricer*/
	this->pricer_ = boost::shared_ptr<CompositeSumOptionPricer>( 
								new CompositeSumOptionPricer(notionalPayment,
															ql_fdi,
															ql_etiList));

	// --------------------------------- Engine ---------------------------------------------

	//boost::shared_ptr<FpmlSerialized::Excel_underlyingCalcInfo_para> xml_underlyingCalcInfo_para = xml_hifive->getExcel_underlyingCalcInfo();

	const boost::shared_ptr<NoteInst>& noteInst
			= boost::shared_ptr<NoteInst>(
						new NoteInst(code,notional_,
									effectiveDate,
									maturityDate,
									daycounter,
									calendar));

	this->engine_ = engine();

	noteInst->setPricingEngine(this->engine_);

	this->instrument_ = noteInst;

	//std::cout << "Start" << std::endl;
	//inst_->setPricingEngine(elsEngine);
	//std::cout << "Eu price                    : " << els100.NPV() << std::endl;

	//std::cout << "Calculation End" << std::endl;
}

}
//void qlStepDownKIFactory::buildResultXml(std::map<std::string,boost::any> addedResult)
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