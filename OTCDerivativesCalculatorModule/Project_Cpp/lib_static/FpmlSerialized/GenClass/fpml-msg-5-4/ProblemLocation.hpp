// ProblemLocation.hpp 
#ifndef FpmlSerialized_ProblemLocation_hpp
#define FpmlSerialized_ProblemLocation_hpp

#include <built_in_type/XsdTypeNormalizedString.hpp>

namespace FpmlSerialized {

class ProblemLocation : public XsdTypeNormalizedString { 
   public: 
       ProblemLocation(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

