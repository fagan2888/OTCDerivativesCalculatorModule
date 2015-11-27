//엔진에 종속되는 INDEX 변환은 여기서 처리함.
#include "MCIRStructuredDLSEngine.hpp"
namespace QuantLib {

    IRStructuredDLSPricer::IRStructuredDLSPricer(
                                       const boost::shared_ptr<PayoffLeg> & payoffLeg,
                                       const std::vector<Size> & timePositions,
									   const boost::shared_ptr<StochasticProcessArray>& process,
                                       const Array & discounts,
									   std::vector<Statistics>& additionalStats)
    :  payoffLeg_(payoffLeg), timePositions_(timePositions), process_(process),discounts_(discounts) 
	  ,additionalStats_(additionalStats){
	
		countMe_=0;
	}

    Real IRStructuredDLSPricer::operator()(const MultiPath& multiPath) const {

		//뒤에서 부터 박음 왜냐면 나머지는 index에서 정보를 가져와서 계산 될거임.

        Size n = multiPath.pathSize();
        QL_REQUIRE(n > 0, "the path cannot be empty");

        Size numberOfAssets = multiPath.assetNumber();
        QL_REQUIRE(numberOfAssets > 0, "there must be some paths");

        const Size numberOfTimes = timePositions_.size();

        Matrix path(numberOfAssets, numberOfTimes, Null<Real>());

		//까꾸로 ㄱㄱ

		//for (Size i = 0; i <numberOfTimes; ++i) {
  //          const Size pos = timePositions_[numberOfTimes-1-i];
  //          for (Size j = 0; j < numberOfAssets; ++j)
  //              //convert instantanious Rate -> Spot Rate
		//		path[j][i] = process_->process(j)->indexAdjustment(multiPath[j][pos],pos);
		//		
  //      }
		
		for (Size i = 0; i <numberOfTimes; ++i) {
            const Size pos = timePositions_[i];

            for (Size j = 0; j < numberOfAssets; ++j)
                //convert instantanious Rate -> Spot Rate
				path[j][i] = process_->process(j)->indexAdjustment(multiPath[j][pos],pos);
        }

        Array exercises;
        std::vector<Array> states(numberOfTimes);

        Array values(numberOfTimes, 0.0);

		//std::cout << path << std::endl;

        payoffLeg_->value(path, values, exercises, states);

		for(Size i=0;i<numberOfTimes;i++){
			additionalStats_[i].add(values[i]);
		}
		
		// for 돌려서 넣어놈.
//		resultAccumulators_[].add(path[j][i]);
		
        // in this engine we ignore early exercise

        Real discountedValue = DotProduct(values, discounts_);
		
        return discountedValue;
    }

}

