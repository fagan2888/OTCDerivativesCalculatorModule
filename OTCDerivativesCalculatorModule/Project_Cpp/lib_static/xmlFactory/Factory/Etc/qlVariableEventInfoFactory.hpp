#ifndef xmlFactory_variableEventfactory_hpp
#define xmlFactory_variableEventfactory_hpp

#include <GenClass/RiskMonitor-0-1/all.hpp>
#include <src/Engine/MonteCarlo/VariableInfo/variableEventInfo.hpp>

using namespace QuantLib;

namespace XmlFactory {

	class qlVariableEventInfoFactory {
		public:
			qlVariableEventInfoFactory()
			{
			}

			boost::shared_ptr<QuantLib::VariableEventInfo> variableEventInfo(const boost::shared_ptr<FpmlSerialized::VariableEventInfo>& xml_serial);

			boost::shared_ptr<QuantLib::VariableEventInfo> nullVariableEventInfo();
			boost::shared_ptr<QuantLib::VariableEventInfo> overWriteVariableEventInfo(const boost::shared_ptr<FpmlSerialized::OverWriteVariableEventInfo>& xml_serial);

	};

}
#endif