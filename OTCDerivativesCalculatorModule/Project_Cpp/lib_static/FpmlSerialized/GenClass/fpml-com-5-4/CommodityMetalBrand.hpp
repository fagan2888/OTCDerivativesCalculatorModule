// CommodityMetalBrand.hpp 
#ifndef FpmlSerialized_CommodityMetalBrand_hpp
#define FpmlSerialized_CommodityMetalBrand_hpp

#include <ISerialized.hpp>
#include <fpml-com-5-4/CommodityMetalBrandName.hpp>
#include <fpml-com-5-4/CommodityMetalBrandManager.hpp>
#include <fpml-shared-5-4/CountryCode.hpp>
#include <fpml-com-5-4/CommodityMetalProducer.hpp>

namespace FpmlSerialized {

class CommodityMetalBrand : public ISerialized { 
   public: 
       CommodityMetalBrand(TiXmlNode* xmlNode);

       bool isName(){return this->nameIsNull_;}
       boost::shared_ptr<CommodityMetalBrandName> getName();
      std::string getNameIDRef(){return nameIDRef_;}

       bool isBrandManager(){return this->brandManagerIsNull_;}
       boost::shared_ptr<CommodityMetalBrandManager> getBrandManager();
      std::string getBrandManagerIDRef(){return brandManagerIDRef_;}

       bool isCountry(){return this->countryIsNull_;}
       boost::shared_ptr<CountryCode> getCountry();
      std::string getCountryIDRef(){return countryIDRef_;}

       bool isProducer(){return this->producerIsNull_;}
       boost::shared_ptr<CommodityMetalProducer> getProducer();
      std::string getProducerIDRef(){return producerIDRef_;}

   protected: 
       boost::shared_ptr<CommodityMetalBrandName> name_;
       std::string nameIDRef_;
       bool nameIsNull_;
       boost::shared_ptr<CommodityMetalBrandManager> brandManager_;
       std::string brandManagerIDRef_;
       bool brandManagerIsNull_;
       boost::shared_ptr<CountryCode> country_;
       std::string countryIDRef_;
       bool countryIsNull_;
       boost::shared_ptr<CommodityMetalProducer> producer_;
       std::string producerIDRef_;
       bool producerIsNull_;

};

} //namespaceFpmlSerialized end
#endif

