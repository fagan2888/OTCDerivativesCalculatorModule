// CommodityPricingDates.cpp 
#include "CommodityPricingDates.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CommodityPricingDates::CommodityPricingDates(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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

   //lagNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* lagNode = xmlNode->FirstChildElement("lag");

   if(lagNode){lagIsNull_ = false;}
   else{lagIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- lagNode , address : " << lagNode << std::endl;
   #endif
   if(lagNode)
   {
      if(lagNode->Attribute("href") || lagNode->Attribute("id"))
      {
          if(lagNode->Attribute("id"))
          {
             lagIDRef_ = lagNode->Attribute("id");
             lag_ = boost::shared_ptr<Lag>(new Lag(lagNode));
             lag_->setID(lagIDRef_);
             IDManager::instance().setID(lagIDRef_,lag_);
          }
          else if(lagNode->Attribute("href")) { lagIDRef_ = lagNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { lag_ = boost::shared_ptr<Lag>(new Lag(lagNode));}
   }

   //dayTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dayTypeNode = xmlNode->FirstChildElement("dayType");

   if(dayTypeNode){dayTypeIsNull_ = false;}
   else{dayTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dayTypeNode , address : " << dayTypeNode << std::endl;
   #endif
   if(dayTypeNode)
   {
      if(dayTypeNode->Attribute("href") || dayTypeNode->Attribute("id"))
      {
          if(dayTypeNode->Attribute("id"))
          {
             dayTypeIDRef_ = dayTypeNode->Attribute("id");
             dayType_ = boost::shared_ptr<CommodityDayTypeEnum>(new CommodityDayTypeEnum(dayTypeNode));
             dayType_->setID(dayTypeIDRef_);
             IDManager::instance().setID(dayTypeIDRef_,dayType_);
          }
          else if(dayTypeNode->Attribute("href")) { dayTypeIDRef_ = dayTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dayType_ = boost::shared_ptr<CommodityDayTypeEnum>(new CommodityDayTypeEnum(dayTypeNode));}
   }

   //dayDistributionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dayDistributionNode = xmlNode->FirstChildElement("dayDistribution");

   if(dayDistributionNode){dayDistributionIsNull_ = false;}
   else{dayDistributionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dayDistributionNode , address : " << dayDistributionNode << std::endl;
   #endif
   if(dayDistributionNode)
   {
      if(dayDistributionNode->Attribute("href") || dayDistributionNode->Attribute("id"))
      {
          if(dayDistributionNode->Attribute("id"))
          {
             dayDistributionIDRef_ = dayDistributionNode->Attribute("id");
             dayDistribution_ = boost::shared_ptr<CommodityFrequencyType>(new CommodityFrequencyType(dayDistributionNode));
             dayDistribution_->setID(dayDistributionIDRef_);
             IDManager::instance().setID(dayDistributionIDRef_,dayDistribution_);
          }
          else if(dayDistributionNode->Attribute("href")) { dayDistributionIDRef_ = dayDistributionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dayDistribution_ = boost::shared_ptr<CommodityFrequencyType>(new CommodityFrequencyType(dayDistributionNode));}
   }

   //dayCountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dayCountNode = xmlNode->FirstChildElement("dayCount");

   if(dayCountNode){dayCountIsNull_ = false;}
   else{dayCountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dayCountNode , address : " << dayCountNode << std::endl;
   #endif
   if(dayCountNode)
   {
      if(dayCountNode->Attribute("href") || dayCountNode->Attribute("id"))
      {
          if(dayCountNode->Attribute("id"))
          {
             dayCountIDRef_ = dayCountNode->Attribute("id");
             dayCount_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(dayCountNode));
             dayCount_->setID(dayCountIDRef_);
             IDManager::instance().setID(dayCountIDRef_,dayCount_);
          }
          else if(dayCountNode->Attribute("href")) { dayCountIDRef_ = dayCountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dayCount_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(dayCountNode));}
   }

   //dayOfWeekNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dayOfWeekNode = xmlNode->FirstChildElement("dayOfWeek");

   if(dayOfWeekNode){dayOfWeekIsNull_ = false;}
   else{dayOfWeekIsNull_ = true;}

   if(dayOfWeekNode)
   {
      for(dayOfWeekNode; dayOfWeekNode; dayOfWeekNode = dayOfWeekNode->NextSiblingElement("dayOfWeek")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dayOfWeekNode , address : " << dayOfWeekNode << std::endl;
          #endif
          if(dayOfWeekNode->Attribute("href") || dayOfWeekNode->Attribute("id"))
          {
              if(dayOfWeekNode->Attribute("id"))
              {
                  dayOfWeekIDRef_ = dayOfWeekNode->Attribute("id");
                  dayOfWeek_.push_back(boost::shared_ptr<DayOfWeekEnum>(new DayOfWeekEnum(dayOfWeekNode)));
                  dayOfWeek_.back()->setID(dayOfWeekIDRef_);
                  IDManager::instance().setID(dayOfWeekIDRef_, dayOfWeek_.back());
              }
              else if(dayOfWeekNode->Attribute("href")) { dayOfWeekIDRef_ = dayOfWeekNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { dayOfWeek_.push_back(boost::shared_ptr<DayOfWeekEnum>(new DayOfWeekEnum(dayOfWeekNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dayOfWeekNode , address : " << dayOfWeekNode << std::endl;
       #endif
   }

   //dayNumberNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dayNumberNode = xmlNode->FirstChildElement("dayNumber");

   if(dayNumberNode){dayNumberIsNull_ = false;}
   else{dayNumberIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dayNumberNode , address : " << dayNumberNode << std::endl;
   #endif
   if(dayNumberNode)
   {
      if(dayNumberNode->Attribute("href") || dayNumberNode->Attribute("id"))
      {
          if(dayNumberNode->Attribute("id"))
          {
             dayNumberIDRef_ = dayNumberNode->Attribute("id");
             dayNumber_ = boost::shared_ptr<XsdTypeInteger>(new XsdTypeInteger(dayNumberNode));
             dayNumber_->setID(dayNumberIDRef_);
             IDManager::instance().setID(dayNumberIDRef_,dayNumber_);
          }
          else if(dayNumberNode->Attribute("href")) { dayNumberIDRef_ = dayNumberNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dayNumber_ = boost::shared_ptr<XsdTypeInteger>(new XsdTypeInteger(dayNumberNode));}
   }

   //businessCalendarNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* businessCalendarNode = xmlNode->FirstChildElement("businessCalendar");

   if(businessCalendarNode){businessCalendarIsNull_ = false;}
   else{businessCalendarIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessCalendarNode , address : " << businessCalendarNode << std::endl;
   #endif
   if(businessCalendarNode)
   {
      if(businessCalendarNode->Attribute("href") || businessCalendarNode->Attribute("id"))
      {
          if(businessCalendarNode->Attribute("id"))
          {
             businessCalendarIDRef_ = businessCalendarNode->Attribute("id");
             businessCalendar_ = boost::shared_ptr<CommodityBusinessCalendar>(new CommodityBusinessCalendar(businessCalendarNode));
             businessCalendar_->setID(businessCalendarIDRef_);
             IDManager::instance().setID(businessCalendarIDRef_,businessCalendar_);
          }
          else if(businessCalendarNode->Attribute("href")) { businessCalendarIDRef_ = businessCalendarNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { businessCalendar_ = boost::shared_ptr<CommodityBusinessCalendar>(new CommodityBusinessCalendar(businessCalendarNode));}
   }

   //calendarSourceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calendarSourceNode = xmlNode->FirstChildElement("calendarSource");

   if(calendarSourceNode){calendarSourceIsNull_ = false;}
   else{calendarSourceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calendarSourceNode , address : " << calendarSourceNode << std::endl;
   #endif
   if(calendarSourceNode)
   {
      if(calendarSourceNode->Attribute("href") || calendarSourceNode->Attribute("id"))
      {
          if(calendarSourceNode->Attribute("id"))
          {
             calendarSourceIDRef_ = calendarSourceNode->Attribute("id");
             calendarSource_ = boost::shared_ptr<CalendarSourceEnum>(new CalendarSourceEnum(calendarSourceNode));
             calendarSource_->setID(calendarSourceIDRef_);
             IDManager::instance().setID(calendarSourceIDRef_,calendarSource_);
          }
          else if(calendarSourceNode->Attribute("href")) { calendarSourceIDRef_ = calendarSourceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calendarSource_ = boost::shared_ptr<CalendarSourceEnum>(new CalendarSourceEnum(calendarSourceNode));}
   }

   //settlementPeriodsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementPeriodsNode = xmlNode->FirstChildElement("settlementPeriods");

   if(settlementPeriodsNode){settlementPeriodsIsNull_ = false;}
   else{settlementPeriodsIsNull_ = true;}

   if(settlementPeriodsNode)
   {
      for(settlementPeriodsNode; settlementPeriodsNode; settlementPeriodsNode = settlementPeriodsNode->NextSiblingElement("settlementPeriods")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementPeriodsNode , address : " << settlementPeriodsNode << std::endl;
          #endif
          if(settlementPeriodsNode->Attribute("href") || settlementPeriodsNode->Attribute("id"))
          {
              if(settlementPeriodsNode->Attribute("id"))
              {
                  settlementPeriodsIDRef_ = settlementPeriodsNode->Attribute("id");
                  settlementPeriods_.push_back(boost::shared_ptr<SettlementPeriods>(new SettlementPeriods(settlementPeriodsNode)));
                  settlementPeriods_.back()->setID(settlementPeriodsIDRef_);
                  IDManager::instance().setID(settlementPeriodsIDRef_, settlementPeriods_.back());
              }
              else if(settlementPeriodsNode->Attribute("href")) { settlementPeriodsIDRef_ = settlementPeriodsNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { settlementPeriods_.push_back(boost::shared_ptr<SettlementPeriods>(new SettlementPeriods(settlementPeriodsNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementPeriodsNode , address : " << settlementPeriodsNode << std::endl;
       #endif
   }

   //settlementPeriodsReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementPeriodsReferenceNode = xmlNode->FirstChildElement("settlementPeriodsReference");

   if(settlementPeriodsReferenceNode){settlementPeriodsReferenceIsNull_ = false;}
   else{settlementPeriodsReferenceIsNull_ = true;}

   if(settlementPeriodsReferenceNode)
   {
      for(settlementPeriodsReferenceNode; settlementPeriodsReferenceNode; settlementPeriodsReferenceNode = settlementPeriodsReferenceNode->NextSiblingElement("settlementPeriodsReference")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementPeriodsReferenceNode , address : " << settlementPeriodsReferenceNode << std::endl;
          #endif
          if(settlementPeriodsReferenceNode->Attribute("href") || settlementPeriodsReferenceNode->Attribute("id"))
          {
              if(settlementPeriodsReferenceNode->Attribute("id"))
              {
                  settlementPeriodsReferenceIDRef_ = settlementPeriodsReferenceNode->Attribute("id");
                  settlementPeriodsReference_.push_back(boost::shared_ptr<SettlementPeriodsReference>(new SettlementPeriodsReference(settlementPeriodsReferenceNode)));
                  settlementPeriodsReference_.back()->setID(settlementPeriodsReferenceIDRef_);
                  IDManager::instance().setID(settlementPeriodsReferenceIDRef_, settlementPeriodsReference_.back());
              }
              else if(settlementPeriodsReferenceNode->Attribute("href")) { settlementPeriodsReferenceIDRef_ = settlementPeriodsReferenceNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { settlementPeriodsReference_.push_back(boost::shared_ptr<SettlementPeriodsReference>(new SettlementPeriodsReference(settlementPeriodsReferenceNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementPeriodsReferenceNode , address : " << settlementPeriodsReferenceNode << std::endl;
       #endif
   }

   //pricingDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* pricingDatesNode = xmlNode->FirstChildElement("pricingDates");

   if(pricingDatesNode){pricingDatesIsNull_ = false;}
   else{pricingDatesIsNull_ = true;}

   if(pricingDatesNode)
   {
      for(pricingDatesNode; pricingDatesNode; pricingDatesNode = pricingDatesNode->NextSiblingElement("pricingDates")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- pricingDatesNode , address : " << pricingDatesNode << std::endl;
          #endif
          if(pricingDatesNode->Attribute("href") || pricingDatesNode->Attribute("id"))
          {
              if(pricingDatesNode->Attribute("id"))
              {
                  pricingDatesIDRef_ = pricingDatesNode->Attribute("id");
                  pricingDates_.push_back(boost::shared_ptr<AdjustableDates>(new AdjustableDates(pricingDatesNode)));
                  pricingDates_.back()->setID(pricingDatesIDRef_);
                  IDManager::instance().setID(pricingDatesIDRef_, pricingDates_.back());
              }
              else if(pricingDatesNode->Attribute("href")) { pricingDatesIDRef_ = pricingDatesNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { pricingDates_.push_back(boost::shared_ptr<AdjustableDates>(new AdjustableDates(pricingDatesNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- pricingDatesNode , address : " << pricingDatesNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CalculationPeriodsReference> CommodityPricingDates::getCalculationPeriodsReference()
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
boost::shared_ptr<CalculationPeriodsScheduleReference> CommodityPricingDates::getCalculationPeriodsScheduleReference()
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
boost::shared_ptr<CalculationPeriodsDatesReference> CommodityPricingDates::getCalculationPeriodsDatesReference()
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
boost::shared_ptr<Lag> CommodityPricingDates::getLag()
{
   if(!this->lagIsNull_){
        if(lagIDRef_ != ""){
             return boost::shared_static_cast<Lag>(IDManager::instance().getID(lagIDRef_));
        }else{
             return this->lag_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Lag>();
   }
}
boost::shared_ptr<CommodityDayTypeEnum> CommodityPricingDates::getDayType()
{
   if(!this->dayTypeIsNull_){
        if(dayTypeIDRef_ != ""){
             return boost::shared_static_cast<CommodityDayTypeEnum>(IDManager::instance().getID(dayTypeIDRef_));
        }else{
             return this->dayType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityDayTypeEnum>();
   }
}
boost::shared_ptr<CommodityFrequencyType> CommodityPricingDates::getDayDistribution()
{
   if(!this->dayDistributionIsNull_){
        if(dayDistributionIDRef_ != ""){
             return boost::shared_static_cast<CommodityFrequencyType>(IDManager::instance().getID(dayDistributionIDRef_));
        }else{
             return this->dayDistribution_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityFrequencyType>();
   }
}
boost::shared_ptr<XsdTypePositiveInteger> CommodityPricingDates::getDayCount()
{
   if(!this->dayCountIsNull_){
        if(dayCountIDRef_ != ""){
             return boost::shared_static_cast<XsdTypePositiveInteger>(IDManager::instance().getID(dayCountIDRef_));
        }else{
             return this->dayCount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypePositiveInteger>();
   }
}
std::vector<boost::shared_ptr<DayOfWeekEnum>> CommodityPricingDates::getDayOfWeek()
{
   if(!this->dayOfWeekIsNull_){
        if(dayOfWeekIDRef_ != ""){
             return this->dayOfWeek_;
        }else{
             return this->dayOfWeek_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<DayOfWeekEnum>>();
   }
}
boost::shared_ptr<XsdTypeInteger> CommodityPricingDates::getDayNumber()
{
   if(!this->dayNumberIsNull_){
        if(dayNumberIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeInteger>(IDManager::instance().getID(dayNumberIDRef_));
        }else{
             return this->dayNumber_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeInteger>();
   }
}
boost::shared_ptr<CommodityBusinessCalendar> CommodityPricingDates::getBusinessCalendar()
{
   if(!this->businessCalendarIsNull_){
        if(businessCalendarIDRef_ != ""){
             return boost::shared_static_cast<CommodityBusinessCalendar>(IDManager::instance().getID(businessCalendarIDRef_));
        }else{
             return this->businessCalendar_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityBusinessCalendar>();
   }
}
boost::shared_ptr<CalendarSourceEnum> CommodityPricingDates::getCalendarSource()
{
   if(!this->calendarSourceIsNull_){
        if(calendarSourceIDRef_ != ""){
             return boost::shared_static_cast<CalendarSourceEnum>(IDManager::instance().getID(calendarSourceIDRef_));
        }else{
             return this->calendarSource_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CalendarSourceEnum>();
   }
}
std::vector<boost::shared_ptr<SettlementPeriods>> CommodityPricingDates::getSettlementPeriods()
{
   if(!this->settlementPeriodsIsNull_){
        if(settlementPeriodsIDRef_ != ""){
             return this->settlementPeriods_;
        }else{
             return this->settlementPeriods_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<SettlementPeriods>>();
   }
}
std::vector<boost::shared_ptr<SettlementPeriodsReference>> CommodityPricingDates::getSettlementPeriodsReference()
{
   if(!this->settlementPeriodsReferenceIsNull_){
        if(settlementPeriodsReferenceIDRef_ != ""){
             return this->settlementPeriodsReference_;
        }else{
             return this->settlementPeriodsReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<SettlementPeriodsReference>>();
   }
}
std::vector<boost::shared_ptr<AdjustableDates>> CommodityPricingDates::getPricingDates()
{
   if(!this->pricingDatesIsNull_){
        if(pricingDatesIDRef_ != ""){
             return this->pricingDates_;
        }else{
             return this->pricingDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<AdjustableDates>>();
   }
}
}

