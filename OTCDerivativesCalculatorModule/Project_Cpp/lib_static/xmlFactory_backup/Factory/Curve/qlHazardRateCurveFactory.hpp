#ifndef xmlFactory_qlHazardRateFactory_hpp
#define xmlFactory_qlHazardRateFactory_hpp

#include <xmlFactory/util/xmlUtilHeader.hpp>
#include <ql/time/date.hpp>
#include <ql/pricingengine.hpp>
#include <ql/instrument.hpp>
#include <ql/math/matrix.hpp>

#include <ql/handle.hpp>

using namespace QuantLib;

namespace XmlFactory {

	class qlHazardRateFactory {
		public:
			qlHazardRateFactory(const std::string& instInfoStr,
								const std::string& paraInfoStr);

			const std::string& result()
			{
				return this->result_;
			}

			void calculate();


		private:
			
			boost::shared_ptr<HazardRateStructure> hazardRateTS(TiXmlNode* node);					
			//Matrix corrationMatrix(TiXmlNode* node);
			
			void buildResultXml(std::map<std::string,boost::any> addedResult);
			void buildResultXml();

		private:
			boost::shared_ptr<Instrument> inst_;
			std::string instInfo_;
			std::string paraInfo_;
			std::string result_;
			Handle<YieldTermStructure> tsCurve_;

		private:
			std::vector<Period> outputTenors_;
			std::vector<Date> dates_;
			std::vector<Time> dateTimes_;
			std::vector<Real> data_;

	};
}

#endif