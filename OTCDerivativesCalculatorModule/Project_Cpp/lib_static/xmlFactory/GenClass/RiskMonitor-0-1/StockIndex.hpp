// StockIndex.hpp 
#ifndef FpmlSerialized_StockIndex_hpp
#define FpmlSerialized_StockIndex_hpp

#include <ISerialized.hpp>

namespace FpmlSerialized {

class StockIndex : public ISerialized { 
   public: 
       StockIndex(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

