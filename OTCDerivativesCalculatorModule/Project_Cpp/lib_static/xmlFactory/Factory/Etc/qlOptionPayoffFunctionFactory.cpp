#include "qlOptionPayoffFunctionFactory.hpp"
#include <src/Engine/MonteCarlo/returnCalculation/CallPut/all.hpp>

using namespace QuantLib;

namespace XmlFactory {

boost::shared_ptr<QuantLib::OptionPayoffFunction> qlOptionPayoffFunctionFactory::optionPayoff(const boost::shared_ptr<FpmlSerialized::OptionPayoffFunction>& xml_serial)
{
	boost::shared_ptr<QuantLib::OptionPayoffFunction> ql_optionPayoff;

	std::string optionType = xml_serial->getType()->SValue();

	if ( optionType == "vanillaCallFunction" )
	{
		const boost::shared_ptr<FpmlSerialized::VanillaCallFunction>& xml_optionPayoff
			= xml_serial->getVanillaCallFunction();

		ql_optionPayoff = this->vanillaCall(xml_optionPayoff);
	}
	else if ( optionType == "vanillaPutFunction" )
	{
		const boost::shared_ptr<FpmlSerialized::VanillaPutFunction>& xml_optionPayoff
			= xml_serial->getVanillaPutFunction();

		ql_optionPayoff = this->vanillaPut(xml_optionPayoff);
	}
	else
	{
		QL_FAIL("unknown optionType : " << optionType);
	}

	return ql_optionPayoff;
}

//call
boost::shared_ptr<QuantLib::OptionPayoffFunction> qlOptionPayoffFunctionFactory::vanillaCall(const boost::shared_ptr<FpmlSerialized::VanillaCallFunction>& xml_serial)
{
	boost::shared_ptr<QuantLib::OptionPayoffFunction> ql_optionPayoff;

	Real partiRate = xml_serial->getPartiRate()->DValue();
	Real strike = xml_serial->getStrike()->DValue();
	Real spread = xml_serial->getSpread()->DValue();

	ql_optionPayoff = boost::shared_ptr<QuantLib::OptionPayoffFunction>(
								new QuantLib::VanillaCall(partiRate,
														strike,
														spread));

	return ql_optionPayoff;
}


//put
boost::shared_ptr<QuantLib::OptionPayoffFunction> qlOptionPayoffFunctionFactory::vanillaPut(const boost::shared_ptr<FpmlSerialized::VanillaPutFunction>& xml_serial)
{
	boost::shared_ptr<QuantLib::OptionPayoffFunction> ql_optionPayoff;

	Real partiRate = xml_serial->getPartiRate()->DValue();
	Real strike = xml_serial->getStrike()->DValue();
	Real spread = xml_serial->getSpread()->DValue();

	ql_optionPayoff = boost::shared_ptr<QuantLib::OptionPayoffFunction>(
								new QuantLib::VanillaPut(partiRate,
														strike,
														spread));

	return ql_optionPayoff;
}

}
