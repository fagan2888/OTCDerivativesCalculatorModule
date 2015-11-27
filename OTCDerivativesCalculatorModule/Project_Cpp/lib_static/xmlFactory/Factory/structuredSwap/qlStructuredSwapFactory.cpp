#include "qlStructuredSwapFactory.hpp"
#include <util\convertFunction.hpp>
#include <ql\time\calendars\all.hpp>
#include <factory\Etc\qlYieldTermStructureFactory.hpp>
#include <boost/lexical_cast.hpp>
#include <GenClass\RiskMonitor-0-1\all.hpp>
#include <Factory\Etc\all.hpp>

#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>
#include <src/Engine/MonteCarlo/pricer/all.hpp>
#include <src/Engine/MonteCarlo/MonteEngine.hpp>
#include <src/Engine/MonteCarlo/fixingDateInfo.hpp>

using namespace QuantLib;
using namespace ConvertFunction;

namespace XmlFactory {

qlStructuredSwapFactory::qlStructuredSwapFactory()
{
}

void qlStructuredSwapFactory::calculate()
{
	this->factoryStructuredSwap();
	
	//this->engine_->calculate();
	value_ = this->instrument_->NPV();
	
	this->buildResultXml();

	//std::cout << value_ << std::endl;
	//this->buildResultXml(inst_->additionalResults());
	//
}


void qlStructuredSwapFactory::calculate(const std::string& instInfoStr,
								const std::string& paraInfoStr)
{
	this->instInfo_ = instInfoStr;
	this->paraInfo_ = paraInfoStr;

	this->factoryStructuredSwap();
	
	//this->engine_->;
	//value_ = inst_->NPV();
	//std::cout << value_ << std::endl;
	//this->buildResultXml(inst_->additionalResults());
	//
}

boost::shared_ptr<MonteEngine> qlStructuredSwapFactory::engine()
{
	//TiXmlDocument document;
	//document.Parse(paraInfo_.c_str(), 0, TIXML_ENCODING_UTF8);

	//TiXmlNode* pricingNode = document.FirstChildElement("pricing");
	//FpmlSerialized::Pricing xml_pricing = FpmlSerialized::Pricing(pricingNode);
	
	//boost::shared_ptr<FpmlSerialized::Pricing> xml_pricing = this->xml_productInnerXml_->getPricing();

	Date referenceDate = this->xml_pricing_->getEvaluationTime()->dateValue();
	Settings::instance().evaluationDate() = referenceDate ;

	boost::shared_ptr<FpmlSerialized::Excel_parameter> xml_para = this->xml_pricing_->getExcel_parameter();

	boost::shared_ptr<FpmlSerialized::Excel_standardSwapPara> xml_standardSwap_para = xml_para->getExcel_standardSwapPara();
	
	boost::shared_ptr<FpmlSerialized::Excel_underlyingCalcInfo_para> xml_excelUnderyingCalcInfo_para = xml_standardSwap_para->getExcel_underlyingCalcInfo_para();

	qlProcessFactory process_factory = qlProcessFactory();
	
	//process_factory.setProcessCode(this->underListCode_);
	process_factory.buildProcess(xml_excelUnderyingCalcInfo_para);

	const boost::shared_ptr<ProcessArrayWrapper>& prrArrWrapper
		= process_factory.getProcessArrWrapper();

	bool needSimul = prrArrWrapper->isNeedSimul();

	qlYieldTermStructureFactory ql_tysf = qlYieldTermStructureFactory();

	//Handle<YieldTermStructure> yieldCurve = factory.yieldTSHandle(pricingParameterNode);
	//boost::shared_ptr<YieldTermStructure> yieldTS = boost::shared_ptr<YieldTermStructure>(
	//				new FlatForward(referenceDate,discount,Actual365Fixed()));

	boost::shared_ptr<FpmlSerialized::Excel_discountCurve_para> xml_discount = xml_standardSwap_para->getExcel_discountCurve_para();

	std::vector<boost::shared_ptr<YieldTermStructure>> yieldTSList
		= ql_tysf.e_yieldTermStructureList(xml_discount);

	//Handle<YieldTermStructure> yieldCurve = Handle<YieldTermStructure>(yieldTS);
	
	Size simulNum = xml_standardSwap_para->getSimulationNum()->IValue();

	if (!needSimul) { simulNum = 1; }

	boost::shared_ptr<MonteEngine> engine(
								new MonteEngine(this->pricer_,
												prrArrWrapper,
												yieldTSList[0],
												simulNum,//simulNum
												1));
	return engine;
}


void qlStructuredSwapFactory::factoryStructuredSwap()
{
	//TiXmlText* rootNode = new TiXmlText(instInfo_.c_str());
	//TiXmlDocument document;
	//document.Parse(instInfo_.c_str(), 0, TIXML_ENCODING_UTF8);

	//TiXmlNode* instNode = document.FirstChild("instrument");

	//rootNode.SetValue;
	DayCounter daycounter = Actual365Fixed();
	Calendar calendar = SouthKorea(); // ?

	//boost::shared_ptr<FpmlSerialized::Instrument> xml_instrument = this->xml_productInnerXml_->getInstrument();

	std::string code = this->xml_instrument_->getCode()->SValue();

	//FpmlSerialized::Instrument xml_instrument = FpmlSerialized::Instrument(instNode);
	//boost::shared_ptr<FpmlSerialized::InstPositionInfo> xml_positionInfo = xml_instrument.getInstPositionInfo();
	//this->krCode_ = xml_positionInfo->getKrCode()->SValue();

	boost::shared_ptr<FpmlSerialized::Excel_swapInterface> xml_swapInterface = this->xml_instrument_->getExcel_swapInterface();

	boost::shared_ptr<FpmlSerialized::Excel_structuredSwap> xml_structuredSwap = xml_swapInterface->getExcel_structuredSwap();

	std::vector<boost::shared_ptr<Excel_swapLeg>> xml_legs 
		= xml_structuredSwap->getExcel_swapLeg();

	const boost::shared_ptr<FpmlSerialized::Excel_swapLeg>& rec_swapLeg 
		= xml_legs[0];

	const boost::shared_ptr<FpmlSerialized::Excel_swapLeg>& pay_swapLeg 
		= xml_legs[1];

	qlPricerFactory ql_pf = qlPricerFactory();

	const boost::shared_ptr<QuantLib::MCPricer>& rec_pricer
		= ql_pf.pricer(rec_swapLeg);

	const boost::shared_ptr<QuantLib::MCPricer>& pay_pricer
		= ql_pf.pricer(pay_swapLeg);

	// 각각의 pricer currency 들은 swap noteInfo 의 currency 기준으로 변환됨.
	boost::shared_ptr<FpmlSerialized::Excel_noteInfo> xml_noteInfo 
		= xml_structuredSwap->getExcel_issueInfo()->getExcel_noteInfo();

	//Date tradeDate = xml_noteInfo->getTradeDate()->dateValue();
	Date effectiveDate = xml_noteInfo->getEffectiveDate()->dateValue();
	Date maturityDate = xml_noteInfo->getMaturityDate()->dateValue();
	//Real notional = xml_noteInfo->getNotional()->DValue();
	Real notional = 1.0;
	std::string currency = xml_noteInfo->getCurrency()->SValue();
	/*const boost::shared_ptr<MCPricer>& pricer*/

	this->pricer_ = boost::shared_ptr<AutoCallableSwapPricer>( 
								new AutoCallableSwapPricer(rec_pricer,
														   pay_pricer,
														   notional,
														   currency));

	// --------------------------------- Engine ---------------------------------------------

	//boost::shared_ptr<FpmlSerialized::Excel_underlyingCalcInfo_para> xml_underlyingCalcInfo_para = xml_hifive->getExcel_underlyingCalcInfo();

	const boost::shared_ptr<NoteInst>& noteInst
			= boost::shared_ptr<NoteInst>(
						new NoteInst(code,notional,
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



//void qlStructuredSwapFactory::buildResultXml(std::map<std::string,boost::any> addedResult)


}
//}