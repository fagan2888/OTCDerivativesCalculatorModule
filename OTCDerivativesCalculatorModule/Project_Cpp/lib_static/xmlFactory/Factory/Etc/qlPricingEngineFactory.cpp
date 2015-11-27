//#include "qlPricingEngineFactory.hpp"
//#include <src/Engine/MonteCarlo/instrument/all.hpp>
//#include <src/Engine/MonteCarlo/MonteEngine.hpp>
//#include <Factory/Etc/all.hpp>
//#include <src/Engine/MonteCarlo/stochasticProcess/all.hpp>
//
//using namespace QuantLib;
//
//namespace XmlFactory {
//
//qlPricingEngineFactory::qlPricingEngineFactory()
//{
//
//}
//
//boost::shared_ptr<QuantLib::PricingEngine> qlPricingEngineFactory::pricingEngine(const boost::shared_ptr<FpmlSerialized::InstrumentInfo>& xml_instInfo,
//																	 	 const boost::shared_ptr<FpmlSerialized::Excel_parameter>& xml_para)
//{
//	boost::shared_ptr<QuantLib::PricingEngine> ql_engine;
//
//	std::string engineType = "monte";
//
//	//if ( engineType == "monte")
//	//{
//	//	ql_engine = this->monteCalroEngine(xml_instInfo,xml_pricingPara);
//	//}
//	//else if ( xml_issueInfo->getType()->SValue() == "swapInfo" )
//	//{
//	//	const boost::shared_ptr<FpmlSerialized::SwapInfo> xml_swapInfo = xml_issueInfo->getSwapInfo();
//
//	//	ql_inst = this->swapInstrument(xml_swapInfo);	
//	//}
//	
//	else 
//	{
//		
//	}
//
//	return ql_engine;
//}
//boost::shared_ptr<QuantLib::PricingEngine> qlPricingEngineFactory::standardInstPricingEngine(const boost::shared_ptr<FpmlSerialized::StandardInstrument>& xml_standInst,
//																		const boost::shared_ptr<FpmlSerialized::PricingParameter>& xml_pricingPara)
//{
//	const boost::shared_ptr<FpmlSerialized::Standard_para>& xml_stand_para = xml_pricingPara->getStandard_para();
//
//	// Pricer ------------------------------------------------------------
//
//	boost::shared_ptr<MCPricer> pricer;
//
//	qlPricerFactory pricerFactory = qlPricerFactory();
//
//	const std::string& typeStr = xml_standInst->getIssueInformation()->getType()->SValue();
//
//	const boost::shared_ptr<FpmlSerialized::PayoffInfo>& xml_payoffInfo = xml_standInst->getPayoffInfo();
//
//	pricer = pricerFactory.singlePricer(xml_payoffInfo);
//
//	// Underlying ------------------------------------------------------------
//
//	const boost::shared_ptr<FpmlSerialized::UnderlyingInformation>& xml_underInfo = xml_standInst->getUnderlyingInformation();
//	const boost::shared_ptr<FpmlSerialized::UnderlyingInfo_para>& xml_underInfo_para = xml_stand_para->getUnderlyingInfo_para();
//
//	qlProcessFactory processFactory = qlProcessFactory();
//	processFactory.makeProcess(xml_underInfo,xml_underInfo_para);
//
//	//boost::shared_ptr<QuantLib::StochasticProcessArray> processArr = processFactory.getProcessArr();
//	boost::shared_ptr<QuantLib::ProcessArrayWrapper> processArrWrrapper = processFactory.getProcessArrWrapper();
//
//	// DicountYield ------------------------------------------------------------
//
//	const boost::shared_ptr<FpmlSerialized::YieldTermstructure>& xml_yieldTS = xml_stand_para->getDiscountCurve_para()->getYieldTermstructure();
//
//	qlYieldTermStructureFactory yieldTSFactory = qlYieldTermStructureFactory();
//	
//	boost::shared_ptr<YieldTermStructure> discountCurve = yieldTSFactory.yieldTSBoost(xml_yieldTS);
//
//	// Method ------------------------------------------------------------
//
//	const boost::shared_ptr<FpmlSerialized::Monte>& xml_monte = xml_pricingPara->getMethod()->getMonte();
//
//	Size simulNum = xml_monte->getSimulationNum()->IValue();
//	
//	Size seed = 1;
//
//	boost::shared_ptr<QuantLib::MonteEngine> mcEngine 
//					= boost::shared_ptr<QuantLib::MonteEngine>(
//												new MonteEngine(pricer,
//																//processArr,
//																processArrWrrapper,
//																discountCurve,
//																simulNum,
//																seed));
//
//	return mcEngine;
//}
//
//boost::shared_ptr<QuantLib::PricingEngine> qlPricingEngineFactory::
//	standardSwapInstPricingEngine(const boost::shared_ptr<FpmlSerialized::StandardSwapInstrument>& xml_standSwapInst,
//								  const boost::shared_ptr<FpmlSerialized::PricingParameter>& xml_pricingPara)
//{
//	const boost::shared_ptr<FpmlSerialized::Standard_para>& xml_stand_para = xml_pricingPara->getStandard_para();
//
//	// Pricer ------------------------------------------------------------
//
//	boost::shared_ptr<MCPricer> pricer;
//
//	qlPricerFactory pricerFactory = qlPricerFactory();
//
//	const std::string& typeStr = xml_standSwapInst->getIssueInformation()->getType()->SValue();
//
//	const boost::shared_ptr<FpmlSerialized::SwapPayoffInfo>& xml_payoffInfo = xml_standSwapInst->getSwapPayoffInfo();
//
//	pricer = pricerFactory.swapPricer(xml_payoffInfo);
//
//	// Underlying ------------------------------------------------------------
//
//	const boost::shared_ptr<FpmlSerialized::UnderlyingInformation>& xml_underInfo = xml_standSwapInst->getUnderlyingInformation();
//	const boost::shared_ptr<FpmlSerialized::UnderlyingInfo_para>& xml_underInfo_para = xml_stand_para->getUnderlyingInfo_para();
//
//	qlProcessFactory processFactory = qlProcessFactory();
//	processFactory.makeProcess(xml_underInfo,xml_underInfo_para);
//
//	//boost::shared_ptr<QuantLib::StochasticProcessArray> processArr = processFactory.getProcessArr();
//	boost::shared_ptr<QuantLib::ProcessArrayWrapper> processArrWrrapper = processFactory.getProcessArrWrapper();
//
//	// DicountYield ------------------------------------------------------------
//
//	const boost::shared_ptr<FpmlSerialized::YieldTermstructure>& xml_yieldTS = xml_stand_para->getDiscountCurve_para()->getYieldTermstructure();
//
//	qlYieldTermStructureFactory yieldTSFactory = qlYieldTermStructureFactory();
//	
//	boost::shared_ptr<YieldTermStructure> discountCurve = yieldTSFactory.yieldTSBoost(xml_yieldTS);
//
//	// Method ------------------------------------------------------------
//
//	const boost::shared_ptr<FpmlSerialized::Monte>& xml_monte = xml_pricingPara->getMethod()->getMonte();
//
//	Size simulNum = xml_monte->getSimulationNum()->IValue();
//	Size seed = 1;
//
//	boost::shared_ptr<QuantLib::MonteEngine> mcEngine 
//					= boost::shared_ptr<QuantLib::MonteEngine>(
//												new MonteEngine(pricer,
//																//processArr,
//																processArrWrrapper,
//																discountCurve,
//																simulNum,
//																seed));
//
//	return mcEngine;
//}
//
//
//boost::shared_ptr<QuantLib::PricingEngine> qlPricingEngineFactory::monteCalroEngine(const boost::shared_ptr<FpmlSerialized::InstrumentInfo>& xml_instInfo,
//																					const boost::shared_ptr<FpmlSerialized::PricingParameter>& xml_pricingPara)
//{
//
//	const boost::shared_ptr<FpmlSerialized::StandardInstrument>& xml_standInst = xml_instInfo->getStandardInstrument();
//	const boost::shared_ptr<FpmlSerialized::Standard_para>& xml_stand_para = xml_pricingPara->getStandard_para();
//
//	// Pricer ------------------------------------------------------------
//
//	boost::shared_ptr<MCPricer> pricer;
//
//	qlPricerFactory pricerFactory = qlPricerFactory();
//
//	const std::string& typeStr = xml_standInst->getIssueInformation()->getType()->SValue();
//
//	if ( typeStr == "noteInfo" )
//	{
//		const boost::shared_ptr<FpmlSerialized::PayoffInfo>& xml_payoffInfo = xml_standInst->getPayoffInfo();
//
//		pricer = pricerFactory.singlePricer(xml_payoffInfo);
//
//	}else if ( typeStr == "swapInfo" )
//	{
//		//const boost::shared_ptr<FpmlSerialized::SwapPayoffInfo>& xml_swapPayoffInfo = xml_standInst->();
//
//		//pricer = pricerFactory.swapPricer(xml_payoffInfo,xml_pricingPara);
//
//	}else if ( typeStr == "optionInfo" )
//	{
//		
//	}else
//	{
//		QL_FAIL("unknown varType : " << typeStr);
//	}
//
//
//
//
//	// Underlying ------------------------------------------------------------
//
//	const boost::shared_ptr<FpmlSerialized::UnderlyingInformation>& xml_underInfo = xml_standInst->getUnderlyingInformation();
//	const boost::shared_ptr<FpmlSerialized::UnderlyingInfo_para>& xml_underInfo_para = xml_stand_para->getUnderlyingInfo_para();
//
//	qlProcessFactory processFactory = qlProcessFactory();
//	processFactory.makeProcess(xml_underInfo,xml_underInfo_para);
//
//	//boost::shared_ptr<QuantLib::StochasticProcessArray> processArr = processFactory.getProcessArr();
//	boost::shared_ptr<QuantLib::ProcessArrayWrapper> processArrWrrapper = processFactory.getProcessArrWrapper();
//
//	// DicountYield ------------------------------------------------------------
//
//	const boost::shared_ptr<FpmlSerialized::YieldTermstructure>& xml_yieldTS = xml_stand_para->getDiscountCurve_para()->getYieldTermstructure();
//
//	qlYieldTermStructureFactory yieldTSFactory = qlYieldTermStructureFactory();
//	
//	boost::shared_ptr<YieldTermStructure> discountCurve = yieldTSFactory.yieldTSBoost(xml_yieldTS);
//
//	// Method ------------------------------------------------------------
//
//	const boost::shared_ptr<FpmlSerialized::Monte>& xml_monte = xml_pricingPara->getMethod()->getMonte();
//
//	Size simulNum = xml_monte->getSimulationNum()->IValue();
//	Size seed = 1;
//
//	boost::shared_ptr<QuantLib::MonteEngine> mcEngine 
//					= boost::shared_ptr<QuantLib::MonteEngine>(
//												new MonteEngine(pricer,
//																//processArr,
//																processArrWrrapper,
//																discountCurve,
//																simulNum,
//																seed));
//
//	return mcEngine;
//}
//
//
//}
//
