//#ifndef xmlFactory_qlPricingEngineFactory_hpp
//#define xmlFactory_qlPricingEngineFactory_hpp
//
//#include <util/xmlUtilHeader.hpp>
//#include <GenClass\RiskMonitor-0-1\all.hpp>
//#include <ql/instrument.hpp>
//
//using namespace QuantLib;
//
//namespace XmlFactory {
//
//	class qlPricingEngineFactory {
//		public:
//			qlPricingEngineFactory();
//			
//			boost::shared_ptr<QuantLib::PricingEngine> pricingEngine(const boost::shared_ptr<FpmlSerialized::InstrumentInfo>& xml_instInfo,
//																	 const boost::shared_ptr<FpmlSerialized::Excel_parameter>& xml_para);
//
//			boost::shared_ptr<QuantLib::PricingEngine> standardInstPricingEngine(const boost::shared_ptr<FpmlSerialized::StandardInstrument>& xml_standInst,
//																				 const boost::shared_ptr<FpmlSerialized::PricingParameter>& xml_pricingPara);
//
//			boost::shared_ptr<QuantLib::PricingEngine> standardSwapInstPricingEngine(const boost::shared_ptr<FpmlSerialized::StandardSwapInstrument>& xml_standSwapInst,
//																				 const boost::shared_ptr<FpmlSerialized::PricingParameter>& xml_pricingPara);
//
//			
//
//	/*		double notional_;
//			std::vector<std::string> underListCode_;
//			std::vector<Real> basePrices_;*/
//
//		//----------- detail issueInfo -----------------------------------------------------------------------------------------------------------------
//		private:
//
//			boost::shared_ptr<QuantLib::PricingEngine> monteCalroEngine(const boost::shared_ptr<FpmlSerialized::InstrumentInfo>& xml_instInfo,
//																	 const boost::shared_ptr<FpmlSerialized::PricingParameter>& xml_pricingPara);
//
//
//
//	};
//}
//
//#endif