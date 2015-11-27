#include "qlJointEventFactory.hpp"
#include <boost/algorithm/string/case_conv.hpp>

using boost::algorithm::to_upper_copy;
using namespace QuantLib;

namespace XmlFactory {
	
qlJointEventFactory::qlJointEventFactory()
{
}
	
boost::shared_ptr<JointEvent> qlJointEventFactory::getJFE()
{
	return jointFunctionEvent_;
}

boost::shared_ptr<JointEvent> qlJointEventFactory::getJSE()
{
	return jointSubEvent_;
}

boost::shared_ptr<JointEvent> qlJointEventFactory::getJFSE()
{
	return jointFSubEvent_;
}

boost::shared_ptr<JointTimeEvent> qlJointEventFactory::getJTE()
{
	return jointTimeEvent_;
}

void qlJointEventFactory::setSerialClass(const boost::shared_ptr<FpmlSerialized::JointFunctionEvent>& serial_jfe)
{
	std::valarray<bool> tfs;

	const std::string& setOper = serial_jfe->getJointType()->SValue();
	const std::vector<boost::shared_ptr<FpmlSerialized::Function>>& serial_function = serial_jfe->getFunctions()->getFunction();

	tfs.resize(serial_function.size());

	for(Size i=0;i < serial_function.size();++i)
	{
		tfs = serial_function[i]->getTruefalse()->BValue();
	}
		
	jointFunctionEvent_ = this->build(tfs,setOper);

}

void qlJointEventFactory::setSerialClass(const boost::shared_ptr<FpmlSerialized::JointSubEvent>& serial_jse)
{
	std::valarray<bool> tfs;
	const std::string& setOper = serial_jse->getJointType()->SValue();
	const std::vector<boost::shared_ptr<FpmlSerialized::SubEvent>>& serial_subEvent = serial_jse->getSubEvent(); //getRefEventID()->SValue();

	tfs.resize(serial_subEvent.size());

	for(Size i=0;i < serial_subEvent.size();++i)
	{
		tfs[i] = serial_subEvent[i]->getTruefalse()->BValue();
	}
		
	jointSubEvent_ = this->build(tfs,setOper);

}

void qlJointEventFactory::setSerialClass(const boost::shared_ptr<FpmlSerialized::JointFSubEvent>& serial_jfse)
{
	std::valarray<bool> tfs(2);
	const std::string& setOper = serial_jfse->getJointType()->SValue();
	//const std::string& setOper = "And";
	
	bool mainTF = serial_jfse->getMainEvent()->BValue();
	bool subTF = serial_jfse->getSubEvent()->BValue();
	
	tfs[0] = mainTF;
	tfs[1] = subTF;
		
	jointFSubEvent_ = this->build(tfs,setOper);

}

void qlJointEventFactory::setSerialClass(const boost::shared_ptr<FpmlSerialized::JointTimeEvent>& serial_jte)
{
	this->jointTimeEvent_ = boost::shared_ptr<QuantLib::JointTimeEvent>(new QuantLib::JointTimeEvent(2));
	
}

boost::shared_ptr<JointEvent> qlJointEventFactory::build(std::valarray<bool> tfs,const std::string& setOper)
{
	boost::shared_ptr<JointEvent> je;

	//  subEvent 에서 그냥 symbol만 가져오려고 하는 경우 "identity" 도 만들어야함? 2013-02-21

	if(to_upper_copy(setOper) == "AND" )
	{
		je = boost::shared_ptr<JointEvent>(new AndJointEvent(tfs));
	}
	else if(to_upper_copy(setOper) == "OR")
	{
		je = boost::shared_ptr<JointEvent>(new ORJointEvent(tfs));
	}
	else
	{
		QL_FAIL("unknown joint type");
	}
	
	return je;
}

boost::shared_ptr<QuantLib::JointTimeEvent> qlJointEventFactory::timeBuild(const std::string& setOper)
{
	QL_FAIL("not Implemented");

	//jointTimeEvent_

	
}

}
