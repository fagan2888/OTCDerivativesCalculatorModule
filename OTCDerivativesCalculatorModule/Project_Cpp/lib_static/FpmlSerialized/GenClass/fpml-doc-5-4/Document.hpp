// Document.hpp 
#ifndef FpmlSerialized_Document_hpp
#define FpmlSerialized_Document_hpp

#include <ISerialized.hpp>

namespace FpmlSerialized {

class Document : public ISerialized { 
   public: 
       Document(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

