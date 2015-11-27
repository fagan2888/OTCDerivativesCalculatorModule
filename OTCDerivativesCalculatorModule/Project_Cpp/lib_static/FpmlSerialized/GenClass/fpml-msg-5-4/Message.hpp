// Message.hpp 
#ifndef FpmlSerialized_Message_hpp
#define FpmlSerialized_Message_hpp

#include <fpml-doc-5-4/Document.hpp>

namespace FpmlSerialized {

class Message : public Document { 
   public: 
       Message(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

