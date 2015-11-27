/* -*- mode: c++; tab-width: 4; indent-tabs-mode: nil; c-basic-offset: 4 -*- */

/*
 Copyright (C) 2004, 2005, 2006 StatPro Italia srl

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

#include <ql/testClass/standardswapTest/IndexSymbolManager.hpp>
#include <boost/algorithm/string/case_conv.hpp>

using boost::algorithm::to_upper_copy;
using std::string;

namespace QuantLib {

    bool IndexSymbolManager::hasSymbol(const string& name) const {
        return data_.find(to_upper_copy(name)) != data_.end();
    }

    double* IndexSymbolManager::setSymbol(const string& name) const {
		if(this->hasSymbol(name)){
	        return &(data_[to_upper_copy(name)]);
		}else{
			data_[to_upper_copy(name)]=0.0; //초기화함.
			return &(data_[to_upper_copy(name)]);
		}
    }

    void IndexSymbolManager::clearSymbol(const string& name) {
        data_.erase(to_upper_copy(name));
    }

    void IndexSymbolManager::clearSymbol() {
        data_.clear();
    }

}
