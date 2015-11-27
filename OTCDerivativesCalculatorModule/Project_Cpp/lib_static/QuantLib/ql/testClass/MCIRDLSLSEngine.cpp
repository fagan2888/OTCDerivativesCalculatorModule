#include <ql/testClass/MCIRDLSLSEngine.hpp>

namespace QuantLib {

MCIRDLSLSEngine::MCIRDLSLSEngine(
         const boost::shared_ptr<StochasticProcessArray>& process,
		 const Handle<YieldTermStructure> & discountTS,
         Size maxSamples,
         BigNatural seed,
		 Size nCalibrationSamples
		 )
	: process_(process), discountTS_(discountTS),maxSamples_(maxSamples),seed_(seed),
	  nCalibrationSamples_(nCalibrationSamples) {
		QL_REQUIRE(nCalibrationSamples > 0,
				   "nCalibrationSamples must be strict positive, "
				   << nCalibrationSamples << " not allowed");

		QL_REQUIRE(maxSamples > nCalibrationSamples,"maxSamples must be larger than nCalibrationSamples")
		QL_REQUIRE(discountTS_->referenceDate() == Settings::instance().evaluationDate(),
					"TS's referenceDate("<< discountTS_->referenceDate() <<") isn't same to evaluationDate("
					<< Settings::instance().evaluationDate() <<")");
		this->registerWith(process_);
}

void MCIRDLSLSEngine::calculate() const {

	for(Size i=0;i<additionalStats_.size();++i) {
		additionalStats_[i].reset();
	}

	pathPricer_ = this->lsmPathPricer();
	Size NeedRnd=randNum();
	PseudoRandom::rsg_type gen  = PseudoRandom::make_sequence_generator(NeedRnd, seed_);
	const std::vector<Real>& rand = gen.nextSequence().value;

	//Real values=this->pathPricer_->values(rand,nCalibrationSamples_);
	Real values=this->pathPricer_->values(rand,maxSamples_);
	this->pathPricer_->calibrate(nCalibrationSamples_);

	values=this->pathPricer_->values(rand,maxSamples_);

	results_.additionalResults["ImpliedCall"] = values;

	const std::vector<Date> & fixings=this->arguments_.fixingDates;
	Size sizeOfCouponNum=fixings.size();

	Leg expectedCashflows;
	Leg pastLeg = arguments_.payoffLeg->leg();
	expectedCashflows=pastLeg;


	std::vector<Real> cashflows(sizeOfCouponNum);
	std::vector<Real> cashflowsDates(sizeOfCouponNum);
	std::vector<Real> earlyExProbability;

	std::vector<Real>& earlyExProbabilityM = pathPricer_->earlyExProbability(); // 그거 지난 일자는 빠진거.

	//
	//for(Size i=0;i<additionalStats_.size();++i) {
	//	expectedCashflows[sizeOfCouponNum-i-1]=boost::shared_ptr<CashFlow>(
	//				new SimpleCashFlow(additionalStats_[sizeOfCouponNum-i-1].mean(),fixings[sizeOfCouponNum-i-1]));
	//	cashflows[sizeOfCouponNum-i-1]=additionalStats_[sizeOfCouponNum-i-1].mean();
	//
	//	//std::cout << additionalStats_[i].mean() << std::endl;
	//}

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
		earlyExProbability.push_back(0.0);
	}

	for(Size i=0;i<additionalStats_.size();++i) {

		expectedCashflows[sizeOfCouponNum-i-1]=boost::shared_ptr<CashFlow>(
					new SimpleCashFlow(additionalStats_[additionalStats_.size()-i-1].mean(),fixings[sizeOfCouponNum-i-1]));
		cashflows[sizeOfCouponNum-i-1]=additionalStats_[additionalStats_.size()-i-1].mean();
		earlyExProbability.push_back(earlyExProbabilityM[i]/maxSamples_);

	}

	results_.additionalResults["cashflows"] = cashflows;

	/*for(Size i=0;i<additionalStats_.size();++i) {
		std::cout << "cashflows : "<< cashflows[i] << std::endl;
	}*/
	for(Size i=0;i<sizeOfCouponNum;++i){
		cashflowsDates[i]=static_cast<Real>(fixings[i].serialNumber());
	}
	
