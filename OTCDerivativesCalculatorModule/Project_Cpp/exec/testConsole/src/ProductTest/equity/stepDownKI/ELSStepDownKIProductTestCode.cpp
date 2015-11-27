//#include <ql/testClass/MCELSGeneralEngine.hpp>
//
//#include <ql/testClass/ELSStepDown.hpp>
//
//#include <ql/testclass/StockIndex.hpp>


//	Calendar calendar = NullCalendar();
 //       Date settlementDate(30, May, 2013);

 //       // must be a business day
 //       settlementDate = calendar.adjust(settlementDate);

	//	DayCounter daycounter = Actual365Fixed();
	//	//DayCounter dc = SimpleDayCounter();

 //       Integer fixingDays = 0;
 //       Natural settlementDays = 0;

	//	Settings::instance().evaluationDate() = Date(4,Jun,2013);
	//	Date todaysDate = Settings::instance().evaluationDate();
 //       
 //       std::cout << "Today: " << todaysDate.weekday()
 //       << ", " << todaysDate << std::endl;

 //       std::cout << "Settlement date: " << settlementDate.weekday()
 //       << ", " << settlementDate << std::endl;

	//	Rate QuoteRate[]={0.0276, 0.0276, 0.0276, 0.0276, 0.0276,0.0276,0.0276,0.0276	,
	//						0.0276,0.0276,0.0276,0.0276,0.0276,0.0276};
	//			      

	//	double Maturity[]={0.01, 0.25, 0.5, 0.75, 1, 1.5,   2,    2.5, 3,	4, 5,	
	//					   7,    10,  15,	20};
	//	
	//	std::vector<Date> MaturityDate;
	//	std::vector<Rate> SpotData;

	//	const Size numberOfSpots = 14;

	//	for (Size i=0;i<numberOfSpots ;i++){
	//		//MaturityDate[i]=today+Maturity[i]*365;
	//		MaturityDate.push_back(todaysDate+Maturity[i]*365);
	//		SpotData.push_back(QuoteRate[i]);

	//	}
	//	
	//	Handle<YieldTermStructure> interCurve(
	//		boost::shared_ptr<YieldTermStructure>(
	//		new InterpolatedZeroCurve< Linear >(MaturityDate,
	//									SpotData,
	//									daycounter,
	//									calendar)));

	//	std::vector<Date> dates;
	//	std::vector<Date> autoCallDates;
	//	std::vector<boost::shared_ptr<StockIndex>> refIndex;
	//	std::vector<Real> earlyExTriggers;
	//	std::vector<Real> redemCoupons;
	//	std::vector<Real> KIbarrier;
	//	
	//	boost::shared_ptr<StockIndex> stock1=boost::shared_ptr<StockIndex>(new StockIndex("SK_Last",0.0214,calendar,daycounter));
	//	boost::shared_ptr<StockIndex> stock2=boost::shared_ptr<StockIndex>(new StockIndex("ELECT_Last",0.0,calendar,daycounter));

	//	refIndex.push_back(stock1);
	//	refIndex.push_back(stock2);

	//	KIbarrier.push_back(0.55);
	//	KIbarrier.push_back(0.55);

	//	
	//	//earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);
	//	autoCallDates.push_back(Date(26,Nov,2013));
	//	earlyExTriggers.push_back(0.95);
	//	redemCoupons.push_back(0.035);
	//	//earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);
	//	autoCallDates.push_back(Date(26,May,2014));
	//	earlyExTriggers.push_back(0.90);
	//	redemCoupons.push_back(0.07);
	//	//earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);
	//	autoCallDates.push_back(Date(26,Nov,2014));
	//	earlyExTriggers.push_back(0.90);
	//	redemCoupons.push_back(0.105);
	//	//earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);
	//	autoCallDates.push_back(Date(26,May,2015));
	//	earlyExTriggers.push_back(0.85);
	//	redemCoupons.push_back(0.14);
	//	//earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);
	//	autoCallDates.push_back(Date(25,Nov,2015));
	//	earlyExTriggers.push_back(0.85);
	//	redemCoupons.push_back(0.175);
	//	//earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);
	//	autoCallDates.push_back(Date(25,May,2016));
	//	earlyExTriggers.push_back(0.70);
	//	redemCoupons.push_back(0.21);
	//	
	//	//Schedule schedule(dates);

	//	Schedule eqSchedule(autoCallDates);

	//	Date stockDates[] = { Date( 4 ,Jun	, 2013 ) };
	//	
	//	Real SKData[]={ 149500 };

	//	Real ELECData[]={ 26400 };

	//	Real drift = 0.02761 ;

	//	Real vol_1 =  0.27486 ;
	//	Real vol_2 = 0.24078 ;

	//	Real dividend_1 =  0.0214 ;
	//	Real dividend_2 =  0.0 ;

	//	Real corr = -0.103192 ;

	//	std::vector<Date> paraDate;

	//	std::vector<boost::shared_ptr<Index>> paraIndex;


	//	Size numberDates = 1;

	//	for(Size i=0 ;i<numberDates; ++i){
	//		refIndex[0]->addFixing(stockDates[i],SKData[i],true);
	//		refIndex[1]->addFixing(stockDates[i],ELECData[i],true);	
	//	}

	//	CheckKIType checkKIType=DailyKI;

	//	ELSStepDown els100 = ELSStepDown(10000.0,
	//									 settlementDate,
	//									 0,
	//									 refIndex,
	//									 eqSchedule,
	//									 earlyExTriggers,
	//									 redemCoupons,
	//									 KIbarrier,
	//									 DailyKI,
	//									 daycounter,
	//									 calendar,
	//									 false);
	//	

 //
	//	Size nTimeSteps=6;

	//	std::vector<boost::shared_ptr<StochasticProcess1D> > gbmProcessArray;

	//	Real SK_initial = 145000;
	//	Real ELEC_initial = 28483.33;

	//	boost::shared_ptr<StochasticProcess1D> gbmProcess1(new GeometricBrownianMotionProcess(SK_initial , drift , vol_1));
	//	boost::shared_ptr<StochasticProcess1D> gbmProcess2(new GeometricBrownianMotionProcess(ELEC_initial , drift , vol_2));

	//	gbmProcessArray.push_back(gbmProcess1);
	//	gbmProcessArray.push_back(gbmProcess2);

	//	Matrix correlation(2,2,0.0);

	//	correlation[0][0] = 1.0 ;
	//	correlation[1][1] = 1.0 ;
	//	correlation[1][0] = corr ;
	//	correlation[0][1] = corr ;

	//	boost::shared_ptr<StochasticProcessArray> gbmProcess(new StochasticProcessArray(
	//	gbmProcessArray,correlation));
	//	
	//	bool brownianBridge = false;

	//	boost::shared_ptr<PricingEngine> MCELSGeneralEngine(new MCELSGeneralEngine(gbmProcess,
	//																interCurve,
	//																10000,//simulNum
	//																1));



	//std::cout << "Start" << std::endl;
	//els100.setPricingEngine(MCELSGeneralEngine);
	//std::cout << "Eu price                    : " << els100.NPV() << std::endl;

	//std::cout << "Calculation End" << std::endl;
	//getchar();
