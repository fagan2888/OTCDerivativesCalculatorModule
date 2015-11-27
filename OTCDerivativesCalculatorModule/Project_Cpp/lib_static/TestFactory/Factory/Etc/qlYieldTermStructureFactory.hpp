#ifndef xmlFactory_qlYieldTermStructureFactory_hpp
#define xmlFactory_qlYieldTermStructureFactory_hpp

#include <tinyxml/tinyxml.h>
//#include <tinyXPath/xpath_static.h>
#include <vector>
#include <ql/time/date.hpp>
#include <boost/shared_ptr.hpp>
#include <ql/pricingengine.hpp>
#include <ql/math/matrix.hpp>
#include <ql/termstructures/yield/all.hpp>

#include <ql/handle.hpp>

using namespace QuantLib;

namespace XmlFactory {

	class qlYieldTermStructureFactory {
		public:
			qlYieldTermStructureFactory(){}

			Handle<YieldTermStructure> yieldTSHandle(TiXmlNode* node);
			boost::shared_ptr<YieldTermStructure> yieldTSBoost(TiXmlNode* node);
			

			std::string buildTSXml(std::string curveType,
									std::vector<Period> periods,
								   std::vector<Date> dates,
								   std::vector<Time> dateTimes,
								   std::vector<Real> data);

			std::string buildRateDataXml(Period period,Date tenorDate,Real data);
			
		

	};
}

#endif