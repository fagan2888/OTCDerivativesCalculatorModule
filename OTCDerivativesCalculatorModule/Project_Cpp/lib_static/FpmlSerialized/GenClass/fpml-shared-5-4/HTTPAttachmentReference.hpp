// HTTPAttachmentReference.hpp 
#ifndef FpmlSerialized_HTTPAttachmentReference_hpp
#define FpmlSerialized_HTTPAttachmentReference_hpp

#include <fpml-shared-5-4/Reference.hpp>

namespace FpmlSerialized {

class HTTPAttachmentReference : public Reference { 
   public: 
       HTTPAttachmentReference(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

