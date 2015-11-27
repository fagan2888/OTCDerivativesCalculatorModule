// UnderlyingIndex.cpp 
#include "UnderlyingIndex.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

UnderlyingIndex::UnderlyingIndex(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //stockIndexNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* stockIndexNode = xmlNode->FirstChildElement("stockIndex");

   if(stockIndexNode){stockIndexIsNull_ = false;}
   else{stockIndexIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- stockIndexNode , address : " << stockIndexNode << std::endl;
   #endif
   if(stockIndexNode)
   {
      if(stockIndexNode->Attribute("href") || stockIndexNode->Attribute("id"))
      {
          if(stockIndexNode->Attribute("id"))
          {
             stockIndexIDRef_ = stockIndexNode->Attribute("id");
             stockIndex_ = boost::shared_ptr<StockIndex>(new StockIndex(stockIndexNode));
             stockIndex_->setID(stockIndexIDRef_);
             IDManager::instance().setID(stockIndexIDRef_,stockIndex_);
          }
          else if(stockIndexNode->Attribute("href")) { stockIndexIDRef_ = stockIndexNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { stockIndex_ = boost::shared_ptr<StockIndex>(new StockIndex(stockIndexNode));}
   }

   //interestrateIndexNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* interestrateIndexNode = xmlNode->FirstChildElement("interestrateIndex");

   if(interestrateIndexNode){interestrateIndexIsNull_ = false;}
   else{interestrateIndexIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- interestrateIndexNode , address : " << interestrateIndexNode << std::endl;
   #endif
   if(interestrateIndexNode)
   {
      if(interestrateIndexNode->Attribute("href") || interestrateIndexNode->Attribute("id"))
      {
          if(interestrateIndexNode->Attribute("id"))
          {
             interestrateIndexIDRef_ = interestrateIndexNode->Attribute("id");
             interestrateIndex_ = boost::shared_ptr<InterestrateIndex>(new InterestrateIndex(interestrateIndexNode));
             interestrateIndex_->setID(interestrateIndexIDRef_);
             IDManager::instance().setID(interestrateIndexIDRef_,interestrateIndex_);
          }
          else if(interestrateIndexNode->Attribute("href")) { interestrateIndexIDRef_ = interestrateIndexNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { interestrateIndex_ = boost::shared_ptr<InterestrateIndex>(new InterestrateIndex(interestrateIndexNode));}
   }

   //commodityIndexNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* commodityIndexNode = xmlNode->FirstChildElement("commodityIndex");

   if(commodityIndexNode){commodityIndexIsNull_ = false;}
   else{commodityIndexIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- commodityIndexNode , address : " << commodityIndexNode << std::endl;
   #endif
   if(commodityIndexNode)
   {
      if(commodityIndexNode->Attribute("href") || commodityIndexNode->Attribute("id"))
      {
          if(commodityIndexNode->Attribute("id"))
          {
             commodityIndexIDRef_ = commodityIndexNode->Attribute("id");
             commodityIndex_ = boost::shared_ptr<CommodityIndex>(new CommodityIndex(commodityIndexNode));
             commodityIndex_->setID(commodityIndexIDRef_);
             IDManager::instance().setID(commodityIndexIDRef_,commodityIndex_);
          }
          else if(commodityIndexNode->Attribute("href")) { commodityIndexIDRef_ = commodityIndexNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { commodityIndex_ = boost::shared_ptr<CommodityIndex>(new CommodityIndex(commodityIndexNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<StockIndex> UnderlyingIndex::getStockIndex()
{
   if(!this->stockIndexIsNull_){
        if(stockIndexIDRef_ != ""){
             return boost::shared_static_cast<StockIndex>(IDManager::instance().getID(stockIndexIDRef_));
        }else{
             return this->stockIndex_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<StockIndex>();
   }
}
boost::shared_ptr<InterestrateIndex> UnderlyingIndex::getInterestrateIndex()
{
   if(!this->interestrateIndexIsNull_){
        if(interestrateIndexIDRef_ != ""){
             return boost::shared_static_cast<InterestrateIndex>(IDManager::instance().getID(interestrateIndexIDRef_));
        }else{
             return this->interestrateIndex_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<InterestrateIndex>();
   }
}
boost::shared_ptr<CommodityIndex> UnderlyingIndex::getCommodityIndex()
{
   if(!this->commodityIndexIsNull_){
        if(commodityIndexIDRef_ != ""){
             return boost::shared_static_cast<CommodityIndex>(IDManager::instance().getID(commodityIndexIDRef_));
        }else{
             return this->commodityIndex_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityIndex>();
   }
}
}

