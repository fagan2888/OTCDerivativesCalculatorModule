#ifndef quantlib_noteinst_hpp
#define quantlib_noteinst_hpp

#include <ql/instrument.hpp>
#include <ql/time/calendar.hpp>
#include <ql/time/daycounter.hpp>

namespace QuantLib {

	class NoteInst : public Instrument {
		public:
			NoteInst(std::string code,
					Real notional,
					const Date& issueDate, // calculation startDate�� ( ���� �����͸� �������� ó�� ���ڰ� �� ) basePrice �� ���� ����� �� ��¥�� ���ؼ� ��������
					const Date& maturityDate,
					const DayCounter& dayCounter,
					const Calendar& calendar
					);
			

			class arguments;
			class results;
			class engine;
			
			//Instrument interface
			void setupArguments(PricingEngine::arguments*) const;
			void fetchResults(const PricingEngine::results* r) const;
			bool isExpired() const;

		protected:

			std::string code_;
			Real notional_;
			Date issueDate_;
			Date maturityDate_;
			Natural settlementDays_;
			Calendar calendar_;
			DayCounter dayCounter_;
	};


class NoteInst::arguments : public PricingEngine::arguments {
	public:
		void validate() const;
			
			std::string code;
			Real notional;
			Date issueDate;
			Date maturityDate;
			Natural settlementDays;
			Calendar calendar;
			DayCounter dayCounter;

};

class NoteInst::results : public Instrument::results {
    public:
		void reset() const;
};

class NoteInst::engine : public GenericEngine<NoteInst::arguments,
                                              NoteInst::results> {
};


}

#endif