// IdentifiedRate.hpp 
#ifndef FpmlSerialized_IdentifiedRate_hpp
#define FpmlSerialized_IdentifiedRate_hpp

#include <built_in_type/XsdTypeDecimal.hpp>

namespace FpmlSerialized {

class IdentifiedRate : public XsdTypeDecimal { 
   public: 
       IdentifiedRate(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

