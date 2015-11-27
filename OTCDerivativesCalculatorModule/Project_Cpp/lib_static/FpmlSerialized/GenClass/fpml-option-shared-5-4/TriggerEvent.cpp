// TriggerEvent.cpp 
#include "TriggerEvent.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

TriggerEvent::TriggerEvent(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //scheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* scheduleNode = xmlNode->FirstChildElement("schedule");

   if(scheduleNode){scheduleIsNull_ = false;}
   else{scheduleIsNull_ = true;}

   if(scheduleNode)
   {
      for(scheduleNode; scheduleNode; scheduleNode = scheduleNode->NextSiblingElement("schedule")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- scheduleNode , address : " << scheduleNode << std::endl;
          #endif
          if(scheduleNode->Attribute("href") || scheduleNode->Attribute("id"))
          {
              if(scheduleNode->Attribute("id"))
              {
                  scheduleIDRef_ = scheduleNode->Attribute("id");
                  schedule_.push_back(boost::shared_ptr<AveragingSchedule>(new AveragingSchedule(scheduleNode)));
                  schedule_.back()->setID(scheduleIDRef_);
                  IDManager::instance().setID(scheduleIDRef_, schedule_.back());
              }
              else if(scheduleNode->Attribute("href")) { scheduleIDRef_ = scheduleNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { schedule_.push_back(boost::shared_ptr<AveragingSchedule>(new AveragingSchedule(scheduleNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- scheduleNode , address : " << scheduleNode << std::endl;
       #endif
   }

   //triggerDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* triggerDatesNode = xmlNode->FirstChildElement("triggerDates");

   if(triggerDatesNode){triggerDatesIsNull_ = false;}
   else{triggerDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- triggerDatesNode , address : " << triggerDatesNode << std::endl;
   #endif
   if(triggerDatesNode)
   {
      if(triggerDatesNode->Attribute("href") || triggerDatesNode->Attribute("id"))
      {
          if(triggerDatesNode->Attribute("id"))
          {
             triggerDatesIDRef_ = triggerDatesNode->Attribute("id");
             triggerDates_ = boost::shared_ptr<DateList>(new DateList(triggerDatesNode));
             triggerDates_->setID(triggerDatesIDRef_);
             IDManager::instance().setID(triggerDatesIDRef_,triggerDates_);
          }
          else if(triggerDatesNode->Attribute("href")) { triggerDatesIDRef_ = triggerDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { triggerDates_ = boost::shared_ptr<DateList>(new DateList(triggerDatesNode));}
   }

   //triggerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* triggerNode = xmlNode->FirstChildElement("trigger");

   if(triggerNode){triggerIsNull_ = false;}
   else{triggerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- triggerNode , address : " << triggerNode << std::endl;
   #endif
   if(triggerNode)
   {
      if(triggerNode->Attribute("href") || triggerNode->Attribute("id"))
      {
          if(triggerNode->Attribute("id"))
          {
             triggerIDRef_ = triggerNode->Attribute("id");
             trigger_ = boost::shared_ptr<Trigger>(new Trigger(triggerNode));
             trigger_->setID(triggerIDRef_);
             IDManager::instance().setID(triggerIDRef_,trigger_);
          }
          else if(triggerNode->Attribute("href")) { triggerIDRef_ = triggerNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { trigger_ = boost::shared_ptr<Trigger>(new Trigger(triggerNode));}
   }

   //featurePaymentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* featurePaymentNode = xmlNode->FirstChildElement("featurePayment");

   if(featurePaymentNode){featurePaymentIsNull_ = false;}
   else{featurePaymentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- featurePaymentNode , address : " << featurePaymentNode << std::endl;
   #endif
   if(featurePaymentNode)
   {
      if(featurePaymentNode->Attribute("href") || featurePaymentNode->Attribute("id"))
      {
          if(featurePaymentNode->Attribute("id"))
          {
             featurePaymentIDRef_ = featurePaymentNode->Attribute("id");
             featurePayment_ = boost::shared_ptr<FeaturePayment>(new FeaturePayment(featurePaymentNode));
             featurePayment_->setID(featurePaymentIDRef_);
             IDManager::instance().setID(featurePaymentIDRef_,featurePayment_);
          }
          else if(featurePaymentNode->Attribute("href")) { featurePaymentIDRef_ = featurePaymentNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { featurePayment_ = boost::shared_ptr<FeaturePayment>(new FeaturePayment(featurePaymentNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<AveragingSchedule>> TriggerEvent::getSchedule()
{
   if(!this->scheduleIsNull_){
        if(scheduleIDRef_ != ""){
             return this->schedule_;
        }else{
             return this->schedule_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<AveragingSchedule>>();
   }
}
boost::shared_ptr<DateList> TriggerEvent::getTriggerDates()
{
   if(!this->triggerDatesIsNull_){
        if(triggerDatesIDRef_ != ""){
             return boost::shared_static_cast<DateList>(IDManager::instance().getID(triggerDatesIDRef_));
        }else{
             return this->triggerDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DateList>();
   }
}
boost::shared_ptr<Trigger> TriggerEvent::getTrigger()
{
   if(!this->triggerIsNull_){
        if(triggerIDRef_ != ""){
             return boost::shared_static_cast<Trigger>(IDManager::instance().getID(triggerIDRef_));
        }else{
             return this->trigger_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Trigger>();
   }
}
boost::shared_ptr<FeaturePayment> TriggerEvent::getFeaturePayment()
{
   if(!this->featurePaymentIsNull_){
        if(featurePaymentIDRef_ != ""){
             return boost::shared_static_cast<FeaturePayment>(IDManager::instance().getID(featurePaymentIDRef_));
        }else{
             return this->featurePayment_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FeaturePayment>();
   }
}
}

