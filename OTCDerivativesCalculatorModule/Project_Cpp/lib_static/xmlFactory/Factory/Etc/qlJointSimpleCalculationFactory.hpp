#ifndef xmlFactory_jointSimpleCalculationFactory_hpp
#define xmlFactory_jointSimpleCalculationFactory_hpp

#include <GenClass/RiskMonitor-0-1/all.hpp>
#include <src/Engine/MonteCarlo/eventCalculation/jointEventCalculation/simpleJointCal/all.hpp>

using namespace QuantLib;

namespace XmlFactory {

	class qlJointSimpleCalculationFactory {
		public:
			qlJointSimpleCalculationFactory()
			{
			}

			boost::shared_ptr<QuantLib::JointSimpleCalculation> jointSimpleCal(const boost::shared_ptr<FpmlSerialized::JointSimpleCalculation>& xml_serial);

			boost::shared_ptr<QuantLib::JointSimpleCalculation> andSimpleCal(const boost::shared_ptr<FpmlSerialized::AndSimpleCal>& xml_serial);

	};

}
#endif