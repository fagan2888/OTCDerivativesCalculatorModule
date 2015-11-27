#include "qlExprPayoffFactory.hpp"

namespace XmlFactory {

qlExprPayoffFactory::qlExprPayoffFactory()
{
	
	
}

void qlExprPayoffFactory::setSerialClass(const boost::shared_ptr<FpmlSerialized::ExprPayoff>& serial_ep)
{
	
}

boost::shared_ptr<QuantLib::ExprPayoff> qlExprPayoffFactory::getEP()
{
	return ql_ep_;
}

}

