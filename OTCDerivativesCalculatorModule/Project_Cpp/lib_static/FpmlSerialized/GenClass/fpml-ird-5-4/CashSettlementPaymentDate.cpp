// CashSettlementPaymentDate.cpp 
#include "CashSettlementPaymentDate.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CashSettlementPaymentDate::CashSettlementPaymentDate(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //adjustableDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* adjustableDatesNode = xmlNode->FirstChildElement("adjustableDates");

   if(adjustableDatesNode){adjustableDatesIsNull_ = false;}
   else{adjustableDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- adjustableDatesNode , address : " << adjustableDatesNode << std::endl;
   #endif
   if(adjustableDatesNode)
   {
      if(adjustableDatesNode->Attribute("href") || adjustableDatesNode->Attribute("id"))
      {
          if(adjustableDatesNode->Attribute("id"))
          {
             adjustableDatesIDRef_ = adjustableDatesNode->Attribute("id");
             adjustableDates_ = boost::shared_ptr<AdjustableDates>(new AdjustableDates(adjustableDatesNode));
             adjustableDates_->setID(adjustableDatesIDRef_);
             IDManager::instance().setID(adjustableDatesIDRef_,adjustableDates_);
          }
          else if(adjustableDatesNode->Attribute("href")) { adjustableDatesIDRef_ = adjustableDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { adjustableDates_ = boost::shared_ptr<AdjustableDates>(new AdjustableDates(adjustableDatesNode));}
   }

   //relativeDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* relativeDateNode = xmlNode->FirstChildElement("relativeDate");

   if(relativeDateNode){relativeDateIsNull_ = false;}
   else{relativeDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- relativeDateNode , address : " << relativeDateNode << std::endl;
   #endif
   if(relativeDateNode)
   {
      if(relativeDateNode->Attribute("href") || relativeDateNode->Attribute("id"))
      {
          if(relativeDateNode->Attribute("id"))
          {
             relativeDateIDRef_ = relativeDateNode->Attribute("id");
             relativeDate_ = boost::shared_ptr<RelativeDateOffset>(new RelativeDateOffset(relativeDateNode));
             relativeDate_->setID(relativeDateIDRef_);
             IDManager::instance().setID(relativeDateIDRef_,relativeDate_);
          }
          else if(relativeDateNode->Attribute("href")) { relativeDateIDRef_ = relativeDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { relativeDate_ = boost::shared_ptr<RelativeDateOffset>(new RelativeDateOffset(relativeDateNode));}
   }

   //businessDateRangeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* businessDateRangeNode = xmlNode->FirstChildElement("businessDateRange");

   if(businessDateRangeNode){businessDateRangeIsNull_ = false;}
   else{businessDateRangeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessDateRangeNode , address : " << businessDateRangeNode << std::endl;
   #endif
   if(businessDateRangeNode)
   {
      if(businessDateRangeNode->Attribute("href") || businessDateRangeNode->Attribute("id"))
      {
          if(businessDateRangeNode->Attribute("id"))
          {
             businessDateRangeIDRef_ = businessDateRangeNode->Attribute("id");
             businessDateRange_ = boost::shared_ptr<BusinessDateRange>(new BusinessDateRange(businessDateRangeNode));
             businessDateRange_->setID(businessDateRangeIDRef_);
             IDManager::instance().setID(businessDateRangeIDRef_,businessDateRange_);
          }
          else if(businessDateRangeNode->Attribute("href")) { businessDateRangeIDRef_ = businessDateRangeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { businessDateRange_ = boost::shared_ptr<BusinessDateRange>(new BusinessDateRange(businessDateRangeNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AdjustableDates> CashSettlementPaymentDate::getAdjustableDates()
{
   if(!this->adjustableDatesIsNull_){
        if(adjustableDatesIDRef_ != ""){
             return boost::shared_static_cast<AdjustableDates>(IDManager::instance().getID(adjustableDatesIDRef_));
        }else{
             return this->adjustableDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableDates>();
   }
}
boost::shared_ptr<RelativeDateOffset> CashSettlementPaymentDate::getRelativeDate()
{
   if(!this->relativeDateIsNull_){
        if(relativeDateIDRef_ != ""){
             return boost::shared_static_cast<RelativeDateOffset>(IDManager::instance().getID(relativeDateIDRef_));
        }else{
             return this->relativeDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RelativeDateOffset>();
   }
}
boost::shared_ptr<BusinessDateRange> CashSettlementPaymentDate::getBusinessDateRange()
{
   if(!this->businessDateRangeIsNull_){
        if(businessDateRangeIDRef_ != ""){
             return boost::shared_static_cast<BusinessDateRange>(IDManager::instance().getID(businessDateRangeIDRef_));
        }else{
             return this->businessDateRange_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessDateRange>();
   }
}
}

