#include "qlFunctionEventsFactory.hpp"
#include <xmlFactory/Factory/Instrument/StructuredProduct/component/qlJointEventFactory.hpp>

#include <boost/algorithm/string/case_conv.hpp>

using boost::algorithm::to_upper_copy;

using namespace QuantLib;
//using namespace TinyXPath;
using namespace ConvertFunction;

namespace XmlFactory {

void qlFunctionEventsFactory::setSerialClass(const boost::shared_ptr<FpmlSerialized::FunctionEvents>& fe)
{
	const std::vector<boost::shared_ptr<FpmlSerialized::EventFunctionM>>& serial_EFs 
							= fe->getEventFunctionM();

	std::valarray<boost::shared_ptr<EventFunctionManager>> eventFunctionMs;
	eventFunctionMs.resize(serial_EFs.size());
	
	boost::shared_ptr<JointEvent>& jointEvent 
			= boost::shared_ptr<JointEvent>(new IdentityJointEvent(true));

	if(serial_EFs.size() == 1)
		jointEvent = boost::shared_ptr<JointEvent>(new SingleEvent(true));

	for(Size i=0;i<serial_EFs.size();++i){
		eventFunctionMs[i] = this->efm(serial_EFs[i]);
	}

	if(!fe->isJointFunctionEvent()){
		qlJointEventFactory jef = qlJointEventFactory();
		jef.setSerialClass(fe->getJointFunctionEvent());
		jointEvent = jef.getJFE();
	}

	this->functionEvents_ = 
		boost::shared_ptr<FunctionEvents>(
				new FunctionEvents(eventFunctionMs,jointEvent));

}
boost::shared_ptr<QuantLib::FunctionEvents> qlFunctionEventsFactory::getFE()
{
	return this->functionEvents_;
}

boost::shared_ptr<QuantLib::EventFunctionManager> qlFunctionEventsFactory::efm(const boost::shared_ptr<FpmlSerialized::EventFunctionM>& ef)
{

	boost::shared_ptr<QuantLib::EventFunctionManager> ql_efm;
	boost::shared_ptr<QuantLib::EventFunction> ql_ef;
	
	const std::string& name = ef->getName()->SValue();
	const std::string& indexSymbol = ef->getIndexSymbol()->SValue();

	const std::string& choiceStr_tran = ef->getChoiceStr_efType();

	if(choiceStr_tran == "upEventCheck"){
		const boost::shared_ptr<FpmlSerialized::UpEventCheck>& serial_uec = ef->getUpEventCheck();
		ql_ef = this->getUpEventCheck(serial_uec);
		
	}else if(choiceStr_tran == "downEventCheck"){
		const boost::shared_ptr<FpmlSerialized::DownEventCheck>& serial_dec = ef->getDownEventCheck();
		ql_ef = this->getDownEventCheck(serial_dec);
	}


	ql_efm = boost::shared_ptr<QuantLib::EventFunctionManager>(
							new EventFunctionManager(name,
													 indexSymbol,
													 ql_ef));

	return ql_efm;
}

boost::shared_ptr<QuantLib::UpEventCheck> qlFunctionEventsFactory::getUpEventCheck(const boost::shared_ptr<FpmlSerialized::UpEventCheck>& serial_uec)
{
	double checkValue = serial_uec->getCheckValue()->DValue();
	bool equality = serial_uec->getEquality()->BValue();

	const boost::shared_ptr<UpEventCheck>& ql_uec = boost::shared_ptr<UpEventCheck>(new QuantLib::UpEventCheck(checkValue,equality));

	return ql_uec;
}

boost::shared_ptr<QuantLib::DownEventCheck> qlFunctionEventsFactory::getDownEventCheck(const boost::shared_ptr<FpmlSerialized::DownEventCheck>& serial_dec)
{
	double checkValue = serial_dec->getCheckValue()->DValue();
	bool equality = serial_dec->getEquality()->BValue();

	const boost::shared_ptr<DownEventCheck>& ql_dec = boost::shared_ptr<DownEventCheck>(new QuantLib::DownEventCheck(checkValue,equality));

	return ql_dec;
}

}