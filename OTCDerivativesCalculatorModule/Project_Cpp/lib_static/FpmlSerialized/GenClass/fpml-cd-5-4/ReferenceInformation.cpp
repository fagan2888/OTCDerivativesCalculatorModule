// ReferenceInformation.cpp 
#include "ReferenceInformation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ReferenceInformation::ReferenceInformation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //referenceEntityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referenceEntityNode = xmlNode->FirstChildElement("referenceEntity");

   if(referenceEntityNode){referenceEntityIsNull_ = false;}
   else{referenceEntityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceEntityNode , address : " << referenceEntityNode << std::endl;
   #endif
   if(referenceEntityNode)
   {
      if(referenceEntityNode->Attribute("href") || referenceEntityNode->Attribute("id"))
      {
          if(referenceEntityNode->Attribute("id"))
          {
             referenceEntityIDRef_ = referenceEntityNode->Attribute("id");
             referenceEntity_ = boost::shared_ptr<LegalEntity>(new LegalEntity(referenceEntityNode));
             referenceEntity_->setID(referenceEntityIDRef_);
             IDManager::instance().setID(referenceEntityIDRef_,referenceEntity_);
          }
          else if(referenceEntityNode->Attribute("href")) { referenceEntityIDRef_ = referenceEntityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { referenceEntity_ = boost::shared_ptr<LegalEntity>(new LegalEntity(referenceEntityNode));}
   }

   //referenceObligationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referenceObligationNode = xmlNode->FirstChildElement("referenceObligation");

   if(referenceObligationNode){referenceObligationIsNull_ = false;}
   else{referenceObligationIsNull_ = true;}

   if(referenceObligationNode)
   {
      for(referenceObligationNode; referenceObligationNode; referenceObligationNode = referenceObligationNode->NextSiblingElement("referenceObligation")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceObligationNode , address : " << referenceObligationNode << std::endl;
          #endif
          if(referenceObligationNode->Attribute("href") || referenceObligationNode->Attribute("id"))
          {
              if(referenceObligationNode->Attribute("id"))
              {
                  referenceObligationIDRef_ = referenceObligationNode->Attribute("id");
                  referenceObligation_.push_back(boost::shared_ptr<ReferenceObligation>(new ReferenceObligation(referenceObligationNode)));
                  referenceObligation_.back()->setID(referenceObligationIDRef_);
                  IDManager::instance().setID(referenceObligationIDRef_, referenceObligation_.back());
              }
              else if(referenceObligationNode->Attribute("href")) { referenceObligationIDRef_ = referenceObligationNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { referenceObligation_.push_back(boost::shared_ptr<ReferenceObligation>(new ReferenceObligation(referenceObligationNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceObligationNode , address : " << referenceObligationNode << std::endl;
       #endif
   }

   //noReferenceObligationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* noReferenceObligationNode = xmlNode->FirstChildElement("noReferenceObligation");

   if(noReferenceObligationNode){noReferenceObligationIsNull_ = false;}
   else{noReferenceObligationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- noReferenceObligationNode , address : " << noReferenceObligationNode << std::endl;
   #endif
   if(noReferenceObligationNode)
   {
      if(noReferenceObligationNode->Attribute("href") || noReferenceObligationNode->Attribute("id"))
      {
          if(noReferenceObligationNode->Attribute("id"))
          {
             noReferenceObligationIDRef_ = noReferenceObligationNode->Attribute("id");
             noReferenceObligation_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(noReferenceObligationNode));
             noReferenceObligation_->setID(noReferenceObligationIDRef_);
             IDManager::instance().setID(noReferenceObligationIDRef_,noReferenceObligation_);
          }
          else if(noReferenceObligationNode->Attribute("href")) { noReferenceObligationIDRef_ = noReferenceObligationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { noReferenceObligation_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(noReferenceObligationNode));}
   }

   //unknownReferenceObligationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* unknownReferenceObligationNode = xmlNode->FirstChildElement("unknownReferenceObligation");

   if(unknownReferenceObligationNode){unknownReferenceObligationIsNull_ = false;}
   else{unknownReferenceObligationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- unknownReferenceObligationNode , address : " << unknownReferenceObligationNode << std::endl;
   #endif
   if(unknownReferenceObligationNode)
   {
      if(unknownReferenceObligationNode->Attribute("href") || unknownReferenceObligationNode->Attribute("id"))
      {
          if(unknownReferenceObligationNode->Attribute("id"))
          {
             unknownReferenceObligationIDRef_ = unknownReferenceObligationNode->Attribute("id");
             unknownReferenceObligation_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(unknownReferenceObligationNode));
             unknownReferenceObligation_->setID(unknownReferenceObligationIDRef_);
             IDManager::instance().setID(unknownReferenceObligationIDRef_,unknownReferenceObligation_);
          }
          else if(unknownReferenceObligationNode->Attribute("href")) { unknownReferenceObligationIDRef_ = unknownReferenceObligationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { unknownReferenceObligation_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(unknownReferenceObligationNode));}
   }

   //allGuaranteesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* allGuaranteesNode = xmlNode->FirstChildElement("allGuarantees");

   if(allGuaranteesNode){allGuaranteesIsNull_ = false;}
   else{allGuaranteesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- allGuaranteesNode , address : " << allGuaranteesNode << std::endl;
   #endif
   if(allGuaranteesNode)
   {
      if(allGuaranteesNode->Attribute("href") || allGuaranteesNode->Attribute("id"))
      {
          if(allGuaranteesNode->Attribute("id"))
          {
             allGuaranteesIDRef_ = allGuaranteesNode->Attribute("id");
             allGuarantees_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(allGuaranteesNode));
             allGuarantees_->setID(allGuaranteesIDRef_);
             IDManager::instance().setID(allGuaranteesIDRef_,allGuarantees_);
          }
          else if(allGuaranteesNode->Attribute("href")) { allGuaranteesIDRef_ = allGuaranteesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { allGuarantees_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(allGuaranteesNode));}
   }

   //referencePriceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referencePriceNode = xmlNode->FirstChildElement("referencePrice");

   if(referencePriceNode){referencePriceIsNull_ = false;}
   else{referencePriceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referencePriceNode , address : " << referencePriceNode << std::endl;
   #endif
   if(referencePriceNode)
   {
      if(referencePriceNode->Attribute("href") || referencePriceNode->Attribute("id"))
      {
          if(referencePriceNode->Attribute("id"))
          {
             referencePriceIDRef_ = referencePriceNode->Attribute("id");
             referencePrice_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(referencePriceNode));
             referencePrice_->setID(referencePriceIDRef_);
             IDManager::instance().setID(referencePriceIDRef_,referencePrice_);
          }
          else if(referencePriceNode->Attribute("href")) { referencePriceIDRef_ = referencePriceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { referencePrice_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(referencePriceNode));}
   }

   //referencePolicyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referencePolicyNode = xmlNode->FirstChildElement("referencePolicy");

   if(referencePolicyNode){referencePolicyIsNull_ = false;}
   else{referencePolicyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referencePolicyNode , address : " << referencePolicyNode << std::endl;
   #endif
   if(referencePolicyNode)
   {
      if(referencePolicyNode->Attribute("href") || referencePolicyNode->Attribute("id"))
      {
          if(referencePolicyNode->Attribute("id"))
          {
             referencePolicyIDRef_ = referencePolicyNode->Attribute("id");
             referencePolicy_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(referencePolicyNode));
             referencePolicy_->setID(referencePolicyIDRef_);
             IDManager::instance().setID(referencePolicyIDRef_,referencePolicy_);
          }
          else if(referencePolicyNode->Attribute("href")) { referencePolicyIDRef_ = referencePolicyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { referencePolicy_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(referencePolicyNode));}
   }

   //securedListNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* securedListNode = xmlNode->FirstChildElement("securedList");

   if(securedListNode){securedListIsNull_ = false;}
   else{securedListIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- securedListNode , address : " << securedListNode << std::endl;
   #endif
   if(securedListNode)
   {
      if(securedListNode->Attribute("href") || securedListNode->Attribute("id"))
      {
          if(securedListNode->Attribute("id"))
          {
             securedListIDRef_ = securedListNode->Attribute("id");
             securedList_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(securedListNode));
             securedList_->setID(securedListIDRef_);
             IDManager::instance().setID(securedListIDRef_,securedList_);
          }
          else if(securedListNode->Attribute("href")) { securedListIDRef_ = securedListNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { securedList_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(securedListNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<LegalEntity> ReferenceInformation::getReferenceEntity()
{
   if(!this->referenceEntityIsNull_){
        if(referenceEntityIDRef_ != ""){
             return boost::shared_static_cast<LegalEntity>(IDManager::instance().getID(referenceEntityIDRef_));
        }else{
             return this->referenceEntity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<LegalEntity>();
   }
}
std::vector<boost::shared_ptr<ReferenceObligation>> ReferenceInformation::getReferenceObligation()
{
   if(!this->referenceObligationIsNull_){
        if(referenceObligationIDRef_ != ""){
             return this->referenceObligation_;
        }else{
             return this->referenceObligation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ReferenceObligation>>();
   }
}
boost::shared_ptr<XsdTypeBoolean> ReferenceInformation::getNoReferenceObligation()
{
   if(!this->noReferenceObligationIsNull_){
        if(noReferenceObligationIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(noReferenceObligationIDRef_));
        }else{
             return this->noReferenceObligation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> ReferenceInformation::getUnknownReferenceObligation()
{
   if(!this->unknownReferenceObligationIsNull_){
        if(unknownReferenceObligationIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(unknownReferenceObligationIDRef_));
        }else{
             return this->unknownReferenceObligation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> ReferenceInformation::getAllGuarantees()
{
   if(!this->allGuaranteesIsNull_){
        if(allGuaranteesIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(allGuaranteesIDRef_));
        }else{
             return this->allGuarantees_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeDecimal> ReferenceInformation::getReferencePrice()
{
   if(!this->referencePriceIsNull_){
        if(referencePriceIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(referencePriceIDRef_));
        }else{
             return this->referencePrice_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeBoolean> ReferenceInformation::getReferencePolicy()
{
   if(!this->referencePolicyIsNull_){
        if(referencePolicyIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(referencePolicyIDRef_));
        }else{
             return this->referencePolicy_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> ReferenceInformation::getSecuredList()
{
   if(!this->securedListIsNull_){
        if(securedListIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(securedListIDRef_));
        }else{
             return this->securedList_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

