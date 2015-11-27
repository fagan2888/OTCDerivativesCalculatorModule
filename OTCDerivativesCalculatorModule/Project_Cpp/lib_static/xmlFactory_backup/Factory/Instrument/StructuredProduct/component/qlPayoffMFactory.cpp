#include "qlPayoffMFactory.hpp"

#include <xmlFactory\Factory\Instrument\StructuredProduct\component\qlPayoffMFactory.hpp>
#include <xmlFactory\Factory\Instrument\StructuredProduct\component/payoffFactorys/all.hpp>

using namespace QuantLib;
//using namespace TinyXPath;

namespace XmlFactory {

qlPayoffMFactory::qlPayoffMFactory()
{

}
boost::shared_ptr<PayoffBase> qlPayoffMFactory::getPB()
{
	QL_REQUIRE(payoffBase_ , "payoffBase Ptr is null")
	return payoffBase_;
}

void qlPayoffMFactory::setSerialClass(const boost::shared_ptr<FpmlSerialized::PayoffBase>& pc){
	
	const std::string& pcType = pc->getChoiceStr_pcType();
	payoffDate_ = pc->getPayoffDate()->dateValue();
	boost::shared_ptr<PayoffBase> pb;

	if(pcType == "constPayoff"){pb = this->constPayoff(pc->getConstPayoff());}
	  else if(pcType == "averPayoff"){pb = this->averPayoff(pc->getAverPayoff());}
	  //else if(pcType == "ExprPayoff"){pb = this->exprPayoff(pc->getExprPayoff());}
	  //else if(pcType == "PreFixPayoff"){pb = this->preFixPayoff(pc->getPreFixPayoff());}
	  else if(pcType == "nullPayoff"){pb = this->nullPayoff(pc->getNullPayoff());}
	  else {QL_FAIL("invalid payoff Type");}

	payoffBase_ = pb;

}

boost::shared_ptr<ConstPayoff> qlPayoffMFactory::constPayoff(const boost::shared_ptr<FpmlSerialized::ConstPayoff>& serial_cp)
{
	qlConstPayoffFactory ql_cpf = qlConstPayoffFactory(payoffDate_);
	ql_cpf.setSerialClass(serial_cp);
	const boost::shared_ptr<ConstPayoff>& cp = ql_cpf.getCP();
	return cp;
}

boost::shared_ptr<AverPayoff> qlPayoffMFactory::averPayoff(const boost::shared_ptr<FpmlSerialized::AverPayoff>& serial_ap)
{
	QL_FAIL("not implemented");
	qlAverPayoffFactory ql_apf = qlAverPayoffFactory();
	ql_apf.setSerialClass(serial_ap);
	const boost::shared_ptr<AverPayoff>& ap = ql_apf.getAP();
	return ap;
}

//boost::shared_ptr<ExprPayoff> qlPayoffMFactory::exprPayoff(const boost::shared_ptr<FpmlSerialized::ExprPayoff>& serial_ep)
//{
//	qlExprPayoffFactory ql_epf = qlExprPayoffFactory();
//	ql_epf.setSerialClass(serial_ep);
//	const boost::shared_ptr<ExprPayoff>& ep = ql_epf.getEP();
//	return ep;
//}

//boost::shared_ptr<PreFixPayoff> qlPayoffMFactory::preFixPayoff(const boost::shared_ptr<FpmlSerialized::PreFixPayoff>& serial_pfp)
//{
//	qlPreFixPayoffFactory ql_pfpf = qlPreFixPayoffFactory();
//	ql_pfpf.setSerialClass(serial_pfp);
//	const boost::shared_ptr<PreFixPayoff>& pfp = ql_pfpf.getPFP();
//	return pfp;
//}

boost::shared_ptr<NullPayoff> qlPayoffMFactory::nullPayoff(const boost::shared_ptr<FpmlSerialized::NullPayoff>& serial_nc)
{
	qlNullPayoffFactory ql_npf = qlNullPayoffFactory();
	ql_npf.setSerialClass(serial_nc);
	const boost::shared_ptr<NullPayoff>& np = ql_npf.getNP();
	return np;
}

}