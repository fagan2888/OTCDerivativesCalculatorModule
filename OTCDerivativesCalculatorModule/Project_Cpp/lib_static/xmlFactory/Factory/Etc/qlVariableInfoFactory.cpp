#include "qlVariableInfoFactory.hpp"
#include <src/Engine/MonteCarlo/VariableInfo/nullVariableInfo.hpp>
#include <src/Engine/MonteCarlo/VariableInfo/overWriteVariableInfo.hpp>
#include <src/Engine/MonteCarlo/VariableInfo/additionVariableInfo.hpp>
#include <src/Engine/MonteCarlo/VariableInfo/resetVariableInfo.hpp>
#include <src/Engine/MonteCarlo/VariableInfo/predefinedVariableInfo.hpp>
#include <src/Engine/MonteCarlo/VariableInfo/definedVariableInfo.hpp>
#include <Factory/Etc/qlFixingInformationFactory.hpp>

using namespace QuantLib;

namespace XmlFactory {

boost::shared_ptr<QuantLib::VariableInfo> qlVariableInfoFactory::variableInfo(const boost::shared_ptr<FpmlSerialized::VariableInfo>& xml_serial)
{
	boost::shared_ptr<QuantLib::VariableInfo> ql_var;

	std::string varType = xml_serial->getType()->SValue();

	if ( varType == "additionVariableInfo" )
	{
		const boost::shared_ptr<FpmlSerialized::AdditionVariableInfo>& xml_var
			= xml_serial->getAdditionVariableInfo();

		ql_var = this->additionVariableInfo(xml_var);
	}
	else if ( varType == "nullVariableEventInfo" )
	{
		const boost::shared_ptr<FpmlSerialized::NullVariableInfo>& xml_var
			= xml_serial->getNullVariableInfo();

		ql_var = this->nullVariableInfo();
	}
	else if ( varType == "overWriteVariableEventInfo" )
	{
		const boost::shared_ptr<FpmlSerialized::OverWriteVariableInfo>& xml_var
			= xml_serial->getOverWriteVariableInfo();

		ql_var = this->overWriteVariableInfo(xml_var);

	}
	else if ( varType == "preDefinedVariableInfo" )
	{
		const boost::shared_ptr<FpmlSerialized::PreDefinedVariableInfo>& xml_var
			= xml_serial->getPreDefinedVariableInfo();

		ql_var = this->preDefinedVariableInfo(xml_var);

	}
	else if ( varType == "dfinedVariableInfo" )
	{
		const boost::shared_ptr<FpmlSerialized::DefinedVariableInfo>& xml_var
			= xml_serial->getDefinedVariableInfo();

		ql_var = this->definedVariableInfo(xml_var);

	}
	else
	{
		QL_FAIL("unknown varType : " << varType);
	}

	return ql_var;
}

boost::shared_ptr<QuantLib::VariableInfo> qlVariableInfoFactory::nullVariableInfo()
{
	boost::shared_ptr<QuantLib::VariableInfo> ql_var;
	
	ql_var = boost::shared_ptr<QuantLib::VariableInfo>(
			new NullVariableInfo());

	return ql_var;

}

boost::shared_ptr<QuantLib::VariableInfo> qlVariableInfoFactory::overWriteVariableInfo(const boost::shared_ptr<FpmlSerialized::OverWriteVariableInfo>& xml_serial)
{
	boost::shared_ptr<QuantLib::VariableInfo> ql_var;

	const std::string& usingRefVarName = xml_serial->getUsingRefVarName()->SValue();
	const std::string& refInstanceName = xml_serial->getRefInstanceName()->SValue();
	//Real initialValue = this->fixingValue( xml_serial->getFixingInformation() );
	bool saveFlag = xml_serial->getSave()->BValue();

	ql_var = boost::shared_ptr<QuantLib::VariableInfo>(
		new OverWriteVariableInfo(usingRefVarName,
								refInstanceName,
								//initialValue,
								saveFlag ));

	return ql_var;

}

boost::shared_ptr<QuantLib::VariableInfo> qlVariableInfoFactory::additionVariableInfo(const boost::shared_ptr<FpmlSerialized::AdditionVariableInfo>& xml_serial)
{
	boost::shared_ptr<QuantLib::VariableInfo> ql_var;
	
	const std::string& usingRefVarName = xml_serial->getUsingRefVarName()->SValue();
	const std::string& refInstanceName = xml_serial->getRefInstanceName()->SValue();
	//Real initialValue = this->fixingValue( xml_serial->getFixingInformation() );
	bool saveFlag = xml_serial->getSave()->BValue();

	ql_var = boost::shared_ptr<QuantLib::VariableInfo>(
		new AdditionVariableInfo(usingRefVarName,
								refInstanceName,
								//initialValue,
								saveFlag ));

	return ql_var;

}

boost::shared_ptr<QuantLib::VariableInfo> qlVariableInfoFactory::resetVariableInfo(const boost::shared_ptr<FpmlSerialized::ResetVariableInfo>& xml_serial)
{
	boost::shared_ptr<QuantLib::VariableInfo> ql_var;

	const std::string& refInstanceName = xml_serial->getRefInstanceName()->SValue();
	Real resetValue = this->fixingValue( xml_serial->getFixingInformation() );

	ql_var = boost::shared_ptr<QuantLib::VariableInfo>(
		new ResetVariableInfo(refInstanceName,resetValue));

	return ql_var;

}

boost::shared_ptr<QuantLib::VariableInfo> qlVariableInfoFactory::preDefinedVariableInfo(const boost::shared_ptr<FpmlSerialized::PreDefinedVariableInfo>& xml_serial)
{
	boost::shared_ptr<QuantLib::VariableInfo> ql_var;

	const std::string& refInstanceName = xml_serial->getRefInstanceName()->SValue();

	const boost::shared_ptr<FpmlSerialized::FixingInformation>& xml_fixingInfo = xml_serial->getFixingInformation();

	qlFixingInformationFactory qlFIF = qlFixingInformationFactory();

	const boost::shared_ptr<QuantLib::FixingInformation>& ql_fixingInfo =
					qlFIF.fixingInfo(xml_fixingInfo);

	ql_var = boost::shared_ptr<QuantLib::VariableInfo>(
		new PreDefinedVariableInfo(refInstanceName,ql_fixingInfo ));

	return ql_var;
}

boost::shared_ptr<QuantLib::VariableInfo> qlVariableInfoFactory::definedVariableInfo(const boost::shared_ptr<FpmlSerialized::DefinedVariableInfo>& xml_serial)
{
	boost::shared_ptr<QuantLib::VariableInfo> ql_var;

	const std::string& refInstanceName = xml_serial->getRefInstanceName()->SValue();

	ql_var = boost::shared_ptr<QuantLib::VariableInfo>(
		new DefinedVariableInfo(refInstanceName));

	return ql_var;
}

Real qlVariableInfoFactory::fixingValue(const boost::shared_ptr<FpmlSerialized::FixingInformation>& xml_serial)
{
	Real v = 0.0;

	Date calculationDate = Settings::instance().evaluationDate();

	const std::vector<boost::shared_ptr<FpmlSerialized::Fixing>>& xml_fixings
								= xml_serial->getFixing();

	for ( Size i=0 ; i < xml_fixings.size() ; i++)
	{
		if ( calculationDate > xml_fixings[i]->getDate()->dateValue() )
		{
			v = xml_fixings[i]->getValue()->DValue();
		}
	}

	return v;
}

}
