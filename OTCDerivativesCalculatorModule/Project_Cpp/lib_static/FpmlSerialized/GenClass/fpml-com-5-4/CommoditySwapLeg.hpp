// CommoditySwapLeg.hpp 
#ifndef FpmlSerialized_CommoditySwapLeg_hpp
#define FpmlSerialized_CommoditySwapLeg_hpp

#include <fpml-shared-5-4/Leg.hpp>

namespace FpmlSerialized {

class CommoditySwapLeg : public Leg { 
   public: 
       CommoditySwapLeg(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

