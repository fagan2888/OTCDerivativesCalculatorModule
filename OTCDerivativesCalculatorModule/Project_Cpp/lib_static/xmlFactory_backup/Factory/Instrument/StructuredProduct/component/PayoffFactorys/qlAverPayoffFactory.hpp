#ifndef xmlFactory_qlaverpayoffFactory_hpp
#define xmlFactory_qlaverpayoffFactory_hpp

#include <xmlFactory/util/xmlUtilHeader.hpp>
#include <fpmlserialized/genclass/ahn-product-1-0/AverPayoff.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/Payoff/AverPayoff.hpp>

namespace XmlFactory {

class qlAverPayoffFactory {
	public:
		qlAverPayoffFactory();
		void setSerialClass(const boost::shared_ptr<FpmlSerialized::AverPayoff>& serial_ap);
		boost::shared_ptr<QuantLib::AverPayoff> getAP();

	private:
		boost::shared_ptr<QuantLib::AverPayoff> ql_ap_;
};

}

#endif