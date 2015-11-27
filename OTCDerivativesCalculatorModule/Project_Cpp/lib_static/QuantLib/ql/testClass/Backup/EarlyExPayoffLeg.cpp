#include "EarlyExPayoffLeg.hpp"
//#include "EarlyExPayoff.hpp"

//클래스 형태가 아닌 기존의 Leg 를 사용해서 visitor pattern을 해야되나..?
//여기서 과거 인덱스를 만든 후에 페이오프에 따라 계산해서 Engine에 넘겨줌
//그러면 거기서 Bond가격을 계산함.


namespace QuantLib{

	EarlyExPayoffLeg::EarlyExPayoffLeg(const std::vector<Date>& dates,
				  const std::vector<boost::shared_ptr<MonteCoupon>>& payoff,
				  const boost::shared_ptr<RedemptionPayoff>& exPayoff,
				  std::vector<boost::shared_ptr<Index>>& refIndex
				  ) 
			  : PayoffLeg(dates,payoff,refIndex),exPayoff_(exPayoff) {



	}

	void EarlyExPayoffLeg::value(Matrix & path, 
				Array   & payments, 
				Array   & exercises, 
				std::vector<Array> & states){
		
		Size indexNum=refIndex_.size();
		Array indexFixings(indexNum);

		/*if(!earlyExFlag_){
			for(Size i=0;i<totalFixingNum_ - pastFixingNum_;++i){
				indexFixings[j]=path[j][i];
			}

			payments[i]=payoff_[i]->expectedAmount(preIndexFixings,indexFixings);
			payoff_[i]->checkFlag();
			states[i]=indexFixings;
			preIndexFixings=indexFixings;

		}*/



		//for(Size i=0;i<totalFixingNum_;++i){
		//	for(Size j=0 ; j<indexNum ; ++j){
		//		indexFixings[j]=path[j][i];
		//	}

		//	if(exPayoff_->isExpiry(i,indexFixings)) {
		//		if(!earlyExFlag_){
		//			exercises[i]=exPayoff_->value(indexFixings);
		//			earlyExFlag_=true;
		//		}
		//	}else{
		//		if(!earlyExFlag_){
		//			payments[i]=payoff_[i]->expectedRate(preIndexFixings,indexFixings);
		//		}
		//	}
		//}		
		//
		//		
		//for(Size i=0;i<totalFixingNum_;++i){
		//	for(Size j=0 ; j<indexNum ; ++j){
		//		indexFixings[j]=path[j][i];
		//	}
		//	payments[i]=payoff_[i]->expectedRate(indexFixings);
		//}
		//상환. 조기상환의 경우 다시 짜야함.
		payments.back()=payments.back()+payoff_.back()->nominal();

		}
	}

	//Leg& EarlyExPayoffLeg::leg(){
	//	
	//	if(leg_.empty()){
	//		for(Size i=0;i<totalFixingNum_;++i){
	//			leg_.push_back(payoff_[i]);
	//		}
	//	}
	//	return leg_;
	//}

		

 //typedef std::vector<boost::shared_ptr<CashFlow> > Leg;