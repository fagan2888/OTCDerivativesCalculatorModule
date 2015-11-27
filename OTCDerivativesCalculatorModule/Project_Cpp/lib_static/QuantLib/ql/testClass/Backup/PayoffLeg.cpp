#include "PayoffLeg.hpp"

//클래스 형태가 아닌 기존의 Leg 를 사용해서 visitor pattern을 해야되나..?
//여기서 과거 인덱스를 만든 후에 페이오프에 따라 계산해서 Engine에 넘겨줌
//그러면 거기서 Bond가격을 계산함.


namespace QuantLib{


	PayoffLeg::PayoffLeg(const std::vector<Date>& dates,
				  const std::vector<boost::shared_ptr<MonteCoupon>>& payoff,
				  std::vector<boost::shared_ptr<Index>>& refIndex
				  ) 
			  : dates_(dates),payoff_(payoff),refIndex_(refIndex) {

				  QL_REQUIRE(!payoff_.empty(), "no monteCoupon given");
				  QL_REQUIRE(!refIndex_.empty(), "no Index given");
				  QL_REQUIRE(payoff.size()==dates.size(), "payoff number must be same to paymentdate number");
				  
				  totalFixingNum_=dates.size();
				  initialize();
				  Redemption_=payoff.back()->nominal();
  				  initialIndexFixings_=Array(refIndex.size());

				  for(Size i=0;i<refIndex.size();++i){
					  initialIndexFixings_[i]=refIndex[i]->fixing(payoff[pastFixingNum_]->accrualStartDate());
				  }

	}

	void PayoffLeg::setRefIndex(const std::vector<boost::shared_ptr<Index>>& refIndex){
		refIndex_=refIndex;
	}

	void PayoffLeg::setPastFixing(Matrix & path){
		//index isValidFixingDate 이거 나중에 엔진에 돌기 시작할때 검사. 또는 상품에 처음으로 박아서 검사.
		Size numberOfAssets=path.rows();
		for(Size i=0;i<pastFixingNum_;++i){
			for(Size j=0;j<numberOfAssets ;++j){
				path[j][i]=refIndex_[j]->fixing(dates_[i]);
			}
		}
	}


	std::vector<boost::shared_ptr<MonteCoupon>> PayoffLeg::payoff() const{
		return payoff_;
	}

	void PayoffLeg::initialize(){
		Date today(Settings::instance().evaluationDate());
		pastFixingNum_=0;	  
		for(Size i=0;i<totalFixingNum_;++i){
			if(today>dates_[i]){
				pastFixingNum_+= 1;
			}
		}
		setPastCashflow();
	}

	void PayoffLeg::setPastCashflow(){
	
		for(Size i=0;i<pastFixingNum_;++i){
			pastCashflow_[i]=payoff_[i]->rate();
		}
		//leg_.push_back(new FixedRateCoupon(dates[i],1.0,payoff[i]->value(refIndex))); //이놈이 이걸 하는건 안대 engine이 해야함. 그냥 Leg와는 다름. 시뮬용이니까. 시뮬이 끝나면 결과를 떨구수는 있음. 모든 정보를 가지고있지는 않은놈임. engine이 나머지를 setting 해줄 필요도 없음. 그렇지만 해줘도 댈듯...?
	
	}
	/*std::vector<Real>& PayoffLeg::pastCashflow() const {
		return pastCashflow_;
	}*/

	Leg& PayoffLeg::leg(){
		Size FixingNum=payoff_.size();
		if(leg_.empty()){
			for(Size i=0;i<FixingNum;++i){
				leg_.push_back(payoff_[i]);
			}
		}
		/*else{
			QL_REQUIRE(!cashflows_.empty(),"Bond defualt cashflow check!");
		}*/
		return leg_;
	}
}

		

 //typedef std::vector<boost::shared_ptr<CashFlow> > Leg;