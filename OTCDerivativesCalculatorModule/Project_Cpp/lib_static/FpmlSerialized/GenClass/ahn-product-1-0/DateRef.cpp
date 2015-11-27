// DateRef.cpp 
#include "DateRef.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

DateRef::DateRef(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //eventDateRefNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* eventDateRefNode = xmlNode->FirstChildElement("eventDateRef");

   if(eventDateRefNode){eventDateRefIsNull_ = false;}
   else{eventDateRefIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eventDateRefNode , address : " << eventDateRefNode << std::endl;
   #endif
   if(eventDateRefNode)
   {
      if(eventDateRefNode->Attribute("href") || eventDateRefNode->Attribute("id"))
      {
          if(eventDateRefNode->Attribute("id"))
          {
             eventDateRefIDRef_ = eventDateRefNode->Attribute("id");
             eventDateRef_ = boost::shared_ptr<EventDate>(new EventDate(eventDateRefNode));
             eventDateRef_->setID(eventDateRefIDRef_);
             IDManager::instance().setID(eventDateRefIDRef_,eventDateRef_);
          }
          else if(eventDateRefNode->Attribute("href")) { eventDateRefIDRef_ = eventDateRefNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { eventDateRef_ = boost::shared_ptr<EventDate>(new EventDate(eventDateRefNode));}
   }

   //fixingDaysNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixingDaysNode = xmlNode->FirstChildElement("fixingDays");

   if(fixingDaysNode){fixingDaysIsNull_ = false;}
   else{fixingDaysIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixingDaysNode , address : " << fixingDaysNode << std::endl;
   #endif
   if(fixingDaysNode)
   {
      if(fixingDaysNode->Attribute("href") || fixingDaysNode->Attribute("id"))
      {
          if(fixingDaysNode->Attribute("id"))
          {
             fixingDaysIDRef_ = fixingDaysNode->Attribute("id");
             fixingDays_ = boost::shared_ptr<FixingDays>(new FixingDays(fixingDaysNode));
             fixingDays_->setID(fixingDaysIDRef_);
             IDManager::instance().setID(fixingDaysIDRef_,fixingDays_);
          }
          else if(fixingDaysNode->Attribute("href")) { fixingDaysIDRef_ = fixingDaysNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fixingDays_ = boost::shared_ptr<FixingDays>(new FixingDays(fixingDaysNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<EventDate> DateRef::getEventDateRef()
{
   if(!this->eventDateRefIsNull_){
        if(eventDateRefIDRef_ != ""){
             return boost::shared_static_cast<EventDate>(IDManager::instance().getID(eventDateRefIDRef_));
        }else{
             return this->eventDateRef_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EventDate>();
   }
}
boost::shared_ptr<FixingDays> DateRef::getFixingDays()
{
   if(!this->fixingDaysIsNull_){
        if(fixingDaysIDRef_ != ""){
             return boost::shared_static_cast<FixingDays>(IDManager::instance().getID(fixingDaysIDRef_));
        }else{
             return this->fixingDays_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FixingDays>();
   }
}
}

