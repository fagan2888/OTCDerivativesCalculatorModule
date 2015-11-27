// Tranche.hpp 
#ifndef FpmlSerialized_Tranche_hpp
#define FpmlSerialized_Tranche_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class Tranche : public ISerialized { 
   public: 
       Tranche(TiXmlNode* xmlNode);

       bool isAttachmentPoint(){return this->attachmentPointIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getAttachmentPoint();
      std::string getAttachmentPointIDRef(){return attachmentPointIDRef_;}

       bool isExhaustionPoint(){return this->exhaustionPointIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getExhaustionPoint();
      std::string getExhaustionPointIDRef(){return exhaustionPointIDRef_;}

       bool isIncurredRecoveryApplicable(){return this->incurredRecoveryApplicableIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getIncurredRecoveryApplicable();
      std::string getIncurredRecoveryApplicableIDRef(){return incurredRecoveryApplicableIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDecimal> attachmentPoint_;
       std::string attachmentPointIDRef_;
       bool attachmentPointIsNull_;
       boost::shared_ptr<XsdTypeDecimal> exhaustionPoint_;
       std::string exhaustionPointIDRef_;
       bool exhaustionPointIsNull_;
       boost::shared_ptr<XsdTypeBoolean> incurredRecoveryApplicable_;
       std::string incurredRecoveryApplicableIDRef_;
       bool incurredRecoveryApplicableIsNull_;

};

} //namespaceFpmlSerialized end
#endif

