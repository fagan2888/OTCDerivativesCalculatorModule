// PartyTradeInformation.cpp 
#include "PartyTradeInformation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PartyTradeInformation::PartyTradeInformation(TiXmlNode* xmlNode)
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

   //accountReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* accountReferenceNode = xmlNode->FirstChildElement("accountReference");

   if(accountReferenceNode){accountReferenceIsNull_ = false;}
   else{accountReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- accountReferenceNode , address : " << accountReferenceNode << std::endl;
   #endif
   if(accountReferenceNode)
   {
      if(accountReferenceNode->Attribute("href") || accountReferenceNode->Attribute("id"))
      {
          if(accountReferenceNode->Attribute("id"))
          {
             accountReferenceIDRef_ = accountReferenceNode->Attribute("id");
             accountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(accountReferenceNode));
             accountReference_->setID(accountReferenceIDRef_);
             IDManager::instance().setID(accountReferenceIDRef_,accountReference_);
          }
          else if(accountReferenceNode->Attribute("href")) { accountReferenceIDRef_ = accountReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { accountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(accountReferenceNode));}
   }

   //relatedPartyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* relatedPartyNode = xmlNode->FirstChildElement("relatedParty");

   if(relatedPartyNode){relatedPartyIsNull_ = false;}
   else{relatedPartyIsNull_ = true;}

   if(relatedPartyNode)
   {
      for(relatedPartyNode; relatedPartyNode; relatedPartyNode = relatedPartyNode->NextSiblingElement("relatedParty")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- relatedPartyNode , address : " << relatedPartyNode << std::endl;
          #endif
          if(relatedPartyNode->Attribute("href") || relatedPartyNode->Attribute("id"))
          {
              if(relatedPartyNode->Attribute("id"))
              {
                  relatedPartyIDRef_ = relatedPartyNode->Attribute("id");
                  relatedParty_.push_back(boost::shared_ptr<RelatedParty>(new RelatedParty(relatedPartyNode)));
                  relatedParty_.back()->setID(relatedPartyIDRef_);
                  IDManager::instance().setID(relatedPartyIDRef_, relatedParty_.back());
              }
              else if(relatedPartyNode->Attribute("href")) { relatedPartyIDRef_ = relatedPartyNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { relatedParty_.push_back(boost::shared_ptr<RelatedParty>(new RelatedParty(relatedPartyNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- relatedPartyNode , address : " << relatedPartyNode << std::endl;
       #endif
   }

   //reportingRoleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* reportingRoleNode = xmlNode->FirstChildElement("reportingRole");

   if(reportingRoleNode){reportingRoleIsNull_ = false;}
   else{reportingRoleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- reportingRoleNode , address : " << reportingRoleNode << std::endl;
   #endif
   if(reportingRoleNode)
   {
      if(reportingRoleNode->Attribute("href") || reportingRoleNode->Attribute("id"))
      {
          if(reportingRoleNode->Attribute("id"))
          {
             reportingRoleIDRef_ = reportingRoleNode->Attribute("id");
             reportingRole_ = boost::shared_ptr<ReportingRole>(new ReportingRole(reportingRoleNode));
             reportingRole_->setID(reportingRoleIDRef_);
             IDManager::instance().setID(reportingRoleIDRef_,reportingRole_);
          }
          else if(reportingRoleNode->Attribute("href")) { reportingRoleIDRef_ = reportingRoleNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { reportingRole_ = boost::shared_ptr<ReportingRole>(new ReportingRole(reportingRoleNode));}
   }

   //unitNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* unitNode = xmlNode->FirstChildElement("unit");

   if(unitNode){unitIsNull_ = false;}
   else{unitIsNull_ = true;}

   if(unitNode)
   {
      for(unitNode; unitNode; unitNode = unitNode->NextSiblingElement("unit")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- unitNode , address : " << unitNode << std::endl;
          #endif
          if(unitNode->Attribute("href") || unitNode->Attribute("id"))
          {
              if(unitNode->Attribute("id"))
              {
                  unitIDRef_ = unitNode->Attribute("id");
                  unit_.push_back(boost::shared_ptr<Unit>(new Unit(unitNode)));
                  unit_.back()->setID(unitIDRef_);
                  IDManager::instance().setID(unitIDRef_, unit_.back());
              }
              else if(unitNode->Attribute("href")) { unitIDRef_ = unitNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { unit_.push_back(boost::shared_ptr<Unit>(new Unit(unitNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- unitNode , address : " << unitNode << std::endl;
       #endif
   }

   //relatedBusinessUnitNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* relatedBusinessUnitNode = xmlNode->FirstChildElement("relatedBusinessUnit");

   if(relatedBusinessUnitNode){relatedBusinessUnitIsNull_ = false;}
   else{relatedBusinessUnitIsNull_ = true;}

   if(relatedBusinessUnitNode)
   {
      for(relatedBusinessUnitNode; relatedBusinessUnitNode; relatedBusinessUnitNode = relatedBusinessUnitNode->NextSiblingElement("relatedBusinessUnit")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- relatedBusinessUnitNode , address : " << relatedBusinessUnitNode << std::endl;
          #endif
          if(relatedBusinessUnitNode->Attribute("href") || relatedBusinessUnitNode->Attribute("id"))
          {
              if(relatedBusinessUnitNode->Attribute("id"))
              {
                  relatedBusinessUnitIDRef_ = relatedBusinessUnitNode->Attribute("id");
                  relatedBusinessUnit_.push_back(boost::shared_ptr<RelatedBusinessUnit>(new RelatedBusinessUnit(relatedBusinessUnitNode)));
                  relatedBusinessUnit_.back()->setID(relatedBusinessUnitIDRef_);
                  IDManager::instance().setID(relatedBusinessUnitIDRef_, relatedBusinessUnit_.back());
              }
              else if(relatedBusinessUnitNode->Attribute("href")) { relatedBusinessUnitIDRef_ = relatedBusinessUnitNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { relatedBusinessUnit_.push_back(boost::shared_ptr<RelatedBusinessUnit>(new RelatedBusinessUnit(relatedBusinessUnitNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- relatedBusinessUnitNode , address : " << relatedBusinessUnitNode << std::endl;
       #endif
   }

   //relatedPersonNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* relatedPersonNode = xmlNode->FirstChildElement("relatedPerson");

   if(relatedPersonNode){relatedPersonIsNull_ = false;}
   else{relatedPersonIsNull_ = true;}

   if(relatedPersonNode)
   {
      for(relatedPersonNode; relatedPersonNode; relatedPersonNode = relatedPersonNode->NextSiblingElement("relatedPerson")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- relatedPersonNode , address : " << relatedPersonNode << std::endl;
          #endif
          if(relatedPersonNode->Attribute("href") || relatedPersonNode->Attribute("id"))
          {
              if(relatedPersonNode->Attribute("id"))
              {
                  relatedPersonIDRef_ = relatedPersonNode->Attribute("id");
                  relatedPerson_.push_back(boost::shared_ptr<RelatedPerson>(new RelatedPerson(relatedPersonNode)));
                  relatedPerson_.back()->setID(relatedPersonIDRef_);
                  IDManager::instance().setID(relatedPersonIDRef_, relatedPerson_.back());
              }
              else if(relatedPersonNode->Attribute("href")) { relatedPersonIDRef_ = relatedPersonNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { relatedPerson_.push_back(boost::shared_ptr<RelatedPerson>(new RelatedPerson(relatedPersonNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- relatedPersonNode , address : " << relatedPersonNode << std::endl;
       #endif
   }

   //isAccountingHedgeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* isAccountingHedgeNode = xmlNode->FirstChildElement("isAccountingHedge");

   if(isAccountingHedgeNode){isAccountingHedgeIsNull_ = false;}
   else{isAccountingHedgeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- isAccountingHedgeNode , address : " << isAccountingHedgeNode << std::endl;
   #endif
   if(isAccountingHedgeNode)
   {
      if(isAccountingHedgeNode->Attribute("href") || isAccountingHedgeNode->Attribute("id"))
      {
          if(isAccountingHedgeNode->Attribute("id"))
          {
             isAccountingHedgeIDRef_ = isAccountingHedgeNode->Attribute("id");
             isAccountingHedge_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(isAccountingHedgeNode));
             isAccountingHedge_->setID(isAccountingHedgeIDRef_);
             IDManager::instance().setID(isAccountingHedgeIDRef_,isAccountingHedge_);
          }
          else if(isAccountingHedgeNode->Attribute("href")) { isAccountingHedgeIDRef_ = isAccountingHedgeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { isAccountingHedge_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(isAccountingHedgeNode));}
   }

   //categoryNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* categoryNode = xmlNode->FirstChildElement("category");

   if(categoryNode){categoryIsNull_ = false;}
   else{categoryIsNull_ = true;}

   if(categoryNode)
   {
      for(categoryNode; categoryNode; categoryNode = categoryNode->NextSiblingElement("category")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- categoryNode , address : " << categoryNode << std::endl;
          #endif
          if(categoryNode->Attribute("href") || categoryNode->Attribute("id"))
          {
              if(categoryNode->Attribute("id"))
              {
                  categoryIDRef_ = categoryNode->Attribute("id");
                  category_.push_back(boost::shared_ptr<TradeCategory>(new TradeCategory(categoryNode)));
                  category_.back()->setID(categoryIDRef_);
                  IDManager::instance().setID(categoryIDRef_, category_.back());
              }
              else if(categoryNode->Attribute("href")) { categoryIDRef_ = categoryNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { category_.push_back(boost::shared_ptr<TradeCategory>(new TradeCategory(categoryNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- categoryNode , address : " << categoryNode << std::endl;
       #endif
   }

   //traderNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* traderNode = xmlNode->FirstChildElement("trader");

   if(traderNode){traderIsNull_ = false;}
   else{traderIsNull_ = true;}

   if(traderNode)
   {
      for(traderNode; traderNode; traderNode = traderNode->NextSiblingElement("trader")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- traderNode , address : " << traderNode << std::endl;
          #endif
          if(traderNode->Attribute("href") || traderNode->Attribute("id"))
          {
              if(traderNode->Attribute("id"))
              {
                  traderIDRef_ = traderNode->Attribute("id");
                  trader_.push_back(boost::shared_ptr<Trader>(new Trader(traderNode)));
                  trader_.back()->setID(traderIDRef_);
                  IDManager::instance().setID(traderIDRef_, trader_.back());
              }
              else if(traderNode->Attribute("href")) { traderIDRef_ = traderNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { trader_.push_back(boost::shared_ptr<Trader>(new Trader(traderNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- traderNode , address : " << traderNode << std::endl;
       #endif
   }

   //executionDateTimeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* executionDateTimeNode = xmlNode->FirstChildElement("executionDateTime");

   if(executionDateTimeNode){executionDateTimeIsNull_ = false;}
   else{executionDateTimeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- executionDateTimeNode , address : " << executionDateTimeNode << std::endl;
   #endif
   if(executionDateTimeNode)
   {
      if(executionDateTimeNode->Attribute("href") || executionDateTimeNode->Attribute("id"))
      {
          if(executionDateTimeNode->Attribute("id"))
          {
             executionDateTimeIDRef_ = executionDateTimeNode->Attribute("id");
             executionDateTime_ = boost::shared_ptr<ExecutionDateTime>(new ExecutionDateTime(executionDateTimeNode));
             executionDateTime_->setID(executionDateTimeIDRef_);
             IDManager::instance().setID(executionDateTimeIDRef_,executionDateTime_);
          }
          else if(executionDateTimeNode->Attribute("href")) { executionDateTimeIDRef_ = executionDateTimeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { executionDateTime_ = boost::shared_ptr<ExecutionDateTime>(new ExecutionDateTime(executionDateTimeNode));}
   }

   //timestampsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* timestampsNode = xmlNode->FirstChildElement("timestamps");

   if(timestampsNode){timestampsIsNull_ = false;}
   else{timestampsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- timestampsNode , address : " << timestampsNode << std::endl;
   #endif
   if(timestampsNode)
   {
      if(timestampsNode->Attribute("href") || timestampsNode->Attribute("id"))
      {
          if(timestampsNode->Attribute("id"))
          {
             timestampsIDRef_ = timestampsNode->Attribute("id");
             timestamps_ = boost::shared_ptr<TradeProcessingTimestamps>(new TradeProcessingTimestamps(timestampsNode));
             timestamps_->setID(timestampsIDRef_);
             IDManager::instance().setID(timestampsIDRef_,timestamps_);
          }
          else if(timestampsNode->Attribute("href")) { timestampsIDRef_ = timestampsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { timestamps_ = boost::shared_ptr<TradeProcessingTimestamps>(new TradeProcessingTimestamps(timestampsNode));}
   }

   //intentToAllocateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* intentToAllocateNode = xmlNode->FirstChildElement("intentToAllocate");

   if(intentToAllocateNode){intentToAllocateIsNull_ = false;}
   else{intentToAllocateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- intentToAllocateNode , address : " << intentToAllocateNode << std::endl;
   #endif
   if(intentToAllocateNode)
   {
      if(intentToAllocateNode->Attribute("href") || intentToAllocateNode->Attribute("id"))
      {
          if(intentToAllocateNode->Attribute("id"))
          {
             intentToAllocateIDRef_ = intentToAllocateNode->Attribute("id");
             intentToAllocate_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(intentToAllocateNode));
             intentToAllocate_->setID(intentToAllocateIDRef_);
             IDManager::instance().setID(intentToAllocateIDRef_,intentToAllocate_);
          }
          else if(intentToAllocateNode->Attribute("href")) { intentToAllocateIDRef_ = intentToAllocateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { intentToAllocate_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(intentToAllocateNode));}
   }

   //allocationStatusNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* allocationStatusNode = xmlNode->FirstChildElement("allocationStatus");

   if(allocationStatusNode){allocationStatusIsNull_ = false;}
   else{allocationStatusIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- allocationStatusNode , address : " << allocationStatusNode << std::endl;
   #endif
   if(allocationStatusNode)
   {
      if(allocationStatusNode->Attribute("href") || allocationStatusNode->Attribute("id"))
      {
          if(allocationStatusNode->Attribute("id"))
          {
             allocationStatusIDRef_ = allocationStatusNode->Attribute("id");
             allocationStatus_ = boost::shared_ptr<AllocationReportingStatus>(new AllocationReportingStatus(allocationStatusNode));
             allocationStatus_->setID(allocationStatusIDRef_);
             IDManager::instance().setID(allocationStatusIDRef_,allocationStatus_);
          }
          else if(allocationStatusNode->Attribute("href")) { allocationStatusIDRef_ = allocationStatusNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { allocationStatus_ = boost::shared_ptr<AllocationReportingStatus>(new AllocationReportingStatus(allocationStatusNode));}
   }

   //intentToClearNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* intentToClearNode = xmlNode->FirstChildElement("intentToClear");

   if(intentToClearNode){intentToClearIsNull_ = false;}
   else{intentToClearIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- intentToClearNode , address : " << intentToClearNode << std::endl;
   #endif
   if(intentToClearNode)
   {
      if(intentToClearNode->Attribute("href") || intentToClearNode->Attribute("id"))
      {
          if(intentToClearNode->Attribute("id"))
          {
             intentToClearIDRef_ = intentToClearNode->Attribute("id");
             intentToClear_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(intentToClearNode));
             intentToClear_->setID(intentToClearIDRef_);
             IDManager::instance().setID(intentToClearIDRef_,intentToClear_);
          }
          else if(intentToClearNode->Attribute("href")) { intentToClearIDRef_ = intentToClearNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { intentToClear_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(intentToClearNode));}
   }

   //clearingStatusNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* clearingStatusNode = xmlNode->FirstChildElement("clearingStatus");

   if(clearingStatusNode){clearingStatusIsNull_ = false;}
   else{clearingStatusIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- clearingStatusNode , address : " << clearingStatusNode << std::endl;
   #endif
   if(clearingStatusNode)
   {
      if(clearingStatusNode->Attribute("href") || clearingStatusNode->Attribute("id"))
      {
          if(clearingStatusNode->Attribute("id"))
          {
             clearingStatusIDRef_ = clearingStatusNode->Attribute("id");
             clearingStatus_ = boost::shared_ptr<ClearingStatusValue>(new ClearingStatusValue(clearingStatusNode));
             clearingStatus_->setID(clearingStatusIDRef_);
             IDManager::instance().setID(clearingStatusIDRef_,clearingStatus_);
          }
          else if(clearingStatusNode->Attribute("href")) { clearingStatusIDRef_ = clearingStatusNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { clearingStatus_ = boost::shared_ptr<ClearingStatusValue>(new ClearingStatusValue(clearingStatusNode));}
   }

   //collateralizationTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* collateralizationTypeNode = xmlNode->FirstChildElement("collateralizationType");

   if(collateralizationTypeNode){collateralizationTypeIsNull_ = false;}
   else{collateralizationTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- collateralizationTypeNode , address : " << collateralizationTypeNode << std::endl;
   #endif
   if(collateralizationTypeNode)
   {
      if(collateralizationTypeNode->Attribute("href") || collateralizationTypeNode->Attribute("id"))
      {
          if(collateralizationTypeNode->Attribute("id"))
          {
             collateralizationTypeIDRef_ = collateralizationTypeNode->Attribute("id");
             collateralizationType_ = boost::shared_ptr<CollateralizationType>(new CollateralizationType(collateralizationTypeNode));
             collateralizationType_->setID(collateralizationTypeIDRef_);
             IDManager::instance().setID(collateralizationTypeIDRef_,collateralizationType_);
          }
          else if(collateralizationTypeNode->Attribute("href")) { collateralizationTypeIDRef_ = collateralizationTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { collateralizationType_ = boost::shared_ptr<CollateralizationType>(new CollateralizationType(collateralizationTypeNode));}
   }

   //reportingRegimeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* reportingRegimeNode = xmlNode->FirstChildElement("reportingRegime");

   if(reportingRegimeNode){reportingRegimeIsNull_ = false;}
   else{reportingRegimeIsNull_ = true;}

   if(reportingRegimeNode)
   {
      for(reportingRegimeNode; reportingRegimeNode; reportingRegimeNode = reportingRegimeNode->NextSiblingElement("reportingRegime")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- reportingRegimeNode , address : " << reportingRegimeNode << std::endl;
          #endif
          if(reportingRegimeNode->Attribute("href") || reportingRegimeNode->Attribute("id"))
          {
              if(reportingRegimeNode->Attribute("id"))
              {
                  reportingRegimeIDRef_ = reportingRegimeNode->Attribute("id");
                  reportingRegime_.push_back(boost::shared_ptr<ReportingRegime>(new ReportingRegime(reportingRegimeNode)));
                  reportingRegime_.back()->setID(reportingRegimeIDRef_);
                  IDManager::instance().setID(reportingRegimeIDRef_, reportingRegime_.back());
              }
              else if(reportingRegimeNode->Attribute("href")) { reportingRegimeIDRef_ = reportingRegimeNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { reportingRegime_.push_back(boost::shared_ptr<ReportingRegime>(new ReportingRegime(reportingRegimeNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- reportingRegimeNode , address : " << reportingRegimeNode << std::endl;
       #endif
   }

   //endUserExceptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* endUserExceptionNode = xmlNode->FirstChildElement("endUserException");

   if(endUserExceptionNode){endUserExceptionIsNull_ = false;}
   else{endUserExceptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- endUserExceptionNode , address : " << endUserExceptionNode << std::endl;
   #endif
   if(endUserExceptionNode)
   {
      if(endUserExceptionNode->Attribute("href") || endUserExceptionNode->Attribute("id"))
      {
          if(endUserExceptionNode->Attribute("id"))
          {
             endUserExceptionIDRef_ = endUserExceptionNode->Attribute("id");
             endUserException_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(endUserExceptionNode));
             endUserException_->setID(endUserExceptionIDRef_);
             IDManager::instance().setID(endUserExceptionIDRef_,endUserException_);
          }
          else if(endUserExceptionNode->Attribute("href")) { endUserExceptionIDRef_ = endUserExceptionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { endUserException_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(endUserExceptionNode));}
   }

   //endUserExceptionDeclarationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* endUserExceptionDeclarationNode = xmlNode->FirstChildElement("endUserExceptionDeclaration");

   if(endUserExceptionDeclarationNode){endUserExceptionDeclarationIsNull_ = false;}
   else{endUserExceptionDeclarationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- endUserExceptionDeclarationNode , address : " << endUserExceptionDeclarationNode << std::endl;
   #endif
   if(endUserExceptionDeclarationNode)
   {
      if(endUserExceptionDeclarationNode->Attribute("href") || endUserExceptionDeclarationNode->Attribute("id"))
      {
          if(endUserExceptionDeclarationNode->Attribute("id"))
          {
             endUserExceptionDeclarationIDRef_ = endUserExceptionDeclarationNode->Attribute("id");
             endUserExceptionDeclaration_ = boost::shared_ptr<EndUserExceptionDeclaration>(new EndUserExceptionDeclaration(endUserExceptionDeclarationNode));
             endUserExceptionDeclaration_->setID(endUserExceptionDeclarationIDRef_);
             IDManager::instance().setID(endUserExceptionDeclarationIDRef_,endUserExceptionDeclaration_);
          }
          else if(endUserExceptionDeclarationNode->Attribute("href")) { endUserExceptionDeclarationIDRef_ = endUserExceptionDeclarationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { endUserExceptionDeclaration_ = boost::shared_ptr<EndUserExceptionDeclaration>(new EndUserExceptionDeclaration(endUserExceptionDeclarationNode));}
   }

   //nonStandardTermsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nonStandardTermsNode = xmlNode->FirstChildElement("nonStandardTerms");

   if(nonStandardTermsNode){nonStandardTermsIsNull_ = false;}
   else{nonStandardTermsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nonStandardTermsNode , address : " << nonStandardTermsNode << std::endl;
   #endif
   if(nonStandardTermsNode)
   {
      if(nonStandardTermsNode->Attribute("href") || nonStandardTermsNode->Attribute("id"))
      {
          if(nonStandardTermsNode->Attribute("id"))
          {
             nonStandardTermsIDRef_ = nonStandardTermsNode->Attribute("id");
             nonStandardTerms_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(nonStandardTermsNode));
             nonStandardTerms_->setID(nonStandardTermsIDRef_);
             IDManager::instance().setID(nonStandardTermsIDRef_,nonStandardTerms_);
          }
          else if(nonStandardTermsNode->Attribute("href")) { nonStandardTermsIDRef_ = nonStandardTermsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { nonStandardTerms_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(nonStandardTermsNode));}
   }

   //offMarketPriceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* offMarketPriceNode = xmlNode->FirstChildElement("offMarketPrice");

   if(offMarketPriceNode){offMarketPriceIsNull_ = false;}
   else{offMarketPriceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- offMarketPriceNode , address : " << offMarketPriceNode << std::endl;
   #endif
   if(offMarketPriceNode)
   {
      if(offMarketPriceNode->Attribute("href") || offMarketPriceNode->Attribute("id"))
      {
          if(offMarketPriceNode->Attribute("id"))
          {
             offMarketPriceIDRef_ = offMarketPriceNode->Attribute("id");
             offMarketPrice_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(offMarketPriceNode));
             offMarketPrice_->setID(offMarketPriceIDRef_);
             IDManager::instance().setID(offMarketPriceIDRef_,offMarketPrice_);
          }
          else if(offMarketPriceNode->Attribute("href")) { offMarketPriceIDRef_ = offMarketPriceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { offMarketPrice_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(offMarketPriceNode));}
   }

   //largeSizeTradeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* largeSizeTradeNode = xmlNode->FirstChildElement("largeSizeTrade");

   if(largeSizeTradeNode){largeSizeTradeIsNull_ = false;}
   else{largeSizeTradeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- largeSizeTradeNode , address : " << largeSizeTradeNode << std::endl;
   #endif
   if(largeSizeTradeNode)
   {
      if(largeSizeTradeNode->Attribute("href") || largeSizeTradeNode->Attribute("id"))
      {
          if(largeSizeTradeNode->Attribute("id"))
          {
             largeSizeTradeIDRef_ = largeSizeTradeNode->Attribute("id");
             largeSizeTrade_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(largeSizeTradeNode));
             largeSizeTrade_->setID(largeSizeTradeIDRef_);
             IDManager::instance().setID(largeSizeTradeIDRef_,largeSizeTrade_);
          }
          else if(largeSizeTradeNode->Attribute("href")) { largeSizeTradeIDRef_ = largeSizeTradeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { largeSizeTrade_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(largeSizeTradeNode));}
   }

   //executionTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* executionTypeNode = xmlNode->FirstChildElement("executionType");

   if(executionTypeNode){executionTypeIsNull_ = false;}
   else{executionTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- executionTypeNode , address : " << executionTypeNode << std::endl;
   #endif
   if(executionTypeNode)
   {
      if(executionTypeNode->Attribute("href") || executionTypeNode->Attribute("id"))
      {
          if(executionTypeNode->Attribute("id"))
          {
             executionTypeIDRef_ = executionTypeNode->Attribute("id");
             executionType_ = boost::shared_ptr<ExecutionType>(new ExecutionType(executionTypeNode));
             executionType_->setID(executionTypeIDRef_);
             IDManager::instance().setID(executionTypeIDRef_,executionType_);
          }
          else if(executionTypeNode->Attribute("href")) { executionTypeIDRef_ = executionTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { executionType_ = boost::shared_ptr<ExecutionType>(new ExecutionType(executionTypeNode));}
   }

   //executionVenueTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* executionVenueTypeNode = xmlNode->FirstChildElement("executionVenueType");

   if(executionVenueTypeNode){executionVenueTypeIsNull_ = false;}
   else{executionVenueTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- executionVenueTypeNode , address : " << executionVenueTypeNode << std::endl;
   #endif
   if(executionVenueTypeNode)
   {
      if(executionVenueTypeNode->Attribute("href") || executionVenueTypeNode->Attribute("id"))
      {
          if(executionVenueTypeNode->Attribute("id"))
          {
             executionVenueTypeIDRef_ = executionVenueTypeNode->Attribute("id");
             executionVenueType_ = boost::shared_ptr<ExecutionVenueType>(new ExecutionVenueType(executionVenueTypeNode));
             executionVenueType_->setID(executionVenueTypeIDRef_);
             IDManager::instance().setID(executionVenueTypeIDRef_,executionVenueType_);
          }
          else if(executionVenueTypeNode->Attribute("href")) { executionVenueTypeIDRef_ = executionVenueTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { executionVenueType_ = boost::shared_ptr<ExecutionVenueType>(new ExecutionVenueType(executionVenueTypeNode));}
   }

   //verificationMethodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* verificationMethodNode = xmlNode->FirstChildElement("verificationMethod");

   if(verificationMethodNode){verificationMethodIsNull_ = false;}
   else{verificationMethodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- verificationMethodNode , address : " << verificationMethodNode << std::endl;
   #endif
   if(verificationMethodNode)
   {
      if(verificationMethodNode->Attribute("href") || verificationMethodNode->Attribute("id"))
      {
          if(verificationMethodNode->Attribute("id"))
          {
             verificationMethodIDRef_ = verificationMethodNode->Attribute("id");
             verificationMethod_ = boost::shared_ptr<VerificationMethod>(new VerificationMethod(verificationMethodNode));
             verificationMethod_->setID(verificationMethodIDRef_);
             IDManager::instance().setID(verificationMethodIDRef_,verificationMethod_);
          }
          else if(verificationMethodNode->Attribute("href")) { verificationMethodIDRef_ = verificationMethodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { verificationMethod_ = boost::shared_ptr<VerificationMethod>(new VerificationMethod(verificationMethodNode));}
   }

   //confirmationMethodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* confirmationMethodNode = xmlNode->FirstChildElement("confirmationMethod");

   if(confirmationMethodNode){confirmationMethodIsNull_ = false;}
   else{confirmationMethodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- confirmationMethodNode , address : " << confirmationMethodNode << std::endl;
   #endif
   if(confirmationMethodNode)
   {
      if(confirmationMethodNode->Attribute("href") || confirmationMethodNode->Attribute("id"))
      {
          if(confirmationMethodNode->Attribute("id"))
          {
             confirmationMethodIDRef_ = confirmationMethodNode->Attribute("id");
             confirmationMethod_ = boost::shared_ptr<ConfirmationMethod>(new ConfirmationMethod(confirmationMethodNode));
             confirmationMethod_->setID(confirmationMethodIDRef_);
             IDManager::instance().setID(confirmationMethodIDRef_,confirmationMethod_);
          }
          else if(confirmationMethodNode->Attribute("href")) { confirmationMethodIDRef_ = confirmationMethodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { confirmationMethod_ = boost::shared_ptr<ConfirmationMethod>(new ConfirmationMethod(confirmationMethodNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PartyReference> PartyTradeInformation::getPartyReference()
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
boost::shared_ptr<AccountReference> PartyTradeInformation::getAccountReference()
{
   if(!this->accountReferenceIsNull_){
        if(accountReferenceIDRef_ != ""){
             return boost::shared_static_cast<AccountReference>(IDManager::instance().getID(accountReferenceIDRef_));
        }else{
             return this->accountReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AccountReference>();
   }
}
std::vector<boost::shared_ptr<RelatedParty>> PartyTradeInformation::getRelatedParty()
{
   if(!this->relatedPartyIsNull_){
        if(relatedPartyIDRef_ != ""){
             return this->relatedParty_;
        }else{
             return this->relatedParty_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<RelatedParty>>();
   }
}
boost::shared_ptr<ReportingRole> PartyTradeInformation::getReportingRole()
{
   if(!this->reportingRoleIsNull_){
        if(reportingRoleIDRef_ != ""){
             return boost::shared_static_cast<ReportingRole>(IDManager::instance().getID(reportingRoleIDRef_));
        }else{
             return this->reportingRole_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReportingRole>();
   }
}
std::vector<boost::shared_ptr<Unit>> PartyTradeInformation::getUnit()
{
   if(!this->unitIsNull_){
        if(unitIDRef_ != ""){
             return this->unit_;
        }else{
             return this->unit_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Unit>>();
   }
}
std::vector<boost::shared_ptr<RelatedBusinessUnit>> PartyTradeInformation::getRelatedBusinessUnit()
{
   if(!this->relatedBusinessUnitIsNull_){
        if(relatedBusinessUnitIDRef_ != ""){
             return this->relatedBusinessUnit_;
        }else{
             return this->relatedBusinessUnit_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<RelatedBusinessUnit>>();
   }
}
std::vector<boost::shared_ptr<RelatedPerson>> PartyTradeInformation::getRelatedPerson()
{
   if(!this->relatedPersonIsNull_){
        if(relatedPersonIDRef_ != ""){
             return this->relatedPerson_;
        }else{
             return this->relatedPerson_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<RelatedPerson>>();
   }
}
boost::shared_ptr<XsdTypeBoolean> PartyTradeInformation::getIsAccountingHedge()
{
   if(!this->isAccountingHedgeIsNull_){
        if(isAccountingHedgeIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(isAccountingHedgeIDRef_));
        }else{
             return this->isAccountingHedge_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
std::vector<boost::shared_ptr<TradeCategory>> PartyTradeInformation::getCategory()
{
   if(!this->categoryIsNull_){
        if(categoryIDRef_ != ""){
             return this->category_;
        }else{
             return this->category_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<TradeCategory>>();
   }
}
std::vector<boost::shared_ptr<Trader>> PartyTradeInformation::getTrader()
{
   if(!this->traderIsNull_){
        if(traderIDRef_ != ""){
             return this->trader_;
        }else{
             return this->trader_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Trader>>();
   }
}
boost::shared_ptr<ExecutionDateTime> PartyTradeInformation::getExecutionDateTime()
{
   if(!this->executionDateTimeIsNull_){
        if(executionDateTimeIDRef_ != ""){
             return boost::shared_static_cast<ExecutionDateTime>(IDManager::instance().getID(executionDateTimeIDRef_));
        }else{
             return this->executionDateTime_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ExecutionDateTime>();
   }
}
boost::shared_ptr<TradeProcessingTimestamps> PartyTradeInformation::getTimestamps()
{
   if(!this->timestampsIsNull_){
        if(timestampsIDRef_ != ""){
             return boost::shared_static_cast<TradeProcessingTimestamps>(IDManager::instance().getID(timestampsIDRef_));
        }else{
             return this->timestamps_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TradeProcessingTimestamps>();
   }
}
boost::shared_ptr<XsdTypeBoolean> PartyTradeInformation::getIntentToAllocate()
{
   if(!this->intentToAllocateIsNull_){
        if(intentToAllocateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(intentToAllocateIDRef_));
        }else{
             return this->intentToAllocate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<AllocationReportingStatus> PartyTradeInformation::getAllocationStatus()
{
   if(!this->allocationStatusIsNull_){
        if(allocationStatusIDRef_ != ""){
             return boost::shared_static_cast<AllocationReportingStatus>(IDManager::instance().getID(allocationStatusIDRef_));
        }else{
             return this->allocationStatus_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AllocationReportingStatus>();
   }
}
boost::shared_ptr<XsdTypeBoolean> PartyTradeInformation::getIntentToClear()
{
   if(!this->intentToClearIsNull_){
        if(intentToClearIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(intentToClearIDRef_));
        }else{
             return this->intentToClear_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<ClearingStatusValue> PartyTradeInformation::getClearingStatus()
{
   if(!this->clearingStatusIsNull_){
        if(clearingStatusIDRef_ != ""){
             return boost::shared_static_cast<ClearingStatusValue>(IDManager::instance().getID(clearingStatusIDRef_));
        }else{
             return this->clearingStatus_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ClearingStatusValue>();
   }
}
boost::shared_ptr<CollateralizationType> PartyTradeInformation::getCollateralizationType()
{
   if(!this->collateralizationTypeIsNull_){
        if(collateralizationTypeIDRef_ != ""){
             return boost::shared_static_cast<CollateralizationType>(IDManager::instance().getID(collateralizationTypeIDRef_));
        }else{
             return this->collateralizationType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CollateralizationType>();
   }
}
std::vector<boost::shared_ptr<ReportingRegime>> PartyTradeInformation::getReportingRegime()
{
   if(!this->reportingRegimeIsNull_){
        if(reportingRegimeIDRef_ != ""){
             return this->reportingRegime_;
        }else{
             return this->reportingRegime_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ReportingRegime>>();
   }
}
boost::shared_ptr<XsdTypeBoolean> PartyTradeInformation::getEndUserException()
{
   if(!this->endUserExceptionIsNull_){
        if(endUserExceptionIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(endUserExceptionIDRef_));
        }else{
             return this->endUserException_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<EndUserExceptionDeclaration> PartyTradeInformation::getEndUserExceptionDeclaration()
{
   if(!this->endUserExceptionDeclarationIsNull_){
        if(endUserExceptionDeclarationIDRef_ != ""){
             return boost::shared_static_cast<EndUserExceptionDeclaration>(IDManager::instance().getID(endUserExceptionDeclarationIDRef_));
        }else{
             return this->endUserExceptionDeclaration_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EndUserExceptionDeclaration>();
   }
}
boost::shared_ptr<XsdTypeBoolean> PartyTradeInformation::getNonStandardTerms()
{
   if(!this->nonStandardTermsIsNull_){
        if(nonStandardTermsIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(nonStandardTermsIDRef_));
        }else{
             return this->nonStandardTerms_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> PartyTradeInformation::getOffMarketPrice()
{
   if(!this->offMarketPriceIsNull_){
        if(offMarketPriceIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(offMarketPriceIDRef_));
        }else{
             return this->offMarketPrice_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> PartyTradeInformation::getLargeSizeTrade()
{
   if(!this->largeSizeTradeIsNull_){
        if(largeSizeTradeIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(largeSizeTradeIDRef_));
        }else{
             return this->largeSizeTrade_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<ExecutionType> PartyTradeInformation::getExecutionType()
{
   if(!this->executionTypeIsNull_){
        if(executionTypeIDRef_ != ""){
             return boost::shared_static_cast<ExecutionType>(IDManager::instance().getID(executionTypeIDRef_));
        }else{
             return this->executionType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ExecutionType>();
   }
}
boost::shared_ptr<ExecutionVenueType> PartyTradeInformation::getExecutionVenueType()
{
   if(!this->executionVenueTypeIsNull_){
        if(executionVenueTypeIDRef_ != ""){
             return boost::shared_static_cast<ExecutionVenueType>(IDManager::instance().getID(executionVenueTypeIDRef_));
        }else{
             return this->executionVenueType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ExecutionVenueType>();
   }
}
boost::shared_ptr<VerificationMethod> PartyTradeInformation::getVerificationMethod()
{
   if(!this->verificationMethodIsNull_){
        if(verificationMethodIDRef_ != ""){
             return boost::shared_static_cast<VerificationMethod>(IDManager::instance().getID(verificationMethodIDRef_));
        }else{
             return this->verificationMethod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<VerificationMethod>();
   }
}
boost::shared_ptr<ConfirmationMethod> PartyTradeInformation::getConfirmationMethod()
{
   if(!this->confirmationMethodIsNull_){
        if(confirmationMethodIDRef_ != ""){
             return boost::shared_static_cast<ConfirmationMethod>(IDManager::instance().getID(confirmationMethodIDRef_));
        }else{
             return this->confirmationMethod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ConfirmationMethod>();
   }
}
}

