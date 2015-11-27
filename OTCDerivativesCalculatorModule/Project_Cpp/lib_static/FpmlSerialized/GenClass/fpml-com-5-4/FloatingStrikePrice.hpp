// FloatingStrikePrice.hpp 
#ifndef FpmlSerialized_FloatingStrikePrice_hpp
#define FpmlSerialized_FloatingStrikePrice_hpp

#include <fpml-com-5-4/FloatingLegCalculation.hpp>
#include <fpml-asset-5-4/Commodity.hpp>

namespace FpmlSerialized {

class FloatingStrikePrice : public FloatingLegCalculation { 
   public: 
       FloatingStrikePrice(TiXmlNode* xmlNode);

       bool isCommodity(){return this->commodityIsNull_;}
       boost::shared_ptr<Commodity> getCommodity();
      std::string getCommodityIDRef(){return commodityIDRef_;}

   protected: 
       boost::shared_ptr<Commodity> commodity_;
       std::string commodityIDRef_;
       bool commodityIsNull_;

};

} //namespaceFpmlSerialized end
#endif

