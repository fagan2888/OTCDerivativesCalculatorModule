#ifndef quantlib_stock_index_hpp
#define quantlib_stock_index_hpp

#include <ql/index.hpp>
#include <ql/termstructures/yieldtermstructure.hpp>
#include <ql/handle.hpp>

namespace QuantLib {

    class StockIndex : public Index,
                       public Observer {
      public:
        //for stock
		StockIndex(const std::string& stockName,
				   Real dividend,
				   const Calendar& fixingCalendar,
				   const DayCounter& dayCounter);
		//for commodity
		/*StockIndex(const std::string& stockName,
				   const Handle<YieldTermStructure>& dividendTS,
				   const Calendar& fixingCalendar,
				   const DayCounter& dayCounter);*/


        //! \name Index interface
        //@{
        std::string name() const;
        Calendar fixingCalendar() const;
        bool isValidFixingDate(const Date& fixingDate) const;
        Rate fixing(const Date& fixingDate,
                    bool forecastTodaysFixing = false) const;
        //@}
        //! \name Observer interface
        //@{
        void update();
        //@}
        //! \name Inspectors
        //@{
        Natural fixingDays() const;
        Date fixingDate(const Date& valueDate) const;
        const DayCounter& dayCounter() const;
		Real dividend() const;
        //@}
        /*! \name Date calculations

            These method can be overridden to implement particular
            conventions (e.g. EurLibor)

            @{
        */
        virtual Date valueDate(const Date& fixingDate) const;
        //virtual Date maturityDate(const Date& valueDate) const = 0;
        // @}
      protected:
        //virtual Rate forecastFixing(const Date& fixingDate) const = 0;
        std::string stockName_;
		Real dividend_;
		Handle<YieldTermStructure> dividendTS_;
        Natural fixingDays_;
        Calendar fixingCalendar_;
        DayCounter dayCounter_;
    };


    // inline definitions

    inline void StockIndex::update() {
        notifyObservers();
    }

    inline std::string StockIndex::name() const {
        return stockName_;
    }
    inline Real StockIndex::dividend() const {
        return dividend_;
    }

    inline Natural StockIndex::fixingDays() const {
        return fixingDays_;
    }

    inline const DayCounter& StockIndex::dayCounter() const {
        return dayCounter_;
    }

}

#endif