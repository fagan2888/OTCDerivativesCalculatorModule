/* -*- mode: c++; tab-width: 4; indent-tabs-mode: nil; c-basic-offset: 4 -*- */

/*
 Copyright (C) 2003 Ferdinando Ametrano
 Copyright (C) 2007 StatPro Italia srl

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

/*! \file vanillaoption.hpp
    \brief Vanilla option on a single asset
*/

#ifndef quantlib_vanilla_option_hpp
#define quantlib_vanilla_option_hpp

#include <ql/instruments/oneassetoption.hpp>
#include <ql/instruments/payoffs.hpp>

namespace QuantLib {

    class GeneralizedBlackScholesProcess;

    //! Warrant Call option (no discrete dividends, no barriers) on a single asset
    /*! \ingroup instruments */
    class WarrantOption : public OneAssetOption {
      public:
        WarrantOption(const Date& issueDate,
 					  const Date& maturityDate,
					  const boost::shared_ptr<StockIndex>& stockIndex,
					  Real initialStrike,
					  const Schedule& exerciseTenor,								 
					  const Schedule& refixingTenor,
					  Real refixingRate);

        Volatility impliedVolatility(
             Real price,
             const boost::shared_ptr<GeneralizedBlackScholesProcess>& process,
             Real accuracy = 1.0e-4,
             Size maxEvaluations = 100,
             Volatility minVol = 1.0e-7,
             Volatility maxVol = 4.0) const;
    };

    bool isExpired() const;

    class WarrantOption::arguments : public virtual PricingEngine::arguments {
      public:
        arguments() {}

        void validate() const {
            QL_REQUIRE(issueDate, "no issueDate given");
            QL_REQUIRE(maturityDate, "no maturityDate given");
			QL_REQUIRE(exerciseTenor, "no exerciseTenor given");
            QL_REQUIRE(initialStrike, "no initialStrike given");
			QL_REQUIRE(stockIndex, "no stockIndex given");

        }
		
		Date issueDate;
	    Date maturityDate;
	    boost::shared_ptr<StockIndex> stockIndex;
	    Real initialStrike;
	    Schedule exerciseTenor;
		Schedule refixingTenor;
	    Real refixingRate;


    };

	//! %Results from single-asset option calculation
    class WarrantOption::results :  public Instrument::results,
                                    public Greeks,
									public MoreGreeks {
      
		public:
			void reset() {
				Instrument::results::reset();
				Greeks::reset();
        }:
        
    };

    class WarrantOption::engine :
        public GenericEngine<WarrantOption::arguments,	
                             WarrantOption::results> {};


}


#endif

