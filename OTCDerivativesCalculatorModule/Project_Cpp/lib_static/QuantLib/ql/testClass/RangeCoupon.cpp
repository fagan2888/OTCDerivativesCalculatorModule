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

    RangeCoupon::RangeCoupon(Real nominal,
                           const Date& startDate,
                           const Date& endDate,
                           Natural fixingDays,
                           Real accrualRate,
						   const std::vector<Real>& upperTrigger,
						   const std::vector<Real>& lowerTrigger,
						   const DayCounter& dayCounter, 
						   std::vector<boost::shared_ptr<Index>>& index,
						   Real gearing ,
						   Spread spread,
						   Real capRate ,
						   Real floorRate ,
						   bool accrual)
    : MonteCoupon(nominal,startDate, endDate,fixingDays,dayCounter,index,gearing,spread,capRate,floorRate,accrual)
		,accrualRate_(accrualRate)		  
    {
		//�ε����� Ʈ������ dim�� ���ƾ���.

		NumOfIndex_=index.size();
		observationDays_=dayCounter.dayCount(accrualStartDate_,accrualEndDate_);
        //if (dayCounter_.empty())
            //dayCounter_ = index_[0]->dayCounter();


		//����ī���� �ʿ��� ����Ʈ�� ������ �ȵ�. �ֳĸ� index Interface�� daycounter()�� ����.
		for(Size i=0;i<NumOfIndex_;++i){
			QL_REQUIRE(upperTrigger[i] >= lowerTrigger[i],"upperTrigger is lower than lowerTrigger");
			upperTrigger_.push_back(upperTrigger[i]);
			lowerTrigger_.push_back(lowerTrigger[i]);
			registerWith(index_[i]);
		}

        registerWith(Settings::instance().evaluationDate());
		
		//�ε��� ������ ������ ���ƾ���.
    }
	
	// notional ���ϱ� ���� ���� ��� ����. accrual �Ȱ� ����.
    Rate RangeCoupon::rate() const {
		Calendar calendar = index_[0]->fixingCalendar();

		Date today = Settings::instance().evaluationDate();
		
		Date loopDate = accrualStartDate_; //������ ����������

		Date refDate=today;
		Real accrualDate=0.0;
		Real trueFlag=1.0;
		if( today >= accrualStartDate_ && today < accrualEndDate_){
			if(!accrual_){

				return  accrualRate_ * dayCounter_.yearFraction(accrualStartDate_,today)/dayCounter_.yearFraction(accrualStartDate_,accrualEndDate_);
				
			}else{
				
				while(loopDate <= today){
					trueFlag=1.0;
				//for(Size j=0 ; j < observationDays_ ; ++j){
					for(Size i=0;i<NumOfIndex_;++i){
						//�켱 ���� ���߿� ����. Null Calendar ����ؾ���.

						if(upperTrigger_[i] > index_[i]->fixing(loopDate,false) &&
							lowerTrigger_[i] < index_[i]->fixing(loopDate,false))
						{}else{
							trueFlag=0.0;
						}
						
					}

					accrualDate  += trueFlag * static_cast<Real>(dayCounter_.dayCount(loopDate,calendar.advance(loopDate,1,Days)));
					//accrualDate += trueFlag; // Real�� ��ȯ
					loopDate=calendar.advance(loopDate,1,Days);
				}
				//otherwise 0.0;
				//���� Daycounter���� totalObservation_�� �������� �ɷ� ����
				// totalObservation_ �ʱ�ȭ �ȵȵ�.
				return accrualRate_ * accrualDate / static_cast<Real>(observationDays_);
			}
		}else{return 0.0;}

	}

	//Rate RangeCoupon::expectedRate(const Array& preRate,const Array& nextRate) const{
	Rate RangeCoupon::expectedRate(const Array& preRate,const Array& refRate) const{

		Size NumOfIndex_=refRate.size();
		Real InFlag=1.0;
		if(!accrual_){
			for(Size i=0;i<NumOfIndex_;++i){
				if(upperTrigger_[i] > preRate[i] &&
					lowerTrigger_[i] < preRate[i] ){
						//���� �̿ϼ�
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
		}
	}
	
	Rate RangeCoupon::expectedArrRate(const Array& preRate,const Array& refRate) const{

		Size NumOfIndex_=refRate.size();
		Real InFlag=1.0;
		if(!accrual_){
			for(Size i=0;i<NumOfIndex_;++i){
				if(upperTrigger_[i] > refRate[i] &&
					lowerTrigger_[i] < refRate[i] ){
						//���� �̿ϼ�
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
		}
	}

	Rate RangeCoupon::InRangeTime(Real preRate,Real refRate,Real up,Real down) const{
	
		Real time;

		if(refRate>preRate){// 6���� ���� 
			if( (preRate<=up && refRate>=up) && down<=preRate )		time = (up-preRate)/(refRate-preRate);
			else if( down<=preRate && up>=refRate )				time = 1.0;
			else if( (down>=preRate && down<=refRate) && up>=refRate )	time = (refRate-down)/(refRate-preRate);
			else if( (down>=preRate && down<=refRate) && (up>=preRate && up<=refRate ) )	time = (up-down)/(refRate-preRate);
			else if( down>=refRate || up<=preRate )				time = 0.0;
		}
		else if(refRate<preRate){// 6���� ���� 
			if( (preRate>=up && refRate<=up) && down<=refRate )		time = (up-refRate)/(preRate-refRate);
			else if( down<=refRate && up>=preRate )				time = 1.0;
			else if( (down<=preRate && down>=refRate) && up>=preRate )	time = (preRate-down)/(preRate-refRate);
			else if( (down>=refRate && down<=preRate) && (up<=preRate && up>=refRate ) )	time = (up-down)/(preRate-refRate);
			else if( down>=preRate || up<=refRate )				time = 0.0;
			
		}
		else{// preRate = refRate
			if( preRate>=up )					time = 0.0;
			else if( down>=preRate )				time = 0.0;
			else if( down<=preRate && up>=preRate )	time = 1.0;
		}
		return time;
		
	}

}