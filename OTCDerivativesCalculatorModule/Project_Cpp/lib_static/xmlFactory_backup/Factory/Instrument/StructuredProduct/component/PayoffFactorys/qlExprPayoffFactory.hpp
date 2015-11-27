
#ifndef xmlFactory_qlexprpayoffFactory_hpp
#define xmlFactory_qlexprpayoffFactory_hpp

#include <xmlFactory/util/xmlUtilHeader.hpp>
#include <fpmlserialized/genclass/ahn-product-1-0/ExprPayoff.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/Payoff/ExprPayoff.hpp>

namespace XmlFactory {

class qlExprPayoffFactory {
	public:
		qlExprPayoffFactory();
		void setSerialClass(const boost::shared_ptr<FpmlSerialized::ExprPayoff>& serial_ep);
		boost::shared_ptr<QuantLib::ExprPayoff> getEP();
	private:
		boost::shared_ptr<QuantLib::ExprPayoff> ql_ep_;
};

}

#endif