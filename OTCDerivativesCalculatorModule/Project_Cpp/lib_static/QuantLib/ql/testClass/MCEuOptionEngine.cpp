/* -*- mode: c++; tab-width: 4; indent-tabs-mode: nil; c-basic-offset: 4 -*- */

/*
 Copyright (C) 2000, 2001, 2002, 2003 RiskMap srl
 Copyright (C) 2003 Neil Firth
 Copyright (C) 2003 Ferdinando Ametrano

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

#include <ql/testClass/mceuoptionengine.hpp>
#include <iostream>
#include <fstream>


namespace QuantLib {

    EuOptionPricer::EuOptionPricer(
                                const boost::shared_ptr<OptionPayoff>& optionpayoff,
                                DiscountFactor discount)
								:  optionpayoff_(optionpayoff), discount_(discount) {



	}

    Real EuOptionPricer::operator()(const MultiPath& multiPath) const {
        Size n = multiPath.pathSize();
        QL_REQUIRE(n>0, "the path cannot be empty");

        Size numAssets = multiPath.assetNumber();
        QL_REQUIRE(numAssets>0, "there must be some paths");





        Size j;
        // calculate the final price of each asset
        Array pathvalue(numAssets, 0.0);
		for (Size k = 0; k < n; k++){
			for (j = 0; j < numAssets; j++){
				//pathvalue[j] = multiPath[j].back();
				pathvalue[j] = multiPath[j][k];
			}
			// k 를 barriercheck date로 사용함(Date로 받으려다가 말음)
			optionpayoff_->checkEventOcc(pathvalue,k);
		}
		//Real price = optionpayoff_->value(pathvalue) * discount_;
		Real price = optionpayoff_->value(pathvalue) * 0.971805109;
		
		//std::cout << price << std::endl ;

		//std::ofstream outStream("processArr.txt");

  //      for (Size i=0; i < numAssets ; i++) {
		//	for (Size j=0; j < n ; j++) {
  //         
		//		outStream << std::endl << multiPath[i][j] << "\t";
  //    
  //         }
  //      }

		//outStream.close();

		optionpayoff_->reset();
        return price;
    }

}

