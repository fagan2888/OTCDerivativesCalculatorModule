/* -*- mode: c++; tab-width: 4; indent-tabs-mode: nil; c-basic-offset: 4 -*- */

/*
 Copyright (C) 2004 FIMAT Group
 Copyright (C) 2007 StatPro Italia srl
 Copyright (C) 2008 Charles Chongseok Hyun

 This file is part of QuantLib, a free-software/open-source library
 for financial quantitative analysts and developers - http://quantlib.org/

 QuantLib is free software: you can redistribute it and/or modify it
 under the terms of the QuantLib license.  You should have received a
 copy of the license along with this program; if not, please email
 <quantlib-dev@lists.sf.net>. The license is also available online at
 <http://quantlib.org/license.shtml>.

 This program is distributed in the hope that it will be useful, but WITHOUT
 ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
 FOR A PARTICULAR PURPOSE.  See the license for more details.
*/

#include <ql/time/calendars/southkorea.hpp>
#include <ql/errors.hpp>

namespace QuantLib {

    SouthKorea::SouthKorea(Market market) {
        // all calendar instances share the same implementation instance
        static boost::shared_ptr<Calendar::Impl> settlementImpl(
                                              new SouthKorea::SettlementImpl);
        static boost::shared_ptr<Calendar::Impl> krxImpl(
                                                     new SouthKorea::KrxImpl);
        switch (market) {
          case Settlement:
            impl_ = settlementImpl;
            break;
          case KRX:
            impl_ = krxImpl;
            break;
          default:
            QL_FAIL("unknown market");
        }
    }

    bool SouthKorea::SettlementImpl::isWeekend(Weekday w) const {
        return w == Saturday || w == Sunday;
    }

