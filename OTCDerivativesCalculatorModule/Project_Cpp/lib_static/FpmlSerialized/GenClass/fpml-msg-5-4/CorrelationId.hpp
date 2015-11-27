// CorrelationId.hpp 
#ifndef FpmlSerialized_CorrelationId_hpp
#define FpmlSerialized_CorrelationId_hpp

#include <built_in_type/XsdTypeNormalizedString.hpp>

namespace FpmlSerialized {

class CorrelationId : public XsdTypeNormalizedString { 
   public: 
       CorrelationId(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

