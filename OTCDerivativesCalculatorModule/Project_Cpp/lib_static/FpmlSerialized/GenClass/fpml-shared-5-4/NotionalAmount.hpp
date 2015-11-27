// NotionalAmount.hpp 
#ifndef FpmlSerialized_NotionalAmount_hpp
#define FpmlSerialized_NotionalAmount_hpp

#include <fpml-shared-5-4/NonNegativeMoney.hpp>

namespace FpmlSerialized {

class NotionalAmount : public NonNegativeMoney { 
   public: 
       NotionalAmount(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

