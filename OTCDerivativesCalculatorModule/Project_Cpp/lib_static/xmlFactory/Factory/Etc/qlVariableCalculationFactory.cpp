#include "qlVariableCalculationFactory.hpp"
#include <Factory/Etc/qlReferenceCalculationFactory.hpp>

using namespace QuantLib;

namespace XmlFactory {

qlVariableCalculationFactory::qlVariableCalculationFactory()
{
}

boost::shared_ptr<QuantLib::VariableCalculation> qlVariableCalculationFactory::variableCal(const boost::shared_ptr<FpmlSerialized::VariableCalculation>& xml_serial)
{
	boost::shared_ptr<QuantLib::VariableCalculation> ql_variableCal;

	//ql_variableCal = boost::shared_ptr<QuantLib::VariableCalculation>(
	//	new VariableCalculation(

	return ql_variableCal;

}


}

