#include "UnderlyingIndex.hpp"
#include <ql/settings.hpp>
#include <sstream>

namespace QuantLib {

    UnderlyingIndex::UnderlyingIndex(const std::string& name,
                            const Currency& currency,
                            const Calendar& fixingCalendar,
							BusinessDayConvention convention,
							bool endOfMonth,
                            const DayCounter& dayCounter,
							const Handle<YieldTermStructure>& h)
    : name_(name), currency_(currency), fixingCalendar_(fixingCalendar),
      convention_(convention), endOfMonth_(false), termStructure_(h) 
	{
        //registerWith(Settings::instance().evaluationDate());
        //registerWith(IndexManager::instance().notifier(name()));
		Integer fixingDays_ = 0;
    }

    //std::string UnderlyingIndex::ISINCode() const {
    //    return ISINCode_;
    //}
	std::string UnderlyingIndex::name() const {
        return name_;
    }
	std::string UnderlyingIndex::familyName() const {
		QL_FAIL("not implementation");
        return familyName_;
    }

    Calendar UnderlyingIndex::fixingCalendar() const {
        return fixingCalendar_;
    }

	BusinessDayConvention UnderlyingIndex::businessDayConvention() const{
		return convention_;
	}


    bool UnderlyingIndex::isValidFixingDate(const Date& fixingDate) const {
        return fixingCalendar().isBusinessDay(fixingDate);
    }

    Rate UnderlyingIndex::fixing(const Date& fixingDate,
                                   bool forecastTodaysFixing) const {
        QL_REQUIRE(isValidFixingDate(fixingDate),
                   "Fixing date " << fixingDate << " is not valid");
        Date today = Settings::instance().evaluationDate();
        bool enforceTodaysHistoricFixings =
            Settings::instance().enforcesTodaysHistoricFixings();
        if (fixingDate < today ||
            (fixingDate == today && enforceTodaysHistoricFixings && !forecastTodaysFixing)) {
            // must have been fixed
            Rate pastFixing =
                IndexManager::instance().getHistory(name())[fixingDate];
            QL_REQUIRE(pastFixing != Null<Real>(),
                       "Missing " << name() << " fixing for " << fixingDate);
            return pastFixing;
        }
        if ((fixingDate == today) && !forecastTodaysFixing) {
            // might have been fixed
            try {
                Rate pastFixing =
                    IndexManager::instance().getHistory(name())[fixingDate];
                if (pastFixing != Null<Real>())
                    return pastFixing;
                else
                    ;   // fall through and forecast
            } catch (Error&) {
                ;       // fall through and forecast
            }
        }
        // forecast
        return forecastFixing(fixingDate);
    }

    Date UnderlyingIndex::valueDate(const Date& fixingDate) const {
        QL_REQUIRE(isValidFixingDate(fixingDate),
                   "Fixing date " << fixingDate << " is not valid");
        return fixingCalendar().advance(fixingDate, fixingDays_, Days);
    }

    Date UnderlyingIndex::fixingDate(const Date& valueDate) const {
		
        Date fixingDate = fixingCalendar().advance(valueDate,
            -static_cast<Integer>(fixingDays_), Days);
        QL_ENSURE(isValidFixingDate(fixingDate),
                  "fixing date " << fixingDate << " is not valid");
        return fixingDate;
    }

	Rate UnderlyingIndex::forecastFixing(const Date& fixingDate) const
	{
		QL_FAIL("not implementation");
		return 0.0;
	}


}
