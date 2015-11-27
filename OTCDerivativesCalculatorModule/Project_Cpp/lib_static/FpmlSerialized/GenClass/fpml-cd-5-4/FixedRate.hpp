// FixedRate.hpp 
#ifndef FpmlSerialized_FixedRate_hpp
#define FpmlSerialized_FixedRate_hpp

#include <built_in_type/XsdTypeDecimal.hpp>

namespace FpmlSerialized {

class FixedRate : public XsdTypeDecimal { 
   public: 
       FixedRate(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

