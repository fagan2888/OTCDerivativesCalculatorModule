// TradeReferenceInformation.cpp 
#include "TradeReferenceInformation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

TradeReferenceInformation::TradeReferenceInformation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //originatingEventNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* originatingEventNode = xmlNode->FirstChildElement("originatingEvent");

   if(originatingEventNode){originatingEventIsNull_ = false;}
   else{originatingEventIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- originatingEventNode , address : " << originatingEventNode << std::endl;
   #endif
   if(originatingEventNode)
   {
      if(originatingEventNode->Attribute("href") || originatingEventNode->Attribute("id"))
      {
          if(originatingEventNode->Attribute("id"))
          {
             originatingEventIDRef_ = originatingEventNode->Attribute("id");
             originatingEvent_ = boost::shared_ptr<OriginatingEvent>(new OriginatingEvent(originatingEventNode));
             originatingEvent_->setID(originatingEventIDRef_);
             IDManager::instance().setID(originatingEventIDRef_,originatingEvent_);
          }
          else if(originatingEventNode->Attribute("href")) { originatingEventIDRef_ = originatingEventNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { originatingEvent_ = boost::shared_ptr<OriginatingEvent>(new OriginatingEvent(originatingEventNode));}
   }

   //terminatingEventNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* terminatingEventNode = xmlNode->FirstChildElement("terminatingEvent");

   if(terminatingEventNode){terminatingEventIsNull_ = false;}
   else{terminatingEventIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- terminatingEventNode , address : " << terminatingEventNode << std::endl;
   #endif
   if(terminatingEventNode)
   {
      if(terminatingEventNode->Attribute("href") || terminatingEventNode->Attribute("id"))
      {
          if(terminatingEventNode->Attribute("id"))
          {
             terminatingEventIDRef_ = terminatingEventNode->Attribute("id");
             terminatingEvent_ = boost::shared_ptr<TerminatingEvent>(new TerminatingEvent(terminatingEventNode));
             terminatingEvent_->setID(terminatingEventIDRef_);
             IDManager::instance().setID(terminatingEventIDRef_,terminatingEvent_);
          }
          else if(terminatingEventNode->Attribute("href")) { terminatingEventIDRef_ = terminatingEventNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { terminatingEvent_ = boost::shared_ptr<TerminatingEvent>(new TerminatingEvent(terminatingEventNode));}
   }

   //partyTradeIdentifierNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* partyTradeIdentifierNode = xmlNode->FirstChildElement("partyTradeIdentifier");

   if(partyTradeIdentifierNode){partyTradeIdentifierIsNull_ = false;}
   else{partyTradeIdentifierIsNull_ = true;}

   if(partyTradeIdentifierNode)
   {
      for(partyTradeIdentifierNode; partyTradeIdentifierNode; partyTradeIdentifierNode = partyTradeIdentifierNode->NextSiblingElement("partyTradeIdentifier")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partyTradeIdentifierNode , address : " << partyTradeIdentifierNode << std::endl;
          #endif
          if(partyTradeIdentifierNode->Attribute("href") || partyTradeIdentifierNode->Attribute("id"))
          {
              if(partyTradeIdentifierNode->Attribute("id"))
              {
                  partyTradeIdentifierIDRef_ = partyTradeIdentifierNode->Attribute("id");
                  partyTradeIdentifier_.push_back(boost::shared_ptr<PartyTradeIdentifier>(new PartyTradeIdentifier(partyTradeIdentifierNode)));
                  partyTradeIdentifier_.back()->setID(partyTradeIdentifierIDRef_);
                  IDManager::instance().setID(partyTradeIdentifierIDRef_, partyTradeIdentifier_.back());
              }
              else if(partyTradeIdentifierNode->Attribute("href")) { partyTradeIdentifierIDRef_ = partyTradeIdentifierNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { partyTradeIdentifier_.push_back(boost::shared_ptr<PartyTradeIdentifier>(new PartyTradeIdentifier(partyTradeIdentifierNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partyTradeIdentifierNode , address : " << partyTradeIdentifierNode << std::endl;
       #endif
   }

   //partyTradeInformationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* partyTradeInformationNode = xmlNode->FirstChildElement("partyTradeInformation");

   if(partyTradeInformationNode){partyTradeInformationIsNull_ = false;}
   else{partyTradeInformationIsNull_ = true;}

   if(partyTradeInformationNode)
   {
      for(partyTradeInformationNode; partyTradeInformationNode; partyTradeInformationNode = partyTradeInformationNode->NextSiblingElement("partyTradeInformation")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partyTradeInformationNode , address : " << partyTradeInformationNode << std::endl;
          #endif
          if(partyTradeInformationNode->Attribute("href") || partyTradeInformationNode->Attribute("id"))
          {
              if(partyTradeInformationNode->Attribute("id"))
              {
                  partyTradeInformationIDRef_ = partyTradeInformationNode->Attribute("id");
                  partyTradeInformation_.push_back(boost::shared_ptr<PartyTradeInformation>(new PartyTradeInformation(partyTradeInformationNode)));
                  partyTradeInformation_.back()->setID(partyTradeInformationIDRef_);
                  IDManager::instance().setID(partyTradeInformationIDRef_, partyTradeInformation_.back());
              }
              else if(partyTradeInformationNode->Attribute("href")) { partyTradeInformationIDRef_ = partyTradeInformationNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { partyTradeInformation_.push_back(boost::shared_ptr<PartyTradeInformation>(new PartyTradeInformation(partyTradeInformationNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partyTradeInformationNode , address : " << partyTradeInformationNode << std::endl;
       #endif
   }

   //productTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* productTypeNode = xmlNode->FirstChildElement("productType");

   if(productTypeNode){productTypeIsNull_ = false;}
   else{productTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- productTypeNode , address : " << productTypeNode << std::endl;
   #endif
   if(productTypeNode)
   {
      if(productTypeNode->Attribute("href") || productTypeNode->Attribute("id"))
      {
          if(productTypeNode->Attribute("id"))
          {
             productTypeIDRef_ = productTypeNode->Attribute("id");
             productType_ = boost::shared_ptr<ProductType>(new ProductType(productTypeNode));
             productType_->setID(productTypeIDRef_);
             IDManager::instance().setID(productTypeIDRef_,productType_);
          }
          else if(productTypeNode->Attribute("href")) { productTypeIDRef_ = productTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { productType_ = boost::shared_ptr<ProductType>(new ProductType(productTypeNode));}
   }

   //productIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* productIdNode = xmlNode->FirstChildElement("productId");

   if(productIdNode){productIdIsNull_ = false;}
   else{productIdIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- productIdNode , address : " << productIdNode << std::endl;
   #endif
   if(productIdNode)
   {
      if(productIdNode->Attribute("href") || productIdNode->Attribute("id"))
      {
          if(productIdNode->Attribute("id"))
          {
             productIdIDRef_ = productIdNode->Attribute("id");
             productId_ = boost::shared_ptr<ProductId>(new ProductId(productIdNode));
             productId_->setID(productIdIDRef_);
             IDManager::instance().setID(productIdIDRef_,productId_);
          }
          else if(productIdNode->Attribute("href")) { productIdIDRef_ = productIdNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { productId_ = boost::shared_ptr<ProductId>(new ProductId(productIdNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<OriginatingEvent> TradeReferenceInformation::getOriginatingEvent()
{
   if(!this->originatingEventIsNull_){
        if(originatingEventIDRef_ != ""){
             return boost::shared_static_cast<OriginatingEvent>(IDManager::instance().getID(originatingEventIDRef_));
        }else{
             return this->originatingEvent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<OriginatingEvent>();
   }
}
boost::shared_ptr<TerminatingEvent> TradeReferenceInformation::getTerminatingEvent()
{
   if(!this->terminatingEventIsNull_){
        if(terminatingEventIDRef_ != ""){
             return boost::shared_static_cast<TerminatingEvent>(IDManager::instance().getID(terminatingEventIDRef_));
        }else{
             return this->terminatingEvent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TerminatingEvent>();
   }
}
std::vector<boost::shared_ptr<PartyTradeIdentifier>> TradeReferenceInformation::getPartyTradeIdentifier()
{
   if(!this->partyTradeIdentifierIsNull_){
        if(partyTradeIdentifierIDRef_ != ""){
             return this->partyTradeIdentifier_;
        }else{
             return this->partyTradeIdentifier_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<PartyTradeIdentifier>>();
   }
}
std::vector<boost::shared_ptr<PartyTradeInformation>> TradeReferenceInformation::getPartyTradeInformation()
{
   if(!this->partyTradeInformationIsNull_){
        if(partyTradeInformationIDRef_ != ""){
             return this->partyTradeInformation_;
        }else{
             return this->partyTradeInformation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<PartyTradeInformation>>();
   }
}
boost::shared_ptr<ProductType> TradeReferenceInformation::getProductType()
{
   if(!this->productTypeIsNull_){
        if(productTypeIDRef_ != ""){
             return boost::shared_static_cast<ProductType>(IDManager::instance().getID(productTypeIDRef_));
        }else{
             return this->productType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ProductType>();
   }
}
boost::shared_ptr<ProductId> TradeReferenceInformation::getProductId()
{
   if(!this->productIdIsNull_){
        if(productIdIDRef_ != ""){
             return boost::shared_static_cast<ProductId>(IDManager::instance().getID(productIdIDRef_));
        }else{
             return this->productId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ProductId>();
   }
}
}

