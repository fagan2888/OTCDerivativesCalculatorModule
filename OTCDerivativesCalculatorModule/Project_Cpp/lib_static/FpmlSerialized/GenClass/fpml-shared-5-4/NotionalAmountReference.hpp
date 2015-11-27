// NotionalAmountReference.hpp 
#ifndef FpmlSerialized_NotionalAmountReference_hpp
#define FpmlSerialized_NotionalAmountReference_hpp

#include <fpml-shared-5-4/Reference.hpp>

namespace FpmlSerialized {

class NotionalAmountReference : public Reference { 
   public: 
       NotionalAmountReference(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

