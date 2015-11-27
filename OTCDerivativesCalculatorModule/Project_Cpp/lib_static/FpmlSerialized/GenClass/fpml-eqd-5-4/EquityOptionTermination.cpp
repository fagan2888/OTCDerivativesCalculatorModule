// EquityOptionTermination.cpp 
#include "EquityOptionTermination.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EquityOptionTermination::EquityOptionTermination(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //settlementAmountPaymentDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementAmountPaymentDateNode = xmlNode->FirstChildElement("settlementAmountPaymentDate");

   if(settlementAmountPaymentDateNode){settlementAmountPaymentDateIsNull_ = false;}
   else{settlementAmountPaymentDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementAmountPaymentDateNode , address : " << settlementAmountPaymentDateNode << std::endl;
   #endif
   if(settlementAmountPaymentDateNode)
   {
      if(settlementAmountPaymentDateNode->Attribute("href") || settlementAmountPaymentDateNode->Attribute("id"))
      {
          if(settlementAmountPaymentDateNode->Attribute("id"))
          {
             settlementAmountPaymentDateIDRef_ = settlementAmountPaymentDateNode->Attribute("id");
             settlementAmountPaymentDate_ = boost::shared_ptr<AdjustableDate>(new AdjustableDate(settlementAmountPaymentDateNode));
             settlementAmountPaymentDate_->setID(settlementAmountPaymentDateIDRef_);
             IDManager::instance().setID(settlementAmountPaymentDateIDRef_,settlementAmountPaymentDate_);
          }
          else if(settlementAmountPaymentDateNode->Attribute("href")) { settlementAmountPaymentDateIDRef_ = settlementAmountPaymentDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { settlementAmountPaymentDate_ = boost::shared_ptr<AdjustableDate>(new AdjustableDate(settlementAmountPaymentDateNode));}
   }

   //settlementAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementAmountNode = xmlNode->FirstChildElement("settlementAmount");

   if(settlementAmountNode){settlementAmountIsNull_ = false;}
   else{settlementAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementAmountNode , address : " << settlementAmountNode << std::endl;
   #endif
   if(settlementAmountNode)
   {
      if(settlementAmountNode->Attribute("href") || settlementAmountNode->Attribute("id"))
      {
          if(settlementAmountNode->Attribute("id"))
          {
             settlementAmountIDRef_ = settlementAmountNode->Attribute("id");
             settlementAmount_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(settlementAmountNode));
             settlementAmount_->setID(settlementAmountIDRef_);
             IDManager::instance().setID(settlementAmountIDRef_,settlementAmount_);
          }
          else if(settlementAmountNode->Attribute("href")) { settlementAmountIDRef_ = settlementAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { settlementAmount_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(settlementAmountNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AdjustableDate> EquityOptionTermination::getSettlementAmountPaymentDate()
{
   if(!this->settlementAmountPaymentDateIsNull_){
        if(settlementAmountPaymentDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableDate>(IDManager::instance().getID(settlementAmountPaymentDateIDRef_));
        }else{
             return this->settlementAmountPaymentDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableDate>();
   }
}
boost::shared_ptr<NonNegativeMoney> EquityOptionTermination::getSettlementAmount()
{
   if(!this->settlementAmountIsNull_){
        if(settlementAmountIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeMoney>(IDManager::instance().getID(settlementAmountIDRef_));
        }else{
             return this->settlementAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeMoney>();
   }
}
}

