// AmountReference.hpp 
#ifndef FpmlSerialized_AmountReference_hpp
#define FpmlSerialized_AmountReference_hpp

#include <fpml-shared-5-4/Reference.hpp>

namespace FpmlSerialized {

class AmountReference : public Reference { 
   public: 
       AmountReference(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

