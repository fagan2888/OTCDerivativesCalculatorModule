// FeaturePayment.cpp 
#include "FeaturePayment.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FeaturePayment::FeaturePayment(TiXmlNode* xmlNode)
: PaymentBase(xmlNode)
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

   //payerAccountReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* payerAccountReferenceNode = xmlNode->FirstChildElement("payerAccountReference");

   if(payerAccountReferenceNode){payerAccountReferenceIsNull_ = false;}
   else{payerAccountReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- payerAccountReferenceNode , address : " << payerAccountReferenceNode << std::endl;
   #endif
   if(payerAccountReferenceNode)
   {
      if(payerAccountReferenceNode->Attribute("href") || payerAccountReferenceNode->Attribute("id"))
      {
          if(payerAccountReferenceNode->Attribute("id"))
          {
             payerAccountReferenceIDRef_ = payerAccountReferenceNode->Attribute("id");
             payerAccountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(payerAccountReferenceNode));
             payerAccountReference_->setID(payerAccountReferenceIDRef_);
             IDManager::instance().setID(payerAccountReferenceIDRef_,payerAccountReference_);
          }
          else if(payerAccountReferenceNode->Attribute("href")) { payerAccountReferenceIDRef_ = payerAccountReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { payerAccountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(payerAccountReferenceNode));}
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

   //receiverAccountReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* receiverAccountReferenceNode = xmlNode->FirstChildElement("receiverAccountReference");

   if(receiverAccountReferenceNode){receiverAccountReferenceIsNull_ = false;}
   else{receiverAccountReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- receiverAccountReferenceNode , address : " << receiverAccountReferenceNode << std::endl;
   #endif
   if(receiverAccountReferenceNode)
   {
      if(receiverAccountReferenceNode->Attribute("href") || receiverAccountReferenceNode->Attribute("id"))
      {
          if(receiverAccountReferenceNode->Attribute("id"))
          {
             receiverAccountReferenceIDRef_ = receiverAccountReferenceNode->Attribute("id");
             receiverAccountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(receiverAccountReferenceNode));
             receiverAccountReference_->setID(receiverAccountReferenceIDRef_);
             IDManager::instance().setID(receiverAccountReferenceIDRef_,receiverAccountReference_);
          }
          else if(receiverAccountReferenceNode->Attribute("href")) { receiverAccountReferenceIDRef_ = receiverAccountReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { receiverAccountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(receiverAccountReferenceNode));}
   }

   //levelPercentageNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* levelPercentageNode = xmlNode->FirstChildElement("levelPercentage");

   if(levelPercentageNode){levelPercentageIsNull_ = false;}
   else{levelPercentageIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- levelPercentageNode , address : " << levelPercentageNode << std::endl;
   #endif
   if(levelPercentageNode)
   {
      if(levelPercentageNode->Attribute("href") || levelPercentageNode->Attribute("id"))
      {
          if(levelPercentageNode->Attribute("id"))
          {
             levelPercentageIDRef_ = levelPercentageNode->Attribute("id");
             levelPercentage_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(levelPercentageNode));
             levelPercentage_->setID(levelPercentageIDRef_);
             IDManager::instance().setID(levelPercentageIDRef_,levelPercentage_);
          }
          else if(levelPercentageNode->Attribute("href")) { levelPercentageIDRef_ = levelPercentageNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { levelPercentage_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(levelPercentageNode));}
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
             amount_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(amountNode));
             amount_->setID(amountIDRef_);
             IDManager::instance().setID(amountIDRef_,amount_);
          }
          else if(amountNode->Attribute("href")) { amountIDRef_ = amountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { amount_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(amountNode));}
   }

   //timeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* timeNode = xmlNode->FirstChildElement("time");

   if(timeNode){timeIsNull_ = false;}
   else{timeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- timeNode , address : " << timeNode << std::endl;
   #endif
   if(timeNode)
   {
      if(timeNode->Attribute("href") || timeNode->Attribute("id"))
      {
          if(timeNode->Attribute("id"))
          {
             timeIDRef_ = timeNode->Attribute("id");
             time_ = boost::shared_ptr<TimeTypeEnum>(new TimeTypeEnum(timeNode));
             time_->setID(timeIDRef_);
             IDManager::instance().setID(timeIDRef_,time_);
          }
          else if(timeNode->Attribute("href")) { timeIDRef_ = timeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { time_ = boost::shared_ptr<TimeTypeEnum>(new TimeTypeEnum(timeNode));}
   }

   //currencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* currencyNode = xmlNode->FirstChildElement("currency");

   if(currencyNode){currencyIsNull_ = false;}
   else{currencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- currencyNode , address : " << currencyNode << std::endl;
   #endif
   if(currencyNode)
   {
      if(currencyNode->Attribute("href") || currencyNode->Attribute("id"))
      {
          if(currencyNode->Attribute("id"))
          {
             currencyIDRef_ = currencyNode->Attribute("id");
             currency_ = boost::shared_ptr<Currency>(new Currency(currencyNode));
             currency_->setID(currencyIDRef_);
             IDManager::instance().setID(currencyIDRef_,currency_);
          }
          else if(currencyNode->Attribute("href")) { currencyIDRef_ = currencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { currency_ = boost::shared_ptr<Currency>(new Currency(currencyNode));}
   }

   //featurePaymentDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* featurePaymentDateNode = xmlNode->FirstChildElement("featurePaymentDate");

   if(featurePaymentDateNode){featurePaymentDateIsNull_ = false;}
   else{featurePaymentDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- featurePaymentDateNode , address : " << featurePaymentDateNode << std::endl;
   #endif
   if(featurePaymentDateNode)
   {
      if(featurePaymentDateNode->Attribute("href") || featurePaymentDateNode->Attribute("id"))
      {
          if(featurePaymentDateNode->Attribute("id"))
          {
             featurePaymentDateIDRef_ = featurePaymentDateNode->Attribute("id");
             featurePaymentDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(featurePaymentDateNode));
             featurePaymentDate_->setID(featurePaymentDateIDRef_);
             IDManager::instance().setID(featurePaymentDateIDRef_,featurePaymentDate_);
          }
          else if(featurePaymentDateNode->Attribute("href")) { featurePaymentDateIDRef_ = featurePaymentDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { featurePaymentDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(featurePaymentDateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PartyReference> FeaturePayment::getPayerPartyReference()
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
boost::shared_ptr<AccountReference> FeaturePayment::getPayerAccountReference()
{
   if(!this->payerAccountReferenceIsNull_){
        if(payerAccountReferenceIDRef_ != ""){
             return boost::shared_static_cast<AccountReference>(IDManager::instance().getID(payerAccountReferenceIDRef_));
        }else{
             return this->payerAccountReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AccountReference>();
   }
}
boost::shared_ptr<PartyReference> FeaturePayment::getReceiverPartyReference()
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
boost::shared_ptr<AccountReference> FeaturePayment::getReceiverAccountReference()
{
   if(!this->receiverAccountReferenceIsNull_){
        if(receiverAccountReferenceIDRef_ != ""){
             return boost::shared_static_cast<AccountReference>(IDManager::instance().getID(receiverAccountReferenceIDRef_));
        }else{
             return this->receiverAccountReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AccountReference>();
   }
}
boost::shared_ptr<XsdTypeDecimal> FeaturePayment::getLevelPercentage()
{
   if(!this->levelPercentageIsNull_){
        if(levelPercentageIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(levelPercentageIDRef_));
        }else{
             return this->levelPercentage_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<NonNegativeDecimal> FeaturePayment::getAmount()
{
   if(!this->amountIsNull_){
        if(amountIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeDecimal>(IDManager::instance().getID(amountIDRef_));
        }else{
             return this->amount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeDecimal>();
   }
}
boost::shared_ptr<TimeTypeEnum> FeaturePayment::getTime()
{
   if(!this->timeIsNull_){
        if(timeIDRef_ != ""){
             return boost::shared_static_cast<TimeTypeEnum>(IDManager::instance().getID(timeIDRef_));
        }else{
             return this->time_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TimeTypeEnum>();
   }
}
boost::shared_ptr<Currency> FeaturePayment::getCurrency()
{
   if(!this->currencyIsNull_){
        if(currencyIDRef_ != ""){
             return boost::shared_static_cast<Currency>(IDManager::instance().getID(currencyIDRef_));
        }else{
             return this->currency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Currency>();
   }
}
boost::shared_ptr<AdjustableOrRelativeDate> FeaturePayment::getFeaturePaymentDate()
{
   if(!this->featurePaymentDateIsNull_){
        if(featurePaymentDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableOrRelativeDate>(IDManager::instance().getID(featurePaymentDateIDRef_));
        }else{
             return this->featurePaymentDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableOrRelativeDate>();
   }
}
}

