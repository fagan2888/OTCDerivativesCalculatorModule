#include "GeneralPayoffLeg.hpp"

//클래스 형태가 아닌 기존의 Leg 를 사용해서 visitor pattern을 해야되나..?
//여기서 과거 인덱스를 만든 후에 페이오프에 따라 계산해서 Engine에 넘겨줌
//그러면 거기서 Bond가격을 계산함.


namespace QuantLib{


	GeneralPayoffLeg::GeneralPayoffLeg(const std::vector<Date>& dates,
				  const std::vector<boost::shared_ptr<MonteCoupon>>& payoff,
				  std::vector<boost::shared_ptr<Index>>& refIndex
				  ) 
			  : PayoffLeg(dates,payoff,refIndex) {
		//pastFixingNum_=0;
		//Date today = Settings::instance().evaluationDate();
		//
		//for(Size i=0;i<dates.size();++i){
		//	if(dates[i]<today){
		//		pastFixingNum_=pastFixingNum_+1;
		//	}
		//}


	}

	void GeneralPayoffLeg::value(Matrix & path, 
							Array   & payments, 
							Array   & exercises, 
							std::vector<Array> & states){
		setPastFixing(path);
		
		Size indexNum=refIndex_.size();
		Array indexFixings(indexNum);
		Array preIndexFixings(indexNum);
		
		preIndexFixings=initialIndexFixings_;
		//for(Size i=0;i<pastFixingNum_;i++){
		//	
		//		payments[i]=payoff_[i]->rate();
		//}

		for(Size i=0;i<totalFixingNum_ - pastFixingNum_;++i){
			for(Size j=0 ; j<indexNum ; ++j){
				indexFixings[j]=path[j][i];
			}
			//std::cout << "preIndexFixings : " <<preIndexFixings << std::endl;
			//std::cout << "indexFixings : " <<indexFixings << std::endl;

			payments[i]=payoff_[i]->expectedAmount(preIndexFixings,indexFixings);			
			//std::cout << "payments[" << i << "]" << payments[i] << std::endl;

			states[i]=indexFixings;
			preIndexFixings=indexFixings;
		}

	}

}

		

 //typedef std::vector<boost::shared_ptr<CashFlow> > Leg;