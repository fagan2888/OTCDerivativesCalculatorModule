//#ifndef xmlFactory_qlCreditDefaultProductFactory_hpp
//#define xmlFactory_qlCreditDefaultProductFactory_hpp
//
//#include <xmlFactory/util/xmlUtilHeader.hpp>
//#include <ql/time/date.hpp>
//#include <ql/pricingengine.hpp>
//#include <ql/instrument.hpp>
//#include <ql/math/matrix.hpp>
//#include <ql/processes/all.hpp>
//#include <ql/handle.hpp>
//
//#include <Factory/instrumentFactory.hpp>
//
//using namespace QuantLib;
//
//namespace XmlFactory {
//
//	class qlCreditDefaultProductFactory : public InstrumentFactory {
//		public:
//
//			qlCreditDefaultProductFactory(const std::string& instInfoStr,
//										  const std::string& paraInfoStr);
//
//			void calculate(const std::string& instInfoStr,
//						   const std::string& paraInfoStr);
//			void buildqlProduct();
//
//			
//
//		private:
//			
//			boost::shared_ptr<PricingEngine> engine();
//			void buildResultXml(std::map<std::string,boost::any> addedResult);
//
//		private:
//			boost::shared_ptr<QuantLib::Instrument> inst_;
//			boost::shared_ptr<QuantLib::MCPricer> pricer_;
//			boost::shared_ptr<DefaultProbabilityTermStructure> defaultCurve_;
//
//			std::vector<Date> dates_;
//
//			double value_;
//			double notional_;
//
//	};
//
//}
//
//#endif