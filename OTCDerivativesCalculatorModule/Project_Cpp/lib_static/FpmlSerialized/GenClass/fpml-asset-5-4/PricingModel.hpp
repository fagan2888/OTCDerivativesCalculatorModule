// PricingModel.hpp 
#ifndef FpmlSerialized_PricingModel_hpp
#define FpmlSerialized_PricingModel_hpp

#include <fpml-shared-5-4/Scheme.hpp>

namespace FpmlSerialized {

class PricingModel : public Scheme { 
   public: 
       PricingModel(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

