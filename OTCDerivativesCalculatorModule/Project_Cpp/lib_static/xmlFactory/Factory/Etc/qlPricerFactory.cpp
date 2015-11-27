#include "qlPricerFactory.hpp"
#include <src/Engine/MonteCarlo/pricer/all.hpp>
#include <Factory/Etc/all.hpp>

using namespace QuantLib;

namespace XmlFactory {

qlPricerFactory::qlPricerFactory()
{

}

// public member --------------------------------------------------------------------
boost::shared_ptr<MCPricer> qlPricerFactory::pricer(
	const boost::shared_ptr<FpmlSerialized::Excel_interface>& xml_interface)
{
	boost::shared_ptr<MCPricer> pricer;

	std::string interfaceType = xml_interface->getExcel_type()->SValue();
	
	std::string upperStr = boost::to_upper_copy(interfaceType);

	// excel_five
	if ( upperStr == "EXCEL_HIFIVE")
	{
		const boost::shared_ptr<FpmlSerialized::Excel_hifive>& xml_hifive
							= xml_interface->getExcel_hifive();

		pricer = this->excel_hifive(xml_hifive);
	}
	// excel_structuredBond
	else if ( upperStr == "EXCEL_STRUCTUREDBOND")
	{
		const boost::shared_ptr<FpmlSerialized::Excel_structuredBond>& xml_structuredBond
							= xml_interface->getExcel_structuredBond();

		pricer = this->excel_structuredBond(xml_structuredBond);
	}
	//// excel_compositeOption
	//else if ( upperStr == "EXCEL_COMPOSITEOPTION")
	//{
	//	const boost::shared_ptr<FpmlSerialized::Excel_compositeOption>& xml_compositeOption
	//						= xml_interface->getExcel_compositeOption();

	//	pricer = this->excel_compositeOption(xml_compositeOption);
	//}
	//// excel_multiAssetCompositeOption
	//else if ( upperStr == "EXCEL_MULTIASSETCOMPOSITEOPTION")
	//{
	//	const boost::shared_ptr<FpmlSerialized::Excel_multiAssetCompositeOption>& xml_multiAssetCompositeOption
	//						= xml_interface->getExcel_multiAssetCompositeOption();

	//	pricer = this->excel_multiAssetCompositeOption(xml_multiAssetCompositeOption);
	//}

	
	else 
	{
		QL_FAIL("unknown interface Type : " << upperStr );
	}

	//qlVariableInfoFactory qlVIF = qlVariableInfoFactory();

	//if ( !xml_payoffInfo->isPreDefinedVariableList() )
	//{
	//	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> ql_variableInfoList;

	//	std::vector<boost::shared_ptr<FpmlSerialized::PreDefinedVariableInfo>> xml_variableInfoList
	//		= xml_payoffInfo->getPreDefinedVariableList()->getPreDefinedVariableInfo();

	//	for ( Size i=0 ; i< xml_variableInfoList.size() ; i++ )
	//	{
	//		ql_variableInfoList.push_back(qlVIF.preDefinedVariableInfo(xml_variableInfoList[i]));
	//	}

	//	pricerPtr->registVariableInfo(ql_variableInfoList);
	//}

	return pricer;

}


boost::shared_ptr<MCPricer> qlPricerFactory::pricer(
	const boost::shared_ptr<FpmlSerialized::Excel_swapLeg>& xml_swapLeg)
{
	boost::shared_ptr<MCPricer> pricer;

	const std::string& interfaceType = xml_swapLeg->getExcel_type()->SValue();
	
	std::string upperStr = boost::to_upper_copy(interfaceType);

	// excel_five
	if ( upperStr == "EXCEL_HIFIVESWAPLEG")
	{
		const boost::shared_ptr<FpmlSerialized::Excel_hifive>& xml_hifive
							= xml_swapLeg->getExcel_hifiveSwapLeg()->getExcel_interface()->getExcel_hifive();

		pricer = this->excel_hifive(xml_hifive);
	}
	// excel_structuredBond
	else if ( upperStr == "EXCEL_STRUCTUREDSWAPLEG")
	{
		const boost::shared_ptr<FpmlSerialized::Excel_structuredBond>& xml_structuredBond
							= xml_swapLeg->getExcel_structuredSwapLeg()->getExcel_interface()->getExcel_structuredBond();

		pricer = this->excel_structuredBond(xml_structuredBond);
	}
	else 
	{
		QL_FAIL("unknown xml_swapLeg Type : " << upperStr );
	}

	//qlVariableInfoFactory qlVIF = qlVariableInfoFactory();

	//if ( !xml_payoffInfo->isPreDefinedVariableList() )
	//{
	//	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> ql_variableInfoList;

	//	std::vector<boost::shared_ptr<FpmlSerialized::PreDefinedVariableInfo>> xml_variableInfoList
	//		= xml_payoffInfo->getPreDefinedVariableList()->getPreDefinedVariableInfo();

	//	for ( Size i=0 ; i< xml_variableInfoList.size() ; i++ )
	//	{
	//		ql_variableInfoList.push_back(qlVIF.preDefinedVariableInfo(xml_variableInfoList[i]));
	//	}

	//	pricerPtr->registVariableInfo(ql_variableInfoList);
	//}

	return pricer;

}

// private member --------------------------------------------------------------------
boost::shared_ptr<MCPricer> qlPricerFactory::excel_hifive(
	const boost::shared_ptr<FpmlSerialized::Excel_hifive>& xml_serial)
{
	//boost::shared_ptr<FpmlSerialized::Excel_interface> xml_interface = xml_instrument.getExcel_interface();

	//boost::shared_ptr<FpmlSerialized::Excel_hifive> xml_hifive = xml_interface->getExcel_hifive();
	boost::shared_ptr<MCPricer> pricer;

	DayCounter daycounter = Actual365Fixed();
	Calendar calendar = SouthKorea(); // ?

	boost::shared_ptr<FpmlSerialized::Excel_noteInfo> xml_noteInfo = xml_serial->getExcel_issueInfo()->getExcel_noteInfo();

	//Date tradeDate = xml_noteInfo->getTradeDate()->dateValue();
	Date effectiveDate = xml_noteInfo->getEffectiveDate()->dateValue();
	Date maturityDate = xml_noteInfo->getMaturityDate()->dateValue();
	Real notional = xml_noteInfo->getNotional()->DValue();
	std::string currency = xml_noteInfo->getCurrency()->SValue();
	Real includeNotionalPayment = xml_noteInfo->getIncludeNotionalPayment()->DValue();

	std::vector<boost::shared_ptr<FpmlSerialized::Excel_schedule>> xml_scheduleList = xml_serial->getExcel_scheduleList()->getExcel_schedule();
	std::vector<boost::shared_ptr<QuantLib::EventTriggerInfo>> ql_etiList;

	qlEventTriggerInfoFactory qetif = qlEventTriggerInfoFactory();

	for(Size i = 0 ; i<xml_scheduleList.size(); ++i )
	{
		const boost::shared_ptr<EventTriggerInfo>& ql_eti
			= qetif.schedule(xml_scheduleList[i]);

		ql_etiList.push_back(ql_eti);

	}

	const boost::shared_ptr<EventTriggerInfo>& ql_kiEti
			= qetif.excel_kiEventCalculation(xml_serial->getExcel_kiEventCalculation());

	qlFixingDateInfoFactory qfdif = qlFixingDateInfoFactory();
	
	const boost::shared_ptr<QuantLib::FixingDateInfo>& payoffDateInfo 
		= qfdif.fixingDateInfo(maturityDate);

	pricer = boost::shared_ptr<HifivePricer>( 
								new HifivePricer(ql_etiList,
													ql_kiEti,
													includeNotionalPayment,
													currency,
													payoffDateInfo));

	return pricer;

}

boost::shared_ptr<MCPricer> qlPricerFactory::excel_structuredBond(
	const boost::shared_ptr<FpmlSerialized::Excel_structuredBond>& xml_serial)
{
	boost::shared_ptr<MCPricer> pricer;

	DayCounter daycounter = Actual365Fixed();
	Calendar calendar = SouthKorea(); // ?

	boost::shared_ptr<FpmlSerialized::Excel_noteInfo> xml_noteInfo = xml_serial->getExcel_issueInfo()->getExcel_noteInfo();

	//Date tradeDate = xml_noteInfo->getTradeDate()->dateValue();
	Date effectiveDate = xml_noteInfo->getEffectiveDate()->dateValue();
	Date maturityDate = xml_noteInfo->getMaturityDate()->dateValue();
	Real notional = xml_noteInfo->getNotional()->DValue();
	std::string currency = xml_noteInfo->getCurrency()->SValue();
	Real includeNotionalPayment = xml_noteInfo->getIncludeNotionalPayment()->DValue();

	std::vector<boost::shared_ptr<FpmlSerialized::Excel_couponSchedule>> xml_couponScheduleList 
		= xml_serial->getExcel_couponScheduleList()->getExcel_couponSchedule();

	std::vector<boost::shared_ptr<QuantLib::EventTriggerInfo>> ql_etiList;

	qlEventTriggerInfoFactory qetif = qlEventTriggerInfoFactory();

	for(Size i = 0 ; i<xml_couponScheduleList.size(); ++i )
	{
		const boost::shared_ptr<EventTriggerInfo>& ql_eti
			= qetif.couponSchedule(xml_couponScheduleList[i]);

		ql_etiList.push_back(ql_eti);
	}

	qlFixingDateInfoFactory qfdif = qlFixingDateInfoFactory();
	
	const boost::shared_ptr<QuantLib::FixingDateInfo>& payoffDateInfo 
		= qfdif.fixingDateInfo(maturityDate);

	pricer = boost::shared_ptr<AutoCallablePricer>( 
								new AutoCallablePricer(ql_etiList,
													   includeNotionalPayment,
													   currency,
													   payoffDateInfo));

	return pricer;

}


//boost::shared_ptr<MCPricer> qlPricerFactory::autoCallableSwapPricer(const boost::shared_ptr<FpmlSerialized::AutoCallableSwapPayoff>& xml_serial)
//{
//	boost::shared_ptr<MCPricer> pricerPtr;
//
//	boost::shared_ptr<MCPricer> recievePricer;
//	boost::shared_ptr<MCPricer> payPricer;
//
//	const boost::shared_ptr<FpmlSerialized::PayoffInfo>& xml_recievePayoffInfo 
//		= xml_serial->getRecieveSwapPart()->getPayoffInfo();
//	//std::string recievePricerType = xml_recievePayoffInfo->getType()->SValue();
//
//	const boost::shared_ptr<FpmlSerialized::PayoffInfo>& xml_payPayoffInfo 
//		= xml_serial->getPaySwapPart()->getPayoffInfo();
//	//std::string payPricerType = xml_payPayoffInfo->getType()->SValue();
//
//
//	recievePricer = this->singlePricer(xml_recievePayoffInfo);
//	payPricer = this->singlePricer(xml_payPayoffInfo);
//
//	pricerPtr = boost::shared_ptr<MCPricer>( 
//		new QuantLib::AutoCallableSwapPricer(payPricer,recievePricer));
//
//	return pricerPtr;
//}


//boost::shared_ptr<MCPricer> qlPricerFactory::stepDownKIPayoffPricer(const boost::shared_ptr<FpmlSerialized::StepDownKIPayoff>& xml_serial)
//{
//	boost::shared_ptr<MCPricer> pricerPtr;
//
//	boost::shared_ptr<FpmlSerialized::KiEventInfo> xml_kiInfo = xml_serial->getKiEventInfo();
//	boost::shared_ptr<FpmlSerialized::NonKiEventInfo> xml_nonkiInfo = xml_serial->getNonKiEventInfo();
//
//	std::vector<boost::shared_ptr<FpmlSerialized::EventTrigger>> xml_eventTriggerList = xml_serial->getEventTriggerList()->getEventTrigger();
//
//	std::vector<boost::shared_ptr<EventTriggerInfo>> eventTriggerList;
//
//	qlEventTriggerInfoFactory qlETIFactory = qlEventTriggerInfoFactory();
//
//	for(Size i = 0 ; i<xml_eventTriggerList.size(); ++i )
//	{
//		eventTriggerList.push_back( qlETIFactory.eventTriggerInfo(xml_eventTriggerList[i]) );
//	}
//
//	const boost::shared_ptr<EventTriggerInfo>& kiInfo = qlETIFactory.eventTriggerInfo( xml_kiInfo->getEventTrigger() );
//	const boost::shared_ptr<EventTriggerInfo>& nonkiInfo = qlETIFactory.eventTriggerInfo( xml_nonkiInfo->getEventTrigger() );
//
//	pricerPtr = boost::shared_ptr<StepDownKIEventPricer>(
//						new StepDownKIEventPricer(eventTriggerList,
//												  kiInfo,
//												  nonkiInfo));
//
//	return pricerPtr;
//
//}

//boost::shared_ptr<MCPricer> qlPricerFactory::stepDownNoKIPayoffPricer(const boost::shared_ptr<FpmlSerialized::StepDownNoKIPayoff>& xml_serial)
//{
//	boost::shared_ptr<MCPricer> pricerPtr;
//
//	std::vector<boost::shared_ptr<FpmlSerialized::EventTrigger>> xml_eventTriggerList = xml_serial->getEventTriggerList()->getEventTrigger();
//	boost::shared_ptr<FpmlSerialized::NoAutoCallReturnTrigger> xml_noAutoCall = xml_serial->getNoAutoCallReturnTrigger();
//
//	std::vector<boost::shared_ptr<EventTriggerInfo>> eventTriggerList;
//
//	qlEventTriggerInfoFactory qlETIFactory = qlEventTriggerInfoFactory();
//
//	for(Size i = 0 ; i<xml_eventTriggerList.size(); ++i )
//	{
//		eventTriggerList.push_back( qlETIFactory.eventTriggerInfo(xml_eventTriggerList[i]) );
//	}
//
//	const boost::shared_ptr<EventTriggerInfo>& noAutoCall = qlETIFactory.noAutoCallReturnETI(xml_noAutoCall);
//
//	pricerPtr = boost::shared_ptr<StepDownNoKIEventPricer>(
//						new StepDownNoKIEventPricer(eventTriggerList,
//												   noAutoCall));
//
//	return pricerPtr;
//
//}

//boost::shared_ptr<MCPricer> qlPricerFactory::interestRateSwapPayoffPricer(const boost::shared_ptr<FpmlSerialized::InterestRateSwapPayoff>& xml_serial)
//{
//	boost::shared_ptr<MCPricer> pricerPtr;
//
//	return pricerPtr;
//
//}

//boost::shared_ptr<MCPricer> qlPricerFactory::stopLossPayoffPricer(const boost::shared_ptr<FpmlSerialized::StopLossPayoff>& xml_serial)
//{
//	boost::shared_ptr<MCPricer> pricerPtr;
//
//	//eventTriggerList
//	std::vector<boost::shared_ptr<FpmlSerialized::EventTrigger>> xml_eventTriggerList = xml_serial->getEventTriggerList()->getEventTrigger();
//
//	std::vector<boost::shared_ptr<EventTriggerInfo>> eventTriggerList;
//
//	qlEventTriggerInfoFactory qlETIFactory = qlEventTriggerInfoFactory();
//
//	for(Size i = 0 ; i<xml_eventTriggerList.size(); ++i )
//	{
//		eventTriggerList.push_back( qlETIFactory.eventTriggerInfo(xml_eventTriggerList[i]) );
//	}
//
//	//BarrierInfo
//	const boost::shared_ptr<FpmlSerialized::BarrierInfo>& xml_barrierInfo = xml_serial->getBarrierInfo();
//	
//	const boost::shared_ptr<QuantLib::EventTriggerInfo>& ql_barrierInfo 
//		= qlETIFactory.barrierInfoETI(xml_barrierInfo);
//
//	//ReturnCalculation
//	qlReturnCalculationFactory qlRCF = qlReturnCalculationFactory();
//
//	const boost::shared_ptr<FpmlSerialized::ReturnCalculation>& xml_returnCal = xml_serial->getReturnCalculation();
//
//	const boost::shared_ptr<QuantLib::ReturnCalculation>& ql_returnCal 
//		= qlRCF.returnCal(xml_returnCal);
//
//	qlFixingDateInfoFactory qlFDF = qlFixingDateInfoFactory();
//
//	boost::shared_ptr<QuantLib::FixingDateInfo> payoffDateInfo 
//				= qlFDF.fixingDateInfo(xml_serial->getPayoffDateInfo()->getFixingDateInfo());
//
//	pricerPtr = boost::shared_ptr<MCPricer>(
//		new StopLossEventPricer(eventTriggerList,
//								ql_barrierInfo,
//								ql_returnCal,
//								payoffDateInfo));
//
//	return pricerPtr;
//}

//boost::shared_ptr<MCPricer> qlPricerFactory::vanillaPayoffPricer(const boost::shared_ptr<FpmlSerialized::VanillaPayoff>& xml_serial)
//{
//	boost::shared_ptr<MCPricer> pricerPtr;
//
//	return pricerPtr;
//
//}

//boost::shared_ptr<MCPricer> qlPricerFactory::vanillaStandardStreamPricer(const boost::shared_ptr<FpmlSerialized::VanillaStandardStreamPayoff>& xml_serial)
//{
//	boost::shared_ptr<MCPricer> pricerPtr;
//
//	const std::vector<boost::shared_ptr<FpmlSerialized::EventTrigger>>& xml_eventTriggerList = xml_serial->getEventTriggerList()->getEventTrigger();
//
//	std::vector<boost::shared_ptr<EventTriggerInfo>> ql_eventTriggerList;
//
//	qlEventTriggerInfoFactory qlETIFactory = qlEventTriggerInfoFactory();
//
//	for(Size i = 0 ; i<xml_eventTriggerList.size(); ++i )
//	{
//		ql_eventTriggerList.push_back( qlETIFactory.eventTriggerInfo(xml_eventTriggerList[i]) );
//	}
//
//	pricerPtr = boost::shared_ptr<MCPricer>(new VanillaStandardStreamPricer(ql_eventTriggerList));
//
//	return pricerPtr;
//}

//boost::shared_ptr<MCPricer> qlPricerFactory::compositeSumOptionPricer(const boost::shared_ptr<FpmlSerialized::CompositeSumOptionPayoff>& xml_serial)
//{
//	boost::shared_ptr<MCPricer> pricerPtr;
//
//	//const boost::shared_ptr<FpmlSerialized::ReferenceCalculation>& xml_referCal = xml_serial->getReferenceCalculation();
//
//	qlFixingDateInfoFactory qlFDF = qlFixingDateInfoFactory();
//
//	boost::shared_ptr<QuantLib::FixingDateInfo> fixingDateInfo 
//				= qlFDF.fixingDateInfo(xml_serial->getFixingDateInfo());
//
//	boost::shared_ptr<QuantLib::FixingDateInfo> payoffDateInfo 
//				= qlFDF.fixingDateInfo(xml_serial->getFixingDateInfo());
//
//	// StandardOptionList ---------------------------------------------------------------------
//
//	const std::vector<boost::shared_ptr<FpmlSerialized::StandardOption>>& xml_standOptionList
//						= xml_serial->getStandardOption();
//
//	std::vector<boost::shared_ptr<QuantLib::EventTriggerInfo>> qlStandOptionList;
//
//	qlEventTriggerInfoFactory qlETIFactory = qlEventTriggerInfoFactory();
//	
//	for (Size i=0 ; i < xml_standOptionList.size() ; i++)
//	{
//		qlStandOptionList.push_back(qlETIFactory.standardOptionETI(xml_standOptionList[i]));
//	}
//
//	pricerPtr = boost::shared_ptr<QuantLib::CompositeSumOptionPricer>(
//						new CompositeSumOptionPricer(fixingDateInfo,
//												     payoffDateInfo,
//												     qlStandOptionList));
//
//	return pricerPtr;
//}

}

