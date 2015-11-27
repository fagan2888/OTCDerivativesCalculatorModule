#include "qlCashFlowFactory.hpp"

using namespace FpmlSerialized;
using namespace QuantLib;

namespace XmlFactory {

qlCashFlowFactory::qlCashFlowFactory(const boost::shared_ptr<FpmlSerialized::PaymentCalculationPeriod>& pcp,
					const boost::shared_ptr<QuantLib::InterestRateIndex> irIndex,
					const boost::shared_ptr<QuantLib::DayCounter> dayCounter)
: pcp_(pcp), irIndex_(irIndex), dayCounter_(dayCounter)
{
			
}

boost::shared_ptr<QuantLib::CashFlow> qlCashFlowFactory::getCashFlow()
{
	// 두개로 나뉨
	// if null 검사 choice 어떻게 구분하지..
	// 우선 null을 사용하려면 built-in type 도 클래스로 감싸야겠음... 
	if(pcp_->isCalculationPeriod())
	{
		QL_REQUIRE((pcp_->getCalculationPeriod()).size() == 1, "CalculationPeriod's number must be 1")
		boost::shared_ptr<FpmlSerialized::CalculationPeriod>& cp = (pcp_->getCalculationPeriod())[0];

		if(cp->isFloatingRateDefinition())
		{
			return this->floatingRateCoupon(cp);

		}else if(cp->isFixedRate())
		{
			return this->fixedRateCoupon(cp);
		}else
		{
			QL_FAIL("rate type invalid");	
		}
	}
	else if(pcp_->isFixedPaymentAmount())
	{
		//이건 함수로 안뺐음.
		QuantLib::Real amount = pcp_->getFixedPaymentAmount()->real();
		QuantLib::Date paymentDate = pcp_->getUnadjustedPaymentDate()->dateValue();

		return this->simpleCashFlow(amount,paymentDate);

	}else
	{
		QL_FAIL("paymentCalculationPeriod not valid");	
	}
}

boost::shared_ptr<QuantLib::FloatingRateCoupon> qlCashFlowFactory::floatingRateCoupon(const boost::shared_ptr<FpmlSerialized::CalculationPeriod>& cp)
{

	Date paymentDate = pcp_->getUnadjustedPaymentDate()->dateValue();
	Real nominal = cp->getNotionalAmount()->dateValue();
			
	//unadjust랑 뭐가 다르지.. ㅡ.ㅡ;; 아오...
	Date startDate = cp->getAdjustedStartDate()->dateValue();
	Date endDate = cp->getAdjustedEndDate()->dateValue();
	Natural fixingDays = 0; //못찾음 아직.
	//index는 받아서씀.
	Real gearing = 1.0;
	if(cp->isFloatingRateMultiplier()) {gearing = cp->getFloatingRateMultiplier()->decimal();}
	Real spread = 0.0;
	if(cp->isSpread()) {spread = cp->getSpread()->decimal();}
	Date refPeriodStart = QuantLib::Date();
	Date refPeriodEnd = QuantLib::Date();
	DayCounter dayCounter = cp->getDayCountYearFraction()->dayCounter();
	bool isInArrears = false;


	return boost::shared_ptr<QuantLib::FloatingRateCoupon>(
				new QuantLib::FloatingRateCoupon(paymentDate,
                    nominal,
                    startDate,
                    endDate,
                    fixingDays,
                    index,
                    gearing,
                    spread,
                    refPeriodStart,
                    refPeriodEnd,
                    dayCounter,
                    isInArrears));
}

boost::shared_ptr<QuantLib::FixedRateCoupon> qlCashFlowFactory::fixedRateCoupon(const boost::shared_ptr<FpmlSerialized::CalculationPeriod>& cp)
{

	Date paymentDate = pcp_->getUnadjustedPaymentDate()->dateValue();
    Real nominal = cp->getNotionalAmount()->real();
    Rate rate = cp->getFixedRate()->real();
	// if 문? 음... 우선 안들어오는걸 조심해야함... schema 에서 minOccs 를 잘 보자.
    DayCounter dayCounter = cp->getDayCountYearFraction()->dayCounter();
			
	//unadjust랑 뭐가 다르지.. ㅡ.ㅡ;; 아오...
    Date accrualStartDate = cp->getAdjustedStartDate()->dateValue();
    Date accrualEndDate = cp->getAdjustedEndDate()->dateValue();

    Date refPeriodStart = Date();
    Date refPeriodEnd = Date();

	return boost::shared_ptr<QuantLib::FixedRateCoupon>(
				new QuantLib::FixedRateCoupon(paymentDate,
									nominal,
									rate,
									dayCounter,
									accrualStartDate,
									accrualEndDate,
									refPeriodStart,
									refPeriodEnd));
}

boost::shared_ptr<QuantLib::SimpleCashFlow> qlCashFlowFactory::simpleCashFlow(QuantLib::Real amount, QuantLib::Date paymentDate)
{
	return boost::shared_ptr<QuantLib::SimpleCashFlow>(new QuantLib::SimpleCashFlow(amount,paymentDate));
}

}