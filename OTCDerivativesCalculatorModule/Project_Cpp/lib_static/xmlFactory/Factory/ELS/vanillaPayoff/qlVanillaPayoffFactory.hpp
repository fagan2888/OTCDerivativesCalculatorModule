//#ifndef xmlFactory_qlvanillaPayoffFactory_hpp
//#define xmlFactory_qlvanillaPayoffFactory_hpp
//
//#include <util/xmlUtilHeader.hpp>
//#include <ql/time/date.hpp>
//#include <ql/pricingengine.hpp>
//#include <ql/math/matrix.hpp>
//#include <ql/processes/all.hpp>
//#include <GenClass\RiskMonitor-0-1\all.hpp>
//#include <Factory/Etc/all.hpp>
//#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>
//#include <src/Engine/MonteCarlo/pricer/vanillaPricer.hpp>
//#include <src/Engine/MonteCarlo/MonteEngine.hpp>
//
//#include <ql/handle.hpp>
//
//#include <Factory/instrumentFactory.hpp>
//
//using namespace QuantLib;
//
//namespace XmlFactory {
//
//	class qlVanillaPayoffFactory : public InstrumentFactory {
//		public:
//			qlVanillaPayoffFactory();
//
//			void calculate(const std::string& instInfoStr,
//						   const std::string& paraInfoStr);
//
//		private:
//			boost::shared_ptr<StochasticProcessArray> processArr(TiXmlNode* node);
//			boost::shared_ptr<PricingEngine> engine(boost::shared_ptr<FpmlSerialized::PayoffInfo> xml_payoff);
//			boost::shared_ptr<EventTriggerInfo> standardOption(const boost::shared_ptr<FpmlSerialized::StandardOption>& xml_standardOption);
//
//			void pricer(boost::shared_ptr<FpmlSerialized::PayoffInfo> xml_payoffInfo);
//
//			void factoryVanilla();
//
//			Matrix corrationMatrix(TiXmlNode* node);
//
//			void buildResultXml(std::map<std::string,boost::any> addedResult);
//
//
//		private:
//
//			double notional_;
//			std::vector<std::string> underListCode_;
//			std::vector<Real> basePrices_;
//	};
//}
//
//#endif