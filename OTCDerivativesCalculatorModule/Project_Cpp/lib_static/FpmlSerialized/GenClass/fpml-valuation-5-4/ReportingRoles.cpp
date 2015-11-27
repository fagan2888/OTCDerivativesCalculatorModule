// ReportingRoles.cpp 
#include "ReportingRoles.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ReportingRoles::ReportingRoles(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //basePartyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* basePartyNode = xmlNode->FirstChildElement("baseParty");

   if(basePartyNode){basePartyIsNull_ = false;}
   else{basePartyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- basePartyNode , address : " << basePartyNode << std::endl;
   #endif
   if(basePartyNode)
   {
      if(basePartyNode->Attribute("href") || basePartyNode->Attribute("id"))
      {
          if(basePartyNode->Attribute("id"))
          {
             basePartyIDRef_ = basePartyNode->Attribute("id");
             baseParty_ = boost::shared_ptr<PartyReference>(new PartyReference(basePartyNode));
             baseParty_->setID(basePartyIDRef_);
             IDManager::instance().setID(basePartyIDRef_,baseParty_);
          }
          else if(basePartyNode->Attribute("href")) { basePartyIDRef_ = basePartyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { baseParty_ = boost::shared_ptr<PartyReference>(new PartyReference(basePartyNode));}
   }

   //baseAccountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* baseAccountNode = xmlNode->FirstChildElement("baseAccount");

   if(baseAccountNode){baseAccountIsNull_ = false;}
   else{baseAccountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- baseAccountNode , address : " << baseAccountNode << std::endl;
   #endif
   if(baseAccountNode)
   {
      if(baseAccountNode->Attribute("href") || baseAccountNode->Attribute("id"))
      {
          if(baseAccountNode->Attribute("id"))
          {
             baseAccountIDRef_ = baseAccountNode->Attribute("id");
             baseAccount_ = boost::shared_ptr<AccountReference>(new AccountReference(baseAccountNode));
             baseAccount_->setID(baseAccountIDRef_);
             IDManager::instance().setID(baseAccountIDRef_,baseAccount_);
          }
          else if(baseAccountNode->Attribute("href")) { baseAccountIDRef_ = baseAccountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { baseAccount_ = boost::shared_ptr<AccountReference>(new AccountReference(baseAccountNode));}
   }

   //activityProviderNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* activityProviderNode = xmlNode->FirstChildElement("activityProvider");

   if(activityProviderNode){activityProviderIsNull_ = false;}
   else{activityProviderIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- activityProviderNode , address : " << activityProviderNode << std::endl;
   #endif
   if(activityProviderNode)
   {
      if(activityProviderNode->Attribute("href") || activityProviderNode->Attribute("id"))
      {
          if(activityProviderNode->Attribute("id"))
          {
             activityProviderIDRef_ = activityProviderNode->Attribute("id");
             activityProvider_ = boost::shared_ptr<PartyReference>(new PartyReference(activityProviderNode));
             activityProvider_->setID(activityProviderIDRef_);
             IDManager::instance().setID(activityProviderIDRef_,activityProvider_);
          }
          else if(activityProviderNode->Attribute("href")) { activityProviderIDRef_ = activityProviderNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { activityProvider_ = boost::shared_ptr<PartyReference>(new PartyReference(activityProviderNode));}
   }

   //positionProviderNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* positionProviderNode = xmlNode->FirstChildElement("positionProvider");

   if(positionProviderNode){positionProviderIsNull_ = false;}
   else{positionProviderIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- positionProviderNode , address : " << positionProviderNode << std::endl;
   #endif
   if(positionProviderNode)
   {
      if(positionProviderNode->Attribute("href") || positionProviderNode->Attribute("id"))
      {
          if(positionProviderNode->Attribute("id"))
          {
             positionProviderIDRef_ = positionProviderNode->Attribute("id");
             positionProvider_ = boost::shared_ptr<PartyReference>(new PartyReference(positionProviderNode));
             positionProvider_->setID(positionProviderIDRef_);
             IDManager::instance().setID(positionProviderIDRef_,positionProvider_);
          }
          else if(positionProviderNode->Attribute("href")) { positionProviderIDRef_ = positionProviderNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { positionProvider_ = boost::shared_ptr<PartyReference>(new PartyReference(positionProviderNode));}
   }

   //valuationProviderNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* valuationProviderNode = xmlNode->FirstChildElement("valuationProvider");

   if(valuationProviderNode){valuationProviderIsNull_ = false;}
   else{valuationProviderIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valuationProviderNode , address : " << valuationProviderNode << std::endl;
   #endif
   if(valuationProviderNode)
   {
      if(valuationProviderNode->Attribute("href") || valuationProviderNode->Attribute("id"))
      {
          if(valuationProviderNode->Attribute("id"))
          {
             valuationProviderIDRef_ = valuationProviderNode->Attribute("id");
             valuationProvider_ = boost::shared_ptr<PartyReference>(new PartyReference(valuationProviderNode));
             valuationProvider_->setID(valuationProviderIDRef_);
             IDManager::instance().setID(valuationProviderIDRef_,valuationProvider_);
          }
          else if(valuationProviderNode->Attribute("href")) { valuationProviderIDRef_ = valuationProviderNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { valuationProvider_ = boost::shared_ptr<PartyReference>(new PartyReference(valuationProviderNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PartyReference> ReportingRoles::getBaseParty()
{
   if(!this->basePartyIsNull_){
        if(basePartyIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(basePartyIDRef_));
        }else{
             return this->baseParty_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<AccountReference> ReportingRoles::getBaseAccount()
{
   if(!this->baseAccountIsNull_){
        if(baseAccountIDRef_ != ""){
             return boost::shared_static_cast<AccountReference>(IDManager::instance().getID(baseAccountIDRef_));
        }else{
             return this->baseAccount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AccountReference>();
   }
}
boost::shared_ptr<PartyReference> ReportingRoles::getActivityProvider()
{
   if(!this->activityProviderIsNull_){
        if(activityProviderIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(activityProviderIDRef_));
        }else{
             return this->activityProvider_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<PartyReference> ReportingRoles::getPositionProvider()
{
   if(!this->positionProviderIsNull_){
        if(positionProviderIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(positionProviderIDRef_));
        }else{
             return this->positionProvider_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<PartyReference> ReportingRoles::getValuationProvider()
{
   if(!this->valuationProviderIsNull_){
        if(valuationProviderIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(valuationProviderIDRef_));
        }else{
             return this->valuationProvider_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
}

