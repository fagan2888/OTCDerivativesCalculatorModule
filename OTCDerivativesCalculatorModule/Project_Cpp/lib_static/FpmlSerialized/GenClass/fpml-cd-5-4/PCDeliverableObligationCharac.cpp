// PCDeliverableObligationCharac.cpp 
#include "PCDeliverableObligationCharac.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PCDeliverableObligationCharac::PCDeliverableObligationCharac(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //applicableNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* applicableNode = xmlNode->FirstChildElement("applicable");

   if(applicableNode){applicableIsNull_ = false;}
   else{applicableIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- applicableNode , address : " << applicableNode << std::endl;
   #endif
   if(applicableNode)
   {
      if(applicableNode->Attribute("href") || applicableNode->Attribute("id"))
      {
          if(applicableNode->Attribute("id"))
          {
             applicableIDRef_ = applicableNode->Attribute("id");
             applicable_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(applicableNode));
             applicable_->setID(applicableIDRef_);
             IDManager::instance().setID(applicableIDRef_,applicable_);
          }
          else if(applicableNode->Attribute("href")) { applicableIDRef_ = applicableNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { applicable_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(applicableNode));}
   }

   //partialCashSettlementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* partialCashSettlementNode = xmlNode->FirstChildElement("partialCashSettlement");

   if(partialCashSettlementNode){partialCashSettlementIsNull_ = false;}
   else{partialCashSettlementIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partialCashSettlementNode , address : " << partialCashSettlementNode << std::endl;
   #endif
   if(partialCashSettlementNode)
   {
      if(partialCashSettlementNode->Attribute("href") || partialCashSettlementNode->Attribute("id"))
      {
          if(partialCashSettlementNode->Attribute("id"))
          {
             partialCashSettlementIDRef_ = partialCashSettlementNode->Attribute("id");
             partialCashSettlement_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(partialCashSettlementNode));
             partialCashSettlement_->setID(partialCashSettlementIDRef_);
             IDManager::instance().setID(partialCashSettlementIDRef_,partialCashSettlement_);
          }
          else if(partialCashSettlementNode->Attribute("href")) { partialCashSettlementIDRef_ = partialCashSettlementNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { partialCashSettlement_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(partialCashSettlementNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeBoolean> PCDeliverableObligationCharac::getApplicable()
{
   if(!this->applicableIsNull_){
        if(applicableIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(applicableIDRef_));
        }else{
             return this->applicable_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> PCDeliverableObligationCharac::getPartialCashSettlement()
{
   if(!this->partialCashSettlementIsNull_){
        if(partialCashSettlementIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(partialCashSettlementIDRef_));
        }else{
             return this->partialCashSettlement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

