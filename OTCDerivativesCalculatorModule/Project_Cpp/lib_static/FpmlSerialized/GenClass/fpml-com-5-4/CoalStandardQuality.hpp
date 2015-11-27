// CoalStandardQuality.hpp 
#ifndef FpmlSerialized_CoalStandardQuality_hpp
#define FpmlSerialized_CoalStandardQuality_hpp

#include <ISerialized.hpp>
#include <fpml-com-5-4/CoalAttributePercentage.hpp>
#include <fpml-com-5-4/CoalAttributeDecimal.hpp>

namespace FpmlSerialized {

class CoalStandardQuality : public ISerialized { 
   public: 
       CoalStandardQuality(TiXmlNode* xmlNode);

       bool isMoisture(){return this->moistureIsNull_;}
       boost::shared_ptr<CoalAttributePercentage> getMoisture();
      std::string getMoistureIDRef(){return moistureIDRef_;}

       bool isAsh(){return this->ashIsNull_;}
       boost::shared_ptr<CoalAttributePercentage> getAsh();
      std::string getAshIDRef(){return ashIDRef_;}

       bool isSulfur(){return this->sulfurIsNull_;}
       boost::shared_ptr<CoalAttributePercentage> getSulfur();
      std::string getSulfurIDRef(){return sulfurIDRef_;}

       bool isSO2(){return this->SO2IsNull_;}
       boost::shared_ptr<CoalAttributePercentage> getSO2();
      std::string getSO2IDRef(){return SO2IDRef_;}

       bool isVolatile(){return this->volatileIsNull_;}
       boost::shared_ptr<CoalAttributePercentage> getVolatile();
      std::string getVolatileIDRef(){return volatileIDRef_;}

       bool isBTUperLB(){return this->BTUperLBIsNull_;}
       boost::shared_ptr<CoalAttributeDecimal> getBTUperLB();
      std::string getBTUperLBIDRef(){return BTUperLBIDRef_;}

       bool isTopSize(){return this->topSizeIsNull_;}
       boost::shared_ptr<CoalAttributeDecimal> getTopSize();
      std::string getTopSizeIDRef(){return topSizeIDRef_;}

       bool isFinesPassingScreen(){return this->finesPassingScreenIsNull_;}
       boost::shared_ptr<CoalAttributeDecimal> getFinesPassingScreen();
      std::string getFinesPassingScreenIDRef(){return finesPassingScreenIDRef_;}

       bool isGrindability(){return this->grindabilityIsNull_;}
       boost::shared_ptr<CoalAttributeDecimal> getGrindability();
      std::string getGrindabilityIDRef(){return grindabilityIDRef_;}

       bool isAshFusionTemperature(){return this->ashFusionTemperatureIsNull_;}
       boost::shared_ptr<CoalAttributeDecimal> getAshFusionTemperature();
      std::string getAshFusionTemperatureIDRef(){return ashFusionTemperatureIDRef_;}

       bool isInitialDeformation(){return this->initialDeformationIsNull_;}
       boost::shared_ptr<CoalAttributeDecimal> getInitialDeformation();
      std::string getInitialDeformationIDRef(){return initialDeformationIDRef_;}

       bool isSofteningHeightWidth(){return this->softeningHeightWidthIsNull_;}
       boost::shared_ptr<CoalAttributeDecimal> getSofteningHeightWidth();
      std::string getSofteningHeightWidthIDRef(){return softeningHeightWidthIDRef_;}

       bool isSofteningHeightHalfWidth(){return this->softeningHeightHalfWidthIsNull_;}
       boost::shared_ptr<CoalAttributeDecimal> getSofteningHeightHalfWidth();
      std::string getSofteningHeightHalfWidthIDRef(){return softeningHeightHalfWidthIDRef_;}

       bool isFluid(){return this->fluidIsNull_;}
       boost::shared_ptr<CoalAttributeDecimal> getFluid();
      std::string getFluidIDRef(){return fluidIDRef_;}

   protected: 
       boost::shared_ptr<CoalAttributePercentage> moisture_;
       std::string moistureIDRef_;
       bool moistureIsNull_;
       boost::shared_ptr<CoalAttributePercentage> ash_;
       std::string ashIDRef_;
       bool ashIsNull_;
       boost::shared_ptr<CoalAttributePercentage> sulfur_;
       std::string sulfurIDRef_;
       bool sulfurIsNull_;
       boost::shared_ptr<CoalAttributePercentage> SO2_;
       std::string SO2IDRef_;
       bool SO2IsNull_;
       boost::shared_ptr<CoalAttributePercentage> volatile_;
       std::string volatileIDRef_;
       bool volatileIsNull_;
       boost::shared_ptr<CoalAttributeDecimal> BTUperLB_;
       std::string BTUperLBIDRef_;
       bool BTUperLBIsNull_;
       boost::shared_ptr<CoalAttributeDecimal> topSize_;
       std::string topSizeIDRef_;
       bool topSizeIsNull_;
       boost::shared_ptr<CoalAttributeDecimal> finesPassingScreen_;
       std::string finesPassingScreenIDRef_;
       bool finesPassingScreenIsNull_;
       boost::shared_ptr<CoalAttributeDecimal> grindability_;
       std::string grindabilityIDRef_;
       bool grindabilityIsNull_;
       boost::shared_ptr<CoalAttributeDecimal> ashFusionTemperature_;
       std::string ashFusionTemperatureIDRef_;
       bool ashFusionTemperatureIsNull_;
       boost::shared_ptr<CoalAttributeDecimal> initialDeformation_;
       std::string initialDeformationIDRef_;
       bool initialDeformationIsNull_;
       boost::shared_ptr<CoalAttributeDecimal> softeningHeightWidth_;
       std::string softeningHeightWidthIDRef_;
       bool softeningHeightWidthIsNull_;
       boost::shared_ptr<CoalAttributeDecimal> softeningHeightHalfWidth_;
       std::string softeningHeightHalfWidthIDRef_;
       bool softeningHeightHalfWidthIsNull_;
       boost::shared_ptr<CoalAttributeDecimal> fluid_;
       std::string fluidIDRef_;
       bool fluidIsNull_;

};

} //namespaceFpmlSerialized end
#endif

