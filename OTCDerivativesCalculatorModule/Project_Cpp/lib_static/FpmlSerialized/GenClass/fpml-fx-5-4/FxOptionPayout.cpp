// FxOptionPayout.cpp 
#include "FxOptionPayout.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FxOptionPayout::FxOptionPayout(TiXmlNode* xmlNode)
: NonNegativeMoney(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //payoutStyleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* payoutStyleNode = xmlNode->FirstChildElement("payoutStyle");

   if(payoutStyleNode){payoutStyleIsNull_ = false;}
   else{payoutStyleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- payoutStyleNode , address : " << payoutStyleNode << std::endl;
   #endif
   if(payoutStyleNode)
   {
      if(payoutStyleNode->Attribute("href") || payoutStyleNode->Attribute("id"))
      {
          if(payoutStyleNode->Attribute("id"))
          {
             payoutStyleIDRef_ = payoutStyleNode->Attribute("id");
             payoutStyle_ = boost::shared_ptr<PayoutEnum>(new PayoutEnum(payoutStyleNode));
             payoutStyle_->setID(payoutStyleIDRef_);
             IDManager::instance().setID(payoutStyleIDRef_,payoutStyle_);
          }
          else if(payoutStyleNode->Attribute("href")) { payoutStyleIDRef_ = payoutStyleNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { payoutStyle_ = boost::shared_ptr<PayoutEnum>(new PayoutEnum(payoutStyleNode));}
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
boost::shared_ptr<PayoutEnum> FxOptionPayout::getPayoutStyle()
{
   if(!this->payoutStyleIsNull_){
        if(payoutStyleIDRef_ != ""){
             return boost::shared_static_cast<PayoutEnum>(IDManager::instance().getID(payoutStyleIDRef_));
        }else{
             return this->payoutStyle_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PayoutEnum>();
   }
}
boost::shared_ptr<SettlementInformation> FxOptionPayout::getSettlementInformation()
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

