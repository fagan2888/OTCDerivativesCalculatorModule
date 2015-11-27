//#include "qlStepDownELSFactory.hpp"
//#include <util\convertFunction.hpp>
//#include <ql\time\calendars\all.hpp>
//#include <factory\Etc\qlYieldTermStructureFactory.hpp>
//#include <boost/lexical_cast.hpp>
//
//using namespace QuantLib;
//using namespace ConvertFunction;
//
//namespace XmlFactory {
//
//qlStepDownELSFactory::qlStepDownELSFactory(const std::string& instInfoStr,
//										   const std::string& paraInfoStr)
//: instInfo_(instInfoStr) , paraInfo_(paraInfoStr)
//{
//}
//
//void qlStepDownELSFactory::calculate()
//{
//	this->factoryStepDownKI();
//
//	value_ = inst_->NPV();
//	//std::cout << value << std::endl;
//	this->buildResultXml(inst_->additionalResults());
//	
//}
//
//std::vector<double> qlStepDownELSFactory::kiTrigger(TiXmlNode* node)
//{
//	std::vector<double> values;
//	TiXmlElement* kiNode = node->FirstChildElement("kiTrigger");
//	TiXmlElement* valueNode = kiNode->FirstChildElement("value");
//
//	if(valueNode)
//	{
//		for(valueNode; valueNode; valueNode = valueNode->NextSiblingElement("value"))
//		{
//			values.push_back(strToDouble(valueNode->GetText()));
//		}
//	}
//
//	//TiXmlElement* pastKiNode = kiNode->FirstChildElement("pastKI");
//	
//	return values;
//}
//
//double qlStepDownELSFactory::nonkiTrigger(TiXmlNode* node)
//{
//	return 0.0;
//}
//
//boost::shared_ptr<StochasticProcessArray> qlStepDownELSFactory::processArr(TiXmlNode* node)
//{
//	TiXmlElement* underIyingInfoNode = node->FirstChildElement("underlyingInfo");
//	Size assetNum = 0;
//
//	std::vector<boost::shared_ptr<StochasticProcess1D> > gbmProcessArray;
//	std::vector<std::string> code;
//	std::vector<std::string> name;
//	std::vector<double> Initial;
//	std::vector<double> drift;
//	std::vector<double> dividend;
//	std::vector<double> vol;
//
//	TiXmlElement* underIyingNode = underIyingInfoNode->FirstChildElement("underlying");
//
//	if(underIyingNode)
//	{
//		for(underIyingNode; underIyingNode; underIyingNode = underIyingNode->NextSiblingElement("underlying"))
//		{
//			//code.push_back(underIyingNode->FirstChildElement("krcode")->GetText());
//			//name.push_back(underIyingNode->FirstChildElement("underName")->GetText());
//			Initial.push_back(strToDouble(underIyingNode->FirstChildElement("currentValue")->GetText()));
//			drift.push_back(strToDouble(underIyingNode->FirstChildElement("drift")->GetText()));
//			dividend.push_back(strToDouble(underIyingNode->FirstChildElement("dividend")->GetText()));
//			vol.push_back(strToDouble(underIyingNode->FirstChildElement("volatility")->GetText()));
//			
//			assetNum = assetNum + 1;
//		}
//	}
//
//	for ( Size i=0 ;i<assetNum; i++)
//	{
//		// 차후 calculation 하는곳에서 dividend 빼면 안댐.
//		gbmProcessArray.push_back(boost::shared_ptr<StochasticProcess1D>(new GeometricBrownianMotionProcess(Initial[i] , drift[i] - dividend[i] , vol[i])));
//	}
//
//	Matrix correlation = corrationMatrix(node);
//
//	boost::shared_ptr<StochasticProcessArray> gbmProcess(new StochasticProcessArray(
//														gbmProcessArray,correlation));
//
//	return gbmProcess;
//}
//
//boost::shared_ptr<PricingEngine> qlStepDownELSFactory::engine()
//{
//	TiXmlDocument document;
//	document.Parse(paraInfo_.c_str(), 0, TIXML_ENCODING_UTF8);
//
//	TiXmlNode* pricingNode = document.FirstChildElement("pricing");
//	TiXmlNode* pricingParameterNode = pricingNode->FirstChildElement("pricingParameter");
//
//	Date referenceDate = strToDate(pricingNode->FirstChildElement("evaluationTime")->GetText());
//	Settings::instance().evaluationDate() = referenceDate ;
//
//	TiXmlElement* simulNumNode = pricingParameterNode->FirstChildElement("simulationNum");
//	Size simulNum = strToSize(simulNumNode->GetText());
//
//	TiXmlElement* discountTSNode = pricingParameterNode->FirstChildElement("dicountFlatTS");
//	double discount = strToDouble(discountTSNode->GetText());
//	//TiXmlNode* processNode = rootNode->FirstChildElement("underlying");
//
//	boost::shared_ptr<StochasticProcessArray> gbmProcess = this->processArr(pricingParameterNode);
//
//	qlYieldTermStructureFactory factory = qlYieldTermStructureFactory();
//
//	//Handle<YieldTermStructure> yieldCurve = factory.yieldTSHandle(pricingParameterNode);
//	boost::shared_ptr<YieldTermStructure> yieldTS = boost::shared_ptr<YieldTermStructure>(
//					new FlatForward(referenceDate,discount,Actual365Fixed()));
//	Handle<YieldTermStructure> yieldCurve = Handle<YieldTermStructure>(yieldTS);
//
//	boost::shared_ptr<PricingEngine> elsEngine(
//								new MCELSGeneralEngine(gbmProcess,
//														yieldCurve,
//														simulNum,//simulNum
//														1));
//
//	
//
//	return elsEngine;
//}
//
//void qlStepDownELSFactory::factoryStepDownKI()
//{
//	//TiXmlText* rootNode = new TiXmlText(instInfo_.c_str());
//	TiXmlDocument document;
//	document.Parse(instInfo_.c_str(), 0, TIXML_ENCODING_UTF8);
//
//	//rootNode.SetValue;
//
//	TiXmlNode* productNode = document.FirstChild("instrument");
//
//	DayCounter daycounter = Actual365Fixed();
//	Calendar calendar = SouthKorea(); // ?
//
//	TiXmlElement* infoNode = productNode->FirstChildElement("issueInformation")->FirstChildElement("securities");
//
//	Date tradeDate = strToDate(infoNode->FirstChildElement("tradeDate")->GetText());
//	Date issueDate = strToDate(infoNode->FirstChildElement("effectiveDate")->GetText());
//	Date maturityDate = strToDate(infoNode->FirstChildElement("maturityDate")->GetText());
//	notional_ = strToSize(infoNode->FirstChildElement("notional")->GetText());
//	Size premium = strToSize(infoNode->FirstChildElement("premium")->GetText());
//
//	std::vector<double> basePrice;
//
//	TiXmlElement* fixedNode = productNode->FirstChildElement("underlyingInformation");
//		TiXmlElement* underNode = fixedNode->FirstChildElement("underlying");
//
//		if(underNode)
//		{
//			for(underNode; underNode; underNode = underNode->NextSiblingElement("underlying"))
//			{
//				TiXmlElement* baseNode = underNode->FirstChildElement("basePrice");
//				basePrice.push_back(strToDouble(baseNode->GetText()));
//
//			}
//		}
//
//	// --------------------------------- Payoff ---------------------------------------------
//
//	TiXmlElement* elsNode = productNode->FirstChildElement("ELSStepDownRedemptions");
//
//	TiXmlNode* triggerNode = elsNode->FirstChildElement("autoCallTrigger");
//
//	std::vector<double> kiTriggers = kiTrigger(elsNode);
//
//	std::vector<Date> autoCallDates;
//	std::vector<double> autoCallTriggers;
//	std::vector<double> autoCallReturns;
//
//	double nonkiReturn;
//
//	if(triggerNode)
//	{
//		for(triggerNode; triggerNode; triggerNode = triggerNode->NextSiblingElement("autoCallTrigger"))
//		{
//			autoCallDates.push_back(strToDate(triggerNode->FirstChildElement("date")->GetText()));
//			autoCallTriggers.push_back(strToDouble(triggerNode->FirstChildElement("trigger")->GetText()));
//			autoCallReturns.push_back(strToDouble(triggerNode->FirstChildElement("return")->GetText()));
//
//		}
//	}
//
//	//ELSStepDown els100 = ELSStepDown(10000.0,
//	inst_ = boost::shared_ptr<ELSStepDown>( 
//								new ELSStepDown(10000.0,
//												issueDate,
//												0,
//												basePrice,
//												autoCallDates,
//												autoCallTriggers,
//												autoCallReturns,
//												kiTriggers,
//												ContiKI,
//												daycounter,
//												calendar,
//												false));
//
//	boost::shared_ptr<PricingEngine> elsEngine = engine();
//
//	//std::cout << "Start" << std::endl;
//	inst_->setPricingEngine(elsEngine);
//	//std::cout << "Eu price                    : " << els100.NPV() << std::endl;
//
//	//std::cout << "Calculation End" << std::endl;
//}
//
//Matrix qlStepDownELSFactory::corrationMatrix(TiXmlNode* node)
//{
//	Matrix correlation(2,2,0.0);
//
//	TiXmlNode * corrNode = node->FirstChildElement("underlyingInfo");
//
//	double corr = strToDouble(corrNode->FirstChildElement("corr")->GetText());
//
//	correlation[0][0] = 1.0 ;
//	correlation[1][1] = 1.0 ;
//	correlation[1][0] = corr ;
//	correlation[0][1] = corr ;
//
//	return correlation;
//}
//
//void qlStepDownELSFactory::buildResultXml(std::map<std::string,boost::any> addedResult)
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
//	//result 쓰기
//}
//
//}