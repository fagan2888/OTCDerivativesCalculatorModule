// ReferenceInformation.hpp 
#ifndef FpmlSerialized_ReferenceInformation_hpp
#define FpmlSerialized_ReferenceInformation_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/LegalEntity.hpp>
#include <fpml-cd-5-4/ReferenceObligation.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>

namespace FpmlSerialized {

class ReferenceInformation : public ISerialized { 
   public: 
       ReferenceInformation(TiXmlNode* xmlNode);

       bool isReferenceEntity(){return this->referenceEntityIsNull_;}
       boost::shared_ptr<LegalEntity> getReferenceEntity();
      std::string getReferenceEntityIDRef(){return referenceEntityIDRef_;}

       bool isReferenceObligation(){return this->referenceObligationIsNull_;}
       std::vector<boost::shared_ptr<ReferenceObligation>> getReferenceObligation();
      std::string getReferenceObligationIDRef(){return referenceObligationIDRef_;}

       bool isNoReferenceObligation(){return this->noReferenceObligationIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getNoReferenceObligation();
      std::string getNoReferenceObligationIDRef(){return noReferenceObligationIDRef_;}

       bool isUnknownReferenceObligation(){return this->unknownReferenceObligationIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getUnknownReferenceObligation();
      std::string getUnknownReferenceObligationIDRef(){return unknownReferenceObligationIDRef_;}

       bool isAllGuarantees(){return this->allGuaranteesIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getAllGuarantees();
      std::string getAllGuaranteesIDRef(){return allGuaranteesIDRef_;}

       bool isReferencePrice(){return this->referencePriceIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getReferencePrice();
      std::string getReferencePriceIDRef(){return referencePriceIDRef_;}

       bool isReferencePolicy(){return this->referencePolicyIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getReferencePolicy();
      std::string getReferencePolicyIDRef(){return referencePolicyIDRef_;}

       bool isSecuredList(){return this->securedListIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getSecuredList();
      std::string getSecuredListIDRef(){return securedListIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!referenceObligationIsNull_){
                count += 1;
                str = "referenceObligation" ;
           }
           if(!noReferenceObligationIsNull_){
                count += 1;
                str = "noReferenceObligation" ;
           }
           if(!unknownReferenceObligationIsNull_){
                count += 1;
                str = "unknownReferenceObligation" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<LegalEntity> referenceEntity_;
       std::string referenceEntityIDRef_;
       bool referenceEntityIsNull_;
         std::vector<boost::shared_ptr<ReferenceObligation>> referenceObligation_;     //choice
       std::string referenceObligationIDRef_;
       bool referenceObligationIsNull_;
         boost::shared_ptr<XsdTypeBoolean> noReferenceObligation_;     //choice
       std::string noReferenceObligationIDRef_;
       bool noReferenceObligationIsNull_;
         boost::shared_ptr<XsdTypeBoolean> unknownReferenceObligation_;     //choice
       std::string unknownReferenceObligationIDRef_;
       bool unknownReferenceObligationIsNull_;
       boost::shared_ptr<XsdTypeBoolean> allGuarantees_;
       std::string allGuaranteesIDRef_;
       bool allGuaranteesIsNull_;
       boost::shared_ptr<XsdTypeDecimal> referencePrice_;
       std::string referencePriceIDRef_;
       bool referencePriceIsNull_;
       boost::shared_ptr<XsdTypeBoolean> referencePolicy_;
       std::string referencePolicyIDRef_;
       bool referencePolicyIsNull_;
       boost::shared_ptr<XsdTypeBoolean> securedList_;
       std::string securedListIDRef_;
       bool securedListIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

