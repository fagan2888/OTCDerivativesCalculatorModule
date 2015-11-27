// PersonReference.hpp 
#ifndef FpmlSerialized_PersonReference_hpp
#define FpmlSerialized_PersonReference_hpp

#include <fpml-shared-5-4/Reference.hpp>

namespace FpmlSerialized {

class PersonReference : public Reference { 
   public: 
       PersonReference(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

