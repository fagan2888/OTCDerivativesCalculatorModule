#include <xmlFactory/Factory/Instrument/Swap/CurrencyRateSwap/CurrencyRateSwapFactory.hpp>
#include <xmlFactory/Factory/Etc/all.hpp>

using namespace FpmlSerialized;
using namespace QuantLib;

namespace XmlFactory {

CurrencyRateSwapFactory::CurrencyRateSwapFactory(const boost::shared_ptr<FpmlSerialized::Swap>& crs)
: crs_(crs) {
	// id�� �˴� ������. �˾Ƽ� ������.

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

	// iterator�� �ǳ�?
	for(Size i=0;i<streamNum;++i){
				
		// �ڵ� Gen Ȯ��.
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
	//����� floating rate�϶��� ���õ�... �˻� �ʿ�.. ���..

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
			
	// ���� paymentCalculationOeriod �� dayCounter�� �̰ɷ� �˴� ������.
	qlDayCounterFactory qdcf = qlDayCounterFactory();
	dayCounter = qdcf.dayCounter(cpa->getCalculation()->getDayCountFraction()->SValue());

	qlCalendarFactory cf = qlCalendarFactory();

	//vector���� �켱 ù��°���� ����
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
				// ���⼭ �׳� �ƹ��ų� �־�ߴ볪..?
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