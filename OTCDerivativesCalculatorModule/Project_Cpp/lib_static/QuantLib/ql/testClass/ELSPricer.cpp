#include <ql/testClass/ELSPricer.hpp>
#include <iostream>
#include <math.h>
#include <fstream>
namespace QuantLib {

ELSPricer::ELSPricer(//const boost::shared_ptr<PayoffLeg> & payoffLeg,
                       const std::vector<Time> & times,
					   const boost::shared_ptr<StochasticProcessArray>& process,
					   const Array & x0,
					   const Array & discounts,
					   const Array & KIRedemPayoff,// Digital 이 아니고 S1,S2 값에 Depend하는 경우 필요 
                       const Matrix & earlyExValues_Chg,
					   const Matrix & KIbarrierValues_Chg,
					   const std::vector<Real>& redemCoupon,
					   Size pastFixingNum,
					   Size seed,
					   std::vector<Statistics>& additionalStats,
					   bool KIflag=false)
    :  times_(times), process_(process),x0_(x0),discounts_(discounts),KIRedemPayoff_(KIRedemPayoff),
	   earlyExValues_Chg_(earlyExValues_Chg),KIbarrierValues_Chg_(KIbarrierValues_Chg),
	   redemCoupon_(redemCoupon),pastFixingNum_(pastFixingNum),additionalStats_(additionalStats),
	   seed_(seed),KIflag_(KIflag){

		//Trigger 계산.
		Size numberOfAssets = process_->size();
		const Size numberOfTimes = times_.size();

		Matrix corr = process->correlation();

		//vol_=Matrix(numberOfAssets,numberOfTimes,Null<Real>());
		vol_=Array(numberOfAssets,Null<Real>());
		sigmaDt_=Matrix(numberOfAssets,numberOfTimes,Null<Real>());

		chol_=CholeskyDecomposition(corr);
		
		corrCoff_=Array(2);
		corrCoff_[0]=chol_[1][0];
		corrCoff_[1]=chol_[1][1];
		
		
		for(Size i=0;i<numberOfAssets;++i){

			//x0[i]=
			//vol_[i][0]=(process_->process(i)->diffusion(times_[0],1.0))*pow(times_[0],0.5); 
			vol_[i]=(process_->process(i)->diffusion(times_[0],1.0));
			sigmaDt_[i][0]=(process_->process(i)->diffusion(times_[0],1.0))*pow(times_[0],0.5);
			for(Size j=1;j<numberOfTimes;++j){
				//redemption위치의 vol, time-varing vol은 아직 구현 안했뜸.
				//vol_[i][j]=(process_->process(i)->diffusion(times_[0],1.0))*pow(times_[j],0.5); // timeVaring Vol 일때 수정해야함.
				sigmaDt_[i][j]=(process_->process(i)->diffusion(times_[0],1.0))*pow((times_[j]-times_[j-1]),0.5);
				
			}
		}
		

}	

Real ELSPricer::values(Size simulNum) const {
		
        //QL_REQUIRE(n > 0, "the path cannot be empty");
		//std::ofstream fout;
		//std::ofstream fout_whole;
		//std::ofstream fout_KI;

		//fout.open("filename");
		//fout_whole.open("filenameWhole");
		//fout_KI.open("filenameKI");

		//Size beforeErr=0;
		//Size InErr=0;

        Size numberOfAssets = process_->size();

        QL_REQUIRE(numberOfAssets > 0, "there must be some paths");

        const Size numberOfTimes = times_.size();

		Array values(numberOfTimes, 0.0); // 조기상환 시점의 value

		//Array drift(numberOfAssets, 0.0); 
		Array sigma(numberOfAssets, 0.0);
		
		for(Size i=0;i<numberOfAssets;++i){
			//drift[i]=process_->process(i)->drift(times_[0],1.0);  //time-Varing 일 경우 수정
			sigma[i]=process_->process(i)->diffusion(times_[0],1.0);
		}
		Matrix states(numberOfAssets,numberOfTimes,Null<Real>()); //index 저장용. bridge를 위한.
		
		//Array vol(2);
		
		Size BridgeInCount=0;
		Size testCount=0;

		bool earlyExflag;

		Size m=6; // 나누는 개수.
		Size bridgeGridNum=pow(2.0,static_cast<int>(m))+1;
		Size h,jmax,imin,ii,ll,rr;
		
		Matrix W(numberOfAssets,bridgeGridNum,0.0);

		Real aa=0.0;  //bridge aa + bb*Z 형태 Drift에 해당.
		Matrix bb(numberOfTimes,m,0.0);
//		Matrix bridgeVol(numberOfTimes,m,0.0);
	
		PseudoRandom::rsg_type gen =
				PseudoRandom::make_sequence_generator(simulNum*numberOfAssets * numberOfTimes, seed_);

		PseudoRandom::rsg_type bridgeGen =
				PseudoRandom::make_sequence_generator(numberOfAssets * (bridgeGridNum-1)*2, seed_+1);
		


		for(Size i=0;i<m;++i){		
			//bb[0][i]=0.5*pow(times_[0],0.5);
			//bb[0][i]=pow(times_[0]/std::pow(2.0,static_cast<double>(i+1)),0.5);
			bb[0][i]=std::pow(pow(times_[0]/std::pow(2.0,static_cast<double>(i+1)),2.0)/(times_[0]/std::pow(2.0,static_cast<double>(i))),0.5);

			for(Size j=1;j<numberOfTimes;++j){
				//bb[j][i]=pow((times_[j]-times_[j-1]),0.5)/std::pow(2.0,static_cast<double>(i*0.5+1));
				//std::cout <<  (times_[j]-times_[j-1]) << std::endl;
				//std::cout <<  std::pow(2.0,static_cast<double>(i+1)) << std::endl;

				//bb[j][i]=std::pow((times_[j]-times_[j-1])/std::pow(2.0,static_cast<double>(i+1)),0.5);
				bb[j][i]=std::pow(pow((times_[j]-times_[j-1])/std::pow(2.0,static_cast<double>(i+1)),2.0)/((times_[j]-times_[j-1])/std::pow(2.0,static_cast<double>(i))),0.5);
				//std::cout <<  bb[j][i] << std::endl;

			}
		}
//		std::cout << bb<< std::endl;
		//--------------------------------simul------------------------
		
		const std::vector<Real>& path = gen.nextSequence().value;
		std::vector<Real>::const_iterator randSeqIter = path.begin();
		
		//for(Size i=0;i<path.size();++i){
		//	fout << *(randSeqIter+i);
		//	fout << std::endl;

		//}
		Real SumdZ1; Real SumdZ2; bool KI;
		Size InErr=0;
		
		for(Size j=0 ;j<simulNum;++j){
		
			SumdZ1=x0_[0];	SumdZ2=x0_[1];
			
			KI=KIflag_;
			earlyExflag=false;
			for (Size i = 0; i <numberOfTimes; ++i) {
				
				SumdZ1+=(*randSeqIter)*sigmaDt_[0][i];
				SumdZ2+=(corrCoff_[0]*(*randSeqIter)+corrCoff_[1]*(*(randSeqIter+1)))*sigmaDt_[1][i];
				/*std::cout << "SumdZ1 : " << SumdZ1 <<std::endl;
				std::cout << "SumdZ2 : " << SumdZ2 <<std::endl;
				std::cout << "randSeqIter : " << *randSeqIter <<std::endl;
				std::cout << "randSeqIter+1 : " << *(randSeqIter+1) <<std::endl;

				std::cout << "corrCoff_[0] : " << corrCoff_[0] <<std::endl;
				std::cout << "corrCoff_[1] : " << corrCoff_[1] <<std::endl;

				std::cout << "sigmaDt_[0]["<< i <<"] : " << sigmaDt_[0][i] <<std::endl;
				std::cout << "sigmaDt_[1]["<< i <<"] : " << sigmaDt_[1][i] <<std::endl;
*/


				++randSeqIter; ++randSeqIter;
				states[0][i]=SumdZ1;
				states[1][i]=SumdZ2;

				//시간에 대한 vol로 계산 해서 집어 넣어야함.

				if (SumdZ1 > earlyExValues_Chg_[0][i] && //1번만 비교할때는 Trigger를 낮춰서 해도 대겠다.
					SumdZ2 > earlyExValues_Chg_[1][i])
				{
					values[i]+= 1+redemCoupon_[pastFixingNum_+i];
					additionalStats_[pastFixingNum_+i].add(1+redemCoupon_[pastFixingNum_+i]);
					earlyExflag=true;
					break;
				}
				
				if(KI==false){
					//fout_KI << j << " "<<SumdZ1 <<" "<<KIbarrierValues_Chg_[0][(i+1)*(bridgeGridNum-1)-1] <<" "<<SumdZ2 <<" "<< KIbarrierValues_Chg_[1][(i+1)*(bridgeGridNum-1)-1] << " KI " << KI <<" "<< earlyExflag<<std::endl;
					if(SumdZ1 < KIbarrierValues_Chg_[0][(i+1)*(bridgeGridNum-1)-1] || //2012-04-13
					   SumdZ2 < KIbarrierValues_Chg_[1][(i+1)*(bridgeGridNum-1)-1])
					{
						KI=true;
						
					}
				}
			}

			if (KI==false && earlyExflag==false){  //뒤에서 부터 오는게 좋은가?

				testCount=testCount+1;
				for(int j=numberOfTimes-1;j>=0;--j){
					//if(KI==true){break;}

					//const std::vector<Real>& bridgePath = bridgeGen.nextSequence().value;
					std::vector<Real>::const_iterator bridgeiter = bridgeGen.nextSequence().value.begin();
					
					for(Size asset=0;asset<numberOfAssets;++asset){
						//W[asset][0]=vol_[asset][j-1]*states[asset][j-1];
						//W[asset][bridgeGridNum-1]=vol_[asset][j]*states[asset][j];
						if(j==0){
							W[asset][0]=x0_[asset];
						}else{
							W[asset][0]=states[asset][j-1];
						}
						
						W[asset][bridgeGridNum-1]=states[asset][j];
					}
					
					h=bridgeGridNum-1;jmax=1;

					for(Size l=0;l<m;++l){
						//if(KI==true){break;}				

						imin=h/2;ii=imin;
						ll=0,rr=h;
//						std::cout << "chol_[0][0] : " << chol_[0][0] << "   " << "chol_[0][1] : "<< chol_[0][1]<< std::endl;
//						std::cout << "chol_[1][0] : " << chol_[1][0] << "   " << "chol_[1][1] : "<< chol_[1][1]<< std::endl;
						for(Size jj=0;jj<jmax;++jj){
							
							for(Size asset=0;asset<numberOfAssets;++asset){
								aa=(W[asset][ll]+W[asset][rr])/2;
//								std::cout << "W[" << asset << "]["<<ll<<"]" << W[asset][ll] << std::endl;
//								std::cout << "W[" << asset << "]["<<rr<<"]" << W[asset][rr] << std::endl;
//								std::cout << "aa[" << asset << "] : "<< aa << std::endl;
//								std::cout << "RandomNum : " << ( chol_[asset][0] * (*bridgeiter) + chol_[asset][1] * (*(bridgeiter+1)) ) << std::endl;
//								std::cout << "bb["<<j<<"][" << l << "] : "<< bb[j][l] << std::endl;

								W[asset][ii]=aa+( chol_[asset][0] * (*bridgeiter) + chol_[asset][1] * (*(bridgeiter+1)) )*bb[j][l] * vol_[asset]; //matrix 곱하기 나중에 구현.
//								std::cout << "W[" << asset << "]["<<ii<<"]" << W[asset][ii] << std::endl;
								bridgeiter=bridgeiter+2;
							}

//							std::cout << "KIbarrierValues_Chg_[0][" << 64*j+ii << "] : "<< KIbarrierValues_Chg_[0][64*j+ii] << std::endl;
//							std::cout << "KIbarrierValues_Chg_[1][" << 64*j+ii << "] : "<< KIbarrierValues_Chg_[1][64*j+ii] << std::endl;
							//std::cout << "W : " << W << std::endl;
		
							if(W[0][ii]<KIbarrierValues_Chg_[0][64*j+ii] || 
								W[1][ii] < KIbarrierValues_Chg_[1][64*j+ii]){
									//std::cout << "W[0]["<< ii << "]" << W[0][ii] <<std::endl;
									//std::cout << "W[1]["<< ii << "]" << W[1][ii] <<std::endl;


									if(SumdZ1>SumdZ2){
										values[numberOfTimes-1]+= KIRedemPayoff_[1]*exp(SumdZ2);
										additionalStats_[pastFixingNum_+numberOfTimes-1].add(KIRedemPayoff_[1]*exp(SumdZ2));
										//additionalStats_[0].add(KIRedemPayoff_[1]*exp(SumdZ2));
									}
									else{
										values[numberOfTimes-1]+= KIRedemPayoff_[0]*exp(SumdZ1);
										additionalStats_[pastFixingNum_+numberOfTimes-1].add(KIRedemPayoff_[0]*exp(SumdZ1));
										//additionalStats_[0].add(KIRedemPayoff_[0]*exp(SumdZ1));
									}
									
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
				
				values[numberOfTimes-1]+= 1+redemCoupon_[pastFixingNum_+numberOfTimes-1];
				additionalStats_[pastFixingNum_+numberOfTimes-1].add(1+redemCoupon_[pastFixingNum_+numberOfTimes-1]);
				//additionalStats_[1].add(1+redemCoupon_*(pastFixingNum_+numberOfTimes));
			}

			else 
			//fout_whole << j << " "<<SumdZ1 <<" "<< SumdZ2 << " whole " << KI <<" "<< earlyExflag<<std::endl;
			//beforeErr=beforeErr+1;
			if(KI==true && earlyExflag==false){
				InErr=InErr+1;
				if(SumdZ1>SumdZ2){
					values[numberOfTimes-1]+= KIRedemPayoff_[1]*exp(SumdZ2);
					
					//additionalStats_[numberOfTimes-1].add(KIRedemPayoff_[1]*exp(SumdZ2));

					additionalStats_[pastFixingNum_+numberOfTimes-1].add(KIRedemPayoff_[1]*exp(SumdZ2));
					//additionalStats_[2].add(KIRedemPayoff_[1]*exp(SumdZ2));
			//		fout << j << " "<<SumdZ1 <<" "<< SumdZ2 << " " << (KIRedemPayoff_[1]*exp(SumdZ2)) << " a " << KI <<" "<< earlyExflag<<std::endl;
					
				}
				else{
					values[numberOfTimes-1]+= KIRedemPayoff_[0]*exp(SumdZ1);
					
					//additionalStats_[numberOfTimes-1].add(KIRedemPayoff_[0]*exp(SumdZ1));
					additionalStats_[pastFixingNum_+numberOfTimes-1].add(KIRedemPayoff_[0]*exp(SumdZ1));
					//additionalStats_[2].add(KIRedemPayoff_[0]*exp(SumdZ1));
			//		fout << j << " "<<SumdZ1 <<" "<< SumdZ2 << " " << (KIRedemPayoff_[1]*exp(SumdZ1)) << " b " << KI <<" "<< earlyExflag<<std::endl;
				}
				
			}
		bridgeEnd:;
		}
	Real discountedValue = DotProduct(values, discounts_);
	/*for(Size z=0;z<numberOfTimes;++z){
		std::cout << "additionalStats_["<< z <<"] : "<<additionalStats_[z].samples() <<std::endl;
		
	}
	std::cout << "BridgeNotInCount            : "<< BridgeInCount <<std::endl;*/
    return discountedValue;

	}
}
