// ValuationDocument.cpp 
#include "ValuationDocument.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ValuationDocument::ValuationDocument(TiXmlNode* xmlNode)
: DataDocument(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //marketNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* marketNode = xmlNode->FirstChildElement("market");

   if(marketNode){marketIsNull_ = false;}
   else{marketIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- marketNode , address : " << marketNode << std::endl;
   #endif
   if(marketNode)
   {
      if(marketNode->Attribute("href") || marketNode->Attribute("id"))
      {
          if(marketNode->Attribute("id"))
          {
             marketIDRef_ = marketNode->Attribute("id");
             market_ = boost::shared_ptr<Market>(new Market(marketNode));
             market_->setID(marketIDRef_);
             IDManager::instance().setID(marketIDRef_,market_);
          }
          else if(marketNode->Attribute("href")) { marketIDRef_ = marketNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { market_ = boost::shared_ptr<Market>(new Market(marketNode));}
   }

   //valuationSetNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* valuationSetNode = xmlNode->FirstChildElement("valuationSet");

   if(valuationSetNode){valuationSetIsNull_ = false;}
   else{valuationSetIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valuationSetNode , address : " << valuationSetNode << std::endl;
   #endif
   if(valuationSetNode)
   {
      if(valuationSetNode->Attribute("href") || valuationSetNode->Attribute("id"))
      {
          if(valuationSetNode->Attribute("id"))
          {
             valuationSetIDRef_ = valuationSetNode->Attribute("id");
             valuationSet_ = boost::shared_ptr<ValuationSet>(new ValuationSet(valuationSetNode));
             valuationSet_->setID(valuationSetIDRef_);
             IDManager::instance().setID(valuationSetIDRef_,valuationSet_);
          }
          else if(valuationSetNode->Attribute("href")) { valuationSetIDRef_ = valuationSetNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { valuationSet_ = boost::shared_ptr<ValuationSet>(new ValuationSet(valuationSetNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Market> ValuationDocument::getMarket()
{
   if(!this->marketIsNull_){
        if(marketIDRef_ != ""){
             return boost::shared_static_cast<Market>(IDManager::instance().getID(marketIDRef_));
        }else{
             return this->market_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Market>();
   }
}
boost::shared_ptr<ValuationSet> ValuationDocument::getValuationSet()
{
   if(!this->valuationSetIsNull_){
        if(valuationSetIDRef_ != ""){
             return boost::shared_static_cast<ValuationSet>(IDManager::instance().getID(valuationSetIDRef_));
        }else{
             return this->valuationSet_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ValuationSet>();
   }
}
}

