#include <ql/testClass/MCELSNotionalProtectedEngine.hpp>

namespace QuantLib {

MCELSNotionalProtectedEngine::MCELSNotionalProtectedEngine(
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


TimeGrid MCELSNotionalProtectedEngine::timeGrid() const {
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

    const Size numberOfTimeSteps = numberOfRemainFixings;//timeSteps_ != Null<Size>() ? timeSteps_ : timeStepsPerYear_ * static_cast<int>(fixingTimes.back());

    //return TimeGrid(fixingTimes.begin(), fixingTimes.end(), numberOfTimeSteps);
	return TimeGrid(fixingTimes.begin(), fixingTimes.end(), numberOfTimeSteps);
}

boost::shared_ptr<ELSNotionalProtectedPricer> MCELSNotionalProtectedEngine::pathPricer() const{

   /*boost::shared_ptr<GeneralizedBlackScholesProcess> process =
		  boost::dynamic_pointer_cast<GeneralizedBlackScholesProcess>(
	                                               process_->process(0));
    QL_REQUIRE(process, "Black-Scholes process required");*/

    TimeGrid theTimeGrid = timeGrid();

    const std::vector<Time> & times = theTimeGrid.mandatoryTimes();
    Size numberOfTimes = times.size();
	Size numAssets = process_->size();
	Size pastFixingNum=this->arguments_.pastFixingDateNum;
	const std::vector<Date> & fixings = this->arguments_.fixingDates;
	const std::vector<boost::shared_ptr<StockIndex>>& refIndex=arguments_.refIndex;
	DayCounter dayCounter = this->arguments_.dayCounter;
	std::vector<Real> initialValues = this->arguments_.initialValues;
	std::vector<Real> dividends = this->arguments_.dividends; // 후에 TS로 수정

	Real redemCoupon= this->arguments_.redemCoupon;
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
	underlyingValue_.resize(numAssets);
    QL_REQUIRE(numberOfRemainFixings == numberOfTimes, "Invalid dates/times");
	
    std::vector<Size> timePositions(numberOfTimes);
    Array discountFactors(numberOfTimes);

    for (Size i = 0; i < numberOfTimes; ++i) {
        //timePositions[i] = theTimeGrid.index(times[i]);
        discountFactors[i] = discountTS_->discount(times[i]);
    }
	
	Matrix earlyExValues_Chg(numAssets,numberOfTimes,Null<Real>());

	Array x0(numAssets);
	Array drift(numAssets);
	Array sigma(numAssets);

	const std::vector<Real>& earlyExValues = this->arguments_.earlyExTriggers;

	for(Size i=0;i<numAssets;++i){
		
		if(process_->process(i)->x0()<0.00001){
			
			x0[i]=std::log((refIndex[i]->fixing(Settings::instance().evaluationDate()))/initialValues[i]);
			underlyingValue_[i]=refIndex[i]->fixing(Settings::instance().evaluationDate());
		}else{
			x0[i]=std::log((process_->process(i)->x0())/initialValues[i]);
			underlyingValue_[i]=process_->process(i)->x0();
		}
		
		sigma[i]=process_->process(i)->diffusion(times[0],1.0) ; // 변동성 조정 필요

		if(process_->process(i)->drift(times[0],1.0)<0.00001){
			drift[i]= discountTS_->zeroRate(times.back(),Compounded,Annual,false) - dividends[i]; //discountTS_->zeroRate(times.back(),Compounded,Annual,false);
		}else{
			drift[i]= process_->process(i)->drift(times[0],1.0) - dividends[i]; //discountTS_->zeroRate(times.back(),Compounded,Annual,false);
		}

		//drift 이거  dividend 추가해야함.

		for(Size j=0;j<numberOfTimes;++j){
			earlyExValues_Chg[i][j]=(std::log(earlyExValues[j])-(drift[i]-0.5*sigma[i]*sigma[i])*times[j]);
			
		}
	}

    return boost::shared_ptr<ELSNotionalProtectedPricer>(
                    new ELSNotionalProtectedPricer(times,process_,x0,discountFactors,earlyExValues_Chg,
                                  redemCoupon,pastFixingNum,additionalStats_));
}


}

