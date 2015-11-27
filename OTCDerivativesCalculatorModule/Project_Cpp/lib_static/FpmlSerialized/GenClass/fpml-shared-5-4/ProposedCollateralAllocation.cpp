// ProposedCollateralAllocation.cpp 
#include "ProposedCollateralAllocation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ProposedCollateralAllocation::ProposedCollateralAllocation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //allocationPartyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* allocationPartyReferenceNode = xmlNode->FirstChildElement("allocationPartyReference");

   if(allocationPartyReferenceNode){allocationPartyReferenceIsNull_ = false;}
   else{allocationPartyReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- allocationPartyReferenceNode , address : " << allocationPartyReferenceNode << std::endl;
   #endif
   if(allocationPartyReferenceNode)
   {
      if(allocationPartyReferenceNode->Attribute("href") || allocationPartyReferenceNode->Attribute("id"))
      {
          if(allocationPartyReferenceNode->Attribute("id"))
          {
             allocationPartyReferenceIDRef_ = allocationPartyReferenceNode->Attribute("id");
             allocationPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(allocationPartyReferenceNode));
             allocationPartyReference_->setID(allocationPartyReferenceIDRef_);
             IDManager::instance().setID(allocationPartyReferenceIDRef_,allocationPartyReference_);
          }
          else if(allocationPartyReferenceNode->Attribute("href")) { allocationPartyReferenceIDRef_ = allocationPartyReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { allocationPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(allocationPartyReferenceNode));}
   }

   //allocationAccountReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* allocationAccountReferenceNode = xmlNode->FirstChildElement("allocationAccountReference");

   if(allocationAccountReferenceNode){allocationAccountReferenceIsNull_ = false;}
   else{allocationAccountReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- allocationAccountReferenceNode , address : " << allocationAccountReferenceNode << std::endl;
   #endif
   if(allocationAccountReferenceNode)
   {
      if(allocationAccountReferenceNode->Attribute("href") || allocationAccountReferenceNode->Attribute("id"))
      {
          if(allocationAccountReferenceNode->Attribute("id"))
          {
             allocationAccountReferenceIDRef_ = allocationAccountReferenceNode->Attribute("id");
             allocationAccountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(allocationAccountReferenceNode));
             allocationAccountReference_->setID(allocationAccountReferenceIDRef_);
             IDManager::instance().setID(allocationAccountReferenceIDRef_,allocationAccountReference_);
          }
          else if(allocationAccountReferenceNode->Attribute("href")) { allocationAccountReferenceIDRef_ = allocationAccountReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { allocationAccountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(allocationAccountReferenceNode));}
   }

   //collateralValueAllocationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* collateralValueAllocationNode = xmlNode->FirstChildElement("collateralValueAllocation");

   if(collateralValueAllocationNode){collateralValueAllocationIsNull_ = false;}
   else{collateralValueAllocationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- collateralValueAllocationNode , address : " << collateralValueAllocationNode << std::endl;
   #endif
   if(collateralValueAllocationNode)
   {
      if(collateralValueAllocationNode->Attribute("href") || collateralValueAllocationNode->Attribute("id"))
      {
          if(collateralValueAllocationNode->Attribute("id"))
          {
             collateralValueAllocationIDRef_ = collateralValueAllocationNode->Attribute("id");
             collateralValueAllocation_ = boost::shared_ptr<CollateralValueAllocation>(new CollateralValueAllocation(collateralValueAllocationNode));
             collateralValueAllocation_->setID(collateralValueAllocationIDRef_);
             IDManager::instance().setID(collateralValueAllocationIDRef_,collateralValueAllocation_);
          }
          else if(collateralValueAllocationNode->Attribute("href")) { collateralValueAllocationIDRef_ = collateralValueAllocationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { collateralValueAllocation_ = boost::shared_ptr<CollateralValueAllocation>(new CollateralValueAllocation(collateralValueAllocationNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PartyReference> ProposedCollateralAllocation::getAllocationPartyReference()
{
   if(!this->allocationPartyReferenceIsNull_){
        if(allocationPartyReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(allocationPartyReferenceIDRef_));
        }else{
             return this->allocationPartyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<AccountReference> ProposedCollateralAllocation::getAllocationAccountReference()
{
   if(!this->allocationAccountReferenceIsNull_){
        if(allocationAccountReferenceIDRef_ != ""){
             return boost::shared_static_cast<AccountReference>(IDManager::instance().getID(allocationAccountReferenceIDRef_));
        }else{
             return this->allocationAccountReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AccountReference>();
   }
}
boost::shared_ptr<CollateralValueAllocation> ProposedCollateralAllocation::getCollateralValueAllocation()
{
   if(!this->collateralValueAllocationIsNull_){
        if(collateralValueAllocationIDRef_ != ""){
             return boost::shared_static_cast<CollateralValueAllocation>(IDManager::instance().getID(collateralValueAllocationIDRef_));
        }else{
             return this->collateralValueAllocation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CollateralValueAllocation>();
   }
}
}

