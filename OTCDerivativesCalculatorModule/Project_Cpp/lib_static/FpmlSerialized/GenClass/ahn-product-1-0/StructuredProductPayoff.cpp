// StructuredProductPayoff.cpp 
#include "StructuredProductPayoff.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

StructuredProductPayoff::StructuredProductPayoff(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //baseInformationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* baseInformationNode = xmlNode->FirstChildElement("baseInformation");

   if(baseInformationNode){baseInformationIsNull_ = false;}
   else{baseInformationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- baseInformationNode , address : " << baseInformationNode << std::endl;
   #endif
   if(baseInformationNode)
   {
      if(baseInformationNode->Attribute("href") || baseInformationNode->Attribute("id"))
      {
          if(baseInformationNode->Attribute("id"))
          {
             baseInformationIDRef_ = baseInformationNode->Attribute("id");
             baseInformation_ = boost::shared_ptr<BaseInformation>(new BaseInformation(baseInformationNode));
             baseInformation_->setID(baseInformationIDRef_);
             IDManager::instance().setID(baseInformationIDRef_,baseInformation_);
          }
          else if(baseInformationNode->Attribute("href")) { baseInformationIDRef_ = baseInformationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { baseInformation_ = boost::shared_ptr<BaseInformation>(new BaseInformation(baseInformationNode));}
   }

   //eventScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* eventScheduleNode = xmlNode->FirstChildElement("eventSchedule");

   if(eventScheduleNode){eventScheduleIsNull_ = false;}
   else{eventScheduleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eventScheduleNode , address : " << eventScheduleNode << std::endl;
   #endif
   if(eventScheduleNode)
   {
      if(eventScheduleNode->Attribute("href") || eventScheduleNode->Attribute("id"))
      {
          if(eventScheduleNode->Attribute("id"))
          {
             eventScheduleIDRef_ = eventScheduleNode->Attribute("id");
             eventSchedule_ = boost::shared_ptr<EventSchedule>(new EventSchedule(eventScheduleNode));
             eventSchedule_->setID(eventScheduleIDRef_);
             IDManager::instance().setID(eventScheduleIDRef_,eventSchedule_);
          }
          else if(eventScheduleNode->Attribute("href")) { eventScheduleIDRef_ = eventScheduleNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { eventSchedule_ = boost::shared_ptr<EventSchedule>(new EventSchedule(eventScheduleNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<BaseInformation> StructuredProductPayoff::getBaseInformation()
{
   if(!this->baseInformationIsNull_){
        if(baseInformationIDRef_ != ""){
             return boost::shared_static_cast<BaseInformation>(IDManager::instance().getID(baseInformationIDRef_));
        }else{
             return this->baseInformation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BaseInformation>();
   }
}
boost::shared_ptr<EventSchedule> StructuredProductPayoff::getEventSchedule()
{
   if(!this->eventScheduleIsNull_){
        if(eventScheduleIDRef_ != ""){
             return boost::shared_static_cast<EventSchedule>(IDManager::instance().getID(eventScheduleIDRef_));
        }else{
             return this->eventSchedule_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EventSchedule>();
   }
}
}

