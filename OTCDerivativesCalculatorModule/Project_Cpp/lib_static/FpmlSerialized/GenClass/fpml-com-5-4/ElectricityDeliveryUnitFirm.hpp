// ElectricityDeliveryUnitFirm.hpp 
#ifndef FpmlSerialized_ElectricityDeliveryUnitFirm_hpp
#define FpmlSerialized_ElectricityDeliveryUnitFirm_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-com-5-4/CommodityDeliveryPoint.hpp>

namespace FpmlSerialized {

class ElectricityDeliveryUnitFirm : public ISerialized { 
   public: 
       ElectricityDeliveryUnitFirm(TiXmlNode* xmlNode);

       bool isApplicable(){return this->applicableIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getApplicable();
      std::string getApplicableIDRef(){return applicableIDRef_;}

       bool isGenerationAsset(){return this->generationAssetIsNull_;}
       boost::shared_ptr<CommodityDeliveryPoint> getGenerationAsset();
      std::string getGenerationAssetIDRef(){return generationAssetIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeBoolean> applicable_;
       std::string applicableIDRef_;
       bool applicableIsNull_;
       boost::shared_ptr<CommodityDeliveryPoint> generationAsset_;
       std::string generationAssetIDRef_;
       bool generationAssetIsNull_;

};

} //namespaceFpmlSerialized end
#endif

