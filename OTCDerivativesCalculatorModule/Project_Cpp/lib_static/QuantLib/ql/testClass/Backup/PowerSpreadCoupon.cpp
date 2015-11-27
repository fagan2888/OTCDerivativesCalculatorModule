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

#include "PowerSpreadCoupon.hpp"
#include <ql/indexes/interestrateindex.hpp>

namespace QuantLib {

    PowerSpreadCoupon::PowerSpreadCoupon(
						   const Date& paymentDate,
                           Real nominal,
                           const Date& startDate,
                           const Date& endDate,
                           Natural fixingDays,
						   std::vector<boost::shared_ptr<Index>>& index,
						   const DayCounter& dayCounter,
						   Real gearing ,
                           Spread spread,
						   Real capRate ,
						   Real floorRate,
						   const Date& refPeriodStart,
                           const Date& refPeriodEnd ,
						   bool accrual,
                           bool isInArrears)

    : MonteCoupon(paymentDate, nominal,startDate, endDate,fixingDays,index,dayCounter,gearing,spread,capRate,floorRate,refPeriodStart,refPeriodEnd,accrual)
			,isInArrears_(isInArrears)
    {
		//�ε����� Ʈ������ dim�� ���ƾ���.
		
		NumOfIndex_=index_.size();

        QL_REQUIRE(NumOfIndex_==2, "PowerSpread must have two Index");

        //if (dayCounter_.empty())
			
            //dayCounter_ = index_[0]->dayCounter();

		//����ī���� �ʿ��� ����Ʈ�� ������ �ȵ�. �ֳĸ� index Interface�� daycounter()�� ����.
		
		for(Size i=0;i<NumOfIndex_;++i){
			registerWith(index_[i]);
		}

        registerWith(Settings::instance().evaluationDate());
		
		//�ε��� ������ ������ ���ƾ���.
    }

   

    Rate PowerSpreadCoupon::rate() const {
		Calendar calendar = index_[0]->fixingCalendar(); // ����? Ķ����?

		Date today = Settings::instance().evaluationDate();
		Date refDate=today;
		Real calRate=0.0;
		Real accrualDate=0.0;
		Real accrualRate=0.0;
		Real trueFlag=1.0;

		if(today > accrualEndDate_){
			if(accrual_){
				for(Size i=0 ; i < observationDays_ ; ++i){
						//�켱 ���� ���߿� ����. Null Calendar ����ؾ���.
						//�Ѳ����� Accrual �Ѱ� Capped ���ִ��� or ������ capped���� �����ؾ���. Default ����.
						calRate = index_[0]->fixing(accrualObservationDates_[i],false) - index_[1]->fixing(accrualObservationDates_[i],false);
						accrualRate = accrualRate + std::max(std::min(gearing_ * calRate + spread_ , capRate_),floorRate_)/totalObservations_;
				}
				return accrualRate ;
			}
			else{

				calRate = index_[0]->fixing(accrualEndDate_,false) - index_[1]->fixing(accrualEndDate_,false);
				return std::max(std::min(gearing_ * calRate + spread_ , capRate_) , floorRate_);/* *
										dayCounter().yearFraction(accrualStartDate_,
                                          std::min(today, accrualEndDate_),
                                          refPeriodStart_,
                                          refPeriodEnd_) ;*/

			}
		}
		else{
			QL_REQUIRE(today > accrualEndDate_,"Can't forecast index, need Simulation");
			
		}
		return 0.0;
		//otherwise 0.0;
		//���� Daycounter���� totalObservation_�� �������� �ɷ� ����
		//return accrualRate_ * accrualDate / totalObservations_;
	}

	Rate PowerSpreadCoupon::expectedRate(const Array& preRate,const Array& refRate) const{
		
		Real calRate=0.0;
		if(!accrual_){
			calRate = gearing_ * (refRate[0] - refRate[1]) + spread_;
		}
		else{
			calRate = gearing_ * ( (refRate[0] - refRate[1]) + (preRate[0] - preRate[1]) ) / 2 + spread_;
		}
		return std::max(std::min(calRate , capRate_),floorRate_);
			
	}

}
