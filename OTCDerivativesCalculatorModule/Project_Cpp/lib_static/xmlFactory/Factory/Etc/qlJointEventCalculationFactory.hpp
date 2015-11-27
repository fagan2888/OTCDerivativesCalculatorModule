#ifndef xmlFactory_operatorfactory_hpp
#define xmlFactory_operatorfactory_hpp

#include <GenClass/RiskMonitor-0-1/all.hpp>
#include <src/Engine/MonteCarlo/eventCalculation/jointEventCalculation/jointEventCalculation.hpp>

using namespace QuantLib;

namespace XmlFactory {

	class qlJointEventCalculationFactory {
		public:
			qlJointEventCalculationFactory()
			{
			}

			boost::shared_ptr<QuantLib::JointEventCalculation> jointEventCal(const boost::shared_ptr<FpmlSerialized::JointEventCalculation>& xml_serial);

			boost::shared_ptr<QuantLib::JointEventCalculation> andEventCal(const boost::shared_ptr<FpmlSerialized::AndEventCal>& xml_serial);
			boost::shared_ptr<QuantLib::JointEventCalculation> orEventCal(const boost::shared_ptr<FpmlSerialized::OrEventCal>& xml_serial);
			boost::shared_ptr<QuantLib::JointEventCalculation> atLeastEventCal(const boost::shared_ptr<FpmlSerialized::AtLeastEventCal>& xml_serial);
			boost::shared_ptr<QuantLib::JointEventCalculation> atMostEventCal(const boost::shared_ptr<FpmlSerialized::AtMostEventCal>& xml_serial);
			boost::shared_ptr<QuantLib::JointEventCalculation> countEventCal(const boost::shared_ptr<FpmlSerialized::CountEventCal>& xml_serial);

	};

}
#endif