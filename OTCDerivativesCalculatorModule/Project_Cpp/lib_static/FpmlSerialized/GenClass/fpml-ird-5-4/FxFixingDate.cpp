// FxFixingDate.cpp 
#include "FxFixingDate.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FxFixingDate::FxFixingDate(TiXmlNode* xmlNode)
: Offset(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //businessDayConventionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* businessDayConventionNode = xmlNode->FirstChildElement("businessDayConvention");

   if(businessDayConventionNode){businessDayConventionIsNull_ = false;}
   else{businessDayConventionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessDayConventionNode , address : " << businessDayConventionNode << std::endl;
   #endif
   if(businessDayConventionNode)
   {
      if(businessDayConventionNode->Attribute("href") || businessDayConventionNode->Attribute("id"))
      {
          if(businessDayConventionNode->Attribute("id"))
          {
             businessDayConventionIDRef_ = businessDayConventionNode->Attribute("id");
             businessDayConvention_ = boost::shared_ptr<BusinessDayConventionEnum>(new BusinessDayConventionEnum(businessDayConventionNode));
             businessDayConvention_->setID(businessDayConventionIDRef_);
             IDManager::instance().setID(businessDayConventionIDRef_,businessDayConvention_);
          }
          else if(businessDayConventionNode->Attribute("href")) { businessDayConventionIDRef_ = businessDayConventionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { businessDayConvention_ = boost::shared_ptr<BusinessDayConventionEnum>(new BusinessDayConventionEnum(businessDayConventionNode));}
   }

   //businessCentersReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* businessCentersReferenceNode = xmlNode->FirstChildElement("businessCentersReference");

   if(businessCentersReferenceNode){businessCentersReferenceIsNull_ = false;}
   else{businessCentersReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessCentersReferenceNode , address : " << businessCentersReferenceNode << std::endl;
   #endif
   if(businessCentersReferenceNode)
   {
      if(businessCentersReferenceNode->Attribute("href") || businessCentersReferenceNode->Attribute("id"))
      {
          if(businessCentersReferenceNode->Attribute("id"))
          {
             businessCentersReferenceIDRef_ = businessCentersReferenceNode->Attribute("id");
             businessCentersReference_ = boost::shared_ptr<BusinessCentersReference>(new BusinessCentersReference(businessCentersReferenceNode));
             businessCentersReference_->setID(businessCentersReferenceIDRef_);
             IDManager::instance().setID(businessCentersReferenceIDRef_,businessCentersReference_);
          }
          else if(businessCentersReferenceNode->Attribute("href")) { businessCentersReferenceIDRef_ = businessCentersReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { businessCentersReference_ = boost::shared_ptr<BusinessCentersReference>(new BusinessCentersReference(businessCentersReferenceNode));}
   }

   //businessCentersNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* businessCentersNode = xmlNode->FirstChildElement("businessCenters");

   if(businessCentersNode){businessCentersIsNull_ = false;}
   else{businessCentersIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessCentersNode , address : " << businessCentersNode << std::endl;
   #endif
   if(businessCentersNode)
   {
      if(businessCentersNode->Attribute("href") || businessCentersNode->Attribute("id"))
      {
          if(businessCentersNode->Attribute("id"))
          {
             businessCentersIDRef_ = businessCentersNode->Attribute("id");
             businessCenters_ = boost::shared_ptr<BusinessCenters>(new BusinessCenters(businessCentersNode));
             businessCenters_->setID(businessCentersIDRef_);
             IDManager::instance().setID(businessCentersIDRef_,businessCenters_);
          }
          else if(businessCentersNode->Attribute("href")) { businessCentersIDRef_ = businessCentersNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { businessCenters_ = boost::shared_ptr<BusinessCenters>(new BusinessCenters(businessCentersNode));}
   }

   //dateRelativeToPaymentDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dateRelativeToPaymentDatesNode = xmlNode->FirstChildElement("dateRelativeToPaymentDates");

   if(dateRelativeToPaymentDatesNode){dateRelativeToPaymentDatesIsNull_ = false;}
   else{dateRelativeToPaymentDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dateRelativeToPaymentDatesNode , address : " << dateRelativeToPaymentDatesNode << std::endl;
   #endif
   if(dateRelativeToPaymentDatesNode)
   {
      if(dateRelativeToPaymentDatesNode->Attribute("href") || dateRelativeToPaymentDatesNode->Attribute("id"))
      {
          if(dateRelativeToPaymentDatesNode->Attribute("id"))
          {
             dateRelativeToPaymentDatesIDRef_ = dateRelativeToPaymentDatesNode->Attribute("id");
             dateRelativeToPaymentDates_ = boost::shared_ptr<DateRelativeToPaymentDates>(new DateRelativeToPaymentDates(dateRelativeToPaymentDatesNode));
             dateRelativeToPaymentDates_->setID(dateRelativeToPaymentDatesIDRef_);
             IDManager::instance().setID(dateRelativeToPaymentDatesIDRef_,dateRelativeToPaymentDates_);
          }
          else if(dateRelativeToPaymentDatesNode->Attribute("href")) { dateRelativeToPaymentDatesIDRef_ = dateRelativeToPaymentDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dateRelativeToPaymentDates_ = boost::shared_ptr<DateRelativeToPaymentDates>(new DateRelativeToPaymentDates(dateRelativeToPaymentDatesNode));}
   }

   //dateRelativeToCalculationPeriodDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dateRelativeToCalculationPeriodDatesNode = xmlNode->FirstChildElement("dateRelativeToCalculationPeriodDates");

   if(dateRelativeToCalculationPeriodDatesNode){dateRelativeToCalculationPeriodDatesIsNull_ = false;}
   else{dateRelativeToCalculationPeriodDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dateRelativeToCalculationPeriodDatesNode , address : " << dateRelativeToCalculationPeriodDatesNode << std::endl;
   #endif
   if(dateRelativeToCalculationPeriodDatesNode)
   {
      if(dateRelativeToCalculationPeriodDatesNode->Attribute("href") || dateRelativeToCalculationPeriodDatesNode->Attribute("id"))
      {
          if(dateRelativeToCalculationPeriodDatesNode->Attribute("id"))
          {
             dateRelativeToCalculationPeriodDatesIDRef_ = dateRelativeToCalculationPeriodDatesNode->Attribute("id");
             dateRelativeToCalculationPeriodDates_ = boost::shared_ptr<DateRelativeToCalculationPeriodDates>(new DateRelativeToCalculationPeriodDates(dateRelativeToCalculationPeriodDatesNode));
             dateRelativeToCalculationPeriodDates_->setID(dateRelativeToCalculationPeriodDatesIDRef_);
             IDManager::instance().setID(dateRelativeToCalculationPeriodDatesIDRef_,dateRelativeToCalculationPeriodDates_);
          }
          else if(dateRelativeToCalculationPeriodDatesNode->Attribute("href")) { dateRelativeToCalculationPeriodDatesIDRef_ = dateRelativeToCalculationPeriodDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dateRelativeToCalculationPeriodDates_ = boost::shared_ptr<DateRelativeToCalculationPeriodDates>(new DateRelativeToCalculationPeriodDates(dateRelativeToCalculationPeriodDatesNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<BusinessDayConventionEnum> FxFixingDate::getBusinessDayConvention()
{
   if(!this->businessDayConventionIsNull_){
        if(businessDayConventionIDRef_ != ""){
             return boost::shared_static_cast<BusinessDayConventionEnum>(IDManager::instance().getID(businessDayConventionIDRef_));
        }else{
             return this->businessDayConvention_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessDayConventionEnum>();
   }
}
boost::shared_ptr<BusinessCentersReference> FxFixingDate::getBusinessCentersReference()
{
   if(!this->businessCentersReferenceIsNull_){
        if(businessCentersReferenceIDRef_ != ""){
             return boost::shared_static_cast<BusinessCentersReference>(IDManager::instance().getID(businessCentersReferenceIDRef_));
        }else{
             return this->businessCentersReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessCentersReference>();
   }
}
boost::shared_ptr<BusinessCenters> FxFixingDate::getBusinessCenters()
{
   if(!this->businessCentersIsNull_){
        if(businessCentersIDRef_ != ""){
             return boost::shared_static_cast<BusinessCenters>(IDManager::instance().getID(businessCentersIDRef_));
        }else{
             return this->businessCenters_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessCenters>();
   }
}
boost::shared_ptr<DateRelativeToPaymentDates> FxFixingDate::getDateRelativeToPaymentDates()
{
   if(!this->dateRelativeToPaymentDatesIsNull_){
        if(dateRelativeToPaymentDatesIDRef_ != ""){
             return boost::shared_static_cast<DateRelativeToPaymentDates>(IDManager::instance().getID(dateRelativeToPaymentDatesIDRef_));
        }else{
             return this->dateRelativeToPaymentDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DateRelativeToPaymentDates>();
   }
}
boost::shared_ptr<DateRelativeToCalculationPeriodDates> FxFixingDate::getDateRelativeToCalculationPeriodDates()
{
   if(!this->dateRelativeToCalculationPeriodDatesIsNull_){
        if(dateRelativeToCalculationPeriodDatesIDRef_ != ""){
             return boost::shared_static_cast<DateRelativeToCalculationPeriodDates>(IDManager::instance().getID(dateRelativeToCalculationPeriodDatesIDRef_));
        }else{
             return this->dateRelativeToCalculationPeriodDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DateRelativeToCalculationPeriodDates>();
   }
}
}

