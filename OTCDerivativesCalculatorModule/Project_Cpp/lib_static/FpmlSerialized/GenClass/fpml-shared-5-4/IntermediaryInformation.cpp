// IntermediaryInformation.cpp 
#include "IntermediaryInformation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

IntermediaryInformation::IntermediaryInformation(TiXmlNode* xmlNode)
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

   //intermediarySequenceNumberNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* intermediarySequenceNumberNode = xmlNode->FirstChildElement("intermediarySequenceNumber");

   if(intermediarySequenceNumberNode){intermediarySequenceNumberIsNull_ = false;}
   else{intermediarySequenceNumberIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- intermediarySequenceNumberNode , address : " << intermediarySequenceNumberNode << std::endl;
   #endif
   if(intermediarySequenceNumberNode)
   {
      if(intermediarySequenceNumberNode->Attribute("href") || intermediarySequenceNumberNode->Attribute("id"))
      {
          if(intermediarySequenceNumberNode->Attribute("id"))
          {
             intermediarySequenceNumberIDRef_ = intermediarySequenceNumberNode->Attribute("id");
             intermediarySequenceNumber_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(intermediarySequenceNumberNode));
             intermediarySequenceNumber_->setID(intermediarySequenceNumberIDRef_);
             IDManager::instance().setID(intermediarySequenceNumberIDRef_,intermediarySequenceNumber_);
          }
          else if(intermediarySequenceNumberNode->Attribute("href")) { intermediarySequenceNumberIDRef_ = intermediarySequenceNumberNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { intermediarySequenceNumber_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(intermediarySequenceNumberNode));}
   }

   //intermediaryPartyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* intermediaryPartyReferenceNode = xmlNode->FirstChildElement("intermediaryPartyReference");

   if(intermediaryPartyReferenceNode){intermediaryPartyReferenceIsNull_ = false;}
   else{intermediaryPartyReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- intermediaryPartyReferenceNode , address : " << intermediaryPartyReferenceNode << std::endl;
   #endif
   if(intermediaryPartyReferenceNode)
   {
      if(intermediaryPartyReferenceNode->Attribute("href") || intermediaryPartyReferenceNode->Attribute("id"))
      {
          if(intermediaryPartyReferenceNode->Attribute("id"))
          {
             intermediaryPartyReferenceIDRef_ = intermediaryPartyReferenceNode->Attribute("id");
             intermediaryPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(intermediaryPartyReferenceNode));
             intermediaryPartyReference_->setID(intermediaryPartyReferenceIDRef_);
             IDManager::instance().setID(intermediaryPartyReferenceIDRef_,intermediaryPartyReference_);
          }
          else if(intermediaryPartyReferenceNode->Attribute("href")) { intermediaryPartyReferenceIDRef_ = intermediaryPartyReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { intermediaryPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(intermediaryPartyReferenceNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<RoutingIds> IntermediaryInformation::getRoutingIds()
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
boost::shared_ptr<RoutingExplicitDetails> IntermediaryInformation::getRoutingExplicitDetails()
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
boost::shared_ptr<RoutingIdsAndExplicitDetails> IntermediaryInformation::getRoutingIdsAndExplicitDetails()
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
boost::shared_ptr<XsdTypePositiveInteger> IntermediaryInformation::getIntermediarySequenceNumber()
{
   if(!this->intermediarySequenceNumberIsNull_){
        if(intermediarySequenceNumberIDRef_ != ""){
             return boost::shared_static_cast<XsdTypePositiveInteger>(IDManager::instance().getID(intermediarySequenceNumberIDRef_));
        }else{
             return this->intermediarySequenceNumber_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypePositiveInteger>();
   }
}
boost::shared_ptr<PartyReference> IntermediaryInformation::getIntermediaryPartyReference()
{
   if(!this->intermediaryPartyReferenceIsNull_){
        if(intermediaryPartyReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(intermediaryPartyReferenceIDRef_));
        }else{
             return this->intermediaryPartyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
}

