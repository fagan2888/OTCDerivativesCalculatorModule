// FunctionEvents.cpp 
#include "FunctionEvents.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FunctionEvents::FunctionEvents(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //eventFunctionMNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* eventFunctionMNode = xmlNode->FirstChildElement("eventFunctionM");

   if(eventFunctionMNode){eventFunctionMIsNull_ = false;}
   else{eventFunctionMIsNull_ = true;}

   if(eventFunctionMNode)
   {
      for(eventFunctionMNode; eventFunctionMNode; eventFunctionMNode = eventFunctionMNode->NextSiblingElement("eventFunctionM")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eventFunctionMNode , address : " << eventFunctionMNode << std::endl;
          #endif
          if(eventFunctionMNode->Attribute("href") || eventFunctionMNode->Attribute("id"))
          {
              if(eventFunctionMNode->Attribute("id"))
              {
                  eventFunctionMIDRef_ = eventFunctionMNode->Attribute("id");
                  eventFunctionM_.push_back(boost::shared_ptr<EventFunctionM>(new EventFunctionM(eventFunctionMNode)));
                  eventFunctionM_.back()->setID(eventFunctionMIDRef_);
                  IDManager::instance().setID(eventFunctionMIDRef_, eventFunctionM_.back());
              }
              else if(eventFunctionMNode->Attribute("href")) { eventFunctionMIDRef_ = eventFunctionMNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { eventFunctionM_.push_back(boost::shared_ptr<EventFunctionM>(new EventFunctionM(eventFunctionMNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eventFunctionMNode , address : " << eventFunctionMNode << std::endl;
       #endif
   }

   //jointFunctionEventNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* jointFunctionEventNode = xmlNode->FirstChildElement("jointFunctionEvent");

   if(jointFunctionEventNode){jointFunctionEventIsNull_ = false;}
   else{jointFunctionEventIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- jointFunctionEventNode , address : " << jointFunctionEventNode << std::endl;
   #endif
   if(jointFunctionEventNode)
   {
      if(jointFunctionEventNode->Attribute("href") || jointFunctionEventNode->Attribute("id"))
      {
          if(jointFunctionEventNode->Attribute("id"))
          {
             jointFunctionEventIDRef_ = jointFunctionEventNode->Attribute("id");
             jointFunctionEvent_ = boost::shared_ptr<JointFunctionEvent>(new JointFunctionEvent(jointFunctionEventNode));
             jointFunctionEvent_->setID(jointFunctionEventIDRef_);
             IDManager::instance().setID(jointFunctionEventIDRef_,jointFunctionEvent_);
          }
          else if(jointFunctionEventNode->Attribute("href")) { jointFunctionEventIDRef_ = jointFunctionEventNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { jointFunctionEvent_ = boost::shared_ptr<JointFunctionEvent>(new JointFunctionEvent(jointFunctionEventNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<EventFunctionM>> FunctionEvents::getEventFunctionM()
{
   if(!this->eventFunctionMIsNull_){
        if(eventFunctionMIDRef_ != ""){
             return this->eventFunctionM_;
        }else{
             return this->eventFunctionM_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<EventFunctionM>>();
   }
}
boost::shared_ptr<JointFunctionEvent> FunctionEvents::getJointFunctionEvent()
{
   if(!this->jointFunctionEventIsNull_){
        if(jointFunctionEventIDRef_ != ""){
             return boost::shared_static_cast<JointFunctionEvent>(IDManager::instance().getID(jointFunctionEventIDRef_));
        }else{
             return this->jointFunctionEvent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<JointFunctionEvent>();
   }
}
}

