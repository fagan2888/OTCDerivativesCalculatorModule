// NullResult.hpp 
#ifndef FpmlSerialized_NullResult_hpp
#define FpmlSerialized_NullResult_hpp

#include <ISerialized.hpp>

namespace FpmlSerialized {

class NullResult : public ISerialized { 
   public: 
       NullResult(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

