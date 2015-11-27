#ifndef xmlFactory_qlPreConditionEventFactory_hpp
#define xmlFactory_qlPreConditionEventFactory_hpp

#include <util/xmlUtilHeader.hpp>
#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>
#include <src/Engine/MonteCarlo/returnCalculation/all.hpp>
#include <src/Engine/MonteCarlo/eventCalculation/all.hpp>

#include <GenClass\RiskMonitor-0-1\all.hpp>

using namespace QuantLib;

namespace XmlFactory {

	class qlPreConditionEventFactory {
		public:
			qlPreConditionEventFactory();

			boost::shared_ptr<QuantLib::PreConditionEvent> preCondiEvent(const boost::shared_ptr<FpmlSerialized::PreConditionEvent>& xml_serial);


	};
}

#endif