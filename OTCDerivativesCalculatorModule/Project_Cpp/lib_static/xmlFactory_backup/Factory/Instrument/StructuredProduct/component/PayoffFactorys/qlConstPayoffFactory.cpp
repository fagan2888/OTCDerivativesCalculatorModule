#include "qlConstPayoffFactory.hpp"
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/variablevalue/constvariablevalue.hpp>

namespace XmlFactory {

qlConstPayoffFactory::qlConstPayoffFactory(const QuantLib::Date& date)
: payoffDate_(date){
	
}

void qlConstPayoffFactory::setSerialClass(const boost::shared_ptr<FpmlSerialized::ConstPayoff>& serial_cp)
{
	const std::string& symbolName = serial_cp->getID();
	Real constValue = serial_cp->getConstValue()->DValue();
	
	if(symbolName == ""){
		QL_REQUIRE(symbolName != "" , "payoff symbolName can't be null string" );
	}

	boost::shared_ptr<ConstVariableValue> ql_vv(new ConstVariableValue(55,symbolName,payoffDate_));

	ql_vv->registManager();

	ql_cp_ = boost::shared_ptr<ConstPayoff>(
		new ConstPayoff(symbolName,payoffDate_,55));

	//�̰� ���� �� variable�� �����ϴ� Ŭ������ �����Ƿ�,
	// �����Ͱ� �Ҹ��ؼ� ���⼭ �׳� �ٷ� �����.
	ql_cp_->setThisVariable(ql_vv);
}
	
boost::shared_ptr<QuantLib::ConstPayoff> qlConstPayoffFactory::getCP()
{
	return ql_cp_;
}

}

