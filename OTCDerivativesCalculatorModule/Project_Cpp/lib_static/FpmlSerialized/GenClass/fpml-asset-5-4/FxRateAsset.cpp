// FxRateAsset.cpp 
#include "FxRateAsset.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FxRateAsset::FxRateAsset(TiXmlNode* xmlNode)
: UnderlyingAsset(xmlNode)
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

   //rateSourceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* rateSourceNode = xmlNode->FirstChildElement("rateSource");

   if(rateSourceNode){rateSourceIsNull_ = false;}
   else{rateSourceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rateSourceNode , address : " << rateSourceNode << std::endl;
   #endif
   if(rateSourceNode)
   {
      if(rateSourceNode->Attribute("href") || rateSourceNode->Attribute("id"))
      {
          if(rateSourceNode->Attribute("id"))
          {
             rateSourceIDRef_ = rateSourceNode->Attribute("id");
             rateSource_ = boost::shared_ptr<FxSpotRateSource>(new FxSpotRateSource(rateSourceNode));
             rateSource_->setID(rateSourceIDRef_);
             IDManager::instance().setID(rateSourceIDRef_,rateSource_);
          }
          else if(rateSourceNode->Attribute("href")) { rateSourceIDRef_ = rateSourceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { rateSource_ = boost::shared_ptr<FxSpotRateSource>(new FxSpotRateSource(rateSourceNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<QuotedCurrencyPair> FxRateAsset::getQuotedCurrencyPair()
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
boost::shared_ptr<FxSpotRateSource> FxRateAsset::getRateSource()
{
   if(!this->rateSourceIsNull_){
        if(rateSourceIDRef_ != ""){
             return boost::shared_static_cast<FxSpotRateSource>(IDManager::instance().getID(rateSourceIDRef_));
        }else{
             return this->rateSource_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FxSpotRateSource>();
   }
}
}

