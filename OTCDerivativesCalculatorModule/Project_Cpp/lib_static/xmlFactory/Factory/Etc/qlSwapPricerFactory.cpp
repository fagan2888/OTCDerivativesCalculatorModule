//#include "qlSwapPricerFactory.hpp"
//#include <src/Engine/MonteCarlo/pricer/autoCallableSwapPricer.hpp>
//#include <src/Engine/MonteCarlo/pricer/vanillaSwapPricer.hpp>
//#include <Factory/Etc/all.hpp>
//
//using namespace QuantLib;
//
//namespace XmlFactory {
//
//qlSwapPricerFactory::qlSwapPricerFactory()
//{
//
//}
//
//boost::shared_ptr<MCPricer> qlSwapPricerFactory::pricer(const boost::shared_ptr<FpmlSerialized::SwapPayoffInfo>& xml_payoffInfo,
//														const boost::shared_ptr<FpmlSerialized::PricingParameter>& xml_parameter)
//
//{
//	boost::shared_ptr<MCPricer> pricerPtr;
//
//	std::string pricerType = xml_payoffInfo->getType()->SValue();
//
//	if ( pricerType == "vanillaSwapPayoff")
//	{
//		const boost::shared_ptr<FpmlSerialized::VanillaSwapPayoff>& xml_vanillaSwapPayoff
//							= xml_payoffInfo->getVanillaSwapPayoff();
//
//		pricerPtr = this->vanillaSwapPricer(xml_vanillaSwapPayoff,
//											xml_parameter);
//	}
//	else if ( pricerType == "autoCallableSwapPayoff")
//	{
//		const boost::shared_ptr<FpmlSerialized::AutoCallableSwapPayoff>& xml_autoCallableSwapPayoff
//							= xml_payoffInfo->getAutoCallableSwapPayoff();
//
//		pricerPtr = this->autoCallableSwapPricer(xml_autoCallableSwapPayoff,
//												xml_parameter);
//	}
//	else 
//	{
//		QL_FAIL("unknown payoffInfoType : " << pricerType );
//	}
//
//	return pricerPtr;
//
//}
//
//boost::shared_ptr<MCPricer> qlSwapPricerFactory::vanillaSwapPricer(const boost::shared_ptr<FpmlSerialized::VanillaSwapPayoff>& xml_serial,
//																	const boost::shared_ptr<FpmlSerialized::PricingParameter>& xml_parameter)
//{
//	boost::shared_ptr<MCPricer> pricerPtr;
//
//	boost::shared_ptr<MCPricer> payPricer;
//	boost::shared_ptr<MCPricer> receivePricer;
//
//	const boost::shared_ptr<FpmlSerialized::PaySwapPart>& xml_payPartPayoff = xml_serial->getPaySwapPart();
//	const boost::shared_ptr<FpmlSerialized::RecieveSwapPart>& xml_receivePartPayoff = xml_serial->getRecieveSwapPart();
//	
//	qlPricerFactory qlPF = qlPricerFactory();
//
//	payPricer = qlPF.singlePricer(xml_payPartPayoff->getPayoffInfo());
//	receivePricer = qlPF.singlePricer(xml_receivePartPayoff->getPayoffInfo());
//
//	qlEventTriggerInfoFactory qlETIFactory = qlEventTriggerInfoFactory();
//
//	pricerPtr = boost::shared_ptr<MCPricer>(
//				new VanillaSwapPricer(payPricer,
//									  receivePricer));
//
//	return pricerPtr;
//}
//
//boost::shared_ptr<MCPricer> qlSwapPricerFactory::autoCallableSwapPricer(const boost::shared_ptr<FpmlSerialized::AutoCallableSwapPayoff>& xml_serial,
//																		const boost::shared_ptr<FpmlSerialized::PricingParameter>& xml_parameter)
//{
//	boost::shared_ptr<MCPricer> pricerPtr;
//
//	boost::shared_ptr<MCPricer> payPricer;
//	boost::shared_ptr<MCPricer> receivePricer;
//
//	const boost::shared_ptr<FpmlSerialized::PaySwapPart>& xml_payPartPayoff = xml_serial->getPaySwapPart();
//	const boost::shared_ptr<FpmlSerialized::RecieveSwapPart>& xml_receivePartPayoff = xml_serial->getRecieveSwapPart();
//	
//	qlPricerFactory qlPF = qlPricerFactory();
//
//	payPricer = qlPF.singlePricer(xml_payPartPayoff->getPayoffInfo());
//	receivePricer = qlPF.singlePricer(xml_receivePartPayoff->getPayoffInfo());
//
//	qlEventTriggerInfoFactory qlETIFactory = qlEventTriggerInfoFactory();
//
//	pricerPtr = boost::shared_ptr<MCPricer>(
//				new AutoCallableSwapPricer(payPricer,
//										   receivePricer));
//
//	return pricerPtr;
//}
//
//}
//
