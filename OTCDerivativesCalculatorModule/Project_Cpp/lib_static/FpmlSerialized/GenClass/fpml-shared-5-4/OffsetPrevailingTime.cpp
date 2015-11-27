// OffsetPrevailingTime.cpp 
#include "OffsetPrevailingTime.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

OffsetPrevailingTime::OffsetPrevailingTime(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //timeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* timeNode = xmlNode->FirstChildElement("time");

   if(timeNode){timeIsNull_ = false;}
   else{timeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- timeNode , address : " << timeNode << std::endl;
   #endif
   if(timeNode)
   {
      if(timeNode->Attribute("href") || timeNode->Attribute("id"))
      {
          if(timeNode->Attribute("id"))
          {
             timeIDRef_ = timeNode->Attribute("id");
             time_ = boost::shared_ptr<PrevailingTime>(new PrevailingTime(timeNode));
             time_->setID(timeIDRef_);
             IDManager::instance().setID(timeIDRef_,time_);
          }
          else if(timeNode->Attribute("href")) { timeIDRef_ = timeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { time_ = boost::shared_ptr<PrevailingTime>(new PrevailingTime(timeNode));}
   }

   //offsetNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* offsetNode = xmlNode->FirstChildElement("offset");

   if(offsetNode){offsetIsNull_ = false;}
   else{offsetIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- offsetNode , address : " << offsetNode << std::endl;
   #endif
   if(offsetNode)
   {
      if(offsetNode->Attribute("href") || offsetNode->Attribute("id"))
      {
          if(offsetNode->Attribute("id"))
          {
             offsetIDRef_ = offsetNode->Attribute("id");
             offset_ = boost::shared_ptr<Offset>(new Offset(offsetNode));
             offset_->setID(offsetIDRef_);
             IDManager::instance().setID(offsetIDRef_,offset_);
          }
          else if(offsetNode->Attribute("href")) { offsetIDRef_ = offsetNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { offset_ = boost::shared_ptr<Offset>(new Offset(offsetNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PrevailingTime> OffsetPrevailingTime::getTime()
{
   if(!this->timeIsNull_){
        if(timeIDRef_ != ""){
             return boost::shared_static_cast<PrevailingTime>(IDManager::instance().getID(timeIDRef_));
        }else{
             return this->time_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PrevailingTime>();
   }
}
boost::shared_ptr<Offset> OffsetPrevailingTime::getOffset()
{
   if(!this->offsetIsNull_){
        if(offsetIDRef_ != ""){
             return boost::shared_static_cast<Offset>(IDManager::instance().getID(offsetIDRef_));
        }else{
             return this->offset_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Offset>();
   }
}
}

