// IdentifiedDate.hpp 
#ifndef FpmlSerialized_IdentifiedDate_hpp
#define FpmlSerialized_IdentifiedDate_hpp

#include <built_in_type/XsdTypeDate.hpp>

namespace FpmlSerialized {

class IdentifiedDate : public XsdTypeDate { 
   public: 
       IdentifiedDate(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

