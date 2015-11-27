// FxAsianFeature.cpp 
#include "FxAsianFeature.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FxAsianFeature::FxAsianFeature(TiXmlNode* xmlNode)
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

   //observationScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* observationScheduleNode = xmlNode->FirstChildElement("observationSchedule");

   if(observationScheduleNode){observationScheduleIsNull_ = false;}
   else{observationScheduleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- observationScheduleNode , address : " << observationScheduleNode << std::endl;
   #endif
   if(observationScheduleNode)
   {
      if(observationScheduleNode->Attribute("href") || observationScheduleNode->Attribute("id"))
      {
          if(observationScheduleNode->Attribute("id"))
          {
             observationScheduleIDRef_ = observationScheduleNode->Attribute("id");
             observationSchedule_ = boost::shared_ptr<FxAverageRateObservationSchedule>(new FxAverageRateObservationSchedule(observationScheduleNode));
             observationSchedule_->setID(observationScheduleIDRef_);
             IDManager::instance().setID(observationScheduleIDRef_,observationSchedule_);
          }
          else if(observationScheduleNode->Attribute("href")) { observationScheduleIDRef_ = observationScheduleNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { observationSchedule_ = boost::shared_ptr<FxAverageRateObservationSchedule>(new FxAverageRateObservationSchedule(observationScheduleNode));}
   }

   //rateObservationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* rateObservationNode = xmlNode->FirstChildElement("rateObservation");

   if(rateObservationNode){rateObservationIsNull_ = false;}
   else{rateObservationIsNull_ = true;}

   if(rateObservationNode)
   {
      for(rateObservationNode; rateObservationNode; rateObservationNode = rateObservationNode->NextSiblingElement("rateObservation")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rateObservationNode , address : " << rateObservationNode << std::endl;
          #endif
          if(rateObservationNode->Attribute("href") || rateObservationNode->Attribute("id"))
          {
              if(rateObservationNode->Attribute("id"))
              {
                  rateObservationIDRef_ = rateObservationNode->Attribute("id");
                  rateObservation_.push_back(boost::shared_ptr<FxAverageRateObservation>(new FxAverageRateObservation(rateObservationNode)));
                  rateObservation_.back()->setID(rateObservationIDRef_);
                  IDManager::instance().setID(rateObservationIDRef_, rateObservation_.back());
              }
              else if(rateObservationNode->Attribute("href")) { rateObservationIDRef_ = rateObservationNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { rateObservation_.push_back(boost::shared_ptr<FxAverageRateObservation>(new FxAverageRateObservation(rateObservationNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rateObservationNode , address : " << rateObservationNode << std::endl;
       #endif
   }

   //rateObservationQuoteBasisNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* rateObservationQuoteBasisNode = xmlNode->FirstChildElement("rateObservationQuoteBasis");

   if(rateObservationQuoteBasisNode){rateObservationQuoteBasisIsNull_ = false;}
   else{rateObservationQuoteBasisIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rateObservationQuoteBasisNode , address : " << rateObservationQuoteBasisNode << std::endl;
   #endif
   if(rateObservationQuoteBasisNode)
   {
      if(rateObservationQuoteBasisNode->Attribute("href") || rateObservationQuoteBasisNode->Attribute("id"))
      {
          if(rateObservationQuoteBasisNode->Attribute("id"))
          {
             rateObservationQuoteBasisIDRef_ = rateObservationQuoteBasisNode->Attribute("id");
             rateObservationQuoteBasis_ = boost::shared_ptr<StrikeQuoteBasisEnum>(new StrikeQuoteBasisEnum(rateObservationQuoteBasisNode));
             rateObservationQuoteBasis_->setID(rateObservationQuoteBasisIDRef_);
             IDManager::instance().setID(rateObservationQuoteBasisIDRef_,rateObservationQuoteBasis_);
          }
          else if(rateObservationQuoteBasisNode->Attribute("href")) { rateObservationQuoteBasisIDRef_ = rateObservationQuoteBasisNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { rateObservationQuoteBasis_ = boost::shared_ptr<StrikeQuoteBasisEnum>(new StrikeQuoteBasisEnum(rateObservationQuoteBasisNode));}
   }

   //payoutFormulaNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* payoutFormulaNode = xmlNode->FirstChildElement("payoutFormula");

   if(payoutFormulaNode){payoutFormulaIsNull_ = false;}
   else{payoutFormulaIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- payoutFormulaNode , address : " << payoutFormulaNode << std::endl;
   #endif
   if(payoutFormulaNode)
   {
      if(payoutFormulaNode->Attribute("href") || payoutFormulaNode->Attribute("id"))
      {
          if(payoutFormulaNode->Attribute("id"))
          {
             payoutFormulaIDRef_ = payoutFormulaNode->Attribute("id");
             payoutFormula_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(payoutFormulaNode));
             payoutFormula_->setID(payoutFormulaIDRef_);
             IDManager::instance().setID(payoutFormulaIDRef_,payoutFormula_);
          }
          else if(payoutFormulaNode->Attribute("href")) { payoutFormulaIDRef_ = payoutFormulaNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { payoutFormula_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(payoutFormulaNode));}
   }

   //precisionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* precisionNode = xmlNode->FirstChildElement("precision");

   if(precisionNode){precisionIsNull_ = false;}
   else{precisionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- precisionNode , address : " << precisionNode << std::endl;
   #endif
   if(precisionNode)
   {
      if(precisionNode->Attribute("href") || precisionNode->Attribute("id"))
      {
          if(precisionNode->Attribute("id"))
          {
             precisionIDRef_ = precisionNode->Attribute("id");
             precision_ = boost::shared_ptr<XsdTypeNonNegativeInteger>(new XsdTypeNonNegativeInteger(precisionNode));
             precision_->setID(precisionIDRef_);
             IDManager::instance().setID(precisionIDRef_,precision_);
          }
          else if(precisionNode->Attribute("href")) { precisionIDRef_ = precisionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { precision_ = boost::shared_ptr<XsdTypeNonNegativeInteger>(new XsdTypeNonNegativeInteger(precisionNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<InformationSource> FxAsianFeature::getPrimaryRateSource()
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
boost::shared_ptr<InformationSource> FxAsianFeature::getSecondaryRateSource()
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
boost::shared_ptr<BusinessCenterTime> FxAsianFeature::getFixingTime()
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
boost::shared_ptr<FxAverageRateObservationSchedule> FxAsianFeature::getObservationSchedule()
{
   if(!this->observationScheduleIsNull_){
        if(observationScheduleIDRef_ != ""){
             return boost::shared_static_cast<FxAverageRateObservationSchedule>(IDManager::instance().getID(observationScheduleIDRef_));
        }else{
             return this->observationSchedule_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FxAverageRateObservationSchedule>();
   }
}
std::vector<boost::shared_ptr<FxAverageRateObservation>> FxAsianFeature::getRateObservation()
{
   if(!this->rateObservationIsNull_){
        if(rateObservationIDRef_ != ""){
             return this->rateObservation_;
        }else{
             return this->rateObservation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<FxAverageRateObservation>>();
   }
}
boost::shared_ptr<StrikeQuoteBasisEnum> FxAsianFeature::getRateObservationQuoteBasis()
{
   if(!this->rateObservationQuoteBasisIsNull_){
        if(rateObservationQuoteBasisIDRef_ != ""){
             return boost::shared_static_cast<StrikeQuoteBasisEnum>(IDManager::instance().getID(rateObservationQuoteBasisIDRef_));
        }else{
             return this->rateObservationQuoteBasis_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<StrikeQuoteBasisEnum>();
   }
}
boost::shared_ptr<XsdTypeString> FxAsianFeature::getPayoutFormula()
{
   if(!this->payoutFormulaIsNull_){
        if(payoutFormulaIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(payoutFormulaIDRef_));
        }else{
             return this->payoutFormula_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
boost::shared_ptr<XsdTypeNonNegativeInteger> FxAsianFeature::getPrecision()
{
   if(!this->precisionIsNull_){
        if(precisionIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeNonNegativeInteger>(IDManager::instance().getID(precisionIDRef_));
        }else{
             return this->precision_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeNonNegativeInteger>();
   }
}
}

