// Withdrawal.cpp 
#include "Withdrawal.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Withdrawal::Withdrawal(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //partyTradeIdentifierNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* partyTradeIdentifierNode = xmlNode->FirstChildElement("partyTradeIdentifier");

   if(partyTradeIdentifierNode){partyTradeIdentifierIsNull_ = false;}
   else{partyTradeIdentifierIsNull_ = true;}

   if(partyTradeIdentifierNode)
   {
      for(partyTradeIdentifierNode; partyTradeIdentifierNode; partyTradeIdentifierNode = partyTradeIdentifierNode->NextSiblingElement("partyTradeIdentifier")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partyTradeIdentifierNode , address : " << partyTradeIdentifierNode << std::endl;
          #endif
          if(partyTradeIdentifierNode->Attribute("href") || partyTradeIdentifierNode->Attribute("id"))
          {
              if(partyTradeIdentifierNode->Attribute("id"))
              {
                  partyTradeIdentifierIDRef_ = partyTradeIdentifierNode->Attribute("id");
                  partyTradeIdentifier_.push_back(boost::shared_ptr<PartyTradeIdentifier>(new PartyTradeIdentifier(partyTradeIdentifierNode)));
                  partyTradeIdentifier_.back()->setID(partyTradeIdentifierIDRef_);
                  IDManager::instance().setID(partyTradeIdentifierIDRef_, partyTradeIdentifier_.back());
              }
              else if(partyTradeIdentifierNode->Attribute("href")) { partyTradeIdentifierIDRef_ = partyTradeIdentifierNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { partyTradeIdentifier_.push_back(boost::shared_ptr<PartyTradeIdentifier>(new PartyTradeIdentifier(partyTradeIdentifierNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partyTradeIdentifierNode , address : " << partyTradeIdentifierNode << std::endl;
       #endif
   }

   //effectiveDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* effectiveDateNode = xmlNode->FirstChildElement("effectiveDate");

   if(effectiveDateNode){effectiveDateIsNull_ = false;}
   else{effectiveDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- effectiveDateNode , address : " << effectiveDateNode << std::endl;
   #endif
   if(effectiveDateNode)
   {
      if(effectiveDateNode->Attribute("href") || effectiveDateNode->Attribute("id"))
      {
          if(effectiveDateNode->Attribute("id"))
          {
             effectiveDateIDRef_ = effectiveDateNode->Attribute("id");
             effectiveDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(effectiveDateNode));
             effectiveDate_->setID(effectiveDateIDRef_);
             IDManager::instance().setID(effectiveDateIDRef_,effectiveDate_);
          }
          else if(effectiveDateNode->Attribute("href")) { effectiveDateIDRef_ = effectiveDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { effectiveDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(effectiveDateNode));}
   }

   //requestedActionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* requestedActionNode = xmlNode->FirstChildElement("requestedAction");

   if(requestedActionNode){requestedActionIsNull_ = false;}
   else{requestedActionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- requestedActionNode , address : " << requestedActionNode << std::endl;
   #endif
   if(requestedActionNode)
   {
      if(requestedActionNode->Attribute("href") || requestedActionNode->Attribute("id"))
      {
          if(requestedActionNode->Attribute("id"))
          {
             requestedActionIDRef_ = requestedActionNode->Attribute("id");
             requestedAction_ = boost::shared_ptr<RequestedWithdrawalAction>(new RequestedWithdrawalAction(requestedActionNode));
             requestedAction_->setID(requestedActionIDRef_);
             IDManager::instance().setID(requestedActionIDRef_,requestedAction_);
          }
          else if(requestedActionNode->Attribute("href")) { requestedActionIDRef_ = requestedActionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { requestedAction_ = boost::shared_ptr<RequestedWithdrawalAction>(new RequestedWithdrawalAction(requestedActionNode));}
   }

   //reasonNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* reasonNode = xmlNode->FirstChildElement("reason");

   if(reasonNode){reasonIsNull_ = false;}
   else{reasonIsNull_ = true;}

   if(reasonNode)
   {
      for(reasonNode; reasonNode; reasonNode = reasonNode->NextSiblingElement("reason")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- reasonNode , address : " << reasonNode << std::endl;
          #endif
          if(reasonNode->Attribute("href") || reasonNode->Attribute("id"))
          {
              if(reasonNode->Attribute("id"))
              {
                  reasonIDRef_ = reasonNode->Attribute("id");
                  reason_.push_back(boost::shared_ptr<WithdrawalReason>(new WithdrawalReason(reasonNode)));
                  reason_.back()->setID(reasonIDRef_);
                  IDManager::instance().setID(reasonIDRef_, reason_.back());
              }
              else if(reasonNode->Attribute("href")) { reasonIDRef_ = reasonNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { reason_.push_back(boost::shared_ptr<WithdrawalReason>(new WithdrawalReason(reasonNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- reasonNode , address : " << reasonNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<PartyTradeIdentifier>> Withdrawal::getPartyTradeIdentifier()
{
   if(!this->partyTradeIdentifierIsNull_){
        if(partyTradeIdentifierIDRef_ != ""){
             return this->partyTradeIdentifier_;
        }else{
             return this->partyTradeIdentifier_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<PartyTradeIdentifier>>();
   }
}
boost::shared_ptr<XsdTypeDate> Withdrawal::getEffectiveDate()
{
   if(!this->effectiveDateIsNull_){
        if(effectiveDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(effectiveDateIDRef_));
        }else{
             return this->effectiveDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<RequestedWithdrawalAction> Withdrawal::getRequestedAction()
{
   if(!this->requestedActionIsNull_){
        if(requestedActionIDRef_ != ""){
             return boost::shared_static_cast<RequestedWithdrawalAction>(IDManager::instance().getID(requestedActionIDRef_));
        }else{
             return this->requestedAction_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RequestedWithdrawalAction>();
   }
}
std::vector<boost::shared_ptr<WithdrawalReason>> Withdrawal::getReason()
{
   if(!this->reasonIsNull_){
        if(reasonIDRef_ != ""){
             return this->reason_;
        }else{
             return this->reason_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<WithdrawalReason>>();
   }
}
}

