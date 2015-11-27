// Fra.hpp 
#ifndef FpmlSerialized_Fra_hpp
#define FpmlSerialized_Fra_hpp

#include <fpml-shared-5-4/Product.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>
#include <fpml-shared-5-4/RequiredIdentifierDate.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <fpml-shared-5-4/AdjustableDate.hpp>
#include <fpml-shared-5-4/RelativeDateOffset.hpp>
#include <fpml-shared-5-4/DayCountFraction.hpp>
#include <built_in_type/XsdTypePositiveInteger.hpp>
#include <fpml-shared-5-4/Money.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-shared-5-4/FloatingRateIndex.hpp>
#include <fpml-shared-5-4/Period.hpp>
#include <fpml-enum-5-4/FraDiscountingEnum.hpp>

namespace FpmlSerialized {

class Fra : public Product { 
   public: 
       Fra(TiXmlNode* xmlNode);

       bool isBuyerPartyReference(){return this->buyerPartyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getBuyerPartyReference();
      std::string getBuyerPartyReferenceIDRef(){return buyerPartyReferenceIDRef_;}

       bool isBuyerAccountReference(){return this->buyerAccountReferenceIsNull_;}
       boost::shared_ptr<AccountReference> getBuyerAccountReference();
      std::string getBuyerAccountReferenceIDRef(){return buyerAccountReferenceIDRef_;}

       bool isSellerPartyReference(){return this->sellerPartyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getSellerPartyReference();
      std::string getSellerPartyReferenceIDRef(){return sellerPartyReferenceIDRef_;}

       bool isSellerAccountReference(){return this->sellerAccountReferenceIsNull_;}
       boost::shared_ptr<AccountReference> getSellerAccountReference();
      std::string getSellerAccountReferenceIDRef(){return sellerAccountReferenceIDRef_;}

       bool isAdjustedEffectiveDate(){return this->adjustedEffectiveDateIsNull_;}
       boost::shared_ptr<RequiredIdentifierDate> getAdjustedEffectiveDate();
      std::string getAdjustedEffectiveDateIDRef(){return adjustedEffectiveDateIDRef_;}

       bool isAdjustedTerminationDate(){return this->adjustedTerminationDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getAdjustedTerminationDate();
      std::string getAdjustedTerminationDateIDRef(){return adjustedTerminationDateIDRef_;}

       bool isPaymentDate(){return this->paymentDateIsNull_;}
       boost::shared_ptr<AdjustableDate> getPaymentDate();
      std::string getPaymentDateIDRef(){return paymentDateIDRef_;}

       bool isFixingDateOffset(){return this->fixingDateOffsetIsNull_;}
       boost::shared_ptr<RelativeDateOffset> getFixingDateOffset();
      std::string getFixingDateOffsetIDRef(){return fixingDateOffsetIDRef_;}

       bool isDayCountFraction(){return this->dayCountFractionIsNull_;}
       boost::shared_ptr<DayCountFraction> getDayCountFraction();
      std::string getDayCountFractionIDRef(){return dayCountFractionIDRef_;}

       bool isCalculationPeriodNumberOfDays(){return this->calculationPeriodNumberOfDaysIsNull_;}
       boost::shared_ptr<XsdTypePositiveInteger> getCalculationPeriodNumberOfDays();
      std::string getCalculationPeriodNumberOfDaysIDRef(){return calculationPeriodNumberOfDaysIDRef_;}

       bool isNotional(){return this->notionalIsNull_;}
       boost::shared_ptr<Money> getNotional();
      std::string getNotionalIDRef(){return notionalIDRef_;}

       bool isFixedRate(){return this->fixedRateIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getFixedRate();
      std::string getFixedRateIDRef(){return fixedRateIDRef_;}

       bool isFloatingRateIndex(){return this->floatingRateIndexIsNull_;}
       boost::shared_ptr<FloatingRateIndex> getFloatingRateIndex();
      std::string getFloatingRateIndexIDRef(){return floatingRateIndexIDRef_;}

       bool isIndexTenor(){return this->indexTenorIsNull_;}
       std::vector<boost::shared_ptr<Period>> getIndexTenor();
      std::string getIndexTenorIDRef(){return indexTenorIDRef_;}

       bool isFraDiscounting(){return this->fraDiscountingIsNull_;}
       boost::shared_ptr<FraDiscountingEnum> getFraDiscounting();
      std::string getFraDiscountingIDRef(){return fraDiscountingIDRef_;}

   protected: 
       boost::shared_ptr<PartyReference> buyerPartyReference_;
       std::string buyerPartyReferenceIDRef_;
       bool buyerPartyReferenceIsNull_;
       boost::shared_ptr<AccountReference> buyerAccountReference_;
       std::string buyerAccountReferenceIDRef_;
       bool buyerAccountReferenceIsNull_;
       boost::shared_ptr<PartyReference> sellerPartyReference_;
       std::string sellerPartyReferenceIDRef_;
       bool sellerPartyReferenceIsNull_;
       boost::shared_ptr<AccountReference> sellerAccountReference_;
       std::string sellerAccountReferenceIDRef_;
       bool sellerAccountReferenceIsNull_;
       boost::shared_ptr<RequiredIdentifierDate> adjustedEffectiveDate_;
       std::string adjustedEffectiveDateIDRef_;
       bool adjustedEffectiveDateIsNull_;
       boost::shared_ptr<XsdTypeDate> adjustedTerminationDate_;
       std::string adjustedTerminationDateIDRef_;
       bool adjustedTerminationDateIsNull_;
       boost::shared_ptr<AdjustableDate> paymentDate_;
       std::string paymentDateIDRef_;
       bool paymentDateIsNull_;
       boost::shared_ptr<RelativeDateOffset> fixingDateOffset_;
       std::string fixingDateOffsetIDRef_;
       bool fixingDateOffsetIsNull_;
       boost::shared_ptr<DayCountFraction> dayCountFraction_;
       std::string dayCountFractionIDRef_;
       bool dayCountFractionIsNull_;
       boost::shared_ptr<XsdTypePositiveInteger> calculationPeriodNumberOfDays_;
       std::string calculationPeriodNumberOfDaysIDRef_;
       bool calculationPeriodNumberOfDaysIsNull_;
       boost::shared_ptr<Money> notional_;
       std::string notionalIDRef_;
       bool notionalIsNull_;
       boost::shared_ptr<XsdTypeDecimal> fixedRate_;
       std::string fixedRateIDRef_;
       bool fixedRateIsNull_;
       boost::shared_ptr<FloatingRateIndex> floatingRateIndex_;
       std::string floatingRateIndexIDRef_;
       bool floatingRateIndexIsNull_;
       std::vector<boost::shared_ptr<Period>> indexTenor_;
       std::string indexTenorIDRef_;
       bool indexTenorIsNull_;
       boost::shared_ptr<FraDiscountingEnum> fraDiscounting_;
       std::string fraDiscountingIDRef_;
       bool fraDiscountingIsNull_;

};

} //namespaceFpmlSerialized end
#endif

