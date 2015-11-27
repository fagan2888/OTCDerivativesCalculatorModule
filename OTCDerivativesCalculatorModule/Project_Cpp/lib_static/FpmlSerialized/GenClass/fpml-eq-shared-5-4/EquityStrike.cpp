// EquityStrike.cpp 
#include "EquityStrike.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EquityStrike::EquityStrike(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //strikePriceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* strikePriceNode = xmlNode->FirstChildElement("strikePrice");

   if(strikePriceNode){strikePriceIsNull_ = false;}
   else{strikePriceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- strikePriceNode , address : " << strikePriceNode << std::endl;
   #endif
   if(strikePriceNode)
   {
      if(strikePriceNode->Attribute("href") || strikePriceNode->Attribute("id"))
      {
          if(strikePriceNode->Attribute("id"))
          {
             strikePriceIDRef_ = strikePriceNode->Attribute("id");
             strikePrice_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(strikePriceNode));
             strikePrice_->setID(strikePriceIDRef_);
             IDManager::instance().setID(strikePriceIDRef_,strikePrice_);
          }
          else if(strikePriceNode->Attribute("href")) { strikePriceIDRef_ = strikePriceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { strikePrice_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(strikePriceNode));}
   }

   //strikePercentageNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* strikePercentageNode = xmlNode->FirstChildElement("strikePercentage");

   if(strikePercentageNode){strikePercentageIsNull_ = false;}
   else{strikePercentageIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- strikePercentageNode , address : " << strikePercentageNode << std::endl;
   #endif
   if(strikePercentageNode)
   {
      if(strikePercentageNode->Attribute("href") || strikePercentageNode->Attribute("id"))
      {
          if(strikePercentageNode->Attribute("id"))
          {
             strikePercentageIDRef_ = strikePercentageNode->Attribute("id");
             strikePercentage_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(strikePercentageNode));
             strikePercentage_->setID(strikePercentageIDRef_);
             IDManager::instance().setID(strikePercentageIDRef_,strikePercentage_);
          }
          else if(strikePercentageNode->Attribute("href")) { strikePercentageIDRef_ = strikePercentageNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { strikePercentage_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(strikePercentageNode));}
   }

   //strikeDeterminationDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* strikeDeterminationDateNode = xmlNode->FirstChildElement("strikeDeterminationDate");

   if(strikeDeterminationDateNode){strikeDeterminationDateIsNull_ = false;}
   else{strikeDeterminationDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- strikeDeterminationDateNode , address : " << strikeDeterminationDateNode << std::endl;
   #endif
   if(strikeDeterminationDateNode)
   {
      if(strikeDeterminationDateNode->Attribute("href") || strikeDeterminationDateNode->Attribute("id"))
      {
          if(strikeDeterminationDateNode->Attribute("id"))
          {
             strikeDeterminationDateIDRef_ = strikeDeterminationDateNode->Attribute("id");
             strikeDeterminationDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(strikeDeterminationDateNode));
             strikeDeterminationDate_->setID(strikeDeterminationDateIDRef_);
             IDManager::instance().setID(strikeDeterminationDateIDRef_,strikeDeterminationDate_);
          }
          else if(strikeDeterminationDateNode->Attribute("href")) { strikeDeterminationDateIDRef_ = strikeDeterminationDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { strikeDeterminationDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(strikeDeterminationDateNode));}
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

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDecimal> EquityStrike::getStrikePrice()
{
   if(!this->strikePriceIsNull_){
        if(strikePriceIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(strikePriceIDRef_));
        }else{
             return this->strikePrice_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDecimal> EquityStrike::getStrikePercentage()
{
   if(!this->strikePercentageIsNull_){
        if(strikePercentageIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(strikePercentageIDRef_));
        }else{
             return this->strikePercentage_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<AdjustableOrRelativeDate> EquityStrike::getStrikeDeterminationDate()
{
   if(!this->strikeDeterminationDateIsNull_){
        if(strikeDeterminationDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableOrRelativeDate>(IDManager::instance().getID(strikeDeterminationDateIDRef_));
        }else{
             return this->strikeDeterminationDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableOrRelativeDate>();
   }
}
boost::shared_ptr<Currency> EquityStrike::getCurrency()
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
}

