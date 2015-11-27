// OrganizationType.hpp 
#ifndef FpmlSerialized_OrganizationType_hpp
#define FpmlSerialized_OrganizationType_hpp

#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class OrganizationType : public XsdTypeToken { 
   public: 
       OrganizationType(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

