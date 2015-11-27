#include "qlVariableEventInfoFactory.hpp"
#include <src/Engine/MonteCarlo/VariableInfo/nullVariableEventInfo.hpp>
#include <src/Engine/MonteCarlo/VariableInfo/overWriteVariableEventInfo.hpp>

using namespace QuantLib;

namespace XmlFactory {

boost::shared_ptr<QuantLib::VariableEventInfo> qlVariableEventInfoFactory::variableEventInfo(const boost::shared_ptr<FpmlSerialized::VariableEventInfo>& xml_serial)
{
	boost::shared_ptr<QuantLib::VariableEventInfo> ql_var;

	std::string varType = xml_serial->getType()->SValue();

	if ( varType == "nullVariableEventInfo" )
	{
		const boost::shared_ptr<FpmlSerialized::NullVariableEventInfo>& xml_var
			= xml_serial->getNullVariableEventInfo();

		ql_var = this->nullVariableEventInfo();
	}
	else if ( varType == "overWriteVariableEventInfo" )
	{
		const boost::shared_ptr<FpmlSerialized::OverWriteVariableEventInfo>& xml_var
			= xml_serial->getOverWriteVariableEventInfo();

		ql_var = this->overWriteVariableEventInfo(xml_var);
	}
	else
	{
		QL_FAIL("unknown varType : " << varType);
	}

	return ql_var;
}

boost::shared_ptr<QuantLib::VariableEventInfo> qlVariableEventInfoFactory::nullVariableEventInfo()
{
	boost::shared_ptr<QuantLib::VariableEventInfo> ql_var;

	ql_var = boost::shared_ptr<QuantLib::VariableEventInfo>(
		new NullVariableEventInfo());

	return ql_var;

}

boost::shared_ptr<QuantLib::VariableEventInfo> qlVariableEventInfoFactory::overWriteVariableEventInfo(const boost::shared_ptr<FpmlSerialized::OverWriteVariableEventInfo>& xml_serial)
{
	boost::shared_ptr<QuantLib::VariableEventInfo> ql_var;

	const std::string& usingRefVarName = xml_serial->getUsingRefVarName()->SValue();
	const std::string& refInstanceName = xml_serial->getRefInstanceName()->SValue();
	bool initialTF = xml_serial->getInitialTF()->BValue();

	ql_var = boost::shared_ptr<QuantLib::VariableEventInfo>(
		new OverWriteVariableEventInfo(usingRefVarName,refInstanceName,initialTF));

	return ql_var;

}

}
