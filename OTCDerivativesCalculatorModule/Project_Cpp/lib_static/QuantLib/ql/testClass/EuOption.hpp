#ifndef quantlib_testClass_EuOption_hpp
#define quantlib_testClass_EuOption_hpp

#include <ql/instrument.hpp>
#include <ql/time/calendar.hpp>
#include <ql/time/daycounter.hpp>
#include <ql/time/date.hpp>
#include <ql/index.hpp>
#include <ql/time/schedule.hpp>
#include <ql/testClass/StockIndex.hpp>
#include <ql/testClass/payoff/optionpayoff.hpp>
#include <ql/event.hpp>

namespace QuantLib {

class EuOption : public Instrument
{
	public:

		EuOption(Real notional,
				const Date& issueDate,
				Natural settlementDays,
				const std::vector<boost::shared_ptr<StockIndex>>& refIndex,
				const Date& maturityDate,
				const boost::shared_ptr<OptionPayoff>& optionPayoff,
				const DayCounter& dayCounter,
				const Calendar& calendar
				);

		class arguments;
        class results;
        class engine;

		//Instrument interface
		bool isExpired() const{return detail::simple_event(maturityDate_).hasOccurred();}

		void setupArguments(PricingEngine::arguments*) const;
		void fetchResults(const PricingEngine::results* r) const;
	   
		std::string decription() const{return "EuOption";}
		
	protected:

		//Input argument

		Real notional_;
		Date issueDate_;
		Natural settlementDays_;
		std::vector<boost::shared_ptr<StockIndex>> refIndex_;
		Date maturityDate_;
		boost::shared_ptr<OptionPayoff> optionPayoff_;
		DayCounter dayCounter_;
		Calendar calendar_;


		//calculated parameter

};

class EuOption::arguments : public PricingEngine::arguments {
    public:
		arguments() {}
		void validate() const{}

		Real notional;
		Date issueDate;
		std::vector<boost::shared_ptr<StockIndex>> refIndex;
		Date maturityDate;
		boost::shared_ptr<OptionPayoff> optionPayoff;
		DayCounter dayCounter;
		Calendar calendar;

};

class EuOption::results : public Instrument::results {
    public:
		void reset() const{}
        Real delta, gamma;
        Real theta;
        Real vega;
        Real rho, dividendRho;
};


class EuOption::engine : public GenericEngine<EuOption::arguments,
                                              EuOption::results> {
};

}

#endif