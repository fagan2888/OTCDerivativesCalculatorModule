#include <ql/testClass/ELSGeneralMonthlyRPricer.hpp>
#include <iostream>
#include <math.h>
#include <fstream>
namespace QuantLib {

ELSGeneralMonthlyRPricer::ELSGeneralMonthlyRPricer(//const boost::shared_ptr<PayoffLeg> & payoffLeg,
                       const std::vector<Time> & times,
					   const boost::shared_ptr<StochasticProcessArray>& process,
					   const Array & x0,
					   const Array & discounts,
					   const std::vector<bool> & earlyRedemtimePositions,
					   const Array & KIRedemPayoff,// Digital �� �ƴϰ� S1,S2 ���� Depend�ϴ� ��� �ʿ� 
                       const Matrix & earlyExValues_Chg,
					   const Matrix & KIbarrierValues_Chg,
					   const std::vector<Real>& redemCoupon,
					   Real KILossCoupon,
					   Size pastFixingNum,
					   Size pastKICount,
					   Size seed,
					   std::vector<Statistics>& additionalStats,
					   CheckKIType checkKIType=DailyKI,
					   bool KIflag=false
					   )
    //:  ELSGeneralPricer(times,process,x0,discounts,KIRedemPayoff,earlyExValues_Chg,KIbarrierValues_Chg,
	//                    redemCoupon,pastFixingNum,seed,additionalStats,checkKIType,KIflag),
	//   earlyRedemtimePositions_(earlyRedemtimePositions),KILossCoupon_(KILossCoupon),pastKICount_(pastKICount){

