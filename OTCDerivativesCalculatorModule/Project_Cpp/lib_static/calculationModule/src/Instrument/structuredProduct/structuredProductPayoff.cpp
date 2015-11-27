#include "structuredProductPayoff.hpp"

namespace QuantLib {

StructuredProductPayoff::StructuredProductPayoff(const std::vector<boost::shared_ptr<IEventCheck>>& eventChecks,
													Calendar calendar)
: calendar_(calendar) , eventChecks_(eventChecks)
{
	this->ECNum_ = eventChecks.size();

	for(Size i=0;i < ECNum_ ;++i){
		eventChecksPtr_[i] = eventChecks[i].get();
		
	}

	this->variableBind();
	
	// setGridInitialize 는 engine에서 set함.
	// EventCheck를 payoffDate순으로 정렬함.
	RemainNotional_ = initialNotional_;
	sampleCount_ = 0;
	autoCall_=false;
}



Calendar StructuredProductPayoff::calendar() const
{
	return this->calendar_;
}

Size StructuredProductPayoff::assetNum() const{
	return assetNum_;
}

const Array& StructuredProductPayoff::value() const {
	return value_;
}

void StructuredProductPayoff::reset() const{
	
	autoCall_ = false;

	for(Size i=0;i<ECNum_;++i){
		eventChecksPtr_[i]->reset();
	}
}

void StructuredProductPayoff::autoCall(){
	this->autoCall_=true;
}

//autoCall은 여기서 처리해야게씀. 2012-11-29
void StructuredProductPayoff::setGridInitialize(const TimeGrid& timeGrid){
	
	this->timeGrid_ = timeGrid;
	value_ = Array(timeGrid_.size(),0.0);

	payoffIndexLocation_.resize(ECNum_); //차후에 만기일 이후에 PAYOFF가 나오는경우 생각해야함.

	//for(Size i=0;i<ECNum_;++i){
	//	//eventChecks_[i]->Initialize();
	//	payoffIndexLocation_[i]=eventChecksPtr_[i]->payoffIndexLocation();
	//}

}

void StructuredProductPayoff::calculate(){

	//QL_REQUIRE(timeGrid_.size() > 0, "timeGrid must be set." );

	bool bindingFlag = true;

	Size ecSize = ECNum_;

	for(Size i = 0 ; i < ecSize ; ++i )
	{
		if(!bindingFlag){
			QL_FAIL("no history or positionPtr binding ");
			break;
		}

		bindingFlag = eventChecksPtr_[i]->bindingFlag();
		eventChecksPtr_[i]->calculate();
		//value_[payoffIndexLocation_[i]] += eventChecksPtr_[i]->payoff();

	}
}

std::vector<Date> StructuredProductPayoff::indexFixingDates()
{
	std::vector<Date> fixings;
	
	for(Size i=0 ; i < ECNum_ ; ++i)
	{
		const std::vector<Date>& returnedFixings = this->eventChecksPtr_[i]->indexFixingDates();
		fixings.insert(fixings.begin(),returnedFixings.begin(),returnedFixings.end());
	}

	return fixings;
}


std::vector<Date> StructuredProductPayoff::payoffDates()
{
	std::vector<Date> fixings;
	
	for(Size i=0 ; i < ECNum_ ; ++i)
	{
		const std::vector<Date>& returnedPayoffDates = this->eventChecksPtr_[i]->payoffDates();
		fixings.insert(fixings.begin(),returnedPayoffDates.begin(),returnedPayoffDates.end());
	}

	return fixings;
}


void StructuredProductPayoff::variableBind()
{
	for(Size i=0 ; i < ECNum_ ; ++i)
	{
		this->eventChecksPtr_[i]->variableBind();
	}
}

void StructuredProductPayoff::variablePtrBind()
{
	for(Size i=0 ; i < ECNum_ ; ++i)
	{
		this->eventChecksPtr_[i]->variablePtrBind();
	}
}

void StructuredProductPayoff::validFixingDates()
{
	for(Size i=0 ; i < ECNum_ ; ++i)
	{
		this->eventChecksPtr_[i]->validFixingDates();
	}
}

void StructuredProductPayoff::historyCalculate()
{
	for(Size i=0 ; i < ECNum_ ; ++i)
	{
		this->eventChecksPtr_[i]->historyCalculate();
	}
}

}//namespace End