// HisoryData.cpp 
#include "HisoryData.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

HisoryData::HisoryData(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //marketDataNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* marketDataNode = xmlNode->FirstChildElement("marketData");

   if(marketDataNode){marketDataIsNull_ = false;}
   else{marketDataIsNull_ = true;}

   if(marketDataNode)
   {
      for(marketDataNode; marketDataNode; marketDataNode = marketDataNode->NextSiblingElement("marketData")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- marketDataNode , address : " << marketDataNode << std::endl;
          #endif
          marketData_.push_back(boost::shared_ptr<MarketData>(new MarketData(marketDataNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- marketDataNode , address : " << marketDataNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<MarketData>> HisoryData::getMarketData()
{
   if(!this->marketDataIsNull_){
        return this->marketData_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<MarketData>>();
   }
}
}

