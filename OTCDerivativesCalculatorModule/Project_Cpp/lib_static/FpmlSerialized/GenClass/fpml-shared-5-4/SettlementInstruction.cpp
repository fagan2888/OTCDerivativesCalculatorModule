// SettlementInstruction.cpp 
#include "SettlementInstruction.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SettlementInstruction::SettlementInstruction(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //settlementMethodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementMethodNode = xmlNode->FirstChildElement("settlementMethod");

   if(settlementMethodNode){settlementMethodIsNull_ = false;}
   else{settlementMethodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementMethodNode , address : " << settlementMethodNode << std::endl;
   #endif
   if(settlementMethodNode)
   {
      if(settlementMethodNode->Attribute("href") || settlementMethodNode->Attribute("id"))
      {
          if(settlementMethodNode->Attribute("id"))
          {
             settlementMethodIDRef_ = settlementMethodNode->Attribute("id");
             settlementMethod_ = boost::shared_ptr<SettlementMethod>(new SettlementMethod(settlementMethodNode));
             settlementMethod_->setID(settlementMethodIDRef_);
             IDManager::instance().setID(settlementMethodIDRef_,settlementMethod_);
          }
          else if(settlementMethodNode->Attribute("href")) { settlementMethodIDRef_ = settlementMethodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { settlementMethod_ = boost::shared_ptr<SettlementMethod>(new SettlementMethod(settlementMethodNode));}
   }

   //correspondentInformationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* correspondentInformationNode = xmlNode->FirstChildElement("correspondentInformation");

   if(correspondentInformationNode){correspondentInformationIsNull_ = false;}
   else{correspondentInformationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- correspondentInformationNode , address : " << correspondentInformationNode << std::endl;
   #endif
   if(correspondentInformationNode)
   {
      if(correspondentInformationNode->Attribute("href") || correspondentInformationNode->Attribute("id"))
      {
          if(correspondentInformationNode->Attribute("id"))
          {
             correspondentInformationIDRef_ = correspondentInformationNode->Attribute("id");
             correspondentInformation_ = boost::shared_ptr<CorrespondentInformation>(new CorrespondentInformation(correspondentInformationNode));
             correspondentInformation_->setID(correspondentInformationIDRef_);
             IDManager::instance().setID(correspondentInformationIDRef_,correspondentInformation_);
          }
          else if(correspondentInformationNode->Attribute("href")) { correspondentInformationIDRef_ = correspondentInformationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { correspondentInformation_ = boost::shared_ptr<CorrespondentInformation>(new CorrespondentInformation(correspondentInformationNode));}
   }

   //intermediaryInformationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* intermediaryInformationNode = xmlNode->FirstChildElement("intermediaryInformation");

   if(intermediaryInformationNode){intermediaryInformationIsNull_ = false;}
   else{intermediaryInformationIsNull_ = true;}

   if(intermediaryInformationNode)
   {
      for(intermediaryInformationNode; intermediaryInformationNode; intermediaryInformationNode = intermediaryInformationNode->NextSiblingElement("intermediaryInformation")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- intermediaryInformationNode , address : " << intermediaryInformationNode << std::endl;
          #endif
          if(intermediaryInformationNode->Attribute("href") || intermediaryInformationNode->Attribute("id"))
          {
              if(intermediaryInformationNode->Attribute("id"))
              {
                  intermediaryInformationIDRef_ = intermediaryInformationNode->Attribute("id");
                  intermediaryInformation_.push_back(boost::shared_ptr<IntermediaryInformation>(new IntermediaryInformation(intermediaryInformationNode)));
                  intermediaryInformation_.back()->setID(intermediaryInformationIDRef_);
                  IDManager::instance().setID(intermediaryInformationIDRef_, intermediaryInformation_.back());
              }
              else if(intermediaryInformationNode->Attribute("href")) { intermediaryInformationIDRef_ = intermediaryInformationNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { intermediaryInformation_.push_back(boost::shared_ptr<IntermediaryInformation>(new IntermediaryInformation(intermediaryInformationNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- intermediaryInformationNode , address : " << intermediaryInformationNode << std::endl;
       #endif
   }

   //beneficiaryBankNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* beneficiaryBankNode = xmlNode->FirstChildElement("beneficiaryBank");

   if(beneficiaryBankNode){beneficiaryBankIsNull_ = false;}
   else{beneficiaryBankIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- beneficiaryBankNode , address : " << beneficiaryBankNode << std::endl;
   #endif
   if(beneficiaryBankNode)
   {
      if(beneficiaryBankNode->Attribute("href") || beneficiaryBankNode->Attribute("id"))
      {
          if(beneficiaryBankNode->Attribute("id"))
          {
             beneficiaryBankIDRef_ = beneficiaryBankNode->Attribute("id");
             beneficiaryBank_ = boost::shared_ptr<Beneficiary>(new Beneficiary(beneficiaryBankNode));
             beneficiaryBank_->setID(beneficiaryBankIDRef_);
             IDManager::instance().setID(beneficiaryBankIDRef_,beneficiaryBank_);
          }
          else if(beneficiaryBankNode->Attribute("href")) { beneficiaryBankIDRef_ = beneficiaryBankNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { beneficiaryBank_ = boost::shared_ptr<Beneficiary>(new Beneficiary(beneficiaryBankNode));}
   }

   //beneficiaryNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* beneficiaryNode = xmlNode->FirstChildElement("beneficiary");

   if(beneficiaryNode){beneficiaryIsNull_ = false;}
   else{beneficiaryIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- beneficiaryNode , address : " << beneficiaryNode << std::endl;
   #endif
   if(beneficiaryNode)
   {
      if(beneficiaryNode->Attribute("href") || beneficiaryNode->Attribute("id"))
      {
          if(beneficiaryNode->Attribute("id"))
          {
             beneficiaryIDRef_ = beneficiaryNode->Attribute("id");
             beneficiary_ = boost::shared_ptr<Beneficiary>(new Beneficiary(beneficiaryNode));
             beneficiary_->setID(beneficiaryIDRef_);
             IDManager::instance().setID(beneficiaryIDRef_,beneficiary_);
          }
          else if(beneficiaryNode->Attribute("href")) { beneficiaryIDRef_ = beneficiaryNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { beneficiary_ = boost::shared_ptr<Beneficiary>(new Beneficiary(beneficiaryNode));}
   }

   //depositoryPartyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* depositoryPartyReferenceNode = xmlNode->FirstChildElement("depositoryPartyReference");

   if(depositoryPartyReferenceNode){depositoryPartyReferenceIsNull_ = false;}
   else{depositoryPartyReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- depositoryPartyReferenceNode , address : " << depositoryPartyReferenceNode << std::endl;
   #endif
   if(depositoryPartyReferenceNode)
   {
      if(depositoryPartyReferenceNode->Attribute("href") || depositoryPartyReferenceNode->Attribute("id"))
      {
          if(depositoryPartyReferenceNode->Attribute("id"))
          {
             depositoryPartyReferenceIDRef_ = depositoryPartyReferenceNode->Attribute("id");
             depositoryPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(depositoryPartyReferenceNode));
             depositoryPartyReference_->setID(depositoryPartyReferenceIDRef_);
             IDManager::instance().setID(depositoryPartyReferenceIDRef_,depositoryPartyReference_);
          }
          else if(depositoryPartyReferenceNode->Attribute("href")) { depositoryPartyReferenceIDRef_ = depositoryPartyReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { depositoryPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(depositoryPartyReferenceNode));}
   }

   //splitSettlementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* splitSettlementNode = xmlNode->FirstChildElement("splitSettlement");

   if(splitSettlementNode){splitSettlementIsNull_ = false;}
   else{splitSettlementIsNull_ = true;}

   if(splitSettlementNode)
   {
      for(splitSettlementNode; splitSettlementNode; splitSettlementNode = splitSettlementNode->NextSiblingElement("splitSettlement")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- splitSettlementNode , address : " << splitSettlementNode << std::endl;
          #endif
          if(splitSettlementNode->Attribute("href") || splitSettlementNode->Attribute("id"))
          {
              if(splitSettlementNode->Attribute("id"))
              {
                  splitSettlementIDRef_ = splitSettlementNode->Attribute("id");
                  splitSettlement_.push_back(boost::shared_ptr<SplitSettlement>(new SplitSettlement(splitSettlementNode)));
                  splitSettlement_.back()->setID(splitSettlementIDRef_);
                  IDManager::instance().setID(splitSettlementIDRef_, splitSettlement_.back());
              }
              else if(splitSettlementNode->Attribute("href")) { splitSettlementIDRef_ = splitSettlementNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { splitSettlement_.push_back(boost::shared_ptr<SplitSettlement>(new SplitSettlement(splitSettlementNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- splitSettlementNode , address : " << splitSettlementNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<SettlementMethod> SettlementInstruction::getSettlementMethod()
{
   if(!this->settlementMethodIsNull_){
        if(settlementMethodIDRef_ != ""){
             return boost::shared_static_cast<SettlementMethod>(IDManager::instance().getID(settlementMethodIDRef_));
        }else{
             return this->settlementMethod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SettlementMethod>();
   }
}
boost::shared_ptr<CorrespondentInformation> SettlementInstruction::getCorrespondentInformation()
{
   if(!this->correspondentInformationIsNull_){
        if(correspondentInformationIDRef_ != ""){
             return boost::shared_static_cast<CorrespondentInformation>(IDManager::instance().getID(correspondentInformationIDRef_));
        }else{
             return this->correspondentInformation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CorrespondentInformation>();
   }
}
std::vector<boost::shared_ptr<IntermediaryInformation>> SettlementInstruction::getIntermediaryInformation()
{
   if(!this->intermediaryInformationIsNull_){
        if(intermediaryInformationIDRef_ != ""){
             return this->intermediaryInformation_;
        }else{
             return this->intermediaryInformation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<IntermediaryInformation>>();
   }
}
boost::shared_ptr<Beneficiary> SettlementInstruction::getBeneficiaryBank()
{
   if(!this->beneficiaryBankIsNull_){
        if(beneficiaryBankIDRef_ != ""){
             return boost::shared_static_cast<Beneficiary>(IDManager::instance().getID(beneficiaryBankIDRef_));
        }else{
             return this->beneficiaryBank_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Beneficiary>();
   }
}
boost::shared_ptr<Beneficiary> SettlementInstruction::getBeneficiary()
{
   if(!this->beneficiaryIsNull_){
        if(beneficiaryIDRef_ != ""){
             return boost::shared_static_cast<Beneficiary>(IDManager::instance().getID(beneficiaryIDRef_));
        }else{
             return this->beneficiary_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Beneficiary>();
   }
}
boost::shared_ptr<PartyReference> SettlementInstruction::getDepositoryPartyReference()
{
   if(!this->depositoryPartyReferenceIsNull_){
        if(depositoryPartyReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(depositoryPartyReferenceIDRef_));
        }else{
             return this->depositoryPartyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
std::vector<boost::shared_ptr<SplitSettlement>> SettlementInstruction::getSplitSettlement()
{
   if(!this->splitSettlementIsNull_){
        if(splitSettlementIDRef_ != ""){
             return this->splitSettlement_;
        }else{
             return this->splitSettlement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<SplitSettlement>>();
   }
}
}

