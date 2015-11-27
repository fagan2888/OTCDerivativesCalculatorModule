#ifndef xmlFactory_qlInstrumentInfoFactory_hpp
#define xmlFactory_qlInstrumentInfoFactory_hpp

#include <util/xmlUtilHeader.hpp>
#include <GenClass\RiskMonitor-0-1\all.hpp>
#include <ql/instrument.hpp>
#include <Factory/instrumentFactory.hpp>

using namespace QuantLib;

namespace XmlFactory {

	//ql_inst와 ql_engine이 묶여서 calculation만 할 수 있는 class를 리턴함.
	class qlInstrumentInfoFactory {
		public:
			qlInstrumentInfoFactory();
			//boost::shared_ptr<QuantLib::InstrumentWithEngine> instrumentInfo(const boost::shared_ptr<FpmlSerialized::InstrumentInfo>& xml_instInfo,
			//														   const boost::shared_ptr<FpmlSerialized::PricingParameter>& xml_pricingPara);
			//boost::shared_ptr<XmlFactory::InstrumentFactory> instFactory(const boost::shared_ptr<FpmlSerialized::Excel_interface>& xml_inst,
			//														   const boost::shared_ptr<FpmlSerialized::Excel_parameter> xml_para);

		private:
			boost::shared_ptr<XmlFactory::InstrumentFactory> hifive(const boost::shared_ptr<FpmlSerialized::Excel_interface> xml_serial,
																	const boost::shared_ptr<FpmlSerialized::Excel_parameter>& xml_pricingPara);

			boost::shared_ptr<XmlFactory::InstrumentFactory> compositeOption(const boost::shared_ptr<FpmlSerialized::Excel_interface> xml_serial,
																			 const boost::shared_ptr<FpmlSerialized::Excel_parameter>& xml_pricingPara);


	};
}

#endif