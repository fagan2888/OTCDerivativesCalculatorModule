// AdjustableOrAdjustedDate.cpp 
#include "AdjustableOrAdjustedDate.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

AdjustableOrAdjustedDate::AdjustableOrAdjustedDate(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //unadjustedDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* unadjustedDateNode = xmlNode->FirstChildElement("unadjustedDate");

   if(unadjustedDateNode){unadjustedDateIsNull_ = false;}
   else{unadjustedDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- unadjustedDateNode , address : " << unadjustedDateNode << std::endl;
   #endif
   if(unadjustedDateNode)
   {
      if(unadjustedDateNode->Attribute("href") || unadjustedDateNode->Attribute("id"))
      {
          if(unadjustedDateNode->Attribute("id"))
          {
             unadjustedDateIDRef_ = unadjustedDateNode->Attribute("id");
             unadjustedDate_ = boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(unadjustedDateNode));
             unadjustedDate_->setID(unadjustedDateIDRef_);
             IDManager::instance().setID(unadjustedDateIDRef_,unadjustedDate_);
          }
          else if(unadjustedDateNode->Attribute("href")) { unadjustedDateIDRef_ = unadjustedDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { unadjustedDate_ = boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(unadjustedDateNode));}
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

   //adjustedDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* adjustedDateNode = xmlNode->FirstChildElement("adjustedDate");

   if(adjustedDateNode){adjustedDateIsNull_ = false;}
   else{adjustedDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- adjustedDateNode , address : " << adjustedDateNode << std::endl;
   #endif
   if(adjustedDateNode)
   {
      if(adjustedDateNode->Attribute("href") || adjustedDateNode->Attribute("id"))
      {
          if(adjustedDateNode->Attribute("id"))
          {
             adjustedDateIDRef_ = adjustedDateNode->Attribute("id");
             adjustedDate_ = boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(adjustedDateNode));
             adjustedDate_->setID(adjustedDateIDRef_);
             IDManager::instance().setID(adjustedDateIDRef_,adjustedDate_);
          }
          else if(adjustedDateNode->Attribute("href")) { adjustedDateIDRef_ = adjustedDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { adjustedDate_ = boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(adjustedDateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<IdentifiedDate> AdjustableOrAdjustedDate::getUnadjustedDate()
{
   if(!this->unadjustedDateIsNull_){
        if(unadjustedDateIDRef_ != ""){
             return boost::shared_static_cast<IdentifiedDate>(IDManager::instance().getID(unadjustedDateIDRef_));
        }else{
             return this->unadjustedDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IdentifiedDate>();
   }
}
boost::shared_ptr<BusinessDayAdjustments> AdjustableOrAdjustedDate::getDateAdjustments()
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
boost::shared_ptr<IdentifiedDate> AdjustableOrAdjustedDate::getAdjustedDate()
{
   if(!this->adjustedDateIsNull_){
        if(adjustedDateIDRef_ != ""){
             return boost::shared_static_cast<IdentifiedDate>(IDManager::instance().getID(adjustedDateIDRef_));
        }else{
             return this->adjustedDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IdentifiedDate>();
   }
}
}

