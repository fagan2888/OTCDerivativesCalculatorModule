#include "qlNullPayoffFactory.hpp"

namespace XmlFactory {

qlNullPayoffFactory::qlNullPayoffFactory()
{
	
	
}

void qlNullPayoffFactory::setSerialClass(const boost::shared_ptr<FpmlSerialized::NullPayoff>& serial_np)
{
	
}

boost::shared_ptr<QuantLib::NullPayoff> qlNullPayoffFactory::getNP()
{
	return ql_np_;
}

}

