// DataProvider.hpp 
#ifndef FpmlSerialized_DataProvider_hpp
#define FpmlSerialized_DataProvider_hpp

#include <fpml-shared-5-4/Scheme.hpp>

namespace FpmlSerialized {

class DataProvider : public Scheme { 
   public: 
       DataProvider(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

