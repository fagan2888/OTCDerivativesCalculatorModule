// Mortgage.hpp 
#ifndef FpmlSerialized_Mortgage_hpp
#define FpmlSerialized_Mortgage_hpp

#include <fpml-asset-5-4/UnderlyingAsset.hpp>
#include <fpml-shared-5-4/LegalEntity.hpp>
#include <fpml-shared-5-4/LegalEntityReference.hpp>
#include <built_in_type/XsdTypeString.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/CreditSeniority.hpp>
#include <fpml-asset-5-4/CouponType.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <fpml-shared-5-4/Period.hpp>
#include <fpml-shared-5-4/DayCountFraction.hpp>
#include <fpml-asset-5-4/AssetPool.hpp>
#include <fpml-asset-5-4/MortgageSector.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class Mortgage : public UnderlyingAsset { 
   public: 
       Mortgage(TiXmlNode* xmlNode);

       bool isInsurer(){return this->insurerIsNull_;}
       boost::shared_ptr<LegalEntity> getInsurer();
      std::string getInsurerIDRef(){return insurerIDRef_;}

       bool isInsurerReference(){return this->insurerReferenceIsNull_;}
       boost::shared_ptr<LegalEntityReference> getInsurerReference();
      std::string getInsurerReferenceIDRef(){return insurerReferenceIDRef_;}

       bool isIssuerName(){return this->issuerNameIsNull_;}
       boost::shared_ptr<XsdTypeString> getIssuerName();
      std::string getIssuerNameIDRef(){return issuerNameIDRef_;}

       bool isIssuerPartyReference(){return this->issuerPartyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getIssuerPartyReference();
      std::string getIssuerPartyReferenceIDRef(){return issuerPartyReferenceIDRef_;}

       bool isSeniority(){return this->seniorityIsNull_;}
       boost::shared_ptr<CreditSeniority> getSeniority();
      std::string getSeniorityIDRef(){return seniorityIDRef_;}

       bool isCouponType(){return this->couponTypeIsNull_;}
       boost::shared_ptr<CouponType> getCouponType();
      std::string getCouponTypeIDRef(){return couponTypeIDRef_;}

       bool isCouponRate(){return this->couponRateIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getCouponRate();
      std::string getCouponRateIDRef(){return couponRateIDRef_;}

       bool isMaturity(){return this->maturityIsNull_;}
       boost::shared_ptr<XsdTypeDate> getMaturity();
      std::string getMaturityIDRef(){return maturityIDRef_;}

       bool isPaymentFrequency(){return this->paymentFrequencyIsNull_;}
       boost::shared_ptr<Period> getPaymentFrequency();
      std::string getPaymentFrequencyIDRef(){return paymentFrequencyIDRef_;}

       bool isDayCountFraction(){return this->dayCountFractionIsNull_;}
       boost::shared_ptr<DayCountFraction> getDayCountFraction();
      std::string getDayCountFractionIDRef(){return dayCountFractionIDRef_;}

       bool isOriginalPrincipalAmount(){return this->originalPrincipalAmountIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getOriginalPrincipalAmount();
      std::string getOriginalPrincipalAmountIDRef(){return originalPrincipalAmountIDRef_;}

       bool isPool(){return this->poolIsNull_;}
       boost::shared_ptr<AssetPool> getPool();
      std::string getPoolIDRef(){return poolIDRef_;}

       bool isSector(){return this->sectorIsNull_;}
       boost::shared_ptr<MortgageSector> getSector();
      std::string getSectorIDRef(){return sectorIDRef_;}

       bool isTranche(){return this->trancheIsNull_;}
       boost::shared_ptr<XsdTypeToken> getTranche();
      std::string getTrancheIDRef(){return trancheIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!insurerIsNull_){
                count += 1;
                str = "insurer" ;
           }
           if(!insurerReferenceIsNull_){
                count += 1;
                str = "insurerReference" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
       std::string getChoiceStr_1(){
           std::string str;
           int count = 0;
           if(!issuerNameIsNull_){
                count += 1;
                str = "issuerName" ;
           }
           if(!issuerPartyReferenceIsNull_){
                count += 1;
                str = "issuerPartyReference" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_1_ = str ;
           return choiceStr_1_;
       }
   protected: 
         boost::shared_ptr<LegalEntity> insurer_;     //choice
       std::string insurerIDRef_;
       bool insurerIsNull_;
         boost::shared_ptr<LegalEntityReference> insurerReference_;     //choice
       std::string insurerReferenceIDRef_;
       bool insurerReferenceIsNull_;
         boost::shared_ptr<XsdTypeString> issuerName_;     //choice
       std::string issuerNameIDRef_;
       bool issuerNameIsNull_;
         boost::shared_ptr<PartyReference> issuerPartyReference_;     //choice
       std::string issuerPartyReferenceIDRef_;
       bool issuerPartyReferenceIsNull_;
       boost::shared_ptr<CreditSeniority> seniority_;
       std::string seniorityIDRef_;
       bool seniorityIsNull_;
       boost::shared_ptr<CouponType> couponType_;
       std::string couponTypeIDRef_;
       bool couponTypeIsNull_;
       boost::shared_ptr<XsdTypeDecimal> couponRate_;
       std::string couponRateIDRef_;
       bool couponRateIsNull_;
       boost::shared_ptr<XsdTypeDate> maturity_;
       std::string maturityIDRef_;
       bool maturityIsNull_;
       boost::shared_ptr<Period> paymentFrequency_;
       std::string paymentFrequencyIDRef_;
       bool paymentFrequencyIsNull_;
       boost::shared_ptr<DayCountFraction> dayCountFraction_;
       std::string dayCountFractionIDRef_;
       bool dayCountFractionIsNull_;
       boost::shared_ptr<XsdTypeDecimal> originalPrincipalAmount_;
       std::string originalPrincipalAmountIDRef_;
       bool originalPrincipalAmountIsNull_;
       boost::shared_ptr<AssetPool> pool_;
       std::string poolIDRef_;
       bool poolIsNull_;
       boost::shared_ptr<MortgageSector> sector_;
       std::string sectorIDRef_;
       bool sectorIsNull_;
       boost::shared_ptr<XsdTypeToken> tranche_;
       std::string trancheIDRef_;
       bool trancheIsNull_;

       //choiceStr 
       std::string choiceStr_0_;
       std::string choiceStr_1_;

};

} //namespaceFpmlSerialized end
#endif

