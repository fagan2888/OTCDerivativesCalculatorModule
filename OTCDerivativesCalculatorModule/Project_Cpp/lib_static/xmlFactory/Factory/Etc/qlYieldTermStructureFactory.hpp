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
#include <GenClass\RiskMonitor-0-1\all.hpp>
#include <ql/handle.hpp>


using namespace QuantLib;

namespace XmlFactory {

	class qlYieldTermStructureFactory {
		public:
			qlYieldTermStructureFactory(){}

			//Handle<YieldTermStructure> yieldTSHandle(boost::shared_ptr<FpmlSerialized::YieldTermstructure> xml_yieldTS);
			//boost::shared_ptr<YieldTermStructure> yieldTSBoost(TiXmlNode* node);
			boost::shared_ptr<YieldTermStructure> e_yieldTSBoost(const boost::shared_ptr<FpmlSerialized::Excel_yieldCurve>& xml_yieldTS);
			
			std::vector<boost::shared_ptr<YieldTermStructure>> e_yieldTermStructureList(const boost::shared_ptr<FpmlSerialized::Excel_discountCurve_para>& xml_discountCurve_para);

		private:
			std::string buildTSXml(std::string curveType,
									std::vector<Period> periods,
								   std::vector<Date> dates,
								   std::vector<Time> dateTimes,
								   std::vector<Real> data);

			std::string buildRateDataXml(Period period,Date tenorDate,Real data);
			
		

	};
}

#endif