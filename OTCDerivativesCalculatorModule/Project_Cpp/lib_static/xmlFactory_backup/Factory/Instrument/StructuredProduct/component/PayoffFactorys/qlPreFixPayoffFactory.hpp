#ifndef xmlFactory_qlprefixpayoffFactory_hpp
#define xmlFactory_qlprefixpayoffFactory_hpp

#include <xmlFactory/util/xmlUtilHeader.hpp>
#include <fpmlserialized/genclass/ahn-product-1-0/PreFixPayoff.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/Payoff/PreFixPayoff.hpp>

namespace XmlFactory {

class qlPreFixPayoffFactory {
	public:
		qlPreFixPayoffFactory();
		void setSerialClass(const boost::shared_ptr<FpmlSerialized::PreFixPayoff>& serial_pfp);
		boost::shared_ptr<QuantLib::PreFixPayoff> getPFP();
	private:
		boost::shared_ptr<QuantLib::PreFixPayoff> ql_pep_;
};

}

#endif