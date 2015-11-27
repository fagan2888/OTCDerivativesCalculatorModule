// QuantityReference.hpp 
#ifndef FpmlSerialized_QuantityReference_hpp
#define FpmlSerialized_QuantityReference_hpp

#include <fpml-shared-5-4/Reference.hpp>

namespace FpmlSerialized {

class QuantityReference : public Reference { 
   public: 
       QuantityReference(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

