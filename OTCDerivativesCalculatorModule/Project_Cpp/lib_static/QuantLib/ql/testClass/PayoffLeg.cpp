#include <ql/testClass/PayoffLeg.hpp>

//Ŭ���� ���°� �ƴ� ������ Leg �� ����ؼ� visitor pattern�� �ؾߵǳ�..?
//���⼭ ���� �ε����� ���� �Ŀ� ���̿����� ���� ����ؼ� Engine�� �Ѱ���
//�׷��� �ű⼭ Bond������ �����.


namespace QuantLib{


	PayoffLeg::PayoffLeg(const std::vector<Date>& dates,
				  //const std::vector<boost::shared_ptr<MonteCoupon>>& payoff,
				  std::vector<boost::shared_ptr<Index>>& refIndex
				  ) 
			  : dates_(dates),refIndex_(refIndex),calFlag_(false)  {

				  QL_REQUIRE(!refIndex_.empty(), "no Index given");
				  //QL_REQUIRE(payoff.size()==dates.size(), "payoff number must be same to paymentdate number");
				  
				  //totalFixingNum_=dates.size();
				  //initialize();
				  ////Redemption_=payoff.back()->nominal();
  				//  initialIndexFixings_=Array(refIndex.size());

				  for(Size i=0;i<refIndex.size();++i){
					 indexType_.push_back(refIndex_[i]->type());// initialIndexFixings_[i]=refIndex[i]->fixing(payoff[pastFixingNum_]->accrualStartDate());

				  }

				  // 2012-06-21 ������ �ε��� �˻�.?!
				  // ���� ���̿������� �ٸ������� ���� Ŀ������ ����... Instrument ���� �� �����;���.

	}

	void PayoffLeg::setRefIndex(const std::vector<boost::shared_ptr<Index>>& refIndex){
		refIndex_=refIndex;
	}

	void PayoffLeg::setPastFixing(std::vector<Array> & path){
		//index isValidFixingDate �̰� ���߿� ������ ���� �����Ҷ� �˻�. �Ǵ� ��ǰ�� ó������ �ھƼ� �˻�.
		Size numberOfAssets=path.size();
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
	
		/*for(Size i=0;i<pastFixingNum_;++i){
			pastCashflow_[i]=payoff_[i]->amout();
		}*/
		//leg_.push_back(new FixedRateCoupon(dates[i],1.0,payoff[i]->value(refIndex))); //�̳��� �̰� �ϴ°� �ȴ� engine�� �ؾ���. �׳� Leg�ʹ� �ٸ�. �ùĿ��̴ϱ�. �ù��� ������ ����� �������� ����. ��� ������ ������������ ��������. engine�� �������� setting ���� �ʿ䵵 ����. �׷����� ���൵ ���...?
	
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