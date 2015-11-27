#include "qlVariableValueFactory.hpp"
#include <xmlFactory/Factory/index/qlUnderlyingFactory.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/symbolManager/pathinformation.hpp>

using namespace QuantLib;

namespace XmlFactory {
	
qlVariableValueFactory::qlVariableValueFactory(){}

void qlVariableValueFactory::setSerialClass(const boost::shared_ptr<FpmlSerialized::VariableValue>& serial_vv)
{
	const std::string& choiceStr_paraType = serial_vv->getChoiceStr_paraType();
	boost::shared_ptr<QuantLib::VariableValue> ql_vv;

	if( choiceStr_paraType == "indexRef")	{
		const boost::shared_ptr<FpmlSerialized::IndexRef>& serial_indexRef
				= serial_vv->getIndexRef();
		const Date& refDate = serial_indexRef->getEventDateRef()->getDateSingle()->dateValue();
		const std::string& fixingTypeChoiceStr = serial_indexRef->getFixingDays()->getChoiceStr_fixingType();

		Integer fixingDays = 0;

		if(fixingTypeChoiceStr == "days"){
			fixingDays = serial_indexRef->getFixingDays()->getDays()->IValue();
		}else
		{
			QL_FAIL("not implementation");
		}

		Calendar calendar = PathInformation::instance().getCalendar();

		const QuantLib::Period& dayUnit = QuantLib::Period(fixingDays,QuantLib::Days); 
		const Date& adjustedRefDate = calendar.advance(refDate,dayUnit);

		const boost::shared_ptr<FpmlSerialized::UnderlyingIndex>& serial_under 
						= serial_vv->getIndexRef()->getUnderlyingIndexRef();

		qlUnderlyingFactory ql_uf = qlUnderlyingFactory();
		ql_uf.setSerialClass(serial_under);

		boost::shared_ptr<QuantLib::Index> index = ql_uf.getIndex();

		ql_vv = boost::shared_ptr<QuantLib::SimpleVariableValue>(
								new QuantLib::SimpleVariableValue(index,adjustedRefDate));

	}
	else if(choiceStr_paraType == "indexTimeRef"){
		const boost::shared_ptr<FpmlSerialized::IndexTimeRef>& serial_indexItmeRef
				= serial_vv->getIndexTimeRef();
		const std::string& fixingTypeChoiceStr = serial_indexItmeRef->getFixingDays()->getChoiceStr_fixingType();

		Integer fixingDays = 0;

		if(fixingTypeChoiceStr == "days"){
			fixingDays = serial_indexItmeRef->getFixingDays()->getDays()->IValue();
		}else
		{
			QL_FAIL("not implementation");
		}

		Calendar calendar = PathInformation::instance().getCalendar();

		const boost::shared_ptr<FpmlSerialized::UnderlyingIndex>& serial_under 
						= serial_indexItmeRef->getUnderlyingIndexRef();

		qlUnderlyingFactory ql_uf = qlUnderlyingFactory();
		ql_uf.setSerialClass(serial_under);

		boost::shared_ptr<QuantLib::Index> index = ql_uf.getIndex();

		ql_vv = boost::shared_ptr<QuantLib::SimpleTimeVariableValue>(
								new QuantLib::SimpleTimeVariableValue(index,fixingDays));


	}
	else if(choiceStr_paraType == "symbolName"){
		const std::string& symbolName = serial_vv->getSymbolName()->SValue();

		ql_vv = boost::shared_ptr<QuantLib::ComplexVariableValue>(
											new QuantLib::ComplexVariableValue(symbolName));

	}
	else if(choiceStr_paraType == "constValue"){
		Real value = serial_vv->getConstValue()->DValue();
		ql_vv = boost::shared_ptr<QuantLib::ConstVariableValue>(new QuantLib::ConstVariableValue(value));
	}
	else
	{
		QL_FAIL("unknown type paraType");
	}

	ql_vv->registManager();

	this->variableValue_ = ql_vv;

}

boost::shared_ptr<QuantLib::VariableValue> qlVariableValueFactory::getVV()
{
	return this->variableValue_;
}

}
