// HisoryData.hpp 
#ifndef FpmlSerialized_HisoryData_hpp
#define FpmlSerialized_HisoryData_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/MarketData.hpp>

namespace FpmlSerialized {

class HisoryData : public ISerialized { 
   public: 
       HisoryData(TiXmlNode* xmlNode);

       bool isMarketData(){return this->marketDataIsNull_;}
       std::vector<boost::shared_ptr<MarketData>> getMarketData();


   protected: 
       std::vector<boost::shared_ptr<MarketData>> marketData_;
       
       bool marketDataIsNull_;

};

} //namespaceFpmlSerialized end
#endif

