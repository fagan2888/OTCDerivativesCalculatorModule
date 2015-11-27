#include "qlFixingDateInfoFactory.hpp"
#include <src/Engine/MonteCarlo/fixedFixingDateInfo.hpp>
#include <src/Engine/MonteCarlo/refVariableFixingDateInfo.hpp>
#include <src/Engine/MonteCarlo/nullFixingDateInfo.hpp>

namespace XmlFactory {

qlFixingDateInfoFactory::qlFixingDateInfoFactory()
{

}

boost::shared_ptr<QuantLib::FixingDateInfo> qlFixingDateInfoFactory::fixingDateInfo(const boost::shared_ptr<FpmlSerialized::FixingDateInfo>& xml_serial)
{
	boost::shared_ptr<QuantLib::FixingDateInfo> ql_fixing;

	const std::string& typeStr = xml_serial->getType()->SValue();

	if ( typeStr == "fixedFixingDateInfo")
	{
		const boost::shared_ptr<FpmlSerialized::FixedFixingDateInfo> xml_fixedFixingInfo = xml_serial->getFixedFixingDateInfo();

		ql_fixing = this->fixedFixingDateInfo(xml_fixedFixingInfo);
	}
	else if ( typeStr == "refVariableFixingDateInfo" )
	{
		const boost::shared_ptr<FpmlSerialized::RefVariableFixingDateInfo> xml_refVarFixingInfo = xml_serial->getRefVariableFixingDateInfo();

		ql_fixing = this->refVarFixingDateInfo(xml_refVarFixingInfo);	
	}
	else if ( typeStr == "nullFixingDateInfo" )
	{
		const boost::shared_ptr<FpmlSerialized::NullFixingDateInfo> xml_nullFixingInfo = xml_serial->getNullFixingDateInfo();

		ql_fixing = this->nullFixingDateInfo(xml_nullFixingInfo);	
	}
	else 
	{
		QL_FAIL("unknown type str");
	}

	return ql_fixing;
}
boost::shared_ptr<QuantLib::FixingDateInfo> qlFixingDateInfoFactory::fixingDateInfo(QuantLib::Date date)
{
	boost::shared_ptr<QuantLib::FixingDateInfo> ql_fixing;

	ql_fixing = boost::shared_ptr<QuantLib::FixingDateInfo>(
		new QuantLib::FixedFixingDateInfo(date,false,date));

	return ql_fixing;
}

boost::shared_ptr<QuantLib::FixingDateInfo> qlFixingDateInfoFactory::fixedFixingDateInfo(const boost::shared_ptr<FpmlSerialized::FixedFixingDateInfo>& xml_serial)
{
	boost::shared_ptr<QuantLib::FixingDateInfo> ql_fixing;

	Date fixedFixingDate = xml_serial->getDate()->dateValue();
	
	bool autoCallFlag = xml_serial->getAutoCallFlag()->BValue();
	Date autoCallFixingDate = Date();

	if ( autoCallFlag )
	{
		autoCallFixingDate = xml_serial->getAutoCallFixingDate()->dateValue();
	}

	ql_fixing = boost::shared_ptr<QuantLib::FixingDateInfo>(
							new QuantLib::FixedFixingDateInfo(fixedFixingDate,
															  autoCallFlag,
															  autoCallFixingDate));

	return ql_fixing;
}

boost::shared_ptr<QuantLib::FixingDateInfo> qlFixingDateInfoFactory::refVarFixingDateInfo(const boost::shared_ptr<FpmlSerialized::RefVariableFixingDateInfo>& xml_serial)
{
	boost::shared_ptr<QuantLib::FixingDateInfo> ql_fixing;

	const std::string& refVarName = xml_serial->getRefDateName()->SValue();

	ql_fixing = boost::shared_ptr<QuantLib::FixingDateInfo>(new QuantLib::RefVariableFixingDateInfo(refVarName));

	return ql_fixing;
}

boost::shared_ptr<QuantLib::FixingDateInfo> qlFixingDateInfoFactory::nullFixingDateInfo(const boost::shared_ptr<FpmlSerialized::NullFixingDateInfo>& xml_serial)
{
	boost::shared_ptr<QuantLib::FixingDateInfo> ql_fixing;

	ql_fixing = boost::shared_ptr<QuantLib::FixingDateInfo>(
			new QuantLib::NullFixingDateInfo());

	return ql_fixing;
}

}

