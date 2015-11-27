// NullFixingDateInfo.hpp 
#ifndef FpmlSerialized_NullFixingDateInfo_hpp
#define FpmlSerialized_NullFixingDateInfo_hpp

#include <ISerialized.hpp>

namespace FpmlSerialized {

class NullFixingDateInfo : public ISerialized { 
   public: 
       NullFixingDateInfo(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

