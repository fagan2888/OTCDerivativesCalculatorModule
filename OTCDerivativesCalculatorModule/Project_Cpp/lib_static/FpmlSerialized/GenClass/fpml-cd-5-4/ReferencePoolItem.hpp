// ReferencePoolItem.hpp 
#ifndef FpmlSerialized_ReferencePoolItem_hpp
#define FpmlSerialized_ReferencePoolItem_hpp

#include <ISerialized.hpp>
#include <fpml-asset-5-4/ConstituentWeight.hpp>
#include <fpml-cd-5-4/ReferencePair.hpp>
#include <fpml-cd-5-4/ProtectionTermsReference.hpp>
#include <fpml-cd-5-4/SettlementTermsReference.hpp>

namespace FpmlSerialized {

class ReferencePoolItem : public ISerialized { 
   public: 
       ReferencePoolItem(TiXmlNode* xmlNode);

       bool isConstituentWeight(){return this->constituentWeightIsNull_;}
       boost::shared_ptr<ConstituentWeight> getConstituentWeight();
      std::string getConstituentWeightIDRef(){return constituentWeightIDRef_;}

       bool isReferencePair(){return this->referencePairIsNull_;}
       boost::shared_ptr<ReferencePair> getReferencePair();
      std::string getReferencePairIDRef(){return referencePairIDRef_;}

       bool isProtectionTermsReference(){return this->protectionTermsReferenceIsNull_;}
       boost::shared_ptr<ProtectionTermsReference> getProtectionTermsReference();
      std::string getProtectionTermsReferenceIDRef(){return protectionTermsReferenceIDRef_;}

       bool isSettlementTermsReference(){return this->settlementTermsReferenceIsNull_;}
       boost::shared_ptr<SettlementTermsReference> getSettlementTermsReference();
      std::string getSettlementTermsReferenceIDRef(){return settlementTermsReferenceIDRef_;}

   protected: 
       boost::shared_ptr<ConstituentWeight> constituentWeight_;
       std::string constituentWeightIDRef_;
       bool constituentWeightIsNull_;
       boost::shared_ptr<ReferencePair> referencePair_;
       std::string referencePairIDRef_;
       bool referencePairIsNull_;
       boost::shared_ptr<ProtectionTermsReference> protectionTermsReference_;
       std::string protectionTermsReferenceIDRef_;
       bool protectionTermsReferenceIsNull_;
       boost::shared_ptr<SettlementTermsReference> settlementTermsReference_;
       std::string settlementTermsReferenceIDRef_;
       bool settlementTermsReferenceIsNull_;

};

} //namespaceFpmlSerialized end
#endif

