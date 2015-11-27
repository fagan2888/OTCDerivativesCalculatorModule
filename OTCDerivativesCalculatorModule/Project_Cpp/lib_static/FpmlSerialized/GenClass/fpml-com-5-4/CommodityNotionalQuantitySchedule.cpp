// CommodityNotionalQuantitySchedule.cpp 
#include "CommodityNotionalQuantitySchedule.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CommodityNotionalQuantitySchedule::CommodityNotionalQuantitySchedule(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //notionalStepNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notionalStepNode = xmlNode->FirstChildElement("notionalStep");

   if(notionalStepNode){notionalStepIsNull_ = false;}
   else{notionalStepIsNull_ = true;}

   if(notionalStepNode)
   {
      for(notionalStepNode; notionalStepNode; notionalStepNode = notionalStepNode->NextSiblingElement("notionalStep")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notionalStepNode , address : " << notionalStepNode << std::endl;
          #endif
          if(notionalStepNode->Attribute("href") || notionalStepNode->Attribute("id"))
          {
              if(notionalStepNode->Attribute("id"))
              {
                  notionalStepIDRef_ = notionalStepNode->Attribute("id");
                  notionalStep_.push_back(boost::shared_ptr<CommodityNotionalQuantity>(new CommodityNotionalQuantity(notionalStepNode)));
                  notionalStep_.back()->setID(notionalStepIDRef_);
                  IDManager::instance().setID(notionalStepIDRef_, notionalStep_.back());
              }
              else if(notionalStepNode->Attribute("href")) { notionalStepIDRef_ = notionalStepNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { notionalStep_.push_back(boost::shared_ptr<CommodityNotionalQuantity>(new CommodityNotionalQuantity(notionalStepNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notionalStepNode , address : " << notionalStepNode << std::endl;
       #endif
   }

   //settlementPeriodsNotionalQuantityScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementPeriodsNotionalQuantityScheduleNode = xmlNode->FirstChildElement("settlementPeriodsNotionalQuantitySchedule");

   if(settlementPeriodsNotionalQuantityScheduleNode){settlementPeriodsNotionalQuantityScheduleIsNull_ = false;}
   else{settlementPeriodsNotionalQuantityScheduleIsNull_ = true;}

   if(settlementPeriodsNotionalQuantityScheduleNode)
   {
      for(settlementPeriodsNotionalQuantityScheduleNode; settlementPeriodsNotionalQuantityScheduleNode; settlementPeriodsNotionalQuantityScheduleNode = settlementPeriodsNotionalQuantityScheduleNode->NextSiblingElement("settlementPeriodsNotionalQuantitySchedule")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementPeriodsNotionalQuantityScheduleNode , address : " << settlementPeriodsNotionalQuantityScheduleNode << std::endl;
          #endif
          if(settlementPeriodsNotionalQuantityScheduleNode->Attribute("href") || settlementPeriodsNotionalQuantityScheduleNode->Attribute("id"))
          {
              if(settlementPeriodsNotionalQuantityScheduleNode->Attribute("id"))
              {
                  settlementPeriodsNotionalQuantityScheduleIDRef_ = settlementPeriodsNotionalQuantityScheduleNode->Attribute("id");
                  settlementPeriodsNotionalQuantitySchedule_.push_back(boost::shared_ptr<CommoditySettlementPeriodsNotionalQuantitySchedule>(new CommoditySettlementPeriodsNotionalQuantitySchedule(settlementPeriodsNotionalQuantityScheduleNode)));
                  settlementPeriodsNotionalQuantitySchedule_.back()->setID(settlementPeriodsNotionalQuantityScheduleIDRef_);
                  IDManager::instance().setID(settlementPeriodsNotionalQuantityScheduleIDRef_, settlementPeriodsNotionalQuantitySchedule_.back());
              }
              else if(settlementPeriodsNotionalQuantityScheduleNode->Attribute("href")) { settlementPeriodsNotionalQuantityScheduleIDRef_ = settlementPeriodsNotionalQuantityScheduleNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { settlementPeriodsNotionalQuantitySchedule_.push_back(boost::shared_ptr<CommoditySettlementPeriodsNotionalQuantitySchedule>(new CommoditySettlementPeriodsNotionalQuantitySchedule(settlementPeriodsNotionalQuantityScheduleNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementPeriodsNotionalQuantityScheduleNode , address : " << settlementPeriodsNotionalQuantityScheduleNode << std::endl;
       #endif
   }

   //calculationPeriodsReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationPeriodsReferenceNode = xmlNode->FirstChildElement("calculationPeriodsReference");

   if(calculationPeriodsReferenceNode){calculationPeriodsReferenceIsNull_ = false;}
   else{calculationPeriodsReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationPeriodsReferenceNode , address : " << calculationPeriodsReferenceNode << std::endl;
   #endif
   if(calculationPeriodsReferenceNode)
   {
      if(calculationPeriodsReferenceNode->Attribute("href") || calculationPeriodsReferenceNode->Attribute("id"))
      {
          if(calculationPeriodsReferenceNode->Attribute("id"))
          {
             calculationPeriodsReferenceIDRef_ = calculationPeriodsReferenceNode->Attribute("id");
             calculationPeriodsReference_ = boost::shared_ptr<CalculationPeriodsReference>(new CalculationPeriodsReference(calculationPeriodsReferenceNode));
             calculationPeriodsReference_->setID(calculationPeriodsReferenceIDRef_);
             IDManager::instance().setID(calculationPeriodsReferenceIDRef_,calculationPeriodsReference_);
          }
          else if(calculationPeriodsReferenceNode->Attribute("href")) { calculationPeriodsReferenceIDRef_ = calculationPeriodsReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculationPeriodsReference_ = boost::shared_ptr<CalculationPeriodsReference>(new CalculationPeriodsReference(calculationPeriodsReferenceNode));}
   }

   //calculationPeriodsScheduleReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationPeriodsScheduleReferenceNode = xmlNode->FirstChildElement("calculationPeriodsScheduleReference");

   if(calculationPeriodsScheduleReferenceNode){calculationPeriodsScheduleReferenceIsNull_ = false;}
   else{calculationPeriodsScheduleReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationPeriodsScheduleReferenceNode , address : " << calculationPeriodsScheduleReferenceNode << std::endl;
   #endif
   if(calculationPeriodsScheduleReferenceNode)
   {
      if(calculationPeriodsScheduleReferenceNode->Attribute("href") || calculationPeriodsScheduleReferenceNode->Attribute("id"))
      {
          if(calculationPeriodsScheduleReferenceNode->Attribute("id"))
          {
             calculationPeriodsScheduleReferenceIDRef_ = calculationPeriodsScheduleReferenceNode->Attribute("id");
             calculationPeriodsScheduleReference_ = boost::shared_ptr<CalculationPeriodsScheduleReference>(new CalculationPeriodsScheduleReference(calculationPeriodsScheduleReferenceNode));
             calculationPeriodsScheduleReference_->setID(calculationPeriodsScheduleReferenceIDRef_);
             IDManager::instance().setID(calculationPeriodsScheduleReferenceIDRef_,calculationPeriodsScheduleReference_);
          }
          else if(calculationPeriodsScheduleReferenceNode->Attribute("href")) { calculationPeriodsScheduleReferenceIDRef_ = calculationPeriodsScheduleReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculationPeriodsScheduleReference_ = boost::shared_ptr<CalculationPeriodsScheduleReference>(new CalculationPeriodsScheduleReference(calculationPeriodsScheduleReferenceNode));}
   }

   //calculationPeriodsDatesReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationPeriodsDatesReferenceNode = xmlNode->FirstChildElement("calculationPeriodsDatesReference");

   if(calculationPeriodsDatesReferenceNode){calculationPeriodsDatesReferenceIsNull_ = false;}
   else{calculationPeriodsDatesReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationPeriodsDatesReferenceNode , address : " << calculationPeriodsDatesReferenceNode << std::endl;
   #endif
   if(calculationPeriodsDatesReferenceNode)
   {
      if(calculationPeriodsDatesReferenceNode->Attribute("href") || calculationPeriodsDatesReferenceNode->Attribute("id"))
      {
          if(calculationPeriodsDatesReferenceNode->Attribute("id"))
          {
             calculationPeriodsDatesReferenceIDRef_ = calculationPeriodsDatesReferenceNode->Attribute("id");
             calculationPeriodsDatesReference_ = boost::shared_ptr<CalculationPeriodsDatesReference>(new CalculationPeriodsDatesReference(calculationPeriodsDatesReferenceNode));
             calculationPeriodsDatesReference_->setID(calculationPeriodsDatesReferenceIDRef_);
             IDManager::instance().setID(calculationPeriodsDatesReferenceIDRef_,calculationPeriodsDatesReference_);
          }
          else if(calculationPeriodsDatesReferenceNode->Attribute("href")) { calculationPeriodsDatesReferenceIDRef_ = calculationPeriodsDatesReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculationPeriodsDatesReference_ = boost::shared_ptr<CalculationPeriodsDatesReference>(new CalculationPeriodsDatesReference(calculationPeriodsDatesReferenceNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<CommodityNotionalQuantity>> CommodityNotionalQuantitySchedule::getNotionalStep()
{
   if(!this->notionalStepIsNull_){
        if(notionalStepIDRef_ != ""){
             return this->notionalStep_;
        }else{
             return this->notionalStep_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<CommodityNotionalQuantity>>();
   }
}
std::vector<boost::shared_ptr<CommoditySettlementPeriodsNotionalQuantitySchedule>> CommodityNotionalQuantitySchedule::getSettlementPeriodsNotionalQuantitySchedule()
{
   if(!this->settlementPeriodsNotionalQuantityScheduleIsNull_){
        if(settlementPeriodsNotionalQuantityScheduleIDRef_ != ""){
             return this->settlementPeriodsNotionalQuantitySchedule_;
        }else{
             return this->settlementPeriodsNotionalQuantitySchedule_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<CommoditySettlementPeriodsNotionalQuantitySchedule>>();
   }
}
boost::shared_ptr<CalculationPeriodsReference> CommodityNotionalQuantitySchedule::getCalculationPeriodsReference()
{
   if(!this->calculationPeriodsReferenceIsNull_){
        if(calculationPeriodsReferenceIDRef_ != ""){
             return boost::shared_static_cast<CalculationPeriodsReference>(IDManager::instance().getID(calculationPeriodsReferenceIDRef_));
        }else{
             return this->calculationPeriodsReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CalculationPeriodsReference>();
   }
}
boost::shared_ptr<CalculationPeriodsScheduleReference> CommodityNotionalQuantitySchedule::getCalculationPeriodsScheduleReference()
{
   if(!this->calculationPeriodsScheduleReferenceIsNull_){
        if(calculationPeriodsScheduleReferenceIDRef_ != ""){
             return boost::shared_static_cast<CalculationPeriodsScheduleReference>(IDManager::instance().getID(calculationPeriodsScheduleReferenceIDRef_));
        }else{
             return this->calculationPeriodsScheduleReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CalculationPeriodsScheduleReference>();
   }
}
boost::shared_ptr<CalculationPeriodsDatesReference> CommodityNotionalQuantitySchedule::getCalculationPeriodsDatesReference()
{
   if(!this->calculationPeriodsDatesReferenceIsNull_){
        if(calculationPeriodsDatesReferenceIDRef_ != ""){
             return boost::shared_static_cast<CalculationPeriodsDatesReference>(IDManager::instance().getID(calculationPeriodsDatesReferenceIDRef_));
        }else{
             return this->calculationPeriodsDatesReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CalculationPeriodsDatesReference>();
   }
}
}

