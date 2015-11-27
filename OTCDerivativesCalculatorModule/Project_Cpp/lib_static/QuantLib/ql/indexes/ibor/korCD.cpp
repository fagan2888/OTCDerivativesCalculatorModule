/* -*- mode: c++; tab-width: 4; indent-tabs-mode: nil; c-basic-offset: 4 -*- */

/*
 Copyright (C) 2007 Ferdinando Ametrano
 Copyright (C) 2007 Chiara Fornarola

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

#include <ql/indexes/ibor/korCD.hpp>
#include <ql/time/calendars/southkorea.hpp>
#include <ql/time/daycounters/actual365fixed.hpp>
#include <ql/currencies/asia.hpp>

namespace QuantLib {

    namespace {

        BusinessDayConvention korcdConvention(const Period& p) {
            switch (p.units()) {
              case Days:
              case Weeks:
                return Following;
              case Months:
              case Years:
                return ModifiedFollowing;
              default:
                QL_FAIL("invalid time units");
            }
        }

        bool korcdEOM(const Period& p) {
            switch (p.units()) {
              case Days:
              case Weeks:
                return false;
              case Months:
              case Years:
                return true;
              default:
                QL_FAIL("invalid time units");
            }
        }

    }

    KorCD::KorCD(const Period& tenor,
                     const Handle<YieldTermStructure>& h)
    : IborIndex("KorCD", tenor,
                0, // settlement days
                KRWCurrency(), SouthKorea(),
                korcdConvention(tenor), korcdEOM(tenor),
                Actual365Fixed(), h) {
       /* QL_REQUIRE(this->tenor().units()!=Days,
                   "for daily tenors (" << this->tenor() <<
                   ") dedicated DailyTenor constructor must be used");*/
    }

    

}
