#include "SubEvents.hpp"

namespace QuantLib {

SubEvents::SubEvents(bool identity)
{
	EventCheckNum_ = 0;
	
	this->joint_ = boost::shared_ptr<QuantLib::JointEvent>(new IdentityJointEvent(identity));

	this->jointPtr_ = this->joint_.get();

}

SubEvents::SubEvents(const std::vector<boost::shared_ptr<IEventCheck>>& subEvents,
					const boost::shared_ptr<JointEvent>& joint)
: subEvents_(subEvents), joint_(joint)
{
	
	EventCheckNum_ = subEvents.size();

	for(Size i = 0 ; i < EventCheckNum_; ++i )
		subEventsPtr_[i] = subEvents_[i].get();

	jointPtr_ = joint_.get();

	QL_REQUIRE(EventCheckNum_ == jointPtr_->jointSize() , "subEvent size must be same to jointEventSize");

}

bool SubEvents::eventOcc()
{
	std::valarray<bool> tfs(this->EventCheckNum_);

	for(Size i = 0 ; i < EventCheckNum_; ++i )
		tfs[i] = subEventsPtr_[i]->eventOcc();

	return jointPtr_->checkJoint(tfs);
}

Size SubEvents::eventCheckNum()
{
	return EventCheckNum_;
}


}

