// ContractIdentifier.cpp 
#include "ContractIdentifier.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ContractIdentifier::ContractIdentifier(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //partyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* partyReferenceNode = xmlNode->FirstChildElement("partyReference");

   if(partyReferenceNode){partyReferenceIsNull_ = false;}
   else{partyReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partyReferenceNode , address : " << partyReferenceNode << std::endl;
   #endif
   if(partyReferenceNode)
   {
      if(partyReferenceNode->Attribute("href") || partyReferenceNode->Attribute("id"))
      {
          if(partyReferenceNode->Attribute("id"))
          {
             partyReferenceIDRef_ = partyReferenceNode->Attribute("id");
             partyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(partyReferenceNode));
             partyReference_->setID(partyReferenceIDRef_);
             IDManager::instance().setID(partyReferenceIDRef_,partyReference_);
          }
          else if(partyReferenceNode->Attribute("href")) { partyReferenceIDRef_ = partyReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { partyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(partyReferenceNode));}
   }

   //contractIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* contractIdNode = xmlNode->FirstChildElement("contractId");

   if(contractIdNode){contractIdIsNull_ = false;}
   else{contractIdIsNull_ = true;}

   if(contractIdNode)
   {
      for(contractIdNode; contractIdNode; contractIdNode = contractIdNode->NextSiblingElement("contractId")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- contractIdNode , address : " << contractIdNode << std::endl;
          #endif
          if(contractIdNode->Attribute("href") || contractIdNode->Attribute("id"))
          {
              if(contractIdNode->Attribute("id"))
              {
                  contractIdIDRef_ = contractIdNode->Attribute("id");
                  contractId_.push_back(boost::shared_ptr<ContractId>(new ContractId(contractIdNode)));
                  contractId_.back()->setID(contractIdIDRef_);
                  IDManager::instance().setID(contractIdIDRef_, contractId_.back());
              }
              else if(contractIdNode->Attribute("href")) { contractIdIDRef_ = contractIdNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { contractId_.push_back(boost::shared_ptr<ContractId>(new ContractId(contractIdNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- contractIdNode , address : " << contractIdNode << std::endl;
       #endif
   }

   //versionedContractIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* versionedContractIdNode = xmlNode->FirstChildElement("versionedContractId");

   if(versionedContractIdNode){versionedContractIdIsNull_ = false;}
   else{versionedContractIdIsNull_ = true;}

   if(versionedContractIdNode)
   {
      for(versionedContractIdNode; versionedContractIdNode; versionedContractIdNode = versionedContractIdNode->NextSiblingElement("versionedContractId")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- versionedContractIdNode , address : " << versionedContractIdNode << std::endl;
          #endif
          if(versionedContractIdNode->Attribute("href") || versionedContractIdNode->Attribute("id"))
          {
              if(versionedContractIdNode->Attribute("id"))
              {
                  versionedContractIdIDRef_ = versionedContractIdNode->Attribute("id");
                  versionedContractId_.push_back(boost::shared_ptr<VersionedContractId>(new VersionedContractId(versionedContractIdNode)));
                  versionedContractId_.back()->setID(versionedContractIdIDRef_);
                  IDManager::instance().setID(versionedContractIdIDRef_, versionedContractId_.back());
              }
              else if(versionedContractIdNode->Attribute("href")) { versionedContractIdIDRef_ = versionedContractIdNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { versionedContractId_.push_back(boost::shared_ptr<VersionedContractId>(new VersionedContractId(versionedContractIdNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- versionedContractIdNode , address : " << versionedContractIdNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PartyReference> ContractIdentifier::getPartyReference()
{
   if(!this->partyReferenceIsNull_){
        if(partyReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(partyReferenceIDRef_));
        }else{
             return this->partyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
std::vector<boost::shared_ptr<ContractId>> ContractIdentifier::getContractId()
{
   if(!this->contractIdIsNull_){
        if(contractIdIDRef_ != ""){
             return this->contractId_;
        }else{
             return this->contractId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ContractId>>();
   }
}
std::vector<boost::shared_ptr<VersionedContractId>> ContractIdentifier::getVersionedContractId()
{
   if(!this->versionedContractIdIsNull_){
        if(versionedContractIdIDRef_ != ""){
             return this->versionedContractId_;
        }else{
             return this->versionedContractId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<VersionedContractId>>();
   }
}
}

