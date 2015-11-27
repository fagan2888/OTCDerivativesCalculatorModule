#include <ql/testClass/RangePayoffLeg.hpp>
#include <ql/testClass/RangeCoupon.hpp>

//클래스 형태가 아닌 기존의 Leg 를 사용해서 visitor pattern을 해야되나..?
//여기서 과거 인덱스를 만든 후에 페이오프에 따라 계산해서 Engine에 넘겨줌
//그러면 거기서 Bond가격을 계산함.


namespace QuantLib{


	RangePayoffLeg::RangePayoffLeg(const Date& startDate,
								   const Schedule& schedule,
								   std::vector<boost::shared_ptr<Index>>& refIndex,
								   const DayCounter& dayCounter,
								   const std::vector<Real>& couponRate,
								   const Matrix& upperTrigger,
								   const Matrix& lowerTrigger,
								   const std::vector<Real>& gearing,
								   const std::vector<Real>& spread,
								   const std::vector<Real>& capRate,
								   const std::vector<Real>& floorRate,			   
								   bool accrual = false,
								   bool isInArrears= false) 
		: PayoffLeg(schedule.dates(),refIndex) {
				
			//개수 맞는거 검정 필요.
		std::vector<Real> upperH;
		std::vector<Real> lowerH;
		Size fixingDatesNum=schedule.size();
		Size indexNum=refIndex.size();


		for(Size j=0;j<indexNum;++j){
			upperH[j]=(upperTrigger[0][j]);
			lowerH[j]=(lowerTrigger[0][j]);
		}

		payoff_.push_back(boost::shared_ptr<MonteCoupon>(
			  new RangeCoupon(10000,startDate,dates_[0],
							  0,couponRate[0],upperH,
							  lowerH,dayCounter,refIndex,gearing[1],spread[1],
							  capRate[0],floorRate[0],accrual)));


		for(Size i=1;i<fixingDatesNum;++i){

			for(Size j=0;j<indexNum;++j){
				upperH[j]=(upperTrigger[i][j]);
				lowerH[j]=(lowerTrigger[i][j]);

			}

			payoff_.push_back(boost::shared_ptr<MonteCoupon>(
				new RangeCoupon(10000,dates_[i],dates_[i+1],
							  0,couponRate[i],upperH,
							  lowerH,dayCounter,refIndex,gearing[i],spread[i],
							  capRate[i],floorRate[i],accrual)));
		}

	}

	void RangePayoffLeg::value(std::vector<Array> & path, 
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