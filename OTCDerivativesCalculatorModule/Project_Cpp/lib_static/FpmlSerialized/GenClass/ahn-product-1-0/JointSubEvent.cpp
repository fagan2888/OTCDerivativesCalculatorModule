// JointSubEvent.cpp 
#include "JointSubEvent.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

JointSubEvent::JointSubEvent(TiXmlNode* xmlNode)
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

   //subEventNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* subEventNode = xmlNode->FirstChildElement("subEvent");

   if(subEventNode){subEventIsNull_ = false;}
   else{subEventIsNull_ = true;}

   if(subEventNode)
   {
      for(subEventNode; subEventNode; subEventNode = subEventNode->NextSiblingElement("subEvent")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- subEventNode , address : " << subEventNode << std::endl;
          #endif
          if(subEventNode->Attribute("href") || subEventNode->Attribute("id"))
          {
              if(subEventNode->Attribute("id"))
              {
                  subEventIDRef_ = subEventNode->Attribute("id");
                  subEvent_.push_back(boost::shared_ptr<SubEvent>(new SubEvent(subEventNode)));
                  subEvent_.back()->setID(subEventIDRef_);
                  IDManager::instance().setID(subEventIDRef_, subEvent_.back());
              }
              else if(subEventNode->Attribute("href")) { subEventIDRef_ = subEventNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { subEvent_.push_back(boost::shared_ptr<SubEvent>(new SubEvent(subEventNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- subEventNode , address : " << subEventNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<JointTypeEnum> JointSubEvent::getJointType()
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
std::vector<boost::shared_ptr<SubEvent>> JointSubEvent::getSubEvent()
{
   if(!this->subEventIsNull_){
        if(subEventIDRef_ != ""){
             return this->subEvent_;
        }else{
             return this->subEvent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<SubEvent>>();
   }
}
}

