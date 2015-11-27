#include <ql/testClass/MCIRDLSEngine.hpp>

namespace QuantLib {

MCIRDLSEngine::MCIRDLSEngine(
         const boost::shared_ptr<StochasticProcessArray>& process,
		 const Handle<YieldTermStructure> & discountTS,
         Size maxSamples,
         BigNatural seed)
	: process_(process),discountTS_(discountTS), maxSamples_(maxSamples),seed_(seed) {

		QL_REQUIRE(discountTS_->referenceDate() == Settings::instance().evaluationDate(),
					"TS's referenceDate("<< discountTS_->referenceDate() <<") isn't same to evaluationDate("
					<< Settings::instance().evaluationDate() <<")");
        this->registerWith(process_);
}

void MCIRDLSEngine::calculate() const {

	for(Size i=0;i<additionalStats_.size();++i) {
		additionalStats_[i].reset();
	}

	pathPricer_ = this->pathPricer();
	Size NeedRnd=randNum();
	PseudoRandom::rsg_type gen  = PseudoRandom::make_sequence_generator(NeedRnd, seed_);
	
	const std::vector<Real>& rand = gen.nextSequence().value;
	
//	const std::vector<Real>& rand = (*pathGenerator_).nextSequence().value;

	Real values=this->pathPricer_->values(rand,maxSamples_);
	
	const std::vector<Date> & fixings=this->arguments_.fixingDates;
	Size sizeOfCouponNum=fixings.size();

	Leg expectedCashflows(sizeOfCouponNum);
	
	std::vector<Real> cashflows(sizeOfCouponNum);
	std::vector<Real> cashflowsDates(sizeOfCouponNum);
	Real accruedAmount=0.0;
	
	Date today = Settings::instance().evaluationDate();
	Size numberOfPastFixings=0;
	for(Size i=0;i<sizeOfCouponNum;++i){
		if(fixings[i]<today){
			numberOfPastFixings=numberOfPastFixings+1;
		}
	}

	for(Size i=0;i<numberOfPastFixings;++i) {
		expectedCashflows[i]=boost::shared_ptr<CashFlow>(
					new SimpleCashFlow((arguments_.payoffLeg->payoff())[i]->amount(),fixings[i]));
		cashflows[i]=(arguments_.payoffLeg->payoff())[i]->amount(),fixings[i];
	}

	for(Size i=0;i<additionalStats_.size();++i) {

		expectedCashflows[sizeOfCouponNum-i-1]=boost::shared_ptr<CashFlow>(
					new SimpleCashFlow(additionalStats_[additionalStats_.size()-i-1].mean(),fixings[sizeOfCouponNum-i-1]));
		cashflows[sizeOfCouponNum-i-1]=additionalStats_[additionalStats_.size()-i-1].mean();

	}
	
	results_.additionalResults["cashflows"] = cashflows;
	for(Size i=0;i<sizeOfCouponNum;++i){
		cashflowsDates[i]=static_cast<Real>(fixings[i].serialNumber());
	}
	
	results_.additionalResults["cashflowsDates"] = cashflowsDates;
	//results_.additionalResults["accruedAmount"] = accruedAmount;

	Real Notional=arguments_.Notional;
	expectedCashflows.push_back(boost::shared_ptr<CashFlow>(new SimpleCashFlow(Notional,fixings.back())));
	//payments.back()=payments.back()+payoff_.back()->nominal();

	results_.expectedCashflows=expectedCashflows;
	
	//Leg는 이놈이 만들어서 떨궈주거나 Result에 leg만들어놓거 거기다가 박음.
	
	QL_REQUIRE(!discountTS_.empty(),
			   "discounting term structure handle is empty");

	results_.valuationDate = Settings::instance().evaluationDate();
	
	//기본적으로 우선 false로 놓자. 돈 받고 시작하는건 
	bool includeRefDateFlows =false;
		/*includeSettlementDateFlows_ ?
		*includeSettlementDateFlows_ :
		Settings::instance().includeReferenceDateCashFlows();*/

	results_.value = CashFlows::npv(results_.expectedCashflows,
									**discountTS_,
									includeRefDateFlows,
									results_.valuationDate,
									results_.valuationDate);

	// a bond's cashflow on settlement date is never taken into account
	results_.settlementValue = CashFlows::npv(results_.expectedCashflows,
											  **discountTS_,
											  false,
											  arguments_.settlementDate,
											  arguments_.settlementDate);

	results_.additionalResults["UnitValue"] = results_.value*10000/Notional;
	
}



Size MCIRDLSEngine::randNum() const {

    boost::shared_ptr<PayoffLeg> payoffLeg = arguments_.payoffLeg;
	const std::vector<Date> & fixings = this->arguments_.fixingDates;
	//std::vector<Real> dt = arguments_.refIndexMaturity;

    QL_REQUIRE(payoffLeg, "IRStructuredDLS payoffLeg given");

    Size numAssets = process_->size();
	Size numberOfFixings = fixings.size();

	QL_REQUIRE(arguments_.refIndexTenor.size()==process_->size(),
			"Process Size must be Same to IndexSize");
	
	for(Size i=0 ; i<numAssets ; ++i){
		QL_REQUIRE(arguments_.refIndexTenor[i]==process_->process(i)->tenor(), 
			"Process Tenor must be Same to refIndex Tenor");
	}

    TimeGrid grid = timeGrid();
	
	for(Size i=0 ; i<numAssets ; ++i){
		process_->process(i)->setPreCalculation(grid); // 속도를 위해 수정되었음.
	}

    //return boost::shared_ptr<PseudoRandom::rsg_type>(&PseudoRandom::make_sequence_generator(maxSamples_* numAssets * numberOfFixings, seed_));

	return maxSamples_* numAssets * numberOfFixings;
}
	
TimeGrid MCIRDLSEngine::timeGrid() const {
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
        		
			fixingTimes.push_back(discountTS_->dayCounter().yearFraction(
                                       today, remainfixings[i]));
	}

