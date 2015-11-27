// PartyRelationshipDocumentation.cpp 
#include "PartyRelationshipDocumentation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PartyRelationshipDocumentation::PartyRelationshipDocumentation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //masterAgreementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* masterAgreementNode = xmlNode->FirstChildElement("masterAgreement");

   if(masterAgreementNode){masterAgreementIsNull_ = false;}
   else{masterAgreementIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- masterAgreementNode , address : " << masterAgreementNode << std::endl;
   #endif
   if(masterAgreementNode)
   {
      if(masterAgreementNode->Attribute("href") || masterAgreementNode->Attribute("id"))
      {
          if(masterAgreementNode->Attribute("id"))
          {
             masterAgreementIDRef_ = masterAgreementNode->Attribute("id");
             masterAgreement_ = boost::shared_ptr<MasterAgreement>(new MasterAgreement(masterAgreementNode));
             masterAgreement_->setID(masterAgreementIDRef_);
             IDManager::instance().setID(masterAgreementIDRef_,masterAgreement_);
          }
          else if(masterAgreementNode->Attribute("href")) { masterAgreementIDRef_ = masterAgreementNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { masterAgreement_ = boost::shared_ptr<MasterAgreement>(new MasterAgreement(masterAgreementNode));}
   }

   //creditSupportAgreementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* creditSupportAgreementNode = xmlNode->FirstChildElement("creditSupportAgreement");

   if(creditSupportAgreementNode){creditSupportAgreementIsNull_ = false;}
   else{creditSupportAgreementIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- creditSupportAgreementNode , address : " << creditSupportAgreementNode << std::endl;
   #endif
   if(creditSupportAgreementNode)
   {
      if(creditSupportAgreementNode->Attribute("href") || creditSupportAgreementNode->Attribute("id"))
      {
          if(creditSupportAgreementNode->Attribute("id"))
          {
             creditSupportAgreementIDRef_ = creditSupportAgreementNode->Attribute("id");
             creditSupportAgreement_ = boost::shared_ptr<CreditSupportAgreement>(new CreditSupportAgreement(creditSupportAgreementNode));
             creditSupportAgreement_->setID(creditSupportAgreementIDRef_);
             IDManager::instance().setID(creditSupportAgreementIDRef_,creditSupportAgreement_);
          }
          else if(creditSupportAgreementNode->Attribute("href")) { creditSupportAgreementIDRef_ = creditSupportAgreementNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { creditSupportAgreement_ = boost::shared_ptr<CreditSupportAgreement>(new CreditSupportAgreement(creditSupportAgreementNode));}
   }

   //agreementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* agreementNode = xmlNode->FirstChildElement("agreement");

   if(agreementNode){agreementIsNull_ = false;}
   else{agreementIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- agreementNode , address : " << agreementNode << std::endl;
   #endif
   if(agreementNode)
   {
      if(agreementNode->Attribute("href") || agreementNode->Attribute("id"))
      {
          if(agreementNode->Attribute("id"))
          {
             agreementIDRef_ = agreementNode->Attribute("id");
             agreement_ = boost::shared_ptr<GenericAgreement>(new GenericAgreement(agreementNode));
             agreement_->setID(agreementIDRef_);
             IDManager::instance().setID(agreementIDRef_,agreement_);
          }
          else if(agreementNode->Attribute("href")) { agreementIDRef_ = agreementNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { agreement_ = boost::shared_ptr<GenericAgreement>(new GenericAgreement(agreementNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<MasterAgreement> PartyRelationshipDocumentation::getMasterAgreement()
{
   if(!this->masterAgreementIsNull_){
        if(masterAgreementIDRef_ != ""){
             return boost::shared_static_cast<MasterAgreement>(IDManager::instance().getID(masterAgreementIDRef_));
        }else{
             return this->masterAgreement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MasterAgreement>();
   }
}
boost::shared_ptr<CreditSupportAgreement> PartyRelationshipDocumentation::getCreditSupportAgreement()
{
   if(!this->creditSupportAgreementIsNull_){
        if(creditSupportAgreementIDRef_ != ""){
             return boost::shared_static_cast<CreditSupportAgreement>(IDManager::instance().getID(creditSupportAgreementIDRef_));
        }else{
             return this->creditSupportAgreement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CreditSupportAgreement>();
   }
}
boost::shared_ptr<GenericAgreement> PartyRelationshipDocumentation::getAgreement()
{
   if(!this->agreementIsNull_){
        if(agreementIDRef_ != ""){
             return boost::shared_static_cast<GenericAgreement>(IDManager::instance().getID(agreementIDRef_));
        }else{
             return this->agreement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<GenericAgreement>();
   }
}
}

