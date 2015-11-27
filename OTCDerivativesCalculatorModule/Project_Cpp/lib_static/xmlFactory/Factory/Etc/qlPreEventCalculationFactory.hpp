#ifndef xmlFactory_qlPreEventCalculationFactory_hpp
#define xmlFactory_qlPreEventCalculationFactory_hpp

#include <util/xmlUtilHeader.hpp>
#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>
#include <src/Engine/MonteCarlo/returnCalculation/all.hpp>
#include <src/Engine/MonteCarlo/eventCalculation/all.hpp>

#include <GenClass\RiskMonitor-0-1\all.hpp>

using namespace QuantLib;

namespace XmlFactory {

	class qlPreEventCalculationFactory {
		public:
			qlPreEventCalculationFactory();

			boost::shared_ptr<QuantLib::PreEventCalculation> preEventCal(const boost::shared_ptr<FpmlSerialized::PreEventCalculation>& xml_serial);


	};
}

#endif