// CreditCurve.cpp 
#include "CreditCurve.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CreditCurve::CreditCurve(TiXmlNode* xmlNode)
: PricingStructure(xmlNode)
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

   //creditEntityReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* creditEntityReferenceNode = xmlNode->FirstChildElement("creditEntityReference");

   if(creditEntityReferenceNode){creditEntityReferenceIsNull_ = false;}
   else{creditEntityReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- creditEntityReferenceNode , address : " << creditEntityReferenceNode << std::endl;
   #endif
   if(creditEntityReferenceNode)
   {
      if(creditEntityReferenceNode->Attribute("href") || creditEntityReferenceNode->Attribute("id"))
      {
          if(creditEntityReferenceNode->Attribute("id"))
          {
             creditEntityReferenceIDRef_ = creditEntityReferenceNode->Attribute("id");
             creditEntityReference_ = boost::shared_ptr<LegalEntityReference>(new LegalEntityReference(creditEntityReferenceNode));
             creditEntityReference_->setID(creditEntityReferenceIDRef_);
             IDManager::instance().setID(creditEntityReferenceIDRef_,creditEntityReference_);
          }
          else if(creditEntityReferenceNode->Attribute("href")) { creditEntityReferenceIDRef_ = creditEntityReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { creditEntityReference_ = boost::shared_ptr<LegalEntityReference>(new LegalEntityReference(creditEntityReferenceNode));}
   }

   //creditEventsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* creditEventsNode = xmlNode->FirstChildElement("creditEvents");

   if(creditEventsNode){creditEventsIsNull_ = false;}
   else{creditEventsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- creditEventsNode , address : " << creditEventsNode << std::endl;
   #endif
   if(creditEventsNode)
   {
      if(creditEventsNode->Attribute("href") || creditEventsNode->Attribute("id"))
      {
          if(creditEventsNode->Attribute("id"))
          {
             creditEventsIDRef_ = creditEventsNode->Attribute("id");
             creditEvents_ = boost::shared_ptr<CreditEvents>(new CreditEvents(creditEventsNode));
             creditEvents_->setID(creditEventsIDRef_);
             IDManager::instance().setID(creditEventsIDRef_,creditEvents_);
          }
          else if(creditEventsNode->Attribute("href")) { creditEventsIDRef_ = creditEventsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { creditEvents_ = boost::shared_ptr<CreditEvents>(new CreditEvents(creditEventsNode));}
   }

   //seniorityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* seniorityNode = xmlNode->FirstChildElement("seniority");

   if(seniorityNode){seniorityIsNull_ = false;}
   else{seniorityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- seniorityNode , address : " << seniorityNode << std::endl;
   #endif
   if(seniorityNode)
   {
      if(seniorityNode->Attribute("href") || seniorityNode->Attribute("id"))
      {
          if(seniorityNode->Attribute("id"))
          {
             seniorityIDRef_ = seniorityNode->Attribute("id");
             seniority_ = boost::shared_ptr<CreditSeniority>(new CreditSeniority(seniorityNode));
             seniority_->setID(seniorityIDRef_);
             IDManager::instance().setID(seniorityIDRef_,seniority_);
          }
          else if(seniorityNode->Attribute("href")) { seniorityIDRef_ = seniorityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { seniority_ = boost::shared_ptr<CreditSeniority>(new CreditSeniority(seniorityNode));}
   }

   //securedNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* securedNode = xmlNode->FirstChildElement("secured");

   if(securedNode){securedIsNull_ = false;}
   else{securedIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- securedNode , address : " << securedNode << std::endl;
   #endif
   if(securedNode)
   {
      if(securedNode->Attribute("href") || securedNode->Attribute("id"))
      {
          if(securedNode->Attribute("id"))
          {
             securedIDRef_ = securedNode->Attribute("id");
             secured_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(securedNode));
             secured_->setID(securedIDRef_);
             IDManager::instance().setID(securedIDRef_,secured_);
          }
          else if(securedNode->Attribute("href")) { securedIDRef_ = securedNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { secured_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(securedNode));}
   }

   //obligationCurrencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* obligationCurrencyNode = xmlNode->FirstChildElement("obligationCurrency");

   if(obligationCurrencyNode){obligationCurrencyIsNull_ = false;}
   else{obligationCurrencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- obligationCurrencyNode , address : " << obligationCurrencyNode << std::endl;
   #endif
   if(obligationCurrencyNode)
   {
      if(obligationCurrencyNode->Attribute("href") || obligationCurrencyNode->Attribute("id"))
      {
          if(obligationCurrencyNode->Attribute("id"))
          {
             obligationCurrencyIDRef_ = obligationCurrencyNode->Attribute("id");
             obligationCurrency_ = boost::shared_ptr<Currency>(new Currency(obligationCurrencyNode));
             obligationCurrency_->setID(obligationCurrencyIDRef_);
             IDManager::instance().setID(obligationCurrencyIDRef_,obligationCurrency_);
          }
          else if(obligationCurrencyNode->Attribute("href")) { obligationCurrencyIDRef_ = obligationCurrencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { obligationCurrency_ = boost::shared_ptr<Currency>(new Currency(obligationCurrencyNode));}
   }

   //obligationsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* obligationsNode = xmlNode->FirstChildElement("obligations");

   if(obligationsNode){obligationsIsNull_ = false;}
   else{obligationsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- obligationsNode , address : " << obligationsNode << std::endl;
   #endif
   if(obligationsNode)
   {
      if(obligationsNode->Attribute("href") || obligationsNode->Attribute("id"))
      {
          if(obligationsNode->Attribute("id"))
          {
             obligationsIDRef_ = obligationsNode->Attribute("id");
             obligations_ = boost::shared_ptr<Obligations>(new Obligations(obligationsNode));
             obligations_->setID(obligationsIDRef_);
             IDManager::instance().setID(obligationsIDRef_,obligations_);
          }
          else if(obligationsNode->Attribute("href")) { obligationsIDRef_ = obligationsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { obligations_ = boost::shared_ptr<Obligations>(new Obligations(obligationsNode));}
   }

   //deliverableObligationsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* deliverableObligationsNode = xmlNode->FirstChildElement("deliverableObligations");

   if(deliverableObligationsNode){deliverableObligationsIsNull_ = false;}
   else{deliverableObligationsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- deliverableObligationsNode , address : " << deliverableObligationsNode << std::endl;
   #endif
   if(deliverableObligationsNode)
   {
      if(deliverableObligationsNode->Attribute("href") || deliverableObligationsNode->Attribute("id"))
      {
          if(deliverableObligationsNode->Attribute("id"))
          {
             deliverableObligationsIDRef_ = deliverableObligationsNode->Attribute("id");
             deliverableObligations_ = boost::shared_ptr<DeliverableObligations>(new DeliverableObligations(deliverableObligationsNode));
             deliverableObligations_->setID(deliverableObligationsIDRef_);
             IDManager::instance().setID(deliverableObligationsIDRef_,deliverableObligations_);
          }
          else if(deliverableObligationsNode->Attribute("href")) { deliverableObligationsIDRef_ = deliverableObligationsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { deliverableObligations_ = boost::shared_ptr<DeliverableObligations>(new DeliverableObligations(deliverableObligationsNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<LegalEntity> CreditCurve::getReferenceEntity()
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
boost::shared_ptr<LegalEntityReference> CreditCurve::getCreditEntityReference()
{
   if(!this->creditEntityReferenceIsNull_){
        if(creditEntityReferenceIDRef_ != ""){
             return boost::shared_static_cast<LegalEntityReference>(IDManager::instance().getID(creditEntityReferenceIDRef_));
        }else{
             return this->creditEntityReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<LegalEntityReference>();
   }
}
boost::shared_ptr<CreditEvents> CreditCurve::getCreditEvents()
{
   if(!this->creditEventsIsNull_){
        if(creditEventsIDRef_ != ""){
             return boost::shared_static_cast<CreditEvents>(IDManager::instance().getID(creditEventsIDRef_));
        }else{
             return this->creditEvents_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CreditEvents>();
   }
}
boost::shared_ptr<CreditSeniority> CreditCurve::getSeniority()
{
   if(!this->seniorityIsNull_){
        if(seniorityIDRef_ != ""){
             return boost::shared_static_cast<CreditSeniority>(IDManager::instance().getID(seniorityIDRef_));
        }else{
             return this->seniority_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CreditSeniority>();
   }
}
boost::shared_ptr<XsdTypeBoolean> CreditCurve::getSecured()
{
   if(!this->securedIsNull_){
        if(securedIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(securedIDRef_));
        }else{
             return this->secured_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<Currency> CreditCurve::getObligationCurrency()
{
   if(!this->obligationCurrencyIsNull_){
        if(obligationCurrencyIDRef_ != ""){
             return boost::shared_static_cast<Currency>(IDManager::instance().getID(obligationCurrencyIDRef_));
        }else{
             return this->obligationCurrency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Currency>();
   }
}
boost::shared_ptr<Obligations> CreditCurve::getObligations()
{
   if(!this->obligationsIsNull_){
        if(obligationsIDRef_ != ""){
             return boost::shared_static_cast<Obligations>(IDManager::instance().getID(obligationsIDRef_));
        }else{
             return this->obligations_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Obligations>();
   }
}
boost::shared_ptr<DeliverableObligations> CreditCurve::getDeliverableObligations()
{
   if(!this->deliverableObligationsIsNull_){
        if(deliverableObligationsIDRef_ != ""){
             return boost::shared_static_cast<DeliverableObligations>(IDManager::instance().getID(deliverableObligationsIDRef_));
        }else{
             return this->deliverableObligations_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DeliverableObligations>();
   }
}
}

