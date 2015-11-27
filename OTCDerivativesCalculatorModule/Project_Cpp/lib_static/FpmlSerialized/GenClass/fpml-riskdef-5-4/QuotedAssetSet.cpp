// QuotedAssetSet.cpp 
#include "QuotedAssetSet.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

QuotedAssetSet::QuotedAssetSet(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //instrumentSetNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* instrumentSetNode = xmlNode->FirstChildElement("instrumentSet");

   if(instrumentSetNode){instrumentSetIsNull_ = false;}
   else{instrumentSetIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- instrumentSetNode , address : " << instrumentSetNode << std::endl;
   #endif
   if(instrumentSetNode)
   {
      if(instrumentSetNode->Attribute("href") || instrumentSetNode->Attribute("id"))
      {
          if(instrumentSetNode->Attribute("id"))
          {
             instrumentSetIDRef_ = instrumentSetNode->Attribute("id");
             instrumentSet_ = boost::shared_ptr<InstrumentSet>(new InstrumentSet(instrumentSetNode));
             instrumentSet_->setID(instrumentSetIDRef_);
             IDManager::instance().setID(instrumentSetIDRef_,instrumentSet_);
          }
          else if(instrumentSetNode->Attribute("href")) { instrumentSetIDRef_ = instrumentSetNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { instrumentSet_ = boost::shared_ptr<InstrumentSet>(new InstrumentSet(instrumentSetNode));}
   }

   //assetQuoteNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* assetQuoteNode = xmlNode->FirstChildElement("assetQuote");

   if(assetQuoteNode){assetQuoteIsNull_ = false;}
   else{assetQuoteIsNull_ = true;}

   if(assetQuoteNode)
   {
      for(assetQuoteNode; assetQuoteNode; assetQuoteNode = assetQuoteNode->NextSiblingElement("assetQuote")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- assetQuoteNode , address : " << assetQuoteNode << std::endl;
          #endif
          if(assetQuoteNode->Attribute("href") || assetQuoteNode->Attribute("id"))
          {
              if(assetQuoteNode->Attribute("id"))
              {
                  assetQuoteIDRef_ = assetQuoteNode->Attribute("id");
                  assetQuote_.push_back(boost::shared_ptr<BasicAssetValuation>(new BasicAssetValuation(assetQuoteNode)));
                  assetQuote_.back()->setID(assetQuoteIDRef_);
                  IDManager::instance().setID(assetQuoteIDRef_, assetQuote_.back());
              }
              else if(assetQuoteNode->Attribute("href")) { assetQuoteIDRef_ = assetQuoteNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { assetQuote_.push_back(boost::shared_ptr<BasicAssetValuation>(new BasicAssetValuation(assetQuoteNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- assetQuoteNode , address : " << assetQuoteNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<InstrumentSet> QuotedAssetSet::getInstrumentSet()
{
   if(!this->instrumentSetIsNull_){
        if(instrumentSetIDRef_ != ""){
             return boost::shared_static_cast<InstrumentSet>(IDManager::instance().getID(instrumentSetIDRef_));
        }else{
             return this->instrumentSet_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<InstrumentSet>();
   }
}
std::vector<boost::shared_ptr<BasicAssetValuation>> QuotedAssetSet::getAssetQuote()
{
   if(!this->assetQuoteIsNull_){
        if(assetQuoteIDRef_ != ""){
             return this->assetQuote_;
        }else{
             return this->assetQuote_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<BasicAssetValuation>>();
   }
}
}

