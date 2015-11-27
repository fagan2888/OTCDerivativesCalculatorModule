// CommodityForwardLeg.hpp 
#ifndef FpmlSerialized_CommodityForwardLeg_hpp
#define FpmlSerialized_CommodityForwardLeg_hpp

#include <fpml-shared-5-4/Leg.hpp>

namespace FpmlSerialized {

class CommodityForwardLeg : public Leg { 
   public: 
       CommodityForwardLeg(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

