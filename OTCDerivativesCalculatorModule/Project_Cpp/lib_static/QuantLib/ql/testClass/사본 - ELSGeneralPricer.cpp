#include <ql/testClass/OptionPayoffPricer.hpp>
#include <iostream>
#include <math.h>
#include <fstream>
namespace QuantLib {

OptionPayoffPricer::OptionPayoffPricer(const boost::shared_ptr<StochasticProcessArray>& process,
									   const TimeGrid& timegrid,
									   const std::vector<Time> & times,
									   const Array & discounts,
									   const OptionPayoff& optionPayoff,
									   Size seed,
									   )
    :  process_(process),discounts_(discounts),optionPayoff_(optionPayoff) {


}	
		

Real OptionPayoffPricer::values(Size simulNum) const {
		
        Size numberOfAssets = process_->size();

        QL_REQUIRE(numberOfAssets_ > 0, "there must be some paths");

        const Size numberOfTimes = timeGrid_.size();

	    Array finalPrice(numAssets, 0.0);

		PseudoRandom::rsg_type gen =
			PseudoRandom::make_sequence_generator(simulNum*numberOfAssets_ * numberOfTimes, seed_);
        
		Array asset = process_->initialValues();		
        Size m = process_->size();

		for(Size k=0;k<simulNum;++k){
			for(Size i=0;i<numberOfTimes;++i){
				
				t = timeGrid_[i-1];
                dt = timeGrid_.dt(i-1);

				asset = process_->evolve(t, asset, dt, temp);

				for (j = 0; j < numAssets; j++)
					finalPrice[j] = process_;

			}

			optionPayoff_.value(asset);

		}

		

		Real discountedValue = DotProduct(values, discounts_);
		return discountedValue;

	}
}
