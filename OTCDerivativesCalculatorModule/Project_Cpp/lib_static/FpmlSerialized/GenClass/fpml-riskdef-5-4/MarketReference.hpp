// MarketReference.hpp 
#ifndef FpmlSerialized_MarketReference_hpp
#define FpmlSerialized_MarketReference_hpp

#include <fpml-shared-5-4/Reference.hpp>

namespace FpmlSerialized {

class MarketReference : public Reference { 
   public: 
       MarketReference(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

