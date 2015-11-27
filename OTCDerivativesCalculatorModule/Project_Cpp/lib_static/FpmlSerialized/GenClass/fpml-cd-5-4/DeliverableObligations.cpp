// DeliverableObligations.cpp 
#include "DeliverableObligations.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

DeliverableObligations::DeliverableObligations(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //accruedInterestNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* accruedInterestNode = xmlNode->FirstChildElement("accruedInterest");

   if(accruedInterestNode){accruedInterestIsNull_ = false;}
   else{accruedInterestIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- accruedInterestNode , address : " << accruedInterestNode << std::endl;
   #endif
   if(accruedInterestNode)
   {
      if(accruedInterestNode->Attribute("href") || accruedInterestNode->Attribute("id"))
      {
          if(accruedInterestNode->Attribute("id"))
          {
             accruedInterestIDRef_ = accruedInterestNode->Attribute("id");
             accruedInterest_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(accruedInterestNode));
             accruedInterest_->setID(accruedInterestIDRef_);
             IDManager::instance().setID(accruedInterestIDRef_,accruedInterest_);
          }
          else if(accruedInterestNode->Attribute("href")) { accruedInterestIDRef_ = accruedInterestNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { accruedInterest_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(accruedInterestNode));}
   }

   //categoryNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* categoryNode = xmlNode->FirstChildElement("category");

   if(categoryNode){categoryIsNull_ = false;}
   else{categoryIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- categoryNode , address : " << categoryNode << std::endl;
   #endif
   if(categoryNode)
   {
      if(categoryNode->Attribute("href") || categoryNode->Attribute("id"))
      {
          if(categoryNode->Attribute("id"))
          {
             categoryIDRef_ = categoryNode->Attribute("id");
             category_ = boost::shared_ptr<ObligationCategoryEnum>(new ObligationCategoryEnum(categoryNode));
             category_->setID(categoryIDRef_);
             IDManager::instance().setID(categoryIDRef_,category_);
          }
          else if(categoryNode->Attribute("href")) { categoryIDRef_ = categoryNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { category_ = boost::shared_ptr<ObligationCategoryEnum>(new ObligationCategoryEnum(categoryNode));}
   }

   //notSubordinatedNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notSubordinatedNode = xmlNode->FirstChildElement("notSubordinated");

   if(notSubordinatedNode){notSubordinatedIsNull_ = false;}
   else{notSubordinatedIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notSubordinatedNode , address : " << notSubordinatedNode << std::endl;
   #endif
   if(notSubordinatedNode)
   {
      if(notSubordinatedNode->Attribute("href") || notSubordinatedNode->Attribute("id"))
      {
          if(notSubordinatedNode->Attribute("id"))
          {
             notSubordinatedIDRef_ = notSubordinatedNode->Attribute("id");
             notSubordinated_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(notSubordinatedNode));
             notSubordinated_->setID(notSubordinatedIDRef_);
             IDManager::instance().setID(notSubordinatedIDRef_,notSubordinated_);
          }
          else if(notSubordinatedNode->Attribute("href")) { notSubordinatedIDRef_ = notSubordinatedNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notSubordinated_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(notSubordinatedNode));}
   }

   //specifiedCurrencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* specifiedCurrencyNode = xmlNode->FirstChildElement("specifiedCurrency");

   if(specifiedCurrencyNode){specifiedCurrencyIsNull_ = false;}
   else{specifiedCurrencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- specifiedCurrencyNode , address : " << specifiedCurrencyNode << std::endl;
   #endif
   if(specifiedCurrencyNode)
   {
      if(specifiedCurrencyNode->Attribute("href") || specifiedCurrencyNode->Attribute("id"))
      {
          if(specifiedCurrencyNode->Attribute("id"))
          {
             specifiedCurrencyIDRef_ = specifiedCurrencyNode->Attribute("id");
             specifiedCurrency_ = boost::shared_ptr<SpecifiedCurrency>(new SpecifiedCurrency(specifiedCurrencyNode));
             specifiedCurrency_->setID(specifiedCurrencyIDRef_);
             IDManager::instance().setID(specifiedCurrencyIDRef_,specifiedCurrency_);
          }
          else if(specifiedCurrencyNode->Attribute("href")) { specifiedCurrencyIDRef_ = specifiedCurrencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { specifiedCurrency_ = boost::shared_ptr<SpecifiedCurrency>(new SpecifiedCurrency(specifiedCurrencyNode));}
   }

   //notSovereignLenderNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notSovereignLenderNode = xmlNode->FirstChildElement("notSovereignLender");

   if(notSovereignLenderNode){notSovereignLenderIsNull_ = false;}
   else{notSovereignLenderIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notSovereignLenderNode , address : " << notSovereignLenderNode << std::endl;
   #endif
   if(notSovereignLenderNode)
   {
      if(notSovereignLenderNode->Attribute("href") || notSovereignLenderNode->Attribute("id"))
      {
          if(notSovereignLenderNode->Attribute("id"))
          {
             notSovereignLenderIDRef_ = notSovereignLenderNode->Attribute("id");
             notSovereignLender_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(notSovereignLenderNode));
             notSovereignLender_->setID(notSovereignLenderIDRef_);
             IDManager::instance().setID(notSovereignLenderIDRef_,notSovereignLender_);
          }
          else if(notSovereignLenderNode->Attribute("href")) { notSovereignLenderIDRef_ = notSovereignLenderNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notSovereignLender_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(notSovereignLenderNode));}
   }

   //notDomesticCurrencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notDomesticCurrencyNode = xmlNode->FirstChildElement("notDomesticCurrency");

   if(notDomesticCurrencyNode){notDomesticCurrencyIsNull_ = false;}
   else{notDomesticCurrencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notDomesticCurrencyNode , address : " << notDomesticCurrencyNode << std::endl;
   #endif
   if(notDomesticCurrencyNode)
   {
      if(notDomesticCurrencyNode->Attribute("href") || notDomesticCurrencyNode->Attribute("id"))
      {
          if(notDomesticCurrencyNode->Attribute("id"))
          {
             notDomesticCurrencyIDRef_ = notDomesticCurrencyNode->Attribute("id");
             notDomesticCurrency_ = boost::shared_ptr<NotDomesticCurrency>(new NotDomesticCurrency(notDomesticCurrencyNode));
             notDomesticCurrency_->setID(notDomesticCurrencyIDRef_);
             IDManager::instance().setID(notDomesticCurrencyIDRef_,notDomesticCurrency_);
          }
          else if(notDomesticCurrencyNode->Attribute("href")) { notDomesticCurrencyIDRef_ = notDomesticCurrencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notDomesticCurrency_ = boost::shared_ptr<NotDomesticCurrency>(new NotDomesticCurrency(notDomesticCurrencyNode));}
   }

   //notDomesticLawNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notDomesticLawNode = xmlNode->FirstChildElement("notDomesticLaw");

   if(notDomesticLawNode){notDomesticLawIsNull_ = false;}
   else{notDomesticLawIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notDomesticLawNode , address : " << notDomesticLawNode << std::endl;
   #endif
   if(notDomesticLawNode)
   {
      if(notDomesticLawNode->Attribute("href") || notDomesticLawNode->Attribute("id"))
      {
          if(notDomesticLawNode->Attribute("id"))
          {
             notDomesticLawIDRef_ = notDomesticLawNode->Attribute("id");
             notDomesticLaw_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(notDomesticLawNode));
             notDomesticLaw_->setID(notDomesticLawIDRef_);
             IDManager::instance().setID(notDomesticLawIDRef_,notDomesticLaw_);
          }
          else if(notDomesticLawNode->Attribute("href")) { notDomesticLawIDRef_ = notDomesticLawNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notDomesticLaw_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(notDomesticLawNode));}
   }

   //listedNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* listedNode = xmlNode->FirstChildElement("listed");

   if(listedNode){listedIsNull_ = false;}
   else{listedIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- listedNode , address : " << listedNode << std::endl;
   #endif
   if(listedNode)
   {
      if(listedNode->Attribute("href") || listedNode->Attribute("id"))
      {
          if(listedNode->Attribute("id"))
          {
             listedIDRef_ = listedNode->Attribute("id");
             listed_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(listedNode));
             listed_->setID(listedIDRef_);
             IDManager::instance().setID(listedIDRef_,listed_);
          }
          else if(listedNode->Attribute("href")) { listedIDRef_ = listedNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { listed_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(listedNode));}
   }

   //notContingentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notContingentNode = xmlNode->FirstChildElement("notContingent");

   if(notContingentNode){notContingentIsNull_ = false;}
   else{notContingentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notContingentNode , address : " << notContingentNode << std::endl;
   #endif
   if(notContingentNode)
   {
      if(notContingentNode->Attribute("href") || notContingentNode->Attribute("id"))
      {
          if(notContingentNode->Attribute("id"))
          {
             notContingentIDRef_ = notContingentNode->Attribute("id");
             notContingent_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(notContingentNode));
             notContingent_->setID(notContingentIDRef_);
             IDManager::instance().setID(notContingentIDRef_,notContingent_);
          }
          else if(notContingentNode->Attribute("href")) { notContingentIDRef_ = notContingentNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notContingent_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(notContingentNode));}
   }

   //notDomesticIssuanceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notDomesticIssuanceNode = xmlNode->FirstChildElement("notDomesticIssuance");

   if(notDomesticIssuanceNode){notDomesticIssuanceIsNull_ = false;}
   else{notDomesticIssuanceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notDomesticIssuanceNode , address : " << notDomesticIssuanceNode << std::endl;
   #endif
   if(notDomesticIssuanceNode)
   {
      if(notDomesticIssuanceNode->Attribute("href") || notDomesticIssuanceNode->Attribute("id"))
      {
          if(notDomesticIssuanceNode->Attribute("id"))
          {
             notDomesticIssuanceIDRef_ = notDomesticIssuanceNode->Attribute("id");
             notDomesticIssuance_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(notDomesticIssuanceNode));
             notDomesticIssuance_->setID(notDomesticIssuanceIDRef_);
             IDManager::instance().setID(notDomesticIssuanceIDRef_,notDomesticIssuance_);
          }
          else if(notDomesticIssuanceNode->Attribute("href")) { notDomesticIssuanceIDRef_ = notDomesticIssuanceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notDomesticIssuance_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(notDomesticIssuanceNode));}
   }

   //assignableLoanNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* assignableLoanNode = xmlNode->FirstChildElement("assignableLoan");

   if(assignableLoanNode){assignableLoanIsNull_ = false;}
   else{assignableLoanIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- assignableLoanNode , address : " << assignableLoanNode << std::endl;
   #endif
   if(assignableLoanNode)
   {
      if(assignableLoanNode->Attribute("href") || assignableLoanNode->Attribute("id"))
      {
          if(assignableLoanNode->Attribute("id"))
          {
             assignableLoanIDRef_ = assignableLoanNode->Attribute("id");
             assignableLoan_ = boost::shared_ptr<PCDeliverableObligationCharac>(new PCDeliverableObligationCharac(assignableLoanNode));
             assignableLoan_->setID(assignableLoanIDRef_);
             IDManager::instance().setID(assignableLoanIDRef_,assignableLoan_);
          }
          else if(assignableLoanNode->Attribute("href")) { assignableLoanIDRef_ = assignableLoanNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { assignableLoan_ = boost::shared_ptr<PCDeliverableObligationCharac>(new PCDeliverableObligationCharac(assignableLoanNode));}
   }

   //consentRequiredLoanNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* consentRequiredLoanNode = xmlNode->FirstChildElement("consentRequiredLoan");

   if(consentRequiredLoanNode){consentRequiredLoanIsNull_ = false;}
   else{consentRequiredLoanIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- consentRequiredLoanNode , address : " << consentRequiredLoanNode << std::endl;
   #endif
   if(consentRequiredLoanNode)
   {
      if(consentRequiredLoanNode->Attribute("href") || consentRequiredLoanNode->Attribute("id"))
      {
          if(consentRequiredLoanNode->Attribute("id"))
          {
             consentRequiredLoanIDRef_ = consentRequiredLoanNode->Attribute("id");
             consentRequiredLoan_ = boost::shared_ptr<PCDeliverableObligationCharac>(new PCDeliverableObligationCharac(consentRequiredLoanNode));
             consentRequiredLoan_->setID(consentRequiredLoanIDRef_);
             IDManager::instance().setID(consentRequiredLoanIDRef_,consentRequiredLoan_);
          }
          else if(consentRequiredLoanNode->Attribute("href")) { consentRequiredLoanIDRef_ = consentRequiredLoanNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { consentRequiredLoan_ = boost::shared_ptr<PCDeliverableObligationCharac>(new PCDeliverableObligationCharac(consentRequiredLoanNode));}
   }

   //directLoanParticipationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* directLoanParticipationNode = xmlNode->FirstChildElement("directLoanParticipation");

   if(directLoanParticipationNode){directLoanParticipationIsNull_ = false;}
   else{directLoanParticipationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- directLoanParticipationNode , address : " << directLoanParticipationNode << std::endl;
   #endif
   if(directLoanParticipationNode)
   {
      if(directLoanParticipationNode->Attribute("href") || directLoanParticipationNode->Attribute("id"))
      {
          if(directLoanParticipationNode->Attribute("id"))
          {
             directLoanParticipationIDRef_ = directLoanParticipationNode->Attribute("id");
             directLoanParticipation_ = boost::shared_ptr<LoanParticipation>(new LoanParticipation(directLoanParticipationNode));
             directLoanParticipation_->setID(directLoanParticipationIDRef_);
             IDManager::instance().setID(directLoanParticipationIDRef_,directLoanParticipation_);
          }
          else if(directLoanParticipationNode->Attribute("href")) { directLoanParticipationIDRef_ = directLoanParticipationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { directLoanParticipation_ = boost::shared_ptr<LoanParticipation>(new LoanParticipation(directLoanParticipationNode));}
   }

   //transferableNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* transferableNode = xmlNode->FirstChildElement("transferable");

   if(transferableNode){transferableIsNull_ = false;}
   else{transferableIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- transferableNode , address : " << transferableNode << std::endl;
   #endif
   if(transferableNode)
   {
      if(transferableNode->Attribute("href") || transferableNode->Attribute("id"))
      {
          if(transferableNode->Attribute("id"))
          {
             transferableIDRef_ = transferableNode->Attribute("id");
             transferable_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(transferableNode));
             transferable_->setID(transferableIDRef_);
             IDManager::instance().setID(transferableIDRef_,transferable_);
          }
          else if(transferableNode->Attribute("href")) { transferableIDRef_ = transferableNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { transferable_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(transferableNode));}
   }

   //maximumMaturityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* maximumMaturityNode = xmlNode->FirstChildElement("maximumMaturity");

   if(maximumMaturityNode){maximumMaturityIsNull_ = false;}
   else{maximumMaturityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- maximumMaturityNode , address : " << maximumMaturityNode << std::endl;
   #endif
   if(maximumMaturityNode)
   {
      if(maximumMaturityNode->Attribute("href") || maximumMaturityNode->Attribute("id"))
      {
          if(maximumMaturityNode->Attribute("id"))
          {
             maximumMaturityIDRef_ = maximumMaturityNode->Attribute("id");
             maximumMaturity_ = boost::shared_ptr<Period>(new Period(maximumMaturityNode));
             maximumMaturity_->setID(maximumMaturityIDRef_);
             IDManager::instance().setID(maximumMaturityIDRef_,maximumMaturity_);
          }
          else if(maximumMaturityNode->Attribute("href")) { maximumMaturityIDRef_ = maximumMaturityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { maximumMaturity_ = boost::shared_ptr<Period>(new Period(maximumMaturityNode));}
   }

   //acceleratedOrMaturedNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* acceleratedOrMaturedNode = xmlNode->FirstChildElement("acceleratedOrMatured");

   if(acceleratedOrMaturedNode){acceleratedOrMaturedIsNull_ = false;}
   else{acceleratedOrMaturedIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- acceleratedOrMaturedNode , address : " << acceleratedOrMaturedNode << std::endl;
   #endif
   if(acceleratedOrMaturedNode)
   {
      if(acceleratedOrMaturedNode->Attribute("href") || acceleratedOrMaturedNode->Attribute("id"))
      {
          if(acceleratedOrMaturedNode->Attribute("id"))
          {
             acceleratedOrMaturedIDRef_ = acceleratedOrMaturedNode->Attribute("id");
             acceleratedOrMatured_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(acceleratedOrMaturedNode));
             acceleratedOrMatured_->setID(acceleratedOrMaturedIDRef_);
             IDManager::instance().setID(acceleratedOrMaturedIDRef_,acceleratedOrMatured_);
          }
          else if(acceleratedOrMaturedNode->Attribute("href")) { acceleratedOrMaturedIDRef_ = acceleratedOrMaturedNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { acceleratedOrMatured_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(acceleratedOrMaturedNode));}
   }

   //notBearerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notBearerNode = xmlNode->FirstChildElement("notBearer");

   if(notBearerNode){notBearerIsNull_ = false;}
   else{notBearerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notBearerNode , address : " << notBearerNode << std::endl;
   #endif
   if(notBearerNode)
   {
      if(notBearerNode->Attribute("href") || notBearerNode->Attribute("id"))
      {
          if(notBearerNode->Attribute("id"))
          {
             notBearerIDRef_ = notBearerNode->Attribute("id");
             notBearer_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(notBearerNode));
             notBearer_->setID(notBearerIDRef_);
             IDManager::instance().setID(notBearerIDRef_,notBearer_);
          }
          else if(notBearerNode->Attribute("href")) { notBearerIDRef_ = notBearerNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notBearer_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(notBearerNode));}
   }

   //fullFaithAndCreditObLiabilityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fullFaithAndCreditObLiabilityNode = xmlNode->FirstChildElement("fullFaithAndCreditObLiability");

   if(fullFaithAndCreditObLiabilityNode){fullFaithAndCreditObLiabilityIsNull_ = false;}
   else{fullFaithAndCreditObLiabilityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fullFaithAndCreditObLiabilityNode , address : " << fullFaithAndCreditObLiabilityNode << std::endl;
   #endif
   if(fullFaithAndCreditObLiabilityNode)
   {
      if(fullFaithAndCreditObLiabilityNode->Attribute("href") || fullFaithAndCreditObLiabilityNode->Attribute("id"))
      {
          if(fullFaithAndCreditObLiabilityNode->Attribute("id"))
          {
             fullFaithAndCreditObLiabilityIDRef_ = fullFaithAndCreditObLiabilityNode->Attribute("id");
             fullFaithAndCreditObLiability_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(fullFaithAndCreditObLiabilityNode));
             fullFaithAndCreditObLiability_->setID(fullFaithAndCreditObLiabilityIDRef_);
             IDManager::instance().setID(fullFaithAndCreditObLiabilityIDRef_,fullFaithAndCreditObLiability_);
          }
          else if(fullFaithAndCreditObLiabilityNode->Attribute("href")) { fullFaithAndCreditObLiabilityIDRef_ = fullFaithAndCreditObLiabilityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fullFaithAndCreditObLiability_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(fullFaithAndCreditObLiabilityNode));}
   }

   //generalFundObligationLiabilityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* generalFundObligationLiabilityNode = xmlNode->FirstChildElement("generalFundObligationLiability");

   if(generalFundObligationLiabilityNode){generalFundObligationLiabilityIsNull_ = false;}
   else{generalFundObligationLiabilityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- generalFundObligationLiabilityNode , address : " << generalFundObligationLiabilityNode << std::endl;
   #endif
   if(generalFundObligationLiabilityNode)
   {
      if(generalFundObligationLiabilityNode->Attribute("href") || generalFundObligationLiabilityNode->Attribute("id"))
      {
          if(generalFundObligationLiabilityNode->Attribute("id"))
          {
             generalFundObligationLiabilityIDRef_ = generalFundObligationLiabilityNode->Attribute("id");
             generalFundObligationLiability_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(generalFundObligationLiabilityNode));
             generalFundObligationLiability_->setID(generalFundObligationLiabilityIDRef_);
             IDManager::instance().setID(generalFundObligationLiabilityIDRef_,generalFundObligationLiability_);
          }
          else if(generalFundObligationLiabilityNode->Attribute("href")) { generalFundObligationLiabilityIDRef_ = generalFundObligationLiabilityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { generalFundObligationLiability_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(generalFundObligationLiabilityNode));}
   }

   //revenueObligationLiabilityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* revenueObligationLiabilityNode = xmlNode->FirstChildElement("revenueObligationLiability");

   if(revenueObligationLiabilityNode){revenueObligationLiabilityIsNull_ = false;}
   else{revenueObligationLiabilityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- revenueObligationLiabilityNode , address : " << revenueObligationLiabilityNode << std::endl;
   #endif
   if(revenueObligationLiabilityNode)
   {
      if(revenueObligationLiabilityNode->Attribute("href") || revenueObligationLiabilityNode->Attribute("id"))
      {
          if(revenueObligationLiabilityNode->Attribute("id"))
          {
             revenueObligationLiabilityIDRef_ = revenueObligationLiabilityNode->Attribute("id");
             revenueObligationLiability_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(revenueObligationLiabilityNode));
             revenueObligationLiability_->setID(revenueObligationLiabilityIDRef_);
             IDManager::instance().setID(revenueObligationLiabilityIDRef_,revenueObligationLiability_);
          }
          else if(revenueObligationLiabilityNode->Attribute("href")) { revenueObligationLiabilityIDRef_ = revenueObligationLiabilityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { revenueObligationLiability_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(revenueObligationLiabilityNode));}
   }

   //indirectLoanParticipationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* indirectLoanParticipationNode = xmlNode->FirstChildElement("indirectLoanParticipation");

   if(indirectLoanParticipationNode){indirectLoanParticipationIsNull_ = false;}
   else{indirectLoanParticipationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- indirectLoanParticipationNode , address : " << indirectLoanParticipationNode << std::endl;
   #endif
   if(indirectLoanParticipationNode)
   {
      if(indirectLoanParticipationNode->Attribute("href") || indirectLoanParticipationNode->Attribute("id"))
      {
          if(indirectLoanParticipationNode->Attribute("id"))
          {
             indirectLoanParticipationIDRef_ = indirectLoanParticipationNode->Attribute("id");
             indirectLoanParticipation_ = boost::shared_ptr<LoanParticipation>(new LoanParticipation(indirectLoanParticipationNode));
             indirectLoanParticipation_->setID(indirectLoanParticipationIDRef_);
             IDManager::instance().setID(indirectLoanParticipationIDRef_,indirectLoanParticipation_);
          }
          else if(indirectLoanParticipationNode->Attribute("href")) { indirectLoanParticipationIDRef_ = indirectLoanParticipationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { indirectLoanParticipation_ = boost::shared_ptr<LoanParticipation>(new LoanParticipation(indirectLoanParticipationNode));}
   }

   //excludedNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excludedNode = xmlNode->FirstChildElement("excluded");

   if(excludedNode){excludedIsNull_ = false;}
   else{excludedIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excludedNode , address : " << excludedNode << std::endl;
   #endif
   if(excludedNode)
   {
      if(excludedNode->Attribute("href") || excludedNode->Attribute("id"))
      {
          if(excludedNode->Attribute("id"))
          {
             excludedIDRef_ = excludedNode->Attribute("id");
             excluded_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(excludedNode));
             excluded_->setID(excludedIDRef_);
             IDManager::instance().setID(excludedIDRef_,excluded_);
          }
          else if(excludedNode->Attribute("href")) { excludedIDRef_ = excludedNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { excluded_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(excludedNode));}
   }

   //othReferenceEntityObligationsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* othReferenceEntityObligationsNode = xmlNode->FirstChildElement("othReferenceEntityObligations");

   if(othReferenceEntityObligationsNode){othReferenceEntityObligationsIsNull_ = false;}
   else{othReferenceEntityObligationsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- othReferenceEntityObligationsNode , address : " << othReferenceEntityObligationsNode << std::endl;
   #endif
   if(othReferenceEntityObligationsNode)
   {
      if(othReferenceEntityObligationsNode->Attribute("href") || othReferenceEntityObligationsNode->Attribute("id"))
      {
          if(othReferenceEntityObligationsNode->Attribute("id"))
          {
             othReferenceEntityObligationsIDRef_ = othReferenceEntityObligationsNode->Attribute("id");
             othReferenceEntityObligations_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(othReferenceEntityObligationsNode));
             othReferenceEntityObligations_->setID(othReferenceEntityObligationsIDRef_);
             IDManager::instance().setID(othReferenceEntityObligationsIDRef_,othReferenceEntityObligations_);
          }
          else if(othReferenceEntityObligationsNode->Attribute("href")) { othReferenceEntityObligationsIDRef_ = othReferenceEntityObligationsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { othReferenceEntityObligations_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(othReferenceEntityObligationsNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeBoolean> DeliverableObligations::getAccruedInterest()
{
   if(!this->accruedInterestIsNull_){
        if(accruedInterestIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(accruedInterestIDRef_));
        }else{
             return this->accruedInterest_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<ObligationCategoryEnum> DeliverableObligations::getCategory()
{
   if(!this->categoryIsNull_){
        if(categoryIDRef_ != ""){
             return boost::shared_static_cast<ObligationCategoryEnum>(IDManager::instance().getID(categoryIDRef_));
        }else{
             return this->category_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ObligationCategoryEnum>();
   }
}
boost::shared_ptr<XsdTypeBoolean> DeliverableObligations::getNotSubordinated()
{
   if(!this->notSubordinatedIsNull_){
        if(notSubordinatedIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(notSubordinatedIDRef_));
        }else{
             return this->notSubordinated_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<SpecifiedCurrency> DeliverableObligations::getSpecifiedCurrency()
{
   if(!this->specifiedCurrencyIsNull_){
        if(specifiedCurrencyIDRef_ != ""){
             return boost::shared_static_cast<SpecifiedCurrency>(IDManager::instance().getID(specifiedCurrencyIDRef_));
        }else{
             return this->specifiedCurrency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SpecifiedCurrency>();
   }
}
boost::shared_ptr<XsdTypeBoolean> DeliverableObligations::getNotSovereignLender()
{
   if(!this->notSovereignLenderIsNull_){
        if(notSovereignLenderIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(notSovereignLenderIDRef_));
        }else{
             return this->notSovereignLender_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<NotDomesticCurrency> DeliverableObligations::getNotDomesticCurrency()
{
   if(!this->notDomesticCurrencyIsNull_){
        if(notDomesticCurrencyIDRef_ != ""){
             return boost::shared_static_cast<NotDomesticCurrency>(IDManager::instance().getID(notDomesticCurrencyIDRef_));
        }else{
             return this->notDomesticCurrency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NotDomesticCurrency>();
   }
}
boost::shared_ptr<XsdTypeBoolean> DeliverableObligations::getNotDomesticLaw()
{
   if(!this->notDomesticLawIsNull_){
        if(notDomesticLawIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(notDomesticLawIDRef_));
        }else{
             return this->notDomesticLaw_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> DeliverableObligations::getListed()
{
   if(!this->listedIsNull_){
        if(listedIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(listedIDRef_));
        }else{
             return this->listed_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> DeliverableObligations::getNotContingent()
{
   if(!this->notContingentIsNull_){
        if(notContingentIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(notContingentIDRef_));
        }else{
             return this->notContingent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> DeliverableObligations::getNotDomesticIssuance()
{
   if(!this->notDomesticIssuanceIsNull_){
        if(notDomesticIssuanceIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(notDomesticIssuanceIDRef_));
        }else{
             return this->notDomesticIssuance_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<PCDeliverableObligationCharac> DeliverableObligations::getAssignableLoan()
{
   if(!this->assignableLoanIsNull_){
        if(assignableLoanIDRef_ != ""){
             return boost::shared_static_cast<PCDeliverableObligationCharac>(IDManager::instance().getID(assignableLoanIDRef_));
        }else{
             return this->assignableLoan_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PCDeliverableObligationCharac>();
   }
}
boost::shared_ptr<PCDeliverableObligationCharac> DeliverableObligations::getConsentRequiredLoan()
{
   if(!this->consentRequiredLoanIsNull_){
        if(consentRequiredLoanIDRef_ != ""){
             return boost::shared_static_cast<PCDeliverableObligationCharac>(IDManager::instance().getID(consentRequiredLoanIDRef_));
        }else{
             return this->consentRequiredLoan_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PCDeliverableObligationCharac>();
   }
}
boost::shared_ptr<LoanParticipation> DeliverableObligations::getDirectLoanParticipation()
{
   if(!this->directLoanParticipationIsNull_){
        if(directLoanParticipationIDRef_ != ""){
             return boost::shared_static_cast<LoanParticipation>(IDManager::instance().getID(directLoanParticipationIDRef_));
        }else{
             return this->directLoanParticipation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<LoanParticipation>();
   }
}
boost::shared_ptr<XsdTypeBoolean> DeliverableObligations::getTransferable()
{
   if(!this->transferableIsNull_){
        if(transferableIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(transferableIDRef_));
        }else{
             return this->transferable_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<Period> DeliverableObligations::getMaximumMaturity()
{
   if(!this->maximumMaturityIsNull_){
        if(maximumMaturityIDRef_ != ""){
             return boost::shared_static_cast<Period>(IDManager::instance().getID(maximumMaturityIDRef_));
        }else{
             return this->maximumMaturity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Period>();
   }
}
boost::shared_ptr<XsdTypeBoolean> DeliverableObligations::getAcceleratedOrMatured()
{
   if(!this->acceleratedOrMaturedIsNull_){
        if(acceleratedOrMaturedIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(acceleratedOrMaturedIDRef_));
        }else{
             return this->acceleratedOrMatured_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> DeliverableObligations::getNotBearer()
{
   if(!this->notBearerIsNull_){
        if(notBearerIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(notBearerIDRef_));
        }else{
             return this->notBearer_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> DeliverableObligations::getFullFaithAndCreditObLiability()
{
   if(!this->fullFaithAndCreditObLiabilityIsNull_){
        if(fullFaithAndCreditObLiabilityIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(fullFaithAndCreditObLiabilityIDRef_));
        }else{
             return this->fullFaithAndCreditObLiability_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> DeliverableObligations::getGeneralFundObligationLiability()
{
   if(!this->generalFundObligationLiabilityIsNull_){
        if(generalFundObligationLiabilityIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(generalFundObligationLiabilityIDRef_));
        }else{
             return this->generalFundObligationLiability_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> DeliverableObligations::getRevenueObligationLiability()
{
   if(!this->revenueObligationLiabilityIsNull_){
        if(revenueObligationLiabilityIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(revenueObligationLiabilityIDRef_));
        }else{
             return this->revenueObligationLiability_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<LoanParticipation> DeliverableObligations::getIndirectLoanParticipation()
{
   if(!this->indirectLoanParticipationIsNull_){
        if(indirectLoanParticipationIDRef_ != ""){
             return boost::shared_static_cast<LoanParticipation>(IDManager::instance().getID(indirectLoanParticipationIDRef_));
        }else{
             return this->indirectLoanParticipation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<LoanParticipation>();
   }
}
boost::shared_ptr<XsdTypeString> DeliverableObligations::getExcluded()
{
   if(!this->excludedIsNull_){
        if(excludedIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(excludedIDRef_));
        }else{
             return this->excluded_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
boost::shared_ptr<XsdTypeString> DeliverableObligations::getOthReferenceEntityObligations()
{
   if(!this->othReferenceEntityObligationsIsNull_){
        if(othReferenceEntityObligationsIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(othReferenceEntityObligationsIDRef_));
        }else{
             return this->othReferenceEntityObligations_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
}

