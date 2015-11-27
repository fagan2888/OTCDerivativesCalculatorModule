#ifndef xmlFactory_qlEventCalculationFactory_hpp
#define xmlFactory_qlEventCalculationFactory_hpp

#include <util/xmlUtilHeader.hpp>
#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>
#include <src/Engine/MonteCarlo/returnCalculation/all.hpp>
#include <src/Engine/MonteCarlo/eventCalculation/all.hpp>
#include <src/Engine/MonteCarlo/eventCalculation/eventCalculationInfo.hpp>

#include <GenClass/RiskMonitor-0-1/all.hpp>

using namespace QuantLib;

namespace XmlFactory {

	class qlEventCalculationFactory {
		public:
			qlEventCalculationFactory();

			boost::shared_ptr<QuantLib::EventCalculation> eventCal(const boost::shared_ptr<FpmlSerialized::EventCalculation>& xml_serial);
			boost::shared_ptr<QuantLib::EventCalculationInfo> eventCalInfo(const boost::shared_ptr<FpmlSerialized::EventCalculationInfo>& xml_serial);

			boost::shared_ptr<QuantLib::EventCalculation> e_eventCal(const boost::shared_ptr<FpmlSerialized::Excel_eventCalcInfo>& xml_serial);
			boost::shared_ptr<QuantLib::EventCalculationInfo> e_eventCalcInfo(const boost::shared_ptr<FpmlSerialized::Excel_eventCalcInfo>& xml_serial);


			boost::shared_ptr<QuantLib::EventCalculation> upperBarrierEventCal(const boost::shared_ptr<FpmlSerialized::UpperBarrierEventCal>& xml_serial);
			boost::shared_ptr<QuantLib::EventCalculation> lowerBarrierEventCal(const boost::shared_ptr<FpmlSerialized::LowerBarrierEventCal>& xml_serial);
			boost::shared_ptr<QuantLib::EventCalculation> simpleRangeEventCal(const boost::shared_ptr<FpmlSerialized::SimpleRangeEventCal>& xml_serial);
			boost::shared_ptr<QuantLib::EventCalculation> referenceEventCal(const boost::shared_ptr<FpmlSerialized::ReferenceEventCal>& xml_serial);

	};
}

#endif