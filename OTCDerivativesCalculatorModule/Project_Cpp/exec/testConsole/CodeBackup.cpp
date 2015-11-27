////#include <ql/quantlib.hpp>
////#include <boost/timer.hpp>
////#include <iostream>
//////#include <iomanip>
//////--------------------------  이자율  --------------------------------
////#include <ql/testClass/MCIRDLSEngine.hpp>
////
////#include <ql/testClass/MCIRDLSLSEngine.hpp>
////
////#include <ql/testClass/IRDLS.hpp>
////#include <ql/testClass/IRDLSCallablePricer.hpp>
////#include <ql/math/randomnumbers/rngtraits.hpp>
////#include <ql/testClass/GeneralPayoffLeg.hpp>
////#include <ql/testClass/RangeCoupon.hpp>
////#include <ql/testClass/PowerSpreadCoupon.hpp>
//////---------------------------------------------------------------------
////
//////---------------------------------------------------------------------
////#include <ql/testClass/MCELSEngine.hpp>
////#include <ql/testClass/MCELSGeneralEngine.hpp>
////#include <ql/testClass/MCELSNotionalProtectedEngine.hpp>
////#include <ql/testClass/MCELSMonthlyREngine.hpp>
////#include <ql/testClass/MCEuOptionEngine.hpp>
////#include <ql/pricingengines/basket/mceuropeanbasketengine.hpp>
////
////
////#include <ql/testClass/ELSStepDown.hpp>
////#include <ql/testClass/ELSNotionalProtected.hpp>
////#include <ql/testClass/ELSStepDownMonthlyR.hpp>
////
////#include <ql/testclass/StockIndex.hpp>
////#include <ql/testClass/payoff/BarrierCheck.hpp>
//////---------------------------------------------------------------------
////#include <ql/indexes/swap/krwcdswap.hpp>
////#include <ql/time/dategenerationrule.hpp>
////#include <ql/testClass/EquitySwap.hpp>
////#include <ql/indexes/ibor/korCD.hpp>
////#include <ql/instruments/payoffs.hpp>
////
////#include <ql/testClass/historyCalulatorMC.hpp>
////#include <muParser.h>
//
//
////#include "CumTimer.hpp"
//
//////using namespace QuantLib;
////using namespace mu;
////
//////CumTimer _totaltime=CumTimer();
////
////
////
//////#endif
//int main(int, char* []) { return 0;}
////	mu::Parser parser;
////}
////	
//////for(int j=2;j>=0;--j){
//////	std::cout <<j<<std::endl;
//////}
//////
////
////		Calendar calendar = SouthKorea();
////        Date settlementDate(2, Mar, 2012);
////		Period eqperiod(1,Months);
////		Period irperiod(6,Months);
////		Period cdperiod(3,Months);
////        // must be a business day
////        settlementDate = calendar.adjust(settlementDate);
////		DayCounter daycounter = Actual365Fixed();
////		//DayCounter dc = SimpleDayCounter();
////
////        Integer fixingDays = 0;
////        Natural settlementDays = 0;
////		Settings::instance().evaluationDate() = Date(28,Aug,2012);
////        //Date todaysDate = calendar.advance(settlementDate, -fixingDays, Days);
////		Date todaysDate = Settings::instance().evaluationDate();
////        // nothing to do with Date::todaysDate
////        
////        std::cout << "Today: " << todaysDate.weekday()
////        << ", " << todaysDate << std::endl;
////
////        std::cout << "Settlement date: " << settlementDate.weekday()
////        << ", " << settlementDate << std::endl;
////
////		Rate QuoteRate[]={0.0325, 0.0324, 0.0325, 0.0327, 0.0325,0.0325,0.0325,0.0326	,
////							0.0338,0.0339,0.0349,0.0361,0.0372,0.0371};
////				      
////
////		double Maturity[]={0.01, 0.25, 0.5, 0.75, 1, 1.5,   2,    2.5, 3,	4, 5,	
////						   7,    10,  15,	20};
////		
////		std::vector<Date> MaturityDate;
////		std::vector<Rate> SpotData;
////
////		const Size numberOfSpots = 14;
////
////		for (Size i=0;i<numberOfSpots ;i++){
////			//MaturityDate[i]=today+Maturity[i]*365;
////			MaturityDate.push_back(todaysDate+Maturity[i]*365);
////			SpotData.push_back(QuoteRate[i]);
////
////		}
////		
////		Handle<YieldTermStructure> interCurve(
////			boost::shared_ptr<YieldTermStructure>(
////			new InterpolatedZeroCurve< Linear >(MaturityDate,
////										SpotData,
////										daycounter,
////										calendar)));
////
////		std::vector<Date> dates;
////		std::vector<boost::shared_ptr<StockIndex>> refIndex;
////		std::vector<Real> earlyExTriggers;
////		std::vector<Real> KIbarrier;
////		boost::shared_ptr<StockIndex> stock1=boost::shared_ptr<StockIndex>(new StockIndex("KOSPI200_Last",0.0145,calendar,daycounter));
////		boost::shared_ptr<StockIndex> stock2=boost::shared_ptr<StockIndex>(new StockIndex("HSCEI_Last",0.0313,calendar,daycounter));
////
////		refIndex.push_back(stock1);
////		refIndex.push_back(stock2);
////
////		KIbarrier.push_back(0.4);
////		KIbarrier.push_back(0.4);
////
////		
////		earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);
////		earlyExTriggers.push_back(0.95);
////		earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);
////		earlyExTriggers.push_back(0.90);
////		earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);
////		earlyExTriggers.push_back(0.85);
////		earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);
////		earlyExTriggers.push_back(0.80);
////		earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);
////		earlyExTriggers.push_back(0.75);
////		earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);earlyExTriggers.push_back(0.0);
////		earlyExTriggers.push_back(0.65);
////		
////		
////		//Schedule schedule(dates);
////
////		Schedule eqSchedule(Date(28,Mar,2012),
////						Date(25,Feb,2015),
////						eqperiod,
////						calendar,
////						Following,
////						Following,
////						DateGeneration::Backward,false);
////
////
////
////		Schedule irSchedule(settlementDate,
////						Date(18,Jul,2014),
////						irperiod,
////						calendar,
////						Following,
////						Following,
////						DateGeneration::Backward,false);
////
////
////		
////
////		Date stockDates[] = { Date( 4 ,	Jan	, 2010 ),Date( 5 ,	Jan	, 2010 ),Date( 6 ,	Jan	, 2010 ),Date( 7 ,	Jan	, 2010 ),Date( 8 ,	Jan	, 2010 ),Date( 11 ,	Jan	, 2010 ),Date( 12 ,	Jan	, 2010 ),Date( 13 ,	Jan	, 2010 ),Date( 14 ,	Jan	, 2010 ),Date( 15 ,	Jan	, 2010 ),Date( 18 ,	Jan	, 2010 ),Date( 19 ,	Jan	, 2010 ),Date( 20 ,	Jan	, 2010 ),
////							Date( 21 ,	Jan	, 2010 ),Date( 22 ,	Jan	, 2010 ),Date( 25 ,	Jan	, 2010 ),Date( 26 ,	Jan	, 2010 ),Date( 27 ,	Jan	, 2010 ),Date( 28 ,	Jan	, 2010 ),Date( 29 ,	Jan	, 2010 ),Date( 1 ,	Feb	, 2010 ),Date( 2 ,	Feb	, 2010 ),Date( 3 ,	Feb	, 2010 ),Date( 4 ,	Feb	, 2010 ),Date( 5 ,	Feb	, 2010 ),
////							Date( 8 ,	Feb	, 2010 ),		Date( 9 ,	Feb	, 2010 ),		Date( 10 ,	Feb	, 2010 ),		Date( 11 ,	Feb	, 2010 ),		Date( 12 ,	Feb	, 2010 ),		Date( 16 ,	Feb	, 2010 ),		Date( 17 ,	Feb	, 2010 ),		Date( 18 ,	Feb	, 2010 ),		Date( 19 ,	Feb	, 2010 ),		Date( 22 ,	Feb	, 2010 ),		Date( 23 ,	Feb	, 2010 ),		Date( 24 ,	Feb	, 2010 ),
////							Date( 25 ,	Feb	, 2010 ),		Date( 26 ,	Feb	, 2010 ),		Date( 2 ,	Mar	, 2010 ),		Date( 3 ,	Mar	, 2010 ),		Date( 4 ,	Mar	, 2010 ),		Date( 5 ,	Mar	, 2010 ),		Date( 8 ,	Mar	, 2010 ),		Date( 9 ,	Mar	, 2010 ),		Date( 10 ,	Mar	, 2010 ),		Date( 11 ,	Mar	, 2010 ),		Date( 12 ,	Mar	, 2010 ),		Date( 15 ,	Mar	, 2010 ),		Date( 16 ,	Mar	, 2010 ),
////							Date( 17 ,	Mar	, 2010 ),		Date( 18 ,	Mar	, 2010 ),		Date( 19 ,	Mar	, 2010 ),		Date( 22 ,	Mar	, 2010 ),		Date( 23 ,	Mar	, 2010 ),		Date( 24 ,	Mar	, 2010 ),		Date( 25 ,	Mar	, 2010 ),		Date( 26 ,	Mar	, 2010 ),		Date( 29 ,	Mar	, 2010 ),		Date( 30 ,	Mar	, 2010 ),		Date( 31 ,	Mar	, 2010 ),		Date( 1 ,	Apr	, 2010 ),		Date( 2 ,	Apr	, 2010 ),
////							Date( 5 ,	Apr	, 2010 ),		Date( 6 ,	Apr	, 2010 ),		Date( 7 ,	Apr	, 2010 ),		Date( 8 ,	Apr	, 2010 ),		Date( 9 ,	Apr	, 2010 ),		Date( 12 ,	Apr	, 2010 ),		Date( 13 ,	Apr	, 2010 ),		Date( 14 ,	Apr	, 2010 ),		Date( 15 ,	Apr	, 2010 ),		Date( 16 ,	Apr	, 2010 ),		Date( 19 ,	Apr	, 2010 ),		Date( 20 ,	Apr	, 2010 ),
////							Date( 21 ,	Apr	, 2010 ),		Date( 22 ,	Apr	, 2010 ),		Date( 23 ,	Apr	, 2010 ),		Date( 26 ,	Apr	, 2010 ),		Date( 27 ,	Apr	, 2010 ),		Date( 28 ,	Apr	, 2010 ),		Date( 29 ,	Apr	, 2010 ),		Date( 30 ,	Apr	, 2010 ),		Date( 3 ,	May	, 2010 ),		Date( 4 ,	May	, 2010 ),		Date( 6 ,	May	, 2010 ),
////							Date( 7 ,	May	, 2010 ),		Date( 10 ,	May	, 2010 ),		Date( 11 ,	May	, 2010 ),		Date( 12 ,	May	, 2010 ),		Date( 13 ,	May	, 2010 ),		Date( 14 ,	May	, 2010 ),		Date( 17 ,	May	, 2010 ),		Date( 18 ,	May	, 2010 ),		Date( 19 ,	May	, 2010 ),		Date( 20 ,	May	, 2010 ),		Date( 24 ,	May	, 2010 ),		Date( 25 ,	May	, 2010 ),
////							Date( 26 ,	May	, 2010 ),		Date( 27 ,	May	, 2010 ),		Date( 28 ,	May	, 2010 ),		Date( 31 ,	May	, 2010 ),		Date( 1 ,	Jun	, 2010 ),		Date( 3 ,	Jun	, 2010 ),		Date( 4 ,	Jun	, 2010 ),		Date( 7 ,	Jun	, 2010 ),		Date( 8 ,	Jun	, 2010 ),		Date( 9 ,	Jun	, 2010 ),		Date( 10 ,	Jun	, 2010 ),		Date( 11 ,	Jun	, 2010 ),
////							Date( 14 ,	Jun	, 2010 ),		Date( 15 ,	Jun	, 2010 ),		Date( 16 ,	Jun	, 2010 ),		Date( 17 ,	Jun	, 2010 ),		Date( 18 ,	Jun	, 2010 ),		Date( 21 ,	Jun	, 2010 ),		Date( 22 ,	Jun	, 2010 ),		Date( 23 ,	Jun	, 2010 ),		Date( 24 ,	Jun	, 2010 ),		Date( 25 ,	Jun	, 2010 ),		Date( 28 ,	Jun	, 2010 ),
////							Date( 29 ,	Jun	, 2010 ),		Date( 30 ,	Jun	, 2010 ),		Date( 1 ,	Jul	, 2010 ),		Date( 2 ,	Jul	, 2010 ),		Date( 5 ,	Jul	, 2010 ),		Date( 6 ,	Jul	, 2010 ),		Date( 7 ,	Jul	, 2010 ),		Date( 8 ,	Jul	, 2010 ),		Date( 9 ,	Jul	, 2010 ),		Date( 12 ,	Jul	, 2010 ),		Date( 13 ,	Jul	, 2010 ),		Date( 14 ,	Jul	, 2010 ),
////							Date( 15 ,	Jul	, 2010 ),		Date( 16 ,	Jul	, 2010 ),		Date( 19 ,	Jul	, 2010 ),		Date( 20 ,	Jul	, 2010 ),		Date( 21 ,	Jul	, 2010 ),		Date( 22 ,	Jul	, 2010 ),		Date( 23 ,	Jul	, 2010 ),		Date( 26 ,	Jul	, 2010 ),		Date( 27 ,	Jul	, 2010 ),		Date( 28 ,	Jul	, 2010 ),		Date( 29 ,	Jul	, 2010 ),		Date( 30 ,	Jul	, 2010 ),		Date( 2 ,	Aug	, 2010 ),
////							Date( 3 ,	Aug	, 2010 ),		Date( 4 ,	Aug	, 2010 ),		Date( 5 ,	Aug	, 2010 ),		Date( 6 ,	Aug	, 2010 ),		Date( 9 ,	Aug	, 2010 ),		Date( 10 ,	Aug	, 2010 ),		Date( 11 ,	Aug	, 2010 ),		Date( 12 ,	Aug	, 2010 ),		Date( 13 ,	Aug	, 2010 ),		Date( 16 ,	Aug	, 2010 ),		Date( 17 ,	Aug	, 2010 ),		Date( 18 ,	Aug	, 2010 ),
////							Date( 19 ,	Aug	, 2010 ),		Date( 20 ,	Aug	, 2010 ),		Date( 23 ,	Aug	, 2010 ),		Date( 24 ,	Aug	, 2010 ),		Date( 25 ,	Aug	, 2010 ),		Date( 26 ,	Aug	, 2010 ),		Date( 27 ,	Aug	, 2010 ),		Date( 30 ,	Aug	, 2010 ),		Date( 31 ,	Aug	, 2010 ),		Date( 1 ,	Sep	, 2010 ),		Date( 2 ,	Sep	, 2010 ),
////							Date( 3 ,	Sep	, 2010 ),		Date( 6 ,	Sep	, 2010 ),		Date( 7 ,	Sep	, 2010 ),		Date( 8 ,	Sep	, 2010 ),		Date( 9 ,	Sep	, 2010 ),		Date( 10 ,	Sep	, 2010 ),		Date( 13 ,	Sep	, 2010 ),		Date( 14 ,	Sep	, 2010 ),		Date( 15 ,	Sep	, 2010 ),		Date( 16 ,	Sep	, 2010 ),		Date( 17 ,	Sep	, 2010 ),		Date( 20 ,	Sep	, 2010 ),
////							Date( 24 ,	Sep	, 2010 ),		Date( 27 ,	Sep	, 2010 ),		Date( 28 ,	Sep	, 2010 ),		Date( 29 ,	Sep	, 2010 ),		Date( 30 ,	Sep	, 2010 ),		Date( 1 ,	Oct	, 2010 ),		Date( 4 ,	Oct	, 2010 ),		Date( 5 ,	Oct	, 2010 ),		Date( 6 ,	Oct	, 2010 ),		Date( 7 ,	Oct	, 2010 ),		Date( 8 ,	Oct	, 2010 ),
////							Date( 11 ,	Oct	, 2010 ),		Date( 12 ,	Oct	, 2010 ),		Date( 13 ,	Oct	, 2010 ),		Date( 14 ,	Oct	, 2010 ),		Date( 15 ,	Oct	, 2010 ),		Date( 18 ,	Oct	, 2010 ),		Date( 19 ,	Oct	, 2010 ),		Date( 20 ,	Oct	, 2010 ),		Date( 21 ,	Oct	, 2010 ),		Date( 22 ,	Oct	, 2010 ),		Date( 25 ,	Oct	, 2010 ),
////							Date( 26 ,	Oct	, 2010 ),		Date( 27 ,	Oct	, 2010 ),		Date( 28 ,	Oct	, 2010 ),		Date( 29 ,	Oct	, 2010 ),		Date( 1 ,	Nov	, 2010 ),		Date( 2 ,	Nov	, 2010 ),		Date( 3 ,	Nov	, 2010 ),		Date( 4 ,	Nov	, 2010 ),		Date( 5 ,	Nov	, 2010 ),		Date( 8 ,	Nov	, 2010 ),		Date( 9 ,	Nov	, 2010 ),		Date( 10 ,	Nov	, 2010 ),
////							Date( 11 ,	Nov	, 2010 ),		Date( 12 ,	Nov	, 2010 ),		Date( 15 ,	Nov	, 2010 ),		Date( 16 ,	Nov	, 2010 ),		Date( 17 ,	Nov	, 2010 ),		Date( 18 ,	Nov	, 2010 ),		Date( 19 ,	Nov	, 2010 ),		Date( 22 ,	Nov	, 2010 ),		Date( 23 ,	Nov	, 2010 ),		Date( 24 ,	Nov	, 2010 ),		Date( 25 ,	Nov	, 2010 ),		Date( 26 ,	Nov	, 2010 ),		Date( 29 ,	Nov	, 2010 ),
////							Date( 30 ,	Nov	, 2010 ),		Date( 1 ,	Dec	, 2010 ),		Date( 2 ,	Dec	, 2010 ),		Date( 3 ,	Dec	, 2010 ),		Date( 6 ,	Dec	, 2010 ),		Date( 7 ,	Dec	, 2010 ),		Date( 8 ,	Dec	, 2010 ),		Date( 9 ,	Dec	, 2010 ),		Date( 10 ,	Dec	, 2010 ),		Date( 13 ,	Dec	, 2010 ),		Date( 14 ,	Dec	, 2010 ),		Date( 15 ,	Dec	, 2010 ),		Date( 16 ,	Dec	, 2010 ),
////							Date( 17 ,	Dec	, 2010 ),		Date( 20 ,	Dec	, 2010 ),		Date( 21 ,	Dec	, 2010 ),		Date( 22 ,	Dec	, 2010 ),		Date( 23 ,	Dec	, 2010 ),		Date( 24 ,	Dec	, 2010 ),		Date( 27 ,	Dec	, 2010 ),		Date( 28 ,	Dec	, 2010 ),		Date( 29 ,	Dec	, 2010 ),		Date( 30 ,	Dec	, 2010 ),		Date( 3 ,	Jan	, 2011 ),		Date( 4 ,	Jan	, 2011 ),
////							Date( 5 ,	Jan	, 2011 ),		Date( 6 ,	Jan	, 2011 ),		Date( 7 ,	Jan	, 2011 ),		Date( 10 ,	Jan	, 2011 ),		Date( 11 ,	Jan	, 2011 ),		Date( 12 ,	Jan	, 2011 ),		Date( 13 ,	Jan	, 2011 ),		Date( 14 ,	Jan	, 2011 ),		Date( 17 ,	Jan	, 2011 ),		Date( 18 ,	Jan	, 2011 ),		Date( 19 ,	Jan	, 2011 ),		Date( 20 ,	Jan	, 2011 ),
////							Date( 21 ,	Jan	, 2011 ),		Date( 24 ,	Jan	, 2011 ),		Date( 25 ,	Jan	, 2011 ),		Date( 26 ,	Jan	, 2011 ),		Date( 27 ,	Jan	, 2011 ),		Date( 28 ,	Jan	, 2011 ),		Date( 31 ,	Jan	, 2011 ),		Date( 1 ,	Feb	, 2011 ),
////							Date( 7 ,	Feb	, 2011 ),		Date( 8 ,	Feb	, 2011 ),		Date( 9 ,	Feb	, 2011 ),		Date( 10 ,	Feb	, 2011 ),		Date( 11 ,	Feb	, 2011 ),		Date( 14 ,	Feb	, 2011 ),		Date( 15 ,	Feb	, 2011 ),		Date( 16 ,	Feb	, 2011 ),		Date( 17 ,	Feb	, 2011 ),		Date( 18 ,	Feb	, 2011 ),		Date( 21 ,	Feb	, 2011 ),		Date( 22 ,	Feb	, 2011 ),
////							Date( 23 ,	Feb	, 2011 ),		Date( 24 ,	Feb	, 2011 ),		Date( 25 ,	Feb	, 2011 ),		Date( 28 ,	Feb	, 2011 ),		Date( 2 ,	Mar	, 2011 ),		Date( 3 ,	Mar	, 2011 ),		Date( 4 ,	Mar	, 2011 ),		Date( 7 ,	Mar	, 2011 ),		Date( 8 ,	Mar	, 2011 ),		Date( 9 ,	Mar	, 2011 ),		Date( 10 ,	Mar	, 2011 ),
////							Date( 11 ,	Mar	, 2011 ),		Date( 14 ,	Mar	, 2011 ),		Date( 15 ,	Mar	, 2011 ),		Date( 16 ,	Mar	, 2011 ),		Date( 17 ,	Mar	, 2011 ),		Date( 18 ,	Mar	, 2011 ),		Date( 21 ,	Mar	, 2011 ),		Date( 22 ,	Mar	, 2011 ),		Date( 23 ,	Mar	, 2011 ),		Date( 24 ,	Mar	, 2011 ),		Date( 25 ,	Mar	, 2011 ),
////							Date( 28 ,	Mar	, 2011 ),		Date( 29 ,	Mar	, 2011 ),		Date( 30 ,	Mar	, 2011 ),		Date( 31 ,	Mar	, 2011 ),		Date( 1 ,	Apr	, 2011 ),		Date( 4 ,	Apr	, 2011 ),		Date( 5 ,	Apr	, 2011 ),		Date( 6 ,	Apr	, 2011 ),		Date( 7 ,	Apr	, 2011 ),		Date( 8 ,	Apr	, 2011 ),
////							Date( 11 ,	Apr	, 2011 ),		Date( 12 ,	Apr	, 2011 ),		Date( 13 ,	Apr	, 2011 ),		Date( 14 ,	Apr	, 2011 ),		Date( 15 ,	Apr	, 2011 ),		Date( 18 ,	Apr	, 2011 ),		Date( 19 ,	Apr	, 2011 ),		Date( 20 ,	Apr	, 2011 ),		Date( 21 ,	Apr	, 2011 ),		Date( 22 ,	Apr	, 2011 ),
////							Date( 25 ,	Apr	, 2011 ),		Date( 26 ,	Apr	, 2011 ),		Date( 27 ,	Apr	, 2011 ),		Date( 28 ,	Apr	, 2011 ),		Date( 29 ,	Apr	, 2011 ),		Date( 2 ,	May	, 2011 ),		Date( 3 ,	May	, 2011 ),		Date( 4 ,	May	, 2011 ),		Date( 6 ,	May	, 2011 ),		Date( 9 ,	May	, 2011 ),		Date( 11 ,	May	, 2011 ),
////							Date( 12 ,	May	, 2011 ),		Date( 13 ,	May	, 2011 ),		Date( 16 ,	May	, 2011 ),		Date( 17 ,	May	, 2011 ),		Date( 18 ,	May	, 2011 ),		Date( 19 ,	May	, 2011 ),		Date( 20 ,	May	, 2011 ),		Date( 23 ,	May	, 2011 ),		Date( 24 ,	May	, 2011 ),		Date( 25 ,	May	, 2011 ),		Date( 26 ,	May	, 2011 ),
////							Date( 27 ,	May	, 2011 ),		Date( 30 ,	May	, 2011 ),		Date( 31 ,	May	, 2011 ),		Date( 1 ,	Jun	, 2011 ),		Date( 2 ,	Jun	, 2011 ),		Date( 3 ,	Jun	, 2011 ),		Date( 7 ,	Jun	, 2011 ),		Date( 8 ,	Jun	, 2011 ),		Date( 9 ,	Jun	, 2011 ),		Date( 10 ,	Jun	, 2011 ),		Date( 13 ,	Jun	, 2011 ),
////							Date( 14 ,	Jun	, 2011 ),		Date( 15 ,	Jun	, 2011 ),		Date( 16 ,	Jun	, 2011 ),		Date( 17 ,	Jun	, 2011 ),		Date( 20 ,	Jun	, 2011 ),		Date( 21 ,	Jun	, 2011 ),		Date( 22 ,	Jun	, 2011 ),		Date( 23 ,	Jun	, 2011 ),		Date( 24 ,	Jun	, 2011 ),		Date( 27 ,	Jun	, 2011 ),		Date( 28 ,	Jun	, 2011 ),		Date( 29 ,	Jun	, 2011 ),
////							Date( 30 ,	Jun	, 2011 ),		Date( 1 ,	Jul	, 2011 ),		Date( 4 ,	Jul	, 2011 ),		Date( 5 ,	Jul	, 2011 ),		Date( 6 ,	Jul	, 2011 ),		Date( 7 ,	Jul	, 2011 ),		Date( 8 ,	Jul	, 2011 ),		Date( 11 ,	Jul	, 2011 ),		Date( 12 ,	Jul	, 2011 ),		Date( 13 ,	Jul	, 2011 ),		Date( 14 ,	Jul	, 2011 ),		Date( 15 ,	Jul	, 2011 ),		Date( 18 ,	Jul	, 2011 ),
////							Date( 19 ,	Jul	, 2011 ),		Date( 20 ,	Jul	, 2011 ),		Date( 21 ,	Jul	, 2011 ),		Date( 22 ,	Jul	, 2011 ),		Date( 25 ,	Jul	, 2011 ),		Date( 26 ,	Jul	, 2011 ),		Date( 27 ,	Jul	, 2011 ),		Date( 28 ,	Jul	, 2011 ),		Date( 29 ,	Jul	, 2011 ),		Date( 1 ,	Aug	, 2011 ),		Date( 2 ,	Aug	, 2011 ),		Date( 3 ,	Aug	, 2011 ),
////							Date( 4 ,	Aug	, 2011 ),		Date( 5 ,	Aug	, 2011 ),
////							Date( 8 ,	Aug	, 2011 ),		Date( 9 ,	Aug	, 2011 ),		Date( 10 ,	Aug	, 2011 ),		Date( 11 ,	Aug	, 2011 ),		Date( 12 ,	Aug	, 2011 ),		Date( 16 ,	Aug	, 2011 ),		Date( 17 ,	Aug	, 2011 ),		Date( 18 ,	Aug	, 2011 ),		Date( 19 ,	Aug	, 2011 ),		Date( 22 ,	Aug	, 2011 ),
////							Date( 23 ,	Aug	, 2011 ),		Date( 24 ,	Aug	, 2011 ),		Date( 25 ,	Aug	, 2011 ),		Date( 26 ,	Aug	, 2011 ),		Date( 29 ,	Aug	, 2011 ),		Date( 30 ,	Aug	, 2011 ),		Date( 31 ,	Aug	, 2011 ),		Date( 1 ,	Sep	, 2011 ),		Date( 2 ,	Sep	, 2011 ),		Date( 5 ,	Sep	, 2011 ),
////							Date( 6 ,	Sep	, 2011 ),		Date( 7 ,	Sep	, 2011 ),		Date( 8 ,	Sep	, 2011 ),		Date( 9 ,	Sep	, 2011 ),		Date( 14 ,	Sep	, 2011 ),		Date( 15 ,	Sep	, 2011 ),		Date( 16 ,	Sep	, 2011 ),		Date( 19 ,	Sep	, 2011 ),		Date( 20 ,	Sep	, 2011 ),		Date( 21 ,	Sep	, 2011 ),		Date( 22 ,	Sep	, 2011 ),		Date( 23 ,	Sep	, 2011 ),
////							Date( 26 ,	Sep	, 2011 ),		Date( 27 ,	Sep	, 2011 ),		Date( 28 ,	Sep	, 2011 ),		Date( 29 ,	Sep	, 2011 ),		Date( 30 ,	Sep	, 2011 ),		Date( 4 ,	Oct	, 2011 ),		Date( 5 ,	Oct	, 2011 ),		Date( 6 ,	Oct	, 2011 ),		Date( 7 ,	Oct	, 2011 ),		Date( 10 ,	Oct	, 2011 ),		Date( 11 ,	Oct	, 2011 ),		Date( 12 ,	Oct	, 2011 ),	Date( 13 ,	Oct	, 2011 ),	Date( 14 ,	Oct	, 2011 ),
////							Date( 17 ,	Oct	, 2011 ),		Date( 18 ,	Oct	, 2011 ),		Date( 19 ,	Oct	, 2011 ),		Date( 20 ,	Oct	, 2011 ),		Date( 21 ,	Oct	, 2011 ),		Date( 24 ,	Oct	, 2011 ),		Date( 25 ,	Oct	, 2011 ),		Date( 26 ,	Oct	, 2011 ),		Date( 27 ,	Oct	, 2011 ),		Date( 28 ,	Oct	, 2011 ),		Date( 31 ,	Oct	, 2011 ),		Date( 1 ,	Nov	, 2011 ),		Date( 2 ,	Nov	, 2011 ),		Date( 3 ,	Nov	, 2011 ),		Date( 4 ,	Nov	, 2011 ),		Date( 7 ,	Nov	, 2011 ),
////							Date( 8 ,	Nov	, 2011 ),		Date( 9 ,	Nov	, 2011 ),		Date( 10 ,	Nov	, 2011 ),		Date( 11 ,	Nov	, 2011 ),		Date( 14 ,	Nov	, 2011 ),		Date( 15 ,	Nov	, 2011 ),		Date( 16 ,	Nov	, 2011 ),		Date( 17 ,	Nov	, 2011 ),		Date( 18 ,	Nov	, 2011 ),		Date( 21 ,	Nov	, 2011 ),		Date( 22 ,	Nov	, 2011 ),		Date( 23 ,	Nov	, 2011 ),		Date( 24 ,	Nov	, 2011 ),
////							Date( 25 ,	Nov	, 2011 ),		Date( 28 ,	Nov	, 2011 ),		Date( 29 ,	Nov	, 2011 ),		Date( 30 ,	Nov	, 2011 ),		Date( 1 ,	Dec	, 2011 ),		Date( 2 ,	Dec	, 2011 ),		Date( 5 ,	Dec	, 2011 ),		Date( 6 ,	Dec	, 2011 ),		Date( 7 ,	Dec	, 2011 ),		Date( 8 ,	Dec	, 2011 ),		Date( 9 ,	Dec	, 2011 ),		Date( 12 ,	Dec	, 2011 ),		Date( 13 ,	Dec	, 2011 ),		Date( 14 ,	Dec	, 2011 ),
////							Date( 15 ,	Dec	, 2011 ),		Date( 16 ,	Dec	, 2011 ),		Date( 19 ,	Dec	, 2011 ),		Date( 20 ,	Dec	, 2011 ),		Date( 21 ,	Dec	, 2011 ),		Date( 22 ,	Dec	, 2011 ),		Date( 23 ,	Dec	, 2011 ),		Date( 26 ,	Dec	, 2011 ),		Date( 27 ,	Dec	, 2011 ),		Date( 28 ,	Dec	, 2011 ),		Date( 29 ,	Dec	, 2011 ),		Date( 2 ,	Jan	, 2012 ),		Date( 3 ,	Jan	, 2012 ),		Date( 4 ,	Jan	, 2012 ),		Date( 5 ,	Jan	, 2012 ),
////							Date( 6 ,	Jan	, 2012 ),		Date( 9 ,	Jan	, 2012 ),		Date( 10 ,	Jan	, 2012 ),		Date( 11 ,	Jan	, 2012 ),		Date( 12 ,	Jan	, 2012 ),		Date( 13 ,	Jan	, 2012 ),		Date( 16 ,	Jan	, 2012 ),		Date( 17 ,	Jan	, 2012 ),		Date( 18 ,	Jan	, 2012 ),		Date( 19 ,	Jan	, 2012 ),		Date( 20 ,	Jan	, 2012 ),		Date( 25 ,	Jan	, 2012 ),		Date( 26 ,	Jan	, 2012 ),		Date( 27 ,	Jan	, 2012 ),	Date( 30 ,	Jan	, 2012 ),
////							Date( 31 ,	Jan	, 2012 ),		Date( 1 ,	Feb	, 2012 ),		Date( 2 ,	Feb	, 2012 ),		Date( 3 ,	Feb	, 2012 ),		Date( 6 ,	Feb	, 2012 ),		Date( 7 ,	Feb	, 2012 ),		Date( 8 ,	Feb	, 2012 ),		Date( 9 ,	Feb	, 2012 ),		Date( 10 ,	Feb	, 2012 ),		Date( 13 ,	Feb	, 2012 ),		Date( 14 ,	Feb	, 2012 ),		Date( 15 ,	Feb	, 2012 ),		Date( 16 ,	Feb	, 2012 ),		Date( 17 ,	Feb	, 2012 ),		Date( 20 ,	Feb	, 2012 ),
////							Date( 21 ,	Feb	, 2012 ),		Date( 22 ,	Feb	, 2012 ),		Date( 23 ,	Feb	, 2012 ),		Date( 24 ,	Feb	, 2012 ),		Date( 27 ,	Feb	, 2012 ),		Date( 28 ,	Feb	, 2012 ),		Date( 29 ,	Feb	, 2012 ),		Date( 2 ,	Mar	, 2012 ),		Date( 5 ,	Mar	, 2012 ),		Date( 6 ,	Mar	, 2012 ),		Date( 7 ,	Mar	, 2012 ),		Date( 8 ,	Mar	, 2012 ),		Date( 9 ,	Mar	, 2012 ),		Date( 12 ,	Mar	, 2012 ),
////							Date( 13 ,	Mar	, 2012 ),		Date( 14 ,	Mar	, 2012 ),		Date( 15 ,	Mar	, 2012 ),		Date( 16 ,	Mar	, 2012 ),		Date( 19 ,	Mar	, 2012 ),		Date( 20 ,	Mar	, 2012 ),		Date( 21 ,	Mar	, 2012 ),		Date( 22 ,	Mar	, 2012 ),		Date( 23 ,	Mar	, 2012 ),		Date( 26 ,	Mar	, 2012 ),		Date( 27 ,	Mar	, 2012 ),		Date( 28 ,	Mar	, 2012 ),
////							Date( 29 ,	Mar	, 2012 ),		Date( 30 ,	Mar	, 2012 ),		Date( 2 ,	Apr	, 2012 ),		Date( 3 ,	Apr	, 2012 ),		Date( 4 ,	Apr	, 2012 ),		Date( 5 ,	Apr	, 2012 ),		Date( 6 ,	Apr	, 2012 ),		Date( 9 ,	Apr	, 2012 ),		Date( 10 ,	Apr	, 2012 ),		Date( 12 ,	Apr	, 2012 ),		Date( 13 ,	Apr	, 2012 ),		Date( 16 ,	Apr	, 2012 ),		Date( 17 ,	Apr	, 2012 ),		Date( 18 ,	Apr	, 2012 ),
////							Date( 19 ,	Apr	, 2012 ),		Date( 20 ,	Apr	, 2012 ),		Date( 23 ,	Apr	, 2012 ),		Date( 24 ,	Apr	, 2012 ),		Date( 25 ,	Apr	, 2012 ),		Date( 26 ,	Apr	, 2012 ),		Date( 27 ,	Apr	, 2012 ),		Date( 30 ,	Apr	, 2012 ),		Date( 2 ,	May	, 2012 ),		Date( 3 ,	May	, 2012 ),		Date( 4 ,	May	, 2012 ),		Date( 7 ,	May	, 2012 ),		Date( 8 ,	May	, 2012 ),		Date( 9 ,	May	, 2012 ),
////							Date( 10 ,	May	, 2012 ),		Date( 11 ,	May	, 2012 ),		Date( 14 ,	May	, 2012 ),		Date( 15 ,	May	, 2012 ),		Date( 16 ,	May	, 2012 ),		Date( 17 ,	May	, 2012 ),		Date( 18 ,	May	, 2012 ),		Date( 21 ,	May	, 2012 ),		Date( 22 ,	May	, 2012 ),		Date( 23 ,	May	, 2012 ),
////							Date( 24 ,	May	, 2012 ),		Date( 25 ,	May	, 2012 ),		Date( 29 ,	May	, 2012 ),		Date( 30 ,	May	, 2012 ),		Date( 31 ,	May	, 2012 ),		Date( 1 ,	Jun	, 2012 ),		Date( 4 ,	Jun	, 2012 ),		Date( 5 ,	Jun	, 2012 ),		Date( 7 ,	Jun	, 2012 ),		Date( 8 ,	Jun	, 2012 ),		Date( 11 ,	Jun	, 2012 ),		Date( 12 ,	Jun	, 2012 ),
////							Date( 13 ,	Jun	, 2012 ),		Date( 14 ,	Jun	, 2012 )};
////		
////		Real kospi200Data[]={223.49	,
////							222.84	,224.67	,221.31	,222.66	,222.23	,223.04	,219.17	,221.19	,223.21	,224.38	,224.13	,224.83	,226.16	,220.68	,219.33	,
////							214.89	,213.02	,215.67	,210.34	,210.76	,209.27	,211.86	,211.72	,205.06	,203.37	,206.01	,205.94	,209.73	,208.74	,209.73	,213.44	,212.55	,208.7	,
////							213.28	,213.45	,210.92	,207.56	,208.36	,211.44	,212.36	,211.91	,214.05	,217.73	,217.82	,217.82	,216.76	,217.35	,215.49	,215.25	,220.28	,
////							219.02	,220.48	,218.52	,220.09	,220.09	,221.07	,222.25	,221.6	,222.48	,221.58	,225.47	,226.69	,227.48	,227.51	,227.31	,228.27	,226.81	,224.59	,
////							224.69	,228.08	,229.17	,227.69	,223.65	,225.13	,229.09	,227.76	,227.36	,229.64	,229.28	,226.98	,226.11	,227.95	,225.1	,224.76	,220.21	,215.09	,
////							219.1	,217.63	,216.78	,220.8	,221.08	,215.36	,214.42	,212.43	,208.78	,210.27	,204.83	,206.62	,209.83	,212.1	,214.34	,213.02	,217.58	,218.03	,
////							214.38	,216.08	,215.26	,215.73	,219.22	,221.43	,221.34	,223.34	,223.45	,223.77	,227.69	,226.45	,225.59	,227.45	,225.63	,225.55	,222.54	,220.85	,
////							218.65	,217.01	,217.47	,219.12	,217.45	,220.78	,224.44	,225.86	,226.14	,229.27	,228.39	,226.34	,225.32	,225.84	,227.88	,226.23	,229.5	,
////							230.87	,230.93	,231.56	,231.16	,229.25	,232.22	,233.38	,233.14	,232.39	,232.35	,233.14	,232.04	,228.98	,223.96	,227.01	,226.51	,227.96	,
////							228.9	,231.88	,231.17	,230.2	,229.42	,225.99	,225.39	,225.52	,229.63	,226.81	,229.41	,230.66	,231.04	,232.77	,232.45	,230.94	,231.53	,233.93	,236.34	,
////							235.98	,237.14	,235.37	,237.64	,238.29	,239.8	,241.38	,240.59	,242.27	,242.95	,243.49	,243.99	,244.22	,247.7	,247.22	,246.51	,245.44	,242.35	,242.99	,
////							246.25	,246.56	,242.64	,240.11	,241.79	,242.53	,245.84	,248.16	,248.38	,246.61	,246.41	,242.98	,247.41	,247.93	,249.99	,251.12	,251.22	,251.73	,252.07	,255.13	,
////							247.51	,248.35	,249.22	,247.84	,247.3	,251.15	,253.04	,254	,252.12	,252.38	,252.45	,249.31	,248.92	,249.64	,252.8	,256.02	,257.65	,257.32	,258.63	,257.51	,
////							262.32	,261.74	,263.31	,265.13	,265.95	,264.92	,267.67	,267.42	,269.31	,269.6	,269.62	,268.5	,267.35	,269.04	,270.44	,271.19	,273.81	,275.78	,275.35	,274.72	,
////							275.61	,273.99	,275.1	,276.17	,275.52	,278.17	,277.05	,276.6	,279.25	,277.75	,272.67	,274.5	,275.18	,278.81	,279.2	,278.45	,273.12	,273.45	,274.9	,273.16	,
////							269.9	,264.57	,260.4	,266.02	,265.4	,262.56	,261.23	,265.8	,264.55	,260.13	,259.21	,257.69	,259.28	,256.36	,254.96	,260.48	,265.42	,261.44	,263.33	,263.8	,260.59	,
////							256.83	,260.69	,254.29	,259.44	,259.8	,262.39	,264.89	,266.05	,265.67	,268.93	,271.66	,272.13	,274.22	,277.04	,278.87	,280.73	,280.01	,282.03	,281.35	,280.45	,
////							281.05	,280.49	,276.13	,280.68	,283.15	,282.8	,282.14	,280.43	,287.19	,291.16	,290.84	,292.69	,291.38	,292.08	,292.15	,290.39	,295.35	,291.65	,288.46	,283.68	,282.59	,
////							286.3	,280.02	,279.59	,277.22	,277.15	,281.76	,276.47	,278.59	,271.19	,271.78	,268.62	,276.33	,277.35	,276.32	,282.76	,282.75	,278.76	,278.84	,276.97	,274.46	,272.44	,
////							269.04	,269.79	,273.67	,274.53	,268.88	,266.22	,264.39	,268.65	,270.71	,269.34	,274.31	,271.44	,270.41	,274.61	,275.17	,278.77	,281.67	,283.88	,285.12	,286.07	,286.05	,
////							282.46	,275.9	,278.32	,278.03	,279.59	,276.71	,276.58	,280.41	,279.2	,282.59	,279.66	,282.04	,282.7	,280.04	,277.11	,282.36	,275.4	,267.8	,261.54	,251.9	,
////							242.45	,233.52	,233.23	,234.14	,230.38	,242.23	,243.43	,238.31	,222.98	,219.15	,228.12	,225.14	,227.02	,229	,235.78	,237.64	,242.16	,242.37	,240.16	,228.89	,
////							226.65	,236.12	,238.47	,233.4	,225.15	,228.58	,237.5	,235.32	,237.53	,239.51	,232.05	,218.62	,214.18	,225.29	,223.82	,230.37	,230.41	,221.93	,217.34	,223.94	,230.27	,230.82	,
////							234.8	,236.66	,238.09	,239.67	,243.49	,239.89	,242.11	,235.57	,240.02	,248.21	,247.2	,247.56	,251.2	,252.47	,249.88	,249.92	,248.03	,244.09	,252.34	,250.78	,
////							248.32	,249.23	,236.02	,242.99	,248.27	,246.21	,241.98	,244.6	,239.43	,236.64	,237.8	,231.68	,233.35	,231.03	,236.59	,242.5	,241.19	,251.52	,251.19	,252.22	,
////							249.48	,251.57	,250.31	,244.93	,248.55	,243.48	,242.35	,236.72	,239.82	,231.74	,233.83	,241.51	,241.4	,244.22	,242.64	,240.79	,238.15	,238.08	,238.7	,245.82	,
////							244.24	,243.56	,240.57	,238.02	,241.69	,240.83	,243.46	,245.28	,243.1	,247.81	,247.82	,251.27	,256.61	,257.14	,257.52	,258.65	,255.21	,256.9	,257.06	,260.35	,258.53	,258.93	,259.8	,
////							262.94	,264.5	,261.17	,262.75	,262.38	,265.88	,261.89	,265.82	,265.95	,265.89	,266.63	,263.58	,265.2	,261.3	,263.45	,267.13	,267.45	,264.75	,262.85	,260.35	,262.85	,265.62	,
////							263.74	,266.9	,269.85	,269.76	,268.27	,270.27	,269.68	,267.79	,267.98	,267.95	,267.41	,270.71	,269.64	,267.13	,266.58	,268.99	,272.46	,268.33	,269.96	,269.97	,
////							265.88	,265.38	,263.95	,266.86	,264.49	,263.32	,266.22	,265.58	,261.84	,261.66	,260.76	,260.82	,261.51	,263.43	,264.35	,266.61	,266.05	,264.4	,259.73	,261.12	,258.79	,257.89	,254	,
////							254.11	,252.32	,243.93	,244.48	,235.85	,238.62	,242.66	,239.76	,240.51	,241.6	,245.26	,244.68	,244.05	,242.98	,236.3	,238.79	,245.51	,243.69	,248.3	,246.43	,247.08,
////							248.62};
////
////		Real HSCEIData[]={12750.55	,13142.03	,13246.21	,13073.2	,13035.09	,13119.03	,12967.37	,12482.18	,12363.37	,12356.88	,12290.26	,12600.76	,12282.09	,11957.83	,11975.65	,11858.46	,
////						11410.12	,11372.69	,11636.03	,11498.2	,11621.64	,11570.35	,11838.72	,11605.88	,11131.78	,10989.19	,11200.33	,11345.64	,11582.31	,11536.36	,11536.36	,11708.34	,11601.67	,11263.83	,11519.56	,11619.68	,11493.41	,11388.5	,11543.73	,12017.55	,
////						12048.25	,11775.06	,11927.37	,12202.8	,12210.34	,12217.33	,12170.04	,12173.28	,11971.49	,11940.47	,12231.47	,12208.36	,12262.36	,12008.65	,12020.85	,12048.63	,11902.49	,12050.33	,12215.48	,12414.2	,12397.59	,12696.05	,12696.05	,12696.05	,12696.05	,12987.82	,12855.31	,
////						13046.72	,12953.45	,12839.85	,12842.47	,12813.88	,12557.4	,12253.78	,12436.56	,12370.98	,12330.89	,12168.18	,12380.71	,12171.01	,11987.67	,11881.4	,12181.2	,11944.96	,11864.22	,11449.22	,11379.56	,
////						11717.32	,11509.22	,11510.3	,11729.71	,11588.97	,11232.62	,11426.18	,11124.59	,11048.38	,11242.55	,10729.05	,11016.05	,11208.76	,11508.49	,11494.31	,11233.96	,11397.41	,11375.51	,11093.46	,11090.75	,11163.35	,11178.17	,11340.38	,
////						11520.95	,11556.45	,11556.45	,11583.5	,11622.69	,12134.42	,12061.34	,12020.38	,11935.95	,11865.17	,11856.55	,11536.2	,11466.24	,11466.24	,11247.1	,11184.33	,11456.42	,11305.18	,11375.29	,11620.68	,11673.37	,11622.61	,11656.61	,
////						11427.94	,11419.62	,11310.7	,11507.22	,11689.91	,11754.69	,11915.58	,11875.03	,11931.12	,11972.75	,11942.21	,11905	,12181.45	,12120.83	,12137.82	,12128.68	,12161.75	,12225.84	,11943.68	,11737.63	,11597.02	,11641.33	,11726.9	,11754.63	,11711.04	,
////						11848.46	,11779.67	,11670.39	,11573.25	,11495.79	,11436.22	,11395.05	,11531.72	,11402.9	,11481.15	,11688.84	,11767.41	,11960.57	,11956.23	,11776.72	,11830.46	,11835.93	,12088.51	,12135.51	,12088.3	,12001.41	,12171.19	,12164.65	,12218.6	,12316.8	,12180.2	,
////						12429.28	,12406.1	,12406.1	,12614.18	,12682.85	,12772.03	,12738.07	,12758.23	,12951.9	,12979	,13301.49	,13575.95	,13613.22	,13420.32	,13573.6	,13448.83	,13615.41	,13494.8	,13626.08	,13642.45	,13259.1	,13326.9	,13168.68	,13508.17	,
////						13523.21	,13820.99	,13948.49	,14107.29	,14204.13	,14022.95	,13889.32	,14088.03	,13663.14	,13416.25	,13192.58	,12876.34	,13168.49	,13170.65	,13193.71	,12817.32	,12872.05	,12931.11	,12757.1	,12888.27	,12817.59	,12949.85	,13087.4	,12937.1	,12804.77	,12922.24	,12735.86	,12731.42	,
////						12661.01	,12751.82	,12865.05	,12585.04	,12434.95	,12468.88	,12408.49	,12607.43	,12611.3	,12516.52	,12442.94	,12442.94	,12309.59	,12508.52	,12586.84	,12884.85	,12919.04	,12994.41	,12983.29	,12925.71	,12806.59	,12918.07	,13126.98	,13182.59	,13152.14	,12938.05	,
////						12967.2	,13132.33	,12845.49	,12735.57	,12596.43	,12562.05	,12649.97	,12649.6	,12565.56	,12560.66	,12534.86	,12454.07	,12526.26	,12278.6	,12022.6	,12081.82	,12398.05	,12280.27	,12437.23	,12574.77	,12742.53	,12651.38	,12351.66	,12251.61	,12059.75	,12270.43	,12504.53	,12507.02	,12658.18	,
////						12849.77	,12820.81	,12990.8	,13088.93	,12992.5	,12752.01	,12882.75	,12551.96	,12642.77	,12457.68	,12427.92	,12645.65	,12783.2	,12752.61	,12831.94	,12975.54	,12894.47	,12920.44	,13162	,13315.84	,13451.48	,13586.7	,13586.7	,13625.77	,13647.79	,13652.92	,13684.06	,13377.15	,13566.46	,
////						13481.73	,13533.58	,13410.9	,13246.86	,13492.38	,13659.35	,13659.35	,13659.35	,13558.41	,13452.44	,13319.96	,13208.71	,13208.71	,13106.54	,12866.59	,12848.82	,12934.47	,12962.33	,12795.95	,12894.13	,12676.79	,12733.21	,12870.83	,13012.43	,12914.61	,12624.16	,12680.99	,12689.66	,12752.08	,12960.82	,
////						13004.31	,13268.39	,13232.39	,12995.41	,12750.66	,12721.48	,12581.55	,12472.59	,12380.81	,12432.84	,12488.27	,12397.6	,12161.42	,12045.05	,12009.33	,12148.74	,12148.94	,12066.52	,12436.74	,12478.61	,12486.79	,12404.52	,12576.68	,12576.68	,12873.6	,12842.39	,12598.34	,12640.34	,12756.32	,12497.32	,
////						12032.03	,12293.65	,12327.21	,12266.32	,12258.45	,12296.96	,12382.67	,12322.25	,12598.77	,12440.64	,12604.68	,12587.66	,12517.53	,12373.64	,12540.4	,12278.78	,12007.1	,11893.5	,11434.59	,11113.45	,10426.07	,10580.41	,10502.73	,10452.64	,10946.64	,10936.11	,10718.46	,10277.38	,10245.8	,10578.96	,
////						10255.63	,10430.39	,10299.58	,10511.87	,10747.08	,10943.29	,10922.53	,10664.45	,10299.17	,10347.04	,10544.86	,10499.89	,10468.89	,9968.86	,10051.67	,10249.2	,9866.97	,9916.23	,9822.67	,9202.7	,9033.09	,8735.4	,9294.22	,9277.49	,9277.49	,8917.36	,8102.58	,8102.58	,8571.49	,8887.53	,8869.55	,9257.34	,
////						9455.84	,9802.58	,9584.83	,9853.34	,9340.43	,9449.14	,9196.68	,9219.73	,9717.65	,9860.98	,10050.59	,10565.76	,10625.16	,10512.99	,10184.48	,10445.85	,10294.92	,10705.48	,10646.75	,10686.02	,10917.7	,10300.18	,10430.07	,10716.9	,10637.86	,10332.09	,10228.65	,9957.4	,9725.82	,9745.35	,9476.15	,9566.29	,
////						9395.91	,9609.86	,9714.09	,9508.94	,10281.99	,10350.51	,10412.96	,10258.54	,10485.05	,10395.37	,10066.63	,10059.35	,9957.15	,9888.15	,9678.86	,9867.41	,9727.08	,9740.01	,9950.71	,9944.62	,10132.66	,10132.66	,10132.66	,9980.51	,9944.58	,9944.58	,10235.17	,10094.41	,10140.92	,9987.33	,10225.81	,10413.61	,10517.07	,
////						10519.21	,10637.03	,10489.59	,10962.42	,10952.6	,11138.49	,11146.99	,11146.99	,11416.88	,11446.52	,11145.6	,11299.05	,11253.8	,11583.47	,11605.57	,11564.86	,11499.77	,11705.86	,11669.15	,11405.22	,11467.66	,11413.16	,11685.73	,11577.36	,11711.51	,11669.51	,11689.69	,11823.6	,11714.29	,
////						11689.84	,11540.23	,11761.3	,11826.76	,11738.71	,11470.7	,11119.17	,10976.49	,11168.5	,11256.28	,11225.91	,11356.28	,11300.41	,11240.57	,11216.39	,11036.1	,10870.61	,10776	,10767.49	,10658.07	,10591.52	,10811.07	,10701.37	,10532.98	,10640.16	,10658.76	,10859.49	,10859.49	,10744.91	,
////						10744.91	,10744.91	,10596.91	,10664.61	,10936.9	,10844.74	,10794.6	,10896.89	,11047.43	,11050.16	,10810.48	,10817.16	,10812.79	,10911.55	,10905.1	,11081	,11145.96	,10987.06	,10882.18	,10574.41	,10525.75	,10356.64	,10289.81	,10143.07	,9986.98	,10084.59	,9741.97	,9700.87	,9577.18	,9582.46	,
////						9698.6	,9573.94	,9541.33	,9539.29	,9858.19	,9690.67	,9686.03	,9620.87	,9375.33	,9397.99	,9473.46	,9352.79	,9574.8	,9519.53	,9658.4,
////						9518.59};
////		Real drift[] = { 0.0346 ,0.0346 ,0.0346};
////		Real vol_1[] = { 0.5 ,0.55 ,0.6 };
////		Real vol_2[] = { 0.3 ,0.35 ,0.4 };
////		Real dividend_1[] = { 0.01 ,0.012 ,0.014 };
////		Real dividend_2[] = { 0.011 ,0.013 ,0.012 };
////		Real corr[] = {0.51,0.52,0.53};
////
////		
////		std::vector<Date> paraDate;
////
////		std::vector<boost::shared_ptr<Index>> paraIndex;
////		boost::shared_ptr<StockIndex> paraIndex1=boost::shared_ptr<StockIndex>(new StockIndex("drift",0.0145,calendar,daycounter));
////		boost::shared_ptr<StockIndex> paraIndex2=boost::shared_ptr<StockIndex>(new StockIndex("divi1",0.0313,calendar,daycounter));
////		boost::shared_ptr<StockIndex> paraIndex3=boost::shared_ptr<StockIndex>(new StockIndex("divi2",0.0145,calendar,daycounter));
////		boost::shared_ptr<StockIndex> paraIndex4=boost::shared_ptr<StockIndex>(new StockIndex("vol1",0.0313,calendar,daycounter));
////		boost::shared_ptr<StockIndex> paraIndex5=boost::shared_ptr<StockIndex>(new StockIndex("vol2",0.0145,calendar,daycounter));
////		boost::shared_ptr<StockIndex> paraIndex6=boost::shared_ptr<StockIndex>(new StockIndex("corr",0.0313,calendar,daycounter));
////
////		paraIndex.push_back(paraIndex1);
////		paraIndex.push_back(paraIndex2);
////		paraIndex.push_back(paraIndex3);
////		paraIndex.push_back(paraIndex4);
////		paraIndex.push_back(paraIndex5);
////		paraIndex.push_back(paraIndex6);
////
////
////
////		for(Size i=0 ;i<3; ++i){
////			paraDate.push_back(stockDates[i+10]);
////			paraIndex[0]->addFixing(paraDate[i],drift[i],true);
////			paraIndex[1]->addFixing(paraDate[i],vol_1[i],true);
////			paraIndex[2]->addFixing(paraDate[i],vol_2[i],true);
////			paraIndex[3]->addFixing(paraDate[i],dividend_1[i],true);
////			paraIndex[4]->addFixing(paraDate[i],dividend_2[i],true);
////			paraIndex[5]->addFixing(paraDate[i],corr[i],true);
////
////		}
////
////		Size numberDates = 611;
////
////		for(Size i=0 ;i<numberDates; ++i){
////			refIndex[0]->addFixing(stockDates[i],kospi200Data[i],true);
////			refIndex[1]->addFixing(stockDates[i],HSCEIData[i],true);	
////		}
////
////
////		
////		CheckKIType checkKIType=DailyKI;
////
////		//ELSStepDown els100 = ELSStepDown(10000,
////		//								 settlementDate,
////		//								 0,
////		//								 refIndex,
////		//								 eqSchedule,
////		//								 earlyExTriggers,
////		//								 0.0351,
////		//								 KIbarrier,
////		//								 DailyKI,
////		//								 daycounter,
////		//								 calendar
////		//								 );
////		
//////		boost::shared_ptr<ELSStepDownMonthlyR> els101(new ELSStepDownMonthlyR(10000,
//////										 settlementDate,
//////										 0,
//////										 refIndex,
//////										 eqSchedule,
//////										 earlyExTriggers,
//////										 0.00765,
//////										 0.0,
//////										 KIbarrier,
////////										 MonthlyKI,
//////										 DailyKI,
//////										 daycounter,
//////										 calendar)
//////										 );
////
////		/*ELSNotionalProtected els100 = ELSNotionalProtected(10000,
////										 Date(9, Apr, 2012),
////										 0,
////										 refIndex,
////										 schedule,
////										 earlyExTriggers,
////										 0.0935,
////										 daycounter,
////										 calendar
////										 );
////
//// ////// /////
////*/ 
////
//// 
////		Size nTimeSteps=6;
////
////		//boost::shared_ptr<StochasticProcess1D> hwProcess(new HullWhiteProcess(interCurve,0.21,0.121));
////		std::vector<boost::shared_ptr<StochasticProcess1D> > gbmProcessArray;
////		//Period period(3,Months);
////		Real gold_initial = 1665.25;
////		Real co_initial = 115.01;
////
////		boost::shared_ptr<StochasticProcess1D> gbmProcess1(new GeometricBrownianMotionProcess(gold_initial,0.0018,0.2222));//,0.1852906));
////		boost::shared_ptr<StochasticProcess1D> gbmProcess2(new GeometricBrownianMotionProcess(co_initial ,0.0018,0.2529));//,0.1480576));
////		//boost::shared_ptr<HullWhite> HW_model(new HullWhite(interCurve,0.3,0.112));
////
////		gbmProcessArray.push_back(gbmProcess1);
////		gbmProcessArray.push_back(gbmProcess2);
////
////		Matrix correlation(2,2,0.0);
////
////		correlation[0][0] = 1.0;
////		correlation[1][1] = 1.0;
////		correlation[1][0] = 0.210337;
////		correlation[0][1] = 0.210337;
////
////		boost::shared_ptr<StochasticProcessArray> gbmProcess(new StochasticProcessArray(
////		gbmProcessArray,correlation));
////		
////		bool brownianBridge = false;
////
////
////				/*PseudoRandom::rsg_type rsg =
////					PseudoRandom::make_sequence_generator(nTimeSteps, 0);*/
////
////		//boost::shared_ptr<PricingEngine> ELSEngine(new MCELSEngine(gbmProcess,
////		//									interCurve,
////		//									10000,//simulNum
////		//									1));
////
////		//boost::shared_ptr<PricingEngine> ELSGenEngine(new MCELSGeneralEngine(gbmProcess,
////		//									interCurve,
////		//									10000,
////		//									1));
////
////		/*boost::shared_ptr<PricingEngine> ELSGenMonthEngine(new MCELSMonthlyREngine(gbmProcess,
////											interCurve,
////											10000,
////											1));*/
////	
////		/*boost::shared_ptr<PricingEngine> ELSEngine(new MCELSNotionalProtectedEngine(gbmProcess,
////											interCurve,
////											10000,
////											1));*/
////		std::vector<boost::shared_ptr<BarrierCheck>> barrierChecks;
////		
////		barrierChecks.push_back(boost::shared_ptr<BarrierCheck>(new BarrierCheck(gold_initial*1.3,Upper)));
////		barrierChecks.push_back(boost::shared_ptr<BarrierCheck>(new BarrierCheck(co_initial *1.3,Upper)));
////
////		std::vector<boost::shared_ptr<Payoff>> hitEuPayoff;
////		std::vector<boost::shared_ptr<Payoff>> nohitEuPayoff;
////
////		nohitEuPayoff.push_back(boost::shared_ptr<Payoff>(new PlainVanillaPayoff(Option::Call,0.0,0.75)));
////		nohitEuPayoff.push_back(boost::shared_ptr<Payoff>(new ConstantPayoff(1.0)));
////
////		hitEuPayoff.push_back(boost::shared_ptr<Payoff>(new ConstantPayoff(1.03)));
////
////		std::vector<boost::shared_ptr<Payoff>> underlyingTransform;
////
////		underlyingTransform.push_back(boost::shared_ptr<Payoff>(new ReturnStrikePayoff(Option::Call,gold_initial,1.0)));
////		underlyingTransform.push_back(boost::shared_ptr<Payoff>(new ReturnStrikePayoff(Option::Call,co_initial,1.0)));
////
////		boost::shared_ptr<OptionPayoff> optionPayoff(new OptionPayoff(barrierChecks,
////																	  AVER,
////																	  hitEuPayoff,
////																	  nohitEuPayoff,
////																	  underlyingTransform));
////
////
////		EuOption eutest = EuOption(10000,
////									 Date(28, Aug, 2012),
////									 0,
////									 refIndex,
////									 Date(28, Aug, 2013),
////									 optionPayoff,
////									 daycounter,
////									 calendar
////									 );
////
////		boost::shared_ptr<PricingEngine> EuEngine(new MCEuOptionEngine<PseudoRandom>(gbmProcess,
////											Null<Size>(),
////											252,
////											false,
////											false,
////											1000,
////											0.000001,
////											10000,
////											1));
////
////		
//////		const boost::shared_ptr<EquityLinkedSecurity>& equtiypointer=boost::shared_ptr<ELSStepDown>(&els100);
////		boost::shared_ptr<IborIndex> cdAAA=boost::shared_ptr<IborIndex>(new KorCD(cdperiod,interCurve));
////
////		cdAAA->addFixing(Date(18,Jan,2012),0.0352,true);
////		cdAAA->addFixing(settlementDate,0.0352,true);
////		
////		//cdAAA->addFixing(Date(5,Jun,2012),0.0352,true);
////
////
////	//els101->setPricingEngine(ELSGenMonthEngine);//
////	//HistoryCalculatorMC histCalMC(paraDate, els101, paraIndex);
////
////	//Real valueHis=histCalMC.exercute(paraDate[0]);
////
////
////	std::cout << "Start" << std::endl;
////	eutest.setPricingEngine(EuEngine);
////	std::cout << "Eu price                    : " << eutest.NPV() << std::endl;
////	//els100.setPricingEngine(ELSGenEngine);
////
////
////
////	/*EquitySwap unfunded81(VanillaSwap::Type::Payer,
////							  10000,
////							  equtiypointer,
////							  cdAAA,
////							  0.004,
////							  irSchedule,
////							  true
////							  );*/
////	//std::cout << "ELS price General                 : " << els100.NPV() << std::endl;
////
////	//std::cout << "Unfunded price General            : " << unfunded81.NPV() << std::endl;
////
////	//std::cout << "ELS price MonthlyRedem            : " << els101->NPV() << std::endl;
////
////
////	//dls599.setPricingEngine(dlsIREngine);
////	//dls599.setPricingEngine(dlsIRCallableEngine);
////
////	//std::cout << "price with DLS     : " << dls599.NPV() << std::endl;
////
////
//////	Real seconds = timer.elapsed();
//////  std::cout << seconds << std::endl;
////	getchar();
////
////
////
////return 0;
////}
////
////////
////////int main(int, char* []) {
////////	Size ii=0;
////////	double startT;
////////	double endT;
////////	startT=std::clock();
////////	boost::timer timer;
////////	for(Size i=0 ;i<5000000;++i){
////////	
////////			
////////		ii=ii+1;
////////			
////////		//Real seconds =timer.elapsed();
////////
////////	//std::cout << "i : " << i << "  time : " << seconds << std::endl;
////////
////////	/*if(seconds > 0.001){
////////		std::cout << "i : " << i << "  time : " << seconds << std::endl;
////////	}
////////	*/
////////
////////	
////////	}
////////	endT=std::clock();
////////	std::cout << endT-startT << std::endl;
////////	std::cout << ii << std::endl;
////////	getchar();
////////	return 0;
////////}
//////
////////#include <ql/math/randomnumbers/rngtraits.hpp>
////////
////////	Size maxSamples=10000;
////////	Size gridSize = 1000;
////////	Size numberOfSimul= 10000;
////////	Size numAssets = 2;
////////	Size numberOfTimes=1000;
////////	Real RedemCoupon = 0.06;
////////	Real value=0.0;
////////	Real SumdZ1=0.0;
////////	Real SumdZ2=0.0;
////////	bool KI=false;
////////
//////
////////int main(int, char* []) {
////////
////////	
////////
////////	PseudoRandom::rsg_type gen =
////////		PseudoRandom::make_sequence_generator(maxSamples*numAssets * gridSize, 1);
////////
////////	const std::vector<Real>& path=gen.nextSequence().value;
////////	std::vector<Real>::const_iterator randSeqIter=path.begin();
////////	
////////	
////////	for(Size j=0 ;j<numberOfSimul;++j){
////////		
////////		SumdZ1=0.0;
////////		SumdZ2=0.0;
////////		KI=false;
////////
////////		for (Size i = 0; i <numberOfTimes; ++randSeqIter,++i) {
////////				SumdZ1=+(*randSeqIter);
////////				++randSeqIter;
////////				SumdZ2=+(*randSeqIter);
////////				if (SumdZ1>0.8 && //1번만 비교할때는 Trigger를 낮춰서 해도 대겠다.
////////					(0.5*SumdZ1+0.866*SumdZ2) > 0.8)
////////				{
////////					value=+ RedemCoupon*(i+1);
////////					//break;
////////				}
////////				
////////				if(KI==false){
////////					if(SumdZ1<-0.5 || SumdZ2<-0.5)
////////					{
////////						KI=true;
////////					}
////////				}
////////		}
////////
////////	if (KI==false){
////////		value=+ RedemCoupon*(numberOfTimes+1);
////////		break;
////////	}
////////
////////	else{
////////		value=+ std::min(SumdZ1,SumdZ2);
////////	}
////////				
////////	}
////////	//(*pathPricer_)(gen.lastSequence().value);
////////	std::cout << value;
////////}
////
////
//////int main(int, char* []) {
//////
////////        Calendar calendar = TARGET();
//////		Calendar calendar = SouthKorea();
//////        Date settlementDate(2, Mar, 2012);
//////        // must be a business day
//////        settlementDate = calendar.adjust(settlementDate);
//////		DayCounter daycounter = Actual365Fixed();
//////		//DayCounter dc = SimpleDayCounter();
//////
//////        Integer fixingDays = 0;
//////        Natural settlementDays = 0;
//////
//////        //Date todaysDate = calendar.advance(settlementDate, -fixingDays, Days);
//////		Date todaysDate = Date(30, Mar, 2012);
//////        // nothing to do with Date::todaysDate
//////        Settings::instance().evaluationDate() = Date(30, Mar, 2012);
//////
//////        std::cout << "Today: " << todaysDate.weekday()
//////        << ", " << todaysDate << std::endl;
//////
//////        std::cout << "Settlement date: " << settlementDate.weekday()
//////        << ", " << settlementDate << std::endl;
//////
//////
//////
//////
//////		Rate QuoteRate[]={0.0324, 0.0352, 0.0353, 0.0353, 0.0355,0.0356	,
//////				      0.0357, 0.0359, 0.0361, 0.0363, 0.0366,	
//////				      0.0371, 0.0379, 0.0379,  0.0379 ,0.0379};
//////
//////		double Maturity[]={0, 0.25, 0.5, 0.75, 1, 1.5,
//////						   2,    2.5, 3,	4, 5,	
//////						   7,    10,  15,	20    ,25};
//////		
//////		std::vector<Date> MaturityDate;
//////		std::vector<Rate> SpotData;
//////
//////		const Size numberOfSpots = 16;
//////
//////		for (Size i=0;i<numberOfSpots ;i++){
//////			//MaturityDate[i]=today+Maturity[i]*365;
//////			MaturityDate.push_back(todaysDate+Maturity[i]*365);
//////			SpotData.push_back(QuoteRate[i]);
//////
//////		}
//////		
//////		Handle<YieldTermStructure> interCurve(
//////			boost::shared_ptr<YieldTermStructure>(
//////			new InterpolatedZeroCurve< Linear >(MaturityDate,
//////										SpotData,
//////										daycounter,
//////										calendar)));
//////
//////		std::vector<Date> dates;
//////
//////		dates.push_back(Date(2,Mar,2012));     //1
//////		dates.push_back(Date(4,Jun,2012));     //2
//////		dates.push_back(Date(3,Sep,2012));     //3
//////		dates.push_back(Date(3,Dec,2012));     //4
//////		dates.push_back(Date(4,Mar,2013));     //5
//////		dates.push_back(Date(3,Jun,2013));     //6
//////		dates.push_back(Date(2,Sep,2013));     //7
//////		dates.push_back(Date(2,Dec,2013));     //8
//////		dates.push_back(Date(3,Mar,2014));     //9
//////		dates.push_back(Date(2,Jun,2014));     //10
//////		dates.push_back(Date(2,Sep,2014));     //11
//////		dates.push_back(Date(2,Dec,2014));     //12
//////		dates.push_back(Date(2,Mar,2015));     //13
//////		dates.push_back(Date(2,Jun,2015));     //14
//////		dates.push_back(Date(2,Sep,2015));     //15
//////		dates.push_back(Date(2,Dec,2015));     //16
//////		dates.push_back(Date(2,Mar,2016));     //17
//////		dates.push_back(Date(2,Jun,2016));     //18
//////		dates.push_back(Date(2,Sep,2016));     //19
//////		dates.push_back(Date(2,Dec,2016));     //20
//////		dates.push_back(Date(2,Mar,2017));     //21
//////		dates.push_back(Date(2,Jun,2017));     //22
//////		dates.push_back(Date(4,Sep,2017));     //23
//////		dates.push_back(Date(4,Dec,2017));     //24
//////		dates.push_back(Date(2,Mar,2018));     //25
//////		dates.push_back(Date(4,Jun,2018));     //26
//////		dates.push_back(Date(3,Sep,2018));     //27
//////		dates.push_back(Date(3,Dec,2018));     //28
//////		dates.push_back(Date(4,Mar,2019));     //29
//////		dates.push_back(Date(3,Jun,2019));     //30
//////		dates.push_back(Date(2,Sep,2019));     //31
//////		dates.push_back(Date(2,Dec,2019));     //32
//////		dates.push_back(Date(2,Mar,2020));     //33
//////		dates.push_back(Date(2,Jun,2020));     //34
//////		dates.push_back(Date(2,Sep,2020));     //35
//////		dates.push_back(Date(2,Dec,2020));     //36
//////		dates.push_back(Date(2,Mar,2021));     //37
//////		dates.push_back(Date(2,Jun,2021));     //38
//////		dates.push_back(Date(2,Sep,2021));     //39
//////		dates.push_back(Date(2,Dec,2021));     //40
//////		dates.push_back(Date(2,Mar,2022));     //41
//////
//////
//////	
//////		//std::vector<boost::shared_ptr<IborIndex> > indexies;
//////		std::vector<boost::shared_ptr<Index> > indexies;
//////		Period period1(10,Years);
//////		Period period2(5,Years);
//////		//indexies.push_back(boost::shared_ptr<IborIndex>(new KrwcdSwap(interCurve)));
//////		//indexies.push_back(boost::shared_ptr<IborIndex>(new KrwcdSwap(interCurve)));
//////		indexies.push_back(boost::shared_ptr<Index>(new KrwcdSwap(period1)));
//////		indexies.push_back(boost::shared_ptr<Index>(new KrwcdSwap(period2)));
//////
//////		indexies[0]->addFixing(dates[0],0.0352,true);
//////		indexies[1]->addFixing(dates[0],0.0333,true);
//////
//////		//std::vector<std::vector<Real> > uppTri(40);
//////
//////		//std::vector<std::vector<Real> > lowTri(40);
//////		//std::vector<Real> accrualRate;
//////		//
//////		/*uppTri[0].push_back(0.040); uppTri[0].push_back(0.041); accrualRate.push_back(0.05);
//////		lowTri[0].push_back(0.030); lowTri[0].push_back(0.031);
//////		uppTri[1].push_back(0.040); uppTri[1].push_back(0.041); accrualRate.push_back(0.05);
//////		lowTri[1].push_back(0.030); lowTri[1].push_back(0.031);
//////		uppTri[2].push_back(0.040); uppTri[2].push_back(0.041); accrualRate.push_back(0.05);
//////		lowTri[2].push_back(0.030); lowTri[2].push_back(0.031);
//////		uppTri[3].push_back(0.040); uppTri[3].push_back(0.041); accrualRate.push_back(0.05);
//////		lowTri[3].push_back(0.030); lowTri[3].push_back(0.031);
//////
//////		uppTri[4].push_back(0.043); uppTri[4].push_back(0.044); accrualRate.push_back(0.055);
//////		lowTri[4].push_back(0.027); lowTri[4].push_back(0.028);
//////		uppTri[5].push_back(0.043); uppTri[5].push_back(0.044); accrualRate.push_back(0.055);
//////		lowTri[5].push_back(0.027); lowTri[5].push_back(0.028);
//////		uppTri[6].push_back(0.043); uppTri[6].push_back(0.044); accrualRate.push_back(0.055);
//////		lowTri[6].push_back(0.027); lowTri[6].push_back(0.028);
//////		uppTri[7].push_back(0.043); uppTri[7].push_back(0.044); accrualRate.push_back(0.055);
//////		lowTri[7].push_back(0.027); lowTri[7].push_back(0.028);
//////
//////		uppTri[8].push_back(0.046); uppTri[8].push_back(0.047); accrualRate.push_back(0.06);
//////		lowTri[8].push_back(0.024); lowTri[8].push_back(0.025);
//////		uppTri[9].push_back(0.031); uppTri[9].push_back(0.047); accrualRate.push_back(0.06);
//////		lowTri[9].push_back(0.024); lowTri[9].push_back(0.025);
//////		uppTri[10].push_back(0.031); uppTri[10].push_back(0.047); accrualRate.push_back(0.06);
//////		lowTri[10].push_back(0.024); lowTri[10].push_back(0.025);
//////		uppTri[11].push_back(0.031); uppTri[11].push_back(0.047); accrualRate.push_back(0.06);
//////		lowTri[11].push_back(0.024); lowTri[11].push_back(0.025);*/
//////
//////		std::vector<boost::shared_ptr<MonteCoupon>> payoffs;
//////		boost::shared_ptr<MonteCoupon> rngCpn;
//////
//////
//////
//////		for(Size i=0;i<dates.size()-1;++i){
//////			
//////			rngCpn=boost::shared_ptr<MonteCoupon>(
//////				new PowerSpreadCoupon(dates[i+1],10000,dates[i],dates[i+1],fixingDays,indexies,
//////										daycounter,
//////										16.5,
//////									    0.02,
//////									    0.1,
//////									    0.0,
//////									    Date(),
//////									    Date(),
//////									    false,
//////									    false));
//////			payoffs.push_back(rngCpn);
//////
//////		}
//////
//////		dates.erase(dates.begin());
//////		//boost::shared_ptr<IborIndex> cd91(new Euribor6M);
//////		
//////
//////		boost::shared_ptr<PayoffLeg> payoffLeg = boost::shared_ptr<GeneralPayoffLeg>(new GeneralPayoffLeg(dates,payoffs,indexies));
//////		IRDLS dls599 = IRDLS(settlementDays,
//////								calendar,
//////								indexies,
//////								payoffLeg,
//////								10000.0,
//////								settlementDate);
//////
//////
////////		Rate SpotRate[numberOfSpots];
//////
//////		//Date today(4,July,2011);// = calendar.adjust(Date::todaysDate());
//////		
//////
//////
//////
//////		//boost::shared_ptr<StochasticProcess1D> hwProcess(new HullWhiteProcess(interCurve,0.21,0.121));
//////		std::vector<boost::shared_ptr<StochasticProcess1D> > hwprocessArray;
//////		//Period period(3,Months);
//////		//Period period=indexies[0]->tenor();
//////		boost::shared_ptr<StochasticProcess1D> hwProcess1(new HullWhiteProcess(interCurve,period1,0.0046,0.005572));
//////		boost::shared_ptr<StochasticProcess1D> hwProcess2(new HullWhiteProcess(interCurve,period2,0.0046,0.005572));
//////		//boost::shared_ptr<HullWhite> HW_model(new HullWhite(interCurve,0.3,0.112));
//////
//////		hwprocessArray.push_back(hwProcess1);
//////		hwprocessArray.push_back(hwProcess2);
//////
//////		Matrix correlation(2,2,0.0);
//////
//////		correlation[0][0] = 1.0;
//////		correlation[1][1] = 1.0;
//////		correlation[1][0] = 0.999;
//////		correlation[0][1] = 0.999;
//////		boost::shared_ptr<StochasticProcessArray> hwProcess(new StochasticProcessArray(
//////		hwprocessArray,correlation));
//////
//////		boost::shared_ptr<PricingEngine> dlsIREngine(new MCIRDLSEngine(hwProcess,
//////											interCurve,
//////											3000,
//////											1));
//////		boost::shared_ptr<PricingEngine> dlsIRCallableEngine(new MCIRDLSLSEngine(hwProcess,
//////											interCurve,
//////											3000,
//////											1,
//////											1000));
//////
//////	dls599.setPricingEngine(dlsIREngine);
//////	std::cout << "DLS price                    : " << dls599.NPV() << std::endl;
//////	/*dls599.setPricingEngine(dlsIRCallableEngine);
//////	std::cout << "DLS price with Callable      : " << dls599.NPV() << std::endl;*/
//////
//////
//////	//dls599.setPricingEngine(dlsIREngine);
//////	//dls599.setPricingEngine(dlsIRCallableEngine);
//////
//////	//std::cout << "price with DLS     : " << dls599.NPV() << std::endl;
//////
//////
////////	Real seconds = timer.elapsed();
////////  std::cout << seconds << std::endl;
//////	std::cout << "" << dls599.NPV() << std::endl;
//////	getchar();
//////
//////	return 0;
//////
//////}
