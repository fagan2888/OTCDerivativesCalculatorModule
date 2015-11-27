// SimpleCreditDefaultSwap.hpp 
#ifndef FpmlSerialized_SimpleCreditDefaultSwap_hpp
#define FpmlSerialized_SimpleCreditDefaultSwap_hpp

#include <fpml-asset-5-4/UnderlyingAsset.hpp>
#include <fpml-shared-5-4/LegalEntity.hpp>
#include <fpml-shared-5-4/LegalEntityReference.hpp>
#include <fpml-shared-5-4/Period.hpp>

namespace FpmlSerialized {

class SimpleCreditDefaultSwap : public UnderlyingAsset { 
   public: 
       SimpleCreditDefaultSwap(TiXmlNode* xmlNode);

       bool isReferenceEntity(){return this->referenceEntityIsNull_;}
       boost::shared_ptr<LegalEntity> getReferenceEntity();
      std::string getReferenceEntityIDRef(){return referenceEntityIDRef_;}

       bool isCreditEntityReference(){return this->creditEntityReferenceIsNull_;}
       boost::shared_ptr<LegalEntityReference> getCreditEntityReference();
      std::string getCreditEntityReferenceIDRef(){return creditEntityReferenceIDRef_;}

       bool isTerm(){return this->termIsNull_;}
       boost::shared_ptr<Period> getTerm();
      std::string getTermIDRef(){return termIDRef_;}

       bool isPaymentFrequency(){return this->paymentFrequencyIsNull_;}
       boost::shared_ptr<Period> getPaymentFrequency();
      std::string getPaymentFrequencyIDRef(){return paymentFrequencyIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!referenceEntityIsNull_){
                count += 1;
                str = "referenceEntity" ;
           }
           if(!creditEntityReferenceIsNull_){
                count += 1;
                str = "creditEntityReference" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<LegalEntity> referenceEntity_;     //choice
       std::string referenceEntityIDRef_;
       bool referenceEntityIsNull_;
         boost::shared_ptr<LegalEntityReference> creditEntityReference_;     //choice
       std::string creditEntityReferenceIDRef_;
       bool creditEntityReferenceIsNull_;
       boost::shared_ptr<Period> term_;
       std::string termIDRef_;
       bool termIsNull_;
       boost::shared_ptr<Period> paymentFrequency_;
       std::string paymentFrequencyIDRef_;
       bool paymentFrequencyIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

