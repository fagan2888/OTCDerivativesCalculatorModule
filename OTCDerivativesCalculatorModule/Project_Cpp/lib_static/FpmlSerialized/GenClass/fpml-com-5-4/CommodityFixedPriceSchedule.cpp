// CommodityFixedPriceSchedule.cpp 
#include "CommodityFixedPriceSchedule.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CommodityFixedPriceSchedule::CommodityFixedPriceSchedule(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //fixedPriceStepNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixedPriceStepNode = xmlNode->FirstChildElement("fixedPriceStep");

   if(fixedPriceStepNode){fixedPriceStepIsNull_ = false;}
   else{fixedPriceStepIsNull_ = true;}

   if(fixedPriceStepNode)
   {
      for(fixedPriceStepNode; fixedPriceStepNode; fixedPriceStepNode = fixedPriceStepNode->NextSiblingElement("fixedPriceStep")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixedPriceStepNode , address : " << fixedPriceStepNode << std::endl;
          #endif
          if(fixedPriceStepNode->Attribute("href") || fixedPriceStepNode->Attribute("id"))
          {
              if(fixedPriceStepNode->Attribute("id"))
              {
                  fixedPriceStepIDRef_ = fixedPriceStepNode->Attribute("id");
                  fixedPriceStep_.push_back(boost::shared_ptr<FixedPrice>(new FixedPrice(fixedPriceStepNode)));
                  fixedPriceStep_.back()->setID(fixedPriceStepIDRef_);
                  IDManager::instance().setID(fixedPriceStepIDRef_, fixedPriceStep_.back());
              }
              else if(fixedPriceStepNode->Attribute("href")) { fixedPriceStepIDRef_ = fixedPriceStepNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { fixedPriceStep_.push_back(boost::shared_ptr<FixedPrice>(new FixedPrice(fixedPriceStepNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixedPriceStepNode , address : " << fixedPriceStepNode << std::endl;
       #endif
   }

   //worldscaleRateStepNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* worldscaleRateStepNode = xmlNode->FirstChildElement("worldscaleRateStep");

   if(worldscaleRateStepNode){worldscaleRateStepIsNull_ = false;}
   else{worldscaleRateStepIsNull_ = true;}

   if(worldscaleRateStepNode)
   {
      for(worldscaleRateStepNode; worldscaleRateStepNode; worldscaleRateStepNode = worldscaleRateStepNode->NextSiblingElement("worldscaleRateStep")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- worldscaleRateStepNode , address : " << worldscaleRateStepNode << std::endl;
          #endif
          if(worldscaleRateStepNode->Attribute("href") || worldscaleRateStepNode->Attribute("id"))
          {
              if(worldscaleRateStepNode->Attribute("id"))
              {
                  worldscaleRateStepIDRef_ = worldscaleRateStepNode->Attribute("id");
                  worldscaleRateStep_.push_back(boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(worldscaleRateStepNode)));
                  worldscaleRateStep_.back()->setID(worldscaleRateStepIDRef_);
                  IDManager::instance().setID(worldscaleRateStepIDRef_, worldscaleRateStep_.back());
              }
              else if(worldscaleRateStepNode->Attribute("href")) { worldscaleRateStepIDRef_ = worldscaleRateStepNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { worldscaleRateStep_.push_back(boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(worldscaleRateStepNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- worldscaleRateStepNode , address : " << worldscaleRateStepNode << std::endl;
       #endif
   }

   //contractRateStepNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* contractRateStepNode = xmlNode->FirstChildElement("contractRateStep");

   if(contractRateStepNode){contractRateStepIsNull_ = false;}
   else{contractRateStepIsNull_ = true;}

   if(contractRateStepNode)
   {
      for(contractRateStepNode; contractRateStepNode; contractRateStepNode = contractRateStepNode->NextSiblingElement("contractRateStep")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- contractRateStepNode , address : " << contractRateStepNode << std::endl;
          #endif
          if(contractRateStepNode->Attribute("href") || contractRateStepNode->Attribute("id"))
          {
              if(contractRateStepNode->Attribute("id"))
              {
                  contractRateStepIDRef_ = contractRateStepNode->Attribute("id");
                  contractRateStep_.push_back(boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(contractRateStepNode)));
                  contractRateStep_.back()->setID(contractRateStepIDRef_);
                  IDManager::instance().setID(contractRateStepIDRef_, contractRateStep_.back());
              }
              else if(contractRateStepNode->Attribute("href")) { contractRateStepIDRef_ = contractRateStepNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { contractRateStep_.push_back(boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(contractRateStepNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- contractRateStepNode , address : " << contractRateStepNode << std::endl;
       #endif
   }

   //settlementPeriodsPriceScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementPeriodsPriceScheduleNode = xmlNode->FirstChildElement("settlementPeriodsPriceSchedule");

   if(settlementPeriodsPriceScheduleNode){settlementPeriodsPriceScheduleIsNull_ = false;}
   else{settlementPeriodsPriceScheduleIsNull_ = true;}

   if(settlementPeriodsPriceScheduleNode)
   {
      for(settlementPeriodsPriceScheduleNode; settlementPeriodsPriceScheduleNode; settlementPeriodsPriceScheduleNode = settlementPeriodsPriceScheduleNode->NextSiblingElement("settlementPeriodsPriceSchedule")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementPeriodsPriceScheduleNode , address : " << settlementPeriodsPriceScheduleNode << std::endl;
          #endif
          if(settlementPeriodsPriceScheduleNode->Attribute("href") || settlementPeriodsPriceScheduleNode->Attribute("id"))
          {
              if(settlementPeriodsPriceScheduleNode->Attribute("id"))
              {
                  settlementPeriodsPriceScheduleIDRef_ = settlementPeriodsPriceScheduleNode->Attribute("id");
                  settlementPeriodsPriceSchedule_.push_back(boost::shared_ptr<CommoditySettlementPeriodsPriceSchedule>(new CommoditySettlementPeriodsPriceSchedule(settlementPeriodsPriceScheduleNode)));
                  settlementPeriodsPriceSchedule_.back()->setID(settlementPeriodsPriceScheduleIDRef_);
                  IDManager::instance().setID(settlementPeriodsPriceScheduleIDRef_, settlementPeriodsPriceSchedule_.back());
              }
              else if(settlementPeriodsPriceScheduleNode->Attribute("href")) { settlementPeriodsPriceScheduleIDRef_ = settlementPeriodsPriceScheduleNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { settlementPeriodsPriceSchedule_.push_back(boost::shared_ptr<CommoditySettlementPeriodsPriceSchedule>(new CommoditySettlementPeriodsPriceSchedule(settlementPeriodsPriceScheduleNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementPeriodsPriceScheduleNode , address : " << settlementPeriodsPriceScheduleNode << std::endl;
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
std::vector<boost::shared_ptr<FixedPrice>> CommodityFixedPriceSchedule::getFixedPriceStep()
{
   if(!this->fixedPriceStepIsNull_){
        if(fixedPriceStepIDRef_ != ""){
             return this->fixedPriceStep_;
        }else{
             return this->fixedPriceStep_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<FixedPrice>>();
   }
}
std::vector<boost::shared_ptr<XsdTypeDecimal>> CommodityFixedPriceSchedule::getWorldscaleRateStep()
{
   if(!this->worldscaleRateStepIsNull_){
        if(worldscaleRateStepIDRef_ != ""){
             return this->worldscaleRateStep_;
        }else{
             return this->worldscaleRateStep_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<XsdTypeDecimal>>();
   }
}
std::vector<boost::shared_ptr<NonNegativeMoney>> CommodityFixedPriceSchedule::getContractRateStep()
{
   if(!this->contractRateStepIsNull_){
        if(contractRateStepIDRef_ != ""){
             return this->contractRateStep_;
        }else{
             return this->contractRateStep_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<NonNegativeMoney>>();
   }
}
std::vector<boost::shared_ptr<CommoditySettlementPeriodsPriceSchedule>> CommodityFixedPriceSchedule::getSettlementPeriodsPriceSchedule()
{
   if(!this->settlementPeriodsPriceScheduleIsNull_){
        if(settlementPeriodsPriceScheduleIDRef_ != ""){
             return this->settlementPeriodsPriceSchedule_;
        }else{
             return this->settlementPeriodsPriceSchedule_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<CommoditySettlementPeriodsPriceSchedule>>();
   }
}
boost::shared_ptr<CalculationPeriodsReference> CommodityFixedPriceSchedule::getCalculationPeriodsReference()
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
boost::shared_ptr<CalculationPeriodsScheduleReference> CommodityFixedPriceSchedule::getCalculationPeriodsScheduleReference()
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
boost::shared_ptr<CalculationPeriodsDatesReference> CommodityFixedPriceSchedule::getCalculationPeriodsDatesReference()
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

