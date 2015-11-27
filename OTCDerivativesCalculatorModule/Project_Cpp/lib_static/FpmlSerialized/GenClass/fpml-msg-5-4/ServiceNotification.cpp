// ServiceNotification.cpp 
#include "ServiceNotification.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ServiceNotification::ServiceNotification(TiXmlNode* xmlNode)
: NotificationMessage(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //serviceNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* serviceNameNode = xmlNode->FirstChildElement("serviceName");

   if(serviceNameNode){serviceNameIsNull_ = false;}
   else{serviceNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- serviceNameNode , address : " << serviceNameNode << std::endl;
   #endif
   if(serviceNameNode)
   {
      if(serviceNameNode->Attribute("href") || serviceNameNode->Attribute("id"))
      {
          if(serviceNameNode->Attribute("id"))
          {
             serviceNameIDRef_ = serviceNameNode->Attribute("id");
             serviceName_ = boost::shared_ptr<XsdTypeNormalizedString>(new XsdTypeNormalizedString(serviceNameNode));
             serviceName_->setID(serviceNameIDRef_);
             IDManager::instance().setID(serviceNameIDRef_,serviceName_);
          }
          else if(serviceNameNode->Attribute("href")) { serviceNameIDRef_ = serviceNameNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { serviceName_ = boost::shared_ptr<XsdTypeNormalizedString>(new XsdTypeNormalizedString(serviceNameNode));}
   }

   //statusNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* statusNode = xmlNode->FirstChildElement("status");

   if(statusNode){statusIsNull_ = false;}
   else{statusIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- statusNode , address : " << statusNode << std::endl;
   #endif
   if(statusNode)
   {
      if(statusNode->Attribute("href") || statusNode->Attribute("id"))
      {
          if(statusNode->Attribute("id"))
          {
             statusIDRef_ = statusNode->Attribute("id");
             status_ = boost::shared_ptr<ServiceStatus>(new ServiceStatus(statusNode));
             status_->setID(statusIDRef_);
             IDManager::instance().setID(statusIDRef_,status_);
          }
          else if(statusNode->Attribute("href")) { statusIDRef_ = statusNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { status_ = boost::shared_ptr<ServiceStatus>(new ServiceStatus(statusNode));}
   }

   //processingStatusNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* processingStatusNode = xmlNode->FirstChildElement("processingStatus");

   if(processingStatusNode){processingStatusIsNull_ = false;}
   else{processingStatusIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- processingStatusNode , address : " << processingStatusNode << std::endl;
   #endif
   if(processingStatusNode)
   {
      if(processingStatusNode->Attribute("href") || processingStatusNode->Attribute("id"))
      {
          if(processingStatusNode->Attribute("id"))
          {
             processingStatusIDRef_ = processingStatusNode->Attribute("id");
             processingStatus_ = boost::shared_ptr<ServiceProcessingStatus>(new ServiceProcessingStatus(processingStatusNode));
             processingStatus_->setID(processingStatusIDRef_);
             IDManager::instance().setID(processingStatusIDRef_,processingStatus_);
          }
          else if(processingStatusNode->Attribute("href")) { processingStatusIDRef_ = processingStatusNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { processingStatus_ = boost::shared_ptr<ServiceProcessingStatus>(new ServiceProcessingStatus(processingStatusNode));}
   }

   //advisoryNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* advisoryNode = xmlNode->FirstChildElement("advisory");

   if(advisoryNode){advisoryIsNull_ = false;}
   else{advisoryIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- advisoryNode , address : " << advisoryNode << std::endl;
   #endif
   if(advisoryNode)
   {
      if(advisoryNode->Attribute("href") || advisoryNode->Attribute("id"))
      {
          if(advisoryNode->Attribute("id"))
          {
             advisoryIDRef_ = advisoryNode->Attribute("id");
             advisory_ = boost::shared_ptr<ServiceAdvisory>(new ServiceAdvisory(advisoryNode));
             advisory_->setID(advisoryIDRef_);
             IDManager::instance().setID(advisoryIDRef_,advisory_);
          }
          else if(advisoryNode->Attribute("href")) { advisoryIDRef_ = advisoryNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { advisory_ = boost::shared_ptr<ServiceAdvisory>(new ServiceAdvisory(advisoryNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeNormalizedString> ServiceNotification::getServiceName()
{
   if(!this->serviceNameIsNull_){
        if(serviceNameIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeNormalizedString>(IDManager::instance().getID(serviceNameIDRef_));
        }else{
             return this->serviceName_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeNormalizedString>();
   }
}
boost::shared_ptr<ServiceStatus> ServiceNotification::getStatus()
{
   if(!this->statusIsNull_){
        if(statusIDRef_ != ""){
             return boost::shared_static_cast<ServiceStatus>(IDManager::instance().getID(statusIDRef_));
        }else{
             return this->status_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ServiceStatus>();
   }
}
boost::shared_ptr<ServiceProcessingStatus> ServiceNotification::getProcessingStatus()
{
   if(!this->processingStatusIsNull_){
        if(processingStatusIDRef_ != ""){
             return boost::shared_static_cast<ServiceProcessingStatus>(IDManager::instance().getID(processingStatusIDRef_));
        }else{
             return this->processingStatus_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ServiceProcessingStatus>();
   }
}
boost::shared_ptr<ServiceAdvisory> ServiceNotification::getAdvisory()
{
   if(!this->advisoryIsNull_){
        if(advisoryIDRef_ != ""){
             return boost::shared_static_cast<ServiceAdvisory>(IDManager::instance().getID(advisoryIDRef_));
        }else{
             return this->advisory_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ServiceAdvisory>();
   }
}
}

