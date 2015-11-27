// CommodityNotionalQuantity.cpp 
#include "CommodityNotionalQuantity.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CommodityNotionalQuantity::CommodityNotionalQuantity(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //quantityUnitNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* quantityUnitNode = xmlNode->FirstChildElement("quantityUnit");

   if(quantityUnitNode){quantityUnitIsNull_ = false;}
   else{quantityUnitIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- quantityUnitNode , address : " << quantityUnitNode << std::endl;
   #endif
   if(quantityUnitNode)
   {
      if(quantityUnitNode->Attribute("href") || quantityUnitNode->Attribute("id"))
      {
          if(quantityUnitNode->Attribute("id"))
          {
             quantityUnitIDRef_ = quantityUnitNode->Attribute("id");
             quantityUnit_ = boost::shared_ptr<QuantityUnit>(new QuantityUnit(quantityUnitNode));
             quantityUnit_->setID(quantityUnitIDRef_);
             IDManager::instance().setID(quantityUnitIDRef_,quantityUnit_);
          }
          else if(quantityUnitNode->Attribute("href")) { quantityUnitIDRef_ = quantityUnitNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { quantityUnit_ = boost::shared_ptr<QuantityUnit>(new QuantityUnit(quantityUnitNode));}
   }

   //quantityFrequencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* quantityFrequencyNode = xmlNode->FirstChildElement("quantityFrequency");

   if(quantityFrequencyNode){quantityFrequencyIsNull_ = false;}
   else{quantityFrequencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- quantityFrequencyNode , address : " << quantityFrequencyNode << std::endl;
   #endif
   if(quantityFrequencyNode)
   {
      if(quantityFrequencyNode->Attribute("href") || quantityFrequencyNode->Attribute("id"))
      {
          if(quantityFrequencyNode->Attribute("id"))
          {
             quantityFrequencyIDRef_ = quantityFrequencyNode->Attribute("id");
             quantityFrequency_ = boost::shared_ptr<CommodityQuantityFrequency>(new CommodityQuantityFrequency(quantityFrequencyNode));
             quantityFrequency_->setID(quantityFrequencyIDRef_);
             IDManager::instance().setID(quantityFrequencyIDRef_,quantityFrequency_);
          }
          else if(quantityFrequencyNode->Attribute("href")) { quantityFrequencyIDRef_ = quantityFrequencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { quantityFrequency_ = boost::shared_ptr<CommodityQuantityFrequency>(new CommodityQuantityFrequency(quantityFrequencyNode));}
   }

   //quantityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* quantityNode = xmlNode->FirstChildElement("quantity");

   if(quantityNode){quantityIsNull_ = false;}
   else{quantityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- quantityNode , address : " << quantityNode << std::endl;
   #endif
   if(quantityNode)
   {
      if(quantityNode->Attribute("href") || quantityNode->Attribute("id"))
      {
          if(quantityNode->Attribute("id"))
          {
             quantityIDRef_ = quantityNode->Attribute("id");
             quantity_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(quantityNode));
             quantity_->setID(quantityIDRef_);
             IDManager::instance().setID(quantityIDRef_,quantity_);
          }
          else if(quantityNode->Attribute("href")) { quantityIDRef_ = quantityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { quantity_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(quantityNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<QuantityUnit> CommodityNotionalQuantity::getQuantityUnit()
{
   if(!this->quantityUnitIsNull_){
        if(quantityUnitIDRef_ != ""){
             return boost::shared_static_cast<QuantityUnit>(IDManager::instance().getID(quantityUnitIDRef_));
        }else{
             return this->quantityUnit_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<QuantityUnit>();
   }
}
boost::shared_ptr<CommodityQuantityFrequency> CommodityNotionalQuantity::getQuantityFrequency()
{
   if(!this->quantityFrequencyIsNull_){
        if(quantityFrequencyIDRef_ != ""){
             return boost::shared_static_cast<CommodityQuantityFrequency>(IDManager::instance().getID(quantityFrequencyIDRef_));
        }else{
             return this->quantityFrequency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityQuantityFrequency>();
   }
}
boost::shared_ptr<XsdTypeDecimal> CommodityNotionalQuantity::getQuantity()
{
   if(!this->quantityIsNull_){
        if(quantityIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(quantityIDRef_));
        }else{
             return this->quantity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
}

