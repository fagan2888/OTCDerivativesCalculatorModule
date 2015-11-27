// CommodityPhysicalQuantityBase.hpp 
#ifndef FpmlSerialized_CommodityPhysicalQuantityBase_hpp
#define FpmlSerialized_CommodityPhysicalQuantityBase_hpp

#include <ISerialized.hpp>

namespace FpmlSerialized {

class CommodityPhysicalQuantityBase : public ISerialized { 
   public: 
       CommodityPhysicalQuantityBase(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

