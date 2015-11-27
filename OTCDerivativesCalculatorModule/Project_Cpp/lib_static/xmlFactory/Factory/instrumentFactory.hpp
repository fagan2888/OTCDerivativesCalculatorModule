#ifndef xmlFactory_instrumentFactory_hpp
#define xmlFactory_instrumentFactory_hpp

#include <src/Engine/MonteCarlo/MCPricer.hpp>
#include <util/convertFunction.hpp>
#include <GenClass\RiskMonitor-0-1\all.hpp>
#include <src/Instrument/instrumentWithEngine.hpp>
#include <src/Engine/MonteCarlo/MonteEngine.hpp>

using namespace QuantLib;

namespace XmlFactory {

	class InstrumentFactory 
	{
		public:
			InstrumentFactory() {}

			void setInstrument(const boost::shared_ptr<FpmlSerialized::ProductInnerXml>& xml_productInnerXml);

			void setInstrument(const std::string& instInfoStr,
							const std::string& paraInfoStr,
							const std::string& historyInfoStr);

			virtual const std::string& result(){ return this->result_; }
			
			const std::string& getKRCode();
			const double getPrice();
			const double getValue();
			const std::string& getDebugLog();

			void historyDataLoad();
			void buildResultXml();

			boost::shared_ptr<MonteEngine> engine() { return this->engine_; } 

			virtual void calculate() { }

		protected:
			

			virtual void calculate(const std::string& instInfoStr,
						   const std::string& paraInfoStr) { }

		protected:
			int loadDocument();

		protected:
			boost::shared_ptr<InstrumentFactory> InstFactory_;

			boost::shared_ptr<MCPricer> pricer_;
			boost::shared_ptr<MonteEngine> engine_;

			boost::shared_ptr<QuantLib::Instrument> instrument_;

			std::string instInfo_;
			std::string paraInfo_;
			std::string historyInfo_;
			std::string result_;
			//std::string debugLog_;

			std::string krCode_;
			double price_;
			double value_;

			TiXmlDocument instDocument_;
			TiXmlDocument paraDocument_;
			TiXmlDocument historyDocument_;

			boost::shared_ptr<FpmlSerialized::ProductInnerXml> xml_productInnerXml_;

			boost::shared_ptr<FpmlSerialized::Instrument> xml_instrument_;
			boost::shared_ptr<FpmlSerialized::Pricing> xml_pricing_;
			boost::shared_ptr<FpmlSerialized::HisoryData> xml_history_;

	};
}

#endif