	:  times_(times),process_(process),x0_(x0),discounts_(discounts),earlyRedemtimePositions_(earlyRedemtimePositions),KIRedemPayoff_(KIRedemPayoff),earlyExValues_Chg_(earlyExValues_Chg),KIbarrierValues_Chg_(KIbarrierValues_Chg),
	                    redemCoupon_(redemCoupon),KILossCoupon_(KILossCoupon),pastFixingNum_(pastFixingNum),pastKICount_(pastKICount),seed_(seed),additionalStats_(additionalStats),checkKIType_(checkKIType),KIflag_(KIflag),monthlyflag_(false)
	   {

		earlyExProb_.resize(additionalStats.size());
		   
		   //Trigger ���.
			numberOfAssets_ = process_->size();
			const Size numberOfTimes = times_.size();
			
			Matrix corr = process->correlation();

			vol_=Array(numberOfAssets_,Null<Real>());
			sigmaDt_=Matrix(numberOfAssets_,numberOfTimes,Null<Real>());

			chol_=CholeskyDecomposition(corr);

			if(checkKIType_==DailyKI){m_=3;}
			else if(checkKIType_==ContiKI){m_=4;}
			else{
				monthlyflag_=true;
				m_=2;}

			bridgeGridNum_=pow(2.0,static_cast<int>(m_))+1;		
			
			for(Size i=0;i<numberOfAssets_;++i){

				vol_[i]=(process_->process(i)->diffusion(times_[0],1.0));
				sigmaDt_[i][0]=(process_->process(i)->diffusion(times_[0],1.0))*pow(times_[0],0.5);
				for(Size j=1;j<numberOfTimes;++j){
					//redemption��ġ�� vol, time-varing vol�� ���� ���� ���߶�.
					//vol_[i][j]=(process_->process(i)->diffusion(times_[0],1.0))*pow(times_[j],0.5); // timeVaring Vol �϶� �����ؾ���.
					sigmaDt_[i][j]=(process_->process(i)->diffusion(times_[0],1.0))*pow((times_[j]-times_[j-1]),0.5);
					
				}
			}

		}


inline bool ELSGeneralMonthlyRPricer::checkEarlyRedem(Array& SumdZ,Size i) const {
	bool redemFlag=true;
	
	if(earlyRedemtimePositions_[i]){ // �̰� ex �� month coupon day�� �����ϴ� flag
		for(Size asset=0;asset<numberOfAssets_;++asset){
				redemFlag=redemFlag&& (SumdZ[asset] > earlyExValues_Chg_[asset][i]);
			}
		
		

		return redemFlag;
	}
	else{
		
		return false;
		
	}

}

inline bool ELSGeneralMonthlyRPricer::checkKI(Array& SumdZ,Size i) const {

	bool KI=KIflag_;

	for(Size asset=0;asset<numberOfAssets_;++asset){
		if(SumdZ[asset] < KIbarrierValues_Chg_[asset][i]){
			KI=true;
		}
	}
	return KI;

}

inline Real ELSGeneralMonthlyRPricer::SumdZMin(Array& SumdZ) const {
	Real min=SumdZ[0];
	for(Size asset=1;asset<numberOfAssets_;++asset){
		if(min>SumdZ[asset]){
			min=SumdZ[asset];
		}
	}
	return min;
}

inline Real ELSGeneralMonthlyRPricer::slopePayoff(Array& SumdZ) const {
	Real min=SumdZ[0];
	Size numSumdZ=0;
	for(Size asset=1;asset<numberOfAssets_;++asset){
		if(min>SumdZ[asset]){
			min=SumdZ[asset];
			numSumdZ=asset;
		}
	}
	// Payoff ->  worst_S - KI_count * lossCoupon 
	return KIRedemPayoff_[numSumdZ] * std::exp(min);
	
}

inline Real ELSGeneralMonthlyRPricer::lossCountPayoff(Array& SumdZ) const {
	Real min=SumdZ[0];
	Size numSumdZ=0;
	for(Size asset=1;asset<numberOfAssets_;++asset){
		if(min>SumdZ[asset]){
			min=SumdZ[asset];
			numSumdZ=asset;
		}
	}
	// Payoff ->  1.0(����) - KI_count * lossCoupon 
	return (1.0 - static_cast<Real>(KILossCount_) * KILossCoupon_) * std::exp(min);
	
}

inline void ELSGeneralMonthlyRPricer::KIPayoff(Array& sumdZ,Size i) const {

	KILossCount_ += KILossCount_;

}



Real ELSGeneralMonthlyRPricer::values(Size simulNum) const {
		
        //Size numberOfAssets = process_->size();

        QL_REQUIRE(numberOfAssets_ > 0, "there must be some paths");

        const Size numberOfTimes = times_.size();

		Array values(numberOfTimes, 0.0); // �����ȯ ������ value

		//Array drift(numberOfAssets, 0.0); 
		Array sigma(numberOfAssets_, 0.0);
		
		for(Size i=0;i<numberOfAssets_;++i){
			//drift[i]=process_->process(i)->drift(times_[0],1.0);  //time-Varing �� ��� ����
			sigma[i]=process_->process(i)->diffusion(times_[0],1.0);
		}
		Matrix states(numberOfAssets_,numberOfTimes,Null<Real>()); //index �����. bridge�� ����.
		
		//Array vol(2);
		
		Size BridgeInCount=0;
		Size testCount=0;

		bool earlyExflag;


		Size h,jmax,imin,ii,ll,rr;
		
		Matrix W(numberOfAssets_,bridgeGridNum_,0.0);

		Real aa=0.0;  //bridge aa + bb*Z ���� Drift�� �ش�.
		Matrix bb(numberOfTimes,m_,0.0);
//		Matrix bridgeVol(numberOfTimes,m,0.0);
		
		/*Size kkk;
		std::cout << " Seed : " ;
		std::cin >> kkk ;*/
	
		PseudoRandom::rsg_type gen =
				PseudoRandom::make_sequence_generator(simulNum*numberOfAssets_ * numberOfTimes, seed_);

		PseudoRandom::rsg_type bridgeGen =
				PseudoRandom::make_sequence_generator(numberOfAssets_ * (bridgeGridNum_-1)*numberOfTimes, seed_+1);
		


		for(Size i=0;i<m_;++i){		
			bb[0][i]=std::pow(pow(times_[0]/std::pow(2.0,static_cast<double>(i+1)),2.0)/(times_[0]/std::pow(2.0,static_cast<double>(i))),0.5);

			for(Size j=1;j<numberOfTimes;++j){
				bb[j][i]=std::pow(pow((times_[j]-times_[j-1])/std::pow(2.0,static_cast<double>(i+1)),2.0)/((times_[j]-times_[j-1])/std::pow(2.0,static_cast<double>(i))),0.5);

			}
		}
		//--------------------------------simul------------------------
		
		const std::vector<Real>& path = gen.nextSequence().value;
		std::vector<Real>::const_iterator randSeqIter = path.begin();
		
		Array SumdZ(numberOfAssets_,0.0); bool KI;
		Size InErr=0;
		
		for(Size j=0 ;j<simulNum;++j){
			
			for(Size asset=0;asset<numberOfAssets_;++asset){
				SumdZ[asset]=x0_[asset];
			}
			
			KI=KIflag_;

			// montly �� �߰�
			KILossCount_=pastKICount_;

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

				if (checkEarlyRedem(SumdZ,i)) {
					values[i]+= 1.0+redemCoupon_[i];//+redemCoupon_*(pastFixingNum_+i+1);
					additionalStats_[pastFixingNum_+i].add(1.0+redemCoupon_[pastFixingNum_+i]);//+redemCoupon_*(pastFixingNum_+i+1));
					earlyExProb_[pastFixingNum_+i]+=1;
					earlyExflag=true;
					// additionalStats_�� prob���ϴ� �� �ȵ�.
					
					break;
				}
				
				if(checkKI(SumdZ,(i+1)*(bridgeGridNum_-1)-1)) {
					KIPayoff(SumdZ,i);
					KI=true;
				}else{
					values[i]+= redemCoupon_[i];
					additionalStats_[pastFixingNum_+i].add(redemCoupon_[pastFixingNum_+i]);
				}
			}
			
			if (KI==false && earlyExflag==false && monthlyflag_==false){  //�ڿ��� ���� ���°� ������?

				testCount=testCount+1;
				Array bridgeRand(numberOfAssets_);
				for(int j=numberOfTimes-1;j>=0;--j){
					std::vector<Real>::const_iterator bridgeiter = bridgeGen.nextSequence().value.begin();
					
					for(Size asset=0;asset<numberOfAssets_;++asset){
						if(j==0){
							W[asset][0]=x0_[asset];
						}else{
							W[asset][0]=states[asset][j-1];
						}
						
						W[asset][bridgeGridNum_-1]=states[asset][j];
					}
					
					h=bridgeGridNum_-1;jmax=1;

					for(Size l=0;l<m_;++l){

						imin=h/2;ii=imin;
						ll=0,rr=h;
						for(Size jj=0;jj<jmax;++jj){
				
							for(Size assetRow=0;assetRow<numberOfAssets_;++assetRow){
								aa=(W[assetRow][ll]+W[assetRow][rr])/2;
								Real randZ=0.0;
								
								for(Size assetCol=0;assetCol<assetRow+1;++assetCol){
									randZ+=(*(bridgeiter+assetCol))*chol_[assetRow][assetCol];
								}
								
								W[assetRow][ii]=aa+randZ*bb[j][l] * vol_[assetRow]; //matrix ���ϱ� ���߿� ����.
								bridgeRand[assetRow]=W[assetRow][ii];
								bridgeiter=bridgeiter+numberOfAssets_;
							}

							if(checkKI(bridgeRand,(bridgeGridNum_-1)*j+ii)){
									
								values[numberOfTimes-1]+= slopePayoff(SumdZ);
								additionalStats_[pastFixingNum_+numberOfTimes-1].add(slopePayoff(SumdZ));
								earlyExProb_[pastFixingNum_+numberOfTimes-1]+=1;
									
								KI=true;
								BridgeInCount=BridgeInCount+1;
								goto bridgeEnd;
				
							}
							ii=ii+h;	ll=ll+h;	rr=rr+h;
						
						}
						jmax=2*jmax;
						h=imin;
						
					}
					
				}
				
				values[numberOfTimes-1]+= 1;//+redemCoupon_*(pastFixingNum_+numberOfTimes);
				additionalStats_[pastFixingNum_+numberOfTimes-1].add(1.0);//+redemCoupon_*(pastFixingNum_+numberOfTimes));
				earlyExProb_[pastFixingNum_+numberOfTimes-1]+=1;
			}

			else
			if(KI==true && earlyExflag==false){
				InErr=InErr+1;
					values[numberOfTimes-1]+= slopePayoff(SumdZ);
					additionalStats_[pastFixingNum_+numberOfTimes-1].add(slopePayoff(SumdZ));
					earlyExProb_[pastFixingNum_+numberOfTimes-1]+=1;
			}
			else
			if(KI==false && earlyExflag==false && monthlyflag_==true){
				values[numberOfTimes-1]+= 1.0;
				additionalStats_[pastFixingNum_+numberOfTimes-1].add(1.0);
				earlyExProb_[pastFixingNum_+numberOfTimes-1]+=1;
			}
		bridgeEnd:;
		}
	Real discountedValue = DotProduct(values, discounts_);
    return discountedValue;

	}
}

