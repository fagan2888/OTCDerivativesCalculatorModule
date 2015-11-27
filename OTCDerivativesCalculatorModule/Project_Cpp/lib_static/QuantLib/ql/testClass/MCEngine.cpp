#include <ql/testClass/MCEngine.hpp>

namespace QuantLib {

MCEngine::MCEngine(
         const boost::shared_ptr<StochasticProcessArray>& process,
		 const Handle<YieldTermStructure> & discountTS,
         Size timeSteps,
         Size maxSamples,
         BigNatural seed)
: process_(process),discountTS_(discountTS), timeSteps_(timeSteps),
  maxSamples_(maxSamples), seed_(seed) {
    QL_REQUIRE(timeSteps != 0,
               "timeSteps must be positive, " << timeSteps <<
               " not allowed");
	QL_REQUIRE(discountTS_->referenceDate() == Settings::instance().evaluationDate(),
				"TS's referenceDate("<< discountTS_->referenceDate() <<") isn't same to evaluationDate("
				<< Settings::instance().evaluationDate() <<")");
    this->registerWith(process_);
}

boost::shared_ptr<PseudoRandom::rsg_type>
MCEngine::pathGenerator() const {

    boost::shared_ptr<PayoffLeg> payoffLeg = arguments_.payoffLeg;
    const std::vector<Date> & fixings = this->arguments_.fixingDates;

	Size numAssets = process_->size();
	Size numberOfFixings = fixings.size();

    QL_REQUIRE(payoffLeg, "IRStructuredDLS payoffLeg given");
			
	QL_REQUIRE(arguments_.refIndexTenor.size()==process_->size(),
			"Process Size (" << numAssets << ") must be Same to IndexSize (" << arguments_.refIndexTenor.size() << ")");

	for(Size i=0 ; i<numAssets ; ++i){
		QL_REQUIRE(arguments_.refIndexTenor[i]==process_->process(i)->tenor(), 
			"Process Tenor must be Same to refIndex Tenor");
	}

	return boost::shared_ptr<PseudoRandom::rsg_type>(&PseudoRandom::make_sequence_generator(maxSamples_* numAssets * numberOfFixings, seed_));

}

TimeGrid MCEngine::timeGrid() const {
    const std::vector<Date> & fixings = this->arguments_.fixingDates;
	const Size numberOfFixings = fixings.size();
	std::vector<Date> remainfixings;
	
	Date today = Settings::instance().evaluationDate();
	
	for(Size i=0;i<numberOfFixings;++i){
		if(fixings[i]>today){
			remainfixings.push_back(fixings[i]);
		}
	}
    const Size numberOfRemainFixings = remainfixings.size();

    std::vector<Time> fixingTimes;//(numberOfFixings); //이거 내가 추가한건가..?
    for (Size i = 0; i < numberOfRemainFixings; ++i) {
        //fixingTimes[i] = this->process_->time(fixings[i]);
		if(fixings[i]>today){
			fixingTimes.push_back(discountTS_->dayCounter().yearFraction(
                                       today, remainfixings[i]));
		}
    }

	return TimeGrid(fixingTimes.begin(), fixingTimes.end(), timeSteps_);
}


}