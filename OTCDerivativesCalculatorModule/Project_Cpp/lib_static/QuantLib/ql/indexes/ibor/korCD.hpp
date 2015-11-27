/* -*- mode: c++; tab-width: 4; indent-tabs-mode: nil; c-basic-offset: 4 -*- */

/*
 Copyright (C) 2000, 2001, 2002, 2003 RiskMap srl
 Copyright (C) 2003, 2004, 2005, 2006 StatPro Italia srl
 Copyright (C) 2006 Katiuscia Manzoni
 Copyright (C) 2006 Chiara Fornarola
 Copyright (C) 2009 Roland Lichters
 Copyright (C) 2009 Ferdinando Ametrano

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

/*! \file KorCD_.hpp
    \brief %KorCD_ index
*/

#ifndef quantlib_korcd_hpp
#define quantlib_korcd_hpp

#include <ql/indexes/iborindex.hpp>

namespace QuantLib {


    class KorCD : public IborIndex {
      public:
        KorCD(const Period& tenor,
                const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>());
    };

    //! 1-week %KorCD_ index
    class KorCD_1D : public KorCD {
      public:
        KorCD_1D(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorCD(Period(1, Days), h) {}
    };

    //! 2-weeks %KorCD_ index
    class KorCD_7D : public KorCD {
      public:
        KorCD_7D(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorCD(Period(7, Days), h) {}
    };

    //! 3-weeks %KorCD_ index
    class KorCD_15D : public KorCD {
      public:
        KorCD_15D(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorCD(Period(15, Days), h) {}
    };

    //! 1-month %KorCD_ index
    class KorCD_1M : public KorCD {
      public:
        KorCD_1M(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorCD(Period(1, Months), h) {}
    };

    //! 2-months %KorCD_ index
    class KorCD_2M : public KorCD {
      public:
        KorCD_2M(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorCD(Period(2, Months), h) {}
    };

    //! 3-months %KorCD_ index
    class KorCD_3M : public KorCD {
      public:
        KorCD_3M(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorCD(Period(3, Months), h) {}
    };

  
    //! 6-months %KorCD_ index
    class KorCD_6M : public KorCD {
      public:
        KorCD_6M(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorCD(Period(6, Months), h) {}
    };

  
    //! 9-months %KorCD_ index
    class KorCD_9M : public KorCD {
      public:
        KorCD_9M(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorCD(Period(9, Months), h) {}
    };

  
    //! 1-year %KorCD_ index
    class KorCD_1Y : public KorCD {
      public:
        KorCD_1Y(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorCD(Period(1, Years), h) {}
    };

}

#endif
