// Sensitivity.hpp 
#ifndef FpmlSerialized_Sensitivity_hpp
#define FpmlSerialized_Sensitivity_hpp

#include <built_in_type/XsdTypeDecimal.hpp>

namespace FpmlSerialized {

class Sensitivity : public XsdTypeDecimal { 
   public: 
       Sensitivity(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

