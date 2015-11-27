// ProductInnerXml.hpp 
#ifndef FpmlSerialized_ProductInnerXml_hpp
#define FpmlSerialized_ProductInnerXml_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Instrument.hpp>
#include <RiskMonitor-0-1/Pricing.hpp>
#include <RiskMonitor-0-1/HisoryData.hpp>

namespace FpmlSerialized {

class ProductInnerXml : public ISerialized { 
   public: 
       ProductInnerXml(TiXmlNode* xmlNode);

       bool isInstrument(){return this->instrumentIsNull_;}
       boost::shared_ptr<Instrument> getInstrument();


       bool isPricing(){return this->pricingIsNull_;}
       boost::shared_ptr<Pricing> getPricing();


       bool isHisoryData(){return this->hisoryDataIsNull_;}
       boost::shared_ptr<HisoryData> getHisoryData();


   protected: 
       boost::shared_ptr<Instrument> instrument_;
       
       bool instrumentIsNull_;
       boost::shared_ptr<Pricing> pricing_;
       
       bool pricingIsNull_;
       boost::shared_ptr<HisoryData> hisoryData_;
       
       bool hisoryDataIsNull_;

};

} //namespaceFpmlSerialized end
#endif

