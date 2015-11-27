#ifndef xmlFactory_qlFixingDateInfoFactory_hpp
#define xmlFactory_qlFixingDateInfoFactory_hpp

#include <util/xmlUtilHeader.hpp>
#include <src/Engine/MonteCarlo/MCPricer.hpp>
#include <GenClass\RiskMonitor-0-1\all.hpp>
#include <src/Engine/MonteCarlo/fixingDateInfo.hpp>

using namespace QuantLib;

namespace XmlFactory {

	class qlFixingDateInfoFactory {
		public:
			qlFixingDateInfoFactory();
			boost::shared_ptr<QuantLib::FixingDateInfo> fixingDateInfo(const boost::shared_ptr<FpmlSerialized::FixingDateInfo>& xml_serial);
			boost::shared_ptr<QuantLib::FixingDateInfo> fixingDateInfo(QuantLib::Date date);

		private:
			boost::shared_ptr<QuantLib::FixingDateInfo> fixedFixingDateInfo(const boost::shared_ptr<FpmlSerialized::FixedFixingDateInfo>& xml_serial);
			boost::shared_ptr<QuantLib::FixingDateInfo> refVarFixingDateInfo(const boost::shared_ptr<FpmlSerialized::RefVariableFixingDateInfo>& xml_serial);
			boost::shared_ptr<QuantLib::FixingDateInfo> nullFixingDateInfo(const boost::shared_ptr<FpmlSerialized::NullFixingDateInfo>& xml_serial);
			
	};
}

#endif