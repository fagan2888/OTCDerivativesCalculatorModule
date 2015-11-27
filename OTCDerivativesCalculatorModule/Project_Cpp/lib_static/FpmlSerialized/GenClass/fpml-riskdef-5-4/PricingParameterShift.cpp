// PricingParameterShift.cpp 
#include "PricingParameterShift.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PricingParameterShift::PricingParameterShift(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //parameterReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* parameterReferenceNode = xmlNode->FirstChildElement("parameterReference");

   if(parameterReferenceNode){parameterReferenceIsNull_ = false;}
   else{parameterReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- parameterReferenceNode , address : " << parameterReferenceNode << std::endl;
   #endif
   if(parameterReferenceNode)
   {
      if(parameterReferenceNode->Attribute("href") || parameterReferenceNode->Attribute("id"))
      {
          if(parameterReferenceNode->Attribute("id"))
          {
             parameterReferenceIDRef_ = parameterReferenceNode->Attribute("id");
             parameterReference_ = boost::shared_ptr<AssetOrTermPointOrPricingStructureReference>(new AssetOrTermPointOrPricingStructureReference(parameterReferenceNode));
             parameterReference_->setID(parameterReferenceIDRef_);
             IDManager::instance().setID(parameterReferenceIDRef_,parameterReference_);
          }
          else if(parameterReferenceNode->Attribute("href")) { parameterReferenceIDRef_ = parameterReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { parameterReference_ = boost::shared_ptr<AssetOrTermPointOrPricingStructureReference>(new AssetOrTermPointOrPricingStructureReference(parameterReferenceNode));}
   }

   //shiftNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* shiftNode = xmlNode->FirstChildElement("shift");

   if(shiftNode){shiftIsNull_ = false;}
   else{shiftIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- shiftNode , address : " << shiftNode << std::endl;
   #endif
   if(shiftNode)
   {
      if(shiftNode->Attribute("href") || shiftNode->Attribute("id"))
      {
          if(shiftNode->Attribute("id"))
          {
             shiftIDRef_ = shiftNode->Attribute("id");
             shift_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(shiftNode));
             shift_->setID(shiftIDRef_);
             IDManager::instance().setID(shiftIDRef_,shift_);
          }
          else if(shiftNode->Attribute("href")) { shiftIDRef_ = shiftNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { shift_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(shiftNode));}
   }

   //shiftUnitsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* shiftUnitsNode = xmlNode->FirstChildElement("shiftUnits");

   if(shiftUnitsNode){shiftUnitsIsNull_ = false;}
   else{shiftUnitsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- shiftUnitsNode , address : " << shiftUnitsNode << std::endl;
   #endif
   if(shiftUnitsNode)
   {
      if(shiftUnitsNode->Attribute("href") || shiftUnitsNode->Attribute("id"))
      {
          if(shiftUnitsNode->Attribute("id"))
          {
             shiftUnitsIDRef_ = shiftUnitsNode->Attribute("id");
             shiftUnits_ = boost::shared_ptr<PriceQuoteUnits>(new PriceQuoteUnits(shiftUnitsNode));
             shiftUnits_->setID(shiftUnitsIDRef_);
             IDManager::instance().setID(shiftUnitsIDRef_,shiftUnits_);
          }
          else if(shiftUnitsNode->Attribute("href")) { shiftUnitsIDRef_ = shiftUnitsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { shiftUnits_ = boost::shared_ptr<PriceQuoteUnits>(new PriceQuoteUnits(shiftUnitsNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AssetOrTermPointOrPricingStructureReference> PricingParameterShift::getParameterReference()
{
   if(!this->parameterReferenceIsNull_){
        if(parameterReferenceIDRef_ != ""){
             return boost::shared_static_cast<AssetOrTermPointOrPricingStructureReference>(IDManager::instance().getID(parameterReferenceIDRef_));
        }else{
             return this->parameterReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AssetOrTermPointOrPricingStructureReference>();
   }
}
boost::shared_ptr<XsdTypeDecimal> PricingParameterShift::getShift()
{
   if(!this->shiftIsNull_){
        if(shiftIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(shiftIDRef_));
        }else{
             return this->shift_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<PriceQuoteUnits> PricingParameterShift::getShiftUnits()
{
   if(!this->shiftUnitsIsNull_){
        if(shiftUnitsIDRef_ != ""){
             return boost::shared_static_cast<PriceQuoteUnits>(IDManager::instance().getID(shiftUnitsIDRef_));
        }else{
             return this->shiftUnits_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PriceQuoteUnits>();
   }
}
}

