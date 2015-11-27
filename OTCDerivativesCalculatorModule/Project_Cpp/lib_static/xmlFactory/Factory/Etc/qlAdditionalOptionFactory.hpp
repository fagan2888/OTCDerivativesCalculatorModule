#ifndef xmlFactory_qlAdditionalOptionFactory_hpp
#define xmlFactory_qlAdditionalOptionFactory_hpp

#include <util/xmlUtilHeader.hpp>
#include <GenClass\RiskMonitor-0-1\all.hpp>
#include <src/Engine/MonteCarlo/pricer/additionalOption/all.hpp>

using namespace QuantLib;

namespace XmlFactory {

	class qlAdditionalOptionFactory {
		public:
			qlAdditionalOptionFactory();

			boost::shared_ptr<QuantLib::AdditionalOption> additionalOption(const boost::shared_ptr<FpmlSerialized::Excel_additionalOption>& xml_serial);

		private:
			boost::shared_ptr<QuantLib::AdditionalOption> noneOption(const boost::shared_ptr<FpmlSerialized::Excel_noneOption >& xml_serial);
			boost::shared_ptr<QuantLib::AdditionalOption> callableOption(const boost::shared_ptr<FpmlSerialized::Excel_callableOption>& xml_serial);
			
	};
}

#endif