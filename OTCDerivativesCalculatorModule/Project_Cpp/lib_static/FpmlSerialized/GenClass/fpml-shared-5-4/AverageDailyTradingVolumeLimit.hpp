// AverageDailyTradingVolumeLimit.hpp 
#ifndef FpmlSerialized_AverageDailyTradingVolumeLimit_hpp
#define FpmlSerialized_AverageDailyTradingVolumeLimit_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/RestrictedPercentage.hpp>
#include <built_in_type/XsdTypeNonNegativeInteger.hpp>

namespace FpmlSerialized {

class AverageDailyTradingVolumeLimit : public ISerialized { 
   public: 
       AverageDailyTradingVolumeLimit(TiXmlNode* xmlNode);

       bool isLimitationPercentage(){return this->limitationPercentageIsNull_;}
       boost::shared_ptr<RestrictedPercentage> getLimitationPercentage();
      std::string getLimitationPercentageIDRef(){return limitationPercentageIDRef_;}

       bool isLimitationPeriod(){return this->limitationPeriodIsNull_;}
       boost::shared_ptr<XsdTypeNonNegativeInteger> getLimitationPeriod();
      std::string getLimitationPeriodIDRef(){return limitationPeriodIDRef_;}

   protected: 
       boost::shared_ptr<RestrictedPercentage> limitationPercentage_;
       std::string limitationPercentageIDRef_;
       bool limitationPercentageIsNull_;
       boost::shared_ptr<XsdTypeNonNegativeInteger> limitationPeriod_;
       std::string limitationPeriodIDRef_;
       bool limitationPeriodIsNull_;

};

} //namespaceFpmlSerialized end
#endif

