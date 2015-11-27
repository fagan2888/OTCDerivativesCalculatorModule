// MandatoryEarlyTermination.cpp 
#include "MandatoryEarlyTermination.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

MandatoryEarlyTermination::MandatoryEarlyTermination(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //mandatoryEarlyTerminationDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* mandatoryEarlyTerminationDateNode = xmlNode->FirstChildElement("mandatoryEarlyTerminationDate");

   if(mandatoryEarlyTerminationDateNode){mandatoryEarlyTerminationDateIsNull_ = false;}
   else{mandatoryEarlyTerminationDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- mandatoryEarlyTerminationDateNode , address : " << mandatoryEarlyTerminationDateNode << std::endl;
   #endif
   if(mandatoryEarlyTerminationDateNode)
   {
      if(mandatoryEarlyTerminationDateNode->Attribute("href") || mandatoryEarlyTerminationDateNode->Attribute("id"))
      {
          if(mandatoryEarlyTerminationDateNode->Attribute("id"))
          {
             mandatoryEarlyTerminationDateIDRef_ = mandatoryEarlyTerminationDateNode->Attribute("id");
             mandatoryEarlyTerminationDate_ = boost::shared_ptr<AdjustableDate>(new AdjustableDate(mandatoryEarlyTerminationDateNode));
             mandatoryEarlyTerminationDate_->setID(mandatoryEarlyTerminationDateIDRef_);
             IDManager::instance().setID(mandatoryEarlyTerminationDateIDRef_,mandatoryEarlyTerminationDate_);
          }
          else if(mandatoryEarlyTerminationDateNode->Attribute("href")) { mandatoryEarlyTerminationDateIDRef_ = mandatoryEarlyTerminationDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { mandatoryEarlyTerminationDate_ = boost::shared_ptr<AdjustableDate>(new AdjustableDate(mandatoryEarlyTerminationDateNode));}
   }

   //calculationAgentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationAgentNode = xmlNode->FirstChildElement("calculationAgent");

   if(calculationAgentNode){calculationAgentIsNull_ = false;}
   else{calculationAgentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationAgentNode , address : " << calculationAgentNode << std::endl;
   #endif
   if(calculationAgentNode)
   {
      if(calculationAgentNode->Attribute("href") || calculationAgentNode->Attribute("id"))
      {
          if(calculationAgentNode->Attribute("id"))
          {
             calculationAgentIDRef_ = calculationAgentNode->Attribute("id");
             calculationAgent_ = boost::shared_ptr<CalculationAgent>(new CalculationAgent(calculationAgentNode));
             calculationAgent_->setID(calculationAgentIDRef_);
             IDManager::instance().setID(calculationAgentIDRef_,calculationAgent_);
          }
          else if(calculationAgentNode->Attribute("href")) { calculationAgentIDRef_ = calculationAgentNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculationAgent_ = boost::shared_ptr<CalculationAgent>(new CalculationAgent(calculationAgentNode));}
   }

   //cashSettlementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* cashSettlementNode = xmlNode->FirstChildElement("cashSettlement");

   if(cashSettlementNode){cashSettlementIsNull_ = false;}
   else{cashSettlementIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cashSettlementNode , address : " << cashSettlementNode << std::endl;
   #endif
   if(cashSettlementNode)
   {
      if(cashSettlementNode->Attribute("href") || cashSettlementNode->Attribute("id"))
      {
          if(cashSettlementNode->Attribute("id"))
          {
             cashSettlementIDRef_ = cashSettlementNode->Attribute("id");
             cashSettlement_ = boost::shared_ptr<CashSettlement>(new CashSettlement(cashSettlementNode));
             cashSettlement_->setID(cashSettlementIDRef_);
             IDManager::instance().setID(cashSettlementIDRef_,cashSettlement_);
          }
          else if(cashSettlementNode->Attribute("href")) { cashSettlementIDRef_ = cashSettlementNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { cashSettlement_ = boost::shared_ptr<CashSettlement>(new CashSettlement(cashSettlementNode));}
   }

   //mandatoryEarlyTerminationAdjustedDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* mandatoryEarlyTerminationAdjustedDatesNode = xmlNode->FirstChildElement("mandatoryEarlyTerminationAdjustedDates");

   if(mandatoryEarlyTerminationAdjustedDatesNode){mandatoryEarlyTerminationAdjustedDatesIsNull_ = false;}
   else{mandatoryEarlyTerminationAdjustedDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- mandatoryEarlyTerminationAdjustedDatesNode , address : " << mandatoryEarlyTerminationAdjustedDatesNode << std::endl;
   #endif
   if(mandatoryEarlyTerminationAdjustedDatesNode)
   {
      if(mandatoryEarlyTerminationAdjustedDatesNode->Attribute("href") || mandatoryEarlyTerminationAdjustedDatesNode->Attribute("id"))
      {
          if(mandatoryEarlyTerminationAdjustedDatesNode->Attribute("id"))
          {
             mandatoryEarlyTerminationAdjustedDatesIDRef_ = mandatoryEarlyTerminationAdjustedDatesNode->Attribute("id");
             mandatoryEarlyTerminationAdjustedDates_ = boost::shared_ptr<MandatoryEarlyTerminationAdjustedDates>(new MandatoryEarlyTerminationAdjustedDates(mandatoryEarlyTerminationAdjustedDatesNode));
             mandatoryEarlyTerminationAdjustedDates_->setID(mandatoryEarlyTerminationAdjustedDatesIDRef_);
             IDManager::instance().setID(mandatoryEarlyTerminationAdjustedDatesIDRef_,mandatoryEarlyTerminationAdjustedDates_);
          }
          else if(mandatoryEarlyTerminationAdjustedDatesNode->Attribute("href")) { mandatoryEarlyTerminationAdjustedDatesIDRef_ = mandatoryEarlyTerminationAdjustedDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { mandatoryEarlyTerminationAdjustedDates_ = boost::shared_ptr<MandatoryEarlyTerminationAdjustedDates>(new MandatoryEarlyTerminationAdjustedDates(mandatoryEarlyTerminationAdjustedDatesNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AdjustableDate> MandatoryEarlyTermination::getMandatoryEarlyTerminationDate()
{
   if(!this->mandatoryEarlyTerminationDateIsNull_){
        if(mandatoryEarlyTerminationDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableDate>(IDManager::instance().getID(mandatoryEarlyTerminationDateIDRef_));
        }else{
             return this->mandatoryEarlyTerminationDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableDate>();
   }
}
boost::shared_ptr<CalculationAgent> MandatoryEarlyTermination::getCalculationAgent()
{
   if(!this->calculationAgentIsNull_){
        if(calculationAgentIDRef_ != ""){
             return boost::shared_static_cast<CalculationAgent>(IDManager::instance().getID(calculationAgentIDRef_));
        }else{
             return this->calculationAgent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CalculationAgent>();
   }
}
boost::shared_ptr<CashSettlement> MandatoryEarlyTermination::getCashSettlement()
{
   if(!this->cashSettlementIsNull_){
        if(cashSettlementIDRef_ != ""){
             return boost::shared_static_cast<CashSettlement>(IDManager::instance().getID(cashSettlementIDRef_));
        }else{
             return this->cashSettlement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CashSettlement>();
   }
}
boost::shared_ptr<MandatoryEarlyTerminationAdjustedDates> MandatoryEarlyTermination::getMandatoryEarlyTerminationAdjustedDates()
{
   if(!this->mandatoryEarlyTerminationAdjustedDatesIsNull_){
        if(mandatoryEarlyTerminationAdjustedDatesIDRef_ != ""){
             return boost::shared_static_cast<MandatoryEarlyTerminationAdjustedDates>(IDManager::instance().getID(mandatoryEarlyTerminationAdjustedDatesIDRef_));
        }else{
             return this->mandatoryEarlyTerminationAdjustedDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MandatoryEarlyTerminationAdjustedDates>();
   }
}
}

