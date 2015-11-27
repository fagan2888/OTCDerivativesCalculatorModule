// CommoditySpread.cpp 
#include "CommoditySpread.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CommoditySpread::CommoditySpread(TiXmlNode* xmlNode)
: Money(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //spreadConversionFactorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* spreadConversionFactorNode = xmlNode->FirstChildElement("spreadConversionFactor");

   if(spreadConversionFactorNode){spreadConversionFactorIsNull_ = false;}
   else{spreadConversionFactorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- spreadConversionFactorNode , address : " << spreadConversionFactorNode << std::endl;
   #endif
   if(spreadConversionFactorNode)
   {
      if(spreadConversionFactorNode->Attribute("href") || spreadConversionFactorNode->Attribute("id"))
      {
          if(spreadConversionFactorNode->Attribute("id"))
          {
             spreadConversionFactorIDRef_ = spreadConversionFactorNode->Attribute("id");
             spreadConversionFactor_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(spreadConversionFactorNode));
             spreadConversionFactor_->setID(spreadConversionFactorIDRef_);
             IDManager::instance().setID(spreadConversionFactorIDRef_,spreadConversionFactor_);
          }
          else if(spreadConversionFactorNode->Attribute("href")) { spreadConversionFactorIDRef_ = spreadConversionFactorNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { spreadConversionFactor_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(spreadConversionFactorNode));}
   }

   //spreadUnitNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* spreadUnitNode = xmlNode->FirstChildElement("spreadUnit");

   if(spreadUnitNode){spreadUnitIsNull_ = false;}
   else{spreadUnitIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- spreadUnitNode , address : " << spreadUnitNode << std::endl;
   #endif
   if(spreadUnitNode)
   {
      if(spreadUnitNode->Attribute("href") || spreadUnitNode->Attribute("id"))
      {
          if(spreadUnitNode->Attribute("id"))
          {
             spreadUnitIDRef_ = spreadUnitNode->Attribute("id");
             spreadUnit_ = boost::shared_ptr<QuantityUnit>(new QuantityUnit(spreadUnitNode));
             spreadUnit_->setID(spreadUnitIDRef_);
             IDManager::instance().setID(spreadUnitIDRef_,spreadUnit_);
          }
          else if(spreadUnitNode->Attribute("href")) { spreadUnitIDRef_ = spreadUnitNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { spreadUnit_ = boost::shared_ptr<QuantityUnit>(new QuantityUnit(spreadUnitNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDecimal> CommoditySpread::getSpreadConversionFactor()
{
   if(!this->spreadConversionFactorIsNull_){
        if(spreadConversionFactorIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(spreadConversionFactorIDRef_));
        }else{
             return this->spreadConversionFactor_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<QuantityUnit> CommoditySpread::getSpreadUnit()
{
   if(!this->spreadUnitIsNull_){
        if(spreadUnitIDRef_ != ""){
             return boost::shared_static_cast<QuantityUnit>(IDManager::instance().getID(spreadUnitIDRef_));
        }else{
             return this->spreadUnit_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<QuantityUnit>();
   }
}
}

