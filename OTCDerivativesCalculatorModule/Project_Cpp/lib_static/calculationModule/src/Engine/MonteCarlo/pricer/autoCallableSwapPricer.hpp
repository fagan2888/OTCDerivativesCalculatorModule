#ifndef quantlib_mc_autoCallableSwapPricer_hpp
#define quantlib_mc_autoCallableSwapPricer_hpp

#include <boost/shared_ptr.hpp>

#include <src/Engine/MonteCarlo/MCPricer.hpp>
#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>
#include <ql/termstructures/all.hpp>

namespace QuantLib {

    class AutoCallableSwapPricer : public MCPricer {
      public:
        //AutoCallableSwapPricer(const boost::shared_ptr<MCPricer>& payPart,
							 //  const boost::shared_ptr<MCPricer>& recievePart,
							 //  bool accruedPay);

		AutoCallableSwapPricer( const boost::shared_ptr<QuantLib::MCPricer>& rec_pricer,
								const boost::shared_ptr<QuantLib::MCPricer>& pay_pricer,
								Real notional,
								std::string currency);

		//AutoCallableSwapPricer(const std::vector<boost::shared_ptr<EventTriggerInfo>>& rec_etiList,
		//						Real rec_notional,
		//						std::string rec_currency,
		//						//const boost::shared_ptr<FixingDateInfo>& rec_payoffDateInfo,
		//						const std::vector<boost::shared_ptr<EventTriggerInfo>>& pay_etiList,
		//						Real pay_notional,
		//						std::string pay_currency,
		//						const boost::shared_ptr<FixingDateInfo>& payoffDateInfo //notional paymentDate¿”.
		//						);
							   //bool accruedPay);

		//interface
		void initializeImpl(const TimeGrid& timeGrid,
						const boost::shared_ptr<YieldTermStructure>& discountCurve,
						const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

		Real calculate(const MultiPath& path,Size endPosition = 0) const;
		Real callableCalculate(const MultiPath& multiPath,Size earlyExOccEventTriggerNum) const;

		std::vector<boost::shared_ptr<EventTriggerInfo>> getEtiList() const;
		Real getNotional() const;
		std::string getCurrency() const;

		Real getNotionalSide(Size i) const;
		Real getDiscountSide(Size i) const;
		Real getDiscountAtSide(Size i,Size position) const;

		std::vector<Date> fixingDates() const;
		std::vector<Date> payoffDates() const;

	protected:
		Size nextOppositePos(Size i) const;
		void resetImpl() const;

      private:
		  Date convReceiveEventDate(Size i);
		  Date convPayEventDate(Size i);


		  bool accruedPay_;
		  Size remainEventPosition_;

		  //boost::shared_ptr<PayoffCalculation> occBarrierPayoffCalculation_;
          //Array discount_;

		  std::vector<Date> fixingDates_;
		  std::vector<Date> payoffDates_;

		  std::vector<boost::shared_ptr<EventTriggerInfo>> rec_etiList_;
		  Real rec_notional_;
		  std::string rec_currency_;
		  //boost::shared_ptr<FixingDateInfo> rec_payoffDateInfo_;

		  std::vector<boost::shared_ptr<EventTriggerInfo>> pay_etiList_;
		  Real pay_notional_;
		  std::string pay_currency_;

		  //notional paymentDate¿”.
		  boost::shared_ptr<FixingDateInfo> rec_payoffDateInfo_;
		  boost::shared_ptr<FixingDateInfo> pay_payoffDateInfo_;

		private:
		  Size startPos_;
		  Size rec_startPos_;
		  Size pay_startPos_;

		  Size rec_etiNum_;
		  Size pay_etiNum_;
		  

		  Size total_eventTriggerNum_;
		  //std::vector<boost::shared_ptr<EventTriggerInfo>> total_etiList_;
		  
		  std::vector<Size> legPostionMap_;
		  std::vector<bool> legPostionSide_; // true : rec , false : pay

		  std::vector<Size> legTotalReceivePostionMap_;
		  std::vector<Size> legTotalPayPostionMap_; // total posNum which located payPos Num

	};
}

#endif