#include "GeneralPayoffLeg.hpp"

//Ŭ���� ���°� �ƴ� ������ Leg �� ����ؼ� visitor pattern�� �ؾߵǳ�..?
//���⼭ ���� �ε����� ���� �Ŀ� ���̿����� ���� ����ؼ� Engine�� �Ѱ���
//�׷��� �ű⼭ Bond������ �����.


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