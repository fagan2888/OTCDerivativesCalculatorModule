// CreditCurve.hpp 
#ifndef FpmlSerialized_CreditCurve_hpp
#define FpmlSerialized_CreditCurve_hpp

#include <fpml-shared-5-4/PricingStructure.hpp>
#include <fpml-shared-5-4/LegalEntity.hpp>
#include <fpml-shared-5-4/LegalEntityReference.hpp>
#include <fpml-option-shared-5-4/CreditEvents.hpp>
#include <fpml-shared-5-4/CreditSeniority.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-shared-5-4/Currency.hpp>
#include <fpml-cd-5-4/Obligations.hpp>
#include <fpml-cd-5-4/DeliverableObligations.hpp>

namespace FpmlSerialized {

class CreditCurve : public PricingStructure { 
   public: 
       CreditCurve(TiXmlNode* xmlNode);

       bool isReferenceEntity(){return this->referenceEntityIsNull_;}
       boost::shared_ptr<LegalEntity> getReferenceEntity();
      std::string getReferenceEntityIDRef(){return referenceEntityIDRef_;}

       bool isCreditEntityReference(){return this->creditEntityReferenceIsNull_;}
       boost::shared_ptr<LegalEntityReference> getCreditEntityReference();
      std::string getCreditEntityReferenceIDRef(){return creditEntityReferenceIDRef_;}

       bool isCreditEvents(){return this->creditEventsIsNull_;}
       boost::shared_ptr<CreditEvents> getCreditEvents();
      std::string getCreditEventsIDRef(){return creditEventsIDRef_;}

       bool isSeniority(){return this->seniorityIsNull_;}
       boost::shared_ptr<CreditSeniority> getSeniority();
      std::string getSeniorityIDRef(){return seniorityIDRef_;}

       bool isSecured(){return this->securedIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getSecured();
      std::string getSecuredIDRef(){return securedIDRef_;}

       bool isObligationCurrency(){return this->obligationCurrencyIsNull_;}
       boost::shared_ptr<Currency> getObligationCurrency();
      std::string getObligationCurrencyIDRef(){return obligationCurrencyIDRef_;}

       bool isObligations(){return this->obligationsIsNull_;}
       boost::shared_ptr<Obligations> getObligations();
      std::string getObligationsIDRef(){return obligationsIDRef_;}

       bool isDeliverableObligations(){return this->deliverableObligationsIsNull_;}
       boost::shared_ptr<DeliverableObligations> getDeliverableObligations();
      std::string getDeliverableObligationsIDRef(){return deliverableObligationsIDRef_;}

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
       boost::shared_ptr<CreditEvents> creditEvents_;
       std::string creditEventsIDRef_;
       bool creditEventsIsNull_;
       boost::shared_ptr<CreditSeniority> seniority_;
       std::string seniorityIDRef_;
       bool seniorityIsNull_;
       boost::shared_ptr<XsdTypeBoolean> secured_;
       std::string securedIDRef_;
       bool securedIsNull_;
       boost::shared_ptr<Currency> obligationCurrency_;
       std::string obligationCurrencyIDRef_;
       bool obligationCurrencyIsNull_;
       boost::shared_ptr<Obligations> obligations_;
       std::string obligationsIDRef_;
       bool obligationsIsNull_;
       boost::shared_ptr<DeliverableObligations> deliverableObligations_;
       std::string deliverableObligationsIDRef_;
       bool deliverableObligationsIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

