// PartyRelationshipDocumentation.hpp 
#ifndef FpmlSerialized_PartyRelationshipDocumentation_hpp
#define FpmlSerialized_PartyRelationshipDocumentation_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/MasterAgreement.hpp>
#include <fpml-shared-5-4/CreditSupportAgreement.hpp>
#include <fpml-shared-5-4/GenericAgreement.hpp>

namespace FpmlSerialized {

class PartyRelationshipDocumentation : public ISerialized { 
   public: 
       PartyRelationshipDocumentation(TiXmlNode* xmlNode);

       bool isMasterAgreement(){return this->masterAgreementIsNull_;}
       boost::shared_ptr<MasterAgreement> getMasterAgreement();
      std::string getMasterAgreementIDRef(){return masterAgreementIDRef_;}

       bool isCreditSupportAgreement(){return this->creditSupportAgreementIsNull_;}
       boost::shared_ptr<CreditSupportAgreement> getCreditSupportAgreement();
      std::string getCreditSupportAgreementIDRef(){return creditSupportAgreementIDRef_;}

       bool isAgreement(){return this->agreementIsNull_;}
       boost::shared_ptr<GenericAgreement> getAgreement();
      std::string getAgreementIDRef(){return agreementIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!masterAgreementIsNull_){
                count += 1;
                str = "masterAgreement" ;
           }
           if(!creditSupportAgreementIsNull_){
                count += 1;
                str = "creditSupportAgreement" ;
           }
           if(!agreementIsNull_){
                count += 1;
                str = "agreement" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<MasterAgreement> masterAgreement_;     //choice
       std::string masterAgreementIDRef_;
       bool masterAgreementIsNull_;
         boost::shared_ptr<CreditSupportAgreement> creditSupportAgreement_;     //choice
       std::string creditSupportAgreementIDRef_;
       bool creditSupportAgreementIsNull_;
         boost::shared_ptr<GenericAgreement> agreement_;     //choice
       std::string agreementIDRef_;
       bool agreementIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

