#ifndef xmlFactory_qlPostCalculationFactory_hpp
#define xmlFactory_qlPostCalculationFactory_hpp

#include <util/xmlUtilHeader.hpp>
#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>
#include <src/Engine/MonteCarlo/returnCalculation/all.hpp>
#include <src/Engine/MonteCarlo/eventCalculation/all.hpp>

#include <GenClass\RiskMonitor-0-1\all.hpp>

using namespace QuantLib;

namespace XmlFactory {

	class qlPostCalculationFactory {
		public:
			qlPostCalculationFactory();

			boost::shared_ptr<QuantLib::PostCalculation> postCal(const boost::shared_ptr<FpmlSerialized::PostCalculation>& xml_serial);


	};
}

#endif