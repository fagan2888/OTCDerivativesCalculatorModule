// QuotedCurrencyPair.cpp 
#include "QuotedCurrencyPair.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

QuotedCurrencyPair::QuotedCurrencyPair(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //currency1Node ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* currency1Node = xmlNode->FirstChildElement("currency1");

   if(currency1Node){currency1IsNull_ = false;}
   else{currency1IsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- currency1Node , address : " << currency1Node << std::endl;
   #endif
   if(currency1Node)
   {
      if(currency1Node->Attribute("href") || currency1Node->Attribute("id"))
      {
          if(currency1Node->Attribute("id"))
          {
             currency1IDRef_ = currency1Node->Attribute("id");
             currency1_ = boost::shared_ptr<Currency>(new Currency(currency1Node));
             currency1_->setID(currency1IDRef_);
             IDManager::instance().setID(currency1IDRef_,currency1_);
          }
          else if(currency1Node->Attribute("href")) { currency1IDRef_ = currency1Node->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { currency1_ = boost::shared_ptr<Currency>(new Currency(currency1Node));}
   }

   //currency2Node ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* currency2Node = xmlNode->FirstChildElement("currency2");

   if(currency2Node){currency2IsNull_ = false;}
   else{currency2IsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- currency2Node , address : " << currency2Node << std::endl;
   #endif
   if(currency2Node)
   {
      if(currency2Node->Attribute("href") || currency2Node->Attribute("id"))
      {
          if(currency2Node->Attribute("id"))
          {
             currency2IDRef_ = currency2Node->Attribute("id");
             currency2_ = boost::shared_ptr<Currency>(new Currency(currency2Node));
             currency2_->setID(currency2IDRef_);
             IDManager::instance().setID(currency2IDRef_,currency2_);
          }
          else if(currency2Node->Attribute("href")) { currency2IDRef_ = currency2Node->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { currency2_ = boost::shared_ptr<Currency>(new Currency(currency2Node));}
   }

   //quoteBasisNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* quoteBasisNode = xmlNode->FirstChildElement("quoteBasis");

   if(quoteBasisNode){quoteBasisIsNull_ = false;}
   else{quoteBasisIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- quoteBasisNode , address : " << quoteBasisNode << std::endl;
   #endif
   if(quoteBasisNode)
   {
      if(quoteBasisNode->Attribute("href") || quoteBasisNode->Attribute("id"))
      {
          if(quoteBasisNode->Attribute("id"))
          {
             quoteBasisIDRef_ = quoteBasisNode->Attribute("id");
             quoteBasis_ = boost::shared_ptr<QuoteBasisEnum>(new QuoteBasisEnum(quoteBasisNode));
             quoteBasis_->setID(quoteBasisIDRef_);
             IDManager::instance().setID(quoteBasisIDRef_,quoteBasis_);
          }
          else if(quoteBasisNode->Attribute("href")) { quoteBasisIDRef_ = quoteBasisNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { quoteBasis_ = boost::shared_ptr<QuoteBasisEnum>(new QuoteBasisEnum(quoteBasisNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Currency> QuotedCurrencyPair::getCurrency1()
{
   if(!this->currency1IsNull_){
        if(currency1IDRef_ != ""){
             return boost::shared_static_cast<Currency>(IDManager::instance().getID(currency1IDRef_));
        }else{
             return this->currency1_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Currency>();
   }
}
boost::shared_ptr<Currency> QuotedCurrencyPair::getCurrency2()
{
   if(!this->currency2IsNull_){
        if(currency2IDRef_ != ""){
             return boost::shared_static_cast<Currency>(IDManager::instance().getID(currency2IDRef_));
        }else{
             return this->currency2_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Currency>();
   }
}
boost::shared_ptr<QuoteBasisEnum> QuotedCurrencyPair::getQuoteBasis()
{
   if(!this->quoteBasisIsNull_){
        if(quoteBasisIDRef_ != ""){
             return boost::shared_static_cast<QuoteBasisEnum>(IDManager::instance().getID(quoteBasisIDRef_));
        }else{
             return this->quoteBasis_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<QuoteBasisEnum>();
   }
}
}

