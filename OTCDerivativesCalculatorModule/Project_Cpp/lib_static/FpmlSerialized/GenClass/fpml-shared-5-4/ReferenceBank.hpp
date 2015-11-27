// ReferenceBank.hpp 
#ifndef FpmlSerialized_ReferenceBank_hpp
#define FpmlSerialized_ReferenceBank_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/ReferenceBankId.hpp>
#include <built_in_type/XsdTypeString.hpp>

namespace FpmlSerialized {

class ReferenceBank : public ISerialized { 
   public: 
       ReferenceBank(TiXmlNode* xmlNode);

       bool isReferenceBankId(){return this->referenceBankIdIsNull_;}
       boost::shared_ptr<ReferenceBankId> getReferenceBankId();
      std::string getReferenceBankIdIDRef(){return referenceBankIdIDRef_;}

       bool isReferenceBankName(){return this->referenceBankNameIsNull_;}
       boost::shared_ptr<XsdTypeString> getReferenceBankName();
      std::string getReferenceBankNameIDRef(){return referenceBankNameIDRef_;}

   protected: 
       boost::shared_ptr<ReferenceBankId> referenceBankId_;
       std::string referenceBankIdIDRef_;
       bool referenceBankIdIsNull_;
       boost::shared_ptr<XsdTypeString> referenceBankName_;
       std::string referenceBankNameIDRef_;
       bool referenceBankNameIsNull_;

};

} //namespaceFpmlSerialized end
#endif

