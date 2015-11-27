// CommodityFx.cpp 
#include "CommodityFx.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CommodityFx::CommodityFx(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //primaryRateSourceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* primaryRateSourceNode = xmlNode->FirstChildElement("primaryRateSource");

   if(primaryRateSourceNode){primaryRateSourceIsNull_ = false;}
   else{primaryRateSourceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- primaryRateSourceNode , address : " << primaryRateSourceNode << std::endl;
   #endif
   if(primaryRateSourceNode)
   {
      if(primaryRateSourceNode->Attribute("href") || primaryRateSourceNode->Attribute("id"))
      {
          if(primaryRateSourceNode->Attribute("id"))
          {
             primaryRateSourceIDRef_ = primaryRateSourceNode->Attribute("id");
             primaryRateSource_ = boost::shared_ptr<InformationSource>(new InformationSource(primaryRateSourceNode));
             primaryRateSource_->setID(primaryRateSourceIDRef_);
             IDManager::instance().setID(primaryRateSourceIDRef_,primaryRateSource_);
          }
          else if(primaryRateSourceNode->Attribute("href")) { primaryRateSourceIDRef_ = primaryRateSourceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { primaryRateSource_ = boost::shared_ptr<InformationSource>(new InformationSource(primaryRateSourceNode));}
   }

   //secondaryRateSourceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* secondaryRateSourceNode = xmlNode->FirstChildElement("secondaryRateSource");

   if(secondaryRateSourceNode){secondaryRateSourceIsNull_ = false;}
   else{secondaryRateSourceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- secondaryRateSourceNode , address : " << secondaryRateSourceNode << std::endl;
   #endif
   if(secondaryRateSourceNode)
   {
      if(secondaryRateSourceNode->Attribute("href") || secondaryRateSourceNode->Attribute("id"))
      {
          if(secondaryRateSourceNode->Attribute("id"))
          {
             secondaryRateSourceIDRef_ = secondaryRateSourceNode->Attribute("id");
             secondaryRateSource_ = boost::shared_ptr<InformationSource>(new InformationSource(secondaryRateSourceNode));
             secondaryRateSource_->setID(secondaryRateSourceIDRef_);
             IDManager::instance().setID(secondaryRateSourceIDRef_,secondaryRateSource_);
          }
          else if(secondaryRateSourceNode->Attribute("href")) { secondaryRateSourceIDRef_ = secondaryRateSourceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { secondaryRateSource_ = boost::shared_ptr<InformationSource>(new InformationSource(secondaryRateSourceNode));}
   }

   //fxTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fxTypeNode = xmlNode->FirstChildElement("fxType");

   if(fxTypeNode){fxTypeIsNull_ = false;}
   else{fxTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fxTypeNode , address : " << fxTypeNode << std::endl;
   #endif
   if(fxTypeNode)
   {
      if(fxTypeNode->Attribute("href") || fxTypeNode->Attribute("id"))
      {
          if(fxTypeNode->Attribute("id"))
          {
             fxTypeIDRef_ = fxTypeNode->Attribute("id");
             fxType_ = boost::shared_ptr<CommodityFxType>(new CommodityFxType(fxTypeNode));
             fxType_->setID(fxTypeIDRef_);
             IDManager::instance().setID(fxTypeIDRef_,fxType_);
          }
          else if(fxTypeNode->Attribute("href")) { fxTypeIDRef_ = fxTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fxType_ = boost::shared_ptr<CommodityFxType>(new CommodityFxType(fxTypeNode));}
   }

   //averagingMethodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* averagingMethodNode = xmlNode->FirstChildElement("averagingMethod");

   if(averagingMethodNode){averagingMethodIsNull_ = false;}
   else{averagingMethodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- averagingMethodNode , address : " << averagingMethodNode << std::endl;
   #endif
   if(averagingMethodNode)
   {
      if(averagingMethodNode->Attribute("href") || averagingMethodNode->Attribute("id"))
      {
          if(averagingMethodNode->Attribute("id"))
          {
             averagingMethodIDRef_ = averagingMethodNode->Attribute("id");
             averagingMethod_ = boost::shared_ptr<AveragingMethodEnum>(new AveragingMethodEnum(averagingMethodNode));
             averagingMethod_->setID(averagingMethodIDRef_);
             IDManager::instance().setID(averagingMethodIDRef_,averagingMethod_);
          }
          else if(averagingMethodNode->Attribute("href")) { averagingMethodIDRef_ = averagingMethodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { averagingMethod_ = boost::shared_ptr<AveragingMethodEnum>(new AveragingMethodEnum(averagingMethodNode));}
   }

   //fixingTimeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixingTimeNode = xmlNode->FirstChildElement("fixingTime");

   if(fixingTimeNode){fixingTimeIsNull_ = false;}
   else{fixingTimeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixingTimeNode , address : " << fixingTimeNode << std::endl;
   #endif
   if(fixingTimeNode)
   {
      if(fixingTimeNode->Attribute("href") || fixingTimeNode->Attribute("id"))
      {
          if(fixingTimeNode->Attribute("id"))
          {
             fixingTimeIDRef_ = fixingTimeNode->Attribute("id");
             fixingTime_ = boost::shared_ptr<BusinessCenterTime>(new BusinessCenterTime(fixingTimeNode));
             fixingTime_->setID(fixingTimeIDRef_);
             IDManager::instance().setID(fixingTimeIDRef_,fixingTime_);
          }
          else if(fixingTimeNode->Attribute("href")) { fixingTimeIDRef_ = fixingTimeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fixingTime_ = boost::shared_ptr<BusinessCenterTime>(new BusinessCenterTime(fixingTimeNode));}
   }

   //fxObservationDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fxObservationDatesNode = xmlNode->FirstChildElement("fxObservationDates");

   if(fxObservationDatesNode){fxObservationDatesIsNull_ = false;}
   else{fxObservationDatesIsNull_ = true;}

   if(fxObservationDatesNode)
   {
      for(fxObservationDatesNode; fxObservationDatesNode; fxObservationDatesNode = fxObservationDatesNode->NextSiblingElement("fxObservationDates")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fxObservationDatesNode , address : " << fxObservationDatesNode << std::endl;
          #endif
          if(fxObservationDatesNode->Attribute("href") || fxObservationDatesNode->Attribute("id"))
          {
              if(fxObservationDatesNode->Attribute("id"))
              {
                  fxObservationDatesIDRef_ = fxObservationDatesNode->Attribute("id");
                  fxObservationDates_.push_back(boost::shared_ptr<AdjustableDates>(new AdjustableDates(fxObservationDatesNode)));
                  fxObservationDates_.back()->setID(fxObservationDatesIDRef_);
                  IDManager::instance().setID(fxObservationDatesIDRef_, fxObservationDates_.back());
              }
              else if(fxObservationDatesNode->Attribute("href")) { fxObservationDatesIDRef_ = fxObservationDatesNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { fxObservationDates_.push_back(boost::shared_ptr<AdjustableDates>(new AdjustableDates(fxObservationDatesNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fxObservationDatesNode , address : " << fxObservationDatesNode << std::endl;
       #endif
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

   //lagReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* lagReferenceNode = xmlNode->FirstChildElement("lagReference");

   if(lagReferenceNode){lagReferenceIsNull_ = false;}
   else{lagReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- lagReferenceNode , address : " << lagReferenceNode << std::endl;
   #endif
   if(lagReferenceNode)
   {
      if(lagReferenceNode->Attribute("href") || lagReferenceNode->Attribute("id"))
      {
          if(lagReferenceNode->Attribute("id"))
          {
             lagReferenceIDRef_ = lagReferenceNode->Attribute("id");
             lagReference_ = boost::shared_ptr<LagReference>(new LagReference(lagReferenceNode));
             lagReference_->setID(lagReferenceIDRef_);
             IDManager::instance().setID(lagReferenceIDRef_,lagReference_);
          }
          else if(lagReferenceNode->Attribute("href")) { lagReferenceIDRef_ = lagReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { lagReference_ = boost::shared_ptr<LagReference>(new LagReference(lagReferenceNode));}
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
boost::shared_ptr<InformationSource> CommodityFx::getPrimaryRateSource()
{
   if(!this->primaryRateSourceIsNull_){
        if(primaryRateSourceIDRef_ != ""){
             return boost::shared_static_cast<InformationSource>(IDManager::instance().getID(primaryRateSourceIDRef_));
        }else{
             return this->primaryRateSource_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<InformationSource>();
   }
}
boost::shared_ptr<InformationSource> CommodityFx::getSecondaryRateSource()
{
   if(!this->secondaryRateSourceIsNull_){
        if(secondaryRateSourceIDRef_ != ""){
             return boost::shared_static_cast<InformationSource>(IDManager::instance().getID(secondaryRateSourceIDRef_));
        }else{
             return this->secondaryRateSource_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<InformationSource>();
   }
}
boost::shared_ptr<CommodityFxType> CommodityFx::getFxType()
{
   if(!this->fxTypeIsNull_){
        if(fxTypeIDRef_ != ""){
             return boost::shared_static_cast<CommodityFxType>(IDManager::instance().getID(fxTypeIDRef_));
        }else{
             return this->fxType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityFxType>();
   }
}
boost::shared_ptr<AveragingMethodEnum> CommodityFx::getAveragingMethod()
{
   if(!this->averagingMethodIsNull_){
        if(averagingMethodIDRef_ != ""){
             return boost::shared_static_cast<AveragingMethodEnum>(IDManager::instance().getID(averagingMethodIDRef_));
        }else{
             return this->averagingMethod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AveragingMethodEnum>();
   }
}
boost::shared_ptr<BusinessCenterTime> CommodityFx::getFixingTime()
{
   if(!this->fixingTimeIsNull_){
        if(fixingTimeIDRef_ != ""){
             return boost::shared_static_cast<BusinessCenterTime>(IDManager::instance().getID(fixingTimeIDRef_));
        }else{
             return this->fixingTime_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessCenterTime>();
   }
}
std::vector<boost::shared_ptr<AdjustableDates>> CommodityFx::getFxObservationDates()
{
   if(!this->fxObservationDatesIsNull_){
        if(fxObservationDatesIDRef_ != ""){
             return this->fxObservationDates_;
        }else{
             return this->fxObservationDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<AdjustableDates>>();
   }
}
boost::shared_ptr<CommodityDayTypeEnum> CommodityFx::getDayType()
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
boost::shared_ptr<CommodityFrequencyType> CommodityFx::getDayDistribution()
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
boost::shared_ptr<XsdTypePositiveInteger> CommodityFx::getDayCount()
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
std::vector<boost::shared_ptr<DayOfWeekEnum>> CommodityFx::getDayOfWeek()
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
boost::shared_ptr<XsdTypeInteger> CommodityFx::getDayNumber()
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
boost::shared_ptr<Lag> CommodityFx::getLag()
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
boost::shared_ptr<LagReference> CommodityFx::getLagReference()
{
   if(!this->lagReferenceIsNull_){
        if(lagReferenceIDRef_ != ""){
             return boost::shared_static_cast<LagReference>(IDManager::instance().getID(lagReferenceIDRef_));
        }else{
             return this->lagReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<LagReference>();
   }
}
boost::shared_ptr<CalculationPeriodsReference> CommodityFx::getCalculationPeriodsReference()
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
boost::shared_ptr<CalculationPeriodsScheduleReference> CommodityFx::getCalculationPeriodsScheduleReference()
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
boost::shared_ptr<CalculationPeriodsDatesReference> CommodityFx::getCalculationPeriodsDatesReference()
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

