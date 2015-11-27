// JointFSubEvent.cpp 
#include "JointFSubEvent.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

JointFSubEvent::JointFSubEvent(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //jointTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* jointTypeNode = xmlNode->FirstChildElement("jointType");

   if(jointTypeNode){jointTypeIsNull_ = false;}
   else{jointTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- jointTypeNode , address : " << jointTypeNode << std::endl;
   #endif
   if(jointTypeNode)
   {
      if(jointTypeNode->Attribute("href") || jointTypeNode->Attribute("id"))
      {
          if(jointTypeNode->Attribute("id"))
          {
             jointTypeIDRef_ = jointTypeNode->Attribute("id");
             jointType_ = boost::shared_ptr<JointTypeEnum>(new JointTypeEnum(jointTypeNode));
             jointType_->setID(jointTypeIDRef_);
             IDManager::instance().setID(jointTypeIDRef_,jointType_);
          }
          else if(jointTypeNode->Attribute("href")) { jointTypeIDRef_ = jointTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { jointType_ = boost::shared_ptr<JointTypeEnum>(new JointTypeEnum(jointTypeNode));}
   }

   //mainEventNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* mainEventNode = xmlNode->FirstChildElement("mainEvent");

   if(mainEventNode){mainEventIsNull_ = false;}
   else{mainEventIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- mainEventNode , address : " << mainEventNode << std::endl;
   #endif
   if(mainEventNode)
   {
      if(mainEventNode->Attribute("href") || mainEventNode->Attribute("id"))
      {
          if(mainEventNode->Attribute("id"))
          {
             mainEventIDRef_ = mainEventNode->Attribute("id");
             mainEvent_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(mainEventNode));
             mainEvent_->setID(mainEventIDRef_);
             IDManager::instance().setID(mainEventIDRef_,mainEvent_);
          }
          else if(mainEventNode->Attribute("href")) { mainEventIDRef_ = mainEventNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { mainEvent_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(mainEventNode));}
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
             subEvent_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(subEventNode));
             subEvent_->setID(subEventIDRef_);
             IDManager::instance().setID(subEventIDRef_,subEvent_);
          }
          else if(subEventNode->Attribute("href")) { subEventIDRef_ = subEventNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { subEvent_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(subEventNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<JointTypeEnum> JointFSubEvent::getJointType()
{
   if(!this->jointTypeIsNull_){
        if(jointTypeIDRef_ != ""){
             return boost::shared_static_cast<JointTypeEnum>(IDManager::instance().getID(jointTypeIDRef_));
        }else{
             return this->jointType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<JointTypeEnum>();
   }
}
boost::shared_ptr<XsdTypeBoolean> JointFSubEvent::getMainEvent()
{
   if(!this->mainEventIsNull_){
        if(mainEventIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(mainEventIDRef_));
        }else{
             return this->mainEvent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> JointFSubEvent::getSubEvent()
{
   if(!this->subEventIsNull_){
        if(subEventIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(subEventIDRef_));
        }else{
             return this->subEvent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

