#include "qlPreEventCalculationFactory.hpp"
#include <Factory/Etc/all.hpp>

using namespace QuantLib;

namespace XmlFactory {

qlPreEventCalculationFactory::qlPreEventCalculationFactory()
{
}

boost::shared_ptr<QuantLib::PreEventCalculation> qlPreEventCalculationFactory::
	preEventCal(const boost::shared_ptr<FpmlSerialized::PreEventCalculation>& xml_serial)
{
	boost::shared_ptr<QuantLib::PreEventCalculation> ql_preEventCal;


	return ql_preEventCal;
}

}

