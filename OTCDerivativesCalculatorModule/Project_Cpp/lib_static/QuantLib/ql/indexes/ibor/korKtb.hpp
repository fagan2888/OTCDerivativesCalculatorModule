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

/*! \file KorKtb_.hpp
    \brief %KorKtb_ index
*/

#ifndef quantlib_korktb_hpp
#define quantlib_korktb_hpp

#include <ql/indexes/iborindex.hpp>

namespace QuantLib {


    class KorKtb : public IborIndex {
      public:
        KorKtb(const Period& tenor,
                const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>());
    };

    //! 1-week %KorKtb_ index
    class KorKtb_1D : public KorKtb {
      public:
        KorKtb_1D(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorKtb(Period(1, Days), h) {}
    };

    //! 2-weeks %KorKtb_ index
    class KorKtb_7D : public KorKtb {
      public:
        KorKtb_7D(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorKtb(Period(7, Days), h) {}
    };

    //! 3-weeks %KorKtb_ index
    class KorKtb_15D : public KorKtb {
      public:
        KorKtb_15D(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorKtb(Period(15, Days), h) {}
    };

    //! 1-month %KorKtb_ index
    class KorKtb_1M : public KorKtb {
      public:
        KorKtb_1M(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorKtb(Period(1, Months), h) {}
    };

    //! 2-months %KorKtb_ index
    class KorKtb_2M : public KorKtb {
      public:
        KorKtb_2M(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorKtb(Period(2, Months), h) {}
    };

    //! 3-months %KorKtb_ index
    class KorKtb_3M : public KorKtb {
      public:
        KorKtb_3M(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorKtb(Period(3, Months), h) {}
    };

  
    //! 6-months %KorKtb_ index
    class KorKtb_6M : public KorKtb {
      public:
        KorKtb_6M(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorKtb(Period(6, Months), h) {}
    };

  
    //! 9-months %KorKtb_ index
    class KorKtb_9M : public KorKtb {
      public:
        KorKtb_9M(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorKtb(Period(9, Months), h) {}
    };

  
    //! 1-year %KorKtb_ index
    class KorKtb_1Y : public KorKtb {
      public:
        KorKtb_1Y(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorKtb(Period(1, Years), h) {}
    };

    //! 2-year %KorKtb_ index
    class KorKtb_2Y : public KorKtb {
      public:
        KorKtb_2Y(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorKtb(Period(2, Years), h) {}
    };

	//! 3-year %KorKtb_ index
    class KorKtb_3Y : public KorKtb {
      public:
        KorKtb_3Y(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorKtb(Period(3, Years), h) {}
    };
    //! 4-year %KorKtb_ index
    class KorKtb_4Y : public KorKtb {
      public:
        KorKtb_4Y(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorKtb(Period(4, Years), h) {}
    };

	    //! 5-year %KorKtb_ index
    class KorKtb_5Y : public KorKtb {
      public:
        KorKtb_5Y(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorKtb(Period(5, Years), h) {}
    };
    //! 6-year %KorKtb_ index
    class KorKtb_6Y : public KorKtb {
      public:
        KorKtb_6Y(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorKtb(Period(6, Years), h) {}
    };

	    //! 7-year %KorKtb_ index
    class KorKtb_7Y : public KorKtb {
      public:
        KorKtb_7Y(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorKtb(Period(7, Years), h) {}
    };
    //! 8-year %KorKtb_ index
    class KorKtb_8Y : public KorKtb {
      public:
        KorKtb_8Y(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorKtb(Period(8, Years), h) {}
    };

	    //! 9-year %KorKtb_ index
    class KorKtb_9Y : public KorKtb {
      public:
        KorKtb_9Y(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorKtb(Period(9, Years), h) {}
    };
    //! 10-year %KorKtb_ index
    class KorKtb_10Y : public KorKtb {
      public:
        KorKtb_10Y(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorKtb(Period(10, Years), h) {}
    };

	    //! 15-year %KorKtb_ index
    class KorKtb_15Y : public KorKtb {
      public:
        KorKtb_15Y(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorKtb(Period(15, Years), h) {}
    };
    //! 20-year %KorKtb_ index
    class KorKtb_20Y : public KorKtb {
      public:
        KorKtb_20Y(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorKtb(Period(20, Years), h) {}
    };
	    class KorKtb_30Y : public KorKtb {
      public:
        KorKtb_30Y(const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>())
        : KorKtb(Period(30, Years), h) {}
    };

}

#endif
