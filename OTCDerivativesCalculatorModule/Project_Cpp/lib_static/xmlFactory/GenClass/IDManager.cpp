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

#include <idmanager.hpp>
#include <filemanager.hpp>
#include <boost/algorithm/string/case_conv.hpp>
#include <ql/errors.hpp>

#ifdef ConsolePrint
	#include <iostream>
#endif

using boost::algorithm::to_upper_copy;
using std::string;

namespace FpmlSerialized {

    bool IDManager::hasID(const string& name) const {
        return data_.find(to_upper_copy(name)) != data_.end();
    }

    void IDManager::setID(const string& name,const boost::shared_ptr<ISerialized>& id) const {
		
		#ifdef ConsolePrint
			FileManager::instance().outFile_ << FileManager::instance().tap_ << "setID : " << name.c_str() << std::endl;
		#endif

		if(this->hasID(to_upper_copy(name))){
	        QL_FAIL("already exist id : " << name.c_str());
		}else{
			data_[to_upper_copy(name)]=id; //초기화함.
		}
		
    }
	void IDManager::setVID(const string& name,const std::vector<boost::shared_ptr<ISerialized>>& id) const {
		#ifdef ConsolePrint
			FileManager::instance().outFile_ << FileManager::instance().tap_ << "setVID : " << name.c_str() << std::endl;
		#endif

		if(this->hasID(to_upper_copy(name))){
	        QL_FAIL("already exist id : " << name.c_str());
		}else{
			vdata_[to_upper_copy(name)]=id; //초기화함.
		}
    }

	boost::shared_ptr<ISerialized> IDManager::getID(const string& name) const {
		#ifdef ConsolePrint
			FileManager::instance().outFile_ << FileManager::instance().tap_ << "getID : " << name.c_str() << std::endl;
		#endif

		if(this->hasID(to_upper_copy(name))){
			return data_[to_upper_copy(name)];
		}else
		{
			QL_FAIL("id doesn't exist : " << name.c_str());
		}
	}
	std::vector<boost::shared_ptr<ISerialized>> IDManager::getVID(const string& name) const {
		#ifdef ConsolePrint
			FileManager::instance().outFile_ << FileManager::instance().tap_ << "getVID : " << name.c_str() << std::endl;
		#endif

		if(this->hasID(to_upper_copy(name))){
			return vdata_[to_upper_copy(name)];
		}else
		{
			QL_FAIL("id doesn't exist : " << name.c_str());
		}
	}

    void IDManager::clearID(const string& name) {
        data_.erase(to_upper_copy(name));
    }

    void IDManager::clearID() {
        data_.clear();
    }

}
