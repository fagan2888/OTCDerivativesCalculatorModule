// RequiredIdentifierDate.hpp 
#ifndef FpmlSerialized_RequiredIdentifierDate_hpp
#define FpmlSerialized_RequiredIdentifierDate_hpp

#include <built_in_type/XsdTypeDate.hpp>

namespace FpmlSerialized {

class RequiredIdentifierDate : public XsdTypeDate { 
   public: 
       RequiredIdentifierDate(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

