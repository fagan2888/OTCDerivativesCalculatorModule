#include <ql/testClass/ELSGeneralPricer.hpp>
#include <valarray>
#include <random>
#include <iostream>
#include <math.h>
#include <fstream>
namespace QuantLib {

ELSGeneralPricer::ELSGeneralPricer(//const boost::shared_ptr<PayoffLeg> & payoffLeg,
                       const std::vector<Time> & times,
					   const boost::shared_ptr<StochasticProcessArray>& process,
					   const Array & x0_def,
					   const std::vector<Real>& underValue,
					   const std::vector<Real>& dividendValue,
					   const Array & discounts,
					   const Array & KIRedemPayoff,// Digital 이 아니고 S1,S2 값에 Depend하는 경우 필요 
                       const Matrix & earlyExValues_Chg,
					   const Matrix & KIbarrierValues_Chg,
					   const std::vector<Real>& KIbarrierValue,
					   const std::vector<Real>& earlyExValue,
					   const std::vector<Real>& redemCoupon,
					   const TimeGrid& timeGrid,
					   Size pastFixingNum,
					   Size seed,
					   std::vector<Statistics>& additionalStats,
					   CheckKIType checkKIType,
					   bool KIflag=false
					   )
    :  times_(times), process_(process),x0_def_(x0_def),underValue_(underValue), dividendValue_(dividendValue), discounts_(discounts),KIRedemPayoff_(KIRedemPayoff),
	   earlyExValues_Chg_(earlyExValues_Chg),KIbarrierValues_Chg_(KIbarrierValues_Chg),KIbarrierValue_(KIbarrierValue),earlyExValue_(earlyExValue),
	   redemCoupon_(redemCoupon),timeGrid_(timeGrid),pastFixingNum_(pastFixingNum),additionalStats_(additionalStats),
	   seed_(seed),checkKIType_(checkKIType),KIflag_(KIflag),monthlyflag_(false){

		//Trigger 계산.
		numberOfAssets_ = process_->size();
		const Size numberOfTimes = times_.size();
		this->numberOfTimes_ =times_.size();
		
		S_Up_.resize(numberOfAssets_);
		S_Down_.resize(numberOfAssets_);
		Vol_Up_.resize(numberOfAssets_);
		Vol_Down_.resize(numberOfAssets_);

		delta_.resize(numberOfAssets_);
		gamma_.resize(numberOfAssets_);
		vega_.resize(numberOfAssets_);

		step_h_.resize(numberOfAssets_);

		Matrix corr = process->correlation();

		vol_=Array(numberOfAssets_,Null<Real>());
		sigmaDt_=Matrix(numberOfAssets_,numberOfTimes,Null<Real>());

		vol_def_=Array(numberOfAssets_,Null<Real>());
		sigmaDt_def_=Matrix(numberOfAssets_,numberOfTimes,Null<Real>());
		
		chol_=CholeskyDecomposition(corr);

		if(checkKIType_==DailyKI){m_=6;}
		else if(checkKIType_==ContiKI){m_=7;}
		else{
			monthlyflag_=true;
			m_=2;}

		bridgeGridNum_=pow(2.0,static_cast<int>(m_))+1;		
		
		for(Size i=0;i<numberOfAssets_;++i){

			step_h_[i] = underValue_[i] * 0.01;
			vol_def_[i]=(process_->process(i)->diffusion(times_[0],1.0));
			sigmaDt_def_[i][0]=(process_->process(i)->diffusion(times_[0],1.0))*pow(times_[0],0.5);
			for(Size j=1;j<numberOfTimes;++j){
				//redemption위치의 vol, time-varing vol은 아직 구현 안했뜸.
				//vol_[i][j]=(process_->process(i)->diffusion(times_[0],1.0))*pow(times_[j],0.5); // timeVaring Vol 일때 수정해야함.
				sigmaDt_def_[i][j]=(process_->process(i)->diffusion(times_[0],1.0))*pow((times_[j]-times_[j-1]),0.5);
				
			}

		}

		this->resetPara();
		
}	
		
void ELSGeneralPricer::setInformation() const
{
	const std::vector<Real>& earlyExValues = this->earlyExValue_;
	const Size numberOfTimes = times_.size();
	Size powM=pow(2.0,static_cast<int>(m_));

	Array drift(numberOfAssets_);

	for(Size i=0;i<numberOfAssets_;++i){

		drift[i]= process_->process(i)->drift(times_[0],1.0);// - dividendValue_[i]; //discountTS_->zeroRate(times.back(),Compounded,Annual,false);
		

		//KIRedemPayoffs[i]=exp((drift[i]-0.5*sigma_[i]*sigma[i])*times.back());

		//drift 이거 dividend 추가해야함.

		for(Size j=0;j<numberOfTimes;++j){
			earlyExValues_Chg_[i][j]=(std::log(earlyExValues[j])-(drift[i]-0.5*vol_[i]*vol_[i])*times_[j]);
			
			//for(Size k=0;k<(64*numberOfTimes);++k){
			for(Size k=0;k<powM;++k){
				KIbarrierValues_Chg_[i][powM*j+k]=(std::log(KIbarrierValue_[i])-(drift[i]-0.5*vol_[i]*vol_[i])*(timeGrid_[j]+timeGrid_.dt(j)*static_cast<Real>(k)/static_cast<Real>(powM)));
				
			}
//			std::cout << KIbarrierValues_Chg << std::endl;
//			std::cout << " --------------------------------------------------------------"<< std::endl;
		}
} 
}


inline bool ELSGeneralPricer::checkEarlyRedem(std::valarray<double>& SumdZ,Size i) const {
	bool redem=true;
	for(Size asset=0;asset<numberOfAssets_;++asset){
			redem=redem && (SumdZ[asset] > earlyExValues_Chg_[asset][i]);
		}
	return redem;

}

inline bool ELSGeneralPricer::checkKI(std::valarray<double>& SumdZ,Size i) const {
bool KI=KIflag_;
	for(Size asset=0;asset<numberOfAssets_;++asset){
		if(SumdZ[asset] < KIbarrierValues_Chg_[asset][i]){
			KI=true;
		}
	}
	return KI;

}

inline Real ELSGeneralPricer::SumdZMin(std::valarray<double>& SumdZ) const {
	Real min=SumdZ[0];
	for(Size asset=1;asset<numberOfAssets_;++asset){
		if(min>SumdZ[asset]){
			min=SumdZ[asset];
		}
	}
	return min;

	
}

inline Real ELSGeneralPricer::slopePayoff(std::valarray<double>& SumdZ) const {
	Real min=SumdZ[0];
	Size numSumdZ=0;
	for(Size asset=1;asset<numberOfAssets_;++asset){
		if(min>SumdZ[asset]){
			min=SumdZ[asset];
			numSumdZ=asset;
		}
	}

	return KIRedemPayoff_[numSumdZ]*std::exp(min);

}

std::vector<Real> ELSGeneralPricer::delta() const {return delta_;}
std::vector<Real> ELSGeneralPricer::gamma() const {return gamma_;}
std::vector<Real> ELSGeneralPricer::vega() const {return vega_;}

std::vector<Real> ELSGeneralPricer::Sup() const {return S_Up_;}
std::vector<Real> ELSGeneralPricer::SDown() const {return S_Down_;}
std::vector<Real> ELSGeneralPricer::VolUp() const {return Vol_Up_;}
std::vector<Real> ELSGeneralPricer::VolDown() const {return Vol_Down_;}

std::vector<Real> ELSGeneralPricer::step_h() const {return step_h_;}


void ELSGeneralPricer::resetPara() const 
{
		this->x0_ = this->x0_def_;
		this->vol_ = this->vol_def_;
		this->sigmaDt_ = this->sigmaDt_def_;
}

Real ELSGeneralPricer::values(Size simulNum) const {
	
	for(Size i=0;i<numberOfAssets_;++i){

		// Delta
		x0_[i] = x0_def_[i] + 0.00995033085316809; // ln(1.01) = 0.00995033085316809; , ln(1.01*St/S0) = ln(1.1) + ln(St/S0)
		S_Up_[i] = 10000 * (this->eachValues(simulNum)/simulNum);
		this->resetPara();
		
		x0_[i] = x0_def_[i]  -0.0100503358535015; // ln(0.99) = -0.0100503358535015; , ln(0.99*St/S0) = ln(1.1) + ln(St/S0)
		S_Down_[i] = 10000 * (this->eachValues(simulNum)/simulNum);
		this->resetPara();

		// Vega
			// VOL 1% UP TICK

		vol_[i] = (process_->process(i)->diffusion(times_[0],1.0)) + 0.01;
		sigmaDt_[i][0] = ( vol_[i] )*pow(times_[0],0.5);
		
		for(Size j=1;j<numberOfTimes_;++j){
			sigmaDt_[i][j] = ( vol_[i] )*pow((times_[j]-times_[j-1]),0.5);
		}
		
		this->setInformation();

		Vol_Up_[i] = 10000 * (this->eachValues(simulNum)/simulNum);

		this->resetPara();
		
			// VOL 1% DOWN TICK
		
		vol_[i] = (process_->process(i)->diffusion(times_[0],1.0)) - 0.01;
		sigmaDt_[i][0] = ( vol_[i] )*pow(times_[0],0.5);

		for(Size j=1;j<numberOfTimes_;++j){
			sigmaDt_[i][j] = ( vol_[i] )*pow((times_[j]-times_[j-1]),0.5);
		}

		this->setInformation();

		Vol_Down_[i] = 10000 * (this->eachValues(simulNum)/simulNum);

		this->resetPara();

		this->setInformation();

	}

	for ( Size i=0 ;i<additionalStats_.size() ; i++)
	{
		additionalStats_[i].reset();
	}

	// Default
		Real S_value = 10000*(this->eachValues(simulNum)/simulNum);

	for(Size i=0;i<numberOfAssets_;++i){
		
		delta_[i] = ( S_Up_[i] - S_Down_[i] ) / ( 2 * step_h_[i] ) ;
		gamma_[i] = ( S_Up_[i] - 2*S_value + S_Down_[i] ) / (2 * step_h_[i]*step_h_[i]);
		vega_[i] = ( Vol_Up_[i] - Vol_Down_[i] ) / 2 ;

	}
	
	return ( S_value / 10000.0 );

}

Real ELSGeneralPricer::eachValues(Size simulNum) const {
		
        //Size numberOfAssets = process_->size();

        QL_REQUIRE(numberOfAssets_ > 0, "there must be some paths");

        const Size numberOfTimes = times_.size();

		Array values(numberOfTimes, 0.0); // 조기상환 시점의 value

		//Array drift(numberOfAssets, 0.0); 
		//Array sigma(numberOfAssets_, 0.0);
		//
		//for(Size i=0;i<numberOfAssets_;++i){
		//	//drift[i]=process_->process(i)->drift(times_[0],1.0);  //time-Varing 일 경우 수정
		//	sigma[i]=process_->process(i)->diffusion(times_[0],1.0);
		//}

		Matrix states(numberOfAssets_,numberOfTimes,Null<Real>()); //index 저장용. bridge를 위한.
		
		//Array vol(2);
		
		Size BridgeInCount=0;
		Size testCount=0;

		bool earlyExflag;


		Size h,jmax,imin,ii,ll,rr;
		
		Matrix W(numberOfAssets_,bridgeGridNum_,0.0);

		Real aa=0.0;  //bridge aa + bb*Z 형태 Drift에 해당.
		Matrix bb(numberOfTimes,m_,0.0);
//		Matrix bridgeVol(numberOfTimes,m,0.0);
		
		/*Size kkk;
		std::cout << " Seed : " ;
		std::cin >> kkk ;*/
	
		PseudoRandom::rsg_type gen =
				PseudoRandom::make_sequence_generator(simulNum*numberOfAssets_ * numberOfTimes, seed_);
			
		PseudoRandom::rsg_type bridgeGen =
				PseudoRandom::make_sequence_generator(numberOfAssets_ * (bridgeGridNum_-1)*numberOfTimes, seed_+1);

		std::valarray<double> bridgePath(numberOfAssets_);
		std::valarray<double> bridgeRand(numberOfAssets_);

		for(Size i=0;i<m_;++i){		
			bb[0][i]=std::pow(pow(times_[0]/std::pow(2.0,static_cast<double>(i+1)),2.0)/(times_[0]/std::pow(2.0,static_cast<double>(i))),0.5);

			for(Size j=1;j<numberOfTimes;++j){
				bb[j][i]=std::pow(pow((times_[j]-times_[j-1])/std::pow(2.0,static_cast<double>(i+1)),2.0)/((times_[j]-times_[j-1])/std::pow(2.0,static_cast<double>(i))),0.5);

			}
		}

		//--------------------------------simul------------------------
		
		const std::vector<Real>& path = gen.nextSequence().value;
		std::vector<Real>::const_iterator randSeqIter = path.begin();
		
		std::valarray<double> SumdZ(numberOfAssets_); 
		bool KI;
		Size InErr=0;
		
		for(Size j=0 ;j<simulNum;++j){
		
			for(Size asset=0;asset<numberOfAssets_;++asset){
				SumdZ[asset]=x0_[asset];
			}
			
			KI=KIflag_;
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

				//SumdZ1=(*randSeqIter)*sigmaDt_[0][i];
				//SumdZ2+=(corrCoff_[0]*(*randSeqIter)+corrCoff_[1]*(*(randSeqIter+1)))*sigmaDt_[1][i];
				
				//시간에 대한 vol로 계산 해서 집어 넣어야함.

				if (checkEarlyRedem(SumdZ,i))	{
					values[i]+= 1+redemCoupon_[pastFixingNum_+i];
					additionalStats_[pastFixingNum_+i].add(1+redemCoupon_[pastFixingNum_+i]);
					earlyExflag=true;
					break;
				}
				
				if(KI==false){
					if(checkKI(SumdZ,(i+1)*(bridgeGridNum_-1)-1)){
						KI=true;
					}
				}
			}
			
			Size bridgemyCount = 0;
			Size position = 0;

			if (KI==false && earlyExflag==false){  //뒤에서 부터 오는게 좋은가?

				//std::srand(j);
				//int uniR = std::rand();
				unsigned long myseed = static_cast<unsigned long>(j);
				std::tr1::mt19937 eng(myseed);
				std::tr1::normal_distribution<double> dist;

				//const std::vector<Real> bridgePath = bridgeGen.nextSequence().value; //	

				//Array bridgeRand(numberOfAssets_);

				for(int j=numberOfTimes-1;j>=0;--j){
					
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
				
							for(Size randCount=0;randCount<numberOfAssets_;++randCount){
								bridgePath[randCount]=dist(eng);
							}

							for(Size assetRow=0;assetRow<numberOfAssets_;++assetRow){
								aa=(W[assetRow][ll]+W[assetRow][rr])/2;
								Real randZ=0.0;
								
								for(Size assetCol=0;assetCol<assetRow+1;++assetCol){
									//randZ+=(*(bridgeiter+assetCol))*chol_[assetRow][assetCol];
									randZ+=bridgePath[assetCol]*chol_[assetRow][assetCol];
									bridgemyCount = bridgemyCount + 1 ;

								}
								
								W[assetRow][ii]=aa+randZ*bb[j][l] * vol_[assetRow]; //matrix 곱하기 나중에 구현.
								bridgeRand[assetRow]=W[assetRow][ii];
								
							}

							//position=position+numberOfAssets_;


							if(checkKI(bridgeRand,(bridgeGridNum_-1)*j+ii)){
									
								values[numberOfTimes-1]+= slopePayoff(SumdZ);
								additionalStats_[pastFixingNum_+numberOfTimes-1].add(slopePayoff(SumdZ));
									
								KI=true;
								//BridgeInCount=BridgeInCount+1;
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
			}

			else
			if(KI==true && earlyExflag==false){
				InErr=InErr+1;
					values[numberOfTimes-1]+= slopePayoff(SumdZ);
					additionalStats_[pastFixingNum_+numberOfTimes-1].add(slopePayoff(SumdZ));
				
			}
		bridgeEnd:;
		}
	Real discountedValue = DotProduct(values, discounts_);
    return discountedValue;

	}
}
