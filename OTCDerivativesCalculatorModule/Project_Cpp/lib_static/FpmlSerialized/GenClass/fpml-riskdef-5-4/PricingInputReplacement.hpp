// PricingInputReplacement.hpp 
#ifndef FpmlSerialized_PricingInputReplacement_hpp
#define FpmlSerialized_PricingInputReplacement_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/PricingStructureReference.hpp>

namespace FpmlSerialized {

class PricingInputReplacement : public ISerialized { 
   public: 
       PricingInputReplacement(TiXmlNode* xmlNode);

       bool isOriginalInputReference(){return this->originalInputReferenceIsNull_;}
       boost::shared_ptr<PricingStructureReference> getOriginalInputReference();
      std::string getOriginalInputReferenceIDRef(){return originalInputReferenceIDRef_;}

       bool isReplacementInputReference(){return this->replacementInputReferenceIsNull_;}
       boost::shared_ptr<PricingStructureReference> getReplacementInputReference();
      std::string getReplacementInputReferenceIDRef(){return replacementInputReferenceIDRef_;}

   protected: 
       boost::shared_ptr<PricingStructureReference> originalInputReference_;
       std::string originalInputReferenceIDRef_;
       bool originalInputReferenceIsNull_;
       boost::shared_ptr<PricingStructureReference> replacementInputReference_;
       std::string replacementInputReferenceIDRef_;
       bool replacementInputReferenceIsNull_;

};

} //namespaceFpmlSerialized end
#endif

