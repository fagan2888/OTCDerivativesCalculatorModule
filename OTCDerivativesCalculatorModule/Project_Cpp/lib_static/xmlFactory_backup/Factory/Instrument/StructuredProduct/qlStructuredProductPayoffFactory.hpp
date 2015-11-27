#ifndef xmlFactory_qlstructuredproductpayofffactory_hpp
#define xmlFactory_qlstructuredproductpayofffactory_hpp

#include <xmlFactory/util/xmlUtilHeader.hpp>

#include <fpmlserialized/genclass/ahn-product-1-0/StructuredProductPayoff.hpp>
#include <calculationModule/src/Instrument/structuredProduct/structuredProductPayoff.hpp>

namespace XmlFactory {

	class qlStructuredProductPayoffFactory {
		public:
			qlStructuredProductPayoffFactory();
		
			void setSerialClass(const boost::shared_ptr<FpmlSerialized::StructuredProductPayoff>& spp);

			boost::shared_ptr<QuantLib::StructuredProductPayoff> getSPP();

		protected:
			
		private:
			boost::shared_ptr<QuantLib::StructuredProductPayoff> structuredProductPayoff_;
	};
}

#endif