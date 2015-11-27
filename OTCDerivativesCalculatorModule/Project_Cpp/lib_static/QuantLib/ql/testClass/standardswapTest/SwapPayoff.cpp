#include <ql/testClass/standardswapTest/swappayoff.hpp>

namespace QuantLib {

	SwapPayoff::SwapPayoff(const std::vector<boost::shared_ptr<EventCheck>>& eventChecksPay,
						   Calendar payCalendar,
						   const std::vector<boost::shared_ptr<EventCheck>>& eventChecksReceive,
						   Calendar receiveCalendar)
	: eventChecksPay_(eventChecksPay), payCalendar_(payCalendar),
	  eventChecksReceive_(eventChecksReceive), receiveCalendar_(receiveCalendar)
	{
		// setGridInitialize �� engine���� set��.
		// EventCheck�� payoffDate������ ������.
		RemainNotionalPay_ = initialNotionalPay_;
		RemainNotionalReceive_ = initialNotionalReceive_;
		sampleCount_ = 0;
		autoCall_=false;
	}

Size SwapPayoff::assetNumPay() const{
	return assetNumPay_;
}
Size SwapPayoff::assetNumReceive() const{
	return assetNumReceive_;
}

const Array& SwapPayoff::payValue() const {
	return payValue_;
}
const Array& SwapPayoff::receiveValue() const {
	return receiveValue_;
}

void SwapPayoff::reset() const{

	autoCall_ = false;

	for(Size i=0;i<eventChecksPay_.size() ;++i){
		eventChecksPay_[i]->reset();
	}
	for(Size i=0;i<eventChecksReceive_.size();++i){
		eventChecksReceive_[i]->reset();
	}
}

void SwapPayoff::receiveAutoCall(){
	this->autoCall_=true;
}

//autoCall�� ���⼭ ó���ؾ߰Ծ�. 2012-11-29
void SwapPayoff::setGridInitialize(const TimeGrid& timeGrid){
	
	this->timeGrid_ = timeGrid;
	payValue_ = Array(timeGrid_.size(),0.0);
	receiveValue_ = Array(timeGrid_.size(),0.0);

	payoffIndexLocationPay_.resize(eventChecksPay_.size()); //���Ŀ� ������ ���Ŀ� PAYOFF�� ������ ��� �����ؾ���.
	payoffIndexLocationReceive_.resize(eventChecksReceive_.size()); //���Ŀ� ������ ���Ŀ� PAYOFF�� �����°�� �����ؾ���.

	for(Size i=0;i<eventChecksPay_.size() ;++i){
		eventChecksPay_[i]->gridInitialize(timeGrid_,payCalendar_);
		payoffIndexLocationPay_[i]=eventChecksPay_[i]->payoffIndexLocation();
	}

	for(Size i=0;i<eventChecksReceive_.size();++i){
		eventChecksReceive_[i]->gridInitialize(timeGrid_,receiveCalendar_);
		payoffIndexLocationReceive_[i]=eventChecksReceive_[i]->payoffIndexLocation();
	}

}

void SwapPayoff::calculate(const MultiPath& multiPath){

	QL_REQUIRE(timeGrid_.size() > 0, "timeGrid must be set." );

		Size i=0;

		while(!autoCall_ && i < ECPayNum_){
			eventChecksPay_[i]->calculate(multiPath);
			payValue_[payoffIndexLocationPay_[i]] += eventChecksPay_[i]->payoff(multiPath);
			i=i+1;
		}
		
		//for(Size i=0;i<eventChecksReceive_.size();++i){
		//	eventChecksReceive_[i]->calculate(multiPath);
		//	receiveValue_[payoffIndexLocationReceive_[i]] += eventChecksReceive_[i]->payoff(multiPath);
		//}
	}
}



}//namespace End