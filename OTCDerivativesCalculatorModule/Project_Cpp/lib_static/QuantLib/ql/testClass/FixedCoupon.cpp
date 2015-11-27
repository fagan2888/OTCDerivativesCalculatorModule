/* -*- mode: c++; tab-width: 4; indent-tabs-mode: nil; c-basic-offset: 4 -*- */

/*
 Copyright (C) 2007 Giorgio Facchinetti
 Copyright (C) 2006, 2007 Cristina Duminuco
 Copyright (C) 2006 Ferdinando Ametrano
 Copyright (C) 2000, 2001, 2002, 2003 RiskMap srl
 Copyright (C) 2003, 2004 StatPro Italia srl
 Copyright (C) 2003 Nicolas Di C?ar?

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

#include <ql/testClass/FixedCoupon.hpp>
#include <ql/indexes/interestrateindex.hpp>

namespace QuantLib {

    FixedCoupon::FixedCoupon(Real nominal,
                           const Date& startDate,
                           const Date& endDate,
                           Natural fixingDays,
                           Real fixedRate,
						   const DayCounter& dayCounter)
    : MonteCoupon(nominal,startDate, endDate,fixingDays,dayCounter) ,
		rate_(InterestRate(fixedRate, dayCounter, Simple, Annual))
				  
    {
		
        registerWith(Settings::instance().evaluationDate());
		
    }

	Rate FixedCoupon::expectedRate(const Array& preRate,const Array& refRate) const{

			return rate_;	
	}

	Real FixedCoupon::accruedAmount(const Date& d) const {
        if (d <= accrualStartDate_ || d > paymentDate_) {
            return 0.0;
        } else {
            return nominal()*(rate_.compoundFactor(accrualStartDate_,
                                                   std::min(d,accrualEndDate_),
                                                   refPeriodStart_,
                                                   refPeriodEnd_) - 1.0);
        }
    }
}