// AdjustableRelativeOrPeriodicDates.cpp 
#include "AdjustableRelativeOrPeriodicDates.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

AdjustableRelativeOrPeriodicDates::AdjustableRelativeOrPeriodicDates(TiXmlNode* xmlNode)
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

   //relativeDateSequenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* relativeDateSequenceNode = xmlNode->FirstChildElement("relativeDateSequence");

   if(relativeDateSequenceNode){relativeDateSequenceIsNull_ = false;}
   else{relativeDateSequenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- relativeDateSequenceNode , address : " << relativeDateSequenceNode << std::endl;
   #endif
   if(relativeDateSequenceNode)
   {
      if(relativeDateSequenceNode->Attribute("href") || relativeDateSequenceNode->Attribute("id"))
      {
          if(relativeDateSequenceNode->Attribute("id"))
          {
             relativeDateSequenceIDRef_ = relativeDateSequenceNode->Attribute("id");
             relativeDateSequence_ = boost::shared_ptr<RelativeDateSequence>(new RelativeDateSequence(relativeDateSequenceNode));
             relativeDateSequence_->setID(relativeDateSequenceIDRef_);
             IDManager::instance().setID(relativeDateSequenceIDRef_,relativeDateSequence_);
          }
          else if(relativeDateSequenceNode->Attribute("href")) { relativeDateSequenceIDRef_ = relativeDateSequenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { relativeDateSequence_ = boost::shared_ptr<RelativeDateSequence>(new RelativeDateSequence(relativeDateSequenceNode));}
   }

   //periodicDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* periodicDatesNode = xmlNode->FirstChildElement("periodicDates");

   if(periodicDatesNode){periodicDatesIsNull_ = false;}
   else{periodicDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- periodicDatesNode , address : " << periodicDatesNode << std::endl;
   #endif
   if(periodicDatesNode)
   {
      if(periodicDatesNode->Attribute("href") || periodicDatesNode->Attribute("id"))
      {
          if(periodicDatesNode->Attribute("id"))
          {
             periodicDatesIDRef_ = periodicDatesNode->Attribute("id");
             periodicDates_ = boost::shared_ptr<PeriodicDates>(new PeriodicDates(periodicDatesNode));
             periodicDates_->setID(periodicDatesIDRef_);
             IDManager::instance().setID(periodicDatesIDRef_,periodicDates_);
          }
          else if(periodicDatesNode->Attribute("href")) { periodicDatesIDRef_ = periodicDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { periodicDates_ = boost::shared_ptr<PeriodicDates>(new PeriodicDates(periodicDatesNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AdjustableDates> AdjustableRelativeOrPeriodicDates::getAdjustableDates()
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
boost::shared_ptr<RelativeDateSequence> AdjustableRelativeOrPeriodicDates::getRelativeDateSequence()
{
   if(!this->relativeDateSequenceIsNull_){
        if(relativeDateSequenceIDRef_ != ""){
             return boost::shared_static_cast<RelativeDateSequence>(IDManager::instance().getID(relativeDateSequenceIDRef_));
        }else{
             return this->relativeDateSequence_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RelativeDateSequence>();
   }
}
boost::shared_ptr<PeriodicDates> AdjustableRelativeOrPeriodicDates::getPeriodicDates()
{
   if(!this->periodicDatesIsNull_){
        if(periodicDatesIDRef_ != ""){
             return boost::shared_static_cast<PeriodicDates>(IDManager::instance().getID(periodicDatesIDRef_));
        }else{
             return this->periodicDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PeriodicDates>();
   }
}
}

