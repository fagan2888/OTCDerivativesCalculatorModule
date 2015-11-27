#ifndef quantlib_ir_DLS_hpp
#define quantlib_ir_DLS_hpp

#include <ql/instruments/bond.hpp>
#include <ql/indexes/iborindex.hpp>
#include <ql/testClass/PayoffLeg.hpp>

namespace QuantLib {

class IRDLS : public Bond
{

	public:


		IRDLS(Natural settlementDays,
					  const Calendar& calendar,
					  //const std::vector<boost::shared_ptr<InterestRateIndex>>& refIndex,
					  const std::vector<boost::shared_ptr<Index>>& refIndex,
					  const boost::shared_ptr<PayoffLeg>& payoffLeg,
					  Real Notional=100.0,
					  const Date& issueDate = Date()
					  //const Leg& coupons = Leg()
					  );
			class arguments;
			class results;
			class engine;
			
		void setupArguments(PricingEngine::arguments*) const;
		std::vector<Date> fixingDates() const{return fixingDates_;};
		std::vector<Date> fixingExDates() const{return fixingDates_;};
		boost::shared_ptr<PayoffLeg> payoffLeg() const{return payoffLeg_;};
		void fetchResults(const PricingEngine::results* r) const;
		DayCounter dayCounter() const{return payoffLeg_->payoff()[0]->dayCounter();};

		Real accruedAmount(Date settlement) const;

	protected:
		Real Notional_;
		std::vector<Date> fixingDates_;
		boost::shared_ptr<PayoffLeg> payoffLeg_;
		std::vector<boost::shared_ptr<Index>> refIndex_;

};

class IRDLS::arguments : public Bond::arguments {
    public:
		//추가할거 없네..? ㅡ.ㅡㅋ
        //Date settlementDate;
        //Leg cashflows; // 세팅만 해서 넘겨주면 됨.
        //Calendar calendar;
        //void validate() const;
		Real Notional;
		std::vector<Date> fixingDates;
		boost::shared_ptr<PayoffLeg> payoffLeg;
		std::vector<Period> refIndexTenor; // Yealfraction. Daycount 사용해야하는가..?


};

class IRDLS::results : public Bond::results {
    public:
        //Real settlementValue;
        //void reset() {
        //    settlementValue = Null<Real>();
        //    Instrument::results::reset();
		Leg expectedCashflows;
    
};
	
class IRDLS::engine : public GenericEngine<IRDLS::arguments,
                                              IRDLS::results> {
};



}
#endif