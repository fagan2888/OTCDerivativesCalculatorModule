//엔진에 종속되는 INDEX 변환은 여기서 처리함.

#include <ql/testClass/IRDLSPricer.hpp>
#include <fstream>
namespace QuantLib {

    IRDLSPricer::IRDLSPricer(
                       const boost::shared_ptr<PayoffLeg> & payoffLeg,
                       const std::vector<Size> & timePositions,
					   const boost::shared_ptr<StochasticProcessArray>& process,
                       const Array & discounts,
					   std::vector<Statistics>& additionalStats)
    :  payoffLeg_(payoffLeg), timePositions_(timePositions), process_(process),discounts_(discounts) 
	  ,additionalStats_(additionalStats){
	
  		Matrix corr = process_->correlation();
  		chol_=CholeskyDecomposition(corr);
		
		indexType_=payoffLeg_->indexType();

		
	}

    Real IRDLSPricer::values(const std::vector<Real>& rand,Size simul) const {
		//std::ofstream fout;
		//fout.open("nonLS");
		std::vector<Real>::const_iterator randSeqIter = rand.begin();

		Real value=0.0;
        Size n = rand.size();
        QL_REQUIRE(n > 0, "the path cannot be empty");

        Size numberOfAssets = process_->size();
        QL_REQUIRE(numberOfAssets > 0, "there must be some paths");

        const Size numberOfTimes = timePositions_.size();

		//const std::vector<Real>& rand2(rand.begin()+(numberOfTimes*simul),rand.end());
			
		//----------------- corr부분 3이상의 경우 수정 요망 --------------------
		std::vector<std::vector<Real>> randz(numberOfAssets);
		
		for(Size i=0;i<numberOfAssets;++i){
			randz[i]=std::vector<Real>(rand.begin()+(numberOfTimes*simul)*i,rand.begin()+(numberOfTimes*simul)*(i+1));
		
		}

		// 그냥 case 문으로 감. 그게 속도 차원에서도 더 나을듯.
		//for(Size i=0;i<simul*numberOfTimes;++i){
		//	for(Size assetRow=1;assetRow<numberOfAssets;++assetRow){
		//		for(Size assetCol=0;assetCol<assetRow;++assetCol){
		//			randz[assetRow][i] += randz[assetCol][i]*chol_[assetRow][assetCol];
		//		}
		//	}
		//}
		//----------------------------------------------------------------------
		Size  randzSize=simul*numberOfTimes;
		switch (numberOfAssets) {
			
			case 1:

				break;

			case 2:
				{
					const Real chol_1_0=chol_[1][0];
					const Real chol_1_1=chol_[1][1];

					for(Size i=0;i<randzSize;++i){
						randz[1][i] = chol_1_0 * randz[0][i] + chol_1_1 * randz[1][i];
					}

					break;
				}

			case 3:
				{
					const Real chol_1_0=chol_[1][0];	const Real chol_1_1=chol_[1][1];
					const Real chol_2_0=chol_[2][0];	const Real chol_2_1=chol_[2][1];	const Real chol_2_2=chol_[2][2];

					for(Size i=0;i<randzSize;++i){
						randz[2][i] = chol_2_0 * randz[0][i] + chol_2_1 * randz[1][i] + chol_2_2 * randz[1][i]; //randz[1][i] 이 갱신되므로 randz[2][i]를 먼저 계산함.
						randz[1][i] = chol_1_0 * randz[0][i] + chol_1_1 * randz[1][i];
					}

					break;
				}
			case 4:
				{
					const Real chol_1_0=chol_[1][0];	const Real chol_1_1=chol_[1][1];
					const Real chol_2_0=chol_[2][0];	const Real chol_2_1=chol_[2][1];	const Real chol_2_2=chol_[2][2];
					const Real chol_3_0=chol_[3][0];	const Real chol_3_1=chol_[3][1];	const Real chol_3_2=chol_[3][2];	const Real chol_3_3=chol_[3][3];

					for(Size i=0;i<randzSize;++i){
						randz[2][i] = chol_3_0 * randz[0][i] + chol_3_1 * randz[1][i] + chol_3_2 * randz[2][i] + chol_3_3 * randz[3][i]; //randz[1][i] 이 갱신되므로 randz[2][i]를 먼저 계산함.
						randz[2][i] = chol_2_0 * randz[0][i] + chol_2_1 * randz[1][i] + chol_2_2 * randz[2][i]; //randz[1][i] 이 갱신되므로 randz[2][i]를 먼저 계산함.
						randz[1][i] = chol_1_0 * randz[0][i] + chol_1_1 * randz[1][i];
					}

					break;
				
				}
				
				break;

			case 5:
				{
					const Real chol_1_0=chol_[1][0];	const Real chol_1_1=chol_[1][1];
					const Real chol_2_0=chol_[2][0];	const Real chol_2_1=chol_[2][1];	const Real chol_2_2=chol_[2][2];
					const Real chol_3_0=chol_[3][0];	const Real chol_3_1=chol_[3][1];	const Real chol_3_2=chol_[3][2];	const Real chol_3_3=chol_[3][3];
					const Real chol_4_0=chol_[4][0];	const Real chol_4_1=chol_[4][1];	const Real chol_4_2=chol_[4][2];	const Real chol_4_3=chol_[4][3];	const Real chol_4_4=chol_[4][4];

					for(Size i=0;i<randzSize;++i){
						randz[4][i] = chol_4_0 * randz[0][i] + chol_4_1 * randz[1][i] + chol_4_2 * randz[2][i] + chol_4_3 * randz[3][i] + chol_4_4 * randz[4][i]; //randz[1][i] 이 갱신되므로 randz[2][i]를 먼저 계산함.
						randz[3][i] = chol_3_0 * randz[0][i] + chol_3_1 * randz[1][i] + chol_3_2 * randz[2][i] + chol_3_3 * randz[3][i]; //randz[1][i] 이 갱신되므로 randz[2][i]를 먼저 계산함.
						randz[2][i] = chol_2_0 * randz[0][i] + chol_2_1 * randz[1][i] + chol_2_2 * randz[2][i]; //randz[1][i] 이 갱신되므로 randz[2][i]를 먼저 계산함.
						randz[1][i] = chol_1_0 * randz[0][i] + chol_1_1 * randz[1][i];
					}

					break;
				
				}


				break;

			default:
				QL_FAIL("too many underlying Num.");

				
		}


		//



		std::vector<std::vector<Array>> paths(numberOfAssets);

		Array initial_r0=process_->initialValues(); //한방에 나오나?
		
		for(Size i=0;i<numberOfAssets;++i){
			paths[i]=std::vector<Array>(simul,Array(numberOfTimes, Null<Real>()));
			for(Size j=0;j<simul;++j){	
				//[0]에다가 initial값을 넣고 나중에 0+1시점으로 바꿔치기 함.
				paths[i][j][0]=initial_r0[i];
			}
			process_->process(i)->indexAdjustment(paths[i],randz[i],indexType_[i]);
			
		}

		Array exercises;
		std::vector<Array> states(numberOfTimes);

		Array values(numberOfTimes, 0.0);
		std::vector<Array> path(numberOfAssets);

		for(Size k=0;k<simul;++k){
			for(Size j=0;j<numberOfAssets;++j){
				path[j]=paths[j][k];
				
			}
		//	std::cout << "path[0] :" << path[0] << std::endl;
		//	std::cout << "path[1] :" << path[1]<< std::endl;

			payoffLeg_->value(path, values, exercises, states);

		//	std::cout << "values :" << values<< std::endl;


			for(Size i=0;i<numberOfTimes;i++){
				additionalStats_[i].add(values[i]);
			}

			//Real discountedValue = DotProduct(values, discounts_)+discounts_.back()*10000 ;
			//fout << discountedValue << std::endl;
		}

			//Real discountedValue = DotProduct(values, discounts_);
			//value+=discountedValue ;
		
		for(Size i=0;i<numberOfTimes;i++){
			value+=additionalStats_[i].mean()*discounts_[i];
		}

        return value;
    }

}










