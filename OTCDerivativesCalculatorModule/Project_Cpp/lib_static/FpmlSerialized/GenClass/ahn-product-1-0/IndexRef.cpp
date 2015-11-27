// IndexRef.cpp 
#include "IndexRef.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

IndexRef::IndexRef(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //underlyingIndexRefNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* underlyingIndexRefNode = xmlNode->FirstChildElement("underlyingIndexRef");

   if(underlyingIndexRefNode){underlyingIndexRefIsNull_ = false;}
   else{underlyingIndexRefIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- underlyingIndexRefNode , address : " << underlyingIndexRefNode << std::endl;
   #endif
   if(underlyingIndexRefNode)
   {
      if(underlyingIndexRefNode->Attribute("href") || underlyingIndexRefNode->Attribute("id"))
      {
          if(underlyingIndexRefNode->Attribute("id"))
          {
             underlyingIndexRefIDRef_ = underlyingIndexRefNode->Attribute("id");
             underlyingIndexRef_ = boost::shared_ptr<UnderlyingIndex>(new UnderlyingIndex(underlyingIndexRefNode));
             underlyingIndexRef_->setID(underlyingIndexRefIDRef_);
             IDManager::instance().setID(underlyingIndexRefIDRef_,underlyingIndexRef_);
          }
          else if(underlyingIndexRefNode->Attribute("href")) { underlyingIndexRefIDRef_ = underlyingIndexRefNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { underlyingIndexRef_ = boost::shared_ptr<UnderlyingIndex>(new UnderlyingIndex(underlyingIndexRefNode));}
   }

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
boost::shared_ptr<UnderlyingIndex> IndexRef::getUnderlyingIndexRef()
{
   if(!this->underlyingIndexRefIsNull_){
        if(underlyingIndexRefIDRef_ != ""){
             return boost::shared_static_cast<UnderlyingIndex>(IDManager::instance().getID(underlyingIndexRefIDRef_));
        }else{
             return this->underlyingIndexRef_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<UnderlyingIndex>();
   }
}
boost::shared_ptr<EventDate> IndexRef::getEventDateRef()
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
boost::shared_ptr<FixingDays> IndexRef::getFixingDays()
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

