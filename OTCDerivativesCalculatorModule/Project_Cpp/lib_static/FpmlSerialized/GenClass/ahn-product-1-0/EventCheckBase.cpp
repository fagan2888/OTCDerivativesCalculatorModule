// EventCheckBase.cpp 
#include "EventCheckBase.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EventCheckBase::EventCheckBase(TiXmlNode* xmlNode)
: IEventCheck(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //eventIndexTransformationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* eventIndexTransformationNode = xmlNode->FirstChildElement("eventIndexTransformation");

   if(eventIndexTransformationNode){eventIndexTransformationIsNull_ = false;}
   else{eventIndexTransformationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eventIndexTransformationNode , address : " << eventIndexTransformationNode << std::endl;
   #endif
   if(eventIndexTransformationNode)
   {
      if(eventIndexTransformationNode->Attribute("href") || eventIndexTransformationNode->Attribute("id"))
      {
          if(eventIndexTransformationNode->Attribute("id"))
          {
             eventIndexTransformationIDRef_ = eventIndexTransformationNode->Attribute("id");
             eventIndexTransformation_ = boost::shared_ptr<EventIndexTransformation>(new EventIndexTransformation(eventIndexTransformationNode));
             eventIndexTransformation_->setID(eventIndexTransformationIDRef_);
             IDManager::instance().setID(eventIndexTransformationIDRef_,eventIndexTransformation_);
          }
          else if(eventIndexTransformationNode->Attribute("href")) { eventIndexTransformationIDRef_ = eventIndexTransformationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { eventIndexTransformation_ = boost::shared_ptr<EventIndexTransformation>(new EventIndexTransformation(eventIndexTransformationNode));}
   }

   //functionEventsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* functionEventsNode = xmlNode->FirstChildElement("functionEvents");

   if(functionEventsNode){functionEventsIsNull_ = false;}
   else{functionEventsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- functionEventsNode , address : " << functionEventsNode << std::endl;
   #endif
   if(functionEventsNode)
   {
      if(functionEventsNode->Attribute("href") || functionEventsNode->Attribute("id"))
      {
          if(functionEventsNode->Attribute("id"))
          {
             functionEventsIDRef_ = functionEventsNode->Attribute("id");
             functionEvents_ = boost::shared_ptr<FunctionEvents>(new FunctionEvents(functionEventsNode));
             functionEvents_->setID(functionEventsIDRef_);
             IDManager::instance().setID(functionEventsIDRef_,functionEvents_);
          }
          else if(functionEventsNode->Attribute("href")) { functionEventsIDRef_ = functionEventsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { functionEvents_ = boost::shared_ptr<FunctionEvents>(new FunctionEvents(functionEventsNode));}
   }

   //payoffBaseNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* payoffBaseNode = xmlNode->FirstChildElement("payoffBase");

   if(payoffBaseNode){payoffBaseIsNull_ = false;}
   else{payoffBaseIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- payoffBaseNode , address : " << payoffBaseNode << std::endl;
   #endif
   if(payoffBaseNode)
   {
      if(payoffBaseNode->Attribute("href") || payoffBaseNode->Attribute("id"))
      {
          if(payoffBaseNode->Attribute("id"))
          {
             payoffBaseIDRef_ = payoffBaseNode->Attribute("id");
             payoffBase_ = boost::shared_ptr<PayoffBase>(new PayoffBase(payoffBaseNode));
             payoffBase_->setID(payoffBaseIDRef_);
             IDManager::instance().setID(payoffBaseIDRef_,payoffBase_);
          }
          else if(payoffBaseNode->Attribute("href")) { payoffBaseIDRef_ = payoffBaseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { payoffBase_ = boost::shared_ptr<PayoffBase>(new PayoffBase(payoffBaseNode));}
   }

   //subEventNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* subEventNode = xmlNode->FirstChildElement("subEvent");

   if(subEventNode){subEventIsNull_ = false;}
   else{subEventIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- subEventNode , address : " << subEventNode << std::endl;
   #endif
   if(subEventNode)
   {
      if(subEventNode->Attribute("href") || subEventNode->Attribute("id"))
      {
          if(subEventNode->Attribute("id"))
          {
             subEventIDRef_ = subEventNode->Attribute("id");
             subEvent_ = boost::shared_ptr<SubEvent>(new SubEvent(subEventNode));
             subEvent_->setID(subEventIDRef_);
             IDManager::instance().setID(subEventIDRef_,subEvent_);
          }
          else if(subEventNode->Attribute("href")) { subEventIDRef_ = subEventNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { subEvent_ = boost::shared_ptr<SubEvent>(new SubEvent(subEventNode));}
   }

   //jointSubEventNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* jointSubEventNode = xmlNode->FirstChildElement("jointSubEvent");

   if(jointSubEventNode){jointSubEventIsNull_ = false;}
   else{jointSubEventIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- jointSubEventNode , address : " << jointSubEventNode << std::endl;
   #endif
   if(jointSubEventNode)
   {
      if(jointSubEventNode->Attribute("href") || jointSubEventNode->Attribute("id"))
      {
          if(jointSubEventNode->Attribute("id"))
          {
             jointSubEventIDRef_ = jointSubEventNode->Attribute("id");
             jointSubEvent_ = boost::shared_ptr<JointSubEvent>(new JointSubEvent(jointSubEventNode));
             jointSubEvent_->setID(jointSubEventIDRef_);
             IDManager::instance().setID(jointSubEventIDRef_,jointSubEvent_);
          }
          else if(jointSubEventNode->Attribute("href")) { jointSubEventIDRef_ = jointSubEventNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { jointSubEvent_ = boost::shared_ptr<JointSubEvent>(new JointSubEvent(jointSubEventNode));}
   }

   //jointFSubEventNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* jointFSubEventNode = xmlNode->FirstChildElement("jointFSubEvent");

   if(jointFSubEventNode){jointFSubEventIsNull_ = false;}
   else{jointFSubEventIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- jointFSubEventNode , address : " << jointFSubEventNode << std::endl;
   #endif
   if(jointFSubEventNode)
   {
      if(jointFSubEventNode->Attribute("href") || jointFSubEventNode->Attribute("id"))
      {
          if(jointFSubEventNode->Attribute("id"))
          {
             jointFSubEventIDRef_ = jointFSubEventNode->Attribute("id");
             jointFSubEvent_ = boost::shared_ptr<JointFSubEvent>(new JointFSubEvent(jointFSubEventNode));
             jointFSubEvent_->setID(jointFSubEventIDRef_);
             IDManager::instance().setID(jointFSubEventIDRef_,jointFSubEvent_);
          }
          else if(jointFSubEventNode->Attribute("href")) { jointFSubEventIDRef_ = jointFSubEventNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { jointFSubEvent_ = boost::shared_ptr<JointFSubEvent>(new JointFSubEvent(jointFSubEventNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<EventIndexTransformation> EventCheckBase::getEventIndexTransformation()
{
   if(!this->eventIndexTransformationIsNull_){
        if(eventIndexTransformationIDRef_ != ""){
             return boost::shared_static_cast<EventIndexTransformation>(IDManager::instance().getID(eventIndexTransformationIDRef_));
        }else{
             return this->eventIndexTransformation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EventIndexTransformation>();
   }
}
boost::shared_ptr<FunctionEvents> EventCheckBase::getFunctionEvents()
{
   if(!this->functionEventsIsNull_){
        if(functionEventsIDRef_ != ""){
             return boost::shared_static_cast<FunctionEvents>(IDManager::instance().getID(functionEventsIDRef_));
        }else{
             return this->functionEvents_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FunctionEvents>();
   }
}
boost::shared_ptr<PayoffBase> EventCheckBase::getPayoffBase()
{
   if(!this->payoffBaseIsNull_){
        if(payoffBaseIDRef_ != ""){
             return boost::shared_static_cast<PayoffBase>(IDManager::instance().getID(payoffBaseIDRef_));
        }else{
             return this->payoffBase_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PayoffBase>();
   }
}
boost::shared_ptr<SubEvent> EventCheckBase::getSubEvent()
{
   if(!this->subEventIsNull_){
        if(subEventIDRef_ != ""){
             return boost::shared_static_cast<SubEvent>(IDManager::instance().getID(subEventIDRef_));
        }else{
             return this->subEvent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SubEvent>();
   }
}
boost::shared_ptr<JointSubEvent> EventCheckBase::getJointSubEvent()
{
   if(!this->jointSubEventIsNull_){
        if(jointSubEventIDRef_ != ""){
             return boost::shared_static_cast<JointSubEvent>(IDManager::instance().getID(jointSubEventIDRef_));
        }else{
             return this->jointSubEvent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<JointSubEvent>();
   }
}
boost::shared_ptr<JointFSubEvent> EventCheckBase::getJointFSubEvent()
{
   if(!this->jointFSubEventIsNull_){
        if(jointFSubEventIDRef_ != ""){
             return boost::shared_static_cast<JointFSubEvent>(IDManager::instance().getID(jointFSubEventIDRef_));
        }else{
             return this->jointFSubEvent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<JointFSubEvent>();
   }
}
}

