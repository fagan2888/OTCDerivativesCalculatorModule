// CoalStandardQualitySchedule.cpp 
#include "CoalStandardQualitySchedule.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CoalStandardQualitySchedule::CoalStandardQualitySchedule(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //StandardQualityStepNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* StandardQualityStepNode = xmlNode->FirstChildElement("StandardQualityStep");

   if(StandardQualityStepNode){StandardQualityStepIsNull_ = false;}
   else{StandardQualityStepIsNull_ = true;}

   if(StandardQualityStepNode)
   {
      for(StandardQualityStepNode; StandardQualityStepNode; StandardQualityStepNode = StandardQualityStepNode->NextSiblingElement("StandardQualityStep")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- StandardQualityStepNode , address : " << StandardQualityStepNode << std::endl;
          #endif
          if(StandardQualityStepNode->Attribute("href") || StandardQualityStepNode->Attribute("id"))
          {
              if(StandardQualityStepNode->Attribute("id"))
              {
                  StandardQualityStepIDRef_ = StandardQualityStepNode->Attribute("id");
                  StandardQualityStep_.push_back(boost::shared_ptr<CoalStandardQuality>(new CoalStandardQuality(StandardQualityStepNode)));
                  StandardQualityStep_.back()->setID(StandardQualityStepIDRef_);
                  IDManager::instance().setID(StandardQualityStepIDRef_, StandardQualityStep_.back());
              }
              else if(StandardQualityStepNode->Attribute("href")) { StandardQualityStepIDRef_ = StandardQualityStepNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { StandardQualityStep_.push_back(boost::shared_ptr<CoalStandardQuality>(new CoalStandardQuality(StandardQualityStepNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- StandardQualityStepNode , address : " << StandardQualityStepNode << std::endl;
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
std::vector<boost::shared_ptr<CoalStandardQuality>> CoalStandardQualitySchedule::getStandardQualityStep()
{
   if(!this->StandardQualityStepIsNull_){
        if(StandardQualityStepIDRef_ != ""){
             return this->StandardQualityStep_;
        }else{
             return this->StandardQualityStep_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<CoalStandardQuality>>();
   }
}
boost::shared_ptr<CalculationPeriodsReference> CoalStandardQualitySchedule::getDeliveryPeriodsReference()
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
boost::shared_ptr<CalculationPeriodsScheduleReference> CoalStandardQualitySchedule::getDeliveryPeriodsScheduleReference()
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

