// WeatherIndex.cpp 
#include "WeatherIndex.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

WeatherIndex::WeatherIndex(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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

   //unitNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* unitNode = xmlNode->FirstChildElement("unit");

   if(unitNode){unitIsNull_ = false;}
   else{unitIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- unitNode , address : " << unitNode << std::endl;
   #endif
   if(unitNode)
   {
      if(unitNode->Attribute("href") || unitNode->Attribute("id"))
      {
          if(unitNode->Attribute("id"))
          {
             unitIDRef_ = unitNode->Attribute("id");
             unit_ = boost::shared_ptr<QuantityUnit>(new QuantityUnit(unitNode));
             unit_->setID(unitIDRef_);
             IDManager::instance().setID(unitIDRef_,unit_);
          }
          else if(unitNode->Attribute("href")) { unitIDRef_ = unitNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { unit_ = boost::shared_ptr<QuantityUnit>(new QuantityUnit(unitNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDecimal> WeatherIndex::getQuantity()
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
boost::shared_ptr<QuantityUnit> WeatherIndex::getUnit()
{
   if(!this->unitIsNull_){
        if(unitIDRef_ != ""){
             return boost::shared_static_cast<QuantityUnit>(IDManager::instance().getID(unitIDRef_));
        }else{
             return this->unit_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<QuantityUnit>();
   }
}
}

