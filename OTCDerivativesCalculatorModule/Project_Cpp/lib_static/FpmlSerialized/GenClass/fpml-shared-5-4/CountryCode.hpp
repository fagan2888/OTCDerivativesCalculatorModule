// CountryCode.hpp 
#ifndef FpmlSerialized_CountryCode_hpp
#define FpmlSerialized_CountryCode_hpp

#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class CountryCode : public XsdTypeToken { 
   public: 
       CountryCode(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

