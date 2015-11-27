#ifndef xmlFactory_qlTypeFactory_hpp
#define xmlFactory_qlTypeFactory_hpp

#include <xmlFactory/util/xmlUtilHeader.hpp>
#include <ql/pricingengine.hpp>
#include <ql/instrument.hpp>
#include <Factory/instrumentFactory.hpp>

using namespace QuantLib;

namespace XmlFactory {

	class qlTypeFactory {
		public:
			qlTypeFactory();

			boost::shared_ptr<InstrumentFactory> getInstFactory(const std::string& typeStr);

			boost::shared_ptr<InstrumentFactory> getInstFactory_file(const char* fileName);

			std::string readFile(std::string fileName);
	};
}

#endif