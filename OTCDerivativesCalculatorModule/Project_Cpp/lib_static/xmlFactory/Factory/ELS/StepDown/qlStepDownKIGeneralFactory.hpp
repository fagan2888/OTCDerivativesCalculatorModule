//#ifndef xmlFactory_qlStepDownKIgeneralFactory_hpp
//#define xmlFactory_qlStepDownKIgeneralFactory_hpp
//
//#include <xmlFactory/util/xmlUtilHeader.hpp>
//#include <ql/time/date.hpp>
//#include <ql/pricingengine.hpp>
//#include <ql/math/matrix.hpp>
//
//#include <GenClass\RiskMonitor-0-1\all.hpp>
//
//#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>
//
//#include <ql/handle.hpp>
//
//#include <Factory/instrumentFactory.hpp>
//
//#include <ql/processes/stochasticprocessarray.hpp>
//
//using namespace QuantLib;
//
//namespace XmlFactory {
//
//	class qlStepDownKIGeneralFactory : public InstrumentFactory {
//		public:
//			qlStepDownKIGeneralFactory();
//
//			void calculate(const std::string& instInfoStr,
//						   const std::string& paraInfoStr);
//
//
//		private:
//			boost::shared_ptr<EventTriggerInfo> kiEventInfo(const boost::shared_ptr<FpmlSerialized::KiEventInfo>& xml_kiEventInfo);
//			boost::shared_ptr<EventTriggerInfo> nonkiEventInfo(const boost::shared_ptr<FpmlSerialized::NonKiEventInfo>& xml_nonkiEventInfo);
//			std::vector<boost::shared_ptr<EventTriggerInfo>> redemInfo(const boost::shared_ptr<FpmlSerialized::RedemptionInfo>& xml_redemEventInfo);
//
//			boost::shared_ptr<StochasticProcessArray> processArr(TiXmlNode* node);
//			boost::shared_ptr<PricingEngine> engine(boost::shared_ptr<FpmlSerialized::PayoffInfo> xml_payoff);
//			void factoryStepDownKI();
//			
//			void pricer(boost::shared_ptr<FpmlSerialized::PayoffInfo> xml_payoffInfo);
//
//			void buildResultXml(std::map<std::string,boost::any> addedResult);
//
//
//		private:
//
//			double notional_;
//			std::vector<std::string> underListCode_;
//			std::vector<Real> basePrices_;
//
//			
//			
//	};
//}
//
//#endif