// ReferenceInformation.hpp 
#ifndef FpmlSerialized_ReferenceInformation_hpp
#define FpmlSerialized_ReferenceInformation_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class ReferenceInformation : public ISerialized { 
   public: 
       ReferenceInformation(TiXmlNode* xmlNode);

       bool isEntityName(){return this->entityNameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getEntityName();


       bool isEntityId(){return this->entityIdIsNull_;}
       boost::shared_ptr<XsdTypeToken> getEntityId();


   protected: 
       boost::shared_ptr<XsdTypeToken> entityName_;
       
       bool entityNameIsNull_;
       boost::shared_ptr<XsdTypeToken> entityId_;
       
       bool entityIdIsNull_;

};

} //namespaceFpmlSerialized end
#endif

