// SimpleCreditDefaultSwap.cpp 
#include "SimpleCreditDefaultSwap.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SimpleCreditDefaultSwap::SimpleCreditDefaultSwap(TiXmlNode* xmlNode)
: UnderlyingAsset(xmlNode)
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

   //termNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* termNode = xmlNode->FirstChildElement("term");

   if(termNode){termIsNull_ = false;}
   else{termIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- termNode , address : " << termNode << std::endl;
   #endif
   if(termNode)
   {
      if(termNode->Attribute("href") || termNode->Attribute("id"))
      {
          if(termNode->Attribute("id"))
          {
             termIDRef_ = termNode->Attribute("id");
             term_ = boost::shared_ptr<Period>(new Period(termNode));
             term_->setID(termIDRef_);
             IDManager::instance().setID(termIDRef_,term_);
          }
          else if(termNode->Attribute("href")) { termIDRef_ = termNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { term_ = boost::shared_ptr<Period>(new Period(termNode));}
   }

   //paymentFrequencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentFrequencyNode = xmlNode->FirstChildElement("paymentFrequency");

   if(paymentFrequencyNode){paymentFrequencyIsNull_ = false;}
   else{paymentFrequencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentFrequencyNode , address : " << paymentFrequencyNode << std::endl;
   #endif
   if(paymentFrequencyNode)
   {
      if(paymentFrequencyNode->Attribute("href") || paymentFrequencyNode->Attribute("id"))
      {
          if(paymentFrequencyNode->Attribute("id"))
          {
             paymentFrequencyIDRef_ = paymentFrequencyNode->Attribute("id");
             paymentFrequency_ = boost::shared_ptr<Period>(new Period(paymentFrequencyNode));
             paymentFrequency_->setID(paymentFrequencyIDRef_);
             IDManager::instance().setID(paymentFrequencyIDRef_,paymentFrequency_);
          }
          else if(paymentFrequencyNode->Attribute("href")) { paymentFrequencyIDRef_ = paymentFrequencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { paymentFrequency_ = boost::shared_ptr<Period>(new Period(paymentFrequencyNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<LegalEntity> SimpleCreditDefaultSwap::getReferenceEntity()
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
boost::shared_ptr<LegalEntityReference> SimpleCreditDefaultSwap::getCreditEntityReference()
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
boost::shared_ptr<Period> SimpleCreditDefaultSwap::getTerm()
{
   if(!this->termIsNull_){
        if(termIDRef_ != ""){
             return boost::shared_static_cast<Period>(IDManager::instance().getID(termIDRef_));
        }else{
             return this->term_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Period>();
   }
}
boost::shared_ptr<Period> SimpleCreditDefaultSwap::getPaymentFrequency()
{
   if(!this->paymentFrequencyIsNull_){
        if(paymentFrequencyIDRef_ != ""){
             return boost::shared_static_cast<Period>(IDManager::instance().getID(paymentFrequencyIDRef_));
        }else{
             return this->paymentFrequency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Period>();
   }
}
}

