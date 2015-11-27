// Material.hpp 
#ifndef FpmlSerialized_Material_hpp
#define FpmlSerialized_Material_hpp

#include <fpml-shared-5-4/Scheme.hpp>

namespace FpmlSerialized {

class Material : public Scheme { 
   public: 
       Material(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

