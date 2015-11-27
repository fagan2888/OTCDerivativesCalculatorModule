// DateReference.hpp 
#ifndef FpmlSerialized_DateReference_hpp
#define FpmlSerialized_DateReference_hpp

#include <fpml-shared-5-4/Reference.hpp>

namespace FpmlSerialized {

class DateReference : public Reference { 
   public: 
       DateReference(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

