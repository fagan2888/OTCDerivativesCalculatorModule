// ReportingRegime.cpp 
#include "ReportingRegime.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ReportingRegime::ReportingRegime(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //nameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nameNode = xmlNode->FirstChildElement("name");

   if(nameNode){nameIsNull_ = false;}
   else{nameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nameNode , address : " << nameNode << std::endl;
   #endif
   if(nameNode)
   {
      if(nameNode->Attribute("href") || nameNode->Attribute("id"))
      {
          if(nameNode->Attribute("id"))
          {
             nameIDRef_ = nameNode->Attribute("id");
             name_ = boost::shared_ptr<ReportingRegimeName>(new ReportingRegimeName(nameNode));
             name_->setID(nameIDRef_);
             IDManager::instance().setID(nameIDRef_,name_);
          }
          else if(nameNode->Attribute("href")) { nameIDRef_ = nameNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { name_ = boost::shared_ptr<ReportingRegimeName>(new ReportingRegimeName(nameNode));}
   }

   //supervisorRegistrationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* supervisorRegistrationNode = xmlNode->FirstChildElement("supervisorRegistration");

   if(supervisorRegistrationNode){supervisorRegistrationIsNull_ = false;}
   else{supervisorRegistrationIsNull_ = true;}

   if(supervisorRegistrationNode)
   {
      for(supervisorRegistrationNode; supervisorRegistrationNode; supervisorRegistrationNode = supervisorRegistrationNode->NextSiblingElement("supervisorRegistration")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- supervisorRegistrationNode , address : " << supervisorRegistrationNode << std::endl;
          #endif
          if(supervisorRegistrationNode->Attribute("href") || supervisorRegistrationNode->Attribute("id"))
          {
              if(supervisorRegistrationNode->Attribute("id"))
              {
                  supervisorRegistrationIDRef_ = supervisorRegistrationNode->Attribute("id");
                  supervisorRegistration_.push_back(boost::shared_ptr<SupervisorRegistration>(new SupervisorRegistration(supervisorRegistrationNode)));
                  supervisorRegistration_.back()->setID(supervisorRegistrationIDRef_);
                  IDManager::instance().setID(supervisorRegistrationIDRef_, supervisorRegistration_.back());
              }
              else if(supervisorRegistrationNode->Attribute("href")) { supervisorRegistrationIDRef_ = supervisorRegistrationNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { supervisorRegistration_.push_back(boost::shared_ptr<SupervisorRegistration>(new SupervisorRegistration(supervisorRegistrationNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- supervisorRegistrationNode , address : " << supervisorRegistrationNode << std::endl;
       #endif
   }

   //reportingRoleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* reportingRoleNode = xmlNode->FirstChildElement("reportingRole");

   if(reportingRoleNode){reportingRoleIsNull_ = false;}
   else{reportingRoleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- reportingRoleNode , address : " << reportingRoleNode << std::endl;
   #endif
   if(reportingRoleNode)
   {
      if(reportingRoleNode->Attribute("href") || reportingRoleNode->Attribute("id"))
      {
          if(reportingRoleNode->Attribute("id"))
          {
             reportingRoleIDRef_ = reportingRoleNode->Attribute("id");
             reportingRole_ = boost::shared_ptr<ReportingRole>(new ReportingRole(reportingRoleNode));
             reportingRole_->setID(reportingRoleIDRef_);
             IDManager::instance().setID(reportingRoleIDRef_,reportingRole_);
          }
          else if(reportingRoleNode->Attribute("href")) { reportingRoleIDRef_ = reportingRoleNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { reportingRole_ = boost::shared_ptr<ReportingRole>(new ReportingRole(reportingRoleNode));}
   }

   //reportingPurposeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* reportingPurposeNode = xmlNode->FirstChildElement("reportingPurpose");

   if(reportingPurposeNode){reportingPurposeIsNull_ = false;}
   else{reportingPurposeIsNull_ = true;}

   if(reportingPurposeNode)
   {
      for(reportingPurposeNode; reportingPurposeNode; reportingPurposeNode = reportingPurposeNode->NextSiblingElement("reportingPurpose")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- reportingPurposeNode , address : " << reportingPurposeNode << std::endl;
          #endif
          if(reportingPurposeNode->Attribute("href") || reportingPurposeNode->Attribute("id"))
          {
              if(reportingPurposeNode->Attribute("id"))
              {
                  reportingPurposeIDRef_ = reportingPurposeNode->Attribute("id");
                  reportingPurpose_.push_back(boost::shared_ptr<ReportingPurpose>(new ReportingPurpose(reportingPurposeNode)));
                  reportingPurpose_.back()->setID(reportingPurposeIDRef_);
                  IDManager::instance().setID(reportingPurposeIDRef_, reportingPurpose_.back());
              }
              else if(reportingPurposeNode->Attribute("href")) { reportingPurposeIDRef_ = reportingPurposeNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { reportingPurpose_.push_back(boost::shared_ptr<ReportingPurpose>(new ReportingPurpose(reportingPurposeNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- reportingPurposeNode , address : " << reportingPurposeNode << std::endl;
       #endif
   }

   //mandatorilyClearableNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* mandatorilyClearableNode = xmlNode->FirstChildElement("mandatorilyClearable");

   if(mandatorilyClearableNode){mandatorilyClearableIsNull_ = false;}
   else{mandatorilyClearableIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- mandatorilyClearableNode , address : " << mandatorilyClearableNode << std::endl;
   #endif
   if(mandatorilyClearableNode)
   {
      if(mandatorilyClearableNode->Attribute("href") || mandatorilyClearableNode->Attribute("id"))
      {
          if(mandatorilyClearableNode->Attribute("id"))
          {
             mandatorilyClearableIDRef_ = mandatorilyClearableNode->Attribute("id");
             mandatorilyClearable_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(mandatorilyClearableNode));
             mandatorilyClearable_->setID(mandatorilyClearableIDRef_);
             IDManager::instance().setID(mandatorilyClearableIDRef_,mandatorilyClearable_);
          }
          else if(mandatorilyClearableNode->Attribute("href")) { mandatorilyClearableIDRef_ = mandatorilyClearableNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { mandatorilyClearable_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(mandatorilyClearableNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<ReportingRegimeName> ReportingRegime::getName()
{
   if(!this->nameIsNull_){
        if(nameIDRef_ != ""){
             return boost::shared_static_cast<ReportingRegimeName>(IDManager::instance().getID(nameIDRef_));
        }else{
             return this->name_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReportingRegimeName>();
   }
}
std::vector<boost::shared_ptr<SupervisorRegistration>> ReportingRegime::getSupervisorRegistration()
{
   if(!this->supervisorRegistrationIsNull_){
        if(supervisorRegistrationIDRef_ != ""){
             return this->supervisorRegistration_;
        }else{
             return this->supervisorRegistration_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<SupervisorRegistration>>();
   }
}
boost::shared_ptr<ReportingRole> ReportingRegime::getReportingRole()
{
   if(!this->reportingRoleIsNull_){
        if(reportingRoleIDRef_ != ""){
             return boost::shared_static_cast<ReportingRole>(IDManager::instance().getID(reportingRoleIDRef_));
        }else{
             return this->reportingRole_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReportingRole>();
   }
}
std::vector<boost::shared_ptr<ReportingPurpose>> ReportingRegime::getReportingPurpose()
{
   if(!this->reportingPurposeIsNull_){
        if(reportingPurposeIDRef_ != ""){
             return this->reportingPurpose_;
        }else{
             return this->reportingPurpose_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ReportingPurpose>>();
   }
}
boost::shared_ptr<XsdTypeBoolean> ReportingRegime::getMandatorilyClearable()
{
   if(!this->mandatorilyClearableIsNull_){
        if(mandatorilyClearableIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(mandatorilyClearableIDRef_));
        }else{
             return this->mandatorilyClearable_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

