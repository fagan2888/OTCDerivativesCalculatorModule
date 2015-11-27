// CommodityStrikeSchedule.cpp 
#include "CommodityStrikeSchedule.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CommodityStrikeSchedule::CommodityStrikeSchedule(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //strikePricePerUnitStepNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* strikePricePerUnitStepNode = xmlNode->FirstChildElement("strikePricePerUnitStep");

   if(strikePricePerUnitStepNode){strikePricePerUnitStepIsNull_ = false;}
   else{strikePricePerUnitStepIsNull_ = true;}

   if(strikePricePerUnitStepNode)
   {
      for(strikePricePerUnitStepNode; strikePricePerUnitStepNode; strikePricePerUnitStepNode = strikePricePerUnitStepNode->NextSiblingElement("strikePricePerUnitStep")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- strikePricePerUnitStepNode , address : " << strikePricePerUnitStepNode << std::endl;
          #endif
          if(strikePricePerUnitStepNode->Attribute("href") || strikePricePerUnitStepNode->Attribute("id"))
          {
              if(strikePricePerUnitStepNode->Attribute("id"))
              {
                  strikePricePerUnitStepIDRef_ = strikePricePerUnitStepNode->Attribute("id");
                  strikePricePerUnitStep_.push_back(boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(strikePricePerUnitStepNode)));
                  strikePricePerUnitStep_.back()->setID(strikePricePerUnitStepIDRef_);
                  IDManager::instance().setID(strikePricePerUnitStepIDRef_, strikePricePerUnitStep_.back());
              }
              else if(strikePricePerUnitStepNode->Attribute("href")) { strikePricePerUnitStepIDRef_ = strikePricePerUnitStepNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { strikePricePerUnitStep_.push_back(boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(strikePricePerUnitStepNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- strikePricePerUnitStepNode , address : " << strikePricePerUnitStepNode << std::endl;
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
std::vector<boost::shared_ptr<NonNegativeMoney>> CommodityStrikeSchedule::getStrikePricePerUnitStep()
{
   if(!this->strikePricePerUnitStepIsNull_){
        if(strikePricePerUnitStepIDRef_ != ""){
             return this->strikePricePerUnitStep_;
        }else{
             return this->strikePricePerUnitStep_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<NonNegativeMoney>>();
   }
}
boost::shared_ptr<CalculationPeriodsReference> CommodityStrikeSchedule::getCalculationPeriodsReference()
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
boost::shared_ptr<CalculationPeriodsScheduleReference> CommodityStrikeSchedule::getCalculationPeriodsScheduleReference()
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
boost::shared_ptr<CalculationPeriodsDatesReference> CommodityStrikeSchedule::getCalculationPeriodsDatesReference()
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

