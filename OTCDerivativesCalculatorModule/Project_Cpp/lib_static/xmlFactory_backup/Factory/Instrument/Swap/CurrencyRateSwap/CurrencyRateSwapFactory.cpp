#include <xmlFactory/Factory/Instrument/Swap/CurrencyRateSwap/CurrencyRateSwapFactory.hpp>
#include <xmlFactory/Factory/Etc/all.hpp>

using namespace FpmlSerialized;
using namespace QuantLib;

namespace XmlFactory {

CurrencyRateSwapFactory::CurrencyRateSwapFactory(const boost::shared_ptr<FpmlSerialized::Swap>& crs)
: crs_(crs) {
	// id를 죄다 저장함. 알아서 꺼내씀.

	this->make();
}
boost::shared_ptr<QuantLib::CurrencyRateSwap> CurrencyRateSwapFactory::getInstrument()
{
	return qlcrs_;
}
void CurrencyRateSwapFactory::make()
{
	qlInterestRateIndexFactory irf = qlInterestRateIndexFactory();
	
	const std::vector<boost::shared_ptr<InterestRateStream>>& irStream = crs_->getSwapStream();

	Size streamNum = irStream.size();
			
	QuantLib::Leg legs;
	std::vector<boost::shared_ptr<QuantLib::InterestRateIndex>> irIndexes;
	std::vector<boost::shared_ptr<QuantLib::DayCounter>> dayCounters;

	dayCounters.resize(streamNum);
	irIndexes.resize(streamNum);
	legs.resize(streamNum);

	// iterator로 되나?
	for(Size i=0;i<streamNum;++i){
				
		// 자동 Gen 확인.
		const std::vector<boost::shared_ptr<PaymentCalculationPeriod>>& pcp =
				irStream[i]->getCashflows()->getPaymentCalculationPeriod();
		Size numLeg = pcp.size();

		dayCounters[i] = this->makeDayCounter(irStream[i]->getCalculationPeriodAmount());
		irIndexes[i] =this->irIndex(irStream[i]);

		if(irStream[i]->getCashflows()->isPrincipalExchange())
		{
					
		}
				
				
		for(Size j=0;j<numLeg;++j)
		{
			qlCashFlowFactory cff = qlCashFlowFactory(pcp[j],
													  irIndexes[i],
													  dayCounters[i]);

			legs.push_back(cff.getCashFlow());
		}
	}
			
	std::vector<bool> payer;
	qlcrs_ = boost::shared_ptr<QuantLib::CurrencyRateSwap>(
					new QuantLib::CurrencyRateSwap(legs,payer));
}
boost::shared_ptr<QuantLib::InterestRateIndex> CurrencyRateSwapFactory::irIndex(const boost::shared_ptr<InterestRateStream>& irStream) 
{
	//여기는 floating rate일때만 들어올듯... 검사 필요.. 흐어..

	const boost::shared_ptr<CalculationPeriodAmount>& cpa = 
						irStream->getCalculationPeriodAmount();

	std::string familyName = "ansang";
	QuantLib::Period tenor;
	Natural settlementDays;
    boost::shared_ptr<QuantLib::Currency> currency;
    boost::shared_ptr<QuantLib::Calendar> fixingCalendar;
    boost::shared_ptr<QuantLib::DayCounter> dayCounter;

	qlTimeUnitFactory tuf = qlTimeUnitFactory();
	const boost::shared_ptr<FpmlSerialized::FloatingRateCalculation>& frc = cpa->getCalculation()->getFloatingRateCalculation();
	Integer n = frc->getIndexTenor()->getPeriodMultiplier()->UIValue();
	std::string unit = frc->getIndexTenor()->getPeriod()->SValue();
	tenor = tuf.timeUnit(n,unit);

	qlFixingDateFactory qfdf = qlFixingDateFactory();

	qfdf.dates(irStream->getResetDates());

	qlCurrencyFactory qcf = qlCurrencyFactory();
	currency = qcf.currency(cpa->getCalculation()->getNotionalSchedule()->getNotionalStepSchedule()->getCurrency()->SValue());
			
	// 하위 paymentCalculationOeriod 의 dayCounter는 이걸로 죄다 설정됨.
	qlDayCounterFactory qdcf = qlDayCounterFactory();
	dayCounter = qdcf.dayCounter(cpa->getCalculation()->getDayCountFraction()->SValue());

	qlCalendarFactory cf = qlCalendarFactory();

	//vector나옴 우선 첫번째꺼만 ㄱㄱ
	const std::vector<boost::shared_ptr<BusinessCenter>>& businessCenters = irStream->getResetDates()->getFixingDates()->getBusinessCenters()->getBusinessCenter();
	fixingCalendar = cf.calendar(businessCenters[0]->SValue());

	
	boost::shared_ptr<QuantLib::InterestRateIndex> ir = 
			boost::shared_ptr<QuantLib::InterestRateIndex>(
										new Libor(familyName,
												  tenor,
												  settlementDays,
												  *currency,
												  *fixingCalendar,
												  *dayCounter
												  //termStructure for calculation
												  ));

	return ir;
}
boost::shared_ptr<QuantLib::DayCounter> CurrencyRateSwapFactory::makeDayCounter(const boost::shared_ptr<CalculationPeriodAmount>& cpa)
		{
			qlDayCounterFactory dcf = qlDayCounterFactory();
			boost::shared_ptr<QuantLib::DayCounter> dc;
			if(cpa->isCalculation()){
				dc = dcf.dayCounter(cpa->getCalculation()->getDayCountFraction()->SValue());
			}else if(cpa->isKnownAmountSchedule()){
				// 여기서 그냥 아무거나 넣어야대나..?
			}else{
				QL_FAIL("Either calculation Or knownAmountSchedule  must be defined");
			}

			return dc;

		}
boost::shared_ptr<QuantLib::PricingEngine> getEngine()
{
	boost::shared_ptr<QuantLib::PricingEngine> engine;
	return engine;
}

}