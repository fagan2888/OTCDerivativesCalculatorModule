// ExerciseFeeSchedule.cpp 
#include "ExerciseFeeSchedule.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ExerciseFeeSchedule::ExerciseFeeSchedule(TiXmlNode* xmlNode)
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
             notionalReference_ = boost::shared_ptr<ScheduleReference>(new ScheduleReference(notionalReferenceNode));
             notionalReference_->setID(notionalReferenceIDRef_);
             IDManager::instance().setID(notionalReferenceIDRef_,notionalReference_);
          }
          else if(notionalReferenceNode->Attribute("href")) { notionalReferenceIDRef_ = notionalReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notionalReference_ = boost::shared_ptr<ScheduleReference>(new ScheduleReference(notionalReferenceNode));}
   }

   //feeAmountScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* feeAmountScheduleNode = xmlNode->FirstChildElement("feeAmountSchedule");

   if(feeAmountScheduleNode){feeAmountScheduleIsNull_ = false;}
   else{feeAmountScheduleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- feeAmountScheduleNode , address : " << feeAmountScheduleNode << std::endl;
   #endif
   if(feeAmountScheduleNode)
   {
      if(feeAmountScheduleNode->Attribute("href") || feeAmountScheduleNode->Attribute("id"))
      {
          if(feeAmountScheduleNode->Attribute("id"))
          {
             feeAmountScheduleIDRef_ = feeAmountScheduleNode->Attribute("id");
             feeAmountSchedule_ = boost::shared_ptr<AmountSchedule>(new AmountSchedule(feeAmountScheduleNode));
             feeAmountSchedule_->setID(feeAmountScheduleIDRef_);
             IDManager::instance().setID(feeAmountScheduleIDRef_,feeAmountSchedule_);
          }
          else if(feeAmountScheduleNode->Attribute("href")) { feeAmountScheduleIDRef_ = feeAmountScheduleNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { feeAmountSchedule_ = boost::shared_ptr<AmountSchedule>(new AmountSchedule(feeAmountScheduleNode));}
   }

   //feeRateScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* feeRateScheduleNode = xmlNode->FirstChildElement("feeRateSchedule");

   if(feeRateScheduleNode){feeRateScheduleIsNull_ = false;}
   else{feeRateScheduleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- feeRateScheduleNode , address : " << feeRateScheduleNode << std::endl;
   #endif
   if(feeRateScheduleNode)
   {
      if(feeRateScheduleNode->Attribute("href") || feeRateScheduleNode->Attribute("id"))
      {
          if(feeRateScheduleNode->Attribute("id"))
          {
             feeRateScheduleIDRef_ = feeRateScheduleNode->Attribute("id");
             feeRateSchedule_ = boost::shared_ptr<Schedule>(new Schedule(feeRateScheduleNode));
             feeRateSchedule_->setID(feeRateScheduleIDRef_);
             IDManager::instance().setID(feeRateScheduleIDRef_,feeRateSchedule_);
          }
          else if(feeRateScheduleNode->Attribute("href")) { feeRateScheduleIDRef_ = feeRateScheduleNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { feeRateSchedule_ = boost::shared_ptr<Schedule>(new Schedule(feeRateScheduleNode));}
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
boost::shared_ptr<PartyReference> ExerciseFeeSchedule::getPayerPartyReference()
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
boost::shared_ptr<AccountReference> ExerciseFeeSchedule::getPayerAccountReference()
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
boost::shared_ptr<PartyReference> ExerciseFeeSchedule::getReceiverPartyReference()
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
boost::shared_ptr<AccountReference> ExerciseFeeSchedule::getReceiverAccountReference()
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
boost::shared_ptr<ScheduleReference> ExerciseFeeSchedule::getNotionalReference()
{
   if(!this->notionalReferenceIsNull_){
        if(notionalReferenceIDRef_ != ""){
             return boost::shared_static_cast<ScheduleReference>(IDManager::instance().getID(notionalReferenceIDRef_));
        }else{
             return this->notionalReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ScheduleReference>();
   }
}
boost::shared_ptr<AmountSchedule> ExerciseFeeSchedule::getFeeAmountSchedule()
{
   if(!this->feeAmountScheduleIsNull_){
        if(feeAmountScheduleIDRef_ != ""){
             return boost::shared_static_cast<AmountSchedule>(IDManager::instance().getID(feeAmountScheduleIDRef_));
        }else{
             return this->feeAmountSchedule_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AmountSchedule>();
   }
}
boost::shared_ptr<Schedule> ExerciseFeeSchedule::getFeeRateSchedule()
{
   if(!this->feeRateScheduleIsNull_){
        if(feeRateScheduleIDRef_ != ""){
             return boost::shared_static_cast<Schedule>(IDManager::instance().getID(feeRateScheduleIDRef_));
        }else{
             return this->feeRateSchedule_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Schedule>();
   }
}
boost::shared_ptr<RelativeDateOffset> ExerciseFeeSchedule::getFeePaymentDate()
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

