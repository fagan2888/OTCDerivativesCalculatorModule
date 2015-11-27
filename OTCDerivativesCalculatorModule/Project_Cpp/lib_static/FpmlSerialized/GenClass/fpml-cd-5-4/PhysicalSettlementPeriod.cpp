// PhysicalSettlementPeriod.cpp 
#include "PhysicalSettlementPeriod.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PhysicalSettlementPeriod::PhysicalSettlementPeriod(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //businessDaysNotSpecifiedNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* businessDaysNotSpecifiedNode = xmlNode->FirstChildElement("businessDaysNotSpecified");

   if(businessDaysNotSpecifiedNode){businessDaysNotSpecifiedIsNull_ = false;}
   else{businessDaysNotSpecifiedIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessDaysNotSpecifiedNode , address : " << businessDaysNotSpecifiedNode << std::endl;
   #endif
   if(businessDaysNotSpecifiedNode)
   {
      if(businessDaysNotSpecifiedNode->Attribute("href") || businessDaysNotSpecifiedNode->Attribute("id"))
      {
          if(businessDaysNotSpecifiedNode->Attribute("id"))
          {
             businessDaysNotSpecifiedIDRef_ = businessDaysNotSpecifiedNode->Attribute("id");
             businessDaysNotSpecified_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(businessDaysNotSpecifiedNode));
             businessDaysNotSpecified_->setID(businessDaysNotSpecifiedIDRef_);
             IDManager::instance().setID(businessDaysNotSpecifiedIDRef_,businessDaysNotSpecified_);
          }
          else if(businessDaysNotSpecifiedNode->Attribute("href")) { businessDaysNotSpecifiedIDRef_ = businessDaysNotSpecifiedNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { businessDaysNotSpecified_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(businessDaysNotSpecifiedNode));}
   }

   //businessDaysNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* businessDaysNode = xmlNode->FirstChildElement("businessDays");

   if(businessDaysNode){businessDaysIsNull_ = false;}
   else{businessDaysIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessDaysNode , address : " << businessDaysNode << std::endl;
   #endif
   if(businessDaysNode)
   {
      if(businessDaysNode->Attribute("href") || businessDaysNode->Attribute("id"))
      {
          if(businessDaysNode->Attribute("id"))
          {
             businessDaysIDRef_ = businessDaysNode->Attribute("id");
             businessDays_ = boost::shared_ptr<XsdTypeNonNegativeInteger>(new XsdTypeNonNegativeInteger(businessDaysNode));
             businessDays_->setID(businessDaysIDRef_);
             IDManager::instance().setID(businessDaysIDRef_,businessDays_);
          }
          else if(businessDaysNode->Attribute("href")) { businessDaysIDRef_ = businessDaysNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { businessDays_ = boost::shared_ptr<XsdTypeNonNegativeInteger>(new XsdTypeNonNegativeInteger(businessDaysNode));}
   }

   //maximumBusinessDaysNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* maximumBusinessDaysNode = xmlNode->FirstChildElement("maximumBusinessDays");

   if(maximumBusinessDaysNode){maximumBusinessDaysIsNull_ = false;}
   else{maximumBusinessDaysIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- maximumBusinessDaysNode , address : " << maximumBusinessDaysNode << std::endl;
   #endif
   if(maximumBusinessDaysNode)
   {
      if(maximumBusinessDaysNode->Attribute("href") || maximumBusinessDaysNode->Attribute("id"))
      {
          if(maximumBusinessDaysNode->Attribute("id"))
          {
             maximumBusinessDaysIDRef_ = maximumBusinessDaysNode->Attribute("id");
             maximumBusinessDays_ = boost::shared_ptr<XsdTypeNonNegativeInteger>(new XsdTypeNonNegativeInteger(maximumBusinessDaysNode));
             maximumBusinessDays_->setID(maximumBusinessDaysIDRef_);
             IDManager::instance().setID(maximumBusinessDaysIDRef_,maximumBusinessDays_);
          }
          else if(maximumBusinessDaysNode->Attribute("href")) { maximumBusinessDaysIDRef_ = maximumBusinessDaysNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { maximumBusinessDays_ = boost::shared_ptr<XsdTypeNonNegativeInteger>(new XsdTypeNonNegativeInteger(maximumBusinessDaysNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeBoolean> PhysicalSettlementPeriod::getBusinessDaysNotSpecified()
{
   if(!this->businessDaysNotSpecifiedIsNull_){
        if(businessDaysNotSpecifiedIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(businessDaysNotSpecifiedIDRef_));
        }else{
             return this->businessDaysNotSpecified_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeNonNegativeInteger> PhysicalSettlementPeriod::getBusinessDays()
{
   if(!this->businessDaysIsNull_){
        if(businessDaysIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeNonNegativeInteger>(IDManager::instance().getID(businessDaysIDRef_));
        }else{
             return this->businessDays_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeNonNegativeInteger>();
   }
}
boost::shared_ptr<XsdTypeNonNegativeInteger> PhysicalSettlementPeriod::getMaximumBusinessDays()
{
   if(!this->maximumBusinessDaysIsNull_){
        if(maximumBusinessDaysIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeNonNegativeInteger>(IDManager::instance().getID(maximumBusinessDaysIDRef_));
        }else{
             return this->maximumBusinessDays_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeNonNegativeInteger>();
   }
}
}

