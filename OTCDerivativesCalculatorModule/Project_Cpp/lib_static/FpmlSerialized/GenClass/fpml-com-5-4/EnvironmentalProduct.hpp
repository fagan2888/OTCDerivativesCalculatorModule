// EnvironmentalProduct.hpp 
#ifndef FpmlSerialized_EnvironmentalProduct_hpp
#define FpmlSerialized_EnvironmentalProduct_hpp

#include <ISerialized.hpp>
#include <fpml-enum-5-4/EnvironmentalProductTypeEnum.hpp>
#include <fpml-com-5-4/EnvironmentalProductComplaincePeriod.hpp>
#include <built_in_type/XsdTypeGYear.hpp>
#include <fpml-com-5-4/EnvironmentalProductApplicableLaw.hpp>
#include <fpml-com-5-4/EnvironmentalTrackingSystem.hpp>

namespace FpmlSerialized {

class EnvironmentalProduct : public ISerialized { 
   public: 
       EnvironmentalProduct(TiXmlNode* xmlNode);

       bool isProductType(){return this->productTypeIsNull_;}
       boost::shared_ptr<EnvironmentalProductTypeEnum> getProductType();
      std::string getProductTypeIDRef(){return productTypeIDRef_;}

       bool isCompliancePeriod(){return this->compliancePeriodIsNull_;}
       boost::shared_ptr<EnvironmentalProductComplaincePeriod> getCompliancePeriod();
      std::string getCompliancePeriodIDRef(){return compliancePeriodIDRef_;}

       bool isVintage(){return this->vintageIsNull_;}
       std::vector<boost::shared_ptr<XsdTypeGYear>> getVintage();
      std::string getVintageIDRef(){return vintageIDRef_;}

       bool isApplicableLaw(){return this->applicableLawIsNull_;}
       boost::shared_ptr<EnvironmentalProductApplicableLaw> getApplicableLaw();
      std::string getApplicableLawIDRef(){return applicableLawIDRef_;}

       bool isTrackingSystem(){return this->trackingSystemIsNull_;}
       boost::shared_ptr<EnvironmentalTrackingSystem> getTrackingSystem();
      std::string getTrackingSystemIDRef(){return trackingSystemIDRef_;}

   protected: 
       boost::shared_ptr<EnvironmentalProductTypeEnum> productType_;
       std::string productTypeIDRef_;
       bool productTypeIsNull_;
       boost::shared_ptr<EnvironmentalProductComplaincePeriod> compliancePeriod_;
       std::string compliancePeriodIDRef_;
       bool compliancePeriodIsNull_;
       std::vector<boost::shared_ptr<XsdTypeGYear>> vintage_;
       std::string vintageIDRef_;
       bool vintageIsNull_;
       boost::shared_ptr<EnvironmentalProductApplicableLaw> applicableLaw_;
       std::string applicableLawIDRef_;
       bool applicableLawIsNull_;
       boost::shared_ptr<EnvironmentalTrackingSystem> trackingSystem_;
       std::string trackingSystemIDRef_;
       bool trackingSystemIsNull_;

};

} //namespaceFpmlSerialized end
#endif

