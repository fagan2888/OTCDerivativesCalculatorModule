#ifndef quantlib_irstructuredDLS_hpp
#define quantlib_irstructuredDLS_hpp

#include <ql/instruments/bond.hpp>
#include <ql/indexes/iborindex.hpp>
#include "PayoffLeg.hpp"

namespace QuantLib {

class IRStructuredDLS : public Bond
{
	public:
		IRStructuredDLS(Natural settlementDays,
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
		boost::shared_ptr<PayoffLeg> payoffLeg() const{return payoffLeg_;};
		void fetchResults(const PricingEngine::results* r) const;

		Real accruedAmount(Date settlement) const;

	protected:
		Real Notional_;
		std::vector<Date> fixingDates_;
		boost::shared_ptr<PayoffLeg> payoffLeg_;
		std::vector<boost::shared_ptr<Index>> refIndex_;

};

class IRStructuredDLS::arguments : public Bond::arguments {
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

class IRStructuredDLS::results : public Bond::results {
    public:
        //Real settlementValue;
        //void reset() {
        //    settlementValue = Null<Real>();
        //    Instrument::results::reset();
		Leg expectedCashflows;
    
};
	
class IRStructuredDLS::engine : public GenericEngine<IRStructuredDLS::arguments,
                                              IRStructuredDLS::results> {
};



}
#endif