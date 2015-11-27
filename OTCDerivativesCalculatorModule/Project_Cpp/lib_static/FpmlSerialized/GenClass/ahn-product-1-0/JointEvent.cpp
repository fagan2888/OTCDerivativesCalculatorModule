// JointEvent.cpp 
#include "JointEvent.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

JointEvent::JointEvent(TiXmlNode* xmlNode)
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

   //functionsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* functionsNode = xmlNode->FirstChildElement("functions");

   if(functionsNode){functionsIsNull_ = false;}
   else{functionsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- functionsNode , address : " << functionsNode << std::endl;
   #endif
   if(functionsNode)
   {
      if(functionsNode->Attribute("href") || functionsNode->Attribute("id"))
      {
          if(functionsNode->Attribute("id"))
          {
             functionsIDRef_ = functionsNode->Attribute("id");
             functions_ = boost::shared_ptr<Functions>(new Functions(functionsNode));
             functions_->setID(functionsIDRef_);
             IDManager::instance().setID(functionsIDRef_,functions_);
          }
          else if(functionsNode->Attribute("href")) { functionsIDRef_ = functionsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { functions_ = boost::shared_ptr<Functions>(new Functions(functionsNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<JointTypeEnum> JointEvent::getJointType()
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
boost::shared_ptr<Functions> JointEvent::getFunctions()
{
   if(!this->functionsIsNull_){
        if(functionsIDRef_ != ""){
             return boost::shared_static_cast<Functions>(IDManager::instance().getID(functionsIDRef_));
        }else{
             return this->functions_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Functions>();
   }
}
}