//boost::shared_ptr<MCPricer> qlPricerFactory::pricer(const boost::shared_ptr<FpmlSerialized::PayoffInfo>& xml_payoffInfo,
//													const boost::shared_ptr<FpmlSerialized::PricingParameter>& xml_parameter)

//boost::shared_ptr<MCPricer> qlPricerFactory::singlePricer(const boost::shared_ptr<FpmlSerialized::PayoffInfo>& xml_payoffInfo)
//{
//	boost::shared_ptr<MCPricer> pricerPtr;
//
//	std::string pricerType = xml_payoffInfo->getType()->SValue();
//
//	//if ( pricerType == "compositeSumOptionPayoff")
//	//{
//	//	const boost::shared_ptr<FpmlSerialized::CompositeSumOptionPayoff>& xml_composite
//	//						= xml_payoffInfo->getCompositeSumOptionPayoff();
//
//	//	pricerPtr = this->compositeSumOptionPricer(xml_composite);
//	//}
//	if ( pricerType == "autoCallablePayoff")
//	{
//		const boost::shared_ptr<FpmlSerialized::AutoCallablePayoff>& xml_autoCallablePayoff
//							= xml_payoffInfo->getAutoCallablePayoff();
//
//		pricerPtr = this->autoCallablePricer(xml_autoCallablePayoff);
//	}
//	//else if ( pricerType == "stepDownNoKIPayoff")
//	//{
//	//	const boost::shared_ptr<FpmlSerialized::StepDownNoKIPayoff>& xml_stepdownnoki
//	//						= xml_payoffInfo->getStepDownNoKIPayoff();
//
//	//	pricerPtr = this->stepDownNoKIPayoffPricer(xml_stepdownnoki);
//	//}
//	//else if ( pricerType == "stopLossPayoff")
//	//{
//	//	const boost::shared_ptr<FpmlSerialized::StopLossPayoff>& xml_stopLossPayoff
//	//						= xml_payoffInfo->getStopLossPayoff();
//
//	//	pricerPtr = this->stopLossPayoffPricer(xml_stopLossPayoff);
//	//}
//	//else if ( pricerType == "vanillaStandardStreamPayoff")
//	//{
//	//	const boost::shared_ptr<FpmlSerialized::VanillaStandardStreamPayoff>& xml_vanillaStandardStreamPayoff
//	//						= xml_payoffInfo->getVanillaStandardStreamPayoff();
//
//	//	pricerPtr = this->vanillaStandardStreamPricer(xml_vanillaStandardStreamPayoff);
//	//}
//	//else if ( pricerType == "autoCallablePayoff")
//	//{
//	//	const boost::shared_ptr<FpmlSerialized::AutoCallablePayoff>& xml_autoCallablePayoff
//	//						= xml_payoffInfo->getAutoCallablePayoff();
//
//	//	pricerPtr = this->autoCallablePricer(xml_autoCallablePayoff);
//	//}
//
//	//else if ( xml_issueInfo->getType()->SValue() == "optionInfo" )
//	//{
//	//	const boost::shared_ptr<FpmlSerialized::OptionInfo> xml_optionInfo = xml_issueInfo->getOptionInfo();
//
//	//	ql_inst = this->optionInstrument(xml_optionInfo);	
//	//}
//	else 
//	{
//		QL_FAIL("unknown payoffInfoType : " << pricerType );
//	}
//
//	qlVariableInfoFactory qlVIF = qlVariableInfoFactory();
//
//	if ( !xml_payoffInfo->isPreDefinedVariableList() )
//	{
//		std::vector<boost::shared_ptr<QuantLib::VariableInfo>> ql_variableInfoList;
//
//		std::vector<boost::shared_ptr<FpmlSerialized::PreDefinedVariableInfo>> xml_variableInfoList
//			= xml_payoffInfo->getPreDefinedVariableList()->getPreDefinedVariableInfo();
//
//		for ( Size i=0 ; i< xml_variableInfoList.size() ; i++ )
//		{
//			ql_variableInfoList.push_back(qlVIF.preDefinedVariableInfo(xml_variableInfoList[i]));
//		}
//
//		pricerPtr->registVariableInfo(ql_variableInfoList);
//	}
//
//	return pricerPtr;
//
//}

