// CreditEventNotice.cpp 
#include "CreditEventNotice.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CreditEventNotice::CreditEventNotice(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //notifyingPartyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notifyingPartyNode = xmlNode->FirstChildElement("notifyingParty");

   if(notifyingPartyNode){notifyingPartyIsNull_ = false;}
   else{notifyingPartyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notifyingPartyNode , address : " << notifyingPartyNode << std::endl;
   #endif
   if(notifyingPartyNode)
   {
      if(notifyingPartyNode->Attribute("href") || notifyingPartyNode->Attribute("id"))
      {
          if(notifyingPartyNode->Attribute("id"))
          {
             notifyingPartyIDRef_ = notifyingPartyNode->Attribute("id");
             notifyingParty_ = boost::shared_ptr<NotifyingParty>(new NotifyingParty(notifyingPartyNode));
             notifyingParty_->setID(notifyingPartyIDRef_);
             IDManager::instance().setID(notifyingPartyIDRef_,notifyingParty_);
          }
          else if(notifyingPartyNode->Attribute("href")) { notifyingPartyIDRef_ = notifyingPartyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notifyingParty_ = boost::shared_ptr<NotifyingParty>(new NotifyingParty(notifyingPartyNode));}
   }

   //businessCenterNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* businessCenterNode = xmlNode->FirstChildElement("businessCenter");

   if(businessCenterNode){businessCenterIsNull_ = false;}
   else{businessCenterIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessCenterNode , address : " << businessCenterNode << std::endl;
   #endif
   if(businessCenterNode)
   {
      if(businessCenterNode->Attribute("href") || businessCenterNode->Attribute("id"))
      {
          if(businessCenterNode->Attribute("id"))
          {
             businessCenterIDRef_ = businessCenterNode->Attribute("id");
             businessCenter_ = boost::shared_ptr<BusinessCenter>(new BusinessCenter(businessCenterNode));
             businessCenter_->setID(businessCenterIDRef_);
             IDManager::instance().setID(businessCenterIDRef_,businessCenter_);
          }
          else if(businessCenterNode->Attribute("href")) { businessCenterIDRef_ = businessCenterNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { businessCenter_ = boost::shared_ptr<BusinessCenter>(new BusinessCenter(businessCenterNode));}
   }

   //publiclyAvailableInformationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* publiclyAvailableInformationNode = xmlNode->FirstChildElement("publiclyAvailableInformation");

   if(publiclyAvailableInformationNode){publiclyAvailableInformationIsNull_ = false;}
   else{publiclyAvailableInformationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- publiclyAvailableInformationNode , address : " << publiclyAvailableInformationNode << std::endl;
   #endif
   if(publiclyAvailableInformationNode)
   {
      if(publiclyAvailableInformationNode->Attribute("href") || publiclyAvailableInformationNode->Attribute("id"))
      {
          if(publiclyAvailableInformationNode->Attribute("id"))
          {
             publiclyAvailableInformationIDRef_ = publiclyAvailableInformationNode->Attribute("id");
             publiclyAvailableInformation_ = boost::shared_ptr<PubliclyAvailableInformation>(new PubliclyAvailableInformation(publiclyAvailableInformationNode));
             publiclyAvailableInformation_->setID(publiclyAvailableInformationIDRef_);
             IDManager::instance().setID(publiclyAvailableInformationIDRef_,publiclyAvailableInformation_);
          }
          else if(publiclyAvailableInformationNode->Attribute("href")) { publiclyAvailableInformationIDRef_ = publiclyAvailableInformationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { publiclyAvailableInformation_ = boost::shared_ptr<PubliclyAvailableInformation>(new PubliclyAvailableInformation(publiclyAvailableInformationNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<NotifyingParty> CreditEventNotice::getNotifyingParty()
{
   if(!this->notifyingPartyIsNull_){
        if(notifyingPartyIDRef_ != ""){
             return boost::shared_static_cast<NotifyingParty>(IDManager::instance().getID(notifyingPartyIDRef_));
        }else{
             return this->notifyingParty_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NotifyingParty>();
   }
}
boost::shared_ptr<BusinessCenter> CreditEventNotice::getBusinessCenter()
{
   if(!this->businessCenterIsNull_){
        if(businessCenterIDRef_ != ""){
             return boost::shared_static_cast<BusinessCenter>(IDManager::instance().getID(businessCenterIDRef_));
        }else{
             return this->businessCenter_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessCenter>();
   }
}
boost::shared_ptr<PubliclyAvailableInformation> CreditEventNotice::getPubliclyAvailableInformation()
{
   if(!this->publiclyAvailableInformationIsNull_){
        if(publiclyAvailableInformationIDRef_ != ""){
             return boost::shared_static_cast<PubliclyAvailableInformation>(IDManager::instance().getID(publiclyAvailableInformationIDRef_));
        }else{
             return this->publiclyAvailableInformation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PubliclyAvailableInformation>();
   }
}
}

