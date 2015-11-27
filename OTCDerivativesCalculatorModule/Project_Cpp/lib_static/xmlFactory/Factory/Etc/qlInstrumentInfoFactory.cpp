#include "qlInstrumentInfoFactory.hpp"
#include <src/Engine/MonteCarlo/instrument/all.hpp>
#include <Factory/Etc/all.hpp>
#include <Factory/instrumentFactory.hpp>
#include <Factory/ELS/Hifive/qlHifiveFactory.hpp>
#include <Factory/ELS/CompositeOption/qlCompositeOptionFactory.hpp>

using namespace QuantLib;

namespace XmlFactory {

qlInstrumentInfoFactory::qlInstrumentInfoFactory()
{

}

//boost::shared_ptr<XmlFactory::InstrumentFactory> qlInstrumentInfoFactory::instFactory(const boost::shared_ptr<FpmlSerialized::Excel_interface>& xml_inst,
//																	   const boost::shared_ptr<FpmlSerialized::Excel_parameter> xml_para)
//{
//	boost::shared_ptr<InstrumentFactory> instFactory;
//	
//	std::string instInfoType = xml_inst->getExcel_type()->SValue();
//
//	if ( instInfoType == "excel_hifive")
//	{
//		//const boost::shared_ptr<FpmlSerialized::Excel_hifive> xml_serial = xml_inst->getExcel_hifive();
//
//		instFactory = this->hifive(xml_inst,xml_para);
//	}
//	else if ( instInfoType == "excel_compositeOption")
//	{
//		instFactory = this->compositeOption(xml_inst,xml_para);
//	}
//	else 
//	{
//		QL_FAIL("unknown varType : " << instInfoType);		
//	}
//
//	return instFactory;
//}

boost::shared_ptr<XmlFactory::InstrumentFactory> qlInstrumentInfoFactory::hifive(const boost::shared_ptr<FpmlSerialized::Excel_interface> xml_serial,
																			 const boost::shared_ptr<FpmlSerialized::Excel_parameter>& xml_pricingPara)
{
	boost::shared_ptr<XmlFactory::qlHifiveFactory> ql_hifive = 
		boost::shared_ptr<XmlFactory::qlHifiveFactory>(new qlHifiveFactory());
	
	return ql_hifive;

}

boost::shared_ptr<XmlFactory::InstrumentFactory> qlInstrumentInfoFactory::compositeOption(const boost::shared_ptr<FpmlSerialized::Excel_interface> xml_serial,
																			 const boost::shared_ptr<FpmlSerialized::Excel_parameter>& xml_pricingPara)
{
	boost::shared_ptr<XmlFactory::qlCompositeOptionFactory> ql_compOption = 
		boost::shared_ptr<XmlFactory::qlCompositeOptionFactory>(new qlCompositeOptionFactory());
	
	return ql_compOption;

}

//boost::shared_ptr<QuantLib::InstrumentWithEngine> qlInstrumentInfoFactory::
//	standardSwapInstrument(const boost::shared_ptr<FpmlSerialized::StandardSwapInstrument> xml_serial,
//						   const boost::shared_ptr<FpmlSerialized::PricingParameter>& xml_pricingPara)
//{
//	boost::shared_ptr<QuantLib::InstrumentWithEngine> xf_inst;
//
//	const boost::shared_ptr<FpmlSerialized::IssueInformation>& xml_issueInfo = 
//		xml_serial->getIssueInformation();
//
//	qlInstrumentFactory issueInfoFactory = qlInstrumentFactory();
//	qlPricingEngineFactory engineFactory = qlPricingEngineFactory();
//
//	boost::shared_ptr<QuantLib::Instrument> inst = issueInfoFactory.instrument(xml_issueInfo);
//	boost::shared_ptr<QuantLib::PricingEngine> pricingEngine = 
//		engineFactory.standardSwapInstPricingEngine(xml_serial,xml_pricingPara);
//
//	// engine -----------------------------------------------------------------------------------------------
//
//	//inst->setPricingEngine(pricingEngine);
//
//	xf_inst = boost::shared_ptr<QuantLib::InstrumentWithEngine>(
//						new QuantLib::InstrumentWithEngine(inst,pricingEngine));
//
//	return xf_inst;
//}

}