//
//Real IRDLSPricer::values(const std::vector<Real>& rand,Size simul) const {
//
//		//std::vector<Real>::const_iterator randSeqIter = rand.begin();
//		
//		
//
//
//		Real value=0.0;
//        Size n = rand.size();
//        QL_REQUIRE(n > 0, "the path cannot be empty");
//
//        Size numberOfAssets = process_->size();
//        QL_REQUIRE(numberOfAssets > 0, "there must be some paths");
//
//        const Size numberOfTimes = timePositions_.size();
//			
//		//----------------- corr부분 3이상의 경우 수정 요망 --------------------
//		std::vector<std::vector<Real>> randz;
//		randz[0]=rand;
//		if(numberOfAssets==2){
//			for(Size i=0;i<simul*numberOfTimes;){
//				randz[1]=corrCoff_[0]*rand[i]+corrCoff_[1]*rand[i+1];
//				i=i+2;
//			}
//		}
//		//----------------------------------------------------------------------
//
//
//		std::vector<Matrix> paths(numberOfAssets);
//
//		Array initial_r0=process_->initialValues(); //한방에 나오나?
//		
//		Array evolveRate(numberOfAssets,0.0);
//		Real preRate=0.0;
//
//		//corr 고려해서 하는거 추가해야함.
//		//for(Size k=0;k<simul;++k){
//			//----------------그냥 1 index 랑 2 index랑 박아버리자. 매트릭스로 가기엔...ㅡ.ㅠ
//			//for (Size j = 0; j < numberOfAssets; ++j){
//
//			//if(numberOfAssets==2){
//			for(Size i=0;i<numberOfAssets;++i){
//				paths[i]=Matrix(simul, numberOfTimes, Null<Real>());
//				for(Size j=0;j<simul;++j){	
//					paths[i][j][0]=initial_r0[i];
//				}
//				process_->process(i)->indexAdjustment(paths[i],randz[i],indexType_[i]);
//				
//			}
//
//				/*evolveRate[0]=process_->process(0)->evolveSaved(initial_r0[0],*randSeqIter,1);
//				path[0][0] = process_->process(0)->indexAdjustment(evolveRate[0],1,indexType_[0]);
//				evolveRate[1]=process_->process(1)->evolveSaved(initial_r0[1],corrCoff_[0]*(*randSeqIter)+corrCoff_[1]*(*(randSeqIter+1)),1);
//				path[1][0] = process_->process(1)->indexAdjustment(evolveRate[1],1,indexType_[1]);
//				*/
//
//				//for (Size i = 1; i <numberOfTimes; ++i) {
//				//	//convert instantanious Rate -> Spot Rate
//				//	randSeqIter++;
//				//	randSeqIter++;
//
//				//	/*evolveRate[0]=process_->process(0)->evolveSaved(evolveRate[0],*randSeqIter,i+1);
//				//	path[0][i] = process_->process(0)->indexAdjustment(evolveRate[0],i+1,indexType_[0]);
//
//				//	evolveRate[1]=process_->process(1)->evolveSaved(evolveRate[1],corrCoff_[0]*(*randSeqIter)+corrCoff_[1]*(*(randSeqIter+1)),i+1);
//				//	path[1][i] = process_->process(1)->indexAdjustment(evolveRate[1],i+1,indexType_[1]);*/
//				//	
//				//}
//				//
//				//randSeqIter++;
//				//randSeqIter++;
//			//}else{QL_REQUIRE(numberOfAssets==2,"IndexNum must be two");}
//			//}
//		
//			Array exercises;
//			std::vector<Array> states(numberOfTimes);
//
//			Array values(numberOfTimes, 0.0);
//
//			//std::cout << path << std::endl;
//			
//			payoffLeg_->value(paths, values, exercises, states);
//
//			for(Size i=0;i<numberOfTimes;i++){
//				additionalStats_[i].add(values[i]);
//			}
//			
//			//Real discountedValue = DotProduct(values, discounts_);
//			//value+=discountedValue ;
//		}
//		for(Size i=0;i<numberOfTimes;i++){
//				value+=additionalStats_[i].mean()*discounts_[i];
//			}
//
//        return value;
//    }
//
