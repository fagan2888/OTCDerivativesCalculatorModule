// PhysicalSettlementTerms.cpp 
#include "PhysicalSettlementTerms.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PhysicalSettlementTerms::PhysicalSettlementTerms(TiXmlNode* xmlNode)
: SettlementTerms(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //physicalSettlementPeriodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* physicalSettlementPeriodNode = xmlNode->FirstChildElement("physicalSettlementPeriod");

   if(physicalSettlementPeriodNode){physicalSettlementPeriodIsNull_ = false;}
   else{physicalSettlementPeriodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- physicalSettlementPeriodNode , address : " << physicalSettlementPeriodNode << std::endl;
   #endif
   if(physicalSettlementPeriodNode)
   {
      if(physicalSettlementPeriodNode->Attribute("href") || physicalSettlementPeriodNode->Attribute("id"))
      {
          if(physicalSettlementPeriodNode->Attribute("id"))
          {
             physicalSettlementPeriodIDRef_ = physicalSettlementPeriodNode->Attribute("id");
             physicalSettlementPeriod_ = boost::shared_ptr<PhysicalSettlementPeriod>(new PhysicalSettlementPeriod(physicalSettlementPeriodNode));
             physicalSettlementPeriod_->setID(physicalSettlementPeriodIDRef_);
             IDManager::instance().setID(physicalSettlementPeriodIDRef_,physicalSettlementPeriod_);
          }
          else if(physicalSettlementPeriodNode->Attribute("href")) { physicalSettlementPeriodIDRef_ = physicalSettlementPeriodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { physicalSettlementPeriod_ = boost::shared_ptr<PhysicalSettlementPeriod>(new PhysicalSettlementPeriod(physicalSettlementPeriodNode));}
   }

   //deliverableObligationsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* deliverableObligationsNode = xmlNode->FirstChildElement("deliverableObligations");

   if(deliverableObligationsNode){deliverableObligationsIsNull_ = false;}
   else{deliverableObligationsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- deliverableObligationsNode , address : " << deliverableObligationsNode << std::endl;
   #endif
   if(deliverableObligationsNode)
   {
      if(deliverableObligationsNode->Attribute("href") || deliverableObligationsNode->Attribute("id"))
      {
          if(deliverableObligationsNode->Attribute("id"))
          {
             deliverableObligationsIDRef_ = deliverableObligationsNode->Attribute("id");
             deliverableObligations_ = boost::shared_ptr<DeliverableObligations>(new DeliverableObligations(deliverableObligationsNode));
             deliverableObligations_->setID(deliverableObligationsIDRef_);
             IDManager::instance().setID(deliverableObligationsIDRef_,deliverableObligations_);
          }
          else if(deliverableObligationsNode->Attribute("href")) { deliverableObligationsIDRef_ = deliverableObligationsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { deliverableObligations_ = boost::shared_ptr<DeliverableObligations>(new DeliverableObligations(deliverableObligationsNode));}
   }

   //escrowNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* escrowNode = xmlNode->FirstChildElement("escrow");

   if(escrowNode){escrowIsNull_ = false;}
   else{escrowIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- escrowNode , address : " << escrowNode << std::endl;
   #endif
   if(escrowNode)
   {
      if(escrowNode->Attribute("href") || escrowNode->Attribute("id"))
      {
          if(escrowNode->Attribute("id"))
          {
             escrowIDRef_ = escrowNode->Attribute("id");
             escrow_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(escrowNode));
             escrow_->setID(escrowIDRef_);
             IDManager::instance().setID(escrowIDRef_,escrow_);
          }
          else if(escrowNode->Attribute("href")) { escrowIDRef_ = escrowNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { escrow_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(escrowNode));}
   }

   //sixtyBusinessDaySettlementCapNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sixtyBusinessDaySettlementCapNode = xmlNode->FirstChildElement("sixtyBusinessDaySettlementCap");

   if(sixtyBusinessDaySettlementCapNode){sixtyBusinessDaySettlementCapIsNull_ = false;}
   else{sixtyBusinessDaySettlementCapIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sixtyBusinessDaySettlementCapNode , address : " << sixtyBusinessDaySettlementCapNode << std::endl;
   #endif
   if(sixtyBusinessDaySettlementCapNode)
   {
      if(sixtyBusinessDaySettlementCapNode->Attribute("href") || sixtyBusinessDaySettlementCapNode->Attribute("id"))
      {
          if(sixtyBusinessDaySettlementCapNode->Attribute("id"))
          {
             sixtyBusinessDaySettlementCapIDRef_ = sixtyBusinessDaySettlementCapNode->Attribute("id");
             sixtyBusinessDaySettlementCap_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(sixtyBusinessDaySettlementCapNode));
             sixtyBusinessDaySettlementCap_->setID(sixtyBusinessDaySettlementCapIDRef_);
             IDManager::instance().setID(sixtyBusinessDaySettlementCapIDRef_,sixtyBusinessDaySettlementCap_);
          }
          else if(sixtyBusinessDaySettlementCapNode->Attribute("href")) { sixtyBusinessDaySettlementCapIDRef_ = sixtyBusinessDaySettlementCapNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { sixtyBusinessDaySettlementCap_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(sixtyBusinessDaySettlementCapNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PhysicalSettlementPeriod> PhysicalSettlementTerms::getPhysicalSettlementPeriod()
{
   if(!this->physicalSettlementPeriodIsNull_){
        if(physicalSettlementPeriodIDRef_ != ""){
             return boost::shared_static_cast<PhysicalSettlementPeriod>(IDManager::instance().getID(physicalSettlementPeriodIDRef_));
        }else{
             return this->physicalSettlementPeriod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PhysicalSettlementPeriod>();
   }
}
boost::shared_ptr<DeliverableObligations> PhysicalSettlementTerms::getDeliverableObligations()
{
   if(!this->deliverableObligationsIsNull_){
        if(deliverableObligationsIDRef_ != ""){
             return boost::shared_static_cast<DeliverableObligations>(IDManager::instance().getID(deliverableObligationsIDRef_));
        }else{
             return this->deliverableObligations_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DeliverableObligations>();
   }
}
boost::shared_ptr<XsdTypeBoolean> PhysicalSettlementTerms::getEscrow()
{
   if(!this->escrowIsNull_){
        if(escrowIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(escrowIDRef_));
        }else{
             return this->escrow_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> PhysicalSettlementTerms::getSixtyBusinessDaySettlementCap()
{
   if(!this->sixtyBusinessDaySettlementCapIsNull_){
        if(sixtyBusinessDaySettlementCapIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(sixtyBusinessDaySettlementCapIDRef_));
        }else{
             return this->sixtyBusinessDaySettlementCap_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

