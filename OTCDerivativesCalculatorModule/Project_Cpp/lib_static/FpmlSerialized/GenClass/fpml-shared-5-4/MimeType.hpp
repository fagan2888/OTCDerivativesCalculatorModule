// MimeType.hpp 
#ifndef FpmlSerialized_MimeType_hpp
#define FpmlSerialized_MimeType_hpp

#include <fpml-shared-5-4/Scheme.hpp>

namespace FpmlSerialized {

class MimeType : public Scheme { 
   public: 
       MimeType(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

