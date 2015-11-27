// Documentation.cpp 
#include "Documentation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Documentation::Documentation(TiXmlNode* xmlNode)
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

   //masterConfirmationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* masterConfirmationNode = xmlNode->FirstChildElement("masterConfirmation");

   if(masterConfirmationNode){masterConfirmationIsNull_ = false;}
   else{masterConfirmationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- masterConfirmationNode , address : " << masterConfirmationNode << std::endl;
   #endif
   if(masterConfirmationNode)
   {
      if(masterConfirmationNode->Attribute("href") || masterConfirmationNode->Attribute("id"))
      {
          if(masterConfirmationNode->Attribute("id"))
          {
             masterConfirmationIDRef_ = masterConfirmationNode->Attribute("id");
             masterConfirmation_ = boost::shared_ptr<MasterConfirmation>(new MasterConfirmation(masterConfirmationNode));
             masterConfirmation_->setID(masterConfirmationIDRef_);
             IDManager::instance().setID(masterConfirmationIDRef_,masterConfirmation_);
          }
          else if(masterConfirmationNode->Attribute("href")) { masterConfirmationIDRef_ = masterConfirmationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { masterConfirmation_ = boost::shared_ptr<MasterConfirmation>(new MasterConfirmation(masterConfirmationNode));}
   }

   //brokerConfirmationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* brokerConfirmationNode = xmlNode->FirstChildElement("brokerConfirmation");

   if(brokerConfirmationNode){brokerConfirmationIsNull_ = false;}
   else{brokerConfirmationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- brokerConfirmationNode , address : " << brokerConfirmationNode << std::endl;
   #endif
   if(brokerConfirmationNode)
   {
      if(brokerConfirmationNode->Attribute("href") || brokerConfirmationNode->Attribute("id"))
      {
          if(brokerConfirmationNode->Attribute("id"))
          {
             brokerConfirmationIDRef_ = brokerConfirmationNode->Attribute("id");
             brokerConfirmation_ = boost::shared_ptr<BrokerConfirmation>(new BrokerConfirmation(brokerConfirmationNode));
             brokerConfirmation_->setID(brokerConfirmationIDRef_);
             IDManager::instance().setID(brokerConfirmationIDRef_,brokerConfirmation_);
          }
          else if(brokerConfirmationNode->Attribute("href")) { brokerConfirmationIDRef_ = brokerConfirmationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { brokerConfirmation_ = boost::shared_ptr<BrokerConfirmation>(new BrokerConfirmation(brokerConfirmationNode));}
   }

   //contractualDefinitionsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* contractualDefinitionsNode = xmlNode->FirstChildElement("contractualDefinitions");

   if(contractualDefinitionsNode){contractualDefinitionsIsNull_ = false;}
   else{contractualDefinitionsIsNull_ = true;}

   if(contractualDefinitionsNode)
   {
      for(contractualDefinitionsNode; contractualDefinitionsNode; contractualDefinitionsNode = contractualDefinitionsNode->NextSiblingElement("contractualDefinitions")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- contractualDefinitionsNode , address : " << contractualDefinitionsNode << std::endl;
          #endif
          if(contractualDefinitionsNode->Attribute("href") || contractualDefinitionsNode->Attribute("id"))
          {
              if(contractualDefinitionsNode->Attribute("id"))
              {
                  contractualDefinitionsIDRef_ = contractualDefinitionsNode->Attribute("id");
                  contractualDefinitions_.push_back(boost::shared_ptr<ContractualDefinitions>(new ContractualDefinitions(contractualDefinitionsNode)));
                  contractualDefinitions_.back()->setID(contractualDefinitionsIDRef_);
                  IDManager::instance().setID(contractualDefinitionsIDRef_, contractualDefinitions_.back());
              }
              else if(contractualDefinitionsNode->Attribute("href")) { contractualDefinitionsIDRef_ = contractualDefinitionsNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { contractualDefinitions_.push_back(boost::shared_ptr<ContractualDefinitions>(new ContractualDefinitions(contractualDefinitionsNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- contractualDefinitionsNode , address : " << contractualDefinitionsNode << std::endl;
       #endif
   }

   //contractualTermsSupplementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* contractualTermsSupplementNode = xmlNode->FirstChildElement("contractualTermsSupplement");

   if(contractualTermsSupplementNode){contractualTermsSupplementIsNull_ = false;}
   else{contractualTermsSupplementIsNull_ = true;}

   if(contractualTermsSupplementNode)
   {
      for(contractualTermsSupplementNode; contractualTermsSupplementNode; contractualTermsSupplementNode = contractualTermsSupplementNode->NextSiblingElement("contractualTermsSupplement")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- contractualTermsSupplementNode , address : " << contractualTermsSupplementNode << std::endl;
          #endif
          if(contractualTermsSupplementNode->Attribute("href") || contractualTermsSupplementNode->Attribute("id"))
          {
              if(contractualTermsSupplementNode->Attribute("id"))
              {
                  contractualTermsSupplementIDRef_ = contractualTermsSupplementNode->Attribute("id");
                  contractualTermsSupplement_.push_back(boost::shared_ptr<ContractualTermsSupplement>(new ContractualTermsSupplement(contractualTermsSupplementNode)));
                  contractualTermsSupplement_.back()->setID(contractualTermsSupplementIDRef_);
                  IDManager::instance().setID(contractualTermsSupplementIDRef_, contractualTermsSupplement_.back());
              }
              else if(contractualTermsSupplementNode->Attribute("href")) { contractualTermsSupplementIDRef_ = contractualTermsSupplementNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { contractualTermsSupplement_.push_back(boost::shared_ptr<ContractualTermsSupplement>(new ContractualTermsSupplement(contractualTermsSupplementNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- contractualTermsSupplementNode , address : " << contractualTermsSupplementNode << std::endl;
       #endif
   }

   //contractualMatrixNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* contractualMatrixNode = xmlNode->FirstChildElement("contractualMatrix");

   if(contractualMatrixNode){contractualMatrixIsNull_ = false;}
   else{contractualMatrixIsNull_ = true;}

   if(contractualMatrixNode)
   {
      for(contractualMatrixNode; contractualMatrixNode; contractualMatrixNode = contractualMatrixNode->NextSiblingElement("contractualMatrix")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- contractualMatrixNode , address : " << contractualMatrixNode << std::endl;
          #endif
          if(contractualMatrixNode->Attribute("href") || contractualMatrixNode->Attribute("id"))
          {
              if(contractualMatrixNode->Attribute("id"))
              {
                  contractualMatrixIDRef_ = contractualMatrixNode->Attribute("id");
                  contractualMatrix_.push_back(boost::shared_ptr<ContractualMatrix>(new ContractualMatrix(contractualMatrixNode)));
                  contractualMatrix_.back()->setID(contractualMatrixIDRef_);
                  IDManager::instance().setID(contractualMatrixIDRef_, contractualMatrix_.back());
              }
              else if(contractualMatrixNode->Attribute("href")) { contractualMatrixIDRef_ = contractualMatrixNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { contractualMatrix_.push_back(boost::shared_ptr<ContractualMatrix>(new ContractualMatrix(contractualMatrixNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- contractualMatrixNode , address : " << contractualMatrixNode << std::endl;
       #endif
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

   //attachmentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* attachmentNode = xmlNode->FirstChildElement("attachment");

   if(attachmentNode){attachmentIsNull_ = false;}
   else{attachmentIsNull_ = true;}

   if(attachmentNode)
   {
      for(attachmentNode; attachmentNode; attachmentNode = attachmentNode->NextSiblingElement("attachment")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- attachmentNode , address : " << attachmentNode << std::endl;
          #endif
          if(attachmentNode->Attribute("href") || attachmentNode->Attribute("id"))
          {
              if(attachmentNode->Attribute("id"))
              {
                  attachmentIDRef_ = attachmentNode->Attribute("id");
                  attachment_.push_back(boost::shared_ptr<Resource>(new Resource(attachmentNode)));
                  attachment_.back()->setID(attachmentIDRef_);
                  IDManager::instance().setID(attachmentIDRef_, attachment_.back());
              }
              else if(attachmentNode->Attribute("href")) { attachmentIDRef_ = attachmentNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { attachment_.push_back(boost::shared_ptr<Resource>(new Resource(attachmentNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- attachmentNode , address : " << attachmentNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<MasterAgreement> Documentation::getMasterAgreement()
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
boost::shared_ptr<MasterConfirmation> Documentation::getMasterConfirmation()
{
   if(!this->masterConfirmationIsNull_){
        if(masterConfirmationIDRef_ != ""){
             return boost::shared_static_cast<MasterConfirmation>(IDManager::instance().getID(masterConfirmationIDRef_));
        }else{
             return this->masterConfirmation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MasterConfirmation>();
   }
}
boost::shared_ptr<BrokerConfirmation> Documentation::getBrokerConfirmation()
{
   if(!this->brokerConfirmationIsNull_){
        if(brokerConfirmationIDRef_ != ""){
             return boost::shared_static_cast<BrokerConfirmation>(IDManager::instance().getID(brokerConfirmationIDRef_));
        }else{
             return this->brokerConfirmation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BrokerConfirmation>();
   }
}
std::vector<boost::shared_ptr<ContractualDefinitions>> Documentation::getContractualDefinitions()
{
   if(!this->contractualDefinitionsIsNull_){
        if(contractualDefinitionsIDRef_ != ""){
             return this->contractualDefinitions_;
        }else{
             return this->contractualDefinitions_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ContractualDefinitions>>();
   }
}
std::vector<boost::shared_ptr<ContractualTermsSupplement>> Documentation::getContractualTermsSupplement()
{
   if(!this->contractualTermsSupplementIsNull_){
        if(contractualTermsSupplementIDRef_ != ""){
             return this->contractualTermsSupplement_;
        }else{
             return this->contractualTermsSupplement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ContractualTermsSupplement>>();
   }
}
std::vector<boost::shared_ptr<ContractualMatrix>> Documentation::getContractualMatrix()
{
   if(!this->contractualMatrixIsNull_){
        if(contractualMatrixIDRef_ != ""){
             return this->contractualMatrix_;
        }else{
             return this->contractualMatrix_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ContractualMatrix>>();
   }
}
boost::shared_ptr<CreditSupportAgreement> Documentation::getCreditSupportAgreement()
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
std::vector<boost::shared_ptr<Resource>> Documentation::getAttachment()
{
   if(!this->attachmentIsNull_){
        if(attachmentIDRef_ != ""){
             return this->attachment_;
        }else{
             return this->attachment_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Resource>>();
   }
}
}

