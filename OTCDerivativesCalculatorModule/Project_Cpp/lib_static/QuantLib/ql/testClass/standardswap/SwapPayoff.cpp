#include <ql/testClass/standardswap/swappayoff.hpp>

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
//autoCall�� ���⼭ ó���ؾ߰Ծ�. 2012-11-29
void SwapPayoff::setGridInitialize(const TimeGrid& timeGrid){
	
	this->timeGrid_ = timeGrid;
	payValue_ = Array(timeGrid_.size(),0.0);
	receiveValue_ = Array(timeGrid_.size(),0.0);

	payoffIndexLocationPay_.resize(eventChecksPay_.size()); //���Ŀ� ������ ���Ŀ� PAYOFF�� �����°�� �����ؾ���.
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


//�̰ŵ� ���ø����� ��������.
void SwapPayoff::calculate(const MultiPath& multiPath){
	std::cout << "sampleCount : " << sampleCount_ << std::endl;
	sampleCount_ += 1;

	//�켱 �ΰ��� ������ autoCall ...
	// ���߿� ����ؼ� �ذ�
	bool autoCall_ = true;
	QL_REQUIRE(timeGrid_.size() > 0, "timeGrid must be set." );
	bool autoCallFlag = false;
	if(autoCall_){
		for(Size i=0;i<eventChecksPay_.size();++i){
			
			eventChecksPay_[i]->calculate(multiPath);
			// RemainNotionalPay_ -= eventChecksPay_[i]->amortizeAmount();
			payValue_[payoffIndexLocationPay_[i]] += eventChecksPay_[i]->payoff(multiPath);
			
			//������ ����ڰ� ����. �׳� ��������.
			if(autoCallFlag) {break;}
		}
		
		//for(Size i=0;i<eventChecksReceive_.size();++i){
		//	eventChecksReceive_[i]->calculate(multiPath);
		//	receiveValue_[payoffIndexLocationReceive_[i]] += eventChecksReceive_[i]->payoff(multiPath);
		//}
	}
}



}//namespace End