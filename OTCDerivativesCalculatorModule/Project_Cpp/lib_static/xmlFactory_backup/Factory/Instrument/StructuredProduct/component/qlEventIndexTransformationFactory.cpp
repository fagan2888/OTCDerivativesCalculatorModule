#include "qlEventIndextransformationFactory.hpp"
#include <xmlFactory/Factory/index/qlUnderlyingFactory.hpp>
#include <xmlFactory/Factory/instrument/structuredProduct/component/qlVariableValueFactory.hpp>

#include <ql/time/period.hpp>

using namespace QuantLib;
//using namespace TinyXPath;

namespace XmlFactory {

//payoff에 들어가는 indexTrans는 daily로 연속해서 사용할일이 없으므로  observationDates에 payoffDate 하나만 들어오면됨.
void qlEventIndexTransformationFactory::setSerialClass(const boost::shared_ptr<FpmlSerialized::EventIndexTransformation>& serial_eit)
{
	std::vector<boost::shared_ptr<QuantLib::VariableValue> > ql_vvList;
	const std::vector<boost::shared_ptr<FpmlSerialized::IndexCalculation>>& serial_ic = serial_eit->getIndexCalculation();

	for(Size i=0;i<serial_ic.size();++i)
	{
		ql_vvList.push_back(this->getItb(serial_ic[i]));
	}

	const std::string& eitf = serial_eit->getID();

	eventIndexTransformation_ = boost::shared_ptr<QuantLib::EventIndexTransformation>(
											new QuantLib::EventIndexTransformation(ql_vvList));

	//addedSymbols.push_back(symbol);

}

boost::shared_ptr<QuantLib::EventIndexTransformation> qlEventIndexTransformationFactory::getEIT()
{
	return this->eventIndexTransformation_;
}

boost::shared_ptr<QuantLib::VariableValue> qlEventIndexTransformationFactory::getItb(const boost::shared_ptr<FpmlSerialized::IndexCalculation>& ic)
{
	boost::shared_ptr<QuantLib::VariableValue> ql_vv;
	bool timeType = false;

	if(!ic->isTimeType())
		timeType = ic->getTimeType()->BValue();

	const std::string& choiceStr_tran = ic->getChoiceStr_tran();

	if(choiceStr_tran == "return"){
		const boost::shared_ptr<FpmlSerialized::ReturnTran>& returnTran = ic->getReturn();
		ql_vv = this->getReturnTrans(returnTran,timeType);
	}
	//else if(choiceStr_tran == "returnTime"){
	//	const boost::shared_ptr<FpmlSerialized::ReturnTranTime>& returnTranTime = ic->getReturnTime();
	//	itb = this->getReturnTransTime(returnTranTime);
	//}
	else if(choiceStr_tran == "minimum"){
		const boost::shared_ptr<FpmlSerialized::MinimumTran>& mininumTran = ic->getMinimum();
		ql_vv = this->getMinimumTrans(mininumTran,timeType);
	}
	else
	{
		QL_FAIL("unknown index Trans type : " << choiceStr_tran);
	}

	return ql_vv;
}

boost::shared_ptr<QuantLib::VariableValue> qlEventIndexTransformationFactory::getReturnTrans(const boost::shared_ptr<FpmlSerialized::ReturnTran>& rt,bool timeFlag)
{
	//const std::string& indexStr = rt->getBaseRef()->SValue();
	const std::string& symbolName = rt->getSymbolName()->SValue();

	const boost::shared_ptr<FpmlSerialized::VariableValue> serial_nc = rt->getNumerCalculation();
	const boost::shared_ptr<FpmlSerialized::VariableValue> serial_dc = rt->getDenumerCalculation();

	const std::string& choiceStr_paraType_nc = serial_nc->getChoiceStr_paraType();
	const std::string& choiceStr_paraType_dc = serial_dc->getChoiceStr_paraType();

	qlVariableValueFactory ql_vvf = qlVariableValueFactory();
	ql_vvf.setSerialClass(rt->getNumerCalculation());

	boost::shared_ptr<QuantLib::VariableValue> numerVariableValue = ql_vvf.getVV();
	
	ql_vvf.setSerialClass(rt->getDenumerCalculation());

	boost::shared_ptr<QuantLib::VariableValue> denumerVariableValue = ql_vvf.getVV();

	boost::shared_ptr<QuantLib::ReturnTrans> returnTranPtr = 
					boost::shared_ptr<QuantLib::ReturnTrans>(
								new QuantLib::ReturnTrans(numerVariableValue,
														  denumerVariableValue,
														  symbolName));
	

	//원칙 1) 모든 fix는 factory 에서 함.
	//원칙 2) 모든 계산은 calculationModule 에서 함.

	std::vector<boost::shared_ptr<QuantLib::VariableValue> > addedVariableValues;

	addedVariableValues.push_back(numerVariableValue);
	addedVariableValues.push_back(denumerVariableValue);

	boost::shared_ptr<QuantLib::VariableValue> returnVariableValue;

	if(timeFlag == true){
		returnVariableValue= boost::shared_ptr<QuantLib::VariableValue>(
					new QuantLib::ComplexTimeVariableValue(returnTranPtr,
													   symbolName,
													   addedVariableValues));	
	}else
	{
		returnVariableValue= boost::shared_ptr<QuantLib::VariableValue>(
					new QuantLib::ComplexVariableValue(returnTranPtr,
														   symbolName,
														   addedVariableValues));	
	}

	returnVariableValue->registManager();

	return returnVariableValue;
}

//boost::shared_ptr<QuantLib::ReturnTrans> qlEventIndexTransformationFactory::getReturnTransTime(const boost::shared_ptr<FpmlSerialized::ReturnTranTime>& rt_time)
//{
//
//}

boost::shared_ptr<QuantLib::VariableValue> qlEventIndexTransformationFactory::getMinimumTrans(const boost::shared_ptr<FpmlSerialized::MinimumTran>& serial_mt, bool timeFlag)
{
	const std::string& symbolName = serial_mt->getSymbolName()->SValue();

	const std::vector<boost::shared_ptr<FpmlSerialized::VariableValue>> variables 
					= serial_mt->getVariable();

	std::vector<boost::shared_ptr<QuantLib::VariableValue>> addedVariableValues;

	for(Size i = 0 ; i < variables.size() ; ++i)
	{
		qlVariableValueFactory ql_vvf = qlVariableValueFactory();
		ql_vvf.setSerialClass(variables[i]);
		addedVariableValues.push_back(ql_vvf.getVV());
	}

	boost::shared_ptr<QuantLib::MinimumTrans> minimumTranPtr 
					= boost::shared_ptr<QuantLib::MinimumTrans>(new QuantLib::MinimumTrans(symbolName,addedVariableValues));
	
	boost::shared_ptr<QuantLib::VariableValue> minimumVariableValue;

	if(timeFlag == true){
		minimumVariableValue = boost::shared_ptr<QuantLib::VariableValue>(
						new QuantLib::ComplexTimeVariableValue(minimumTranPtr,
														   symbolName,
														   addedVariableValues));	
	}else
	{
		minimumVariableValue = boost::shared_ptr<QuantLib::VariableValue>(
						new QuantLib::ComplexVariableValue(minimumTranPtr,
															   symbolName,
															   addedVariableValues));	
	}

	minimumVariableValue->registManager();

	return minimumVariableValue;
}


}