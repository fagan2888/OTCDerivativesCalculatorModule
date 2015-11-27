// EntityType.hpp 
#ifndef FpmlSerialized_EntityType_hpp
#define FpmlSerialized_EntityType_hpp

#include <fpml-shared-5-4/Scheme.hpp>

namespace FpmlSerialized {

class EntityType : public Scheme { 
   public: 
       EntityType(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

