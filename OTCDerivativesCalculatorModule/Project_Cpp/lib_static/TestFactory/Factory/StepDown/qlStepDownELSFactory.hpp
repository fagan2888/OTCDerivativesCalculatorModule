#ifndef xmlFactory_qlStepDownELSFactory_hpp
#define xmlFactory_qlStepDownELSFactory_hpp

//#include <tinyxml/tinyxml.h>
//#include <tinyXPath/xpath_static.h>
#include <xmlFactory/util/xmlUtilHeader.hpp>
#include <ql/time/date.hpp>
#include <ql/pricingengine.hpp>
#include <ql/instrument.hpp>
#include <ql/math/matrix.hpp>
#include <ql/processes/all.hpp>

#include <ql/testClass/MCELSGeneralEngine.hpp>
#include <ql/handle.hpp>

using namespace QuantLib;

namespace XmlFactory {

	class qlStepDownELSFactory {
		public:
			qlStepDownELSFactory(const std::string& instInfoStr,
								 const std::string& paraInfoStr);

			const std::string& result()
			{
				return this->result_;
			}

			void calculate();


		private:
			std::vector<double> kiTrigger(TiXmlNode* node);
			double nonkiTrigger(TiXmlNode* node);
			//Handle<YieldTermStructure> discountTS(TiXmlNode* node);
			boost::shared_ptr<StochasticProcessArray> processArr(TiXmlNode* node);
			boost::shared_ptr<PricingEngine> engine();
			void factoryStepDownKI();
			Matrix corrationMatrix(TiXmlNode* node);
			
			void buildResultXml(std::map<std::string,boost::any> addedResult);


		private:
			boost::shared_ptr<Instrument> inst_;
			std::string instInfo_;
			std::string paraInfo_;
			std::string result_;

	};
}

#endif