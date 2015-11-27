// Asset.hpp 
#ifndef FpmlSerialized_Asset_hpp
#define FpmlSerialized_Asset_hpp

#include <ISerialized.hpp>

namespace FpmlSerialized {

class Asset : public ISerialized { 
   public: 
       Asset(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

