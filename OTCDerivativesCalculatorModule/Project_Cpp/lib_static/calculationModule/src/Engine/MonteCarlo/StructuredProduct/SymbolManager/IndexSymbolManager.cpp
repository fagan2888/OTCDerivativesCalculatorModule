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

#include "IndexSymbolManager.hpp"
#include <boost/algorithm/string/case_conv.hpp>

using boost::algorithm::to_upper_copy;
using std::string;

namespace QuantLib {

    bool IndexSymbolManager::hasSymbol(const string& name) const {
        return ptr_data_.find(to_upper_copy(name)) != ptr_data_.end();
    }
	void IndexSymbolManager::setSymbol(const std::string& name,const boost::shared_ptr<VariableValue>& variableValue) const
	{
		if(this->hasSymbol(name)){
			QL_FAIL("aleady exist symbol name. name : " << name);
		}else{
			ptr_data_[to_upper_copy(name)] = variableValue; //초기화함.
		}
	}

	//void IndexSymbolManager::addConstVariableForPreFixed(const boost::shared_ptr<VariableValue>& variableValue)
	//{
	//	this->constVariables_.push_back(variableValue);
	//}

	//void IndexSymbolManager::setSymbol(const std::string& name,VariableValue* variableValue) const
	//{
	//	if(this->hasSymbol(name))
	//	{
	//		QL_FAIL("aleady exist symbol name. name : " << name);
	//	}else
	//	{
	//		boost::shared_ptr<VariableValue> vv = boost::shared_ptr<VariableValue>(variableValue);
	//		ptr_data_[to_upper_copy(name)] = vv; //초기화함.
	//	}
	//}

	//이놈은 전부 클래스가 만들어진 이후에 불릴것 이므로 없으면 ERROR 뱉음.
	boost::shared_ptr<VariableValue> IndexSymbolManager::getSymbol(const std::string& name,
																   const std::vector<std::string>& circulationCheckString) const
	{
		boost::shared_ptr<VariableValue> ptr;

		if(this->hasSymbol(to_upper_copy(name)))
		{
			ptr = ptr_data_[to_upper_copy(name)];
			if(!(ptr->variableBindingFlag()))
				ptr->variableBind(circulationCheckString);
		}
		else
		{
			QL_FAIL("indexSymbol does not exist.  name : " << name );
		}

		return ptr;
	}

    void IndexSymbolManager::clearSymbol(const string& name) {
        ptr_data_.erase(to_upper_copy(name));
    }

    void IndexSymbolManager::clearSymbol() {
        ptr_data_.clear();
    }

}
