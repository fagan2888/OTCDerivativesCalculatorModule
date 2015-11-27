// DividendPeriod.cpp 
#include "DividendPeriod.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

DividendPeriod::DividendPeriod(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //unadjustedStartDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* unadjustedStartDateNode = xmlNode->FirstChildElement("unadjustedStartDate");

   if(unadjustedStartDateNode){unadjustedStartDateIsNull_ = false;}
   else{unadjustedStartDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- unadjustedStartDateNode , address : " << unadjustedStartDateNode << std::endl;
   #endif
   if(unadjustedStartDateNode)
   {
      if(unadjustedStartDateNode->Attribute("href") || unadjustedStartDateNode->Attribute("id"))
      {
          if(unadjustedStartDateNode->Attribute("id"))
          {
             unadjustedStartDateIDRef_ = unadjustedStartDateNode->Attribute("id");
             unadjustedStartDate_ = boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(unadjustedStartDateNode));
             unadjustedStartDate_->setID(unadjustedStartDateIDRef_);
             IDManager::instance().setID(unadjustedStartDateIDRef_,unadjustedStartDate_);
          }
          else if(unadjustedStartDateNode->Attribute("href")) { unadjustedStartDateIDRef_ = unadjustedStartDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { unadjustedStartDate_ = boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(unadjustedStartDateNode));}
   }

   //unadjustedEndDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* unadjustedEndDateNode = xmlNode->FirstChildElement("unadjustedEndDate");

   if(unadjustedEndDateNode){unadjustedEndDateIsNull_ = false;}
   else{unadjustedEndDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- unadjustedEndDateNode , address : " << unadjustedEndDateNode << std::endl;
   #endif
   if(unadjustedEndDateNode)
   {
      if(unadjustedEndDateNode->Attribute("href") || unadjustedEndDateNode->Attribute("id"))
      {
          if(unadjustedEndDateNode->Attribute("id"))
          {
             unadjustedEndDateIDRef_ = unadjustedEndDateNode->Attribute("id");
             unadjustedEndDate_ = boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(unadjustedEndDateNode));
             unadjustedEndDate_->setID(unadjustedEndDateIDRef_);
             IDManager::instance().setID(unadjustedEndDateIDRef_,unadjustedEndDate_);
          }
          else if(unadjustedEndDateNode->Attribute("href")) { unadjustedEndDateIDRef_ = unadjustedEndDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { unadjustedEndDate_ = boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(unadjustedEndDateNode));}
   }

   //dateAdjustmentsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dateAdjustmentsNode = xmlNode->FirstChildElement("dateAdjustments");

   if(dateAdjustmentsNode){dateAdjustmentsIsNull_ = false;}
   else{dateAdjustmentsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dateAdjustmentsNode , address : " << dateAdjustmentsNode << std::endl;
   #endif
   if(dateAdjustmentsNode)
   {
      if(dateAdjustmentsNode->Attribute("href") || dateAdjustmentsNode->Attribute("id"))
      {
          if(dateAdjustmentsNode->Attribute("id"))
          {
             dateAdjustmentsIDRef_ = dateAdjustmentsNode->Attribute("id");
             dateAdjustments_ = boost::shared_ptr<BusinessDayAdjustments>(new BusinessDayAdjustments(dateAdjustmentsNode));
             dateAdjustments_->setID(dateAdjustmentsIDRef_);
             IDManager::instance().setID(dateAdjustmentsIDRef_,dateAdjustments_);
          }
          else if(dateAdjustmentsNode->Attribute("href")) { dateAdjustmentsIDRef_ = dateAdjustmentsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dateAdjustments_ = boost::shared_ptr<BusinessDayAdjustments>(new BusinessDayAdjustments(dateAdjustmentsNode));}
   }

   //underlyerReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* underlyerReferenceNode = xmlNode->FirstChildElement("underlyerReference");

   if(underlyerReferenceNode){underlyerReferenceIsNull_ = false;}
   else{underlyerReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- underlyerReferenceNode , address : " << underlyerReferenceNode << std::endl;
   #endif
   if(underlyerReferenceNode)
   {
      if(underlyerReferenceNode->Attribute("href") || underlyerReferenceNode->Attribute("id"))
      {
          if(underlyerReferenceNode->Attribute("id"))
          {
             underlyerReferenceIDRef_ = underlyerReferenceNode->Attribute("id");
             underlyerReference_ = boost::shared_ptr<AssetReference>(new AssetReference(underlyerReferenceNode));
             underlyerReference_->setID(underlyerReferenceIDRef_);
             IDManager::instance().setID(underlyerReferenceIDRef_,underlyerReference_);
          }
          else if(underlyerReferenceNode->Attribute("href")) { underlyerReferenceIDRef_ = underlyerReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { underlyerReference_ = boost::shared_ptr<AssetReference>(new AssetReference(underlyerReferenceNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<IdentifiedDate> DividendPeriod::getUnadjustedStartDate()
{
   if(!this->unadjustedStartDateIsNull_){
        if(unadjustedStartDateIDRef_ != ""){
             return boost::shared_static_cast<IdentifiedDate>(IDManager::instance().getID(unadjustedStartDateIDRef_));
        }else{
             return this->unadjustedStartDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IdentifiedDate>();
   }
}
boost::shared_ptr<IdentifiedDate> DividendPeriod::getUnadjustedEndDate()
{
   if(!this->unadjustedEndDateIsNull_){
        if(unadjustedEndDateIDRef_ != ""){
             return boost::shared_static_cast<IdentifiedDate>(IDManager::instance().getID(unadjustedEndDateIDRef_));
        }else{
             return this->unadjustedEndDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IdentifiedDate>();
   }
}
boost::shared_ptr<BusinessDayAdjustments> DividendPeriod::getDateAdjustments()
{
   if(!this->dateAdjustmentsIsNull_){
        if(dateAdjustmentsIDRef_ != ""){
             return boost::shared_static_cast<BusinessDayAdjustments>(IDManager::instance().getID(dateAdjustmentsIDRef_));
        }else{
             return this->dateAdjustments_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessDayAdjustments>();
   }
}
boost::shared_ptr<AssetReference> DividendPeriod::getUnderlyerReference()
{
   if(!this->underlyerReferenceIsNull_){
        if(underlyerReferenceIDRef_ != ""){
             return boost::shared_static_cast<AssetReference>(IDManager::instance().getID(underlyerReferenceIDRef_));
        }else{
             return this->underlyerReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AssetReference>();
   }
}
}

