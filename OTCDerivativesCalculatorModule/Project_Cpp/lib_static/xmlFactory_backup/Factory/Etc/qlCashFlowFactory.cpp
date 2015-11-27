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
	// �ΰ��� ����
	// if null �˻� choice ��� ��������..
	// �켱 null�� ����Ϸ��� built-in type �� Ŭ������ ���ξ߰���... 
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
		//�̰� �Լ��� �Ȼ���.
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
			
	//unadjust�� ���� �ٸ���.. ��.��;; �ƿ�...
	Date startDate = cp->getAdjustedStartDate()->dateValue();
	Date endDate = cp->getAdjustedEndDate()->dateValue();
	Natural fixingDays = 0; //��ã�� ����.
	//index�� �޾Ƽ���.
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
	// if ��? ��... �켱 �ȵ����°� �����ؾ���... schema ���� minOccs �� �� ����.
    DayCounter dayCounter = cp->getDayCountYearFraction()->dayCounter();
			
	//unadjust�� ���� �ٸ���.. ��.��;; �ƿ�...
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