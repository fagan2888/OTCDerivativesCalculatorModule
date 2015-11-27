// CreditEventNoticeDocument.cpp 
#include "CreditEventNoticeDocument.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CreditEventNoticeDocument::CreditEventNoticeDocument(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //affectedTransactionsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* affectedTransactionsNode = xmlNode->FirstChildElement("affectedTransactions");

   if(affectedTransactionsNode){affectedTransactionsIsNull_ = false;}
   else{affectedTransactionsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- affectedTransactionsNode , address : " << affectedTransactionsNode << std::endl;
   #endif
   if(affectedTransactionsNode)
   {
      if(affectedTransactionsNode->Attribute("href") || affectedTransactionsNode->Attribute("id"))
      {
          if(affectedTransactionsNode->Attribute("id"))
          {
             affectedTransactionsIDRef_ = affectedTransactionsNode->Attribute("id");
             affectedTransactions_ = boost::shared_ptr<AffectedTransactions>(new AffectedTransactions(affectedTransactionsNode));
             affectedTransactions_->setID(affectedTransactionsIDRef_);
             IDManager::instance().setID(affectedTransactionsIDRef_,affectedTransactions_);
          }
          else if(affectedTransactionsNode->Attribute("href")) { affectedTransactionsIDRef_ = affectedTransactionsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { affectedTransactions_ = boost::shared_ptr<AffectedTransactions>(new AffectedTransactions(affectedTransactionsNode));}
   }

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

   //creditEventNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* creditEventNode = xmlNode->FirstChildElement("creditEvent");

   if(creditEventNode){creditEventIsNull_ = false;}
   else{creditEventIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- creditEventNode , address : " << creditEventNode << std::endl;
   #endif
   if(creditEventNode)
   {
      if(creditEventNode->Attribute("href") || creditEventNode->Attribute("id"))
      {
          if(creditEventNode->Attribute("id"))
          {
             creditEventIDRef_ = creditEventNode->Attribute("id");
             creditEvent_ = boost::shared_ptr<CreditEvent>(new CreditEvent(creditEventNode));
             creditEvent_->setID(creditEventIDRef_);
             IDManager::instance().setID(creditEventIDRef_,creditEvent_);
          }
          else if(creditEventNode->Attribute("href")) { creditEventIDRef_ = creditEventNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { creditEvent_ = boost::shared_ptr<CreditEvent>(new CreditEvent(creditEventNode));}
   }

   //bankruptcyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* bankruptcyNode = xmlNode->FirstChildElement("bankruptcy");

   if(bankruptcyNode){bankruptcyIsNull_ = false;}
   else{bankruptcyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- bankruptcyNode , address : " << bankruptcyNode << std::endl;
   #endif
   if(bankruptcyNode)
   {
      if(bankruptcyNode->Attribute("href") || bankruptcyNode->Attribute("id"))
      {
          if(bankruptcyNode->Attribute("id"))
          {
             bankruptcyIDRef_ = bankruptcyNode->Attribute("id");
             bankruptcy_ = boost::shared_ptr<BankruptcyEvent>(new BankruptcyEvent(bankruptcyNode));
             bankruptcy_->setID(bankruptcyIDRef_);
             IDManager::instance().setID(bankruptcyIDRef_,bankruptcy_);
          }
          else if(bankruptcyNode->Attribute("href")) { bankruptcyIDRef_ = bankruptcyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { bankruptcy_ = boost::shared_ptr<BankruptcyEvent>(new BankruptcyEvent(bankruptcyNode));}
   }

   //failureToPayNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* failureToPayNode = xmlNode->FirstChildElement("failureToPay");

   if(failureToPayNode){failureToPayIsNull_ = false;}
   else{failureToPayIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- failureToPayNode , address : " << failureToPayNode << std::endl;
   #endif
   if(failureToPayNode)
   {
      if(failureToPayNode->Attribute("href") || failureToPayNode->Attribute("id"))
      {
          if(failureToPayNode->Attribute("id"))
          {
             failureToPayIDRef_ = failureToPayNode->Attribute("id");
             failureToPay_ = boost::shared_ptr<FailureToPayEvent>(new FailureToPayEvent(failureToPayNode));
             failureToPay_->setID(failureToPayIDRef_);
             IDManager::instance().setID(failureToPayIDRef_,failureToPay_);
          }
          else if(failureToPayNode->Attribute("href")) { failureToPayIDRef_ = failureToPayNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { failureToPay_ = boost::shared_ptr<FailureToPayEvent>(new FailureToPayEvent(failureToPayNode));}
   }

   //obligationAccelerationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* obligationAccelerationNode = xmlNode->FirstChildElement("obligationAcceleration");

   if(obligationAccelerationNode){obligationAccelerationIsNull_ = false;}
   else{obligationAccelerationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- obligationAccelerationNode , address : " << obligationAccelerationNode << std::endl;
   #endif
   if(obligationAccelerationNode)
   {
      if(obligationAccelerationNode->Attribute("href") || obligationAccelerationNode->Attribute("id"))
      {
          if(obligationAccelerationNode->Attribute("id"))
          {
             obligationAccelerationIDRef_ = obligationAccelerationNode->Attribute("id");
             obligationAcceleration_ = boost::shared_ptr<ObligationAccelerationEvent>(new ObligationAccelerationEvent(obligationAccelerationNode));
             obligationAcceleration_->setID(obligationAccelerationIDRef_);
             IDManager::instance().setID(obligationAccelerationIDRef_,obligationAcceleration_);
          }
          else if(obligationAccelerationNode->Attribute("href")) { obligationAccelerationIDRef_ = obligationAccelerationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { obligationAcceleration_ = boost::shared_ptr<ObligationAccelerationEvent>(new ObligationAccelerationEvent(obligationAccelerationNode));}
   }

   //obligationDefaultNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* obligationDefaultNode = xmlNode->FirstChildElement("obligationDefault");

   if(obligationDefaultNode){obligationDefaultIsNull_ = false;}
   else{obligationDefaultIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- obligationDefaultNode , address : " << obligationDefaultNode << std::endl;
   #endif
   if(obligationDefaultNode)
   {
      if(obligationDefaultNode->Attribute("href") || obligationDefaultNode->Attribute("id"))
      {
          if(obligationDefaultNode->Attribute("id"))
          {
             obligationDefaultIDRef_ = obligationDefaultNode->Attribute("id");
             obligationDefault_ = boost::shared_ptr<ObligationDefaultEvent>(new ObligationDefaultEvent(obligationDefaultNode));
             obligationDefault_->setID(obligationDefaultIDRef_);
             IDManager::instance().setID(obligationDefaultIDRef_,obligationDefault_);
          }
          else if(obligationDefaultNode->Attribute("href")) { obligationDefaultIDRef_ = obligationDefaultNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { obligationDefault_ = boost::shared_ptr<ObligationDefaultEvent>(new ObligationDefaultEvent(obligationDefaultNode));}
   }

   //repudiationMoratoriumNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* repudiationMoratoriumNode = xmlNode->FirstChildElement("repudiationMoratorium");

   if(repudiationMoratoriumNode){repudiationMoratoriumIsNull_ = false;}
   else{repudiationMoratoriumIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- repudiationMoratoriumNode , address : " << repudiationMoratoriumNode << std::endl;
   #endif
   if(repudiationMoratoriumNode)
   {
      if(repudiationMoratoriumNode->Attribute("href") || repudiationMoratoriumNode->Attribute("id"))
      {
          if(repudiationMoratoriumNode->Attribute("id"))
          {
             repudiationMoratoriumIDRef_ = repudiationMoratoriumNode->Attribute("id");
             repudiationMoratorium_ = boost::shared_ptr<RepudiationMoratoriumEvent>(new RepudiationMoratoriumEvent(repudiationMoratoriumNode));
             repudiationMoratorium_->setID(repudiationMoratoriumIDRef_);
             IDManager::instance().setID(repudiationMoratoriumIDRef_,repudiationMoratorium_);
          }
          else if(repudiationMoratoriumNode->Attribute("href")) { repudiationMoratoriumIDRef_ = repudiationMoratoriumNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { repudiationMoratorium_ = boost::shared_ptr<RepudiationMoratoriumEvent>(new RepudiationMoratoriumEvent(repudiationMoratoriumNode));}
   }

   //restructuringNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* restructuringNode = xmlNode->FirstChildElement("restructuring");

   if(restructuringNode){restructuringIsNull_ = false;}
   else{restructuringIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- restructuringNode , address : " << restructuringNode << std::endl;
   #endif
   if(restructuringNode)
   {
      if(restructuringNode->Attribute("href") || restructuringNode->Attribute("id"))
      {
          if(restructuringNode->Attribute("id"))
          {
             restructuringIDRef_ = restructuringNode->Attribute("id");
             restructuring_ = boost::shared_ptr<RestructuringEvent>(new RestructuringEvent(restructuringNode));
             restructuring_->setID(restructuringIDRef_);
             IDManager::instance().setID(restructuringIDRef_,restructuring_);
          }
          else if(restructuringNode->Attribute("href")) { restructuringIDRef_ = restructuringNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { restructuring_ = boost::shared_ptr<RestructuringEvent>(new RestructuringEvent(restructuringNode));}
   }

   //publiclyAvailableInformationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* publiclyAvailableInformationNode = xmlNode->FirstChildElement("publiclyAvailableInformation");

   if(publiclyAvailableInformationNode){publiclyAvailableInformationIsNull_ = false;}
   else{publiclyAvailableInformationIsNull_ = true;}

   if(publiclyAvailableInformationNode)
   {
      for(publiclyAvailableInformationNode; publiclyAvailableInformationNode; publiclyAvailableInformationNode = publiclyAvailableInformationNode->NextSiblingElement("publiclyAvailableInformation")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- publiclyAvailableInformationNode , address : " << publiclyAvailableInformationNode << std::endl;
          #endif
          if(publiclyAvailableInformationNode->Attribute("href") || publiclyAvailableInformationNode->Attribute("id"))
          {
              if(publiclyAvailableInformationNode->Attribute("id"))
              {
                  publiclyAvailableInformationIDRef_ = publiclyAvailableInformationNode->Attribute("id");
                  publiclyAvailableInformation_.push_back(boost::shared_ptr<Resource>(new Resource(publiclyAvailableInformationNode)));
                  publiclyAvailableInformation_.back()->setID(publiclyAvailableInformationIDRef_);
                  IDManager::instance().setID(publiclyAvailableInformationIDRef_, publiclyAvailableInformation_.back());
              }
              else if(publiclyAvailableInformationNode->Attribute("href")) { publiclyAvailableInformationIDRef_ = publiclyAvailableInformationNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { publiclyAvailableInformation_.push_back(boost::shared_ptr<Resource>(new Resource(publiclyAvailableInformationNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- publiclyAvailableInformationNode , address : " << publiclyAvailableInformationNode << std::endl;
       #endif
   }

   //notifyingPartyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notifyingPartyReferenceNode = xmlNode->FirstChildElement("notifyingPartyReference");

   if(notifyingPartyReferenceNode){notifyingPartyReferenceIsNull_ = false;}
   else{notifyingPartyReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notifyingPartyReferenceNode , address : " << notifyingPartyReferenceNode << std::endl;
   #endif
   if(notifyingPartyReferenceNode)
   {
      if(notifyingPartyReferenceNode->Attribute("href") || notifyingPartyReferenceNode->Attribute("id"))
      {
          if(notifyingPartyReferenceNode->Attribute("id"))
          {
             notifyingPartyReferenceIDRef_ = notifyingPartyReferenceNode->Attribute("id");
             notifyingPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(notifyingPartyReferenceNode));
             notifyingPartyReference_->setID(notifyingPartyReferenceIDRef_);
             IDManager::instance().setID(notifyingPartyReferenceIDRef_,notifyingPartyReference_);
          }
          else if(notifyingPartyReferenceNode->Attribute("href")) { notifyingPartyReferenceIDRef_ = notifyingPartyReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notifyingPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(notifyingPartyReferenceNode));}
   }

   //notifiedPartyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notifiedPartyReferenceNode = xmlNode->FirstChildElement("notifiedPartyReference");

   if(notifiedPartyReferenceNode){notifiedPartyReferenceIsNull_ = false;}
   else{notifiedPartyReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notifiedPartyReferenceNode , address : " << notifiedPartyReferenceNode << std::endl;
   #endif
   if(notifiedPartyReferenceNode)
   {
      if(notifiedPartyReferenceNode->Attribute("href") || notifiedPartyReferenceNode->Attribute("id"))
      {
          if(notifiedPartyReferenceNode->Attribute("id"))
          {
             notifiedPartyReferenceIDRef_ = notifiedPartyReferenceNode->Attribute("id");
             notifiedPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(notifiedPartyReferenceNode));
             notifiedPartyReference_->setID(notifiedPartyReferenceIDRef_);
             IDManager::instance().setID(notifiedPartyReferenceIDRef_,notifiedPartyReference_);
          }
          else if(notifiedPartyReferenceNode->Attribute("href")) { notifiedPartyReferenceIDRef_ = notifiedPartyReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notifiedPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(notifiedPartyReferenceNode));}
   }

   //creditEventNoticeDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* creditEventNoticeDateNode = xmlNode->FirstChildElement("creditEventNoticeDate");

   if(creditEventNoticeDateNode){creditEventNoticeDateIsNull_ = false;}
   else{creditEventNoticeDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- creditEventNoticeDateNode , address : " << creditEventNoticeDateNode << std::endl;
   #endif
   if(creditEventNoticeDateNode)
   {
      if(creditEventNoticeDateNode->Attribute("href") || creditEventNoticeDateNode->Attribute("id"))
      {
          if(creditEventNoticeDateNode->Attribute("id"))
          {
             creditEventNoticeDateIDRef_ = creditEventNoticeDateNode->Attribute("id");
             creditEventNoticeDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(creditEventNoticeDateNode));
             creditEventNoticeDate_->setID(creditEventNoticeDateIDRef_);
             IDManager::instance().setID(creditEventNoticeDateIDRef_,creditEventNoticeDate_);
          }
          else if(creditEventNoticeDateNode->Attribute("href")) { creditEventNoticeDateIDRef_ = creditEventNoticeDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { creditEventNoticeDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(creditEventNoticeDateNode));}
   }

   //creditEventDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* creditEventDateNode = xmlNode->FirstChildElement("creditEventDate");

   if(creditEventDateNode){creditEventDateIsNull_ = false;}
   else{creditEventDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- creditEventDateNode , address : " << creditEventDateNode << std::endl;
   #endif
   if(creditEventDateNode)
   {
      if(creditEventDateNode->Attribute("href") || creditEventDateNode->Attribute("id"))
      {
          if(creditEventDateNode->Attribute("id"))
          {
             creditEventDateIDRef_ = creditEventDateNode->Attribute("id");
             creditEventDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(creditEventDateNode));
             creditEventDate_->setID(creditEventDateIDRef_);
             IDManager::instance().setID(creditEventDateIDRef_,creditEventDate_);
          }
          else if(creditEventDateNode->Attribute("href")) { creditEventDateIDRef_ = creditEventDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { creditEventDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(creditEventDateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AffectedTransactions> CreditEventNoticeDocument::getAffectedTransactions()
{
   if(!this->affectedTransactionsIsNull_){
        if(affectedTransactionsIDRef_ != ""){
             return boost::shared_static_cast<AffectedTransactions>(IDManager::instance().getID(affectedTransactionsIDRef_));
        }else{
             return this->affectedTransactions_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AffectedTransactions>();
   }
}
boost::shared_ptr<LegalEntity> CreditEventNoticeDocument::getReferenceEntity()
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
boost::shared_ptr<CreditEvent> CreditEventNoticeDocument::getCreditEvent()
{
   if(!this->creditEventIsNull_){
        if(creditEventIDRef_ != ""){
             return boost::shared_static_cast<CreditEvent>(IDManager::instance().getID(creditEventIDRef_));
        }else{
             return this->creditEvent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CreditEvent>();
   }
}
boost::shared_ptr<BankruptcyEvent> CreditEventNoticeDocument::getBankruptcy()
{
   if(!this->bankruptcyIsNull_){
        if(bankruptcyIDRef_ != ""){
             return boost::shared_static_cast<BankruptcyEvent>(IDManager::instance().getID(bankruptcyIDRef_));
        }else{
             return this->bankruptcy_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BankruptcyEvent>();
   }
}
boost::shared_ptr<FailureToPayEvent> CreditEventNoticeDocument::getFailureToPay()
{
   if(!this->failureToPayIsNull_){
        if(failureToPayIDRef_ != ""){
             return boost::shared_static_cast<FailureToPayEvent>(IDManager::instance().getID(failureToPayIDRef_));
        }else{
             return this->failureToPay_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FailureToPayEvent>();
   }
}
boost::shared_ptr<ObligationAccelerationEvent> CreditEventNoticeDocument::getObligationAcceleration()
{
   if(!this->obligationAccelerationIsNull_){
        if(obligationAccelerationIDRef_ != ""){
             return boost::shared_static_cast<ObligationAccelerationEvent>(IDManager::instance().getID(obligationAccelerationIDRef_));
        }else{
             return this->obligationAcceleration_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ObligationAccelerationEvent>();
   }
}
boost::shared_ptr<ObligationDefaultEvent> CreditEventNoticeDocument::getObligationDefault()
{
   if(!this->obligationDefaultIsNull_){
        if(obligationDefaultIDRef_ != ""){
             return boost::shared_static_cast<ObligationDefaultEvent>(IDManager::instance().getID(obligationDefaultIDRef_));
        }else{
             return this->obligationDefault_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ObligationDefaultEvent>();
   }
}
boost::shared_ptr<RepudiationMoratoriumEvent> CreditEventNoticeDocument::getRepudiationMoratorium()
{
   if(!this->repudiationMoratoriumIsNull_){
        if(repudiationMoratoriumIDRef_ != ""){
             return boost::shared_static_cast<RepudiationMoratoriumEvent>(IDManager::instance().getID(repudiationMoratoriumIDRef_));
        }else{
             return this->repudiationMoratorium_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RepudiationMoratoriumEvent>();
   }
}
boost::shared_ptr<RestructuringEvent> CreditEventNoticeDocument::getRestructuring()
{
   if(!this->restructuringIsNull_){
        if(restructuringIDRef_ != ""){
             return boost::shared_static_cast<RestructuringEvent>(IDManager::instance().getID(restructuringIDRef_));
        }else{
             return this->restructuring_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RestructuringEvent>();
   }
}
std::vector<boost::shared_ptr<Resource>> CreditEventNoticeDocument::getPubliclyAvailableInformation()
{
   if(!this->publiclyAvailableInformationIsNull_){
        if(publiclyAvailableInformationIDRef_ != ""){
             return this->publiclyAvailableInformation_;
        }else{
             return this->publiclyAvailableInformation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Resource>>();
   }
}
boost::shared_ptr<PartyReference> CreditEventNoticeDocument::getNotifyingPartyReference()
{
   if(!this->notifyingPartyReferenceIsNull_){
        if(notifyingPartyReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(notifyingPartyReferenceIDRef_));
        }else{
             return this->notifyingPartyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<PartyReference> CreditEventNoticeDocument::getNotifiedPartyReference()
{
   if(!this->notifiedPartyReferenceIsNull_){
        if(notifiedPartyReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(notifiedPartyReferenceIDRef_));
        }else{
             return this->notifiedPartyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<XsdTypeDate> CreditEventNoticeDocument::getCreditEventNoticeDate()
{
   if(!this->creditEventNoticeDateIsNull_){
        if(creditEventNoticeDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(creditEventNoticeDateIDRef_));
        }else{
             return this->creditEventNoticeDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> CreditEventNoticeDocument::getCreditEventDate()
{
   if(!this->creditEventDateIsNull_){
        if(creditEventDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(creditEventDateIDRef_));
        }else{
             return this->creditEventDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
}

