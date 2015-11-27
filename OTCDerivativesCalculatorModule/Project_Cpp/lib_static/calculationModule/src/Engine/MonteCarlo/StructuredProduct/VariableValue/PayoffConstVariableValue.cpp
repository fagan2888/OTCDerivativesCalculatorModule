//#include "PayoffConstVariableValue.hpp"
//#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/symbolmanager/IndexSymbolManager.hpp>
//#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/symbolmanager/pathInformation.hpp>
//
//namespace QuantLib {
//
//PayoffConstVariableValue::PayoffConstVariableValue(boost::shared_ptr<PayoffBase> pb,
//	  											   const std::string& symbolName,
//												   Real constValue)
//: VariableValue(), pb_(pb), constValue_(constValue)
//{
//	this->symbolName_ = symbolName;
//
//	IndexSymbolManager::instance().setSymbol(symbolName,this);
//	
//	lastFixingDate_ = Date();
//	
//	this->variableBindingFlag_ = true;
//}
//
//void PayoffConstVariableValue::variableBind(const std::vector<std::string>& circulationCheckString)
//{
//	this->variableBindingFlag_ = true;
//}
//
//void PayoffConstVariableValue::variablePtrBind()
//{
//	value_ = constValue_;
//	this->valuePtr_ = &(this->value_);
//}
//
//void PayoffConstVariableValue::calculate()
//{
//	//���� �尡��..? ���� eventcheck�� �������� ����(event�� �Ͼ������ �Ҷ��)
//	this->addSample();
//}
//
//void PayoffConstVariableValue::addSample()
//{
//	this->sampleAccumulator_.add(value_,1.0);
//}
//
////time���� ���������� ��� �Ͽ� eventdates Maximum ������ ���ߴ볪..? 2013-02-25
//void PayoffConstVariableValue::validFixingDates(const std::vector<Date>& eventDates)
//{
//}
//
//Date PayoffConstVariableValue::calculateLastIndexFixing()
//{
//	return lastFixingDate_;
//}
//
//std::vector<Date> PayoffConstVariableValue::indexFixingDates()
//{
//	if(!variableBindingFlag_)
//		QL_FAIL("variable is not binding");
//
//	std::vector<Date> dates;
//
//	dates.push_back(lastFixingDate_);
//
//	return dates;
//}
//
//
//}