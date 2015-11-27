// Currency.hpp 
#ifndef FpmlSerialized_Currency_hpp
#define FpmlSerialized_Currency_hpp

#include <fpml-shared-5-4/Scheme.hpp>

namespace FpmlSerialized {

class Currency : public Scheme { 
   public: 
       Currency(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

