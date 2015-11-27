// MarketData.cpp 
#include "MarketData.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

MarketData::MarketData(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //krcodeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* krcodeNode = xmlNode->FirstChildElement("krcode");

   if(krcodeNode){krcodeIsNull_ = false;}
   else{krcodeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- krcodeNode , address : " << krcodeNode << std::endl;
   #endif
   if(krcodeNode)
   {
       krcode_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(krcodeNode));
   }

   //nameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nameNode = xmlNode->FirstChildElement("name");

   if(nameNode){nameIsNull_ = false;}
   else{nameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nameNode , address : " << nameNode << std::endl;
   #endif
   if(nameNode)
   {
       name_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(nameNode));
   }

   //dataValueInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dataValueInfoNode = xmlNode->FirstChildElement("dataValueInfo");

   if(dataValueInfoNode){dataValueInfoIsNull_ = false;}
   else{dataValueInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dataValueInfoNode , address : " << dataValueInfoNode << std::endl;
   #endif
   if(dataValueInfoNode)
   {
       dataValueInfo_ = boost::shared_ptr<DataValueInfo>(new DataValueInfo(dataValueInfoNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> MarketData::getKrcode()
{
   if(!this->krcodeIsNull_){
        return this->krcode_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> MarketData::getName()
{
   if(!this->nameIsNull_){
        return this->name_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<DataValueInfo> MarketData::getDataValueInfo()
{
   if(!this->dataValueInfoIsNull_){
        return this->dataValueInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DataValueInfo>();
   }
}
}

