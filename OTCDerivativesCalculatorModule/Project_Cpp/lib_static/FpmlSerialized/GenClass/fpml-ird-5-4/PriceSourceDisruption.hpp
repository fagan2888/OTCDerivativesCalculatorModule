// PriceSourceDisruption.hpp 
#ifndef FpmlSerialized_PriceSourceDisruption_hpp
#define FpmlSerialized_PriceSourceDisruption_hpp

#include <ISerialized.hpp>
#include <fpml-ird-5-4/FallbackReferencePrice.hpp>

namespace FpmlSerialized {

class PriceSourceDisruption : public ISerialized { 
   public: 
       PriceSourceDisruption(TiXmlNode* xmlNode);

       bool isFallbackReferencePrice(){return this->fallbackReferencePriceIsNull_;}
       boost::shared_ptr<FallbackReferencePrice> getFallbackReferencePrice();
      std::string getFallbackReferencePriceIDRef(){return fallbackReferencePriceIDRef_;}

   protected: 
       boost::shared_ptr<FallbackReferencePrice> fallbackReferencePrice_;
       std::string fallbackReferencePriceIDRef_;
       bool fallbackReferencePriceIsNull_;

};

} //namespaceFpmlSerialized end
#endif

