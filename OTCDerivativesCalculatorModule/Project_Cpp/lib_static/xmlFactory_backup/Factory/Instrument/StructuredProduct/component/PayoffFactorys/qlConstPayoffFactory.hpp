#ifndef xmlFactory_qlconstpayoffFactory_hpp
#define xmlFactory_qlconstpayoffFactory_hpp

#include <xmlFactory/util/xmlUtilHeader.hpp>
#include <fpmlserialized/genclass/ahn-product-1-0/ConstPayoff.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/Payoff/ConstPayoff.hpp>

namespace XmlFactory {

	class qlConstPayoffFactory {
		public:
			qlConstPayoffFactory(const QuantLib::Date& date);
			void setSerialClass(const boost::shared_ptr<FpmlSerialized::ConstPayoff>& serial_cp);
			boost::shared_ptr<QuantLib::ConstPayoff> getCP();
		private:
			boost::shared_ptr<QuantLib::ConstPayoff> ql_cp_;
			QuantLib::Date payoffDate_;
	};

}

#endif