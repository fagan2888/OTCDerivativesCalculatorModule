// CommodityInformationSource.hpp 
#ifndef FpmlSerialized_CommodityInformationSource_hpp
#define FpmlSerialized_CommodityInformationSource_hpp

#include <ISerialized.hpp>
#include <fpml-asset-5-4/CommodityInformationProvider.hpp>
#include <fpml-shared-5-4/RateSourcePage.hpp>
#include <built_in_type/XsdTypeString.hpp>

namespace FpmlSerialized {

class CommodityInformationSource : public ISerialized { 
   public: 
       CommodityInformationSource(TiXmlNode* xmlNode);

       bool isRateSource(){return this->rateSourceIsNull_;}
       boost::shared_ptr<CommodityInformationProvider> getRateSource();
      std::string getRateSourceIDRef(){return rateSourceIDRef_;}

       bool isRateSourcePage(){return this->rateSourcePageIsNull_;}
       boost::shared_ptr<RateSourcePage> getRateSourcePage();
      std::string getRateSourcePageIDRef(){return rateSourcePageIDRef_;}

       bool isRateSourcePageHeading(){return this->rateSourcePageHeadingIsNull_;}
       boost::shared_ptr<XsdTypeString> getRateSourcePageHeading();
      std::string getRateSourcePageHeadingIDRef(){return rateSourcePageHeadingIDRef_;}

   protected: 
       boost::shared_ptr<CommodityInformationProvider> rateSource_;
       std::string rateSourceIDRef_;
       bool rateSourceIsNull_;
       boost::shared_ptr<RateSourcePage> rateSourcePage_;
       std::string rateSourcePageIDRef_;
       bool rateSourcePageIsNull_;
       boost::shared_ptr<XsdTypeString> rateSourcePageHeading_;
       std::string rateSourcePageHeadingIDRef_;
       bool rateSourcePageHeadingIsNull_;

};

} //namespaceFpmlSerialized end
#endif

