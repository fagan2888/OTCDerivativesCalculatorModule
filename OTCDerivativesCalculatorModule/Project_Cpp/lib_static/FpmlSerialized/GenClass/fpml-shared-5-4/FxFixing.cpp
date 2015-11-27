// FxFixing.cpp 
#include "FxFixing.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FxFixing::FxFixing(TiXmlNode* xmlNode)
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

   //fixingDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixingDateNode = xmlNode->FirstChildElement("fixingDate");

   if(fixingDateNode){fixingDateIsNull_ = false;}
   else{fixingDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixingDateNode , address : " << fixingDateNode << std::endl;
   #endif
   if(fixingDateNode)
   {
      if(fixingDateNode->Attribute("href") || fixingDateNode->Attribute("id"))
      {
          if(fixingDateNode->Attribute("id"))
          {
             fixingDateIDRef_ = fixingDateNode->Attribute("id");
             fixingDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(fixingDateNode));
             fixingDate_->setID(fixingDateIDRef_);
             IDManager::instance().setID(fixingDateIDRef_,fixingDate_);
          }
          else if(fixingDateNode->Attribute("href")) { fixingDateIDRef_ = fixingDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fixingDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(fixingDateNode));}
   }

   //fxSpotRateSourceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fxSpotRateSourceNode = xmlNode->FirstChildElement("fxSpotRateSource");

   if(fxSpotRateSourceNode){fxSpotRateSourceIsNull_ = false;}
   else{fxSpotRateSourceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fxSpotRateSourceNode , address : " << fxSpotRateSourceNode << std::endl;
   #endif
   if(fxSpotRateSourceNode)
   {
      if(fxSpotRateSourceNode->Attribute("href") || fxSpotRateSourceNode->Attribute("id"))
      {
          if(fxSpotRateSourceNode->Attribute("id"))
          {
             fxSpotRateSourceIDRef_ = fxSpotRateSourceNode->Attribute("id");
             fxSpotRateSource_ = boost::shared_ptr<FxSpotRateSource>(new FxSpotRateSource(fxSpotRateSourceNode));
             fxSpotRateSource_->setID(fxSpotRateSourceIDRef_);
             IDManager::instance().setID(fxSpotRateSourceIDRef_,fxSpotRateSource_);
          }
          else if(fxSpotRateSourceNode->Attribute("href")) { fxSpotRateSourceIDRef_ = fxSpotRateSourceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fxSpotRateSource_ = boost::shared_ptr<FxSpotRateSource>(new FxSpotRateSource(fxSpotRateSourceNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<QuotedCurrencyPair> FxFixing::getQuotedCurrencyPair()
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
boost::shared_ptr<XsdTypeDate> FxFixing::getFixingDate()
{
   if(!this->fixingDateIsNull_){
        if(fixingDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(fixingDateIDRef_));
        }else{
             return this->fixingDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<FxSpotRateSource> FxFixing::getFxSpotRateSource()
{
   if(!this->fxSpotRateSourceIsNull_){
        if(fxSpotRateSourceIDRef_ != ""){
             return boost::shared_static_cast<FxSpotRateSource>(IDManager::instance().getID(fxSpotRateSourceIDRef_));
        }else{
             return this->fxSpotRateSource_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FxSpotRateSource>();
   }
}
}

