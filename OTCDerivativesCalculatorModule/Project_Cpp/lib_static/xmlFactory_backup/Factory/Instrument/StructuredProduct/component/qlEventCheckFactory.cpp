#include "qlEventCheckFactory.hpp"
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/EventCheck/NormalEC.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/SymbolManager/EventSymbolManager.hpp>
//#include <fpmlserialized/genclass/built_in_type/XsdTypeToken.hpp>

namespace XmlFactory {

qlEventCheckFactory::qlEventCheckFactory()
{
}
	
void qlEventCheckFactory::setSerialClass(const boost::shared_ptr<FpmlSerialized::EventCheck>& serial_ec)
{
	
	const std::string& eventChoiceStr = serial_ec->getChoiceStr_ecType();

	boost::shared_ptr<QuantLib::IEventCheck> ql_iec;

	eventCheckID_ = serial_ec->getID();

	if( eventChoiceStr == "eventCheckNormal" )
	{
		const boost::shared_ptr<FpmlSerialized::EventCheckNormal>& serial_ecNormal = serial_ec->getEventCheckNormal();
		ql_iec = this->getNormalEC(serial_ecNormal);
	}
	else if( eventChoiceStr == "eventCheckTime" )
	{
		const boost::shared_ptr<FpmlSerialized::EventCheckTime>& serial_ecTime = serial_ec->getEventCheckTime();
		ql_iec = this->getTimeEC(serial_ecTime);
	}else
	{
		QL_FAIL("unknown event Type");
	}

	iEventCheck_ = ql_iec;
}

boost::shared_ptr<QuantLib::IEventCheck> qlEventCheckFactory::getIEC()
{
	QL_REQUIRE(iEventCheck_ , "EventCheck is null");
	return iEventCheck_;
}

//--------------------------------------------- Event type ----------------------------------------------------------------

boost::shared_ptr<QuantLib::IEventCheck> qlEventCheckFactory::getNormalEC(const boost::shared_ptr<FpmlSerialized::EventCheckNormal>& serial_Class)
{
	boost::shared_ptr<QuantLib::IEventCheck> ql_iec;

	const boost::shared_ptr<QuantLib::JointEvent>& ql_identityJE = boost::shared_ptr<QuantLib::JointEvent>(new IdentityJointEvent(true));


	boost::shared_ptr<QuantLib::SubEvents> ql_subEvents = boost::shared_ptr<QuantLib::SubEvents>(new QuantLib::SubEvents(true));

	boost::shared_ptr<QuantLib::JointEvent> ql_fsubJE = boost::shared_ptr<QuantLib::JointEvent>(new IdentityJointEvent(true));
	boost::shared_ptr<QuantLib::PayoffBase> ql_pb = boost::shared_ptr<QuantLib::PayoffBase>(new QuantLib::NullPayoff());

	const std::string& thisEventSymbol = this->eventCheckID_;

	const boost::shared_ptr<QuantLib::EventIndexTransformation>& ql_eit = this->getEIT(serial_Class->getEventIndexTransformation());
	const boost::shared_ptr<QuantLib::FunctionEvents>& ql_fe = this->getFE(serial_Class->getFunctionEvents());
	
	if(!serial_Class->isPayoffBase())
		ql_pb = this->getPB(serial_Class->getPayoffBase());
	
	if(!serial_Class->isJointSubEvent()){
		const boost::shared_ptr<FpmlSerialized::JointSubEvent>& serial_jse = serial_Class->getJointSubEvent();
		ql_subEvents = this->getSubEvents(serial_jse);
	}
	
	if(!serial_Class->isJointFSubEvent())
		ql_fsubJE = this->getF_SubJE(serial_Class->getJointFSubEvent());
	
	//std::vector<std::string> subEvent 등록 및 관리 하는 코드
		
	qlDateIntervalMakerFactory dimf = qlDateIntervalMakerFactory();

	dimf.setSerialClass(serial_Class->getEventDate());

	boost::shared_ptr<DateIntervalMaker> ql_dim = dimf.getDIM();
	
	QL_REQUIRE(ql_dim->dates().size() == 1 , "too many eventDate");

	const std::vector<Date>& dates = ql_dim->dates();
	const Date& eventDate =  dates.front();
	
	ql_iec = boost::shared_ptr<QuantLib::IEventCheck>(
										new QuantLib::NormalEC(thisEventSymbol,
																ql_eit,
																ql_fe,
																ql_pb,
																ql_subEvents,
																ql_fsubJE,
																eventDate));	

	return ql_iec;
}
boost::shared_ptr<QuantLib::IEventCheck> qlEventCheckFactory::getTimeEC(const boost::shared_ptr<FpmlSerialized::EventCheckTime>& serial_Class)
{
	boost::shared_ptr<QuantLib::IEventCheck> ql_iec;

	const boost::shared_ptr<QuantLib::JointEvent>& ql_identityJE = boost::shared_ptr<QuantLib::JointEvent>(new IdentityJointEvent(true));

	boost::shared_ptr<QuantLib::PayoffBase> ql_pb = boost::shared_ptr<QuantLib::PayoffBase>(new QuantLib::NullPayoff());

	boost::shared_ptr<QuantLib::JointEvent> ql_fsubJE = ql_identityJE;
	
	//boost::shared_ptr<QuantLib::JointTimeEvent> ql_timeJE = ql_identityJE;
	
	const std::string& thisEventSymbol = this->eventCheckID_;

	const boost::shared_ptr<QuantLib::EventIndexTransformation>& ql_eit = this->getEIT(serial_Class->getEventIndexTransformation());
	const boost::shared_ptr<QuantLib::FunctionEvents>& ql_fe = this->getFE(serial_Class->getFunctionEvents());
	const boost::shared_ptr<QuantLib::JointTimeEvent>& ql_JTE = this->getJTE(serial_Class->getJointTimeEvent());

	if(!serial_Class->isPayoffBase())
		ql_pb = this->getPB(serial_Class->getPayoffBase());
	
	qlDateIntervalMakerFactory dimf = qlDateIntervalMakerFactory();

	dimf.setSerialClass(serial_Class->getEventDates());

	boost::shared_ptr<DateIntervalMaker> ql_dim = dimf.getDIM();

	ql_iec = boost::shared_ptr<QuantLib::IEventCheck>(
										new QuantLib::NormalTimeEC(thisEventSymbol,
																	ql_eit,
																	ql_fe,
																	ql_pb,
																	ql_fsubJE,
																	ql_JTE,
																	*ql_dim));	


	return ql_iec;
}

//--------------------------------------------- Event Component ----------------------------------------------------------------

boost::shared_ptr<QuantLib::EventIndexTransformation> qlEventCheckFactory::getEIT(const boost::shared_ptr<FpmlSerialized::EventIndexTransformation>& serial_EIT)
{
	qlEventIndexTransformationFactory itmf = qlEventIndexTransformationFactory();
	itmf.setSerialClass(serial_EIT);
	const boost::shared_ptr<QuantLib::EventIndexTransformation>& itb = itmf.getEIT();

	return itb;

}
boost::shared_ptr<QuantLib::FunctionEvents> qlEventCheckFactory::getFE(const boost::shared_ptr<FpmlSerialized::FunctionEvents>& serial_FE)
{
	qlFunctionEventsFactory fef = qlFunctionEventsFactory();
	fef.setSerialClass(serial_FE);
	
	return fef.getFE();
	

}
boost::shared_ptr<QuantLib::PayoffBase> qlEventCheckFactory::getPB(const boost::shared_ptr<FpmlSerialized::PayoffBase>& serial_PB)
{
	qlPayoffMFactory pmf = qlPayoffMFactory();
	pmf.setSerialClass(serial_PB);
	const boost::shared_ptr<QuantLib::PayoffBase>& pb = pmf.getPB();

	return pb;
}
boost::shared_ptr<QuantLib::JointTimeEvent> qlEventCheckFactory::getJTE(const boost::shared_ptr<FpmlSerialized::JointTimeEvent>& serial_JTE)
{
	qlJointEventFactory jef_time = qlJointEventFactory();
	jef_time.setSerialClass(serial_JTE);

	return jef_time.getJTE();
}

//--------------------------------------------- Sub Event ---------------------------------------------------------------

boost::shared_ptr<QuantLib::JointEvent> qlEventCheckFactory::getF_SubJE(const boost::shared_ptr<FpmlSerialized::JointFSubEvent>& serial_JFSubE)
{
	qlJointEventFactory jef = qlJointEventFactory();
	jef.setSerialClass(serial_JFSubE);

	return jef.getJFSE();
}
boost::shared_ptr<QuantLib::SubEvents> qlEventCheckFactory::getSubEvents(const boost::shared_ptr<FpmlSerialized::JointSubEvent>& serial_JSubE)
{
	qlJointEventFactory jef_sub = qlJointEventFactory();

	jef_sub.setSerialClass(serial_JSubE);

	const boost::shared_ptr<QuantLib::JointEvent>& je = jef_sub.getJSE();
	
	//const std::vector<boost::shared_ptr<FpmlSerialized::XsdTypeToken>>& str = serial_Class->getSubEvent()->getRefEventID()->SValue();

	const std::vector<boost::shared_ptr<FpmlSerialized::SubEvent>>& serial_subEvent = serial_JSubE->getSubEvent();

	std::vector<boost::shared_ptr<QuantLib::IEventCheck>> subEventsPtr;
	
	for(Size i=0 ; i < serial_subEvent.size()  ; ++i ){

		const boost::shared_ptr<QuantLib::IEventCheck>& subEvent 
					= EventSymbolManager::instance().getSymbol(serial_subEvent[i]->getRefEventID()->SValue());

		subEventsPtr.push_back(subEvent);
	}
	
	boost::shared_ptr<QuantLib::SubEvents> ql_ses = boost::shared_ptr<QuantLib::SubEvents>(new QuantLib::SubEvents(subEventsPtr,je));

	return ql_ses;
}

}