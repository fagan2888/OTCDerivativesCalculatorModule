// Commission.cpp 
#include "Commission.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Commission::Commission(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //commissionDenominationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* commissionDenominationNode = xmlNode->FirstChildElement("commissionDenomination");

   if(commissionDenominationNode){commissionDenominationIsNull_ = false;}
   else{commissionDenominationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- commissionDenominationNode , address : " << commissionDenominationNode << std::endl;
   #endif
   if(commissionDenominationNode)
   {
      if(commissionDenominationNode->Attribute("href") || commissionDenominationNode->Attribute("id"))
      {
          if(commissionDenominationNode->Attribute("id"))
          {
             commissionDenominationIDRef_ = commissionDenominationNode->Attribute("id");
             commissionDenomination_ = boost::shared_ptr<CommissionDenominationEnum>(new CommissionDenominationEnum(commissionDenominationNode));
             commissionDenomination_->setID(commissionDenominationIDRef_);
             IDManager::instance().setID(commissionDenominationIDRef_,commissionDenomination_);
          }
          else if(commissionDenominationNode->Attribute("href")) { commissionDenominationIDRef_ = commissionDenominationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { commissionDenomination_ = boost::shared_ptr<CommissionDenominationEnum>(new CommissionDenominationEnum(commissionDenominationNode));}
   }

   //commissionAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* commissionAmountNode = xmlNode->FirstChildElement("commissionAmount");

   if(commissionAmountNode){commissionAmountIsNull_ = false;}
   else{commissionAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- commissionAmountNode , address : " << commissionAmountNode << std::endl;
   #endif
   if(commissionAmountNode)
   {
      if(commissionAmountNode->Attribute("href") || commissionAmountNode->Attribute("id"))
      {
          if(commissionAmountNode->Attribute("id"))
          {
             commissionAmountIDRef_ = commissionAmountNode->Attribute("id");
             commissionAmount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(commissionAmountNode));
             commissionAmount_->setID(commissionAmountIDRef_);
             IDManager::instance().setID(commissionAmountIDRef_,commissionAmount_);
          }
          else if(commissionAmountNode->Attribute("href")) { commissionAmountIDRef_ = commissionAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { commissionAmount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(commissionAmountNode));}
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

   //commissionPerTradeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* commissionPerTradeNode = xmlNode->FirstChildElement("commissionPerTrade");

   if(commissionPerTradeNode){commissionPerTradeIsNull_ = false;}
   else{commissionPerTradeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- commissionPerTradeNode , address : " << commissionPerTradeNode << std::endl;
   #endif
   if(commissionPerTradeNode)
   {
      if(commissionPerTradeNode->Attribute("href") || commissionPerTradeNode->Attribute("id"))
      {
          if(commissionPerTradeNode->Attribute("id"))
          {
             commissionPerTradeIDRef_ = commissionPerTradeNode->Attribute("id");
             commissionPerTrade_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(commissionPerTradeNode));
             commissionPerTrade_->setID(commissionPerTradeIDRef_);
             IDManager::instance().setID(commissionPerTradeIDRef_,commissionPerTrade_);
          }
          else if(commissionPerTradeNode->Attribute("href")) { commissionPerTradeIDRef_ = commissionPerTradeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { commissionPerTrade_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(commissionPerTradeNode));}
   }

   //fxRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fxRateNode = xmlNode->FirstChildElement("fxRate");

   if(fxRateNode){fxRateIsNull_ = false;}
   else{fxRateIsNull_ = true;}

   if(fxRateNode)
   {
      for(fxRateNode; fxRateNode; fxRateNode = fxRateNode->NextSiblingElement("fxRate")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fxRateNode , address : " << fxRateNode << std::endl;
          #endif
          if(fxRateNode->Attribute("href") || fxRateNode->Attribute("id"))
          {
              if(fxRateNode->Attribute("id"))
              {
                  fxRateIDRef_ = fxRateNode->Attribute("id");
                  fxRate_.push_back(boost::shared_ptr<FxRate>(new FxRate(fxRateNode)));
                  fxRate_.back()->setID(fxRateIDRef_);
                  IDManager::instance().setID(fxRateIDRef_, fxRate_.back());
              }
              else if(fxRateNode->Attribute("href")) { fxRateIDRef_ = fxRateNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { fxRate_.push_back(boost::shared_ptr<FxRate>(new FxRate(fxRateNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fxRateNode , address : " << fxRateNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CommissionDenominationEnum> Commission::getCommissionDenomination()
{
   if(!this->commissionDenominationIsNull_){
        if(commissionDenominationIDRef_ != ""){
             return boost::shared_static_cast<CommissionDenominationEnum>(IDManager::instance().getID(commissionDenominationIDRef_));
        }else{
             return this->commissionDenomination_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommissionDenominationEnum>();
   }
}
boost::shared_ptr<XsdTypeDecimal> Commission::getCommissionAmount()
{
   if(!this->commissionAmountIsNull_){
        if(commissionAmountIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(commissionAmountIDRef_));
        }else{
             return this->commissionAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<Currency> Commission::getCurrency()
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
boost::shared_ptr<XsdTypeDecimal> Commission::getCommissionPerTrade()
{
   if(!this->commissionPerTradeIsNull_){
        if(commissionPerTradeIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(commissionPerTradeIDRef_));
        }else{
             return this->commissionPerTrade_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
std::vector<boost::shared_ptr<FxRate>> Commission::getFxRate()
{
   if(!this->fxRateIsNull_){
        if(fxRateIDRef_ != ""){
             return this->fxRate_;
        }else{
             return this->fxRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<FxRate>>();
   }
}
}

