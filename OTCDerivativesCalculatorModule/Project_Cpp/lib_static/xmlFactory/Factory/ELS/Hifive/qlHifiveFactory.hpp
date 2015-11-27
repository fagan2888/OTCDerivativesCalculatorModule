#ifndef xmlFactory_qlhifiveFactory_hpp
#define xmlFactory_qlhifiveFactory_hpp

#include <util/xmlUtilHeader.hpp>
#include <ql/time/date.hpp>
#include <ql/pricingengine.hpp>
#include <ql/math/matrix.hpp>
#include <ql/processes/all.hpp>

#include <Factory/instrumentFactory.hpp>

using namespace QuantLib;

namespace XmlFactory {

	class qlHifiveFactory : public InstrumentFactory {
		public:
			qlHifiveFactory();

			const std::string& result()
			{
				return this->result_;
			}

			void calculate(const std::string& instInfoStr,
						   const std::string& paraInfoStr);

			void calculate();


		private:
			boost::shared_ptr<StochasticProcessArray> processArr(TiXmlNode* node);
			boost::shared_ptr<MonteEngine> engine();
			void factoryHifive();
			Matrix corrationMatrix(TiXmlNode* node);

			//void buildResultXml(std::map<std::string,boost::any> addedResult);
			//void buildResultXml();

		private:

			double notional_;
			std::vector<std::string> underListCode_;

	};
}

#endif