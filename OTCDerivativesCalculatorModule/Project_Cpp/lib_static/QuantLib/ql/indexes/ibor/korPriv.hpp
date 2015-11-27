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

/*! \file KorPriv_.hpp
    \brief %KorPriv_ index
*/

#ifndef quantlib_korpriv_hpp
#define quantlib_korpriv_hpp

#include <ql/indexes/iborindex.hpp>

namespace QuantLib {


    class KorPriv : public IborIndex {
      public:
        KorPriv(const Period& tenor,
                const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>());

    };

    //! 1-week %KorPriv_ index
    class KorPriv_1D : public KorPriv {
      public:
        KorPriv_1D(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorPriv(Period(1, Days), h) {}
    };

    //! 2-weeks %KorPriv_ index
    class KorPriv_7D : public KorPriv {
      public:
        KorPriv_7D(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorPriv(Period(7, Days), h) {}
    };

    //! 3-weeks %KorPriv_ index
    class KorPriv_15D : public KorPriv {
      public:
        KorPriv_15D(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorPriv(Period(15, Days), h) {}
    };

    //! 1-month %KorPriv_ index
    class KorPriv_1M : public KorPriv {
      public:
        KorPriv_1M(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorPriv(Period(1, Months), h) {}
    };

    //! 2-months %KorPriv_ index
    class KorPriv_2M : public KorPriv {
      public:
        KorPriv_2M(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorPriv(Period(2, Months), h) {}
    };

    //! 3-months %KorPriv_ index
    class KorPriv_3M : public KorPriv {
      public:
        KorPriv_3M(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorPriv(Period(3, Months), h) {}
    };

  
    //! 6-months %KorPriv_ index
    class KorPriv_6M : public KorPriv {
      public:
        KorPriv_6M(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorPriv(Period(6, Months), h) {}
    };

  
    //! 9-months %KorPriv_ index
    class KorPriv_9M : public KorPriv {
      public:
        KorPriv_9M(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorPriv(Period(9, Months), h) {}
    };

  
	    //! 1-year %KorPriv_ index
    class KorPriv_1Y : public KorPriv {
      public:
        KorPriv_1Y(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorPriv(Period(1, Years), h) {}
    };
    //! 2-year %KorPriv_ index
    class KorPriv_2Y : public KorPriv {
      public:
        KorPriv_2Y(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorPriv(Period(2, Years), h) {}
    };

	//! 3-year %KorPriv_ index
    class KorPriv_3Y : public KorPriv {
      public:
        KorPriv_3Y(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorPriv(Period(3, Years), h) {}
    };
    //! 4-year %KorPriv_ index
    class KorPriv_4Y : public KorPriv {
      public:
        KorPriv_4Y(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorPriv(Period(4, Years), h) {}
    };

	    //! 5-year %KorPriv_ index
    class KorPriv_5Y : public KorPriv {
      public:
        KorPriv_5Y(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorPriv(Period(5, Years), h) {}
    };
    //! 6-year %KorPriv_ index
    class KorPriv_6Y : public KorPriv {
      public:
        KorPriv_6Y(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorPriv(Period(6, Years), h) {}
    };

	    //! 7-year %KorPriv_ index
    class KorPriv_7Y : public KorPriv {
      public:
        KorPriv_7Y(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorPriv(Period(7, Years), h) {}
    };
    //! 8-year %KorPriv_ index
    class KorPriv_8Y : public KorPriv {
      public:
        KorPriv_8Y(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorPriv(Period(8, Years), h) {}
    };


	    //! 9-year %KorPriv_ index
    class KorPriv_9Y : public KorPriv {
      public:
        KorPriv_9Y(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorPriv(Period(9, Years), h) {}
    };
    //! 10-year %KorPriv_ index
    class KorPriv_10Y : public KorPriv {
      public:
        KorPriv_10Y(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorPriv(Period(10, Years), h) {}
    };

	    //! 15-year %KorPriv_ index
    class KorPriv_15Y : public KorPriv {
      public:
        KorPriv_15Y(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorPriv(Period(15, Years), h) {}
    };
    //! 20-year %KorPriv_ index
    class KorPriv_20Y : public KorPriv {
      public:
        KorPriv_20Y(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorPriv(Period(20, Years), h) {}
    };
	    class KorPriv_30Y : public KorPriv {
      public:
        KorPriv_30Y(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorPriv(Period(30, Years), h) {}
    };

}

#endif
