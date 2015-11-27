#include <ql/testClass/EquitySwap.hpp>
#include <ql/cashflows/simplecashflow.hpp>
#include <ql/cashflows/iborcoupon.hpp>
#include <ql/termstructures/yieldtermstructure.hpp>
#include <ql/pricingengines/swap/discountingswapengine.hpp>

#include <iostream>

namespace QuantLib{

EquitySwap::EquitySwap(Type type,
					   Real notional,
					   const boost::shared_ptr<EquityLinkedSecurity>& equityLinkedSecurity,
					   const boost::shared_ptr<IborIndex>& Index,
					   Spread spread,
					   const Schedule& schedule,
					   bool fundedFlag)
	:VanillaSwap(type,notional,	equityLinkedSecurity->schedule(),equityLinkedSecurity->daycounter(),
	schedule,Index,spread,equityLinkedSecurity->daycounter()),equityLinkedSecurity_(equityLinkedSecurity),fundedFlag_(fundedFlag)
	{
	
		QL_REQUIRE(equityLinkedSecurity_, "equityLinkedSecurity given");
		
		// vanilla swap에서 
		paymentConvention_ = schedule.businessDayConvention();
		Calendar calendar = schedule.calendar();
		Leg equityleg;

		const std::vector<Real>& earlyExProbability = 
			equityLinkedSecurity_->result<std::vector<Real>>("earlyExProbability");
		const std::vector<Real>& expectedRedem = 
			equityLinkedSecurity_->result<std::vector<Real>>("expectedRedem");  //expectedRedem.size() := additionalStats_.resize(numberOfTimes+pastFixingNum); In <ql/testClass/MCELSGeneralEngine.cpp>
		const Handle<YieldTermStructure>& discountCurve = 
			equityLinkedSecurity_->result<Handle<YieldTermStructure>>("DiscountCurveForSwap");

		const std::vector<Date>& equityExDates = equityLinkedSecurity_->fixingExDates();
		const std::vector<Date>& irDates = schedule.dates();
		std::vector<Real> earlyExWholeProbability;

		Date today=Settings::instance().evaluationDate();
		Size fixingDatesNum=equityExDates.size();
		Size irLegNum= schedule.size();
		Size pasteqDatesNum=0; Size pastirDatesNum=0;
		//Real irPartNPV_=0.0;Real equityPartNPV_=0.0; Real accrualNPV_=0.0;

		for(Size i=0;i<fixingDatesNum;++i){
			if(equityExDates[i] < today){
				pasteqDatesNum=pasteqDatesNum+1;
			}
		}

		for(Size i=1;i<irLegNum;++i){  //irDates 가 최초 발행일도 포함하므로 제외하기위해 i=1을 사용함.
			if(irDates[i] < today){
				pastirDatesNum=pastirDatesNum+1;
			}
		}
		// IborLeg 가 지난 일자는 빼고 Cashflow를 만들어서, 뒤에 과거지난 개수 구한뒤에 더해서 사용함.
		irleg_ = IborLeg(floatingSchedule_, iborIndex_)
            .withNotionals(nominal_)
            .withPaymentDayCounter(floatingDayCount_)
            .withPaymentAdjustment(paymentConvention_)
            .withSpreads(spread_);

		std::vector<Real> irexpectedflows(irLegNum,0.0);
		
		std::vector<Real> eqEarlyExProbAdjust(fixingDatesNum,0.0); // P1 = sumPi, P2 = sumPi - P1 , P3 = sumPi- (P1+P2) ...
		std::vector<Real> irEarlyExProbAdjust(irLegNum,0.0); // P1 = sumPi, P2 = sumPi - P1 , P3 = sumPi- (P1+P2) ...

		for(Size k=0;k<fixingDatesNum;++k){
			if( equityExDates[k] < today){
				eqEarlyExProbAdjust[k]=0.0; // 지난건 확률을 0 넣음.
			}else{
				for(Size m=k;m<fixingDatesNum;++m){
					eqEarlyExProbAdjust[k]+=earlyExProbability[m];
				}
			}
		}

		Size j=0;
		Real front_ratio=0.0;
		Real back_ratio=0.0;

		//irEarlyExProbAdjust[0] -> 첫날꺼는 사용 안함
		irEarlyExProbAdjust[0] = eqEarlyExProbAdjust[0];

		if(irDates[0] > equityExDates[0]){j=j+1;}

		for(Size i=1;i<irLegNum;++i){
			if(irDates[i] <= equityExDates[j]){

				irEarlyExProbAdjust[i] = eqEarlyExProbAdjust[j];
				
//				irexpectedflows[i]=irleg_[i]->amount()*discountCurve->discount(equityExDates[i]);
			}else{
				
				Size total_accuralDays = calendar.businessDaysBetween(irDates[i-1],irDates[i]);
				Size front_accuralDays = calendar.businessDaysBetween(irDates[i-1],equityExDates[j]);
				Size back_accuralDays = calendar.businessDaysBetween(equityExDates[j],irDates[i]);
				
				if(j<fixingDatesNum-1){
					front_ratio = (static_cast<Real>(front_accuralDays)/static_cast<Real>(total_accuralDays))*eqEarlyExProbAdjust[j];
					back_ratio = static_cast<Real>(back_accuralDays)/static_cast<Real>(total_accuralDays)*eqEarlyExProbAdjust[j+1];
					while( equityExDates[j] < irDates[i] && j<fixingDatesNum-1){
						j=j+1;  //조기상환 Tenor가 매우 짧아 이자율 Tenor 사이에 여러개가 들어가는 경우 다시 생각해야함.( 지금은 1개만 있는 경우로 근사됨 )
					}
				}else if(j==fixingDatesNum-1){
					front_ratio = (static_cast<Real>(front_accuralDays)/static_cast<Real>(total_accuralDays))*eqEarlyExProbAdjust[j];
					back_ratio = (static_cast<Real>(back_accuralDays)/static_cast<Real>(total_accuralDays))*eqEarlyExProbAdjust[j];
				}else{
					QL_REQUIRE(false, "check schedule... something wrong");
				}

				irEarlyExProbAdjust[i] = front_ratio+back_ratio;
				
			}
			
		}

		//equity part는 지난거까지 다 뿌리고, ir part는 남은거만 뿌림.
		if(!fundedFlag_){
			for(Size i=0;i<irleg_.size()-pastirDatesNum;i++){ // irleg_.size()에서 과거 지난거 까지 같이 나옴
				expectedIRCashFlow_.push_back(irleg_[pastirDatesNum+i]->amount()*irEarlyExProbAdjust[pastirDatesNum+i+1]);
				legs_[1].push_back(boost::shared_ptr<CashFlow>(new SimpleCashFlow(expectedIRCashFlow_[i], irDates[pastirDatesNum+i+1])));
			}
			for(Size i=0;i<expectedRedem.size();i++){
				legs_[0].push_back(boost::shared_ptr<CashFlow>(new SimpleCashFlow((expectedRedem[i]-earlyExProbability[i])*notional, equityExDates[i])));
			}

		}else{
		
			for(Size i=0;i<irleg_.size()-pastirDatesNum;i++){ // irleg_.size()에서 과거 지난거 까지 같이 나옴
				expectedIRCashFlow_.push_back(irleg_[pastirDatesNum+i]->amount()*irEarlyExProbAdjust[pastirDatesNum+i+1]);
				legs_[1].push_back(boost::shared_ptr<CashFlow>(new SimpleCashFlow(expectedIRCashFlow_[i], irDates[pastirDatesNum+i+1])));

			}
			for(Size i=0;i<expectedRedem.size();i++){
				legs_[0].push_back(boost::shared_ptr<CashFlow>(new SimpleCashFlow(expectedRedem[i]*notional, equityExDates[i])));
				legs_[1].push_back(boost::shared_ptr<CashFlow>(new SimpleCashFlow(notional*earlyExProbability[i], equityExDates[i])));
			
			}
		
		}

		/*for(Size i=0;i<legs_[0].size();++i){
			std::cout << "legs_[0][ "<< i << "] : " << legs_[0][i]->amount() << std::endl;
		}

		std::cout << std::endl;

		for(Size i=0;i<legs_[1].size();++i){
			std::cout << "legs_[1][ "<< i << "] : " << legs_[1][i]->amount() << std::endl;
		}*/
		// 다음 기 이자는 100% 들어오므로 그냥 ㄱㄱ함. Sum{Pi} = 1
		if(today <= irDates.back()){
			accrualNPV_=irleg_[pastirDatesNum]->amount()*
                floatingDayCount_.yearFraction(irDates[pastirDatesNum],today)/floatingDayCount_.yearFraction(irDates[pastirDatesNum],irDates[pastirDatesNum+1]);
		}else{
			accrualNPV_=0.0; // 만기 지난거
		}



        for (Leg::const_iterator i = legs_[1].begin(); i < legs_[1].end(); ++i)
            registerWith(*i);

		for (Leg::const_iterator i = legs_[0].begin(); i < legs_[0].end(); ++i)
            registerWith(*i);

		registerWith(equityLinkedSecurity);
		registerWith(Index);

		 switch (type_) {
          case Payer:
            payer_[0] = -1.0;
            payer_[1] = +1.0;
            break;
          case Receiver:
			accrualNPV_= accrualNPV_ * (-1.0);
            payer_[0] = +1.0;
            payer_[1] = -1.0;
            break;
          default:
            QL_FAIL("Unknown EquitySwap type");
	
	}
		
		 setPricingEngine(boost::shared_ptr<PricingEngine>(new DiscountingSwapEngine(discountCurve)));
	

		 // 각각 expected Vaule 게산해서 넣어야함 2012 - 06- 11
}
EquitySwap::EquitySwap(Type type,
					   Real notional,
					   const boost::shared_ptr<IRDLS>& irdls,
					   const boost::shared_ptr<IborIndex>& Index,
					   Spread spread,
					   const Schedule& schedule,
					   bool fundedFlag)
	:VanillaSwap(type,notional,	Schedule(irdls->fixingDates(),irdls->calendar(),schedule.businessDayConvention()),irdls->dayCounter(),
	schedule,Index,spread,irdls->dayCounter()),irdls_(irdls),fundedFlag_(fundedFlag)
	{

	
		QL_REQUIRE(irdls_, "IRDLS given");
		
		// vanilla swap에서 
		paymentConvention_ = schedule.businessDayConvention();
		Calendar calendar = schedule.calendar();
		Leg equityleg;

		const std::vector<Real>& earlyExProbability = 
			irdls_->result<std::vector<Real>>("earlyExProbability");
		const std::vector<Real>& expectedRedem = 
			irdls_->result<std::vector<Real>>("expectedRedem");  //expectedRedem.size() := additionalStats_.resize(numberOfTimes+pastFixingNum); In <ql/testClass/MCELSGeneralEngine.cpp>
		const Handle<YieldTermStructure>& discountCurve = 
			irdls_->result<Handle<YieldTermStructure>>("DiscountCurveForSwap");

		const std::vector<Date>& equityExDates = irdls_->fixingExDates();
		const std::vector<Date>& irDates = schedule.dates();
		std::vector<Real> earlyExWholeProbability;

		Date today=Settings::instance().evaluationDate();
		Size fixingDatesNum=equityExDates.size();
		Size irLegNum= schedule.size();
		Size pasteqDatesNum=0; Size pastirDatesNum=0;
		//Real irPartNPV_=0.0;Real equityPartNPV_=0.0; Real accrualNPV_=0.0;

		for(Size i=0;i<fixingDatesNum;++i){
			if(equityExDates[i] < today){
				pasteqDatesNum=pasteqDatesNum+1;
			}
		}

		for(Size i=1;i<irLegNum;++i){  //irDates 가 최초 발행일도 포함하므로 제외하기위해 i=1을 사용함.
			if(irDates[i] < today){
				pastirDatesNum=pastirDatesNum+1;
			}
		}
		// IborLeg 가 지난 일자는 빼고 Cashflow를 만들어서, 뒤에 과거지난 개수 구한뒤에 더해서 사용함.
		irleg_ = IborLeg(floatingSchedule_, iborIndex_)
            .withNotionals(nominal_)
            .withPaymentDayCounter(floatingDayCount_)
            .withPaymentAdjustment(paymentConvention_)
            .withSpreads(spread_);

		std::vector<Real> irexpectedflows(irLegNum,0.0);
		
		std::vector<Real> eqEarlyExProbAdjust(fixingDatesNum,0.0); // P1 = sumPi, P2 = sumPi - P1 , P3 = sumPi- (P1+P2) ...
		std::vector<Real> irEarlyExProbAdjust(irLegNum,0.0); // P1 = sumPi, P2 = sumPi - P1 , P3 = sumPi- (P1+P2) ...

		for(Size k=0;k<fixingDatesNum;++k){
			if( equityExDates[k] < today){
				eqEarlyExProbAdjust[k]=0.0; // 지난건 확률을 0 넣음.
			}else{
				for(Size m=k;m<fixingDatesNum;++m){
					eqEarlyExProbAdjust[k]+=earlyExProbability[m];
				}
			}
		}

		Size j=0;
		Real front_ratio=0.0;
		Real back_ratio=0.0;

		//irEarlyExProbAdjust[0] -> 첫날꺼는 사용 안함
		irEarlyExProbAdjust[0] = eqEarlyExProbAdjust[0];

		if(irDates[0] > equityExDates[0]){j=j+1;}

		for(Size i=1;i<irLegNum;++i){
			if(irDates[i] <= equityExDates[j]){

				irEarlyExProbAdjust[i] = eqEarlyExProbAdjust[j];
				
//				irexpectedflows[i]=irleg_[i]->amount()*discountCurve->discount(equityExDates[i]);
			}else{
				
				Size total_accuralDays = calendar.businessDaysBetween(irDates[i-1],irDates[i]);
				Size front_accuralDays = calendar.businessDaysBetween(irDates[i-1],equityExDates[j]);
				Size back_accuralDays = calendar.businessDaysBetween(equityExDates[j],irDates[i]);
				
				if(j<fixingDatesNum-1){
					front_ratio = (static_cast<Real>(front_accuralDays)/static_cast<Real>(total_accuralDays))*eqEarlyExProbAdjust[j];
					back_ratio = static_cast<Real>(back_accuralDays)/static_cast<Real>(total_accuralDays)*eqEarlyExProbAdjust[j+1];
					while( equityExDates[j] < irDates[i] && j<fixingDatesNum-1){
						j=j+1;  //조기상환 Tenor가 매우 짧아 이자율 Tenor 사이에 여러개가 들어가는 경우 다시 생각해야함.( 지금은 1개만 있는 경우로 근사됨 )
					}
				}else if(j==fixingDatesNum-1){
					front_ratio = (static_cast<Real>(front_accuralDays)/static_cast<Real>(total_accuralDays))*eqEarlyExProbAdjust[j];
					back_ratio = (static_cast<Real>(back_accuralDays)/static_cast<Real>(total_accuralDays))*eqEarlyExProbAdjust[j];
				}else{
					QL_REQUIRE(false, "check schedule... something wrong");
				}

				irEarlyExProbAdjust[i] = front_ratio+back_ratio;
				
			}
			
		}

		//equity part는 지난거까지 다 뿌리고, ir part는 남은거만 뿌림.
		if(!fundedFlag_){
			for(Size i=0;i<irleg_.size()-pastirDatesNum;i++){ // irleg_.size()에서 과거 지난거 까지 같이 나옴
				expectedIRCashFlow_.push_back(irleg_[pastirDatesNum+i]->amount()*irEarlyExProbAdjust[pastirDatesNum+i+1]);
				legs_[1].push_back(boost::shared_ptr<CashFlow>(new SimpleCashFlow(expectedIRCashFlow_[i], irDates[pastirDatesNum+i+1])));
			}
			for(Size i=0;i<expectedRedem.size();i++){
				legs_[0].push_back(boost::shared_ptr<CashFlow>(new SimpleCashFlow((expectedRedem[i]-1)*notional, equityExDates[i])));
			}

		}else{
		
			for(Size i=0;i<irleg_.size()-pastirDatesNum;i++){ // irleg_.size()에서 과거 지난거 까지 같이 나옴
				expectedIRCashFlow_.push_back(irleg_[pastirDatesNum+i]->amount()*irEarlyExProbAdjust[pastirDatesNum+i+1]);
				legs_[1].push_back(boost::shared_ptr<CashFlow>(new SimpleCashFlow(expectedIRCashFlow_[i], irDates[pastirDatesNum+i+1])));

			}
			for(Size i=0;i<expectedRedem.size();i++){
				legs_[0].push_back(boost::shared_ptr<CashFlow>(new SimpleCashFlow(expectedRedem[i]*notional, equityExDates[i])));
				legs_[1].push_back(boost::shared_ptr<CashFlow>(new SimpleCashFlow(notional*earlyExProbability[i], equityExDates[i])));
			
			}
		
		}

		/*for(Size i=0;i<legs_[0].size();++i){
			std::cout << "legs_[0][ "<< i << "] : " << legs_[0][i]->amount() << std::endl;
		}

		std::cout << std::endl;

		for(Size i=0;i<legs_[1].size();++i){
			std::cout << "legs_[1][ "<< i << "] : " << legs_[1][i]->amount() << std::endl;
		}*/
		// 다음 기 이자는 100% 들어오므로 그냥 ㄱㄱ함. Sum{Pi} = 1
		if(today <= irDates.back()){
			accrualNPV_=irleg_[pastirDatesNum]->amount()*
                floatingDayCount_.yearFraction(irDates[pastirDatesNum],today)/floatingDayCount_.yearFraction(irDates[pastirDatesNum],irDates[pastirDatesNum+1]);
		}else{
			accrualNPV_=0.0; // 만기 지난거
		}



        for (Leg::const_iterator i = legs_[1].begin(); i < legs_[1].end(); ++i)
            registerWith(*i);

		for (Leg::const_iterator i = legs_[0].begin(); i < legs_[0].end(); ++i)
            registerWith(*i);

		registerWith(irdls);
		registerWith(Index);

		 switch (type_) {
          case Payer:
            payer_[0] = -1.0;
            payer_[1] = +1.0;
            break;
          case Receiver:
			accrualNPV_= accrualNPV_ * (-1.0);
            payer_[0] = +1.0;
            payer_[1] = -1.0;
            break;
          default:
            QL_FAIL("Unknown EquitySwap type");
	
	}
		
		 setPricingEngine(boost::shared_ptr<PricingEngine>(new DiscountingSwapEngine(discountCurve)));
	

		 // 각각 expected Vaule 게산해서 넣어야함 2012 - 06- 11
}
void EquitySwap::setupArguments(PricingEngine::arguments* args) const {

        Swap::setupArguments(args);

        EquitySwap::arguments* arguments =
            dynamic_cast<EquitySwap::arguments*>(args);

        if (!arguments)  // it's a swap engine...
            return;

        arguments->type = type_;
        arguments->nominal = nominal_;

        const Leg& fixedCoupons = fixedLeg();

        arguments->fixedResetDates = arguments->fixedPayDates =
            std::vector<Date>(fixedCoupons.size());
        arguments->fixedCoupons = std::vector<Real>(fixedCoupons.size());

        for (Size i=0; i<fixedCoupons.size(); ++i) {

            arguments->fixedPayDates[i] = fixedCoupons[i]->date();
            
            arguments->fixedCoupons[i] = fixedCoupons[i]->amount();
        }

        const Leg& floatingCoupons = irleg_;

        arguments->floatingResetDates = arguments->floatingPayDates =
            arguments->floatingFixingDates =
            std::vector<Date>(floatingCoupons.size());
        arguments->floatingAccrualTimes =
            std::vector<Time>(floatingCoupons.size());
        arguments->floatingSpreads =
            std::vector<Spread>(floatingCoupons.size());
        arguments->floatingCoupons = std::vector<Real>(floatingCoupons.size());
        for (Size i=0; i<floatingCoupons.size(); ++i) {
            boost::shared_ptr<IborCoupon> coupon =
                boost::dynamic_pointer_cast<IborCoupon>(floatingCoupons[i]);

            arguments->floatingResetDates[i] = coupon->accrualStartDate();
            arguments->floatingPayDates[i] = coupon->date();

            arguments->floatingFixingDates[i] = coupon->fixingDate();
            arguments->floatingAccrualTimes[i] = coupon->accrualPeriod();
            arguments->floatingSpreads[i] = coupon->spread();
            try {
                arguments->floatingCoupons[i] = expectedIRCashFlow_[i];
            } catch (Error&) {
                arguments->floatingCoupons[i] = Null<Real>();
            }
        }
    }


Real EquitySwap::accrualNPV() const {
	calculate();	
	return accrualNPV_;
}
//void EquitySwap::fetchResults(const PricingEngine::results* r) const {
//
//        VanillaSwap::fetchResults(r);
//
//        const EquityLinkedSecurity::results* results =
//            dynamic_cast<const EquityLinkedSecurity::results*>(r);
//        QL_ENSURE(results != 0, "wrong result type");
//
//		//settlementValue_ = results->settlementValue;
//		
//}

}