#ifndef xmlFactory_qlCreditDefaultSwapFactory_hpp
#define xmlFactory_qlCreditDefaultSwapFactory_hpp

//#include <tinyxml/tinyxml.h>
//#include <tinyXPath/xpath_static.h>
#include <xmlFactory/util/xmlUtilHeader.hpp>
#include <ql/time/date.hpp>
#include <ql/pricingengine.hpp>
#include <ql/instrument.hpp>
#include <ql/termstructures/all.hpp>
#include <ql/termstructures/credit/all.hpp>
#include <ql/termstructures/credit/copulahazardrate2.hpp>

using namespace QuantLib;

namespace XmlFactory {

	class qlCreditDefaultSwapFactory {
		public:
			qlCreditDefaultSwapFactory(const std::string& instInfoStr,
									const std::string& paraInfoStr);

			const std::string& result()
			{
				return this->result_;
			}

			void calculate();


		private:

			boost::shared_ptr<DefaultProbabilityTermStructure> 
						jointDefaultTs(const std::vector<boost::shared_ptr<HazardRateStructure>>& hazardRates,
										Real corr,Size n = 1 ,Real maximum = 5.0, Size integrationsSteps = 50);

			boost::shared_ptr<DefaultProbabilityTermStructure> defaultTs(TiXmlNode* node);
			boost::shared_ptr<YieldTermStructure> yieldTs(TiXmlNode* node);

			boost::shared_ptr<PricingEngine> engine();
			
			void buildResultXml(std::map<std::string,boost::any> addedResult);


		private:
			boost::shared_ptr<Instrument> inst_;
			std::string instInfo_;
			std::string paraInfo_;
			std::string result_;

	};
}

#endif