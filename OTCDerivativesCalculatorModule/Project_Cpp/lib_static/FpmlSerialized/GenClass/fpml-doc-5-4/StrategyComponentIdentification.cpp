// StrategyComponentIdentification.cpp 
#include "StrategyComponentIdentification.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

StrategyComponentIdentification::StrategyComponentIdentification(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //tradeIdentifierReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tradeIdentifierReferenceNode = xmlNode->FirstChildElement("tradeIdentifierReference");

   if(tradeIdentifierReferenceNode){tradeIdentifierReferenceIsNull_ = false;}
   else{tradeIdentifierReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tradeIdentifierReferenceNode , address : " << tradeIdentifierReferenceNode << std::endl;
   #endif
   if(tradeIdentifierReferenceNode)
   {
      if(tradeIdentifierReferenceNode->Attribute("href") || tradeIdentifierReferenceNode->Attribute("id"))
      {
          if(tradeIdentifierReferenceNode->Attribute("id"))
          {
             tradeIdentifierReferenceIDRef_ = tradeIdentifierReferenceNode->Attribute("id");
             tradeIdentifierReference_ = boost::shared_ptr<PartyTradeIdentifierReference>(new PartyTradeIdentifierReference(tradeIdentifierReferenceNode));
             tradeIdentifierReference_->setID(tradeIdentifierReferenceIDRef_);
             IDManager::instance().setID(tradeIdentifierReferenceIDRef_,tradeIdentifierReference_);
          }
          else if(tradeIdentifierReferenceNode->Attribute("href")) { tradeIdentifierReferenceIDRef_ = tradeIdentifierReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { tradeIdentifierReference_ = boost::shared_ptr<PartyTradeIdentifierReference>(new PartyTradeIdentifierReference(tradeIdentifierReferenceNode));}
   }

   //componentReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* componentReferenceNode = xmlNode->FirstChildElement("componentReference");

   if(componentReferenceNode){componentReferenceIsNull_ = false;}
   else{componentReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- componentReferenceNode , address : " << componentReferenceNode << std::endl;
   #endif
   if(componentReferenceNode)
   {
      if(componentReferenceNode->Attribute("href") || componentReferenceNode->Attribute("id"))
      {
          if(componentReferenceNode->Attribute("id"))
          {
             componentReferenceIDRef_ = componentReferenceNode->Attribute("id");
             componentReference_ = boost::shared_ptr<ProductReference>(new ProductReference(componentReferenceNode));
             componentReference_->setID(componentReferenceIDRef_);
             IDManager::instance().setID(componentReferenceIDRef_,componentReference_);
          }
          else if(componentReferenceNode->Attribute("href")) { componentReferenceIDRef_ = componentReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { componentReference_ = boost::shared_ptr<ProductReference>(new ProductReference(componentReferenceNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PartyTradeIdentifierReference> StrategyComponentIdentification::getTradeIdentifierReference()
{
   if(!this->tradeIdentifierReferenceIsNull_){
        if(tradeIdentifierReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyTradeIdentifierReference>(IDManager::instance().getID(tradeIdentifierReferenceIDRef_));
        }else{
             return this->tradeIdentifierReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyTradeIdentifierReference>();
   }
}
boost::shared_ptr<ProductReference> StrategyComponentIdentification::getComponentReference()
{
   if(!this->componentReferenceIsNull_){
        if(componentReferenceIDRef_ != ""){
             return boost::shared_static_cast<ProductReference>(IDManager::instance().getID(componentReferenceIDRef_));
        }else{
             return this->componentReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ProductReference>();
   }
}
}