    bool SouthKorea::SettlementImpl::isBusinessDay(const Date& date) const {
        Weekday w = date.weekday();
        Day d = date.dayOfMonth();
        Month m = date.month();
        Year y = date.year();

        if (isWeekend(w)
            // New Year's Day
            || (d == 1 && m == January)
            // Independence Day
            || (d == 1 && m == March)
            // Arbour Day
            || (d == 5 && m == April && y <= 2005)
            // Labour Day
            || (d == 1 && m == May)
            // Children's Day
            || (d == 5 && m == May)
            // Memorial Day
            || (d == 6 && m == June)
            // Constitution Day
            || (d == 17 && m == July && y <= 2007)
            // Liberation Day
            || (d == 15 && m == August)
            // National Foundation Day
            || (d == 3 && m == October)
            // Christmas Day
            || (d == 25 && m == December)

            // Lunar New Year
            || ((d == 21 || d==22 || d==23) && m == January && y == 2004)
            || ((d ==  8 || d ==  9 || d == 10) && m == February && y == 2005)
            || ((d == 28 || d == 29 || d == 30 ) && m == January && y == 2006)
            || (d == 19 && m == February && y == 2007)
            || ((d == 6 || d == 7 || d == 8) && m == February && y == 2008)
            || ((d == 25 || d == 26 || d == 27) && m == January && y == 2009)
            || ((d == 13 || d == 14 || d == 15) && m == February && y == 2010)
            || ((d == 2 || d == 3 || d == 4) && m == February && y == 2011)
            || ((d == 22 || d == 23 || d == 24) && m == January && y == 2012)
            || ((d == 9 || d == 10 || d == 11) && m == February && y == 2013)

			|| ((d == 30 || d == 31 ) && m == January && y == 2014)
			|| ((d == 1 ) && m == February && y == 2014)

            || ((d == 18 || d == 19 || d == 20) && m == February && y == 2015)
            || ((d == 7 || d == 8 || d == 9) && m == February && y == 2016)
            || ((d == 27 || d == 28 || d == 29) && m == January && y == 2017)
            || ((d == 15 || d == 16 || d == 17) && m == February && y == 2018)
			|| ((d == 4 || d == 5 || d == 6) && m == February && y == 2019)
			|| ((d == 24 || d == 25 || d == 26) && m == January && y == 2020)
			|| (( d == 11 || d == 12 || d == 13 ) && m == February && y == 2021 )
			|| (( d == 0 || d == 1 || d == 2 ) && m == February && y == 2022 )
			|| (( d == 21 || d == 22 || d == 23 ) && m == January && y == 2023 )
			|| (( d == 9 || d == 10 || d == 11 ) && m == February && y == 2024 )
			|| (( d == 28 || d == 29 || d == 30 ) && m == January && y == 2025 )
			|| (( d == 16 || d == 17 || d == 18 ) && m == February && y == 2026 )
			|| (( d == 6 || d == 7 || d == 8 ) && m == February && y == 2027 )
			|| (( d == 26 || d == 27 || d == 28 ) && m == January && y == 2028 )
			|| (( d == 12 || d == 13 || d == 14 ) && m == February && y == 2029 )
			|| (( d == 2 || d == 3 || d == 4 ) && m == February && y == 2030 )
			|| (( d == 22 || d == 23 || d == 24 ) && m == January && y == 2031 )
			|| (( d == 10 || d == 11 || d == 12 ) && m == February && y == 2032 )
			
			|| (( d == 30 || d == 31 ) && m == January && y ==2033 )
			|| (( d == 1 ) && m == February && y ==2033 )

			|| (( d == 18 || d == 19 || d == 20 ) && m == February && y == 2034 )
			|| (( d == 7 || d == 8 || d == 9 ) && m == February && y == 2035 )
			|| (( d == 27 || d == 28 || d == 29 ) && m == January && y == 2036 )
			|| (( d == 14 || d == 15 || d == 16 ) && m == February && y == 2037 )
			|| (( d == 3 || d == 4 || d == 5 ) && m == February && y == 2038 )
			|| (( d == 23 || d == 24 || d == 25 ) && m == January && y == 2039 )
			|| (( d == 11 || d == 12 || d == 13 ) && m == February && y == 2040 )
			
			|| (( d == 31 ) && m == January && y ==2041 )
			|| (( d == 1 || d == 2 ) && m == February && y ==2041 )

			|| (( d == 21 || d == 22 || d == 23 ) && m == January && y == 2042 )
			|| (( d == 9 || d == 10 || d == 11 ) && m == February && y == 2043 )
			|| (( d == 29 || d == 30 || d == 31 ) && m == January && y == 2044 )
			|| (( d == 16 || d == 17 || d == 18 ) && m == February && y == 2045 )
			|| (( d == 5 || d == 6 || d == 7 ) && m == February && y == 2046 )
			|| (( d == 25 || d == 26 || d == 27 ) && m == January && y == 2047 )
			|| (( d == 13 || d == 14 || d == 15 ) && m == February && y == 2048 )
			|| (( d == 1 || d == 2 || d == 3 ) && m == February && y == 2049 )

            // Election Days
            || (d == 15 && m == April && y == 2004)    // National Assembly
            || (d == 31 && m == May && y == 2006)      // Regional election
            || (d == 19 && m == December && y == 2007) // Presidency
            || (d ==  9 && m == April && y == 2008)    // National Assembly
            || (d ==  2 && m == June && y == 2010)     // Local election
			|| (d ==  11 && m == April && y == 2012)     // Local election




            // Buddha's birthday
            || (d == 26 && m == May && y == 2004)
            || (d == 15 && m == May && y == 2005)
            || (d ==  5 && m == May && y == 2006)
            || (d == 24 && m == May && y == 2007)
            || (d == 12 && m == May && y == 2008)
            || (d ==  2 && m == May && y == 2009)
            || (d == 21 && m == May && y == 2010)
			|| (d == 10 && m == May && y == 2011)
			|| (d == 28 && m == May && y == 2012)
			|| (d == 17 && m == May && y == 2013)
			|| (d == 6 && m == May && y == 2014)
			|| (d == 25 && m == May && y == 2015)
			|| (d == 14 && m == May && y == 2016)
			|| (d == 3 && m == May && y == 2017)
			|| (d == 22 && m == May && y == 2018)
			|| (d == 12 && m == May && y == 2019)
			|| (d == 30 && m == April && y == 2020)

            // Harvest Moon Day
            || ((d == 27 || d == 28 || d == 29) && m == September && y == 2004)
            || ((d == 17 || d == 18 || d == 19) && m == September && y == 2005)
            || ((d ==  5 || d ==  6 || d ==  7) && m == October && y == 2006)
            || ((d == 24 || d == 25 || d == 26) && m == September && y == 2007)
            || ((d == 13 || d == 14 || d == 15) && m == September && y == 2008)
            || ((d ==  2 || d ==  3 || d ==  4) && m == October && y == 2009)
            || ((d == 21 || d == 22 || d == 23) && m == September && y == 2010)
			|| ((d == 11 || d == 12 || d == 13) && m == September && y == 2011)
			|| ((d == 29 || d == 30 || d == 31) && m == September && y == 2012)

			|| ((d == 18 || d == 19 || d == 20) && m == September && y == 2013)

			|| ((d == 7 || d == 8 || d == 9) && m == September && y == 2014)

			|| ((d == 26 || d == 27 || d == 28) && m == September && y == 2015)

			|| ((d == 14 || d == 15 || d == 16) && m == September && y == 2016)

			|| ((d == 3 || d == 4 || d == 5) && m == October && y == 2017)
			|| ((d == 23 || d == 24 || d == 25) && m == September && y == 2018)
			|| ((d == 12 || d == 13 || d == 14) && m == September && y == 2019)
			|| ((d == 31 || d == 1 || d == 2) && m == October && y == 2020)

            )
            return false;

        return true;
    }

    bool SouthKorea::KrxImpl::isBusinessDay(const Date& date) const {
        // public holidays
        if ( !SettlementImpl::isBusinessDay(date) )
            return false;

        Day d = date.dayOfMonth();
        Month m = date.month();
        Year y = date.year();

        if (// Year-end closing
               (d == 31 && m == December && y == 2004)
            || (d == 30 && m == December && y == 2005)
            || (d == 29 && m == December && y == 2006)
            || (d == 31 && m == December && y == 2007)
            || (d == 31 && m == December && y == 2008)
            || (d == 31 && m == December && y == 2009)
            || (d == 31 && m == December && y == 2010)
			|| (d == 30 && m == December && y == 2011)
			|| (d == 31 && m == December && y == 2012)
			|| (d == 31 && m == December && y == 2013)
			|| (d == 31 && m == December && y == 2014)
			|| (d == 31 && m == December && y == 2015)
			|| (d == 30 && m == December && y == 2016)
			|| (d == 29 && m == December && y == 2017)
			|| (d == 31 && m == December && y == 2018)
			|| (d == 31 && m == December && y == 2019)
			|| (d == 31 && m == December && y == 2020)

            )
            return false;

        return true;
    }

}

