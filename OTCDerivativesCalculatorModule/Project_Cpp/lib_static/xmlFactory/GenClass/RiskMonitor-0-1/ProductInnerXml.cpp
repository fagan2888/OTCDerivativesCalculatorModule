// ProductInnerXml.cpp 
#include "ProductInnerXml.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ProductInnerXml::ProductInnerXml(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //instrumentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* instrumentNode = xmlNode->FirstChildElement("instrument");

   if(instrumentNode){instrumentIsNull_ = false;}
   else{instrumentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- instrumentNode , address : " << instrumentNode << std::endl;
   #endif
   if(instrumentNode)
   {
       instrument_ = boost::shared_ptr<Instrument>(new Instrument(instrumentNode));
   }

   //pricingNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* pricingNode = xmlNode->FirstChildElement("pricing");

   if(pricingNode){pricingIsNull_ = false;}
   else{pricingIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- pricingNode , address : " << pricingNode << std::endl;
   #endif
   if(pricingNode)
   {
       pricing_ = boost::shared_ptr<Pricing>(new Pricing(pricingNode));
   }

   //hisoryDataNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* hisoryDataNode = xmlNode->FirstChildElement("hisoryData");

   if(hisoryDataNode){hisoryDataIsNull_ = false;}
   else{hisoryDataIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- hisoryDataNode , address : " << hisoryDataNode << std::endl;
   #endif
   if(hisoryDataNode)
   {
       hisoryData_ = boost::shared_ptr<HisoryData>(new HisoryData(hisoryDataNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Instrument> ProductInnerXml::getInstrument()
{
   if(!this->instrumentIsNull_){
        return this->instrument_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Instrument>();
   }
}
boost::shared_ptr<Pricing> ProductInnerXml::getPricing()
{
   if(!this->pricingIsNull_){
        return this->pricing_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Pricing>();
   }
}
boost::shared_ptr<HisoryData> ProductInnerXml::getHisoryData()
{
   if(!this->hisoryDataIsNull_){
        return this->hisoryData_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<HisoryData>();
   }
}
}

