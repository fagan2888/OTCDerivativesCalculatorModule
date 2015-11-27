// SupervisorRegistration.cpp 
#include "SupervisorRegistration.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SupervisorRegistration::SupervisorRegistration(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //supervisoryBodyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* supervisoryBodyNode = xmlNode->FirstChildElement("supervisoryBody");

   if(supervisoryBodyNode){supervisoryBodyIsNull_ = false;}
   else{supervisoryBodyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- supervisoryBodyNode , address : " << supervisoryBodyNode << std::endl;
   #endif
   if(supervisoryBodyNode)
   {
      if(supervisoryBodyNode->Attribute("href") || supervisoryBodyNode->Attribute("id"))
      {
          if(supervisoryBodyNode->Attribute("id"))
          {
             supervisoryBodyIDRef_ = supervisoryBodyNode->Attribute("id");
             supervisoryBody_ = boost::shared_ptr<SupervisoryBody>(new SupervisoryBody(supervisoryBodyNode));
             supervisoryBody_->setID(supervisoryBodyIDRef_);
             IDManager::instance().setID(supervisoryBodyIDRef_,supervisoryBody_);
          }
          else if(supervisoryBodyNode->Attribute("href")) { supervisoryBodyIDRef_ = supervisoryBodyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { supervisoryBody_ = boost::shared_ptr<SupervisoryBody>(new SupervisoryBody(supervisoryBodyNode));}
   }

   //registrationNumberNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* registrationNumberNode = xmlNode->FirstChildElement("registrationNumber");

   if(registrationNumberNode){registrationNumberIsNull_ = false;}
   else{registrationNumberIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- registrationNumberNode , address : " << registrationNumberNode << std::endl;
   #endif
   if(registrationNumberNode)
   {
      if(registrationNumberNode->Attribute("href") || registrationNumberNode->Attribute("id"))
      {
          if(registrationNumberNode->Attribute("id"))
          {
             registrationNumberIDRef_ = registrationNumberNode->Attribute("id");
             registrationNumber_ = boost::shared_ptr<RegulatorId>(new RegulatorId(registrationNumberNode));
             registrationNumber_->setID(registrationNumberIDRef_);
             IDManager::instance().setID(registrationNumberIDRef_,registrationNumber_);
          }
          else if(registrationNumberNode->Attribute("href")) { registrationNumberIDRef_ = registrationNumberNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { registrationNumber_ = boost::shared_ptr<RegulatorId>(new RegulatorId(registrationNumberNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<SupervisoryBody> SupervisorRegistration::getSupervisoryBody()
{
   if(!this->supervisoryBodyIsNull_){
        if(supervisoryBodyIDRef_ != ""){
             return boost::shared_static_cast<SupervisoryBody>(IDManager::instance().getID(supervisoryBodyIDRef_));
        }else{
             return this->supervisoryBody_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SupervisoryBody>();
   }
}
boost::shared_ptr<RegulatorId> SupervisorRegistration::getRegistrationNumber()
{
   if(!this->registrationNumberIsNull_){
        if(registrationNumberIDRef_ != ""){
             return boost::shared_static_cast<RegulatorId>(IDManager::instance().getID(registrationNumberIDRef_));
        }else{
             return this->registrationNumber_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RegulatorId>();
   }
}
}

