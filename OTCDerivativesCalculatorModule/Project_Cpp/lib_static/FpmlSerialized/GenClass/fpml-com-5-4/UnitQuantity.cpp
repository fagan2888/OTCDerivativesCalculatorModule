// UnitQuantity.cpp 
#include "UnitQuantity.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

UnitQuantity::UnitQuantity(TiXmlNode* xmlNode)
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
             quantity_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(quantityNode));
             quantity_->setID(quantityIDRef_);
             IDManager::instance().setID(quantityIDRef_,quantity_);
          }
          else if(quantityNode->Attribute("href")) { quantityIDRef_ = quantityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { quantity_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(quantityNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<QuantityUnit> UnitQuantity::getQuantityUnit()
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
boost::shared_ptr<NonNegativeDecimal> UnitQuantity::getQuantity()
{
   if(!this->quantityIsNull_){
        if(quantityIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeDecimal>(IDManager::instance().getID(quantityIDRef_));
        }else{
             return this->quantity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeDecimal>();
   }
}
}

