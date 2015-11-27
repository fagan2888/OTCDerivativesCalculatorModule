#include <ql/testClass/warrantoption.hpp>

namespace QuantLib {

WarrantOption::WarrantOption(
             const boost::shared_ptr<StochasticProcessArray>& process,
			 const Handle<YieldTermStructure> & discountTS,
             Size maxSamples,
             BigNatural seed)
    : process_(process),discountTS_(discountTS),
      maxSamples_(maxSamples), seed_(seed) {
		QL_REQUIRE(discountTS_->referenceDate() == Settings::instance().evaluationDate(),
					"TS's referenceDate("<< discountTS_->referenceDate() <<") isn't same to evaluationDate("
					<< Settings::instance().evaluationDate() <<")");
        this->registerWith(process_);
		
    }


TimeGrid WarrantOption::timeGrid() const {

	const std::vector<Date> & exerciseDates = this->arguments_.exerciseTenor.dates();
	const std::vector<Date> & refixingDates = this->arguments_.refixingTenor.dates();
    
	const Size numberOfexercise = exerciseDates.size();
	const Size numberOfrefixing = refixingDates.size();
	
	if(numberOfexercise>numberOfrefixing){
		const std::vector<Date> & fixingDates=exerciseDates;
	}else{
		const std::vector<Date> & fixingDates=refixingDates;
	}

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

    const Size numberOfTimeSteps = numberOfRemainFixings;

	return TimeGrid(fixingTimes.begin(), fixingTimes.end(), numberOfTimeSteps);
}

boost::shared_ptr<ELSPricer> WarrantOption::pathPricer() const{

   /*boost::shared_ptr<GeneralizedBlackScholesProcess> process =
		  boost::dynamic_pointer_cast<GeneralizedBlackScholesProcess>(
	                                               process_->process(0));
    QL_REQUIRE(process, "Black-Scholes process required");*/

    TimeGrid theTimeGrid = timeGrid();

    const std::vector<Time> & times = theTimeGrid.mandatoryTimes();
    Size numberOfTimes = times.size();
	Size pastFixingNum=this->arguments_.pastFixingDateNum;
	const std::vector<Date> & fixings = this->arguments_.fixingDates;
	const boost::shared_ptr<StockIndex>& refIndex=arguments_.refIndex;
	DayCounter dayCounter = this->arguments_.dayCounter;
	Real initialValues = this->arguments_.initialValues;
	Real dividends = this->arguments_.dividends; // 후에 TS로 수정
	
	std::vector<Date> remainfixings;

	//오늘일자를 TS에서 가져옴.
    Date today = Settings::instance().evaluationDate();

	Size numberOfFixings = fixings.size();

	for(Size i=0;i<numberOfFixings;++i){
		if(fixings[i]>today){
			remainfixings.push_back(fixings[i]);
		}
	}

    Size numberOfRemainFixings = remainfixings.size();

	additionalStats_.resize(numberOfTimes+pastFixingNum);
    QL_REQUIRE(numberOfRemainFixings == numberOfTimes, "Invalid dates/times");
	
    std::vector<Size> timePositions(numberOfTimes);
    Array discountFactors(numberOfTimes);
	Array strikeVals(numberOfTimes);

    for (Size i = 0; i < numberOfTimes; ++i) {
        timePositions[i] = theTimeGrid.index(times[i]);
        discountFactors[i] = discountTS_->discount(times[i]);
		strikeVals[i] = 


    }
	
	Matrix KIbarrierValues_Chg(numAssets,64*numberOfTimes,0.0);

	Real x0;
	Real drift(numAssets);
	Real sigma(numAssets);
	
	const std::vector<Real>& earlyExValues = this->arguments_.earlyExTriggers;

		if(process_->process(i)->x0()<0.00001){
			
			x0[i]=std::log((refIndex[i]->fixing(Settings::instance().evaluationDate()))/initialValues[i]);
			underlyingValue_[i]=refIndex[i]->fixing(Settings::instance().evaluationDate());
		}else{
			x0[i]=std::log((process_->process(i)->x0())/initialValues[i]);
			underlyingValue_[i]=process_->process(i)->x0();
		}
		

    return boost::shared_ptr<WarrantPricer>(
                    new WarrantPricer(times,process_,x0,discountFactors,pastFixingNum,seed_,additionalStats_));
}


}

