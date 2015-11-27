#include <ql/testClass/standardswap/swappayoff.hpp>

namespace QuantLib {

	SwapPayoff::SwapPayoff(const std::vector<boost::shared_ptr<EventCheck>>& eventChecksPay,
						   Calendar payCalendar,
						   const std::vector<boost::shared_ptr<EventCheck>>& eventChecksReceive,
						   Calendar receiveCalendar)
	: eventChecksPay_(eventChecksPay), payCalendar_(payCalendar),
	  eventChecksReceive_(eventChecksReceive), receiveCalendar_(receiveCalendar)
	{
		// setGridInitialize 는 engine에서 set함.
		// EventCheck를 payoffDate순으로 정렬함.
		RemainNotionalPay_ = initialNotionalPay_;
		RemainNotionalReceive_ = initialNotionalReceive_;
		sampleCount_ = 0;
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
	for(Size i=0;i<eventChecksPay_.size() ;++i){
		eventChecksPay_[i]->reset();
	}
	for(Size i=0;i<eventChecksReceive_.size();++i){
		eventChecksReceive_[i]->reset();
	}
} 
//autoCall은 여기서 처리해야게씀. 2012-11-29
void SwapPayoff::setGridInitialize(const TimeGrid& timeGrid){
	
	this->timeGrid_ = timeGrid;
	payValue_ = Array(timeGrid_.size(),0.0);
	receiveValue_ = Array(timeGrid_.size(),0.0);

	payoffIndexLocationPay_.resize(eventChecksPay_.size()); //차후에 만기일 이후에 PAYOFF가 나오는경우 생각해야함.
	payoffIndexLocationReceive_.resize(eventChecksReceive_.size()); //차후에 만기일 이후에 PAYOFF가 나오는경우 생각해야함.

	for(Size i=0;i<eventChecksPay_.size() ;++i){
		eventChecksPay_[i]->gridInitialize(timeGrid_,payCalendar_);
		payoffIndexLocationPay_[i]=eventChecksPay_[i]->payoffIndexLocation();
	}

	for(Size i=0;i<eventChecksReceive_.size();++i){
		eventChecksReceive_[i]->gridInitialize(timeGrid_,receiveCalendar_);
		payoffIndexLocationReceive_[i]=eventChecksReceive_[i]->payoffIndexLocation();
	}

}


//이거도 템플릿으로 박을거임.
void SwapPayoff::calculate(const MultiPath& multiPath){
	std::cout << "sampleCount : " << sampleCount_ << std::endl;
	sampleCount_ += 1;

	//우선 두개로 나누자 autoCall ...
	// 나중에 상속해서 해결
	bool autoCall_ = true;
	QL_REQUIRE(timeGrid_.size() > 0, "timeGrid must be set." );
	bool autoCallFlag = false;
	if(autoCall_){
		for(Size i=0;i<eventChecksPay_.size();++i){
			
			eventChecksPay_[i]->calculate(multiPath);
			// RemainNotionalPay_ -= eventChecksPay_[i]->amortizeAmount();
			payValue_[payoffIndexLocationPay_[i]] += eventChecksPay_[i]->payoff(multiPath);
			
			//순서는 사용자가 구분. 그냥 끝내버림.
			if(autoCallFlag) {break;}
		}
		
		//for(Size i=0;i<eventChecksReceive_.size();++i){
		//	eventChecksReceive_[i]->calculate(multiPath);
		//	receiveValue_[payoffIndexLocationReceive_[i]] += eventChecksReceive_[i]->payoff(multiPath);
		//}
	}
}



}//namespace End