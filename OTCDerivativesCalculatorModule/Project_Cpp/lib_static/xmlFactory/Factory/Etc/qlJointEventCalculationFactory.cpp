#include "qlJointEventCalculationFactory.hpp"
#include <src/Engine/MonteCarlo/operator/all.hpp>
#include <src/Engine/MonteCarlo/eventCalculation/jointEventCalculation/all.hpp>
#include <Factory/Etc/qlEventCalculationFactory.hpp>

using namespace QuantLib;

namespace XmlFactory {

boost::shared_ptr<QuantLib::JointEventCalculation> qlJointEventCalculationFactory::jointEventCal(const boost::shared_ptr<FpmlSerialized::JointEventCalculation>& xml_serial)
{
	boost::shared_ptr<QuantLib::JointEventCalculation> ql_jointEventCal;

	std::string jointType = xml_serial->getType()->SValue();

	if ( jointType == "andEventCal" )
	{
		const boost::shared_ptr<FpmlSerialized::AndEventCal>& xml_oper
			= xml_serial->getAndEventCal();

		ql_jointEventCal = this->andEventCal(xml_oper);
	}
	else if ( jointType == "orEventCal" )
	{
		const boost::shared_ptr<FpmlSerialized::OrEventCal>& xml_oper
			= xml_serial->getOrEventCal();

		ql_jointEventCal = this->orEventCal(xml_oper);
	}
	else if ( jointType == "atLeastEventCal" )
	{
		const boost::shared_ptr<FpmlSerialized::AtLeastEventCal>& xml_oper
			= xml_serial->getAtLeastEventCal();

		ql_jointEventCal = this->atLeastEventCal(xml_oper);
	}
	else if ( jointType == "atMostEventCal" )
	{
		const boost::shared_ptr<FpmlSerialized::AtMostEventCal>& xml_oper
			= xml_serial->getAtMostEventCal();

		ql_jointEventCal = this->atMostEventCal(xml_oper);
	}
	else if ( jointType == "countEventCal" )
	{
		const boost::shared_ptr<FpmlSerialized::CountEventCal>& xml_oper
			= xml_serial->getCountEventCal();

		ql_jointEventCal = this->countEventCal(xml_oper);
	}
	else
	{
		QL_FAIL("unknown jointType : " << jointType);
	}

	return ql_jointEventCal;
}


boost::shared_ptr<QuantLib::JointEventCalculation> andEventCal(const boost::shared_ptr<FpmlSerialized::AndEventCal>& xml_serial)
{
	boost::shared_ptr<QuantLib::JointEventCalculation> ql_jointEventCal;

	std::vector<boost::shared_ptr<QuantLib::EventCalculation>> ql_eventCalList;

	const std::vector<boost::shared_ptr<FpmlSerialized::EventCalculation>>& xml_eventCalList
			= xml_serial->getEventCalculationList()->getEventCalculation();

	qlEventCalculationFactory qlECF = qlEventCalculationFactory();

	for ( Size i=0;i<xml_eventCalList.size();i++)
	{
		ql_eventCalList.push_back(qlECF.eventCal(xml_eventCalList[i]));
	}

	ql_jointEventCal = boost::shared_ptr<QuantLib::JointEventCalculation>(
								new QuantLib::AndEventCal(ql_eventCalList));

	return ql_jointEventCal;
}

boost::shared_ptr<QuantLib::JointEventCalculation> orEventCal(const boost::shared_ptr<FpmlSerialized::OrEventCal>& xml_serial)
{
	boost::shared_ptr<QuantLib::JointEventCalculation> ql_jointEventCal;

	std::vector<boost::shared_ptr<QuantLib::EventCalculation>> ql_eventCalList;

	const std::vector<boost::shared_ptr<FpmlSerialized::EventCalculation>>& xml_eventCalList
			= xml_serial->getEventCalculationList()->getEventCalculation();

	qlEventCalculationFactory qlECF = qlEventCalculationFactory();

	for ( Size i=0;i<xml_eventCalList.size();i++)
	{
		ql_eventCalList.push_back(qlECF.eventCal(xml_eventCalList[i]));
	}

	ql_jointEventCal = boost::shared_ptr<QuantLib::JointEventCalculation>(
								new QuantLib::OrEventCal(ql_eventCalList));

	return ql_jointEventCal;
}
boost::shared_ptr<QuantLib::JointEventCalculation> atLeastEventCal(const boost::shared_ptr<FpmlSerialized::AtLeastEventCal>& xml_serial)
{
	boost::shared_ptr<QuantLib::JointEventCalculation> ql_jointEventCal;

	std::vector<boost::shared_ptr<QuantLib::EventCalculation>> ql_eventCalList;

	const std::vector<boost::shared_ptr<FpmlSerialized::EventCalculation>>& xml_eventCalList
			= xml_serial->getEventCalculationList()->getEventCalculation();

	Size num = xml_serial->getNum()->IValue();

	qlEventCalculationFactory qlECF = qlEventCalculationFactory();

	for ( Size i=0;i<xml_eventCalList.size();i++)
	{
		ql_eventCalList.push_back(qlECF.eventCal(xml_eventCalList[i]));
	}

	ql_jointEventCal = boost::shared_ptr<QuantLib::JointEventCalculation>(
								new QuantLib::AtLeastEventCal(num,
															  ql_eventCalList));

	return ql_jointEventCal;
}

boost::shared_ptr<QuantLib::JointEventCalculation> atMostEventCal(const boost::shared_ptr<FpmlSerialized::AtMostEventCal>& xml_serial)
{
	boost::shared_ptr<QuantLib::JointEventCalculation> ql_jointEventCal;

	std::vector<boost::shared_ptr<QuantLib::EventCalculation>> ql_eventCalList;

	const std::vector<boost::shared_ptr<FpmlSerialized::EventCalculation>>& xml_eventCalList
			= xml_serial->getEventCalculationList()->getEventCalculation();

	Size num = xml_serial->getNum()->IValue();

	qlEventCalculationFactory qlECF = qlEventCalculationFactory();

	for ( Size i=0;i<xml_eventCalList.size();i++)
	{
		ql_eventCalList.push_back(qlECF.eventCal(xml_eventCalList[i]));
	}

	ql_jointEventCal = boost::shared_ptr<QuantLib::JointEventCalculation>(
								new QuantLib::AtMostEventCal(num,
															 ql_eventCalList));

	return ql_jointEventCal;
}

boost::shared_ptr<QuantLib::JointEventCalculation> countEventCal(const boost::shared_ptr<FpmlSerialized::CountEventCal>& xml_serial)
{
	boost::shared_ptr<QuantLib::JointEventCalculation> ql_jointEventCal;

	std::vector<boost::shared_ptr<QuantLib::EventCalculation>> ql_eventCalList;

	const std::vector<boost::shared_ptr<FpmlSerialized::EventCalculation>>& xml_eventCalList
			= xml_serial->getEventCalculationList()->getEventCalculation();

	Size num = xml_serial->getNum()->IValue();

	qlEventCalculationFactory qlECF = qlEventCalculationFactory();

	for ( Size i=0;i<xml_eventCalList.size();i++)
	{
		ql_eventCalList.push_back(qlECF.eventCal(xml_eventCalList[i]));
	}

	ql_jointEventCal = boost::shared_ptr<QuantLib::JointEventCalculation>(
								new QuantLib::CountEventCal(num,
															 ql_eventCalList));

	return ql_jointEventCal;
}

}
