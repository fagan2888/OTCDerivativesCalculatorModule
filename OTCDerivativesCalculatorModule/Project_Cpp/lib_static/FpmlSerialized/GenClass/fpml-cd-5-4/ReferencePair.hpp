// ReferencePair.hpp 
#ifndef FpmlSerialized_ReferencePair_hpp
#define FpmlSerialized_ReferencePair_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/LegalEntity.hpp>
#include <fpml-cd-5-4/ReferenceObligation.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-cd-5-4/EntityType.hpp>

namespace FpmlSerialized {

class ReferencePair : public ISerialized { 
   public: 
       ReferencePair(TiXmlNode* xmlNode);

       bool isReferenceEntity(){return this->referenceEntityIsNull_;}
       boost::shared_ptr<LegalEntity> getReferenceEntity();
      std::string getReferenceEntityIDRef(){return referenceEntityIDRef_;}

       bool isReferenceObligation(){return this->referenceObligationIsNull_;}
       boost::shared_ptr<ReferenceObligation> getReferenceObligation();
      std::string getReferenceObligationIDRef(){return referenceObligationIDRef_;}

       bool isNoReferenceObligation(){return this->noReferenceObligationIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getNoReferenceObligation();
      std::string getNoReferenceObligationIDRef(){return noReferenceObligationIDRef_;}

       bool isEntityType(){return this->entityTypeIsNull_;}
       boost::shared_ptr<EntityType> getEntityType();
      std::string getEntityTypeIDRef(){return entityTypeIDRef_;}

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
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<LegalEntity> referenceEntity_;
       std::string referenceEntityIDRef_;
       bool referenceEntityIsNull_;
         boost::shared_ptr<ReferenceObligation> referenceObligation_;     //choice
       std::string referenceObligationIDRef_;
       bool referenceObligationIsNull_;
         boost::shared_ptr<XsdTypeBoolean> noReferenceObligation_;     //choice
       std::string noReferenceObligationIDRef_;
       bool noReferenceObligationIsNull_;
       boost::shared_ptr<EntityType> entityType_;
       std::string entityTypeIDRef_;
       bool entityTypeIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

