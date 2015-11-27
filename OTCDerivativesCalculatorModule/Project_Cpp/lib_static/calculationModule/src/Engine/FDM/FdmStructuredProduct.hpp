#ifndef calculationModule_fdmstructuredproduct_hpp
#define calculationModule_fdmstructuredproduct_hpp

#include <ql/time/date.hpp>
#include <ql/time/daycounter.hpp>
#include <ql/pricingEngine.hpp>
#include <ql/instrument.hpp>

namespace QuantLib {

	class FdmStructuredProduct : public Instrument
{
	public:
		//중간에 일부가 상환될 수 있으므로 여기서 Notional을 사용하지 않음.
		StructuredProduct(const std::string& productType,
						 const std::string& instrumentID,
						 Real notional,
						 const Date& issueDate,
						 const Date& maturityDate,
						 const boost::shared_ptr<FdmStructuredProductPayoff>& fdm_payoff);
					  
		
		class arguments;
        class results;
        class engine;

		//Instrument interface

		std::string decription() const{return "StructuredProduct";}
		void setupArguments(PricingEngine::arguments* args) const;
		bool isExpired() const{ return false;} // 우선 ㄱㄱ
		//Real accrualNPV() const;

	protected:


	private:
		std::string productType_;
		std::string instrumentID_;
		Real notional_;
		Date issueDate_;
		Date maturityDate_;
		boost::shared_ptr<FdmStructuredProductPayoff> sp_payoff_;
		//Real accrualNPV_;

};

class StructuredProduct::arguments : public PricingEngine::arguments {

    public:
        
        Real notional;
		Date issueDate;
		Date maturityDate;
		Calendar calendar;
		DayCounter dayCounter;
		Natural settlementDays;
		boost::shared_ptr<StructuredProductPayoff> sp_payoff;

		std::vector<Date> indexFixingDates;

		void validate() const{};

};

class StructuredProduct::results : public Instrument::results {
    public:
		//Rate fairRate;
  //      Spread fairSpread;
        //void reset();
};


class StructuredProduct::engine : public GenericEngine<StructuredProduct::arguments,
													   StructuredProduct::results> {
};

}

#endif