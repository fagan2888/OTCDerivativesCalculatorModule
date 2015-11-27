#ifndef xmlFactory_StructuredProductFactory_hpp
#define xmlFactory_StructuredProductFactory_hpp

#include <xmlFactory/util/xmlUtilHeader.hpp>

#include <calculationModule/src/Instrument/StructuredProduct/StructuredProduct.hpp>

#include <fpmlserialized/genclass/ahn-product-1-0/StructuredProduct.hpp>

namespace XmlFactory {

	class qlFdmContingentPayoffFactory {
		public:
			qlFdmContingentPayoffFactory();
			void setSerialClass(const boost::shared_ptr<FpmlSerialized::FdmContingentPayoffFactory>& sp);
			boost::shared_ptr<QuantLib::StructuredProduct> getSP();

		protected:
		
		//³»ºÎ¿ë getter
		private:
			boost::shared_ptr<QuantLib::StructuredProductPayoff> getSPP();

		private:
			boost::shared_ptr<QuantLib::StructuredProduct> structuredProduct_;
	};
}

#endif