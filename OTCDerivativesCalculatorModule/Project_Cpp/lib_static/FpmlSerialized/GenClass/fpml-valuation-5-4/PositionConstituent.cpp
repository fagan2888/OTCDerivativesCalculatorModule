// PositionConstituent.cpp 
#include "PositionConstituent.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PositionConstituent::PositionConstituent(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //tradeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tradeNode = xmlNode->FirstChildElement("trade");

   if(tradeNode){tradeIsNull_ = false;}
   else{tradeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tradeNode , address : " << tradeNode << std::endl;
   #endif
   if(tradeNode)
   {
      if(tradeNode->Attribute("href") || tradeNode->Attribute("id"))
      {
          if(tradeNode->Attribute("id"))
          {
             tradeIDRef_ = tradeNode->Attribute("id");
             trade_ = boost::shared_ptr<Trade>(new Trade(tradeNode));
             trade_->setID(tradeIDRef_);
             IDManager::instance().setID(tradeIDRef_,trade_);
          }
          else if(tradeNode->Attribute("href")) { tradeIDRef_ = tradeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { trade_ = boost::shared_ptr<Trade>(new Trade(tradeNode));}
   }

   //positionVersionReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* positionVersionReferenceNode = xmlNode->FirstChildElement("positionVersionReference");

   if(positionVersionReferenceNode){positionVersionReferenceIsNull_ = false;}
   else{positionVersionReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- positionVersionReferenceNode , address : " << positionVersionReferenceNode << std::endl;
   #endif
   if(positionVersionReferenceNode)
   {
      if(positionVersionReferenceNode->Attribute("href") || positionVersionReferenceNode->Attribute("id"))
      {
          if(positionVersionReferenceNode->Attribute("id"))
          {
             positionVersionReferenceIDRef_ = positionVersionReferenceNode->Attribute("id");
             positionVersionReference_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(positionVersionReferenceNode));
             positionVersionReference_->setID(positionVersionReferenceIDRef_);
             IDManager::instance().setID(positionVersionReferenceIDRef_,positionVersionReference_);
          }
          else if(positionVersionReferenceNode->Attribute("href")) { positionVersionReferenceIDRef_ = positionVersionReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { positionVersionReference_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(positionVersionReferenceNode));}
   }

   //tradeReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tradeReferenceNode = xmlNode->FirstChildElement("tradeReference");

   if(tradeReferenceNode){tradeReferenceIsNull_ = false;}
   else{tradeReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tradeReferenceNode , address : " << tradeReferenceNode << std::endl;
   #endif
   if(tradeReferenceNode)
   {
      if(tradeReferenceNode->Attribute("href") || tradeReferenceNode->Attribute("id"))
      {
          if(tradeReferenceNode->Attribute("id"))
          {
             tradeReferenceIDRef_ = tradeReferenceNode->Attribute("id");
             tradeReference_ = boost::shared_ptr<PartyTradeIdentifiers>(new PartyTradeIdentifiers(tradeReferenceNode));
             tradeReference_->setID(tradeReferenceIDRef_);
             IDManager::instance().setID(tradeReferenceIDRef_,tradeReference_);
          }
          else if(tradeReferenceNode->Attribute("href")) { tradeReferenceIDRef_ = tradeReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { tradeReference_ = boost::shared_ptr<PartyTradeIdentifiers>(new PartyTradeIdentifiers(tradeReferenceNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Trade> PositionConstituent::getTrade()
{
   if(!this->tradeIsNull_){
        if(tradeIDRef_ != ""){
             return boost::shared_static_cast<Trade>(IDManager::instance().getID(tradeIDRef_));
        }else{
             return this->trade_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Trade>();
   }
}
boost::shared_ptr<XsdTypePositiveInteger> PositionConstituent::getPositionVersionReference()
{
   if(!this->positionVersionReferenceIsNull_){
        if(positionVersionReferenceIDRef_ != ""){
             return boost::shared_static_cast<XsdTypePositiveInteger>(IDManager::instance().getID(positionVersionReferenceIDRef_));
        }else{
             return this->positionVersionReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypePositiveInteger>();
   }
}
boost::shared_ptr<PartyTradeIdentifiers> PositionConstituent::getTradeReference()
{
   if(!this->tradeReferenceIsNull_){
        if(tradeReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyTradeIdentifiers>(IDManager::instance().getID(tradeReferenceIDRef_));
        }else{
             return this->tradeReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyTradeIdentifiers>();
   }
}
}

