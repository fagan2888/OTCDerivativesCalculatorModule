// EventIdentifier.cpp 
#include "EventIdentifier.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EventIdentifier::EventIdentifier(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //correlationIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* correlationIdNode = xmlNode->FirstChildElement("correlationId");

   if(correlationIdNode){correlationIdIsNull_ = false;}
   else{correlationIdIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- correlationIdNode , address : " << correlationIdNode << std::endl;
   #endif
   if(correlationIdNode)
   {
      if(correlationIdNode->Attribute("href") || correlationIdNode->Attribute("id"))
      {
          if(correlationIdNode->Attribute("id"))
          {
             correlationIdIDRef_ = correlationIdNode->Attribute("id");
             correlationId_ = boost::shared_ptr<CorrelationId>(new CorrelationId(correlationIdNode));
             correlationId_->setID(correlationIdIDRef_);
             IDManager::instance().setID(correlationIdIDRef_,correlationId_);
          }
          else if(correlationIdNode->Attribute("href")) { correlationIdIDRef_ = correlationIdNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { correlationId_ = boost::shared_ptr<CorrelationId>(new CorrelationId(correlationIdNode));}
   }

   //sequenceNumberNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sequenceNumberNode = xmlNode->FirstChildElement("sequenceNumber");

   if(sequenceNumberNode){sequenceNumberIsNull_ = false;}
   else{sequenceNumberIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sequenceNumberNode , address : " << sequenceNumberNode << std::endl;
   #endif
   if(sequenceNumberNode)
   {
      if(sequenceNumberNode->Attribute("href") || sequenceNumberNode->Attribute("id"))
      {
          if(sequenceNumberNode->Attribute("id"))
          {
             sequenceNumberIDRef_ = sequenceNumberNode->Attribute("id");
             sequenceNumber_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(sequenceNumberNode));
             sequenceNumber_->setID(sequenceNumberIDRef_);
             IDManager::instance().setID(sequenceNumberIDRef_,sequenceNumber_);
          }
          else if(sequenceNumberNode->Attribute("href")) { sequenceNumberIDRef_ = sequenceNumberNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { sequenceNumber_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(sequenceNumberNode));}
   }

   //tradeIdentifierNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tradeIdentifierNode = xmlNode->FirstChildElement("tradeIdentifier");

   if(tradeIdentifierNode){tradeIdentifierIsNull_ = false;}
   else{tradeIdentifierIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tradeIdentifierNode , address : " << tradeIdentifierNode << std::endl;
   #endif
   if(tradeIdentifierNode)
   {
      if(tradeIdentifierNode->Attribute("href") || tradeIdentifierNode->Attribute("id"))
      {
          if(tradeIdentifierNode->Attribute("id"))
          {
             tradeIdentifierIDRef_ = tradeIdentifierNode->Attribute("id");
             tradeIdentifier_ = boost::shared_ptr<TradeIdentifier>(new TradeIdentifier(tradeIdentifierNode));
             tradeIdentifier_->setID(tradeIdentifierIDRef_);
             IDManager::instance().setID(tradeIdentifierIDRef_,tradeIdentifier_);
          }
          else if(tradeIdentifierNode->Attribute("href")) { tradeIdentifierIDRef_ = tradeIdentifierNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { tradeIdentifier_ = boost::shared_ptr<TradeIdentifier>(new TradeIdentifier(tradeIdentifierNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CorrelationId> EventIdentifier::getCorrelationId()
{
   if(!this->correlationIdIsNull_){
        if(correlationIdIDRef_ != ""){
             return boost::shared_static_cast<CorrelationId>(IDManager::instance().getID(correlationIdIDRef_));
        }else{
             return this->correlationId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CorrelationId>();
   }
}
boost::shared_ptr<XsdTypePositiveInteger> EventIdentifier::getSequenceNumber()
{
   if(!this->sequenceNumberIsNull_){
        if(sequenceNumberIDRef_ != ""){
             return boost::shared_static_cast<XsdTypePositiveInteger>(IDManager::instance().getID(sequenceNumberIDRef_));
        }else{
             return this->sequenceNumber_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypePositiveInteger>();
   }
}
boost::shared_ptr<TradeIdentifier> EventIdentifier::getTradeIdentifier()
{
   if(!this->tradeIdentifierIsNull_){
        if(tradeIdentifierIDRef_ != ""){
             return boost::shared_static_cast<TradeIdentifier>(IDManager::instance().getID(tradeIdentifierIDRef_));
        }else{
             return this->tradeIdentifier_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TradeIdentifier>();
   }
}
}

