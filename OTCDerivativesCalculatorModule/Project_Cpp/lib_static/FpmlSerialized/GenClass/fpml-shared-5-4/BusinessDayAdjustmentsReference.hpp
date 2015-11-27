// BusinessDayAdjustmentsReference.hpp 
#ifndef FpmlSerialized_BusinessDayAdjustmentsReference_hpp
#define FpmlSerialized_BusinessDayAdjustmentsReference_hpp

#include <fpml-shared-5-4/Reference.hpp>

namespace FpmlSerialized {

class BusinessDayAdjustmentsReference : public Reference { 
   public: 
       BusinessDayAdjustmentsReference(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

