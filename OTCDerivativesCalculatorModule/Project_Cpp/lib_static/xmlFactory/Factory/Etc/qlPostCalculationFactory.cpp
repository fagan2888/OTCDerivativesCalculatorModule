#include "qlPostCalculationFactory.hpp"
#include <Factory/Etc/qlOperatorFactory.hpp>

using namespace QuantLib;

namespace XmlFactory {

qlPostCalculationFactory::qlPostCalculationFactory()
{
}

boost::shared_ptr<QuantLib::PostCalculation> qlPostCalculationFactory::postCal(const boost::shared_ptr<FpmlSerialized::PostCalculation>& xml_serial)
{
	boost::shared_ptr<QuantLib::PostCalculation> ql_postCal;

	std::vector<boost::shared_ptr<QuantLib::Operator1D>> ql_operator1DList;

	const std::vector<boost::shared_ptr<FpmlSerialized::Operator1D>>& xml_operator1DList
		 = xml_serial->getOperator1DList()->getOperator1D();

	Size operator1DNum = xml_operator1DList.size();
	
	qlOperatorFactory operFactory = qlOperatorFactory();
	
	for ( Size i=0 ; i<operator1DNum ; i++ )
	{
		ql_operator1DList.push_back(operFactory.operator1D(xml_operator1DList[i]));
	}

	ql_postCal = boost::shared_ptr<QuantLib::PostCalculation>(
					new QuantLib::PostCalculation(ql_operator1DList));

	return ql_postCal;
}

}

