// Compounding.cpp 
#include "Compounding.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Compounding::Compounding(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //compoundingMethodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* compoundingMethodNode = xmlNode->FirstChildElement("compoundingMethod");

   if(compoundingMethodNode){compoundingMethodIsNull_ = false;}
   else{compoundingMethodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- compoundingMethodNode , address : " << compoundingMethodNode << std::endl;
   #endif
   if(compoundingMethodNode)
   {
      if(compoundingMethodNode->Attribute("href") || compoundingMethodNode->Attribute("id"))
      {
          if(compoundingMethodNode->Attribute("id"))
          {
             compoundingMethodIDRef_ = compoundingMethodNode->Attribute("id");
             compoundingMethod_ = boost::shared_ptr<CompoundingMethodEnum>(new CompoundingMethodEnum(compoundingMethodNode));
             compoundingMethod_->setID(compoundingMethodIDRef_);
             IDManager::instance().setID(compoundingMethodIDRef_,compoundingMethod_);
          }
          else if(compoundingMethodNode->Attribute("href")) { compoundingMethodIDRef_ = compoundingMethodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { compoundingMethod_ = boost::shared_ptr<CompoundingMethodEnum>(new CompoundingMethodEnum(compoundingMethodNode));}
   }

   //compoundingRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* compoundingRateNode = xmlNode->FirstChildElement("compoundingRate");

   if(compoundingRateNode){compoundingRateIsNull_ = false;}
   else{compoundingRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- compoundingRateNode , address : " << compoundingRateNode << std::endl;
   #endif
   if(compoundingRateNode)
   {
      if(compoundingRateNode->Attribute("href") || compoundingRateNode->Attribute("id"))
      {
          if(compoundingRateNode->Attribute("id"))
          {
             compoundingRateIDRef_ = compoundingRateNode->Attribute("id");
             compoundingRate_ = boost::shared_ptr<CompoundingRate>(new CompoundingRate(compoundingRateNode));
             compoundingRate_->setID(compoundingRateIDRef_);
             IDManager::instance().setID(compoundingRateIDRef_,compoundingRate_);
          }
          else if(compoundingRateNode->Attribute("href")) { compoundingRateIDRef_ = compoundingRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { compoundingRate_ = boost::shared_ptr<CompoundingRate>(new CompoundingRate(compoundingRateNode));}
   }

   //compoundingSpreadNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* compoundingSpreadNode = xmlNode->FirstChildElement("compoundingSpread");

   if(compoundingSpreadNode){compoundingSpreadIsNull_ = false;}
   else{compoundingSpreadIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- compoundingSpreadNode , address : " << compoundingSpreadNode << std::endl;
   #endif
   if(compoundingSpreadNode)
   {
      if(compoundingSpreadNode->Attribute("href") || compoundingSpreadNode->Attribute("id"))
      {
          if(compoundingSpreadNode->Attribute("id"))
          {
             compoundingSpreadIDRef_ = compoundingSpreadNode->Attribute("id");
             compoundingSpread_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(compoundingSpreadNode));
             compoundingSpread_->setID(compoundingSpreadIDRef_);
             IDManager::instance().setID(compoundingSpreadIDRef_,compoundingSpread_);
          }
          else if(compoundingSpreadNode->Attribute("href")) { compoundingSpreadIDRef_ = compoundingSpreadNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { compoundingSpread_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(compoundingSpreadNode));}
   }

   //compoundingDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* compoundingDatesNode = xmlNode->FirstChildElement("compoundingDates");

   if(compoundingDatesNode){compoundingDatesIsNull_ = false;}
   else{compoundingDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- compoundingDatesNode , address : " << compoundingDatesNode << std::endl;
   #endif
   if(compoundingDatesNode)
   {
      if(compoundingDatesNode->Attribute("href") || compoundingDatesNode->Attribute("id"))
      {
          if(compoundingDatesNode->Attribute("id"))
          {
             compoundingDatesIDRef_ = compoundingDatesNode->Attribute("id");
             compoundingDates_ = boost::shared_ptr<AdjustableRelativeOrPeriodicDates2>(new AdjustableRelativeOrPeriodicDates2(compoundingDatesNode));
             compoundingDates_->setID(compoundingDatesIDRef_);
             IDManager::instance().setID(compoundingDatesIDRef_,compoundingDates_);
          }
          else if(compoundingDatesNode->Attribute("href")) { compoundingDatesIDRef_ = compoundingDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { compoundingDates_ = boost::shared_ptr<AdjustableRelativeOrPeriodicDates2>(new AdjustableRelativeOrPeriodicDates2(compoundingDatesNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CompoundingMethodEnum> Compounding::getCompoundingMethod()
{
   if(!this->compoundingMethodIsNull_){
        if(compoundingMethodIDRef_ != ""){
             return boost::shared_static_cast<CompoundingMethodEnum>(IDManager::instance().getID(compoundingMethodIDRef_));
        }else{
             return this->compoundingMethod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CompoundingMethodEnum>();
   }
}
boost::shared_ptr<CompoundingRate> Compounding::getCompoundingRate()
{
   if(!this->compoundingRateIsNull_){
        if(compoundingRateIDRef_ != ""){
             return boost::shared_static_cast<CompoundingRate>(IDManager::instance().getID(compoundingRateIDRef_));
        }else{
             return this->compoundingRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CompoundingRate>();
   }
}
boost::shared_ptr<XsdTypeDecimal> Compounding::getCompoundingSpread()
{
   if(!this->compoundingSpreadIsNull_){
        if(compoundingSpreadIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(compoundingSpreadIDRef_));
        }else{
             return this->compoundingSpread_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<AdjustableRelativeOrPeriodicDates2> Compounding::getCompoundingDates()
{
   if(!this->compoundingDatesIsNull_){
        if(compoundingDatesIDRef_ != ""){
             return boost::shared_static_cast<AdjustableRelativeOrPeriodicDates2>(IDManager::instance().getID(compoundingDatesIDRef_));
        }else{
             return this->compoundingDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableRelativeOrPeriodicDates2>();
   }
}
}

