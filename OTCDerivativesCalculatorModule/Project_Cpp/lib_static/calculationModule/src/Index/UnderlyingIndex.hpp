#ifndef quantlib_underlying_index_hpp
#define quantlib_underlying_index_hpp

#include <ql/index.hpp>
#include <ql/currency.hpp>
#include <ql/termstructures/yieldtermstructure.hpp>

namespace QuantLib {

    //! base class for Inter-Bank-Offered-Rate indexes (e.g. %Libor, etc.)
    class UnderlyingIndex : public Index {
      public:
        UnderlyingIndex(const std::string& name,
                   const Currency& currency,
                   const Calendar& fixingCalendar,
                   BusinessDayConvention convention,
                   bool endOfMonth,
                   const DayCounter& dayCounter,
                   const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>());

        //! \name Index interface
		IndexType type() const{return STOCK;}
		//std::string ISINCode() const;
		std::string name() const;
		std::string familyName() const;
		Calendar fixingCalendar() const;
        BusinessDayConvention businessDayConvention() const;
        bool endOfMonth() const { return endOfMonth_; }
        //! the curve used to forecast fixings
        Handle<YieldTermStructure> forwardingTermStructure() const;
		bool isValidFixingDate(const Date& fixingDate) const;
		Rate fixing(const Date& fixingDate,bool forecastTodaysFixing) const;
		Date valueDate(const Date& fixingDate) const;
		Date fixingDate(const Date& valueDate) const;
        //@}
        //! \name Other methods
        //@{
        //! returns a copy of itself linked to a different forwarding curve
        //virtual boost::shared_ptr<UnderlyingIndex> clone(
        //                const Handle<YieldTermStructure>& forwarding) const;
        // @}
	  protected:
		Rate forecastFixing(const Date& fixingDate) const;

      protected:
        //! \name InterestRateIndex interface
        //@{
		// forward Value∏¶ ∂≥±≈¡‹.

		std::string ISINCode_;

		std::string name_;
		std::string familyName_;
		Currency currency_;
		Calendar fixingCalendar_;
        BusinessDayConvention convention_;
        Handle<YieldTermStructure> termStructure_;
        bool endOfMonth_;

	  private:
		Integer fixingDays_;
    };

}

#endif
