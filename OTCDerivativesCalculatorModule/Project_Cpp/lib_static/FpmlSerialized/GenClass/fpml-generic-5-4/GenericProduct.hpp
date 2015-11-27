// GenericProduct.hpp 
#ifndef FpmlSerialized_GenericProduct_hpp
#define FpmlSerialized_GenericProduct_hpp

#include <fpml-shared-5-4/Product.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>
#include <fpml-shared-5-4/SimplePayment.hpp>
#include <fpml-shared-5-4/AdjustableDate2.hpp>
#include <fpml-generic-5-4/TradeUnderlyer2.hpp>
#include <fpml-shared-5-4/CashflowNotional.hpp>
#include <fpml-generic-5-4/OptionType.hpp>
#include <fpml-shared-5-4/IdentifiedCurrency.hpp>
#include <fpml-shared-5-4/DayCountFraction.hpp>

namespace FpmlSerialized {

class GenericProduct : public Product { 
   public: 
       GenericProduct(TiXmlNode* xmlNode);

       bool isMultiLeg(){return this->multiLegIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getMultiLeg();
      std::string getMultiLegIDRef(){return multiLegIDRef_;}

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

       bool isCounterpartyReference(){return this->counterpartyReferenceIsNull_;}
       std::vector<boost::shared_ptr<PartyReference>> getCounterpartyReference();
      std::string getCounterpartyReferenceIDRef(){return counterpartyReferenceIDRef_;}

       bool isPremium(){return this->premiumIsNull_;}
       boost::shared_ptr<SimplePayment> getPremium();
      std::string getPremiumIDRef(){return premiumIDRef_;}

       bool isEffectiveDate(){return this->effectiveDateIsNull_;}
       boost::shared_ptr<AdjustableDate2> getEffectiveDate();
      std::string getEffectiveDateIDRef(){return effectiveDateIDRef_;}

       bool isExpirationDate(){return this->expirationDateIsNull_;}
       boost::shared_ptr<AdjustableDate2> getExpirationDate();
      std::string getExpirationDateIDRef(){return expirationDateIDRef_;}

       bool isTerminationDate(){return this->terminationDateIsNull_;}
       boost::shared_ptr<AdjustableDate2> getTerminationDate();
      std::string getTerminationDateIDRef(){return terminationDateIDRef_;}

       bool isUnderlyer(){return this->underlyerIsNull_;}
       std::vector<boost::shared_ptr<TradeUnderlyer2>> getUnderlyer();
      std::string getUnderlyerIDRef(){return underlyerIDRef_;}

       bool isNotional(){return this->notionalIsNull_;}
       std::vector<boost::shared_ptr<CashflowNotional>> getNotional();
      std::string getNotionalIDRef(){return notionalIDRef_;}

       bool isOptionType(){return this->optionTypeIsNull_;}
       boost::shared_ptr<OptionType> getOptionType();
      std::string getOptionTypeIDRef(){return optionTypeIDRef_;}

       bool isSettlementCurrency(){return this->settlementCurrencyIsNull_;}
       std::vector<boost::shared_ptr<IdentifiedCurrency>> getSettlementCurrency();
      std::string getSettlementCurrencyIDRef(){return settlementCurrencyIDRef_;}

       bool isDayCountFraction(){return this->dayCountFractionIsNull_;}
       std::vector<boost::shared_ptr<DayCountFraction>> getDayCountFraction();
      std::string getDayCountFractionIDRef(){return dayCountFractionIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!buyerPartyReferenceIsNull_){
                count += 1;
                str = "buyerPartyReference" ;
           }
           if(!buyerAccountReferenceIsNull_){
                count += 1;
                str = "buyerAccountReference" ;
           }
           if(!sellerPartyReferenceIsNull_){
                count += 1;
                str = "sellerPartyReference" ;
           }
           if(!sellerAccountReferenceIsNull_){
                count += 1;
                str = "sellerAccountReference" ;
           }
           if(!counterpartyReferenceIsNull_){
                count += 1;
                str = "counterpartyReference" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<XsdTypeBoolean> multiLeg_;
       std::string multiLegIDRef_;
       bool multiLegIsNull_;
         boost::shared_ptr<PartyReference> buyerPartyReference_;     //choice
       std::string buyerPartyReferenceIDRef_;
       bool buyerPartyReferenceIsNull_;
         boost::shared_ptr<AccountReference> buyerAccountReference_;     //choice
       std::string buyerAccountReferenceIDRef_;
       bool buyerAccountReferenceIsNull_;
         boost::shared_ptr<PartyReference> sellerPartyReference_;     //choice
       std::string sellerPartyReferenceIDRef_;
       bool sellerPartyReferenceIsNull_;
         boost::shared_ptr<AccountReference> sellerAccountReference_;     //choice
       std::string sellerAccountReferenceIDRef_;
       bool sellerAccountReferenceIsNull_;
         std::vector<boost::shared_ptr<PartyReference>> counterpartyReference_;     //choice
       std::string counterpartyReferenceIDRef_;
       bool counterpartyReferenceIsNull_;
       boost::shared_ptr<SimplePayment> premium_;
       std::string premiumIDRef_;
       bool premiumIsNull_;
       boost::shared_ptr<AdjustableDate2> effectiveDate_;
       std::string effectiveDateIDRef_;
       bool effectiveDateIsNull_;
       boost::shared_ptr<AdjustableDate2> expirationDate_;
       std::string expirationDateIDRef_;
       bool expirationDateIsNull_;
       boost::shared_ptr<AdjustableDate2> terminationDate_;
       std::string terminationDateIDRef_;
       bool terminationDateIsNull_;
       std::vector<boost::shared_ptr<TradeUnderlyer2>> underlyer_;
       std::string underlyerIDRef_;
       bool underlyerIsNull_;
       std::vector<boost::shared_ptr<CashflowNotional>> notional_;
       std::string notionalIDRef_;
       bool notionalIsNull_;
       boost::shared_ptr<OptionType> optionType_;
       std::string optionTypeIDRef_;
       bool optionTypeIsNull_;
       std::vector<boost::shared_ptr<IdentifiedCurrency>> settlementCurrency_;
       std::string settlementCurrencyIDRef_;
       bool settlementCurrencyIsNull_;
       std::vector<boost::shared_ptr<DayCountFraction>> dayCountFraction_;
       std::string dayCountFractionIDRef_;
       bool dayCountFractionIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

