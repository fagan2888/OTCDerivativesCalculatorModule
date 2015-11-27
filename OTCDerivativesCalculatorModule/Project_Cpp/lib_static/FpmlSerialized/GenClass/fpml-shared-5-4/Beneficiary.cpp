// Beneficiary.cpp 
#include "Beneficiary.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Beneficiary::Beneficiary(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //routingIdsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* routingIdsNode = xmlNode->FirstChildElement("routingIds");

   if(routingIdsNode){routingIdsIsNull_ = false;}
   else{routingIdsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- routingIdsNode , address : " << routingIdsNode << std::endl;
   #endif
   if(routingIdsNode)
   {
      if(routingIdsNode->Attribute("href") || routingIdsNode->Attribute("id"))
      {
          if(routingIdsNode->Attribute("id"))
          {
             routingIdsIDRef_ = routingIdsNode->Attribute("id");
             routingIds_ = boost::shared_ptr<RoutingIds>(new RoutingIds(routingIdsNode));
             routingIds_->setID(routingIdsIDRef_);
             IDManager::instance().setID(routingIdsIDRef_,routingIds_);
          }
          else if(routingIdsNode->Attribute("href")) { routingIdsIDRef_ = routingIdsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { routingIds_ = boost::shared_ptr<RoutingIds>(new RoutingIds(routingIdsNode));}
   }

   //routingExplicitDetailsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* routingExplicitDetailsNode = xmlNode->FirstChildElement("routingExplicitDetails");

   if(routingExplicitDetailsNode){routingExplicitDetailsIsNull_ = false;}
   else{routingExplicitDetailsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- routingExplicitDetailsNode , address : " << routingExplicitDetailsNode << std::endl;
   #endif
   if(routingExplicitDetailsNode)
   {
      if(routingExplicitDetailsNode->Attribute("href") || routingExplicitDetailsNode->Attribute("id"))
      {
          if(routingExplicitDetailsNode->Attribute("id"))
          {
             routingExplicitDetailsIDRef_ = routingExplicitDetailsNode->Attribute("id");
             routingExplicitDetails_ = boost::shared_ptr<RoutingExplicitDetails>(new RoutingExplicitDetails(routingExplicitDetailsNode));
             routingExplicitDetails_->setID(routingExplicitDetailsIDRef_);
             IDManager::instance().setID(routingExplicitDetailsIDRef_,routingExplicitDetails_);
          }
          else if(routingExplicitDetailsNode->Attribute("href")) { routingExplicitDetailsIDRef_ = routingExplicitDetailsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { routingExplicitDetails_ = boost::shared_ptr<RoutingExplicitDetails>(new RoutingExplicitDetails(routingExplicitDetailsNode));}
   }

   //routingIdsAndExplicitDetailsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* routingIdsAndExplicitDetailsNode = xmlNode->FirstChildElement("routingIdsAndExplicitDetails");

   if(routingIdsAndExplicitDetailsNode){routingIdsAndExplicitDetailsIsNull_ = false;}
   else{routingIdsAndExplicitDetailsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- routingIdsAndExplicitDetailsNode , address : " << routingIdsAndExplicitDetailsNode << std::endl;
   #endif
   if(routingIdsAndExplicitDetailsNode)
   {
      if(routingIdsAndExplicitDetailsNode->Attribute("href") || routingIdsAndExplicitDetailsNode->Attribute("id"))
      {
          if(routingIdsAndExplicitDetailsNode->Attribute("id"))
          {
             routingIdsAndExplicitDetailsIDRef_ = routingIdsAndExplicitDetailsNode->Attribute("id");
             routingIdsAndExplicitDetails_ = boost::shared_ptr<RoutingIdsAndExplicitDetails>(new RoutingIdsAndExplicitDetails(routingIdsAndExplicitDetailsNode));
             routingIdsAndExplicitDetails_->setID(routingIdsAndExplicitDetailsIDRef_);
             IDManager::instance().setID(routingIdsAndExplicitDetailsIDRef_,routingIdsAndExplicitDetails_);
          }
          else if(routingIdsAndExplicitDetailsNode->Attribute("href")) { routingIdsAndExplicitDetailsIDRef_ = routingIdsAndExplicitDetailsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { routingIdsAndExplicitDetails_ = boost::shared_ptr<RoutingIdsAndExplicitDetails>(new RoutingIdsAndExplicitDetails(routingIdsAndExplicitDetailsNode));}
   }

   //beneficiaryPartyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* beneficiaryPartyReferenceNode = xmlNode->FirstChildElement("beneficiaryPartyReference");

   if(beneficiaryPartyReferenceNode){beneficiaryPartyReferenceIsNull_ = false;}
   else{beneficiaryPartyReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- beneficiaryPartyReferenceNode , address : " << beneficiaryPartyReferenceNode << std::endl;
   #endif
   if(beneficiaryPartyReferenceNode)
   {
      if(beneficiaryPartyReferenceNode->Attribute("href") || beneficiaryPartyReferenceNode->Attribute("id"))
      {
          if(beneficiaryPartyReferenceNode->Attribute("id"))
          {
             beneficiaryPartyReferenceIDRef_ = beneficiaryPartyReferenceNode->Attribute("id");
             beneficiaryPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(beneficiaryPartyReferenceNode));
             beneficiaryPartyReference_->setID(beneficiaryPartyReferenceIDRef_);
             IDManager::instance().setID(beneficiaryPartyReferenceIDRef_,beneficiaryPartyReference_);
          }
          else if(beneficiaryPartyReferenceNode->Attribute("href")) { beneficiaryPartyReferenceIDRef_ = beneficiaryPartyReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { beneficiaryPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(beneficiaryPartyReferenceNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<RoutingIds> Beneficiary::getRoutingIds()
{
   if(!this->routingIdsIsNull_){
        if(routingIdsIDRef_ != ""){
             return boost::shared_static_cast<RoutingIds>(IDManager::instance().getID(routingIdsIDRef_));
        }else{
             return this->routingIds_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RoutingIds>();
   }
}
boost::shared_ptr<RoutingExplicitDetails> Beneficiary::getRoutingExplicitDetails()
{
   if(!this->routingExplicitDetailsIsNull_){
        if(routingExplicitDetailsIDRef_ != ""){
             return boost::shared_static_cast<RoutingExplicitDetails>(IDManager::instance().getID(routingExplicitDetailsIDRef_));
        }else{
             return this->routingExplicitDetails_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RoutingExplicitDetails>();
   }
}
boost::shared_ptr<RoutingIdsAndExplicitDetails> Beneficiary::getRoutingIdsAndExplicitDetails()
{
   if(!this->routingIdsAndExplicitDetailsIsNull_){
        if(routingIdsAndExplicitDetailsIDRef_ != ""){
             return boost::shared_static_cast<RoutingIdsAndExplicitDetails>(IDManager::instance().getID(routingIdsAndExplicitDetailsIDRef_));
        }else{
             return this->routingIdsAndExplicitDetails_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RoutingIdsAndExplicitDetails>();
   }
}
boost::shared_ptr<PartyReference> Beneficiary::getBeneficiaryPartyReference()
{
   if(!this->beneficiaryPartyReferenceIsNull_){
        if(beneficiaryPartyReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(beneficiaryPartyReferenceIDRef_));
        }else{
             return this->beneficiaryPartyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
}

