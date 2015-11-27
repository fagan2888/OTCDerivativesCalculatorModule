// FxOptionPremium.cpp 
#include "FxOptionPremium.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FxOptionPremium::FxOptionPremium(TiXmlNode* xmlNode)
: NonNegativePayment(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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

   //quoteNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* quoteNode = xmlNode->FirstChildElement("quote");

   if(quoteNode){quoteIsNull_ = false;}
   else{quoteIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- quoteNode , address : " << quoteNode << std::endl;
   #endif
   if(quoteNode)
   {
      if(quoteNode->Attribute("href") || quoteNode->Attribute("id"))
      {
          if(quoteNode->Attribute("id"))
          {
             quoteIDRef_ = quoteNode->Attribute("id");
             quote_ = boost::shared_ptr<PremiumQuote>(new PremiumQuote(quoteNode));
             quote_->setID(quoteIDRef_);
             IDManager::instance().setID(quoteIDRef_,quote_);
          }
          else if(quoteNode->Attribute("href")) { quoteIDRef_ = quoteNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { quote_ = boost::shared_ptr<PremiumQuote>(new PremiumQuote(quoteNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<SettlementInformation> FxOptionPremium::getSettlementInformation()
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
boost::shared_ptr<PremiumQuote> FxOptionPremium::getQuote()
{
   if(!this->quoteIsNull_){
        if(quoteIDRef_ != ""){
             return boost::shared_static_cast<PremiumQuote>(IDManager::instance().getID(quoteIDRef_));
        }else{
             return this->quote_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PremiumQuote>();
   }
}
}

