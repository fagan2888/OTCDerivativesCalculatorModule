#include <ql/testClass/ELSNotionalProtectedPricer.hpp>
#include <iostream>
#include <math.h>
#include <fstream>
namespace QuantLib {

ELSNotionalProtectedPricer::ELSNotionalProtectedPricer(//const boost::shared_ptr<PayoffLeg> & payoffLeg,
                       const std::vector<Time> & times,
					   const boost::shared_ptr<StochasticProcessArray>& process,
					   const Array & x0,
					   const Array & discounts,
                       const Matrix & earlyExValues_Chg,
					   Real redemCoupon,
					   Size pastFixingNum,
					   std::vector<Statistics>& additionalStats)
    :  times_(times), process_(process),x0_(x0),discounts_(discounts),
	   earlyExValues_Chg_(earlyExValues_Chg),redemCoupon_(redemCoupon),
	   pastFixingNum_(pastFixingNum),additionalStats_(additionalStats){

		//Trigger 계산.
		Size numberOfAssets_ = process_->size();
		const Size numberOfTimes = times_.size();

		Matrix corr = process->correlation();

		vol_=Matrix(numberOfAssets_,numberOfTimes,Null<Real>());
		sigmaDt_=Matrix(numberOfAssets_,numberOfTimes,Null<Real>());

		chol_=CholeskyDecomposition(corr);
		
		for(Size i=0;i<numberOfAssets_;++i){
			//x0[i]=
			vol_[i][0]=(process_->process(i)->diffusion(times_[0],1.0))*pow(times_[0],0.5); 
			sigmaDt_[i][0]=(process_->process(i)->diffusion(times_[0],1.0))*pow(times_[0],0.5);
			for(Size j=1;j<numberOfTimes;++j){
				//redemption위치의 vol, time-varing vol은 아직 구현 안했뜸.
				vol_[i][j]=(process_->process(i)->diffusion(times_[0],1.0))*pow(times_[j],0.5); 
				sigmaDt_[i][j]=(process_->process(i)->diffusion(times_[0],1.0))*pow((times_[j]-times_[j-1]),0.5);
				
			}
		}
		

}	
inline bool ELSNotionalProtectedPricer::checkEarlyRedem(Array& SumdZ,Size i) const {
	bool redem=true;
	for(Size asset=0;asset<numberOfAssets_;++asset){
			redem=redem && (SumdZ[asset] > earlyExValues_Chg_[asset][i]);
		}
	return redem;

}

Real ELSNotionalProtectedPricer::values(Size simulNum) const {
		


        QL_REQUIRE(numberOfAssets_ > 0, "there must be some paths");

        const Size numberOfTimes = times_.size();

		Array values(numberOfTimes, 0.0); // 조기상환 시점의 value

		Array sigma(numberOfAssets_, 0.0);
		
		for(Size i=0;i<numberOfAssets_;++i){
			//drift[i]=process_->process(i)->drift(times_[0],1.0);  //time-Varing 일 경우 수정
			sigma[i]=process_->process(i)->diffusion(times_[0],1.0);
		}
		Matrix states(numberOfAssets_,numberOfTimes,Null<Real>()); //index 저장용. bridge를 위한.
		
		Array vol(2);
		
		Size BridgeInCount=0;
		Size testCount=0;

		bool earlyExflag;

		PseudoRandom::rsg_type gen =
				PseudoRandom::make_sequence_generator(simulNum*numberOfAssets_ * numberOfTimes, 1);


		//--------------------------------simul------------------------
		
		const std::vector<Real>& path = gen.nextSequence().value;
		std::vector<Real>::const_iterator randSeqIter = path.begin();

		Array SumdZ(numberOfAssets_,0.0);
		
		for(Size j=0 ;j<simulNum;++j){
		
			for(Size asset=0;asset<numberOfAssets_;++asset){
				SumdZ[asset]=x0_[asset];
			}
			
			earlyExflag=false;
			for (Size i = 0; i <numberOfTimes; ++i) {
				
				for(Size assetRow=0;assetRow<numberOfAssets_;++assetRow){
					for(Size assetCol=0;assetCol<assetRow+1;++assetCol){
						SumdZ[assetRow]+=(*(randSeqIter+assetCol))*chol_[assetRow][assetCol]*sigmaDt_[assetRow][i];
						
						
					}
					//std::cout << " general sumdZ"<< assetRow <<" : " << SumdZ[assetRow] << std::endl;
					
				}
				randSeqIter=randSeqIter+numberOfAssets_;

				for(Size asset=0;asset<numberOfAssets_;++asset){

					states[asset][i]=SumdZ[asset];
				}
				//시간에 대한 vol로 계산 해서 집어 넣어야함.

				if (checkEarlyRedem(SumdZ,i))
				{
					values[i]+= 1+redemCoupon_*(pastFixingNum_+i+1);
					additionalStats_[pastFixingNum_+i].add(1+redemCoupon_*(pastFixingNum_+i+1));
					earlyExflag=true;
					break;
				}
			}

			if (earlyExflag==false){  //뒤에서 부터 오는게 좋은가?
				
				values[numberOfTimes-1]+= 1.0;
				additionalStats_[pastFixingNum_+numberOfTimes-1].add(1.0);
			}
		}
	Real discountedValue = DotProduct(values, discounts_);
   
	return discountedValue;

	}
}
