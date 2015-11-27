// VersionedContractId.cpp 
#include "VersionedContractId.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

VersionedContractId::VersionedContractId(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //contractIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* contractIdNode = xmlNode->FirstChildElement("contractId");

   if(contractIdNode){contractIdIsNull_ = false;}
   else{contractIdIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- contractIdNode , address : " << contractIdNode << std::endl;
   #endif
   if(contractIdNode)
   {
      if(contractIdNode->Attribute("href") || contractIdNode->Attribute("id"))
      {
          if(contractIdNode->Attribute("id"))
          {
             contractIdIDRef_ = contractIdNode->Attribute("id");
             contractId_ = boost::shared_ptr<ContractId>(new ContractId(contractIdNode));
             contractId_->setID(contractIdIDRef_);
             IDManager::instance().setID(contractIdIDRef_,contractId_);
          }
          else if(contractIdNode->Attribute("href")) { contractIdIDRef_ = contractIdNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { contractId_ = boost::shared_ptr<ContractId>(new ContractId(contractIdNode));}
   }

   //versionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* versionNode = xmlNode->FirstChildElement("version");

   if(versionNode){versionIsNull_ = false;}
   else{versionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- versionNode , address : " << versionNode << std::endl;
   #endif
   if(versionNode)
   {
      if(versionNode->Attribute("href") || versionNode->Attribute("id"))
      {
          if(versionNode->Attribute("id"))
          {
             versionIDRef_ = versionNode->Attribute("id");
             version_ = boost::shared_ptr<XsdTypeNonNegativeInteger>(new XsdTypeNonNegativeInteger(versionNode));
             version_->setID(versionIDRef_);
             IDManager::instance().setID(versionIDRef_,version_);
          }
          else if(versionNode->Attribute("href")) { versionIDRef_ = versionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { version_ = boost::shared_ptr<XsdTypeNonNegativeInteger>(new XsdTypeNonNegativeInteger(versionNode));}
   }

   //effectiveDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* effectiveDateNode = xmlNode->FirstChildElement("effectiveDate");

   if(effectiveDateNode){effectiveDateIsNull_ = false;}
   else{effectiveDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- effectiveDateNode , address : " << effectiveDateNode << std::endl;
   #endif
   if(effectiveDateNode)
   {
      if(effectiveDateNode->Attribute("href") || effectiveDateNode->Attribute("id"))
      {
          if(effectiveDateNode->Attribute("id"))
          {
             effectiveDateIDRef_ = effectiveDateNode->Attribute("id");
             effectiveDate_ = boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(effectiveDateNode));
             effectiveDate_->setID(effectiveDateIDRef_);
             IDManager::instance().setID(effectiveDateIDRef_,effectiveDate_);
          }
          else if(effectiveDateNode->Attribute("href")) { effectiveDateIDRef_ = effectiveDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { effectiveDate_ = boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(effectiveDateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<ContractId> VersionedContractId::getContractId()
{
   if(!this->contractIdIsNull_){
        if(contractIdIDRef_ != ""){
             return boost::shared_static_cast<ContractId>(IDManager::instance().getID(contractIdIDRef_));
        }else{
             return this->contractId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ContractId>();
   }
}
boost::shared_ptr<XsdTypeNonNegativeInteger> VersionedContractId::getVersion()
{
   if(!this->versionIsNull_){
        if(versionIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeNonNegativeInteger>(IDManager::instance().getID(versionIDRef_));
        }else{
             return this->version_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeNonNegativeInteger>();
   }
}
boost::shared_ptr<IdentifiedDate> VersionedContractId::getEffectiveDate()
{
   if(!this->effectiveDateIsNull_){
        if(effectiveDateIDRef_ != ""){
             return boost::shared_static_cast<IdentifiedDate>(IDManager::instance().getID(effectiveDateIDRef_));
        }else{
             return this->effectiveDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IdentifiedDate>();
   }
}
}

