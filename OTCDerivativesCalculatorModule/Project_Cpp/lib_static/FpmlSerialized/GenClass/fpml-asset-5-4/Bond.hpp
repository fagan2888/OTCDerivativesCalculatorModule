// Bond.hpp 
#ifndef FpmlSerialized_Bond_hpp
#define FpmlSerialized_Bond_hpp

#include <fpml-asset-5-4/UnderlyingAsset.hpp>
#include <built_in_type/XsdTypeString.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/CreditSeniority.hpp>
#include <fpml-asset-5-4/CouponType.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <fpml-shared-5-4/Period.hpp>
#include <fpml-shared-5-4/DayCountFraction.hpp>

namespace FpmlSerialized {

class Bond : public UnderlyingAsset { 
   public: 
       Bond(TiXmlNode* xmlNode);

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

       bool isParValue(){return this->parValueIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getParValue();
      std::string getParValueIDRef(){return parValueIDRef_;}

       bool isFaceAmount(){return this->faceAmountIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getFaceAmount();
      std::string getFaceAmountIDRef(){return faceAmountIDRef_;}

       bool isPaymentFrequency(){return this->paymentFrequencyIsNull_;}
       boost::shared_ptr<Period> getPaymentFrequency();
      std::string getPaymentFrequencyIDRef(){return paymentFrequencyIDRef_;}

       bool isDayCountFraction(){return this->dayCountFractionIsNull_;}
       boost::shared_ptr<DayCountFraction> getDayCountFraction();
      std::string getDayCountFractionIDRef(){return dayCountFractionIDRef_;}

       std::string getChoiceStr_0(){
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
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
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
       boost::shared_ptr<XsdTypeDecimal> parValue_;
       std::string parValueIDRef_;
       bool parValueIsNull_;
       boost::shared_ptr<XsdTypeDecimal> faceAmount_;
       std::string faceAmountIDRef_;
       bool faceAmountIsNull_;
       boost::shared_ptr<Period> paymentFrequency_;
       std::string paymentFrequencyIDRef_;
       bool paymentFrequencyIsNull_;
       boost::shared_ptr<DayCountFraction> dayCountFraction_;
       std::string dayCountFractionIDRef_;
       bool dayCountFractionIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

