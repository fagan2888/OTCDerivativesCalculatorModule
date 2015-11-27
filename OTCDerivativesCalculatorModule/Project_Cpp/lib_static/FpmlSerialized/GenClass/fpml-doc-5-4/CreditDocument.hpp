// CreditDocument.hpp 
#ifndef FpmlSerialized_CreditDocument_hpp
#define FpmlSerialized_CreditDocument_hpp

#include <fpml-shared-5-4/Scheme.hpp>

namespace FpmlSerialized {

class CreditDocument : public Scheme { 
   public: 
       CreditDocument(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

