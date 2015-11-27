// ProductComponentIdentifier.cpp 
#include "ProductComponentIdentifier.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ProductComponentIdentifier::ProductComponentIdentifier(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //premiumProductReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* premiumProductReferenceNode = xmlNode->FirstChildElement("premiumProductReference");

   if(premiumProductReferenceNode){premiumProductReferenceIsNull_ = false;}
   else{premiumProductReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- premiumProductReferenceNode , address : " << premiumProductReferenceNode << std::endl;
   #endif
   if(premiumProductReferenceNode)
   {
      if(premiumProductReferenceNode->Attribute("href") || premiumProductReferenceNode->Attribute("id"))
      {
          if(premiumProductReferenceNode->Attribute("id"))
          {
             premiumProductReferenceIDRef_ = premiumProductReferenceNode->Attribute("id");
             premiumProductReference_ = boost::shared_ptr<ProductReference>(new ProductReference(premiumProductReferenceNode));
             premiumProductReference_->setID(premiumProductReferenceIDRef_);
             IDManager::instance().setID(premiumProductReferenceIDRef_,premiumProductReference_);
          }
          else if(premiumProductReferenceNode->Attribute("href")) { premiumProductReferenceIDRef_ = premiumProductReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { premiumProductReference_ = boost::shared_ptr<ProductReference>(new ProductReference(premiumProductReferenceNode));}
   }

   //issuerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* issuerNode = xmlNode->FirstChildElement("issuer");

   if(issuerNode){issuerIsNull_ = false;}
   else{issuerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- issuerNode , address : " << issuerNode << std::endl;
   #endif
   if(issuerNode)
   {
      if(issuerNode->Attribute("href") || issuerNode->Attribute("id"))
      {
          if(issuerNode->Attribute("id"))
          {
             issuerIDRef_ = issuerNode->Attribute("id");
             issuer_ = boost::shared_ptr<IssuerId>(new IssuerId(issuerNode));
             issuer_->setID(issuerIDRef_);
             IDManager::instance().setID(issuerIDRef_,issuer_);
          }
          else if(issuerNode->Attribute("href")) { issuerIDRef_ = issuerNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { issuer_ = boost::shared_ptr<IssuerId>(new IssuerId(issuerNode));}
   }

   //tradeIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tradeIdNode = xmlNode->FirstChildElement("tradeId");

   if(tradeIdNode){tradeIdIsNull_ = false;}
   else{tradeIdIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tradeIdNode , address : " << tradeIdNode << std::endl;
   #endif
   if(tradeIdNode)
   {
      if(tradeIdNode->Attribute("href") || tradeIdNode->Attribute("id"))
      {
          if(tradeIdNode->Attribute("id"))
          {
             tradeIdIDRef_ = tradeIdNode->Attribute("id");
             tradeId_ = boost::shared_ptr<TradeId>(new TradeId(tradeIdNode));
             tradeId_->setID(tradeIdIDRef_);
             IDManager::instance().setID(tradeIdIDRef_,tradeId_);
          }
          else if(tradeIdNode->Attribute("href")) { tradeIdIDRef_ = tradeIdNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { tradeId_ = boost::shared_ptr<TradeId>(new TradeId(tradeIdNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<ProductReference> ProductComponentIdentifier::getPremiumProductReference()
{
   if(!this->premiumProductReferenceIsNull_){
        if(premiumProductReferenceIDRef_ != ""){
             return boost::shared_static_cast<ProductReference>(IDManager::instance().getID(premiumProductReferenceIDRef_));
        }else{
             return this->premiumProductReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ProductReference>();
   }
}
boost::shared_ptr<IssuerId> ProductComponentIdentifier::getIssuer()
{
   if(!this->issuerIsNull_){
        if(issuerIDRef_ != ""){
             return boost::shared_static_cast<IssuerId>(IDManager::instance().getID(issuerIDRef_));
        }else{
             return this->issuer_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IssuerId>();
   }
}
boost::shared_ptr<TradeId> ProductComponentIdentifier::getTradeId()
{
   if(!this->tradeIdIsNull_){
        if(tradeIdIDRef_ != ""){
             return boost::shared_static_cast<TradeId>(IDManager::instance().getID(tradeIdIDRef_));
        }else{
             return this->tradeId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TradeId>();
   }
}
}

