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

#include <ql/testClass/MCSwapEngine.hpp>
#include <iostream>
#include <fstream>


namespace QuantLib {

	//discount 를 거기서 swappayoff에서 해가지고 오는 방법 고려해야함 2012-11-20
    SwapPricer::SwapPricer(const boost::shared_ptr<SwapPayoff>& swappayoff,
							DiscountFactor discount)
				:  discount_(discount),swappayoff_(swappayoff) {

		numAssetsPay_ = swappayoff->assetNumPay();
		numAssetsReceive_ = swappayoff->assetNumReceive();
		
	}

    Real SwapPricer::operator()(const MultiPath& multiPath) const {
	
        Size n = multiPath.pathSize();
        QL_REQUIRE(n>0, "the path cannot be empty");

		Size numAssets = multiPath.assetNumber();
		QL_REQUIRE(numAssets>0, "there must be some paths");
        
		swappayoff_->reset();
		swappayoff_->calculate(multiPath);

		const Array& paySide = swappayoff_->payValue();
		const Array& receiveSide = swappayoff_->receiveValue();
		
		//netPrice = DotProduct(discount_,paySide) + DotProduct(discount_,paySide)

		return 1.0;
    }

}











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