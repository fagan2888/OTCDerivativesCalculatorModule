#include "qlJointSimpleCalculationFactory.hpp"
#include <src/Engine/MonteCarlo/operator/all.hpp>
#include <src/Engine/MonteCarlo/eventCalculation/jointEventCalculation/all.hpp>
#include <Factory/Etc/qlEventCalculationFactory.hpp>

using namespace QuantLib;

namespace XmlFactory {

boost::shared_ptr<QuantLib::JointSimpleCalculation> qlJointSimpleCalculationFactory::jointSimpleCal(const boost::shared_ptr<FpmlSerialized::JointSimpleCalculation>& xml_serial)
{
	boost::shared_ptr<QuantLib::JointSimpleCalculation> ql_jointSimpleCal;

	std::string jointType = xml_serial->getType()->SValue();

	if ( jointType == "andSimpleCal" )
	{
		const boost::shared_ptr<FpmlSerialized::AndSimpleCal>& xml_oper
			= xml_serial->getAndSimpleCal();

		ql_jointSimpleCal = this->andSimpleCal(xml_oper);
	}
	//else if ( jointType == "orSimpleCal" )
	//{
	//	const boost::shared_ptr<FpmlSerialized::OrSimpleCal>& xml_oper
	//		= xml_serial->getOrSimpleCal();

	//	ql_jointSimpleCal = this->orSimpleCal(xml_oper);
	//}
	//else if ( jointType == "atLeastSimpleCal" )
	//{
	//	const boost::shared_ptr<FpmlSerialized::AtLeastSimpleCal>& xml_oper
	//		= xml_serial->getAtLeastSimpleCal();

	//	ql_jointSimpleCal = this->atLeastSimpleCal(xml_oper);
	//}
	//else if ( jointType == "atMostSimpleCal" )
	//{
	//	const boost::shared_ptr<FpmlSerialized::AtMostSimpleCal>& xml_oper
	//		= xml_serial->getAtMostSimpleCal();

	//	ql_jointSimpleCal = this->atMostSimpleCal(xml_oper);
	//}
	//else if ( jointType == "countSimpleCal" )
	//{
	//	const boost::shared_ptr<FpmlSerialized::CountSimpleCal>& xml_oper
	//		= xml_serial->getCountSimpleCal();

	//	ql_jointSimpleCal = this->countSimpleCal(xml_oper);
	//}
	else
	{
		QL_FAIL("unknown jointType : " << jointType);
	}

	return ql_jointSimpleCal;
}


boost::shared_ptr<QuantLib::JointSimpleCalculation> qlJointSimpleCalculationFactory::andSimpleCal(const boost::shared_ptr<FpmlSerialized::AndSimpleCal>& xml_serial)
{
	boost::shared_ptr<QuantLib::JointSimpleCalculation> ql_jointSimpleCal;

	bool pastTF = xml_serial->getPastOcc()->BValue();

	ql_jointSimpleCal = boost::shared_ptr<QuantLib::JointSimpleCalculation>(
								new QuantLib::AndSimpleCal(pastTF));

	return ql_jointSimpleCal;
}

}
