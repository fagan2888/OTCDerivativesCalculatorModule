// UnprocessedElementWrapper.hpp 
#ifndef FpmlSerialized_UnprocessedElementWrapper_hpp
#define FpmlSerialized_UnprocessedElementWrapper_hpp

#include <ISerialized.hpp>

namespace FpmlSerialized {

class UnprocessedElementWrapper : public ISerialized { 
   public: 
       UnprocessedElementWrapper(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

