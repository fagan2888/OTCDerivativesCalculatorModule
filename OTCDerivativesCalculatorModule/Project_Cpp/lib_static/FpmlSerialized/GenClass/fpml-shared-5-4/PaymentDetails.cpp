// PaymentDetails.cpp 
#include "PaymentDetails.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PaymentDetails::PaymentDetails(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //paymentReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentReferenceNode = xmlNode->FirstChildElement("paymentReference");

   if(paymentReferenceNode){paymentReferenceIsNull_ = false;}
   else{paymentReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentReferenceNode , address : " << paymentReferenceNode << std::endl;
   #endif
   if(paymentReferenceNode)
   {
      if(paymentReferenceNode->Attribute("href") || paymentReferenceNode->Attribute("id"))
      {
          if(paymentReferenceNode->Attribute("id"))
          {
             paymentReferenceIDRef_ = paymentReferenceNode->Attribute("id");
             paymentReference_ = boost::shared_ptr<PaymentReference>(new PaymentReference(paymentReferenceNode));
             paymentReference_->setID(paymentReferenceIDRef_);
             IDManager::instance().setID(paymentReferenceIDRef_,paymentReference_);
          }
          else if(paymentReferenceNode->Attribute("href")) { paymentReferenceIDRef_ = paymentReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { paymentReference_ = boost::shared_ptr<PaymentReference>(new PaymentReference(paymentReferenceNode));}
   }

   //grossCashflowNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* grossCashflowNode = xmlNode->FirstChildElement("grossCashflow");

   if(grossCashflowNode){grossCashflowIsNull_ = false;}
   else{grossCashflowIsNull_ = true;}

   if(grossCashflowNode)
   {
      for(grossCashflowNode; grossCashflowNode; grossCashflowNode = grossCashflowNode->NextSiblingElement("grossCashflow")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- grossCashflowNode , address : " << grossCashflowNode << std::endl;
          #endif
          if(grossCashflowNode->Attribute("href") || grossCashflowNode->Attribute("id"))
          {
              if(grossCashflowNode->Attribute("id"))
              {
                  grossCashflowIDRef_ = grossCashflowNode->Attribute("id");
                  grossCashflow_.push_back(boost::shared_ptr<GrossCashflow>(new GrossCashflow(grossCashflowNode)));
                  grossCashflow_.back()->setID(grossCashflowIDRef_);
                  IDManager::instance().setID(grossCashflowIDRef_, grossCashflow_.back());
              }
              else if(grossCashflowNode->Attribute("href")) { grossCashflowIDRef_ = grossCashflowNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { grossCashflow_.push_back(boost::shared_ptr<GrossCashflow>(new GrossCashflow(grossCashflowNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- grossCashflowNode , address : " << grossCashflowNode << std::endl;
       #endif
   }

   //settlementInformationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementInformationNode = xmlNode->FirstChildElement("settlementInformation");

   if(settlementInformationNode){settlementInformationIsNull_ = false;}
   else{settlementInformationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementInformationNode , address : " << settlementInformationNode << std::endl;
   #endif
   if(settlementInformationNode)
   {
      if(settlementInformationNode->Attribute("href") || settlementInformationNode->Attribute("id"))
      {
          if(settlementInformationNode->Attribute("id"))
          {
             settlementInformationIDRef_ = settlementInformationNode->Attribute("id");
             settlementInformation_ = boost::shared_ptr<SettlementInformation>(new SettlementInformation(settlementInformationNode));
             settlementInformation_->setID(settlementInformationIDRef_);
             IDManager::instance().setID(settlementInformationIDRef_,settlementInformation_);
          }
          else if(settlementInformationNode->Attribute("href")) { settlementInformationIDRef_ = settlementInformationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { settlementInformation_ = boost::shared_ptr<SettlementInformation>(new SettlementInformation(settlementInformationNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PaymentReference> PaymentDetails::getPaymentReference()
{
   if(!this->paymentReferenceIsNull_){
        if(paymentReferenceIDRef_ != ""){
             return boost::shared_static_cast<PaymentReference>(IDManager::instance().getID(paymentReferenceIDRef_));
        }else{
             return this->paymentReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PaymentReference>();
   }
}
std::vector<boost::shared_ptr<GrossCashflow>> PaymentDetails::getGrossCashflow()
{
   if(!this->grossCashflowIsNull_){
        if(grossCashflowIDRef_ != ""){
             return this->grossCashflow_;
        }else{
             return this->grossCashflow_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<GrossCashflow>>();
   }
}
boost::shared_ptr<SettlementInformation> PaymentDetails::getSettlementInformation()
{
   if(!this->settlementInformationIsNull_){
        if(settlementInformationIDRef_ != ""){
             return boost::shared_static_cast<SettlementInformation>(IDManager::instance().getID(settlementInformationIDRef_));
        }else{
             return this->settlementInformation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SettlementInformation>();
   }
}
}

