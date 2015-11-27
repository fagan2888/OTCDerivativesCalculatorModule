#ifndef xmlFactory_qlnullpayoffFactory_hpp
#define xmlFactory_qlnullpayoffFactory_hpp

#include <xmlFactory/util/xmlUtilHeader.hpp>
#include <fpmlserialized/genclass/ahn-product-1-0/NullPayoff.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/Payoff/NullPayoff.hpp>

namespace XmlFactory {

class qlNullPayoffFactory {
	public:
		qlNullPayoffFactory();
		void setSerialClass(const boost::shared_ptr<FpmlSerialized::NullPayoff>& serial_np);
		boost::shared_ptr<QuantLib::NullPayoff> getNP();

	private:
		boost::shared_ptr<QuantLib::NullPayoff> ql_np_;
};

}

#endif