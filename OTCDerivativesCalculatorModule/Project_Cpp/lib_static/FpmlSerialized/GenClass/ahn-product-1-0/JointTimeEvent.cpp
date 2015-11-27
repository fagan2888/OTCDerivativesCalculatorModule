// JointTimeEvent.cpp 
#include "JointTimeEvent.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

JointTimeEvent::JointTimeEvent(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //triggerAtleastNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* triggerAtleastNode = xmlNode->FirstChildElement("triggerAtleast");

   if(triggerAtleastNode){triggerAtleastIsNull_ = false;}
   else{triggerAtleastIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- triggerAtleastNode , address : " << triggerAtleastNode << std::endl;
   #endif
   if(triggerAtleastNode)
   {
      if(triggerAtleastNode->Attribute("href") || triggerAtleastNode->Attribute("id"))
      {
          if(triggerAtleastNode->Attribute("id"))
          {
             triggerAtleastIDRef_ = triggerAtleastNode->Attribute("id");
             triggerAtleast_ = boost::shared_ptr<TriggerAtleast>(new TriggerAtleast(triggerAtleastNode));
             triggerAtleast_->setID(triggerAtleastIDRef_);
             IDManager::instance().setID(triggerAtleastIDRef_,triggerAtleast_);
          }
          else if(triggerAtleastNode->Attribute("href")) { triggerAtleastIDRef_ = triggerAtleastNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { triggerAtleast_ = boost::shared_ptr<TriggerAtleast>(new TriggerAtleast(triggerAtleastNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<TriggerAtleast> JointTimeEvent::getTriggerAtleast()
{
   if(!this->triggerAtleastIsNull_){
        if(triggerAtleastIDRef_ != ""){
             return boost::shared_static_cast<TriggerAtleast>(IDManager::instance().getID(triggerAtleastIDRef_));
        }else{
             return this->triggerAtleast_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TriggerAtleast>();
   }
}
}

