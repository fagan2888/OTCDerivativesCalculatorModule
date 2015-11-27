#include "qlStepDownELSFactory.hpp"
#include <util\convertFunction.hpp>
#include <ql\time\calendars\all.hpp>
#include <Factory\Etc\qlYieldTermStructureFactory.hpp>

using namespace QuantLib;
using namespace ConvertFunction;

namespace XmlFactory {

qlStepDownELSFactory::qlStepDownELSFactory(const std::string& instInfoStr,
										   const std::string& paraInfoStr)
: instInfo_(instInfoStr) , paraInfo_(paraInfoStr)
{
}

void qlStepDownELSFactory::calculate()
{
	this->factoryStepDownKI();

	double value = inst_->NPV();
	std::cout << value << std::endl;
	this->buildResultXml(inst_->additionalResults());
	
}

std::vector<double> qlStepDownELSFactory::kiTrigger(TiXmlNode* node)
{
	std::vector<double> values;
	TiXmlElement* kiNode = node->FirstChildElement("kiTrigger");
	TiXmlElement* valueNode = kiNode->FirstChildElement("value");

	if(valueNode)
	{
		for(valueNode; valueNode; valueNode = valueNode->NextSiblingElement("value"))
		{
			values.push_back(strToDouble(valueNode->GetText()));
		}
	}
	return values;
}

double qlStepDownELSFactory::nonkiTrigger(TiXmlNode* node)
{
	return 0.0;
}

boost::shared_ptr<StochasticProcessArray> qlStepDownELSFactory::processArr(TiXmlNode* node)
{
	Size assetNum = 0;

	std::vector<boost::shared_ptr<StochasticProcess1D> > gbmProcessArray;
	std::vector<std::string> code;
	std::vector<std::string> name;
	std::vector<double> Initial;
	std::vector<double> drift;
	std::vector<double> dividend;
	std::vector<double> vol;

	TiXmlElement* underIniNode = node->FirstChildElement("underlying");

	if(underIniNode)
	{
		for(underIniNode; underIniNode; underIniNode = underIniNode->NextSiblingElement("underlying"))
		{
			code.push_back(underIniNode->FirstChildElement("krcode")->GetText());
			name.push_back(underIniNode->FirstChildElement("underName")->GetText());
			Initial.push_back(strToDouble(underIniNode->FirstChildElement("currentValue")->GetText()));
			drift.push_back(strToDouble(underIniNode->FirstChildElement("drift")->GetText()));
			dividend.push_back(strToDouble(underIniNode->FirstChildElement("dividend")->GetText()));
			vol.push_back(strToDouble(underIniNode->FirstChildElement("volatility")->GetText()));
			
			assetNum = assetNum + 1;
		}
	}

	for ( Size i=0 ;i<assetNum; i++)
	{
		// 차후 calculation 하는곳에서 dividend 빼면 안댐.
		gbmProcessArray.push_back(boost::shared_ptr<StochasticProcess1D>(new GeometricBrownianMotionProcess(Initial[i] , drift[i] - dividend[i] , vol[i])));
	}

	Matrix correlation = corrationMatrix(node);

	boost::shared_ptr<StochasticProcessArray> gbmProcess(new StochasticProcessArray(
														gbmProcessArray,correlation));

	return gbmProcess;
}

boost::shared_ptr<PricingEngine> qlStepDownELSFactory::engine()
{
	TiXmlDocument document;
	document.Parse(paraInfo_.c_str(), 0, TIXML_ENCODING_UTF8);

	TiXmlNode* rootNode = document.FirstChildElement("pricingParametor");

	Date referenceDate = strToDate(rootNode->FirstChildElement("evaluationDate")->GetText());
	Settings::instance().evaluationDate() = referenceDate ;

	TiXmlElement* simulNumNode = rootNode->FirstChildElement("simulationNum");
	Size simulNum = strToSize(simulNumNode->GetText());

	//TiXmlNode* processNode = rootNode->FirstChildElement("underlying");

	boost::shared_ptr<StochasticProcessArray> gbmProcess = this->processArr(rootNode);

	qlYieldTermStructureFactory factory = qlYieldTermStructureFactory();

	Handle<YieldTermStructure> yieldCurve = factory.yieldTSHandle(rootNode);



	boost::shared_ptr<PricingEngine> elsEngine(
								new MCELSGeneralEngine(gbmProcess,
														yieldCurve,
														simulNum,//simulNum
														1));

	

	return elsEngine;
}

void qlStepDownELSFactory::factoryStepDownKI()
{
	//TiXmlText* rootNode = new TiXmlText(instInfo_.c_str());
	TiXmlDocument document;
	document.Parse(instInfo_.c_str(), 0, TIXML_ENCODING_UTF8);

	//rootNode.SetValue;

	TiXmlNode* productNode = document.FirstChild("instrument");

	DayCounter daycounter = Actual365Fixed();
	Calendar calendar = SouthKorea();

	TiXmlElement* infoNode = productNode->FirstChildElement("issueInformation");

	Date tradeDate = strToDate(infoNode->FirstChildElement("tradeDate")->GetText());
	Date issueDate = strToDate(infoNode->FirstChildElement("effectiveDate")->GetText());
	Date maturityDate = strToDate(infoNode->FirstChildElement("maturityDate")->GetText());
	Size notional = strToSize(infoNode->FirstChildElement("notional")->GetText());
	Size premium = strToSize(infoNode->FirstChildElement("premium")->GetText());

	std::vector<double> basePrice;

	TiXmlElement* fixedNode = infoNode->FirstChildElement("underlyingInformation");
	TiXmlElement* underNode = fixedNode->FirstChildElement("underlying");

	TiXmlElement* baseNode = underNode->FirstChildElement("basePrice");

	if(baseNode)
	{
		for(baseNode; baseNode; baseNode = baseNode->NextSiblingElement("basePrice"))
		{
			basePrice.push_back(strToDouble(baseNode->GetText()));

		}
	}

	// --------------------------------- Payoff ---------------------------------------------

	TiXmlElement* elsNode = productNode->FirstChildElement("ELSStepDownRedemptions");

	TiXmlNode* triggerNode = elsNode->FirstChildElement("autoCallTrigger");

	std::vector<double> kiTriggers = kiTrigger(elsNode);

	std::vector<Date> autoCallDates;
	std::vector<double> autoCallTriggers;
	std::vector<double> autoCallReturns;

	double nonkiReturn;

	if(triggerNode)
	{
		for(triggerNode; triggerNode; triggerNode = triggerNode->NextSiblingElement("autoCallTrigger"))
		{
			autoCallDates.push_back(strToDate(triggerNode->FirstChildElement("date")->GetText()));
			autoCallTriggers.push_back(strToDouble(triggerNode->FirstChildElement("trigger")->GetText()));
			autoCallReturns.push_back(strToDouble(triggerNode->FirstChildElement("return")->GetText()));

		}
	}

	//ELSStepDown els100 = ELSStepDown(10000.0,
	inst_ = boost::shared_ptr<ELSStepDown>( 
								new ELSStepDown(10000.0,
												issueDate,
												0,
												basePrice,
												autoCallDates,
												autoCallTriggers,
												autoCallReturns,
												kiTriggers,
												DailyKI,
												daycounter,
												calendar,
												false));

	boost::shared_ptr<PricingEngine> elsEngine = engine();

	//std::cout << "Start" << std::endl;
	inst_->setPricingEngine(elsEngine);
	//std::cout << "Eu price                    : " << els100.NPV() << std::endl;

	//std::cout << "Calculation End" << std::endl;
}

Matrix qlStepDownELSFactory::corrationMatrix(TiXmlNode* node)
{
	Matrix correlation(2,2,0.0);

	double corr = strToDouble(node->FirstChildElement("corr")->GetText());

	correlation[0][0] = 1.0 ;
	correlation[1][1] = 1.0 ;
	correlation[1][0] = corr ;
	correlation[0][1] = corr ;

	return correlation;
}

void qlStepDownELSFactory::buildResultXml(std::map<std::string,boost::any> addedResult)
{

	std::vector<double> _delta = boost::any_cast<std::vector<double>>(addedResult.find("Delta")->second);
	std::vector<double> _gamma = boost::any_cast<std::vector<double>>(addedResult.find("Gamma")->second);
	std::vector<double> _vega = boost::any_cast<std::vector<double>>(addedResult.find("Vega")->second);
	std::vector<double> _sup = boost::any_cast<std::vector<double>>(addedResult.find("Sup")->second);
	std::vector<double> _sdown = boost::any_cast<std::vector<double>>(addedResult.find("SDown")->second);
	std::vector<double> _volup = boost::any_cast<std::vector<double>>(addedResult.find("VolUp")->second);
	std::vector<double> _voldown = boost::any_cast<std::vector<double>>(addedResult.find("VolDown")->second);

	std::vector<double> _step_h = boost::any_cast<std::vector<double>>(addedResult.find("step_h")->second);

	std::vector<double> _underlyingValue = boost::any_cast<std::vector<double>>(addedResult.find("underlyingValue")->second);
	std::vector<double> _earlyExProbability = boost::any_cast<std::vector<double>>(addedResult.find("earlyExProbability")->second);
	std::vector<double> _initialValues = boost::any_cast<std::vector<double>>(addedResult.find("initialValues")->second);
	std::vector<double> _expectedRedem = boost::any_cast<std::vector<double>>(addedResult.find("expectedRedem")->second);

	
	std::cout << "_delta" << " : " << "_gamma" << " : " << "_vega" << std::endl;
	

	for(Size i=0;i<_delta.size();++i){
		std::cout << _delta[i] << " : " << _gamma[i] << " : " << _vega[i] << std::endl;
	}

	std::cout << "_sup" << " : " << "_sdown" << " : " << "_step_h" << std::endl;

	for(Size i=0;i<_delta.size();++i){
		std::cout << _sup[i] << " : " << _sdown[i] << " : " << _step_h[i] << std::endl;
	}

	std::cout << "_volup" << " : " << "_voldown" << std::endl;

	for(Size i=0;i<_delta.size();++i){
		std::cout << _volup[i] << " : " << _voldown[i] << std::endl;
	}
	 
	//result 쓰기
}

}