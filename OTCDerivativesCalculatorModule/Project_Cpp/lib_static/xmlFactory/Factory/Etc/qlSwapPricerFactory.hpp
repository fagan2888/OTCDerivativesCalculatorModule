//#ifndef xmlFactory_qlswappricerFactory_hpp
//#define xmlFactory_qlswappricerFactory_hpp
//
//#include <util/xmlUtilHeader.hpp>
//#include <src/Engine/MonteCarlo/MCPricer.hpp>
//#include <GenClass\RiskMonitor-0-1\all.hpp>
//
//using namespace QuantLib;
//
//namespace XmlFactory {
//
//	class qlSwapPricerFactory {
//		public:
//			qlSwapPricerFactory();
//			boost::shared_ptr<MCPricer> pricer(const boost::shared_ptr<FpmlSerialized::SwapPayoffInfo>& xml_payoffInfo,
//											   const boost::shared_ptr<FpmlSerialized::PricingParameter>& xml_parameter);
//
//		private:
//			
//			double notioanlRecieve_;
//			double notionalPay_;
//
//			std::vector<std::string> underListCode_;
//			std::vector<Real> basePrices_;
//
//
//		//----------- detail pricer -----------------------------------------------------------------------------------------------------------------
//		private:
//			boost::shared_ptr<MCPricer> vanillaSwapPricer(const boost::shared_ptr<FpmlSerialized::VanillaSwapPayoff>& xml_serial,
//														  const boost::shared_ptr<FpmlSerialized::PricingParameter>& xml_parameter);
//
//			boost::shared_ptr<MCPricer> autoCallableSwapPricer(const boost::shared_ptr<FpmlSerialized::AutoCallableSwapPayoff>& xml_serial,
//															   const boost::shared_ptr<FpmlSerialized::PricingParameter>& xml_parameter);
//
//
//	};
//}
//
//#endif