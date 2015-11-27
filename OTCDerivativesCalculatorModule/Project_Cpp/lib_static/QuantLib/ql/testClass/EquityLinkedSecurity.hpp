#ifndef quantlib_testClass_ELS_EquityLinkedSecurity_hpp
#define quantlib_testClass_ELS_EquityLinkedSecurity_hpp

#include <ql/instrument.hpp>
#include <ql/time/calendar.hpp>
#include <ql/time/daycounter.hpp>
#include <ql/time/date.hpp>
#include <ql/index.hpp>
#include <ql/time/schedule.hpp>
#include <ql/testclass/StockIndex.hpp>

namespace QuantLib {
	
class EquityLinkedSecurity : public Instrument
{


	public:
		EquityLinkedSecurity(Real notional,
							const Date& issueDate,
							Natural settlementDays,
							//�ȹ޾Ƶ� ��� ������, �����ٿ��� ��������.
							//const std::vector<boost::shared_ptr<Index>>& refIndex,//stock���� �ٲܰ�?.
							//const std::vector<boost::shared_ptr<StockIndex>> refIndex,
							const std::vector<Real>& initialValues,
							const std::vector<Date>& autoCallDates,
							const DayCounter& dayCounter,// ������ index���� �������� ������ �׳� ��.
							const Calendar& calendar
							//const Payoff& payoff
							);//���Ͱ��� Ŭ���� �ϳ� ����(���ø����� ������ ����).

		//instrment interface
		void setupArguments(PricingEngine::arguments*) const;
		void fetchResults(const PricingEngine::results* r) const;
		bool isExpired() const;
		std::vector<Date> fixingDates() const{return fixingDates_;}
		// �����ȯ�� ���� fixingDates.
		virtual std::vector<Date> fixingExDates() const{return fixingDates_;}
		
		const DayCounter& daycounter() const{return dayCounter_;}

		Real notional() const;
		Date issueDate() const;
		Date maturityDate() const;
		

		virtual std::string description() const;
		virtual Date nextCashFlowDate(Date d = Date()) const;
	
		//std::vector<boost::shared_ptr<index>>& refindex
		
		class arguments;
        class results;
        class engine;

	protected:

		Real notional_;
		Date issueDate_;
		Date maturityDate_;
		Natural settlementDays_;
		Calendar calendar_;
		DayCounter dayCounter_;
		std::vector<Date> fixingDates_;
		std::vector<Real> initialValues_;
		std::vector<Date> autoCallDates_;
		//std::vector<boost::shared_ptr<Index>> refIndex_;
		//std::vector<boost::shared_ptr<StockIndex>> refIndex_;

};

class EquityLinkedSecurity::arguments : public PricingEngine::arguments {
    public:
		void validate() const;

		Date issueDate;
		Date maturityDate;
		Real notional;
		Size pastFixingDateNum;
		std::vector<boost::shared_ptr<StockIndex>> refIndex;
		std::vector<Date> fixingDates;
		std::vector<Real> initialValues;
		std::vector<Real> dividends;
		std::vector<Date> autoCallDates;
		DayCounter dayCounter;


		//Real Notional;
		//std::vector<Date> fixingDates;
		//std::vector<Period> refIndexTenor; // Yealfraction. Daycount ����ؾ��ϴ°�..?


};

class EquityLinkedSecurity::results : public Instrument::results {
    public:
		//Leg expectedCashflows;
     void reset() const;
};


class EquityLinkedSecurity::engine : public GenericEngine<EquityLinkedSecurity::arguments,
                                              EquityLinkedSecurity::results> {
};

}

#endif