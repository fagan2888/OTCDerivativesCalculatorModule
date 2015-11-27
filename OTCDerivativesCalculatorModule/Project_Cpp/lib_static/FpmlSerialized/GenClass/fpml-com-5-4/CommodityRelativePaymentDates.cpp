// CommodityRelativePaymentDates.cpp 
#include "CommodityRelativePaymentDates.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CommodityRelativePaymentDates::CommodityRelativePaymentDates(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //payRelativeToNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* payRelativeToNode = xmlNode->FirstChildElement("payRelativeTo");

   if(payRelativeToNode){payRelativeToIsNull_ = false;}
   else{payRelativeToIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- payRelativeToNode , address : " << payRelativeToNode << std::endl;
   #endif
   if(payRelativeToNode)
   {
      if(payRelativeToNode->Attribute("href") || payRelativeToNode->Attribute("id"))
      {
          if(payRelativeToNode->Attribute("id"))
          {
             payRelativeToIDRef_ = payRelativeToNode->Attribute("id");
             payRelativeTo_ = boost::shared_ptr<CommodityPayRelativeToEnum>(new CommodityPayRelativeToEnum(payRelativeToNode));
             payRelativeTo_->setID(payRelativeToIDRef_);
             IDManager::instance().setID(payRelativeToIDRef_,payRelativeTo_);
          }
          else if(payRelativeToNode->Attribute("href")) { payRelativeToIDRef_ = payRelativeToNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { payRelativeTo_ = boost::shared_ptr<CommodityPayRelativeToEnum>(new CommodityPayRelativeToEnum(payRelativeToNode));}
   }

   //payRelativeToEventNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* payRelativeToEventNode = xmlNode->FirstChildElement("payRelativeToEvent");

   if(payRelativeToEventNode){payRelativeToEventIsNull_ = false;}
   else{payRelativeToEventIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- payRelativeToEventNode , address : " << payRelativeToEventNode << std::endl;
   #endif
   if(payRelativeToEventNode)
   {
      if(payRelativeToEventNode->Attribute("href") || payRelativeToEventNode->Attribute("id"))
      {
          if(payRelativeToEventNode->Attribute("id"))
          {
             payRelativeToEventIDRef_ = payRelativeToEventNode->Attribute("id");
             payRelativeToEvent_ = boost::shared_ptr<CommodityPayRelativeToEvent>(new CommodityPayRelativeToEvent(payRelativeToEventNode));
             payRelativeToEvent_->setID(payRelativeToEventIDRef_);
             IDManager::instance().setID(payRelativeToEventIDRef_,payRelativeToEvent_);
          }
          else if(payRelativeToEventNode->Attribute("href")) { payRelativeToEventIDRef_ = payRelativeToEventNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { payRelativeToEvent_ = boost::shared_ptr<CommodityPayRelativeToEvent>(new CommodityPayRelativeToEvent(payRelativeToEventNode));}
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

   //paymentDaysOffsetNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentDaysOffsetNode = xmlNode->FirstChildElement("paymentDaysOffset");

   if(paymentDaysOffsetNode){paymentDaysOffsetIsNull_ = false;}
   else{paymentDaysOffsetIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentDaysOffsetNode , address : " << paymentDaysOffsetNode << std::endl;
   #endif
   if(paymentDaysOffsetNode)
   {
      if(paymentDaysOffsetNode->Attribute("href") || paymentDaysOffsetNode->Attribute("id"))
      {
          if(paymentDaysOffsetNode->Attribute("id"))
          {
             paymentDaysOffsetIDRef_ = paymentDaysOffsetNode->Attribute("id");
             paymentDaysOffset_ = boost::shared_ptr<DateOffset>(new DateOffset(paymentDaysOffsetNode));
             paymentDaysOffset_->setID(paymentDaysOffsetIDRef_);
             IDManager::instance().setID(paymentDaysOffsetIDRef_,paymentDaysOffset_);
          }
          else if(paymentDaysOffsetNode->Attribute("href")) { paymentDaysOffsetIDRef_ = paymentDaysOffsetNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { paymentDaysOffset_ = boost::shared_ptr<DateOffset>(new DateOffset(paymentDaysOffsetNode));}
   }

   //businessCentersReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* businessCentersReferenceNode = xmlNode->FirstChildElement("businessCentersReference");

   if(businessCentersReferenceNode){businessCentersReferenceIsNull_ = false;}
   else{businessCentersReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessCentersReferenceNode , address : " << businessCentersReferenceNode << std::endl;
   #endif
   if(businessCentersReferenceNode)
   {
      if(businessCentersReferenceNode->Attribute("href") || businessCentersReferenceNode->Attribute("id"))
      {
          if(businessCentersReferenceNode->Attribute("id"))
          {
             businessCentersReferenceIDRef_ = businessCentersReferenceNode->Attribute("id");
             businessCentersReference_ = boost::shared_ptr<BusinessCentersReference>(new BusinessCentersReference(businessCentersReferenceNode));
             businessCentersReference_->setID(businessCentersReferenceIDRef_);
             IDManager::instance().setID(businessCentersReferenceIDRef_,businessCentersReference_);
          }
          else if(businessCentersReferenceNode->Attribute("href")) { businessCentersReferenceIDRef_ = businessCentersReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { businessCentersReference_ = boost::shared_ptr<BusinessCentersReference>(new BusinessCentersReference(businessCentersReferenceNode));}
   }

   //businessCentersNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* businessCentersNode = xmlNode->FirstChildElement("businessCenters");

   if(businessCentersNode){businessCentersIsNull_ = false;}
   else{businessCentersIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessCentersNode , address : " << businessCentersNode << std::endl;
   #endif
   if(businessCentersNode)
   {
      if(businessCentersNode->Attribute("href") || businessCentersNode->Attribute("id"))
      {
          if(businessCentersNode->Attribute("id"))
          {
             businessCentersIDRef_ = businessCentersNode->Attribute("id");
             businessCenters_ = boost::shared_ptr<BusinessCenters>(new BusinessCenters(businessCentersNode));
             businessCenters_->setID(businessCentersIDRef_);
             IDManager::instance().setID(businessCentersIDRef_,businessCenters_);
          }
          else if(businessCentersNode->Attribute("href")) { businessCentersIDRef_ = businessCentersNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { businessCenters_ = boost::shared_ptr<BusinessCenters>(new BusinessCenters(businessCentersNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CommodityPayRelativeToEnum> CommodityRelativePaymentDates::getPayRelativeTo()
{
   if(!this->payRelativeToIsNull_){
        if(payRelativeToIDRef_ != ""){
             return boost::shared_static_cast<CommodityPayRelativeToEnum>(IDManager::instance().getID(payRelativeToIDRef_));
        }else{
             return this->payRelativeTo_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityPayRelativeToEnum>();
   }
}
boost::shared_ptr<CommodityPayRelativeToEvent> CommodityRelativePaymentDates::getPayRelativeToEvent()
{
   if(!this->payRelativeToEventIsNull_){
        if(payRelativeToEventIDRef_ != ""){
             return boost::shared_static_cast<CommodityPayRelativeToEvent>(IDManager::instance().getID(payRelativeToEventIDRef_));
        }else{
             return this->payRelativeToEvent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityPayRelativeToEvent>();
   }
}
boost::shared_ptr<CalculationPeriodsReference> CommodityRelativePaymentDates::getCalculationPeriodsReference()
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
boost::shared_ptr<CalculationPeriodsScheduleReference> CommodityRelativePaymentDates::getCalculationPeriodsScheduleReference()
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
boost::shared_ptr<CalculationPeriodsDatesReference> CommodityRelativePaymentDates::getCalculationPeriodsDatesReference()
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
boost::shared_ptr<DateOffset> CommodityRelativePaymentDates::getPaymentDaysOffset()
{
   if(!this->paymentDaysOffsetIsNull_){
        if(paymentDaysOffsetIDRef_ != ""){
             return boost::shared_static_cast<DateOffset>(IDManager::instance().getID(paymentDaysOffsetIDRef_));
        }else{
             return this->paymentDaysOffset_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DateOffset>();
   }
}
boost::shared_ptr<BusinessCentersReference> CommodityRelativePaymentDates::getBusinessCentersReference()
{
   if(!this->businessCentersReferenceIsNull_){
        if(businessCentersReferenceIDRef_ != ""){
             return boost::shared_static_cast<BusinessCentersReference>(IDManager::instance().getID(businessCentersReferenceIDRef_));
        }else{
             return this->businessCentersReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessCentersReference>();
   }
}
boost::shared_ptr<BusinessCenters> CommodityRelativePaymentDates::getBusinessCenters()
{
   if(!this->businessCentersIsNull_){
        if(businessCentersIDRef_ != ""){
             return boost::shared_static_cast<BusinessCenters>(IDManager::instance().getID(businessCentersIDRef_));
        }else{
             return this->businessCenters_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessCenters>();
   }
}
}

