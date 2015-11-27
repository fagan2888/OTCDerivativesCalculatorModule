// FxBarrierFeature.cpp 
#include "FxBarrierFeature.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FxBarrierFeature::FxBarrierFeature(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //barrierTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* barrierTypeNode = xmlNode->FirstChildElement("barrierType");

   if(barrierTypeNode){barrierTypeIsNull_ = false;}
   else{barrierTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- barrierTypeNode , address : " << barrierTypeNode << std::endl;
   #endif
   if(barrierTypeNode)
   {
      if(barrierTypeNode->Attribute("href") || barrierTypeNode->Attribute("id"))
      {
          if(barrierTypeNode->Attribute("id"))
          {
             barrierTypeIDRef_ = barrierTypeNode->Attribute("id");
             barrierType_ = boost::shared_ptr<FxBarrierTypeEnum>(new FxBarrierTypeEnum(barrierTypeNode));
             barrierType_->setID(barrierTypeIDRef_);
             IDManager::instance().setID(barrierTypeIDRef_,barrierType_);
          }
          else if(barrierTypeNode->Attribute("href")) { barrierTypeIDRef_ = barrierTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { barrierType_ = boost::shared_ptr<FxBarrierTypeEnum>(new FxBarrierTypeEnum(barrierTypeNode));}
   }

   //quotedCurrencyPairNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* quotedCurrencyPairNode = xmlNode->FirstChildElement("quotedCurrencyPair");

   if(quotedCurrencyPairNode){quotedCurrencyPairIsNull_ = false;}
   else{quotedCurrencyPairIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- quotedCurrencyPairNode , address : " << quotedCurrencyPairNode << std::endl;
   #endif
   if(quotedCurrencyPairNode)
   {
      if(quotedCurrencyPairNode->Attribute("href") || quotedCurrencyPairNode->Attribute("id"))
      {
          if(quotedCurrencyPairNode->Attribute("id"))
          {
             quotedCurrencyPairIDRef_ = quotedCurrencyPairNode->Attribute("id");
             quotedCurrencyPair_ = boost::shared_ptr<QuotedCurrencyPair>(new QuotedCurrencyPair(quotedCurrencyPairNode));
             quotedCurrencyPair_->setID(quotedCurrencyPairIDRef_);
             IDManager::instance().setID(quotedCurrencyPairIDRef_,quotedCurrencyPair_);
          }
          else if(quotedCurrencyPairNode->Attribute("href")) { quotedCurrencyPairIDRef_ = quotedCurrencyPairNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { quotedCurrencyPair_ = boost::shared_ptr<QuotedCurrencyPair>(new QuotedCurrencyPair(quotedCurrencyPairNode));}
   }

   //triggerRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* triggerRateNode = xmlNode->FirstChildElement("triggerRate");

   if(triggerRateNode){triggerRateIsNull_ = false;}
   else{triggerRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- triggerRateNode , address : " << triggerRateNode << std::endl;
   #endif
   if(triggerRateNode)
   {
      if(triggerRateNode->Attribute("href") || triggerRateNode->Attribute("id"))
      {
          if(triggerRateNode->Attribute("id"))
          {
             triggerRateIDRef_ = triggerRateNode->Attribute("id");
             triggerRate_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(triggerRateNode));
             triggerRate_->setID(triggerRateIDRef_);
             IDManager::instance().setID(triggerRateIDRef_,triggerRate_);
          }
          else if(triggerRateNode->Attribute("href")) { triggerRateIDRef_ = triggerRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { triggerRate_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(triggerRateNode));}
   }

   //informationSourceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* informationSourceNode = xmlNode->FirstChildElement("informationSource");

   if(informationSourceNode){informationSourceIsNull_ = false;}
   else{informationSourceIsNull_ = true;}

   if(informationSourceNode)
   {
      for(informationSourceNode; informationSourceNode; informationSourceNode = informationSourceNode->NextSiblingElement("informationSource")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- informationSourceNode , address : " << informationSourceNode << std::endl;
          #endif
          if(informationSourceNode->Attribute("href") || informationSourceNode->Attribute("id"))
          {
              if(informationSourceNode->Attribute("id"))
              {
                  informationSourceIDRef_ = informationSourceNode->Attribute("id");
                  informationSource_.push_back(boost::shared_ptr<InformationSource>(new InformationSource(informationSourceNode)));
                  informationSource_.back()->setID(informationSourceIDRef_);
                  IDManager::instance().setID(informationSourceIDRef_, informationSource_.back());
              }
              else if(informationSourceNode->Attribute("href")) { informationSourceIDRef_ = informationSourceNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { informationSource_.push_back(boost::shared_ptr<InformationSource>(new InformationSource(informationSourceNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- informationSourceNode , address : " << informationSourceNode << std::endl;
       #endif
   }

   //observationStartDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* observationStartDateNode = xmlNode->FirstChildElement("observationStartDate");

   if(observationStartDateNode){observationStartDateIsNull_ = false;}
   else{observationStartDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- observationStartDateNode , address : " << observationStartDateNode << std::endl;
   #endif
   if(observationStartDateNode)
   {
      if(observationStartDateNode->Attribute("href") || observationStartDateNode->Attribute("id"))
      {
          if(observationStartDateNode->Attribute("id"))
          {
             observationStartDateIDRef_ = observationStartDateNode->Attribute("id");
             observationStartDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(observationStartDateNode));
             observationStartDate_->setID(observationStartDateIDRef_);
             IDManager::instance().setID(observationStartDateIDRef_,observationStartDate_);
          }
          else if(observationStartDateNode->Attribute("href")) { observationStartDateIDRef_ = observationStartDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { observationStartDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(observationStartDateNode));}
   }

   //observationEndDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* observationEndDateNode = xmlNode->FirstChildElement("observationEndDate");

   if(observationEndDateNode){observationEndDateIsNull_ = false;}
   else{observationEndDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- observationEndDateNode , address : " << observationEndDateNode << std::endl;
   #endif
   if(observationEndDateNode)
   {
      if(observationEndDateNode->Attribute("href") || observationEndDateNode->Attribute("id"))
      {
          if(observationEndDateNode->Attribute("id"))
          {
             observationEndDateIDRef_ = observationEndDateNode->Attribute("id");
             observationEndDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(observationEndDateNode));
             observationEndDate_->setID(observationEndDateIDRef_);
             IDManager::instance().setID(observationEndDateIDRef_,observationEndDate_);
          }
          else if(observationEndDateNode->Attribute("href")) { observationEndDateIDRef_ = observationEndDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { observationEndDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(observationEndDateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<FxBarrierTypeEnum> FxBarrierFeature::getBarrierType()
{
   if(!this->barrierTypeIsNull_){
        if(barrierTypeIDRef_ != ""){
             return boost::shared_static_cast<FxBarrierTypeEnum>(IDManager::instance().getID(barrierTypeIDRef_));
        }else{
             return this->barrierType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FxBarrierTypeEnum>();
   }
}
boost::shared_ptr<QuotedCurrencyPair> FxBarrierFeature::getQuotedCurrencyPair()
{
   if(!this->quotedCurrencyPairIsNull_){
        if(quotedCurrencyPairIDRef_ != ""){
             return boost::shared_static_cast<QuotedCurrencyPair>(IDManager::instance().getID(quotedCurrencyPairIDRef_));
        }else{
             return this->quotedCurrencyPair_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<QuotedCurrencyPair>();
   }
}
boost::shared_ptr<PositiveDecimal> FxBarrierFeature::getTriggerRate()
{
   if(!this->triggerRateIsNull_){
        if(triggerRateIDRef_ != ""){
             return boost::shared_static_cast<PositiveDecimal>(IDManager::instance().getID(triggerRateIDRef_));
        }else{
             return this->triggerRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PositiveDecimal>();
   }
}
std::vector<boost::shared_ptr<InformationSource>> FxBarrierFeature::getInformationSource()
{
   if(!this->informationSourceIsNull_){
        if(informationSourceIDRef_ != ""){
             return this->informationSource_;
        }else{
             return this->informationSource_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<InformationSource>>();
   }
}
boost::shared_ptr<XsdTypeDate> FxBarrierFeature::getObservationStartDate()
{
   if(!this->observationStartDateIsNull_){
        if(observationStartDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(observationStartDateIDRef_));
        }else{
             return this->observationStartDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> FxBarrierFeature::getObservationEndDate()
{
   if(!this->observationEndDateIsNull_){
        if(observationEndDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(observationEndDateIDRef_));
        }else{
             return this->observationEndDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
}

