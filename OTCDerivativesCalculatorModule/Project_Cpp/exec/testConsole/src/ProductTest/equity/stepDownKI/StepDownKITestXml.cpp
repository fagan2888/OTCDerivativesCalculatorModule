//#include <tinyxml/tinyxml.h>
////#include <tinyXPath/xpath_static.h>
//#include <vector>
//#include <ql/time/date.hpp>
//#include <boost/shared_ptr.hpp>
//#include <ql/pricingengine.hpp>
//#include <ql/math/matrix.hpp>
//#include <ql/processes/all.hpp>
//#include <ql/testClass/MCELSGeneralEngine.hpp>
//
////D:\Project File\OTCDerivativesCalculatorModule\Project_Cpp\exec\testConsole\Debug
//using namespace QuantLib;
//
//Date strToDate(const std::string& str)
//{
//	return Date();
//}
//
//double strToDouble(const std::string& str)
//{
//	return 0.0;
//}
//
//Size strToSize(const std::string& str)
//{
//	return 10000;
//}
//
//std::vector<double> kiTrigger(TiXmlNode* node)
//{
//	std::vector<double> values;
//	TiXmlNode* kiNode = node->FirstChild("kiTrigger");
//
//	if(kiNode)
//	{
//		for(kiNode; kiNode; kiNode = kiNode->NextSiblingElement("date"))
//		{
//			values.push_back(strToDouble(kiNode->Value()));
//		}
//	}
//	return values;
//}
//
//double nonkiTrigger(TiXmlNode* node)
//{
//	return 0.0;
//}
//
//Handle<YieldTermStructure> discountTS(TiXmlNode* node)
//{
//		Rate QuoteRate[]={0.0276, 0.0276, 0.0276, 0.0276, 0.0276,0.0276,0.0276,0.0276	,
//							0.0276,0.0276,0.0276,0.0276,0.0276,0.0276};
//				      
//
//		double Maturity[]={0.01, 0.25, 0.5, 0.75, 1, 1.5,   2,    2.5, 3,	4, 5,	
//						   7,    10,  15,	20};
//		
//		std::vector<Date> MaturityDate;
//		std::vector<Rate> SpotData;
//
//		const Size numberOfSpots = 14;
//
//		for (Size i=0;i<numberOfSpots ;i++){
//			//MaturityDate[i]=today+Maturity[i]*365;
//			MaturityDate.push_back(todaysDate+Maturity[i]*365);
//			SpotData.push_back(QuoteRate[i]);
//
//		}
//		
//		Handle<YieldTermStructure> interCurve(
//			boost::shared_ptr<YieldTermStructure>(
//			new InterpolatedZeroCurve< Linear >(MaturityDate,
//										SpotData,
//										daycounter,
//										calendar)));
//}
//
//	
//
//boost::shared_ptr<StochasticProcessArray> processArr(TiXmlNode* node)
//{
//	Size assetNum = 0;
//
//	std::vector<boost::shared_ptr<StochasticProcess1D> > gbmProcessArray;
//	std::vector<double> Initial;
//	std::vector<double> drift;
//	std::vector<double> dividend;
//	std::vector<double> vol;
//
//
//	TiXmlElement* underIniNode = node->FirstChildElement("underlying");
//
//	if(underIniNode)
//	{
//		for(underIniNode; underIniNode; underIniNode = underIniNode->NextSiblingElement("underlying"))
//		{
//			Initial.push_back(strToDouble(underIniNode->FirstChild("value")->Value()));
//			drift.push_back(strToDouble(underIniNode->FirstChild("drift")->Value()));
//			dividend.push_back(strToDouble(underIniNode->FirstChild("dividend")->Value()));
//			vol.push_back(strToDouble(underIniNode->FirstChild("vol")->Value()));
//			
//			assetNum = assetNum + 1;
//		}
//	}
//
//	for ( int i=0 ;i<assetNum; i++)
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
//boost::shared_ptr<PricingEngine> engine()
//{
//	boost::shared_ptr<StochasticProcessArray> gbmProcess = processArr();
//		
//
//
//	bool brownianBridge = false;
//
//	boost::shared_ptr<PricingEngine> MCELSGeneralEngine(new MCELSGeneralEngine(gbmProcess,
//																interCurve,
//																10000,//simulNum
//																1));
//
//
//
//	std::cout << "Start" << std::endl;
//	els100.setPricingEngine(MCELSGeneralEngine);
//	std::cout << "Eu price                    : " << els100.NPV() << std::endl;
//
//	std::cout << "Calculation End" << std::endl;
//
//	return MCELSGeneralEngine;
//}
//
//void factoryStepDownKI()
//{
//	TiXmlDocument document;
//	document.LoadFile("D:\\Project File\\OTCDerivativesCalculatorModule\\Project_Cpp\\exec\\testConsole\\Debug\\ELS701_InstInformation.xml"); 
//
//	TiXmlNode* productNode = document.FirstChild("instrument");
//
//	//
//
//	TiXmlElement* infoNode = productNode->FirstChildElement("issueInformation");
//
//	Date issueDate = strToDate(infoNode->FirstChild("issueDate")->Value());
//	Date maturityDate = strToDate(infoNode->FirstChild("maturityDate")->Value());
//	Size notional = strToSize(infoNode->FirstChild("notional")->Value());
//	Size premium = strToSize(infoNode->FirstChild("premium")->Value());
//
//	std::vector<double> basePrice;
//
//	TiXmlElement* fixedNode = infoNode->FirstChildElement("initialFixedValue");
//	TiXmlElement* baseNode = fixedNode->FirstChildElement("basePrice");
//
//	if(baseNode)
//	{
//		for(baseNode; baseNode; baseNode = baseNode->NextSiblingElement("basePrice"))
//		{
//			basePrice.push_back(strToDouble(baseNode->Value()));
//
//		}
//	}
//
//	// --------------------------------- Payoff ---------------------------------------------
//
//	TiXmlElement* elsNode = productNode->FirstChildElement("ELSStepDownRedemptions");
//
//	TiXmlNode* triggerNode = elsNode->FirstChild("autoCallTrigger");
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
//			autoCallDates.push_back(strToDate(triggerNode->FirstChild("date")->Value()));
//			autoCallTriggers.push_back(strToDouble(triggerNode->FirstChild("trigger")->Value()));
//			autoCallReturns.push_back(strToDouble(triggerNode->FirstChild("return")->Value()));
//
//		}
//	}
//
//
//	TiXmlDocument parametor_document;
//	parametor_document.LoadFile("D:\\Project File\\OTCDerivativesCalculatorModule\\Project_Cpp\\exec\\testConsole\\Debug\\ELS701_Underlying.xml"); 
//
//
//	boost::shared_ptr<PricingEngine> elsEngine = engine();
//
//
//
//
//
//
//	/*if(functionNode)
//	{
//		for(functionNode; functionNode; functionNode = functionNode->NextSiblingElement("function"))
//	}*/
//
//
//}
//
//
//
//Matrix corrationMatrix(TiXmlNode* node)
//{
//	Matrix correlation(2,2,0.0);
//
//	double corr = strToDouble(node->FirstChild("corr")->Value());
//
//	correlation[0][0] = 1.0 ;
//	correlation[1][1] = 1.0 ;
//	correlation[1][0] = corr ;
//	correlation[0][1] = corr ;
//
//	return correlation;
//}
//
