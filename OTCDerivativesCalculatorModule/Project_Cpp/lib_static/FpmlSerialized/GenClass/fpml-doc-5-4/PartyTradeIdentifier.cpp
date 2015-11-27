// PartyTradeIdentifier.cpp 
#include "PartyTradeIdentifier.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PartyTradeIdentifier::PartyTradeIdentifier(TiXmlNode* xmlNode)
: TradeIdentifier(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //linkIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* linkIdNode = xmlNode->FirstChildElement("linkId");

   if(linkIdNode){linkIdIsNull_ = false;}
   else{linkIdIsNull_ = true;}

   if(linkIdNode)
   {
      for(linkIdNode; linkIdNode; linkIdNode = linkIdNode->NextSiblingElement("linkId")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- linkIdNode , address : " << linkIdNode << std::endl;
          #endif
          if(linkIdNode->Attribute("href") || linkIdNode->Attribute("id"))
          {
              if(linkIdNode->Attribute("id"))
              {
                  linkIdIDRef_ = linkIdNode->Attribute("id");
                  linkId_.push_back(boost::shared_ptr<LinkId>(new LinkId(linkIdNode)));
                  linkId_.back()->setID(linkIdIDRef_);
                  IDManager::instance().setID(linkIdIDRef_, linkId_.back());
              }
              else if(linkIdNode->Attribute("href")) { linkIdIDRef_ = linkIdNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { linkId_.push_back(boost::shared_ptr<LinkId>(new LinkId(linkIdNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- linkIdNode , address : " << linkIdNode << std::endl;
       #endif
   }

   //allocationTradeIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* allocationTradeIdNode = xmlNode->FirstChildElement("allocationTradeId");

   if(allocationTradeIdNode){allocationTradeIdIsNull_ = false;}
   else{allocationTradeIdIsNull_ = true;}

   if(allocationTradeIdNode)
   {
      for(allocationTradeIdNode; allocationTradeIdNode; allocationTradeIdNode = allocationTradeIdNode->NextSiblingElement("allocationTradeId")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- allocationTradeIdNode , address : " << allocationTradeIdNode << std::endl;
          #endif
          if(allocationTradeIdNode->Attribute("href") || allocationTradeIdNode->Attribute("id"))
          {
              if(allocationTradeIdNode->Attribute("id"))
              {
                  allocationTradeIdIDRef_ = allocationTradeIdNode->Attribute("id");
                  allocationTradeId_.push_back(boost::shared_ptr<TradeIdentifier>(new TradeIdentifier(allocationTradeIdNode)));
                  allocationTradeId_.back()->setID(allocationTradeIdIDRef_);
                  IDManager::instance().setID(allocationTradeIdIDRef_, allocationTradeId_.back());
              }
              else if(allocationTradeIdNode->Attribute("href")) { allocationTradeIdIDRef_ = allocationTradeIdNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { allocationTradeId_.push_back(boost::shared_ptr<TradeIdentifier>(new TradeIdentifier(allocationTradeIdNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- allocationTradeIdNode , address : " << allocationTradeIdNode << std::endl;
       #endif
   }

   //blockTradeIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* blockTradeIdNode = xmlNode->FirstChildElement("blockTradeId");

   if(blockTradeIdNode){blockTradeIdIsNull_ = false;}
   else{blockTradeIdIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- blockTradeIdNode , address : " << blockTradeIdNode << std::endl;
   #endif
   if(blockTradeIdNode)
   {
      if(blockTradeIdNode->Attribute("href") || blockTradeIdNode->Attribute("id"))
      {
          if(blockTradeIdNode->Attribute("id"))
          {
             blockTradeIdIDRef_ = blockTradeIdNode->Attribute("id");
             blockTradeId_ = boost::shared_ptr<TradeIdentifier>(new TradeIdentifier(blockTradeIdNode));
             blockTradeId_->setID(blockTradeIdIDRef_);
             IDManager::instance().setID(blockTradeIdIDRef_,blockTradeId_);
          }
          else if(blockTradeIdNode->Attribute("href")) { blockTradeIdIDRef_ = blockTradeIdNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { blockTradeId_ = boost::shared_ptr<TradeIdentifier>(new TradeIdentifier(blockTradeIdNode));}
   }

   //originatingTradeIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* originatingTradeIdNode = xmlNode->FirstChildElement("originatingTradeId");

   if(originatingTradeIdNode){originatingTradeIdIsNull_ = false;}
   else{originatingTradeIdIsNull_ = true;}

   if(originatingTradeIdNode)
   {
      for(originatingTradeIdNode; originatingTradeIdNode; originatingTradeIdNode = originatingTradeIdNode->NextSiblingElement("originatingTradeId")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- originatingTradeIdNode , address : " << originatingTradeIdNode << std::endl;
          #endif
          if(originatingTradeIdNode->Attribute("href") || originatingTradeIdNode->Attribute("id"))
          {
              if(originatingTradeIdNode->Attribute("id"))
              {
                  originatingTradeIdIDRef_ = originatingTradeIdNode->Attribute("id");
                  originatingTradeId_.push_back(boost::shared_ptr<TradeIdentifier>(new TradeIdentifier(originatingTradeIdNode)));
                  originatingTradeId_.back()->setID(originatingTradeIdIDRef_);
                  IDManager::instance().setID(originatingTradeIdIDRef_, originatingTradeId_.back());
              }
              else if(originatingTradeIdNode->Attribute("href")) { originatingTradeIdIDRef_ = originatingTradeIdNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { originatingTradeId_.push_back(boost::shared_ptr<TradeIdentifier>(new TradeIdentifier(originatingTradeIdNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- originatingTradeIdNode , address : " << originatingTradeIdNode << std::endl;
       #endif
   }

   //productComponentIdentifierNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* productComponentIdentifierNode = xmlNode->FirstChildElement("productComponentIdentifier");

   if(productComponentIdentifierNode){productComponentIdentifierIsNull_ = false;}
   else{productComponentIdentifierIsNull_ = true;}

   if(productComponentIdentifierNode)
   {
      for(productComponentIdentifierNode; productComponentIdentifierNode; productComponentIdentifierNode = productComponentIdentifierNode->NextSiblingElement("productComponentIdentifier")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- productComponentIdentifierNode , address : " << productComponentIdentifierNode << std::endl;
          #endif
          if(productComponentIdentifierNode->Attribute("href") || productComponentIdentifierNode->Attribute("id"))
          {
              if(productComponentIdentifierNode->Attribute("id"))
              {
                  productComponentIdentifierIDRef_ = productComponentIdentifierNode->Attribute("id");
                  productComponentIdentifier_.push_back(boost::shared_ptr<ProductComponentIdentifier>(new ProductComponentIdentifier(productComponentIdentifierNode)));
                  productComponentIdentifier_.back()->setID(productComponentIdentifierIDRef_);
                  IDManager::instance().setID(productComponentIdentifierIDRef_, productComponentIdentifier_.back());
              }
              else if(productComponentIdentifierNode->Attribute("href")) { productComponentIdentifierIDRef_ = productComponentIdentifierNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { productComponentIdentifier_.push_back(boost::shared_ptr<ProductComponentIdentifier>(new ProductComponentIdentifier(productComponentIdentifierNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- productComponentIdentifierNode , address : " << productComponentIdentifierNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<LinkId>> PartyTradeIdentifier::getLinkId()
{
   if(!this->linkIdIsNull_){
        if(linkIdIDRef_ != ""){
             return this->linkId_;
        }else{
             return this->linkId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<LinkId>>();
   }
}
std::vector<boost::shared_ptr<TradeIdentifier>> PartyTradeIdentifier::getAllocationTradeId()
{
   if(!this->allocationTradeIdIsNull_){
        if(allocationTradeIdIDRef_ != ""){
             return this->allocationTradeId_;
        }else{
             return this->allocationTradeId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<TradeIdentifier>>();
   }
}
boost::shared_ptr<TradeIdentifier> PartyTradeIdentifier::getBlockTradeId()
{
   if(!this->blockTradeIdIsNull_){
        if(blockTradeIdIDRef_ != ""){
             return boost::shared_static_cast<TradeIdentifier>(IDManager::instance().getID(blockTradeIdIDRef_));
        }else{
             return this->blockTradeId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TradeIdentifier>();
   }
}
std::vector<boost::shared_ptr<TradeIdentifier>> PartyTradeIdentifier::getOriginatingTradeId()
{
   if(!this->originatingTradeIdIsNull_){
        if(originatingTradeIdIDRef_ != ""){
             return this->originatingTradeId_;
        }else{
             return this->originatingTradeId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<TradeIdentifier>>();
   }
}
std::vector<boost::shared_ptr<ProductComponentIdentifier>> PartyTradeIdentifier::getProductComponentIdentifier()
{
   if(!this->productComponentIdentifierIsNull_){
        if(productComponentIdentifierIDRef_ != ""){
             return this->productComponentIdentifier_;
        }else{
             return this->productComponentIdentifier_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ProductComponentIdentifier>>();
   }
}
}

