// ImpliedTrade.cpp 
#include "ImpliedTrade.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ImpliedTrade::ImpliedTrade(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //originatingEventNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* originatingEventNode = xmlNode->FirstChildElement("originatingEvent");

   if(originatingEventNode){originatingEventIsNull_ = false;}
   else{originatingEventIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- originatingEventNode , address : " << originatingEventNode << std::endl;
   #endif
   if(originatingEventNode)
   {
      if(originatingEventNode->Attribute("href") || originatingEventNode->Attribute("id"))
      {
          if(originatingEventNode->Attribute("id"))
          {
             originatingEventIDRef_ = originatingEventNode->Attribute("id");
             originatingEvent_ = boost::shared_ptr<OriginatingEvent>(new OriginatingEvent(originatingEventNode));
             originatingEvent_->setID(originatingEventIDRef_);
             IDManager::instance().setID(originatingEventIDRef_,originatingEvent_);
          }
          else if(originatingEventNode->Attribute("href")) { originatingEventIDRef_ = originatingEventNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { originatingEvent_ = boost::shared_ptr<OriginatingEvent>(new OriginatingEvent(originatingEventNode));}
   }

   //tradeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tradeNode = xmlNode->FirstChildElement("trade");

   if(tradeNode){tradeIsNull_ = false;}
   else{tradeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tradeNode , address : " << tradeNode << std::endl;
   #endif
   if(tradeNode)
   {
      if(tradeNode->Attribute("href") || tradeNode->Attribute("id"))
      {
          if(tradeNode->Attribute("id"))
          {
             tradeIDRef_ = tradeNode->Attribute("id");
             trade_ = boost::shared_ptr<Trade>(new Trade(tradeNode));
             trade_->setID(tradeIDRef_);
             IDManager::instance().setID(tradeIDRef_,trade_);
          }
          else if(tradeNode->Attribute("href")) { tradeIDRef_ = tradeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { trade_ = boost::shared_ptr<Trade>(new Trade(tradeNode));}
   }

   //paymentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentNode = xmlNode->FirstChildElement("payment");

   if(paymentNode){paymentIsNull_ = false;}
   else{paymentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentNode , address : " << paymentNode << std::endl;
   #endif
   if(paymentNode)
   {
      if(paymentNode->Attribute("href") || paymentNode->Attribute("id"))
      {
          if(paymentNode->Attribute("id"))
          {
             paymentIDRef_ = paymentNode->Attribute("id");
             payment_ = boost::shared_ptr<NonNegativePayment>(new NonNegativePayment(paymentNode));
             payment_->setID(paymentIDRef_);
             IDManager::instance().setID(paymentIDRef_,payment_);
          }
          else if(paymentNode->Attribute("href")) { paymentIDRef_ = paymentNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { payment_ = boost::shared_ptr<NonNegativePayment>(new NonNegativePayment(paymentNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<OriginatingEvent> ImpliedTrade::getOriginatingEvent()
{
   if(!this->originatingEventIsNull_){
        if(originatingEventIDRef_ != ""){
             return boost::shared_static_cast<OriginatingEvent>(IDManager::instance().getID(originatingEventIDRef_));
        }else{
             return this->originatingEvent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<OriginatingEvent>();
   }
}
boost::shared_ptr<Trade> ImpliedTrade::getTrade()
{
   if(!this->tradeIsNull_){
        if(tradeIDRef_ != ""){
             return boost::shared_static_cast<Trade>(IDManager::instance().getID(tradeIDRef_));
        }else{
             return this->trade_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Trade>();
   }
}
boost::shared_ptr<NonNegativePayment> ImpliedTrade::getPayment()
{
   if(!this->paymentIsNull_){
        if(paymentIDRef_ != ""){
             return boost::shared_static_cast<NonNegativePayment>(IDManager::instance().getID(paymentIDRef_));
        }else{
             return this->payment_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativePayment>();
   }
}
}