//boost::shared_ptr<MCPricer> qlPricerFactory::swapPricer(const boost::shared_ptr<FpmlSerialized::SwapPayoffInfo>& xml_swapPayoffInfo)
//{
//	boost::shared_ptr<MCPricer> pricerPtr;
//
//	std::string pricerType = xml_swapPayoffInfo->getType()->SValue();
//
//	if ( pricerType == "autoCallableSwapPayoff")
//	{
//		const boost::shared_ptr<FpmlSerialized::AutoCallableSwapPayoff>& xml_autoCallablePayoff
//							= xml_swapPayoffInfo->getAutoCallableSwapPayoff();
//
//		pricerPtr = this->autoCallableSwapPricer(xml_autoCallablePayoff);
//	}
//	//else if ( pricerType == "autoCallablePayoff")
//	//{
//	//	const boost::shared_ptr<FpmlSerialized::AutoCallablePayoff>& xml_autoCallablePayoff
//	//						= xml_payoffInfo->getAutoCallablePayoff();
//
//	//	pricerPtr = this->autoCallablePricer(xml_autoCallablePayoff);
//	//}
//	else 
//	{
//		QL_FAIL("unknown payoffInfoType : " << pricerType );
//	}
//
//	return pricerPtr;
//}

//
//boost::shared_ptr<MCPricer> qlPricerFactory::autoCallablePricer(const boost::shared_ptr<FpmlSerialized::AutoCallablePayoff>& xml_serial)
//{
//	boost::shared_ptr<MCPricer> pricerPtr;
//
//	std::vector<boost::shared_ptr<FpmlSerialized::EventTrigger>> xml_eventTriggerList = xml_serial->getEventTriggerList()->getEventTrigger();
//
//	std::vector<boost::shared_ptr<EventTriggerInfo>> eventTriggerList;
//
//	qlEventTriggerInfoFactory qlETIFactory = qlEventTriggerInfoFactory();
//
//	for(Size i = 0 ; i<xml_eventTriggerList.size(); ++i )
//	{
//		eventTriggerList.push_back( qlETIFactory.eventTriggerInfo(xml_eventTriggerList[i]) );
//	}
//
//	pricerPtr = boost::shared_ptr<AutoCallablePricer>(
//						new AutoCallablePricer(eventTriggerList));
//
//	return pricerPtr;
//
//}

//boost::shared_ptr<MCPricer> qlPricerFactory::autoCallablePricer(const boost::shared_ptr<FpmlSerialized::AutoCallablePayoff>& xml_serial)