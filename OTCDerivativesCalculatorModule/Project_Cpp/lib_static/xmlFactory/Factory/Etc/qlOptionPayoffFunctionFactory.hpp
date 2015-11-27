#ifndef xmlFactory_optionpayofffactory_hpp
#define xmlFactory_optionpayofffactory_hpp

#include <GenClass/RiskMonitor-0-1/all.hpp>
#include <src/Engine/MonteCarlo/returnCalculation/CallPut/OptionPayoffFunction.hpp>

using namespace QuantLib;

namespace XmlFactory {

	class qlOptionPayoffFunctionFactory {
		public:
			qlOptionPayoffFunctionFactory()
			{
			}

			boost::shared_ptr<QuantLib::OptionPayoffFunction> optionPayoff(const boost::shared_ptr<FpmlSerialized::OptionPayoffFunction>& xml_serial);

			boost::shared_ptr<QuantLib::OptionPayoffFunction> vanillaCall(const boost::shared_ptr<FpmlSerialized::VanillaCallFunction>& xml_serial);
			boost::shared_ptr<QuantLib::OptionPayoffFunction> vanillaPut(const boost::shared_ptr<FpmlSerialized::VanillaPutFunction>& xml_serial);

	};

}
#endif