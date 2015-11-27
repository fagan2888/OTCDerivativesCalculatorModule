// AdjustableDate.hpp 
#ifndef FpmlSerialized_AdjustableDate_hpp
#define FpmlSerialized_AdjustableDate_hpp

#include <ISerialized.hpp>

namespace FpmlSerialized {

class AdjustableDate : public ISerialized { 
   public: 
       AdjustableDate(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

