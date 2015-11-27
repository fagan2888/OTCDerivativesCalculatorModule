// BusinessUnitReference.hpp 
#ifndef FpmlSerialized_BusinessUnitReference_hpp
#define FpmlSerialized_BusinessUnitReference_hpp

#include <fpml-shared-5-4/Reference.hpp>

namespace FpmlSerialized {

class BusinessUnitReference : public Reference { 
   public: 
       BusinessUnitReference(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

