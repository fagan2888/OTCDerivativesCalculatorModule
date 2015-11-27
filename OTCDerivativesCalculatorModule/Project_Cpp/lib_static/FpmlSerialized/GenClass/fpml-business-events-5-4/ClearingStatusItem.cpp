// ClearingStatusItem.cpp 
#include "ClearingStatusItem.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ClearingStatusItem::ClearingStatusItem(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //tradeIdentifierNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tradeIdentifierNode = xmlNode->FirstChildElement("tradeIdentifier");

   if(tradeIdentifierNode){tradeIdentifierIsNull_ = false;}
   else{tradeIdentifierIsNull_ = true;}

   if(tradeIdentifierNode)
   {
      for(tradeIdentifierNode; tradeIdentifierNode; tradeIdentifierNode = tradeIdentifierNode->NextSiblingElement("tradeIdentifier")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tradeIdentifierNode , address : " << tradeIdentifierNode << std::endl;
          #endif
          if(tradeIdentifierNode->Attribute("href") || tradeIdentifierNode->Attribute("id"))
          {
              if(tradeIdentifierNode->Attribute("id"))
              {
                  tradeIdentifierIDRef_ = tradeIdentifierNode->Attribute("id");
                  tradeIdentifier_.push_back(boost::shared_ptr<TradeIdentifier>(new TradeIdentifier(tradeIdentifierNode)));
                  tradeIdentifier_.back()->setID(tradeIdentifierIDRef_);
                  IDManager::instance().setID(tradeIdentifierIDRef_, tradeIdentifier_.back());
              }
              else if(tradeIdentifierNode->Attribute("href")) { tradeIdentifierIDRef_ = tradeIdentifierNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { tradeIdentifier_.push_back(boost::shared_ptr<TradeIdentifier>(new TradeIdentifier(tradeIdentifierNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tradeIdentifierNode , address : " << tradeIdentifierNode << std::endl;
       #endif
   }

   //tradeReferenceInformationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tradeReferenceInformationNode = xmlNode->FirstChildElement("tradeReferenceInformation");

   if(tradeReferenceInformationNode){tradeReferenceInformationIsNull_ = false;}
   else{tradeReferenceInformationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tradeReferenceInformationNode , address : " << tradeReferenceInformationNode << std::endl;
   #endif
   if(tradeReferenceInformationNode)
   {
      if(tradeReferenceInformationNode->Attribute("href") || tradeReferenceInformationNode->Attribute("id"))
      {
          if(tradeReferenceInformationNode->Attribute("id"))
          {
             tradeReferenceInformationIDRef_ = tradeReferenceInformationNode->Attribute("id");
             tradeReferenceInformation_ = boost::shared_ptr<TradeReferenceInformation>(new TradeReferenceInformation(tradeReferenceInformationNode));
             tradeReferenceInformation_->setID(tradeReferenceInformationIDRef_);
             IDManager::instance().setID(tradeReferenceInformationIDRef_,tradeReferenceInformation_);
          }
          else if(tradeReferenceInformationNode->Attribute("href")) { tradeReferenceInformationIDRef_ = tradeReferenceInformationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { tradeReferenceInformation_ = boost::shared_ptr<TradeReferenceInformation>(new TradeReferenceInformation(tradeReferenceInformationNode));}
   }

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

   //clearingStatusValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* clearingStatusValueNode = xmlNode->FirstChildElement("clearingStatusValue");

   if(clearingStatusValueNode){clearingStatusValueIsNull_ = false;}
   else{clearingStatusValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- clearingStatusValueNode , address : " << clearingStatusValueNode << std::endl;
   #endif
   if(clearingStatusValueNode)
   {
      if(clearingStatusValueNode->Attribute("href") || clearingStatusValueNode->Attribute("id"))
      {
          if(clearingStatusValueNode->Attribute("id"))
          {
             clearingStatusValueIDRef_ = clearingStatusValueNode->Attribute("id");
             clearingStatusValue_ = boost::shared_ptr<ClearingStatusValue>(new ClearingStatusValue(clearingStatusValueNode));
             clearingStatusValue_->setID(clearingStatusValueIDRef_);
             IDManager::instance().setID(clearingStatusValueIDRef_,clearingStatusValue_);
          }
          else if(clearingStatusValueNode->Attribute("href")) { clearingStatusValueIDRef_ = clearingStatusValueNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { clearingStatusValue_ = boost::shared_ptr<ClearingStatusValue>(new ClearingStatusValue(clearingStatusValueNode));}
   }

   //updatedDateTimeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* updatedDateTimeNode = xmlNode->FirstChildElement("updatedDateTime");

   if(updatedDateTimeNode){updatedDateTimeIsNull_ = false;}
   else{updatedDateTimeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- updatedDateTimeNode , address : " << updatedDateTimeNode << std::endl;
   #endif
   if(updatedDateTimeNode)
   {
      if(updatedDateTimeNode->Attribute("href") || updatedDateTimeNode->Attribute("id"))
      {
          if(updatedDateTimeNode->Attribute("id"))
          {
             updatedDateTimeIDRef_ = updatedDateTimeNode->Attribute("id");
             updatedDateTime_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(updatedDateTimeNode));
             updatedDateTime_->setID(updatedDateTimeIDRef_);
             IDManager::instance().setID(updatedDateTimeIDRef_,updatedDateTime_);
          }
          else if(updatedDateTimeNode->Attribute("href")) { updatedDateTimeIDRef_ = updatedDateTimeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { updatedDateTime_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(updatedDateTimeNode));}
   }

   //reasonNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* reasonNode = xmlNode->FirstChildElement("reason");

   if(reasonNode){reasonIsNull_ = false;}
   else{reasonIsNull_ = true;}

   if(reasonNode)
   {
      for(reasonNode; reasonNode; reasonNode = reasonNode->NextSiblingElement("reason")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- reasonNode , address : " << reasonNode << std::endl;
          #endif
          if(reasonNode->Attribute("href") || reasonNode->Attribute("id"))
          {
              if(reasonNode->Attribute("id"))
              {
                  reasonIDRef_ = reasonNode->Attribute("id");
                  reason_.push_back(boost::shared_ptr<Reason>(new Reason(reasonNode)));
                  reason_.back()->setID(reasonIDRef_);
                  IDManager::instance().setID(reasonIDRef_, reason_.back());
              }
              else if(reasonNode->Attribute("href")) { reasonIDRef_ = reasonNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { reason_.push_back(boost::shared_ptr<Reason>(new Reason(reasonNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- reasonNode , address : " << reasonNode << std::endl;
       #endif
   }

   //statusAppliesToNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* statusAppliesToNode = xmlNode->FirstChildElement("statusAppliesTo");

   if(statusAppliesToNode){statusAppliesToIsNull_ = false;}
   else{statusAppliesToIsNull_ = true;}

   if(statusAppliesToNode)
   {
      for(statusAppliesToNode; statusAppliesToNode; statusAppliesToNode = statusAppliesToNode->NextSiblingElement("statusAppliesTo")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- statusAppliesToNode , address : " << statusAppliesToNode << std::endl;
          #endif
          if(statusAppliesToNode->Attribute("href") || statusAppliesToNode->Attribute("id"))
          {
              if(statusAppliesToNode->Attribute("id"))
              {
                  statusAppliesToIDRef_ = statusAppliesToNode->Attribute("id");
                  statusAppliesTo_.push_back(boost::shared_ptr<PartyReference>(new PartyReference(statusAppliesToNode)));
                  statusAppliesTo_.back()->setID(statusAppliesToIDRef_);
                  IDManager::instance().setID(statusAppliesToIDRef_, statusAppliesTo_.back());
              }
              else if(statusAppliesToNode->Attribute("href")) { statusAppliesToIDRef_ = statusAppliesToNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { statusAppliesTo_.push_back(boost::shared_ptr<PartyReference>(new PartyReference(statusAppliesToNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- statusAppliesToNode , address : " << statusAppliesToNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<TradeIdentifier>> ClearingStatusItem::getTradeIdentifier()
{
   if(!this->tradeIdentifierIsNull_){
        if(tradeIdentifierIDRef_ != ""){
             return this->tradeIdentifier_;
        }else{
             return this->tradeIdentifier_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<TradeIdentifier>>();
   }
}
boost::shared_ptr<TradeReferenceInformation> ClearingStatusItem::getTradeReferenceInformation()
{
   if(!this->tradeReferenceInformationIsNull_){
        if(tradeReferenceInformationIDRef_ != ""){
             return boost::shared_static_cast<TradeReferenceInformation>(IDManager::instance().getID(tradeReferenceInformationIDRef_));
        }else{
             return this->tradeReferenceInformation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TradeReferenceInformation>();
   }
}
boost::shared_ptr<Trade> ClearingStatusItem::getTrade()
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
boost::shared_ptr<ClearingStatusValue> ClearingStatusItem::getClearingStatusValue()
{
   if(!this->clearingStatusValueIsNull_){
        if(clearingStatusValueIDRef_ != ""){
             return boost::shared_static_cast<ClearingStatusValue>(IDManager::instance().getID(clearingStatusValueIDRef_));
        }else{
             return this->clearingStatusValue_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ClearingStatusValue>();
   }
}
boost::shared_ptr<XsdTypeDateTime> ClearingStatusItem::getUpdatedDateTime()
{
   if(!this->updatedDateTimeIsNull_){
        if(updatedDateTimeIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDateTime>(IDManager::instance().getID(updatedDateTimeIDRef_));
        }else{
             return this->updatedDateTime_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDateTime>();
   }
}
std::vector<boost::shared_ptr<Reason>> ClearingStatusItem::getReason()
{
   if(!this->reasonIsNull_){
        if(reasonIDRef_ != ""){
             return this->reason_;
        }else{
             return this->reason_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Reason>>();
   }
}
std::vector<boost::shared_ptr<PartyReference>> ClearingStatusItem::getStatusAppliesTo()
{
   if(!this->statusAppliesToIsNull_){
        if(statusAppliesToIDRef_ != ""){
             return this->statusAppliesTo_;
        }else{
             return this->statusAppliesTo_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<PartyReference>>();
   }
}
}

