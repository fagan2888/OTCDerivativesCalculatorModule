// Language.hpp 
#ifndef FpmlSerialized_Language_hpp
#define FpmlSerialized_Language_hpp

#include <fpml-shared-5-4/Scheme.hpp>

namespace FpmlSerialized {

class Language : public Scheme { 
   public: 
       Language(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

