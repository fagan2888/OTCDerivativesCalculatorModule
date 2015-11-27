#include "monteEngine.hpp"
#include <ql\time\calendars\southkorea.hpp>
#include <src/Engine/MonteCarlo/result/resultCommulator.hpp>
#include <src/Engine/MonteCarlo/result/CalculationLogCommulator.hpp>
#include <ql/indexes/indexmanager.hpp>


namespace QuantLib {

MonteEngine::MonteEngine(const boost::shared_ptr<MCPricer>& pricer,
					//const boost::shared_ptr<StochasticProcessArray>& processes,
					const boost::shared_ptr<ProcessArrayWrapper>& processArrWrapper,
					const boost::shared_ptr<YieldTermStructure>& discountCurve,
                    Size simulSamples,
                    BigNatural seed)
: pricer_(pricer), processArrWrapper_(processArrWrapper), discountCurve_(discountCurve),
  simulSamples_(simulSamples), seed_(seed)
{
	this->resultCalc_ = boost::shared_ptr<MyResultCalculator>(
		new MyResultCalculator());

	//registerWith(processes_);
}

void MonteEngine::calculate() const
{
	boost::shared_ptr<PathGeneratorFactory>& pg = this->pathGeneratorFactory();

	Real value = 0;

	int start = std::clock();
	//std::cout << std::clock() << std::endl;
	
	//bool anti = false;
	//bool rcFlag = true;

	//ResultCommulator rc = ResultCommulator(pg->pathSize());

	//const boost::shared_ptr<ProcessArrayWrapper>& processArr = pg->getProcessArrWrapper();

	//rc.setBasePrice(processArr);

	//const MultiPath& multiPath = pg->next(false);
	//std::vector<std::vector<std::string>> logList;

	//MyResultCalculator resultCalc = MyResultCalculator();

	Size simulNum = this->simulSamples_;

	//Size simulNum = 10000;

	this->resultCalc_->initialize(this->pricer_,pg,static_cast<double>(simulNum));

	//this->resultCalc_->simulNum_ = simulNum;

	for(Size j = 0; j < simulNum; j++) 
	//for(Size j = 0; j < simulSamples_; j++) 
	{
		this->resultCalc_->calculation(this->pricer_,pg);
		//this->pricer_->reset();
		//std::cout << j << "\n";
	}
	
	////simulNum = 100;
	//for(Size j = 0; j < simulSamples_; j++) 
	////for(Size j = 0; j <= simulNum; j++) 
	//{
	//	

	//	const MultiPath& multiPath = pg->next(anti);

	//	if ( rcFlag )
	//	{
	//		rc.setDate(multiPath);
	//		rcFlag = false;
	//	}

	//	multiPath.log_.reserve(this->simulSamples_);
	//	multiPath.log_.clear();

	//	#ifdef LogPrint
	//		std::ostringstream ss;
	//		ss << j;
	//		multiPath.log_.push_back(ss.str());
	//	#endif

	//	this->pricer_->reset();
	//	
	//	if ( j < 100 )
	//		rc.recode(multiPath);

	//	Real y = this->pricer_->calculate(multiPath);
	//	value += y;
	//	
	//	if ( j < 100 )
	//		logList_.push_back(multiPath.log_);
	//	//anti = !anti;
	//	//std::cout << "simul count : " << j <<  " : " << y << std::endl;
	//	//sampleAccumulator_.add(pp.calculate(),1.0);

	//	

	//}

	//CalculationLogCommulator clc = CalculationLogCommulator();

	//#ifdef LogPrint
	//	std::ostringstream pathCalcFile;
	//		
	//	pathCalcFile << this->arguments_.code << "_" << "pathCalcLog.txt";
	//	clc.save(pathCalcFile.str() ,logList_);

	//#endif

	////value = value / double(simulSamples_);
	//value = value / double(simulNum);

	//this->results_.value = value ;
	this->resultCalc_->calculateGreek();
	
	std::cout << "simulNum : " << simulNum << std::endl;
	std::cout << "calcaultion time : " << static_cast<double>((std::clock() - start))/1000 << " second" << std::endl;
	std::cout << "value : " << this->resultCalc_->value_ / static_cast<double>(simulNum) << std::endl;
	//int kk;
	//std::cin >> kk;

}

boost::shared_ptr<MyResultCalculator> MonteEngine::resultCalc() const
{
	return this->resultCalc_;
}

std::string MonteEngine::getLogList()
{
	std::ostringstream ss;

	for ( Size i = 0 ;i<this->logList_.size(); i++)
	{
		const std::vector<std::string>& xLoop = this->logList_[i];

		for ( Size j = 0 ;j<xLoop.size(); j++)	
		{
			ss << xLoop[j] << "|";
		}

		ss << "\n";
	}
	
	return ss.str();
}

TimeGrid MonteEngine::timeGridWithPast() const {

	// calculation startDate임 ( 과거 데이터를 가져오는 처음 일자가 됨 )
	// basePrice 는 따로 계산방법 및 날짜를 정해서 받을거임
	// eventTrigger에서 이 issueDate보다 과거일자가 있을경우 이 날짜가 들어가가될거임(timegrid의 closeIndex때문에..)
	// 그러므러 이 issueDate가 충분히 과거일자로 setting이 되어있어야 과거 indexData를 가져옴
	Date startDate = this->arguments_.issueDate;

	Date maturityDate = this->arguments_.maturityDate;

	Date today = Settings::instance().evaluationDate();

	DayCounter dayCounter = Actual365Fixed();
	Calendar calendar = SouthKorea();
	std::vector<Time> fixingTimes;

	Size count = 0;

	//if ( this->processArrWrapper_->isNeedSimul() )
	//{
	//	std::vector<Date>& pastDates = IndexManager::instance().getPastDates(startDate,today,false);

	//	// pastData가 없을때 error 

	//	if ( startDate == today )
	//	{
	//		QL_REQUIRE(pastDates.size() >= 0 ,"pastData does not exist");
	//	}else
	//	{
	//		QL_REQUIRE(pastDates.size() > 0 ,"pastData does not exist");
	//	}

	//	for ( Size i=0; i<pastDates.size() ; i++)
	//	{
	//		fixingsFromToday_.push_back(Date(pastDates[i].serialNumber()));
	//		fixingTimes.push_back(dayCounter.yearFraction(startDate,pastDates[i]));
	//	}
	//}

	std::vector<Date>& pastDates = IndexManager::instance().getPastDates(startDate,today,false);

	for ( Size i=0; i<pastDates.size() ; i++)
	{
		fixingsFromToday_.push_back(Date(pastDates[i].serialNumber()));
		fixingTimes.push_back(dayCounter.yearFraction(startDate,pastDates[i]));
	}

	Date roopDate = today;

	while ( roopDate <= maturityDate)
	{
		//std::cout << count << " : " << roopDate << std::endl;
		//count = count + 1;

		fixingsFromToday_.push_back(roopDate);
		fixingTimes.push_back(dayCounter.yearFraction(startDate,roopDate));

		roopDate = calendar.advance(roopDate,Period(1,Days));
		
	}

	// 휴일로 roopDate 가 maturity를 넘어가서 maturity가 안박히는 경우를 catch함.
	if ( roopDate > maturityDate ) 
	{
		fixingsFromToday_.push_back(maturityDate);
		fixingTimes.push_back(dayCounter.yearFraction(startDate,maturityDate));
	}
    
	Real maturityTime = dayCounter.yearFraction(today,this->arguments_.maturityDate);

    return TimeGrid(fixingTimes.begin(), fixingTimes.end(), fixingsFromToday_);;
     
}

TimeGrid MonteEngine::timeOneDayGrid() const {

	//const std::vector<Date>& fixings = this->pricer_->fixingDates();

	std::vector<Date> fixings = this->pricer_->fixingDates();
	//const std::vector<Date>& payoffDates = this->pricer_->payoffDates();
        
	//this->fixings_ = this->pricer_->fixingDates();

	const Size numberOfFixings = fixings.size();
	
	Date today = Settings::instance().evaluationDate();
	std::vector<Time> fixingTimes;

	//fixingTimes.push_back(0.0);
	//fixingsFromToday_.push_back(today);

	DayCounter dayCounter = Actual365Fixed();
	Calendar calendar = SouthKorea();

	Date roopDate = today;

	//0.0 도 드감 왜냐면 today도 들어있으니..
	while ( roopDate <= this->arguments_.maturityDate)
	{
		fixingsFromToday_.push_back(roopDate);
		fixingTimes.push_back(dayCounter.yearFraction(today,roopDate));
		roopDate = calendar.advance(roopDate,Period(1,Days));
	}
    
	Real maturityTime = dayCounter.yearFraction(today,this->arguments_.maturityDate);

	//fixingTimes.push_back(maturityTime);

	//const Size numberOfAdjustedFixings = fixings.size();

	//for (Size i = 0; i < numberOfAdjustedFixings ; ++i) {
	//	if(today < fixings[i])
	//	{
	//		fixingTimes.push_back(dayCounter.yearFraction(today,fixings[i])) ;
	//		fixingsFromToday_.push_back(fixings[i]); //.push_back(fixings[i]);
	//	}

	//}
	//this->timeGrid_ = 

    //return TimeGrid(fixingTimes.begin(),fixingTimes.end(), Size(365));
	//return TimeGrid(fixingTimes.begin(),fixingTimes.end(), Size(365));
	//return TimeGrid(fixingTimes.begin(),fixingTimes.end(),fixingsFromToday_);
	return TimeGrid(fixingTimes.begin(),fixingTimes.end(),fixingsFromToday_);
     
}

boost::shared_ptr<PathGeneratorFactory> MonteEngine::pathGeneratorFactory() const
{
    //Size numAssets = processes_->size();
	Size numAssets = processArrWrapper_->size();

	bool oneDayPathFalg = false;

	TimeGrid grid;

	if ( oneDayPathFalg ){
		grid = this->timeOneDayGrid();
		
	}else
	{
		grid = this->timeGridWithPast();
	}

    PseudoRandom::rsg_type gen =
        PseudoRandom::make_sequence_generator(numAssets*(grid.size()-1),seed_);

	bool brownianBridge = false;

    //return boost::shared_ptr<path_generator_type>(
    //             new path_generator_type(processes_,
    //                                     grid, gen, brownianBridge));

	/*gen_ = new MultiVariate<PseudoRandom>::path_generator_type(processes_,
                                         grid, gen, brownianBridge));*/
	//const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory = boost::shared_ptr<PathGeneratorFactory>( new PathGeneratorFactory(this->processes_,grid) );
	const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory = boost::shared_ptr<PathGeneratorFactory>( new PathGeneratorFactory(this->processArrWrapper_,grid,this->fixingsFromToday_) );

	this->pricer_->initialize(grid , this->discountCurve_ , pathGenFactory);

	//this->pricer_->setReferenceVariable(pathGenFactory);

	return pathGenFactory;
}
    
}

