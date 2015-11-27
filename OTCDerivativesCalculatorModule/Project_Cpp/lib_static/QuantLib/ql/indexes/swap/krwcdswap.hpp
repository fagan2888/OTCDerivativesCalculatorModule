/* -*- mode: c++; tab-width: 4; indent-tabs-mode: nil; c-basic-offset: 4 -*- */

/*
 Copyright (C) 2008, 2011 Ferdinando Ametrano

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

/*! \file usdliborswap.hpp
    \brief %USD %Libor %Swap indexes
*/

#ifndef quantlib_krwcdswap_hpp
#define quantlib_krwcdswap_hpp

#include <ql/indexes/swapindex.hpp>

namespace QuantLib {

    class KrwcdSwap : public SwapIndex {
      public:
        KrwcdSwap(const Period& tenor,
                              const Handle<YieldTermStructure>& h =
                                    Handle<YieldTermStructure>());
        KrwcdSwap(const Period& tenor,
                              const Handle<YieldTermStructure>& forwarding,
                              const Handle<YieldTermStructure>& discounting);
    };

}

#endif
