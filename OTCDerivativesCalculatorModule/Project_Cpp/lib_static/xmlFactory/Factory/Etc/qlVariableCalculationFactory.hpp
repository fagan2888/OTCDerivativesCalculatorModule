#ifndef xmlFactory_qlVariableCalculationFactory_hpp
#define xmlFactory_qlVariableCalculationFactory_hpp

#include <util/xmlUtilHeader.hpp>
#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>
#include <src/Engine/MonteCarlo/variableCalculation.hpp>
#include <GenClass\RiskMonitor-0-1\all.hpp>

using namespace QuantLib;

namespace XmlFactory {

	class qlVariableCalculationFactory {
		public:
			qlVariableCalculationFactory();

			boost::shared_ptr<QuantLib::VariableCalculation> variableCal(const boost::shared_ptr<FpmlSerialized::VariableCalculation>& xml_serial);

	};
}

#endif