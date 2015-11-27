#include <ql/testClass/GeneralPayoffLeg.hpp>

//클래스 형태가 아닌 기존의 Leg 를 사용해서 visitor pattern을 해야되나..?
//여기서 과거 인덱스를 만든 후에 페이오프에 따라 계산해서 Engine에 넘겨줌
//그러면 거기서 Bond가격을 계산함.


namespace QuantLib{


	GeneralPayoffLeg::GeneralPayoffLeg(const std::vector<Date>& dates, //accrualStartDate 사용
								  const std::vector<boost::shared_ptr<MonteCoupon>>& payoff,
								  std::vector<boost::shared_ptr<Index>>& refIndex,
								  bool isInArrears) 
		  : PayoffLeg(dates,refIndex),isInArrears_(isInArrears){

			  payoff_=payoff;
		  QL_REQUIRE(!payoff_.empty(), "no monteCoupon given");
		  QL_REQUIRE(!refIndex_.empty(), "no Index given");
		  //QL_REQUIRE(payoff.size()==dates.size(), "payoff number must be same to paymentdate number");
		  
		  Date today(Settings::instance().evaluationDate());
		  totalFixingNum_=dates.size();
		  initialize();
		  Redemption_=payoff.back()->nominal();
		  initialIndexFixings_=Array(refIndex.size());
		  

		  for(Size i=0;i<refIndex.size();++i){
			  QL_REQUIRE(today > payoff[pastFixingNum_]->accrualStartDate() , "calculation Date must be later than last fixingDate");	
			  //initialIndexFixings_[i]=refIndex[i]->fixing(payoff[pastFixingNum_]->accrualStartDate());
			  initialIndexFixings_[i]=refIndex[i]->fixing(today);
		  }
		  
		  remaintime_ = static_cast<Real>((payoff_[pastFixingNum_]->accrualEndDate()).serialNumber() - today.serialNumber())
				/static_cast<Real>(((payoff_[pastFixingNum_]->accrualEndDate()).serialNumber() - (payoff_[pastFixingNum_]->accrualStartDate().serialNumber())));

		  accrualRate_=payoff_[pastFixingNum_]->amount();

	}

	void GeneralPayoffLeg::value(std::vector<Array> & path, 
							Array   & payments, 
							Array   & exercises, 
							std::vector<Array> & states){
		//setPastFixing(path);
		
		Size indexNum=refIndex_.size();
		Array indexFixings(indexNum);
		Array preIndexFixings(indexNum);
		
		preIndexFixings=initialIndexFixings_;
		//for(Size i=0;i<pastFixingNum_;i++){
		//	
		//		payments[i]=payoff_[i]->rate();
		//}
		


		if(!isInArrears_){
			
			for(Size j=0 ; j<indexNum ; ++j){
				indexFixings[j]=path[j][0];
			}
			payments[0] = accrualRate_ + remaintime_ * payoff_[pastFixingNum_]->expectedAmount(preIndexFixings,indexFixings);
			calculatedPayment_=payments[0];

			states[0]=initialIndexFixings_;
			
			for(Size j=0 ; j<indexNum ; ++j){
				preIndexFixings[j]=path[j][0];
			}
			

			for(Size i=1;i<totalFixingNum_ - pastFixingNum_;++i){
				for(Size j=0 ; j<indexNum ; ++j){
					indexFixings[j]=path[j][i];
				}

				payments[i]=payoff_[pastFixingNum_+i]->expectedAmount(preIndexFixings,indexFixings);
				states[i]=indexFixings;
				preIndexFixings=indexFixings;
				
			}
		}
		else{

			for(Size i=0;i<totalFixingNum_ - pastFixingNum_;++i){
				for(Size j=0 ; j<indexNum ; ++j){
					indexFixings[j]=path[j][i];
				}

				payments[i]=payoff_[pastFixingNum_]->expectedArrAmount(preIndexFixings,indexFixings);			
				states[i]=indexFixings;
				preIndexFixings=indexFixings;
			}
		}

	}

}

		

 //typedef std::vector<boost::shared_ptr<CashFlow> > Leg;