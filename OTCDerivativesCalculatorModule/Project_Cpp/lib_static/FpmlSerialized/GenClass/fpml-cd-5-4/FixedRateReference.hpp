// FixedRateReference.hpp 
#ifndef FpmlSerialized_FixedRateReference_hpp
#define FpmlSerialized_FixedRateReference_hpp

#include <fpml-shared-5-4/Reference.hpp>

namespace FpmlSerialized {

class FixedRateReference : public Reference { 
   public: 
       FixedRateReference(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

