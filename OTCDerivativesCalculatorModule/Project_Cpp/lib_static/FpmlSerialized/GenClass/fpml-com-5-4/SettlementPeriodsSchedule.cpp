// SettlementPeriodsSchedule.cpp 
#include "SettlementPeriodsSchedule.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SettlementPeriodsSchedule::SettlementPeriodsSchedule(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //settlementPeriodsStepNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementPeriodsStepNode = xmlNode->FirstChildElement("settlementPeriodsStep");

   if(settlementPeriodsStepNode){settlementPeriodsStepIsNull_ = false;}
   else{settlementPeriodsStepIsNull_ = true;}

   if(settlementPeriodsStepNode)
   {
      for(settlementPeriodsStepNode; settlementPeriodsStepNode; settlementPeriodsStepNode = settlementPeriodsStepNode->NextSiblingElement("settlementPeriodsStep")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementPeriodsStepNode , address : " << settlementPeriodsStepNode << std::endl;
          #endif
          if(settlementPeriodsStepNode->Attribute("href") || settlementPeriodsStepNode->Attribute("id"))
          {
              if(settlementPeriodsStepNode->Attribute("id"))
              {
                  settlementPeriodsStepIDRef_ = settlementPeriodsStepNode->Attribute("id");
                  settlementPeriodsStep_.push_back(boost::shared_ptr<SettlementPeriodsStep>(new SettlementPeriodsStep(settlementPeriodsStepNode)));
                  settlementPeriodsStep_.back()->setID(settlementPeriodsStepIDRef_);
                  IDManager::instance().setID(settlementPeriodsStepIDRef_, settlementPeriodsStep_.back());
              }
              else if(settlementPeriodsStepNode->Attribute("href")) { settlementPeriodsStepIDRef_ = settlementPeriodsStepNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { settlementPeriodsStep_.push_back(boost::shared_ptr<SettlementPeriodsStep>(new SettlementPeriodsStep(settlementPeriodsStepNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementPeriodsStepNode , address : " << settlementPeriodsStepNode << std::endl;
       #endif
   }

   //deliveryPeriodsReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* deliveryPeriodsReferenceNode = xmlNode->FirstChildElement("deliveryPeriodsReference");

   if(deliveryPeriodsReferenceNode){deliveryPeriodsReferenceIsNull_ = false;}
   else{deliveryPeriodsReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- deliveryPeriodsReferenceNode , address : " << deliveryPeriodsReferenceNode << std::endl;
   #endif
   if(deliveryPeriodsReferenceNode)
   {
      if(deliveryPeriodsReferenceNode->Attribute("href") || deliveryPeriodsReferenceNode->Attribute("id"))
      {
          if(deliveryPeriodsReferenceNode->Attribute("id"))
          {
             deliveryPeriodsReferenceIDRef_ = deliveryPeriodsReferenceNode->Attribute("id");
             deliveryPeriodsReference_ = boost::shared_ptr<CalculationPeriodsReference>(new CalculationPeriodsReference(deliveryPeriodsReferenceNode));
             deliveryPeriodsReference_->setID(deliveryPeriodsReferenceIDRef_);
             IDManager::instance().setID(deliveryPeriodsReferenceIDRef_,deliveryPeriodsReference_);
          }
          else if(deliveryPeriodsReferenceNode->Attribute("href")) { deliveryPeriodsReferenceIDRef_ = deliveryPeriodsReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { deliveryPeriodsReference_ = boost::shared_ptr<CalculationPeriodsReference>(new CalculationPeriodsReference(deliveryPeriodsReferenceNode));}
   }

   //deliveryPeriodsScheduleReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* deliveryPeriodsScheduleReferenceNode = xmlNode->FirstChildElement("deliveryPeriodsScheduleReference");

   if(deliveryPeriodsScheduleReferenceNode){deliveryPeriodsScheduleReferenceIsNull_ = false;}
   else{deliveryPeriodsScheduleReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- deliveryPeriodsScheduleReferenceNode , address : " << deliveryPeriodsScheduleReferenceNode << std::endl;
   #endif
   if(deliveryPeriodsScheduleReferenceNode)
   {
      if(deliveryPeriodsScheduleReferenceNode->Attribute("href") || deliveryPeriodsScheduleReferenceNode->Attribute("id"))
      {
          if(deliveryPeriodsScheduleReferenceNode->Attribute("id"))
          {
             deliveryPeriodsScheduleReferenceIDRef_ = deliveryPeriodsScheduleReferenceNode->Attribute("id");
             deliveryPeriodsScheduleReference_ = boost::shared_ptr<CalculationPeriodsScheduleReference>(new CalculationPeriodsScheduleReference(deliveryPeriodsScheduleReferenceNode));
             deliveryPeriodsScheduleReference_->setID(deliveryPeriodsScheduleReferenceIDRef_);
             IDManager::instance().setID(deliveryPeriodsScheduleReferenceIDRef_,deliveryPeriodsScheduleReference_);
          }
          else if(deliveryPeriodsScheduleReferenceNode->Attribute("href")) { deliveryPeriodsScheduleReferenceIDRef_ = deliveryPeriodsScheduleReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { deliveryPeriodsScheduleReference_ = boost::shared_ptr<CalculationPeriodsScheduleReference>(new CalculationPeriodsScheduleReference(deliveryPeriodsScheduleReferenceNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<SettlementPeriodsStep>> SettlementPeriodsSchedule::getSettlementPeriodsStep()
{
   if(!this->settlementPeriodsStepIsNull_){
        if(settlementPeriodsStepIDRef_ != ""){
             return this->settlementPeriodsStep_;
        }else{
             return this->settlementPeriodsStep_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<SettlementPeriodsStep>>();
   }
}
boost::shared_ptr<CalculationPeriodsReference> SettlementPeriodsSchedule::getDeliveryPeriodsReference()
{
   if(!this->deliveryPeriodsReferenceIsNull_){
        if(deliveryPeriodsReferenceIDRef_ != ""){
             return boost::shared_static_cast<CalculationPeriodsReference>(IDManager::instance().getID(deliveryPeriodsReferenceIDRef_));
        }else{
             return this->deliveryPeriodsReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CalculationPeriodsReference>();
   }
}
boost::shared_ptr<CalculationPeriodsScheduleReference> SettlementPeriodsSchedule::getDeliveryPeriodsScheduleReference()
{
   if(!this->deliveryPeriodsScheduleReferenceIsNull_){
        if(deliveryPeriodsScheduleReferenceIDRef_ != ""){
             return boost::shared_static_cast<CalculationPeriodsScheduleReference>(IDManager::instance().getID(deliveryPeriodsScheduleReferenceIDRef_));
        }else{
             return this->deliveryPeriodsScheduleReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CalculationPeriodsScheduleReference>();
   }
}
}

