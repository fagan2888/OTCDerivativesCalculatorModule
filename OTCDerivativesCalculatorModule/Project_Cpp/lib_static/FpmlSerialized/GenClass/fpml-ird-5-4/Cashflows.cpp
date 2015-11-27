// Cashflows.cpp 
#include "Cashflows.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Cashflows::Cashflows(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //cashflowsMatchParametersNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* cashflowsMatchParametersNode = xmlNode->FirstChildElement("cashflowsMatchParameters");

   if(cashflowsMatchParametersNode){cashflowsMatchParametersIsNull_ = false;}
   else{cashflowsMatchParametersIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cashflowsMatchParametersNode , address : " << cashflowsMatchParametersNode << std::endl;
   #endif
   if(cashflowsMatchParametersNode)
   {
      if(cashflowsMatchParametersNode->Attribute("href") || cashflowsMatchParametersNode->Attribute("id"))
      {
          if(cashflowsMatchParametersNode->Attribute("id"))
          {
             cashflowsMatchParametersIDRef_ = cashflowsMatchParametersNode->Attribute("id");
             cashflowsMatchParameters_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(cashflowsMatchParametersNode));
             cashflowsMatchParameters_->setID(cashflowsMatchParametersIDRef_);
             IDManager::instance().setID(cashflowsMatchParametersIDRef_,cashflowsMatchParameters_);
          }
          else if(cashflowsMatchParametersNode->Attribute("href")) { cashflowsMatchParametersIDRef_ = cashflowsMatchParametersNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { cashflowsMatchParameters_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(cashflowsMatchParametersNode));}
   }

   //principalExchangeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* principalExchangeNode = xmlNode->FirstChildElement("principalExchange");

   if(principalExchangeNode){principalExchangeIsNull_ = false;}
   else{principalExchangeIsNull_ = true;}

   if(principalExchangeNode)
   {
      for(principalExchangeNode; principalExchangeNode; principalExchangeNode = principalExchangeNode->NextSiblingElement("principalExchange")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- principalExchangeNode , address : " << principalExchangeNode << std::endl;
          #endif
          if(principalExchangeNode->Attribute("href") || principalExchangeNode->Attribute("id"))
          {
              if(principalExchangeNode->Attribute("id"))
              {
                  principalExchangeIDRef_ = principalExchangeNode->Attribute("id");
                  principalExchange_.push_back(boost::shared_ptr<PrincipalExchange>(new PrincipalExchange(principalExchangeNode)));
                  principalExchange_.back()->setID(principalExchangeIDRef_);
                  IDManager::instance().setID(principalExchangeIDRef_, principalExchange_.back());
              }
              else if(principalExchangeNode->Attribute("href")) { principalExchangeIDRef_ = principalExchangeNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { principalExchange_.push_back(boost::shared_ptr<PrincipalExchange>(new PrincipalExchange(principalExchangeNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- principalExchangeNode , address : " << principalExchangeNode << std::endl;
       #endif
   }

   //paymentCalculationPeriodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentCalculationPeriodNode = xmlNode->FirstChildElement("paymentCalculationPeriod");

   if(paymentCalculationPeriodNode){paymentCalculationPeriodIsNull_ = false;}
   else{paymentCalculationPeriodIsNull_ = true;}

   if(paymentCalculationPeriodNode)
   {
      for(paymentCalculationPeriodNode; paymentCalculationPeriodNode; paymentCalculationPeriodNode = paymentCalculationPeriodNode->NextSiblingElement("paymentCalculationPeriod")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentCalculationPeriodNode , address : " << paymentCalculationPeriodNode << std::endl;
          #endif
          if(paymentCalculationPeriodNode->Attribute("href") || paymentCalculationPeriodNode->Attribute("id"))
          {
              if(paymentCalculationPeriodNode->Attribute("id"))
              {
                  paymentCalculationPeriodIDRef_ = paymentCalculationPeriodNode->Attribute("id");
                  paymentCalculationPeriod_.push_back(boost::shared_ptr<PaymentCalculationPeriod>(new PaymentCalculationPeriod(paymentCalculationPeriodNode)));
                  paymentCalculationPeriod_.back()->setID(paymentCalculationPeriodIDRef_);
                  IDManager::instance().setID(paymentCalculationPeriodIDRef_, paymentCalculationPeriod_.back());
              }
              else if(paymentCalculationPeriodNode->Attribute("href")) { paymentCalculationPeriodIDRef_ = paymentCalculationPeriodNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { paymentCalculationPeriod_.push_back(boost::shared_ptr<PaymentCalculationPeriod>(new PaymentCalculationPeriod(paymentCalculationPeriodNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentCalculationPeriodNode , address : " << paymentCalculationPeriodNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeBoolean> Cashflows::getCashflowsMatchParameters()
{
   if(!this->cashflowsMatchParametersIsNull_){
        if(cashflowsMatchParametersIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(cashflowsMatchParametersIDRef_));
        }else{
             return this->cashflowsMatchParameters_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
std::vector<boost::shared_ptr<PrincipalExchange>> Cashflows::getPrincipalExchange()
{
   if(!this->principalExchangeIsNull_){
        if(principalExchangeIDRef_ != ""){
             return this->principalExchange_;
        }else{
             return this->principalExchange_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<PrincipalExchange>>();
   }
}
std::vector<boost::shared_ptr<PaymentCalculationPeriod>> Cashflows::getPaymentCalculationPeriod()
{
   if(!this->paymentCalculationPeriodIsNull_){
        if(paymentCalculationPeriodIDRef_ != ""){
             return this->paymentCalculationPeriod_;
        }else{
             return this->paymentCalculationPeriod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<PaymentCalculationPeriod>>();
   }
}
}

