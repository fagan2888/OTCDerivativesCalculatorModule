#include <ql/testClass/stockIndex.hpp>
#include <ql/settings.hpp>

#include <sstream>

namespace QuantLib {

	StockIndex::StockIndex(const std::string& stockName,
						   Real dividend,
						   const Calendar& fixingCalendar,
						   const DayCounter& dayCounter)
	: stockName_(stockName),dividend_(dividend),fixingCalendar_(fixingCalendar), 
	 dayCounter_(dayCounter) {
        
        registerWith(Settings::instance().evaluationDate());
        registerWith(IndexManager::instance().notifier(name()));
    }

	/*StockIndex::StockIndex(const std::string& stockName,
						   const Handle<YieldTermStructure>& dividendTS,
						   const Calendar& fixingCalendar,
						   const DayCounter& dayCounter)
    : stockName_(stockName),dividend_(dividend),fixingCalendar_(fixingCalendar), 
	 dayCounter_(dayCounter) {
        
        registerWith(Settings::instance().evaluationDate());
        registerWith(IndexManager::instance().notifier(name()));
    }*/
	
  //  std::string StockIndex::name() const {/*
  //      std::ostringstream out;
  //      out << familyName_;
  //      if (tenor_ == 1*Days) {
  //          if (fixingDays_==0)
  //              out << "ON";
  //          else if (fixingDays_==1)
  //              out << "TN";
  //          else if (fixingDays_==2)
  //              out << "SN";
  //          else
  //              out << io::short_period(tenor_);
  //      } else {
  //          out << io::short_period(tenor_);
  //      }
  //      out << " " << dayCounter_.name();
  //      return out.str();*/
  //  }

    Calendar StockIndex::fixingCalendar() const {
        return fixingCalendar_;
    }

    bool StockIndex::isValidFixingDate(const Date& fixingDate) const {
        return fixingCalendar().isBusinessDay(fixingDate);
    }

    Rate StockIndex::fixing(const Date& fixingDate,
                                   bool forecastTodaysFixing) const {
        QL_REQUIRE(isValidFixingDate(fixingDate),
                   "Fixing date " << fixingDate << " is not valid");
        Date today = Settings::instance().evaluationDate();

        Rate pastFixing =
            IndexManager::instance().getHistory(name())[fixingDate];
        QL_REQUIRE(pastFixing != Null<Real>(),
                   "Missing " << name() << " fixing for " << fixingDate);
        return pastFixing;

            
    }

    Date StockIndex::valueDate(const Date& fixingDate) const {
        QL_REQUIRE(isValidFixingDate(fixingDate),
                   "Fixing date " << fixingDate << " is not valid");
        return fixingCalendar().advance(fixingDate, fixingDays_, Days);
    }

    Date StockIndex::fixingDate(const Date& valueDate) const {
        Date fixingDate = fixingCalendar().advance(valueDate,
            -static_cast<Integer>(fixingDays_), Days);
        QL_ENSURE(isValidFixingDate(fixingDate),
                  "fixing date " << fixingDate << " is not valid");
        return fixingDate;
    }

}
