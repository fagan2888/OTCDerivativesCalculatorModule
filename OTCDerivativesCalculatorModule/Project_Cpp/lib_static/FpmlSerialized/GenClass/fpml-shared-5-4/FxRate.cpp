// FxRate.cpp 
#include "FxRate.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FxRate::FxRate(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //quotedCurrencyPairNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* quotedCurrencyPairNode = xmlNode->FirstChildElement("quotedCurrencyPair");

   if(quotedCurrencyPairNode){quotedCurrencyPairIsNull_ = false;}
   else{quotedCurrencyPairIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- quotedCurrencyPairNode , address : " << quotedCurrencyPairNode << std::endl;
   #endif
   if(quotedCurrencyPairNode)
   {
      if(quotedCurrencyPairNode->Attribute("href") || quotedCurrencyPairNode->Attribute("id"))
      {
          if(quotedCurrencyPairNode->Attribute("id"))
          {
             quotedCurrencyPairIDRef_ = quotedCurrencyPairNode->Attribute("id");
             quotedCurrencyPair_ = boost::shared_ptr<QuotedCurrencyPair>(new QuotedCurrencyPair(quotedCurrencyPairNode));
             quotedCurrencyPair_->setID(quotedCurrencyPairIDRef_);
             IDManager::instance().setID(quotedCurrencyPairIDRef_,quotedCurrencyPair_);
          }
          else if(quotedCurrencyPairNode->Attribute("href")) { quotedCurrencyPairIDRef_ = quotedCurrencyPairNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { quotedCurrencyPair_ = boost::shared_ptr<QuotedCurrencyPair>(new QuotedCurrencyPair(quotedCurrencyPairNode));}
   }

   //rateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* rateNode = xmlNode->FirstChildElement("rate");

   if(rateNode){rateIsNull_ = false;}
   else{rateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rateNode , address : " << rateNode << std::endl;
   #endif
   if(rateNode)
   {
      if(rateNode->Attribute("href") || rateNode->Attribute("id"))
      {
          if(rateNode->Attribute("id"))
          {
             rateIDRef_ = rateNode->Attribute("id");
             rate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(rateNode));
             rate_->setID(rateIDRef_);
             IDManager::instance().setID(rateIDRef_,rate_);
          }
          else if(rateNode->Attribute("href")) { rateIDRef_ = rateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { rate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(rateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<QuotedCurrencyPair> FxRate::getQuotedCurrencyPair()
{
   if(!this->quotedCurrencyPairIsNull_){
        if(quotedCurrencyPairIDRef_ != ""){
             return boost::shared_static_cast<QuotedCurrencyPair>(IDManager::instance().getID(quotedCurrencyPairIDRef_));
        }else{
             return this->quotedCurrencyPair_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<QuotedCurrencyPair>();
   }
}
boost::shared_ptr<XsdTypeDecimal> FxRate::getRate()
{
   if(!this->rateIsNull_){
        if(rateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(rateIDRef_));
        }else{
             return this->rate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
}

