#ifndef xmlFactory_qlVariableValueFactory_hpp
#define xmlFactory_qlVariableValueFactory_hpp

#include <xmlFactory/util/xmlUtilHeader.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/VariableValue/all.hpp>

#include <fpmlserialized/genclass/ahn-product-1-0/VariableValue.hpp>

using namespace QuantLib;

namespace XmlFactory {
	
	class qlVariableValueFactory {
		public:
			qlVariableValueFactory();

			void setSerialClass(const boost::shared_ptr<FpmlSerialized::VariableValue>& serial_vv);

			boost::shared_ptr<QuantLib::VariableValue> getVV();

		private:

			boost::shared_ptr<QuantLib::VariableValue> variableValue_;

	};

}

#endif