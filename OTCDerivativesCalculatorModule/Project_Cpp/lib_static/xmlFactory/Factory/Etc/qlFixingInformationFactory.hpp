#ifndef xmlFactory_qlFixingInformationFactory_hpp
#define xmlFactory_qlFixingInformationFactory_hpp

#include <util/xmlUtilHeader.hpp>
#include <GenClass\RiskMonitor-0-1\all.hpp>
#include <src/Engine/MonteCarlo/fixingInformation.hpp>

using namespace QuantLib;

namespace XmlFactory {

	class qlFixingInformationFactory {
		public:
			qlFixingInformationFactory();
			boost::shared_ptr<QuantLib::FixingInformation> fixingInfo(const boost::shared_ptr<FpmlSerialized::FixingInformation>& xml_serial);

	};
}

#endif