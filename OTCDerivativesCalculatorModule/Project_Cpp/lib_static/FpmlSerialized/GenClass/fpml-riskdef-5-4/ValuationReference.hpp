// ValuationReference.hpp 
#ifndef FpmlSerialized_ValuationReference_hpp
#define FpmlSerialized_ValuationReference_hpp

#include <fpml-shared-5-4/Reference.hpp>

namespace FpmlSerialized {

class ValuationReference : public Reference { 
   public: 
       ValuationReference(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

