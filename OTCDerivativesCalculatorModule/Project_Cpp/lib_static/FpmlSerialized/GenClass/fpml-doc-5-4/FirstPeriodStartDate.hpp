// FirstPeriodStartDate.hpp 
#ifndef FpmlSerialized_FirstPeriodStartDate_hpp
#define FpmlSerialized_FirstPeriodStartDate_hpp

#include <built_in_type/XsdTypeDate.hpp>

namespace FpmlSerialized {

class FirstPeriodStartDate : public XsdTypeDate { 
   public: 
       FirstPeriodStartDate(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

