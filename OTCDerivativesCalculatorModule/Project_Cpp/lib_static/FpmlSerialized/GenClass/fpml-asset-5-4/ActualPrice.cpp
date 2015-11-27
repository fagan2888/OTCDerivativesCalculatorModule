// ActualPrice.cpp 
#include "ActualPrice.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ActualPrice::ActualPrice(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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

   //amountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* amountNode = xmlNode->FirstChildElement("amount");

   if(amountNode){amountIsNull_ = false;}
   else{amountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- amountNode , address : " << amountNode << std::endl;
   #endif
   if(amountNode)
   {
      if(amountNode->Attribute("href") || amountNode->Attribute("id"))
      {
          if(amountNode->Attribute("id"))
          {
             amountIDRef_ = amountNode->Attribute("id");
             amount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(amountNode));
             amount_->setID(amountIDRef_);
             IDManager::instance().setID(amountIDRef_,amount_);
          }
          else if(amountNode->Attribute("href")) { amountIDRef_ = amountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { amount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(amountNode));}
   }

   //priceExpressionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* priceExpressionNode = xmlNode->FirstChildElement("priceExpression");

   if(priceExpressionNode){priceExpressionIsNull_ = false;}
   else{priceExpressionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- priceExpressionNode , address : " << priceExpressionNode << std::endl;
   #endif
   if(priceExpressionNode)
   {
      if(priceExpressionNode->Attribute("href") || priceExpressionNode->Attribute("id"))
      {
          if(priceExpressionNode->Attribute("id"))
          {
             priceExpressionIDRef_ = priceExpressionNode->Attribute("id");
             priceExpression_ = boost::shared_ptr<PriceExpressionEnum>(new PriceExpressionEnum(priceExpressionNode));
             priceExpression_->setID(priceExpressionIDRef_);
             IDManager::instance().setID(priceExpressionIDRef_,priceExpression_);
          }
          else if(priceExpressionNode->Attribute("href")) { priceExpressionIDRef_ = priceExpressionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { priceExpression_ = boost::shared_ptr<PriceExpressionEnum>(new PriceExpressionEnum(priceExpressionNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Currency> ActualPrice::getCurrency()
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
boost::shared_ptr<XsdTypeDecimal> ActualPrice::getAmount()
{
   if(!this->amountIsNull_){
        if(amountIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(amountIDRef_));
        }else{
             return this->amount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<PriceExpressionEnum> ActualPrice::getPriceExpression()
{
   if(!this->priceExpressionIsNull_){
        if(priceExpressionIDRef_ != ""){
             return boost::shared_static_cast<PriceExpressionEnum>(IDManager::instance().getID(priceExpressionIDRef_));
        }else{
             return this->priceExpression_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PriceExpressionEnum>();
   }
}
}

