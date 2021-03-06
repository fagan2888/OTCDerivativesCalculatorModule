
/* -*- mode: c++; tab-width: 4; indent-tabs-mode: nil; c-basic-offset: 4 -*- */

/*
 Copyright (C) 2000, 2001, 2002, 2003 RiskMap srl
 Copyright (C) 2003, 2004, 2005, 2006 StatPro Italia srl
 Copyright (C) 2007, 2008 Ferdinando Ametrano
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

/*! \file index.hpp
    \brief virtual base class for indexes
*/

#ifndef quantlib_stockindex_hpp
#define quantlib_stockindex_hpp

#include <ql/index.hpp>
#include "stockNameIndex.hpp"

namespace QuantLib {
    /*! \warning this class performs no check that the
                 provided/requested fixings are for dates in the past,
                 i.e. for dates less than or equal to the evaluation
                 date. It is up to the client code to take care of
                 possible inconsistencies due to "seeing in the
                 future"
    */
	template<class StockInfo>
    class StockIndex : public Index {
      public:
        //! Returns the name of the index.
        /*! \warning This method is used for output and comparison
                     between indexes. It is <b>not</b> meant to be
                     used for writing switch-on-type code.
        */
		std::string name() const {return StockInfo.name();}
		std::string krCode() const {return StockInfo.krCode();}

        //! returns the fixing TimeSeries
        const TimeSeries<Real>& timeSeries() const {
            return IndexManager::instance().getHistory(name());
        }
        template <class DateIterator, class ValueIterator>
        void addFixings(DateIterator dBegin, DateIterator dEnd,
                        ValueIterator vBegin,
                        bool forceOverwrite = false) {
            std::string tag = StockInfo.name();
            TimeSeries<Real> h = IndexManager::instance().getHistory(tag);
            bool missingFixing, validFixing;
            bool noInvalidFixing = true, noDuplicatedFixing = true;
            Date invalidDate, duplicatedDate;
            Real nullValue = Null<Real>();
            Real invalidValue = Null<Real>();
            Real duplicatedValue = Null<Real>();
            while (dBegin != dEnd) {
                validFixing = isValidFixingDate(*dBegin);
                Real currentValue = h[*dBegin];
                missingFixing= forceOverwrite || close(currentValue,nullValue);
                if (validFixing) {
                    if (missingFixing)
                        h[*(dBegin++)] = *(vBegin++);
                    else if (close(currentValue,*(vBegin))) {
                        ++dBegin;
                        ++vBegin;
                    } else {
                        noDuplicatedFixing = false;
                        duplicatedDate = *(dBegin++);
                        duplicatedValue = *(vBegin++);
                    }
                } else {
                    noInvalidFixing = false;
                    invalidDate = *(dBegin++);
                    invalidValue = *(vBegin++);
                }
            }
            IndexManager::instance().setHistory(tag, h);
            QL_REQUIRE(noInvalidFixing,
                       "At least one invalid fixing provided: " <<
                       invalidDate.weekday() << " " << invalidDate <<
                       ", " << invalidValue);
            QL_REQUIRE(noDuplicatedFixing,
                       "At least one duplicated fixing provided: " <<
                       duplicatedDate << ", " << duplicatedValue <<
                       " while " << h[duplicatedDate] <<
                       " value is already present");
        }
        //! clears all stored historical fixings
        
    };

}

#endif
