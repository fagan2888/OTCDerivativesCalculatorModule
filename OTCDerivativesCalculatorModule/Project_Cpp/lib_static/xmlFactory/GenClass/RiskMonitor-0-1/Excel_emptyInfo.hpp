// Excel_emptyInfo.hpp 
#ifndef FpmlSerialized_Excel_emptyInfo_hpp
#define FpmlSerialized_Excel_emptyInfo_hpp

#include <ISerialized.hpp>

namespace FpmlSerialized {

class Excel_emptyInfo : public ISerialized { 
   public: 
       Excel_emptyInfo(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

