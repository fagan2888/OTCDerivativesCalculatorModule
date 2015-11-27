#include "qlAdditionalOptionFactory.hpp"
#include <src/Engine/MonteCarlo/pricer/additionalOption/all.hpp>

namespace XmlFactory {

qlAdditionalOptionFactory::qlAdditionalOptionFactory()
{

}

boost::shared_ptr<QuantLib::AdditionalOption> qlAdditionalOptionFactory::additionalOption(const boost::shared_ptr<FpmlSerialized::Excel_additionalOption>& xml_serial)
{
	boost::shared_ptr<QuantLib::AdditionalOption> ql_additionalOption;

	const std::string& typeStr = xml_serial->getExcel_type()->SValue();

	if ( typeStr == "excel_noneOption")
	{
		const boost::shared_ptr<FpmlSerialized::Excel_noneOption> xml_noneOption 
			= xml_serial->getExcel_noneOption();

		ql_additionalOption = this->noneOption(xml_noneOption);
	}
	else if ( typeStr == "excel_callableOption" )
	{
		const boost::shared_ptr<FpmlSerialized::Excel_callableOption> xml_callableOption 
			= xml_serial->getExcel_callableOption();

		ql_additionalOption = this->callableOption(xml_callableOption);	
	}
	else if ( typeStr == "excel_puttableOption" )
	{
	}
	else 
	{
		QL_FAIL("unknown type str");
	}

	return ql_additionalOption;
}

boost::shared_ptr<QuantLib::AdditionalOption> qlAdditionalOptionFactory::noneOption(const boost::shared_ptr<FpmlSerialized::Excel_noneOption >& xml_serial)
{
	boost::shared_ptr<QuantLib::AdditionalOption> ql_additionalOption;

	ql_additionalOption = boost::shared_ptr<QuantLib::AdditionalOption>(
					new QuantLib::NoneOption());

	return ql_additionalOption;
}

boost::shared_ptr<QuantLib::AdditionalOption> qlAdditionalOptionFactory::callableOption(const boost::shared_ptr<FpmlSerialized::Excel_callableOption>& xml_serial)
{
	boost::shared_ptr<QuantLib::AdditionalOption> ql_additionalOption;

	ql_additionalOption = boost::shared_ptr<QuantLib::CallableOption>(
					new QuantLib::CallableOption());
	
	
	return ql_additionalOption;
}

}

