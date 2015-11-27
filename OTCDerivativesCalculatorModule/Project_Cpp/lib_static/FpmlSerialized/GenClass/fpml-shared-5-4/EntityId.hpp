// EntityId.hpp 
#ifndef FpmlSerialized_EntityId_hpp
#define FpmlSerialized_EntityId_hpp

#include <fpml-shared-5-4/Scheme.hpp>

namespace FpmlSerialized {

class EntityId : public Scheme { 
   public: 
       EntityId(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

