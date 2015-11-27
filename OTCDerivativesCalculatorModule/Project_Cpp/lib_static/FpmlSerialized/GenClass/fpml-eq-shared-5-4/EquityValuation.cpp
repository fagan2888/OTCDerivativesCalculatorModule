// EquityValuation.cpp 
#include "EquityValuation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EquityValuation::EquityValuation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //valuationDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* valuationDateNode = xmlNode->FirstChildElement("valuationDate");

   if(valuationDateNode){valuationDateIsNull_ = false;}
   else{valuationDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valuationDateNode , address : " << valuationDateNode << std::endl;
   #endif
   if(valuationDateNode)
   {
      if(valuationDateNode->Attribute("href") || valuationDateNode->Attribute("id"))
      {
          if(valuationDateNode->Attribute("id"))
          {
             valuationDateIDRef_ = valuationDateNode->Attribute("id");
             valuationDate_ = boost::shared_ptr<AdjustableDateOrRelativeDateSequence>(new AdjustableDateOrRelativeDateSequence(valuationDateNode));
             valuationDate_->setID(valuationDateIDRef_);
             IDManager::instance().setID(valuationDateIDRef_,valuationDate_);
          }
          else if(valuationDateNode->Attribute("href")) { valuationDateIDRef_ = valuationDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { valuationDate_ = boost::shared_ptr<AdjustableDateOrRelativeDateSequence>(new AdjustableDateOrRelativeDateSequence(valuationDateNode));}
   }

   //valuationDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* valuationDatesNode = xmlNode->FirstChildElement("valuationDates");

   if(valuationDatesNode){valuationDatesIsNull_ = false;}
   else{valuationDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valuationDatesNode , address : " << valuationDatesNode << std::endl;
   #endif
   if(valuationDatesNode)
   {
      if(valuationDatesNode->Attribute("href") || valuationDatesNode->Attribute("id"))
      {
          if(valuationDatesNode->Attribute("id"))
          {
             valuationDatesIDRef_ = valuationDatesNode->Attribute("id");
             valuationDates_ = boost::shared_ptr<AdjustableRelativeOrPeriodicDates>(new AdjustableRelativeOrPeriodicDates(valuationDatesNode));
             valuationDates_->setID(valuationDatesIDRef_);
             IDManager::instance().setID(valuationDatesIDRef_,valuationDates_);
          }
          else if(valuationDatesNode->Attribute("href")) { valuationDatesIDRef_ = valuationDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { valuationDates_ = boost::shared_ptr<AdjustableRelativeOrPeriodicDates>(new AdjustableRelativeOrPeriodicDates(valuationDatesNode));}
   }

   //valuationTimeTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* valuationTimeTypeNode = xmlNode->FirstChildElement("valuationTimeType");

   if(valuationTimeTypeNode){valuationTimeTypeIsNull_ = false;}
   else{valuationTimeTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valuationTimeTypeNode , address : " << valuationTimeTypeNode << std::endl;
   #endif
   if(valuationTimeTypeNode)
   {
      if(valuationTimeTypeNode->Attribute("href") || valuationTimeTypeNode->Attribute("id"))
      {
          if(valuationTimeTypeNode->Attribute("id"))
          {
             valuationTimeTypeIDRef_ = valuationTimeTypeNode->Attribute("id");
             valuationTimeType_ = boost::shared_ptr<TimeTypeEnum>(new TimeTypeEnum(valuationTimeTypeNode));
             valuationTimeType_->setID(valuationTimeTypeIDRef_);
             IDManager::instance().setID(valuationTimeTypeIDRef_,valuationTimeType_);
          }
          else if(valuationTimeTypeNode->Attribute("href")) { valuationTimeTypeIDRef_ = valuationTimeTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { valuationTimeType_ = boost::shared_ptr<TimeTypeEnum>(new TimeTypeEnum(valuationTimeTypeNode));}
   }

   //valuationTimeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* valuationTimeNode = xmlNode->FirstChildElement("valuationTime");

   if(valuationTimeNode){valuationTimeIsNull_ = false;}
   else{valuationTimeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valuationTimeNode , address : " << valuationTimeNode << std::endl;
   #endif
   if(valuationTimeNode)
   {
      if(valuationTimeNode->Attribute("href") || valuationTimeNode->Attribute("id"))
      {
          if(valuationTimeNode->Attribute("id"))
          {
             valuationTimeIDRef_ = valuationTimeNode->Attribute("id");
             valuationTime_ = boost::shared_ptr<BusinessCenterTime>(new BusinessCenterTime(valuationTimeNode));
             valuationTime_->setID(valuationTimeIDRef_);
             IDManager::instance().setID(valuationTimeIDRef_,valuationTime_);
          }
          else if(valuationTimeNode->Attribute("href")) { valuationTimeIDRef_ = valuationTimeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { valuationTime_ = boost::shared_ptr<BusinessCenterTime>(new BusinessCenterTime(valuationTimeNode));}
   }

   //futuresPriceValuationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* futuresPriceValuationNode = xmlNode->FirstChildElement("futuresPriceValuation");

   if(futuresPriceValuationNode){futuresPriceValuationIsNull_ = false;}
   else{futuresPriceValuationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- futuresPriceValuationNode , address : " << futuresPriceValuationNode << std::endl;
   #endif
   if(futuresPriceValuationNode)
   {
      if(futuresPriceValuationNode->Attribute("href") || futuresPriceValuationNode->Attribute("id"))
      {
          if(futuresPriceValuationNode->Attribute("id"))
          {
             futuresPriceValuationIDRef_ = futuresPriceValuationNode->Attribute("id");
             futuresPriceValuation_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(futuresPriceValuationNode));
             futuresPriceValuation_->setID(futuresPriceValuationIDRef_);
             IDManager::instance().setID(futuresPriceValuationIDRef_,futuresPriceValuation_);
          }
          else if(futuresPriceValuationNode->Attribute("href")) { futuresPriceValuationIDRef_ = futuresPriceValuationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { futuresPriceValuation_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(futuresPriceValuationNode));}
   }

   //optionsPriceValuationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* optionsPriceValuationNode = xmlNode->FirstChildElement("optionsPriceValuation");

   if(optionsPriceValuationNode){optionsPriceValuationIsNull_ = false;}
   else{optionsPriceValuationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- optionsPriceValuationNode , address : " << optionsPriceValuationNode << std::endl;
   #endif
   if(optionsPriceValuationNode)
   {
      if(optionsPriceValuationNode->Attribute("href") || optionsPriceValuationNode->Attribute("id"))
      {
          if(optionsPriceValuationNode->Attribute("id"))
          {
             optionsPriceValuationIDRef_ = optionsPriceValuationNode->Attribute("id");
             optionsPriceValuation_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(optionsPriceValuationNode));
             optionsPriceValuation_->setID(optionsPriceValuationIDRef_);
             IDManager::instance().setID(optionsPriceValuationIDRef_,optionsPriceValuation_);
          }
          else if(optionsPriceValuationNode->Attribute("href")) { optionsPriceValuationIDRef_ = optionsPriceValuationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { optionsPriceValuation_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(optionsPriceValuationNode));}
   }

   //numberOfValuationDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* numberOfValuationDatesNode = xmlNode->FirstChildElement("numberOfValuationDates");

   if(numberOfValuationDatesNode){numberOfValuationDatesIsNull_ = false;}
   else{numberOfValuationDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- numberOfValuationDatesNode , address : " << numberOfValuationDatesNode << std::endl;
   #endif
   if(numberOfValuationDatesNode)
   {
      if(numberOfValuationDatesNode->Attribute("href") || numberOfValuationDatesNode->Attribute("id"))
      {
          if(numberOfValuationDatesNode->Attribute("id"))
          {
             numberOfValuationDatesIDRef_ = numberOfValuationDatesNode->Attribute("id");
             numberOfValuationDates_ = boost::shared_ptr<XsdTypeNonNegativeInteger>(new XsdTypeNonNegativeInteger(numberOfValuationDatesNode));
             numberOfValuationDates_->setID(numberOfValuationDatesIDRef_);
             IDManager::instance().setID(numberOfValuationDatesIDRef_,numberOfValuationDates_);
          }
          else if(numberOfValuationDatesNode->Attribute("href")) { numberOfValuationDatesIDRef_ = numberOfValuationDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { numberOfValuationDates_ = boost::shared_ptr<XsdTypeNonNegativeInteger>(new XsdTypeNonNegativeInteger(numberOfValuationDatesNode));}
   }

   //dividendValuationDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dividendValuationDatesNode = xmlNode->FirstChildElement("dividendValuationDates");

   if(dividendValuationDatesNode){dividendValuationDatesIsNull_ = false;}
   else{dividendValuationDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dividendValuationDatesNode , address : " << dividendValuationDatesNode << std::endl;
   #endif
   if(dividendValuationDatesNode)
   {
      if(dividendValuationDatesNode->Attribute("href") || dividendValuationDatesNode->Attribute("id"))
      {
          if(dividendValuationDatesNode->Attribute("id"))
          {
             dividendValuationDatesIDRef_ = dividendValuationDatesNode->Attribute("id");
             dividendValuationDates_ = boost::shared_ptr<AdjustableRelativeOrPeriodicDates>(new AdjustableRelativeOrPeriodicDates(dividendValuationDatesNode));
             dividendValuationDates_->setID(dividendValuationDatesIDRef_);
             IDManager::instance().setID(dividendValuationDatesIDRef_,dividendValuationDates_);
          }
          else if(dividendValuationDatesNode->Attribute("href")) { dividendValuationDatesIDRef_ = dividendValuationDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dividendValuationDates_ = boost::shared_ptr<AdjustableRelativeOrPeriodicDates>(new AdjustableRelativeOrPeriodicDates(dividendValuationDatesNode));}
   }

   //fPVFinalPriceElectionFallbackNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fPVFinalPriceElectionFallbackNode = xmlNode->FirstChildElement("fPVFinalPriceElectionFallback");

   if(fPVFinalPriceElectionFallbackNode){fPVFinalPriceElectionFallbackIsNull_ = false;}
   else{fPVFinalPriceElectionFallbackIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fPVFinalPriceElectionFallbackNode , address : " << fPVFinalPriceElectionFallbackNode << std::endl;
   #endif
   if(fPVFinalPriceElectionFallbackNode)
   {
      if(fPVFinalPriceElectionFallbackNode->Attribute("href") || fPVFinalPriceElectionFallbackNode->Attribute("id"))
      {
          if(fPVFinalPriceElectionFallbackNode->Attribute("id"))
          {
             fPVFinalPriceElectionFallbackIDRef_ = fPVFinalPriceElectionFallbackNode->Attribute("id");
             fPVFinalPriceElectionFallback_ = boost::shared_ptr<FPVFinalPriceElectionFallbackEnum>(new FPVFinalPriceElectionFallbackEnum(fPVFinalPriceElectionFallbackNode));
             fPVFinalPriceElectionFallback_->setID(fPVFinalPriceElectionFallbackIDRef_);
             IDManager::instance().setID(fPVFinalPriceElectionFallbackIDRef_,fPVFinalPriceElectionFallback_);
          }
          else if(fPVFinalPriceElectionFallbackNode->Attribute("href")) { fPVFinalPriceElectionFallbackIDRef_ = fPVFinalPriceElectionFallbackNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fPVFinalPriceElectionFallback_ = boost::shared_ptr<FPVFinalPriceElectionFallbackEnum>(new FPVFinalPriceElectionFallbackEnum(fPVFinalPriceElectionFallbackNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AdjustableDateOrRelativeDateSequence> EquityValuation::getValuationDate()
{
   if(!this->valuationDateIsNull_){
        if(valuationDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableDateOrRelativeDateSequence>(IDManager::instance().getID(valuationDateIDRef_));
        }else{
             return this->valuationDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableDateOrRelativeDateSequence>();
   }
}
boost::shared_ptr<AdjustableRelativeOrPeriodicDates> EquityValuation::getValuationDates()
{
   if(!this->valuationDatesIsNull_){
        if(valuationDatesIDRef_ != ""){
             return boost::shared_static_cast<AdjustableRelativeOrPeriodicDates>(IDManager::instance().getID(valuationDatesIDRef_));
        }else{
             return this->valuationDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableRelativeOrPeriodicDates>();
   }
}
boost::shared_ptr<TimeTypeEnum> EquityValuation::getValuationTimeType()
{
   if(!this->valuationTimeTypeIsNull_){
        if(valuationTimeTypeIDRef_ != ""){
             return boost::shared_static_cast<TimeTypeEnum>(IDManager::instance().getID(valuationTimeTypeIDRef_));
        }else{
             return this->valuationTimeType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TimeTypeEnum>();
   }
}
boost::shared_ptr<BusinessCenterTime> EquityValuation::getValuationTime()
{
   if(!this->valuationTimeIsNull_){
        if(valuationTimeIDRef_ != ""){
             return boost::shared_static_cast<BusinessCenterTime>(IDManager::instance().getID(valuationTimeIDRef_));
        }else{
             return this->valuationTime_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessCenterTime>();
   }
}
boost::shared_ptr<XsdTypeBoolean> EquityValuation::getFuturesPriceValuation()
{
   if(!this->futuresPriceValuationIsNull_){
        if(futuresPriceValuationIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(futuresPriceValuationIDRef_));
        }else{
             return this->futuresPriceValuation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> EquityValuation::getOptionsPriceValuation()
{
   if(!this->optionsPriceValuationIsNull_){
        if(optionsPriceValuationIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(optionsPriceValuationIDRef_));
        }else{
             return this->optionsPriceValuation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeNonNegativeInteger> EquityValuation::getNumberOfValuationDates()
{
   if(!this->numberOfValuationDatesIsNull_){
        if(numberOfValuationDatesIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeNonNegativeInteger>(IDManager::instance().getID(numberOfValuationDatesIDRef_));
        }else{
             return this->numberOfValuationDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeNonNegativeInteger>();
   }
}
boost::shared_ptr<AdjustableRelativeOrPeriodicDates> EquityValuation::getDividendValuationDates()
{
   if(!this->dividendValuationDatesIsNull_){
        if(dividendValuationDatesIDRef_ != ""){
             return boost::shared_static_cast<AdjustableRelativeOrPeriodicDates>(IDManager::instance().getID(dividendValuationDatesIDRef_));
        }else{
             return this->dividendValuationDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableRelativeOrPeriodicDates>();
   }
}
boost::shared_ptr<FPVFinalPriceElectionFallbackEnum> EquityValuation::getFPVFinalPriceElectionFallback()
{
   if(!this->fPVFinalPriceElectionFallbackIsNull_){
        if(fPVFinalPriceElectionFallbackIDRef_ != ""){
             return boost::shared_static_cast<FPVFinalPriceElectionFallbackEnum>(IDManager::instance().getID(fPVFinalPriceElectionFallbackIDRef_));
        }else{
             return this->fPVFinalPriceElectionFallback_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FPVFinalPriceElectionFallbackEnum>();
   }
}
}

