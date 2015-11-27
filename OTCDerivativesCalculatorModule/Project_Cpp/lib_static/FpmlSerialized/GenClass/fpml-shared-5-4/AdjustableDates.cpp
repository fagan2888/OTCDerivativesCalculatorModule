// AdjustableDates.cpp 
#include "AdjustableDates.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

AdjustableDates::AdjustableDates(TiXmlNode* xmlNode)
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

   if(unadjustedDateNode)
   {
      for(unadjustedDateNode; unadjustedDateNode; unadjustedDateNode = unadjustedDateNode->NextSiblingElement("unadjustedDate")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- unadjustedDateNode , address : " << unadjustedDateNode << std::endl;
          #endif
          if(unadjustedDateNode->Attribute("href") || unadjustedDateNode->Attribute("id"))
          {
              if(unadjustedDateNode->Attribute("id"))
              {
                  unadjustedDateIDRef_ = unadjustedDateNode->Attribute("id");
                  unadjustedDate_.push_back(boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(unadjustedDateNode)));
                  unadjustedDate_.back()->setID(unadjustedDateIDRef_);
                  IDManager::instance().setID(unadjustedDateIDRef_, unadjustedDate_.back());
              }
              else if(unadjustedDateNode->Attribute("href")) { unadjustedDateIDRef_ = unadjustedDateNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { unadjustedDate_.push_back(boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(unadjustedDateNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- unadjustedDateNode , address : " << unadjustedDateNode << std::endl;
       #endif
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

   if(adjustedDateNode)
   {
      for(adjustedDateNode; adjustedDateNode; adjustedDateNode = adjustedDateNode->NextSiblingElement("adjustedDate")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- adjustedDateNode , address : " << adjustedDateNode << std::endl;
          #endif
          if(adjustedDateNode->Attribute("href") || adjustedDateNode->Attribute("id"))
          {
              if(adjustedDateNode->Attribute("id"))
              {
                  adjustedDateIDRef_ = adjustedDateNode->Attribute("id");
                  adjustedDate_.push_back(boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(adjustedDateNode)));
                  adjustedDate_.back()->setID(adjustedDateIDRef_);
                  IDManager::instance().setID(adjustedDateIDRef_, adjustedDate_.back());
              }
              else if(adjustedDateNode->Attribute("href")) { adjustedDateIDRef_ = adjustedDateNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { adjustedDate_.push_back(boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(adjustedDateNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- adjustedDateNode , address : " << adjustedDateNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<IdentifiedDate>> AdjustableDates::getUnadjustedDate()
{
   if(!this->unadjustedDateIsNull_){
        if(unadjustedDateIDRef_ != ""){
             return this->unadjustedDate_;
        }else{
             return this->unadjustedDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<IdentifiedDate>>();
   }
}
boost::shared_ptr<BusinessDayAdjustments> AdjustableDates::getDateAdjustments()
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
std::vector<boost::shared_ptr<IdentifiedDate>> AdjustableDates::getAdjustedDate()
{
   if(!this->adjustedDateIsNull_){
        if(adjustedDateIDRef_ != ""){
             return this->adjustedDate_;
        }else{
             return this->adjustedDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<IdentifiedDate>>();
   }
}
}

