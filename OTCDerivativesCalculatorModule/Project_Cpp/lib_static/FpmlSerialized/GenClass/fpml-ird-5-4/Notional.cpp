// Notional.cpp 
#include "Notional.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Notional::Notional(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //notionalStepScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notionalStepScheduleNode = xmlNode->FirstChildElement("notionalStepSchedule");

   if(notionalStepScheduleNode){notionalStepScheduleIsNull_ = false;}
   else{notionalStepScheduleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notionalStepScheduleNode , address : " << notionalStepScheduleNode << std::endl;
   #endif
   if(notionalStepScheduleNode)
   {
      if(notionalStepScheduleNode->Attribute("href") || notionalStepScheduleNode->Attribute("id"))
      {
          if(notionalStepScheduleNode->Attribute("id"))
          {
             notionalStepScheduleIDRef_ = notionalStepScheduleNode->Attribute("id");
             notionalStepSchedule_ = boost::shared_ptr<NonNegativeAmountSchedule>(new NonNegativeAmountSchedule(notionalStepScheduleNode));
             notionalStepSchedule_->setID(notionalStepScheduleIDRef_);
             IDManager::instance().setID(notionalStepScheduleIDRef_,notionalStepSchedule_);
          }
          else if(notionalStepScheduleNode->Attribute("href")) { notionalStepScheduleIDRef_ = notionalStepScheduleNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notionalStepSchedule_ = boost::shared_ptr<NonNegativeAmountSchedule>(new NonNegativeAmountSchedule(notionalStepScheduleNode));}
   }

   //notionalStepParametersNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notionalStepParametersNode = xmlNode->FirstChildElement("notionalStepParameters");

   if(notionalStepParametersNode){notionalStepParametersIsNull_ = false;}
   else{notionalStepParametersIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notionalStepParametersNode , address : " << notionalStepParametersNode << std::endl;
   #endif
   if(notionalStepParametersNode)
   {
      if(notionalStepParametersNode->Attribute("href") || notionalStepParametersNode->Attribute("id"))
      {
          if(notionalStepParametersNode->Attribute("id"))
          {
             notionalStepParametersIDRef_ = notionalStepParametersNode->Attribute("id");
             notionalStepParameters_ = boost::shared_ptr<NotionalStepRule>(new NotionalStepRule(notionalStepParametersNode));
             notionalStepParameters_->setID(notionalStepParametersIDRef_);
             IDManager::instance().setID(notionalStepParametersIDRef_,notionalStepParameters_);
          }
          else if(notionalStepParametersNode->Attribute("href")) { notionalStepParametersIDRef_ = notionalStepParametersNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notionalStepParameters_ = boost::shared_ptr<NotionalStepRule>(new NotionalStepRule(notionalStepParametersNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<NonNegativeAmountSchedule> Notional::getNotionalStepSchedule()
{
   if(!this->notionalStepScheduleIsNull_){
        if(notionalStepScheduleIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeAmountSchedule>(IDManager::instance().getID(notionalStepScheduleIDRef_));
        }else{
             return this->notionalStepSchedule_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeAmountSchedule>();
   }
}
boost::shared_ptr<NotionalStepRule> Notional::getNotionalStepParameters()
{
   if(!this->notionalStepParametersIsNull_){
        if(notionalStepParametersIDRef_ != ""){
             return boost::shared_static_cast<NotionalStepRule>(IDManager::instance().getID(notionalStepParametersIDRef_));
        }else{
             return this->notionalStepParameters_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NotionalStepRule>();
   }
}
}

