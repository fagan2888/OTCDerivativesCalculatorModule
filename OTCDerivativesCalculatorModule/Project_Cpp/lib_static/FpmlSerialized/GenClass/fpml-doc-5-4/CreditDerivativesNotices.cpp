// CreditDerivativesNotices.cpp 
#include "CreditDerivativesNotices.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CreditDerivativesNotices::CreditDerivativesNotices(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //creditEventNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* creditEventNode = xmlNode->FirstChildElement("creditEvent");

   if(creditEventNode){creditEventIsNull_ = false;}
   else{creditEventIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- creditEventNode , address : " << creditEventNode << std::endl;
   #endif
   if(creditEventNode)
   {
      if(creditEventNode->Attribute("href") || creditEventNode->Attribute("id"))
      {
          if(creditEventNode->Attribute("id"))
          {
             creditEventIDRef_ = creditEventNode->Attribute("id");
             creditEvent_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(creditEventNode));
             creditEvent_->setID(creditEventIDRef_);
             IDManager::instance().setID(creditEventIDRef_,creditEvent_);
          }
          else if(creditEventNode->Attribute("href")) { creditEventIDRef_ = creditEventNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { creditEvent_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(creditEventNode));}
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
             publiclyAvailableInformation_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(publiclyAvailableInformationNode));
             publiclyAvailableInformation_->setID(publiclyAvailableInformationIDRef_);
             IDManager::instance().setID(publiclyAvailableInformationIDRef_,publiclyAvailableInformation_);
          }
          else if(publiclyAvailableInformationNode->Attribute("href")) { publiclyAvailableInformationIDRef_ = publiclyAvailableInformationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { publiclyAvailableInformation_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(publiclyAvailableInformationNode));}
   }

   //physicalSettlementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* physicalSettlementNode = xmlNode->FirstChildElement("physicalSettlement");

   if(physicalSettlementNode){physicalSettlementIsNull_ = false;}
   else{physicalSettlementIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- physicalSettlementNode , address : " << physicalSettlementNode << std::endl;
   #endif
   if(physicalSettlementNode)
   {
      if(physicalSettlementNode->Attribute("href") || physicalSettlementNode->Attribute("id"))
      {
          if(physicalSettlementNode->Attribute("id"))
          {
             physicalSettlementIDRef_ = physicalSettlementNode->Attribute("id");
             physicalSettlement_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(physicalSettlementNode));
             physicalSettlement_->setID(physicalSettlementIDRef_);
             IDManager::instance().setID(physicalSettlementIDRef_,physicalSettlement_);
          }
          else if(physicalSettlementNode->Attribute("href")) { physicalSettlementIDRef_ = physicalSettlementNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { physicalSettlement_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(physicalSettlementNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeBoolean> CreditDerivativesNotices::getCreditEvent()
{
   if(!this->creditEventIsNull_){
        if(creditEventIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(creditEventIDRef_));
        }else{
             return this->creditEvent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> CreditDerivativesNotices::getPubliclyAvailableInformation()
{
   if(!this->publiclyAvailableInformationIsNull_){
        if(publiclyAvailableInformationIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(publiclyAvailableInformationIDRef_));
        }else{
             return this->publiclyAvailableInformation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> CreditDerivativesNotices::getPhysicalSettlement()
{
   if(!this->physicalSettlementIsNull_){
        if(physicalSettlementIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(physicalSettlementIDRef_));
        }else{
             return this->physicalSettlement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

