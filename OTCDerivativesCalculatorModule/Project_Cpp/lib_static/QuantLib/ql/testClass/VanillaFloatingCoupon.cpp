/* -*- mode: c++; tab-width: 4; indent-tabs-mode: nil; c-basic-offset: 4 -*- */

/*
 Copyright (C) 2007 Giorgio Facchinetti
 Copyright (C) 2006, 2007 Cristina Duminuco
 Copyright (C) 2006 Ferdinando Ametrano
 Copyright (C) 2000, 2001, 2002, 2003 RiskMap srl
 Copyright (C) 2003, 2004 StatPro Italia srl
 Copyright (C) 2003 Nicolas Di C?ar?

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

#include <ql/testClass/RangeCoupon.hpp>
#include <ql/indexes/interestrateindex.hpp>

namespace QuantLib {

    VanillaFloatingCoupon::VanillaFloatingCoupon(Real nominal,
                           const Date& startDate,
                           const Date& endDate,
                           Natural fixingDays,
						   const DayCounter& dayCounter, 
						   std::vector<boost::shared_ptr<Index>>& index,
						   Real gearing ,
						   Spread spread,
						   Real capRate ,
						   Real floorRate ,
						   bool accrual)
    : MonteCoupon(nominal,startDate, endDate,fixingDays,dayCounter,index,gearing,spread,capRate,floorRate,accrual)
		,accrualRate_(accrualRate), upperTrigger_(upperTrigger),lowerTrigger_(lowerTrigger)
		  
    {

		NumOfIndex_=index.size();
		
        //if (dayCounter_.empty())
            //dayCounter_ = index_[0]->dayCounter();


		//데이카운터 필요함 디폴트로 박으면 안됨. 왜냐면 index Interface에 daycounter()가 없뜸.
		
		for(Size i=0;i<NumOfIndex_;++i){
			QL_REQUIRE(upperTrigger[i] > lowerTrigger[i],"upperTrigger is lower than lowerTrigger");
		}


		for(Size i=0;i<NumOfIndex_;++i){
			registerWith(index_[i]);
		}

        registerWith(Settings::instance().evaluationDate());
		
		//인덱스 개수랑 범위랑 같아야함.
    }

    Rate VanillaFloatingCoupon::rate() const {
		Calendar calendar = index_[0]->fixingCalendar();

		Date today = Settings::instance().evaluationDate();
		Date refDate=today;
		Real accrualDate=0.0;
		Real trueFlag=1.0;
		
		if( today >= accrualStartDate_ && today < accrualEndDate_){
			for(Size j=0 ; j < observationDays_ ; ++j){
				for(Size i=0;i<NumOfIndex_;++i){
					//우선 ㄱㄱ 나중에 수정. Null Calendar 사용해야함.

					if(upperTrigger_[i] < index_[i]->fixing(accrualObservationDates_[i],false) &&
						lowerTrigger_[i] > index_[i]->fixing(accrualObservationDates_[i],false))
					{
						trueFlag=1.0;
					}
				}
				accrualDate=accrualDate+trueFlag; // Real로 변환
			}
		}
		//otherwise 0.0;
		//여기 Daycounter에서 totalObservation_을 가져오는 걸로 수정
		// totalObservation_ 초기화 안된듯.
		return accrualRate_ * accrualDate / totalObservations_;
	}

	//Rate RangeCoupon::expectedRate(const Array& preRate,const Array& nextRate) const{
	Rate VanillaFloatingCoupon::expectedRate(const Array& preRate,const Array& refRate) const{

		Size NumOfIndex_=refRate.size();
		Real InFlag=1.0;
		if(!accrual_){
			for(Size i=0;i<NumOfIndex_;++i){
				if(upperTrigger_[i] > refRate[i] &&
					lowerTrigger_[i] < refRate[i] ){
						//아직 미완성
				}
				else{
					return 0.0;
				}
			}
			return accrualRate_;


		}
		else
		{
			Real time=1.0;
			for(Size i=0;i<NumOfIndex_;++i){
				time=std::min(time,InRangeTime(preRate[i],refRate[i],upperTrigger_[i],lowerTrigger_[i]));
			}
			return time*accrualRate_;	
			//QL_REQUIRE(!accrual_, "No yet implementation");
		}

	}

}