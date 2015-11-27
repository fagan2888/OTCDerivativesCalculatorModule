// ExecutionDateTime.hpp 
#ifndef FpmlSerialized_ExecutionDateTime_hpp
#define FpmlSerialized_ExecutionDateTime_hpp

#include <built_in_type/XsdTypeDateTime.hpp>

namespace FpmlSerialized {

class ExecutionDateTime : public XsdTypeDateTime { 
   public: 
       ExecutionDateTime(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