	results_.additionalResults["cashflowsDates"] = cashflowsDates;
	results_.additionalResults["EarlyExProbability"] = earlyExProbability;
	
	//pricer에서 Notional을 더해서옴. 언제 상환될지 모르므로...

	//Real Notional=arguments_.Notional;
	//expectedCashflows.push_back(boost::shared_ptr<CashFlow>(new SimpleCashFlow(Notional,fixings.back())));

	results_.expectedCashflows=expectedCashflows;
	//expected Bond Price도 넣어야하나..?

	QL_REQUIRE(!discountTS_.empty(),
			   "discounting term structure handle is empty");

	results_.valuationDate = Settings::instance().evaluationDate();
	
	bool includeRefDateFlows =false;
	Real Notional=arguments_.Notional;
	results_.additionalResults["nonCallableValue"] = pathPricer_->expectedBondPrice()*10000/maxSamples_;
	results_.additionalResults["nonCallableUnitValue"] = pathPricer_->expectedBondPrice()*100000000/(maxSamples_*Notional);


	results_.value = CashFlows::npv(results_.expectedCashflows,
									**discountTS_,
									includeRefDateFlows,
									results_.valuationDate,
									results_.valuationDate);

	results_.settlementValue = CashFlows::npv(results_.expectedCashflows,
											  **discountTS_,
											  false,
											  arguments_.settlementDate,
											  arguments_.settlementDate);

	results_.additionalResults["UnitValue"] = results_.value*10000/Notional;

}

    
Size MCIRDLSLSEngine::randNum() const {

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

    TimeGrid grid = timeGrid();
	
	for(Size i=0 ; i<numAssets ; ++i){
		process_->process(i)->setPreCalculation(grid); // 속도를 위해 수정되었음.
	}

	//return boost::shared_ptr<PseudoRandom::rsg_type>(&PseudoRandom::make_sequence_generator(maxSamples_* numAssets * numberOfFixings, seed_));
	return maxSamples_* numAssets * numberOfFixings;
}

TimeGrid MCIRDLSLSEngine::timeGrid() const {
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

    std::vector<Time> fixingTimes;//(numberOfFixings);
    for (Size i = 0; i < numberOfRemainFixings; ++i) {
        if(remainfixings[i]>today){
			fixingTimes.push_back(discountTS_->dayCounter().yearFraction(
                                       today, remainfixings[i]));
		}
    }
	
    const Size numberOfTimeSteps = numberOfRemainFixings;
	
    return TimeGrid(fixingTimes.begin(), fixingTimes.end(), numberOfTimeSteps);
}	


boost::shared_ptr<IRDLSCallablePricer>
MCIRDLSLSEngine::lsmPathPricer() const {
	
    boost::shared_ptr<StochasticProcessArray> processArray =
        boost::dynamic_pointer_cast<StochasticProcessArray>(this->process_);
    QL_REQUIRE(processArray && processArray->size()>0,
               "Stochastic process array required");


	boost::shared_ptr<PayoffLeg> payoffLeg = arguments_.payoffLeg;
    QL_REQUIRE(payoffLeg, "IRDLS payoffLeg given");

	//const Handle<YieldTermStructure> &df=arguments_.df;
	//Frequency freq = arguments_.freq;

    const TimeGrid theTimeGrid = this->timeGrid();

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

    std::vector<Size> timePositions(numberOfTimes);
    Array discountFactors(numberOfTimes);
    //std::vector<Handle<YieldTermStructure> > forwardTermStructures(numberOfTimes);

    //const Handle<YieldTermStructure> & riskFreeRate = process->riskFreeRate();

	for (Size i = 0; i < numberOfTimes; ++i){
        timePositions[i] = theTimeGrid.index(times[i]);
        discountFactors[i] = discountTS_->discount(times[i]);
	}
      //  forwardTermStructures[i] = Handle<YieldTermStructure>(
        //            new ImpliedTermStructure(riskFreeRate, fixings[i]));
    

    const Size polynomialOrder = 2;
    const LsmBasisSystem::PolynomType polynomType = LsmBasisSystem::Monomial;

    return boost::shared_ptr<IRDLSCallablePricer> (
							new IRDLSCallablePricer(payoffLeg,
													 timePositions,
													 process_,
													 discountFactors,
													 additionalStats_,
													 polynomialOrder,
													 polynomType));
}



} //namespace bracket