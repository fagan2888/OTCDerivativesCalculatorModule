// PricingStructureReference.hpp 
#ifndef FpmlSerialized_PricingStructureReference_hpp
#define FpmlSerialized_PricingStructureReference_hpp

#include <fpml-shared-5-4/Reference.hpp>

namespace FpmlSerialized {

class PricingStructureReference : public Reference { 
   public: 
       PricingStructureReference(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

