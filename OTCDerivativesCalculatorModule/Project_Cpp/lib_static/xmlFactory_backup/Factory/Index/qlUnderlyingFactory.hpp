#ifndef xmlFactory_qlunderlyingFactory_hpp
#define xmlFactory_qlunderlyingFactory_hpp

#include <xmlFactory/util/xmlUtilHeader.hpp>
#include <xmlFactory/Factory/Etc/all.hpp>
#include <calculationModule/src/index/underlyingindex.hpp>

#include <fpmlserialized/genclass/ahn-product-1-0/UnderlyingIndex.hpp>

namespace XmlFactory {

	class qlUnderlyingFactory {
		public:
			qlUnderlyingFactory();
			void setSerialClass(const boost::shared_ptr<FpmlSerialized::UnderlyingIndex>& under);
			boost::shared_ptr<QuantLib::Index> getIndex();

		protected:
		
		//³»ºÎ¿ë getter
		private:
			boost::shared_ptr<QuantLib::Index> getStockIndex(const boost::shared_ptr<FpmlSerialized::UnderlyingIndex>& serial_under);
			boost::shared_ptr<QuantLib::Index> getInterestRateIndex(const boost::shared_ptr<FpmlSerialized::UnderlyingIndex>& serial_under);
			boost::shared_ptr<QuantLib::Index> getCommodityIndex(const boost::shared_ptr<FpmlSerialized::UnderlyingIndex>& serial_under);

		private:
			boost::shared_ptr<QuantLib::Index> index_;
	};
}

#endif