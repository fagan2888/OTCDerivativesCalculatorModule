// ExerciseFee.cpp 
#include "ExerciseFee.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ExerciseFee::ExerciseFee(TiXmlNode* xmlNode)
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

   //notionalReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notionalReferenceNode = xmlNode->FirstChildElement("notionalReference");

   if(notionalReferenceNode){notionalReferenceIsNull_ = false;}
   else{notionalReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notionalReferenceNode , address : " << notionalReferenceNode << std::endl;
   #endif
   if(notionalReferenceNode)
   {
      if(notionalReferenceNode->Attribute("href") || notionalReferenceNode->Attribute("id"))
      {
          if(notionalReferenceNode->Attribute("id"))
          {
             notionalReferenceIDRef_ = notionalReferenceNode->Attribute("id");
             notionalReference_ = boost::shared_ptr<NotionalReference>(new NotionalReference(notionalReferenceNode));
             notionalReference_->setID(notionalReferenceIDRef_);
             IDManager::instance().setID(notionalReferenceIDRef_,notionalReference_);
          }
          else if(notionalReferenceNode->Attribute("href")) { notionalReferenceIDRef_ = notionalReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notionalReference_ = boost::shared_ptr<NotionalReference>(new NotionalReference(notionalReferenceNode));}
   }

   //feeAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* feeAmountNode = xmlNode->FirstChildElement("feeAmount");

   if(feeAmountNode){feeAmountIsNull_ = false;}
   else{feeAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- feeAmountNode , address : " << feeAmountNode << std::endl;
   #endif
   if(feeAmountNode)
   {
      if(feeAmountNode->Attribute("href") || feeAmountNode->Attribute("id"))
      {
          if(feeAmountNode->Attribute("id"))
          {
             feeAmountIDRef_ = feeAmountNode->Attribute("id");
             feeAmount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(feeAmountNode));
             feeAmount_->setID(feeAmountIDRef_);
             IDManager::instance().setID(feeAmountIDRef_,feeAmount_);
          }
          else if(feeAmountNode->Attribute("href")) { feeAmountIDRef_ = feeAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { feeAmount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(feeAmountNode));}
   }

   //feeRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* feeRateNode = xmlNode->FirstChildElement("feeRate");

   if(feeRateNode){feeRateIsNull_ = false;}
   else{feeRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- feeRateNode , address : " << feeRateNode << std::endl;
   #endif
   if(feeRateNode)
   {
      if(feeRateNode->Attribute("href") || feeRateNode->Attribute("id"))
      {
          if(feeRateNode->Attribute("id"))
          {
             feeRateIDRef_ = feeRateNode->Attribute("id");
             feeRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(feeRateNode));
             feeRate_->setID(feeRateIDRef_);
             IDManager::instance().setID(feeRateIDRef_,feeRate_);
          }
          else if(feeRateNode->Attribute("href")) { feeRateIDRef_ = feeRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { feeRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(feeRateNode));}
   }

   //feePaymentDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* feePaymentDateNode = xmlNode->FirstChildElement("feePaymentDate");

   if(feePaymentDateNode){feePaymentDateIsNull_ = false;}
   else{feePaymentDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- feePaymentDateNode , address : " << feePaymentDateNode << std::endl;
   #endif
   if(feePaymentDateNode)
   {
      if(feePaymentDateNode->Attribute("href") || feePaymentDateNode->Attribute("id"))
      {
          if(feePaymentDateNode->Attribute("id"))
          {
             feePaymentDateIDRef_ = feePaymentDateNode->Attribute("id");
             feePaymentDate_ = boost::shared_ptr<RelativeDateOffset>(new RelativeDateOffset(feePaymentDateNode));
             feePaymentDate_->setID(feePaymentDateIDRef_);
             IDManager::instance().setID(feePaymentDateIDRef_,feePaymentDate_);
          }
          else if(feePaymentDateNode->Attribute("href")) { feePaymentDateIDRef_ = feePaymentDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { feePaymentDate_ = boost::shared_ptr<RelativeDateOffset>(new RelativeDateOffset(feePaymentDateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PartyReference> ExerciseFee::getPayerPartyReference()
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
boost::shared_ptr<AccountReference> ExerciseFee::getPayerAccountReference()
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
boost::shared_ptr<PartyReference> ExerciseFee::getReceiverPartyReference()
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
boost::shared_ptr<AccountReference> ExerciseFee::getReceiverAccountReference()
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
boost::shared_ptr<NotionalReference> ExerciseFee::getNotionalReference()
{
   if(!this->notionalReferenceIsNull_){
        if(notionalReferenceIDRef_ != ""){
             return boost::shared_static_cast<NotionalReference>(IDManager::instance().getID(notionalReferenceIDRef_));
        }else{
             return this->notionalReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NotionalReference>();
   }
}
boost::shared_ptr<XsdTypeDecimal> ExerciseFee::getFeeAmount()
{
   if(!this->feeAmountIsNull_){
        if(feeAmountIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(feeAmountIDRef_));
        }else{
             return this->feeAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDecimal> ExerciseFee::getFeeRate()
{
   if(!this->feeRateIsNull_){
        if(feeRateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(feeRateIDRef_));
        }else{
             return this->feeRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<RelativeDateOffset> ExerciseFee::getFeePaymentDate()
{
   if(!this->feePaymentDateIsNull_){
        if(feePaymentDateIDRef_ != ""){
             return boost::shared_static_cast<RelativeDateOffset>(IDManager::instance().getID(feePaymentDateIDRef_));
        }else{
             return this->feePaymentDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RelativeDateOffset>();
   }
}
}

