#include "qlAverPayoffFactory.hpp"

namespace XmlFactory {

qlAverPayoffFactory::qlAverPayoffFactory()
{
	
}

void qlAverPayoffFactory::setSerialClass(const boost::shared_ptr<FpmlSerialized::AverPayoff>& serial_ap)
{
	
}
	
boost::shared_ptr<QuantLib::AverPayoff> qlAverPayoffFactory::getAP()
{
	return ql_ap_;	
}

}

