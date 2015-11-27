// GenericDimension.hpp 
#ifndef FpmlSerialized_GenericDimension_hpp
#define FpmlSerialized_GenericDimension_hpp

#include <built_in_type/XsdTypeString.hpp>

namespace FpmlSerialized {

class GenericDimension : public XsdTypeString { 
   public: 
       GenericDimension(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

