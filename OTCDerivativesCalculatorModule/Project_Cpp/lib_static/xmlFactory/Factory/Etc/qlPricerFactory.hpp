#ifndef xmlFactory_qlpricerFactory_hpp
#define xmlFactory_qlpricerFactory_hpp

#include <util/xmlUtilHeader.hpp>
#include <src/Engine/MonteCarlo/MCPricer.hpp>
#include <GenClass\RiskMonitor-0-1\all.hpp>

using namespace QuantLib;

namespace XmlFactory {

	class qlPricerFactory {
		public:
			qlPricerFactory();
			//boost::shared_ptr<MCPricer> pricer(const boost::shared_ptr<FpmlSerialized::PayoffInfo>& xml_payoffInfo,
			//								   const boost::shared_ptr<FpmlSerialized::PricingParameter>& xml_parameter = boost::shared_ptr<FpmlSerialized::PricingParameter>());

			//boost::shared_ptr<MCPricer> singlePricer(const boost::shared_ptr<FpmlSerialized::PayoffInfo>& xml_payoffInfo);

			//boost::shared_ptr<MCPricer> swapPricer(const boost::shared_ptr<FpmlSerialized::SwapPayoffInfo>& xml_swapPayoffInfo);

		private:
			double notional_;
			std::vector<std::string> underListCode_;
			std::vector<Real> basePrices_;

		public:
			boost::shared_ptr<MCPricer> pricer(const boost::shared_ptr<FpmlSerialized::Excel_interface>& xml_interface);
			boost::shared_ptr<MCPricer> pricer(const boost::shared_ptr<FpmlSerialized::Excel_swapLeg>& xml_swapLeg);
		//----------- detail pricer -----------------------------------------------------------------------------------------------------------------

		private:
			boost::shared_ptr<MCPricer> excel_hifive(const boost::shared_ptr<FpmlSerialized::Excel_hifive>& xml_serial);
			boost::shared_ptr<MCPricer> excel_structuredBond(const boost::shared_ptr<FpmlSerialized::Excel_structuredBond>& xml_serial);
			boost::shared_ptr<MCPricer> excel_compositeOption(const boost::shared_ptr<FpmlSerialized::Excel_compositeOption>& xml_serial);
			boost::shared_ptr<MCPricer> excel_multiAssetCompositeOption(const boost::shared_ptr<FpmlSerialized::Excel_multiAssetCompositeOption>& xml_serial);

			
			
			//boost::shared_ptr<MCPricer> stepDownKIPayoffPricer(const boost::shared_ptr<FpmlSerialized::StepDownKIPayoff>& xml_serial);
			//boost::shared_ptr<MCPricer> stepDownNoKIPayoffPricer(const boost::shared_ptr<FpmlSerialized::StepDownNoKIPayoff>& xml_serial);
			//boost::shared_ptr<MCPricer> interestRateSwapPayoffPricer(const boost::shared_ptr<FpmlSerialized::InterestRateSwapPayoff>& xml_serial);
			//boost::shared_ptr<MCPricer> stopLossPayoffPricer(const boost::shared_ptr<FpmlSerialized::StopLossPayoff>& xml_serial);
			boost::shared_ptr<MCPricer> vanillaPayoffPricer(const boost::shared_ptr<FpmlSerialized::VanillaPayoff>& xml_serial);

			//boost::shared_ptr<MCPricer> vanillaStandardStreamPricer(const boost::shared_ptr<FpmlSerialized::VanillaStandardStreamPayoff>& xml_serial);
			//boost::shared_ptr<MCPricer> compositeSumOptionPricer(const boost::shared_ptr<FpmlSerialized::CompositeSumOptionPayoff>& xml_serial);

		//----------- detail swapPricer -----------------------------------------------------------------------------------------------------------------
		private:
			//boost::shared_ptr<MCPricer> autoCallableSwapPricer(const boost::shared_ptr<FpmlSerialized::AutoCallableSwapPayoff>& xml_serial);
	};
}

#endif