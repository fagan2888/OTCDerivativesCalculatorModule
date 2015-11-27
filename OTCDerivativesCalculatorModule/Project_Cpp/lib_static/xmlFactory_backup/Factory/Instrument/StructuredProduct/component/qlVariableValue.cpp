#include "qlVariableValueFactory.hpp>

using namespace QuantLib;

namespace XmlFactory {
	
qlVariableValueFactory::qlVariableValueFactory(){}

void qlVariableValueFactory::setSerialClass(const boost::shared_ptr<FpmlSerialized::VariableValue>& serial_vv)
{
	boost::shared_ptr<QuantLib::VariableValue> ql_vv;

	//--------------------------numer-----------------------------
	if( choiceStr_paraType_nc == "dateRef")	{

		const Date& refDate = serial_nc->getDateRef()->getEventDateRef()->getDateSingle()->dateValue();
		const std::string& fixingTypeChoiceStr = serial_nc->getDateRef()->getFixingDays()->getChoiceStr_fixingType();

		Integer fixingDays = 0;

		if(fixingTypeChoiceStr == "days"){
			fixingDays = serial_nc->getDateRef()->getFixingDays()->getDays()->IValue();
		}else
		{
			QL_FAIL("not implementation");
		}

		Calendar calendar = PathInformation::instance().getCalendar();

		const QuantLib::Period& dayUnit = QuantLib::Period(fixingDays,QuantLib::Days); 
		const Date& adjustedRefDate = calendar.advance(refDate,dayUnit);
		
		variableValue_ = boost::shared_ptr<SimpleVariableValue>();

		//qlDateFactory df = qlDateFactory();
		//const Date& date = df.getDate();
		
	}
	else if(choiceStr_paraType_nc == "symbolName"){
		const std::string& symbolName = serial_nc->getSymbolName()->SValue();

		variableValue_ = boost::shared_ptr<ComplexVariableValue>();

	}
	else if(choiceStr_paraType_nc == "constValue"){
		Real value = serial_nc->getConstValue()->DValue();
		variableValue_ = boost::shared_ptr<ConstVariableValue>();
	}
	else if(choiceStr_paraType_nc == "date"){
		
		const Date& numerDate = serial_nc->getDate()->dateValue();

		variableValue_ = boost::shared_ptr<SimpleVariableValue>();
	}
	
	this->variableValue_ = ql_vv;


}

boost::shared_ptr<QuantLib::VariableValue> qlVariableValueFactory::getVV()
{
	return this->variableValue_;
}

}

#endif