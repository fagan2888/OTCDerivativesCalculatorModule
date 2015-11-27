// PersonId.hpp 
#ifndef FpmlSerialized_PersonId_hpp
#define FpmlSerialized_PersonId_hpp

#include <fpml-shared-5-4/Scheme.hpp>

namespace FpmlSerialized {

class PersonId : public Scheme { 
   public: 
       PersonId(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