    const Size numberOfTimeSteps = numberOfFixings;

	return TimeGrid(fixingTimes.begin(), fixingTimes.end(), numberOfTimeSteps);
}

boost::shared_ptr<Pricer>
MCIRDLSEngine::pathPricer() const {

    boost::shared_ptr<PayoffLeg> payoffLeg = arguments_.payoffLeg;
    QL_REQUIRE(payoffLeg, "IRStructuredDLS payoffLeg given");

	//수정 필요.
    //boost::shared_ptr<GeneralizedBlackScholesProcess> process =
    //    boost::dynamic_pointer_cast<GeneralizedBlackScholesProcess>(
    //                                               process_->process(0));
    //QL_REQUIRE(process, "Black-Scholes process required");

    const TimeGrid theTimeGrid = timeGrid();

    const std::vector<Time> & times = theTimeGrid.mandatoryTimes();
    const Size numberOfTimes = times.size();

	const std::vector<Date> & fixings = this->arguments_.fixingDates;
	std::vector<Date> remainfixings;

    Date today = Settings::instance().evaluationDate();
	const Size numberOfFixings = fixings.size();

	for(Size i=0;i<numberOfFixings;++i){
		if(fixings[i]>today){
			remainfixings.push_back(fixings[i]);
		}
	}
    const Size numberOfRemainFixings = remainfixings.size();

	additionalStats_.resize(numberOfTimes);
	
    QL_REQUIRE(numberOfRemainFixings == numberOfTimes, "Invalid dates/times");
	
	// 쿠폰 statistics //추가 조기상환 확률 이딴거.
	//resultStatistics.resize(numberOfTimes);
	
	//sampleAccumulator();
    std::vector<Size> timePositions(numberOfTimes);
    Array discountFactors(numberOfTimes);

    for (Size i = 0; i < numberOfTimes; ++i) {
        timePositions[i] = theTimeGrid.index(times[i]);
        discountFactors[i] = discountTS_->discount(times[i]);
    }

    return boost::shared_ptr<Pricer>(
                    new IRDLSPricer(payoffLeg, timePositions,process_,
                                                    discountFactors,additionalStats_));
}


}

