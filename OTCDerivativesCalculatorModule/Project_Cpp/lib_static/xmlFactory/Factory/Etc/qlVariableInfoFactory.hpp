#ifndef xmlFactory_variablefactory_hpp
#define xmlFactory_variablefactory_hpp

#include <GenClass/RiskMonitor-0-1/all.hpp>
#include <src/Engine/MonteCarlo/variableInfo/all.hpp>

using namespace QuantLib;

namespace XmlFactory {

	class qlVariableInfoFactory {
		public:
			qlVariableInfoFactory()
			{
			}

			boost::shared_ptr<QuantLib::VariableInfo> variableInfo(const boost::shared_ptr<FpmlSerialized::VariableInfo>& xml_serial);

			boost::shared_ptr<QuantLib::VariableInfo> additionVariableInfo(const boost::shared_ptr<FpmlSerialized::AdditionVariableInfo>& xml_serial);
			boost::shared_ptr<QuantLib::VariableInfo> nullVariableInfo();
			boost::shared_ptr<QuantLib::VariableInfo> overWriteVariableInfo(const boost::shared_ptr<FpmlSerialized::OverWriteVariableInfo>& xml_serial);
			boost::shared_ptr<QuantLib::VariableInfo> resetVariableInfo(const boost::shared_ptr<FpmlSerialized::ResetVariableInfo>& xml_serial);
			boost::shared_ptr<QuantLib::VariableInfo> preDefinedVariableInfo(const boost::shared_ptr<FpmlSerialized::PreDefinedVariableInfo>& xml_serial);
			boost::shared_ptr<QuantLib::VariableInfo> definedVariableInfo(const boost::shared_ptr<FpmlSerialized::DefinedVariableInfo>& xml_serial);

			Real fixingValue(const boost::shared_ptr<FpmlSerialized::FixingInformation>& xml_serial);

	};
}
#endif