// CommodityMetalBrand.cpp 
#include "CommodityMetalBrand.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CommodityMetalBrand::CommodityMetalBrand(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //nameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nameNode = xmlNode->FirstChildElement("name");

   if(nameNode){nameIsNull_ = false;}
   else{nameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nameNode , address : " << nameNode << std::endl;
   #endif
   if(nameNode)
   {
      if(nameNode->Attribute("href") || nameNode->Attribute("id"))
      {
          if(nameNode->Attribute("id"))
          {
             nameIDRef_ = nameNode->Attribute("id");
             name_ = boost::shared_ptr<CommodityMetalBrandName>(new CommodityMetalBrandName(nameNode));
             name_->setID(nameIDRef_);
             IDManager::instance().setID(nameIDRef_,name_);
          }
          else if(nameNode->Attribute("href")) { nameIDRef_ = nameNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { name_ = boost::shared_ptr<CommodityMetalBrandName>(new CommodityMetalBrandName(nameNode));}
   }

   //brandManagerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* brandManagerNode = xmlNode->FirstChildElement("brandManager");

   if(brandManagerNode){brandManagerIsNull_ = false;}
   else{brandManagerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- brandManagerNode , address : " << brandManagerNode << std::endl;
   #endif
   if(brandManagerNode)
   {
      if(brandManagerNode->Attribute("href") || brandManagerNode->Attribute("id"))
      {
          if(brandManagerNode->Attribute("id"))
          {
             brandManagerIDRef_ = brandManagerNode->Attribute("id");
             brandManager_ = boost::shared_ptr<CommodityMetalBrandManager>(new CommodityMetalBrandManager(brandManagerNode));
             brandManager_->setID(brandManagerIDRef_);
             IDManager::instance().setID(brandManagerIDRef_,brandManager_);
          }
          else if(brandManagerNode->Attribute("href")) { brandManagerIDRef_ = brandManagerNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { brandManager_ = boost::shared_ptr<CommodityMetalBrandManager>(new CommodityMetalBrandManager(brandManagerNode));}
   }

   //countryNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* countryNode = xmlNode->FirstChildElement("country");

   if(countryNode){countryIsNull_ = false;}
   else{countryIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- countryNode , address : " << countryNode << std::endl;
   #endif
   if(countryNode)
   {
      if(countryNode->Attribute("href") || countryNode->Attribute("id"))
      {
          if(countryNode->Attribute("id"))
          {
             countryIDRef_ = countryNode->Attribute("id");
             country_ = boost::shared_ptr<CountryCode>(new CountryCode(countryNode));
             country_->setID(countryIDRef_);
             IDManager::instance().setID(countryIDRef_,country_);
          }
          else if(countryNode->Attribute("href")) { countryIDRef_ = countryNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { country_ = boost::shared_ptr<CountryCode>(new CountryCode(countryNode));}
   }

   //producerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* producerNode = xmlNode->FirstChildElement("producer");

   if(producerNode){producerIsNull_ = false;}
   else{producerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- producerNode , address : " << producerNode << std::endl;
   #endif
   if(producerNode)
   {
      if(producerNode->Attribute("href") || producerNode->Attribute("id"))
      {
          if(producerNode->Attribute("id"))
          {
             producerIDRef_ = producerNode->Attribute("id");
             producer_ = boost::shared_ptr<CommodityMetalProducer>(new CommodityMetalProducer(producerNode));
             producer_->setID(producerIDRef_);
             IDManager::instance().setID(producerIDRef_,producer_);
          }
          else if(producerNode->Attribute("href")) { producerIDRef_ = producerNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { producer_ = boost::shared_ptr<CommodityMetalProducer>(new CommodityMetalProducer(producerNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CommodityMetalBrandName> CommodityMetalBrand::getName()
{
   if(!this->nameIsNull_){
        if(nameIDRef_ != ""){
             return boost::shared_static_cast<CommodityMetalBrandName>(IDManager::instance().getID(nameIDRef_));
        }else{
             return this->name_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityMetalBrandName>();
   }
}
boost::shared_ptr<CommodityMetalBrandManager> CommodityMetalBrand::getBrandManager()
{
   if(!this->brandManagerIsNull_){
        if(brandManagerIDRef_ != ""){
             return boost::shared_static_cast<CommodityMetalBrandManager>(IDManager::instance().getID(brandManagerIDRef_));
        }else{
             return this->brandManager_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityMetalBrandManager>();
   }
}
boost::shared_ptr<CountryCode> CommodityMetalBrand::getCountry()
{
   if(!this->countryIsNull_){
        if(countryIDRef_ != ""){
             return boost::shared_static_cast<CountryCode>(IDManager::instance().getID(countryIDRef_));
        }else{
             return this->country_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CountryCode>();
   }
}
boost::shared_ptr<CommodityMetalProducer> CommodityMetalBrand::getProducer()
{
   if(!this->producerIsNull_){
        if(producerIDRef_ != ""){
             return boost::shared_static_cast<CommodityMetalProducer>(IDManager::instance().getID(producerIDRef_));
        }else{
             return this->producer_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityMetalProducer>();
   }
}
}

