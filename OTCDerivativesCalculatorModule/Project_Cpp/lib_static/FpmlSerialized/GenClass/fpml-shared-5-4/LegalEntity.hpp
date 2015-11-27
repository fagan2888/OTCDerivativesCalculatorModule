// LegalEntity.hpp 
#ifndef FpmlSerialized_LegalEntity_hpp
#define FpmlSerialized_LegalEntity_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/EntityName.hpp>
#include <fpml-shared-5-4/EntityId.hpp>

namespace FpmlSerialized {

class LegalEntity : public ISerialized { 
   public: 
       LegalEntity(TiXmlNode* xmlNode);

       bool isEntityName(){return this->entityNameIsNull_;}
       boost::shared_ptr<EntityName> getEntityName();
      std::string getEntityNameIDRef(){return entityNameIDRef_;}

       bool isEntityId(){return this->entityIdIsNull_;}
       std::vector<boost::shared_ptr<EntityId>> getEntityId();
      std::string getEntityIdIDRef(){return entityIdIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!entityNameIsNull_){
                count += 1;
                str = "entityName" ;
           }
           if(!entityIdIsNull_){
                count += 1;
                str = "entityId" ;
           }
           if(!entityIdIsNull_){
                count += 1;
                str = "entityId" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<EntityName> entityName_;     //choice
       std::string entityNameIDRef_;
       bool entityNameIsNull_;
         std::vector<boost::shared_ptr<EntityId>> entityId_;     //choice
       std::string entityIdIDRef_;
       bool entityIdIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

