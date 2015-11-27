// UpfrontPremium.cpp 
#include "UpfrontPremium.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

UpfrontPremium::UpfrontPremium(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //payerPartyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* payerPartyReferenceNode = xmlNode->FirstChildElement("payerPartyReference");

   if(payerPartyReferenceNode){payerPartyReferenceIsNull_ = false;}
   else{payerPartyReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- payerPartyReferenceNode , address : " << payerPartyReferenceNode << std::endl;
   #endif
   if(payerPartyReferenceNode)
   {
      if(payerPartyReferenceNode->Attribute("href") || payerPartyReferenceNode->Attribute("id"))
      {
          if(payerPartyReferenceNode->Attribute("id"))
          {
             payerPartyReferenceIDRef_ = payerPartyReferenceNode->Attribute("id");
             payerPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(payerPartyReferenceNode));
             payerPartyReference_->setID(payerPartyReferenceIDRef_);
             IDManager::instance().setID(payerPartyReferenceIDRef_,payerPartyReference_);
          }
          else if(payerPartyReferenceNode->Attribute("href")) { payerPartyReferenceIDRef_ = payerPartyReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { payerPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(payerPartyReferenceNode));}
   }

   //receiverPartyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* receiverPartyReferenceNode = xmlNode->FirstChildElement("receiverPartyReference");

   if(receiverPartyReferenceNode){receiverPartyReferenceIsNull_ = false;}
   else{receiverPartyReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- receiverPartyReferenceNode , address : " << receiverPartyReferenceNode << std::endl;
   #endif
   if(receiverPartyReferenceNode)
   {
      if(receiverPartyReferenceNode->Attribute("href") || receiverPartyReferenceNode->Attribute("id"))
      {
          if(receiverPartyReferenceNode->Attribute("id"))
          {
             receiverPartyReferenceIDRef_ = receiverPartyReferenceNode->Attribute("id");
             receiverPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(receiverPartyReferenceNode));
             receiverPartyReference_->setID(receiverPartyReferenceIDRef_);
             IDManager::instance().setID(receiverPartyReferenceIDRef_,receiverPartyReference_);
          }
          else if(receiverPartyReferenceNode->Attribute("href")) { receiverPartyReferenceIDRef_ = receiverPartyReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { receiverPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(receiverPartyReferenceNode));}
   }

   //amountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* amountNode = xmlNode->FirstChildElement("amount");

   if(amountNode){amountIsNull_ = false;}
   else{amountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- amountNode , address : " << amountNode << std::endl;
   #endif
   if(amountNode)
   {
      if(amountNode->Attribute("href") || amountNode->Attribute("id"))
      {
          if(amountNode->Attribute("id"))
          {
             amountIDRef_ = amountNode->Attribute("id");
             amount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(amountNode));
             amount_->setID(amountIDRef_);
             IDManager::instance().setID(amountIDRef_,amount_);
          }
          else if(amountNode->Attribute("href")) { amountIDRef_ = amountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { amount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(amountNode));}
   }

   //exchangeDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exchangeDateNode = xmlNode->FirstChildElement("exchangeDate");

   if(exchangeDateNode){exchangeDateIsNull_ = false;}
   else{exchangeDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exchangeDateNode , address : " << exchangeDateNode << std::endl;
   #endif
   if(exchangeDateNode)
   {
      if(exchangeDateNode->Attribute("href") || exchangeDateNode->Attribute("id"))
      {
          if(exchangeDateNode->Attribute("id"))
          {
             exchangeDateIDRef_ = exchangeDateNode->Attribute("id");
             exchangeDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(exchangeDateNode));
             exchangeDate_->setID(exchangeDateIDRef_);
             IDManager::instance().setID(exchangeDateIDRef_,exchangeDate_);
          }
          else if(exchangeDateNode->Attribute("href")) { exchangeDateIDRef_ = exchangeDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { exchangeDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(exchangeDateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PartyReference> UpfrontPremium::getPayerPartyReference()
{
   if(!this->payerPartyReferenceIsNull_){
        if(payerPartyReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(payerPartyReferenceIDRef_));
        }else{
             return this->payerPartyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<PartyReference> UpfrontPremium::getReceiverPartyReference()
{
   if(!this->receiverPartyReferenceIsNull_){
        if(receiverPartyReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(receiverPartyReferenceIDRef_));
        }else{
             return this->receiverPartyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<XsdTypeDecimal> UpfrontPremium::getAmount()
{
   if(!this->amountIsNull_){
        if(amountIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(amountIDRef_));
        }else{
             return this->amount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDate> UpfrontPremium::getExchangeDate()
{
   if(!this->exchangeDateIsNull_){
        if(exchangeDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(exchangeDateIDRef_));
        }else{
             return this->exchangeDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
}

