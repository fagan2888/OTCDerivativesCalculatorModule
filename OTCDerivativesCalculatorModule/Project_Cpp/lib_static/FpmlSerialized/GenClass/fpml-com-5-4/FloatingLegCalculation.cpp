// FloatingLegCalculation.cpp 
#include "FloatingLegCalculation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FloatingLegCalculation::FloatingLegCalculation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //pricingDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* pricingDatesNode = xmlNode->FirstChildElement("pricingDates");

   if(pricingDatesNode){pricingDatesIsNull_ = false;}
   else{pricingDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- pricingDatesNode , address : " << pricingDatesNode << std::endl;
   #endif
   if(pricingDatesNode)
   {
      if(pricingDatesNode->Attribute("href") || pricingDatesNode->Attribute("id"))
      {
          if(pricingDatesNode->Attribute("id"))
          {
             pricingDatesIDRef_ = pricingDatesNode->Attribute("id");
             pricingDates_ = boost::shared_ptr<CommodityPricingDates>(new CommodityPricingDates(pricingDatesNode));
             pricingDates_->setID(pricingDatesIDRef_);
             IDManager::instance().setID(pricingDatesIDRef_,pricingDates_);
          }
          else if(pricingDatesNode->Attribute("href")) { pricingDatesIDRef_ = pricingDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { pricingDates_ = boost::shared_ptr<CommodityPricingDates>(new CommodityPricingDates(pricingDatesNode));}
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

   //conversionFactorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* conversionFactorNode = xmlNode->FirstChildElement("conversionFactor");

   if(conversionFactorNode){conversionFactorIsNull_ = false;}
   else{conversionFactorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- conversionFactorNode , address : " << conversionFactorNode << std::endl;
   #endif
   if(conversionFactorNode)
   {
      if(conversionFactorNode->Attribute("href") || conversionFactorNode->Attribute("id"))
      {
          if(conversionFactorNode->Attribute("id"))
          {
             conversionFactorIDRef_ = conversionFactorNode->Attribute("id");
             conversionFactor_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(conversionFactorNode));
             conversionFactor_->setID(conversionFactorIDRef_);
             IDManager::instance().setID(conversionFactorIDRef_,conversionFactor_);
          }
          else if(conversionFactorNode->Attribute("href")) { conversionFactorIDRef_ = conversionFactorNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { conversionFactor_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(conversionFactorNode));}
   }

   //roundingNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* roundingNode = xmlNode->FirstChildElement("rounding");

   if(roundingNode){roundingIsNull_ = false;}
   else{roundingIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- roundingNode , address : " << roundingNode << std::endl;
   #endif
   if(roundingNode)
   {
      if(roundingNode->Attribute("href") || roundingNode->Attribute("id"))
      {
          if(roundingNode->Attribute("id"))
          {
             roundingIDRef_ = roundingNode->Attribute("id");
             rounding_ = boost::shared_ptr<Rounding>(new Rounding(roundingNode));
             rounding_->setID(roundingIDRef_);
             IDManager::instance().setID(roundingIDRef_,rounding_);
          }
          else if(roundingNode->Attribute("href")) { roundingIDRef_ = roundingNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { rounding_ = boost::shared_ptr<Rounding>(new Rounding(roundingNode));}
   }

   //spreadNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* spreadNode = xmlNode->FirstChildElement("spread");

   if(spreadNode){spreadIsNull_ = false;}
   else{spreadIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- spreadNode , address : " << spreadNode << std::endl;
   #endif
   if(spreadNode)
   {
      if(spreadNode->Attribute("href") || spreadNode->Attribute("id"))
      {
          if(spreadNode->Attribute("id"))
          {
             spreadIDRef_ = spreadNode->Attribute("id");
             spread_ = boost::shared_ptr<CommoditySpread>(new CommoditySpread(spreadNode));
             spread_->setID(spreadIDRef_);
             IDManager::instance().setID(spreadIDRef_,spread_);
          }
          else if(spreadNode->Attribute("href")) { spreadIDRef_ = spreadNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { spread_ = boost::shared_ptr<CommoditySpread>(new CommoditySpread(spreadNode));}
   }

   //spreadScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* spreadScheduleNode = xmlNode->FirstChildElement("spreadSchedule");

   if(spreadScheduleNode){spreadScheduleIsNull_ = false;}
   else{spreadScheduleIsNull_ = true;}

   if(spreadScheduleNode)
   {
      for(spreadScheduleNode; spreadScheduleNode; spreadScheduleNode = spreadScheduleNode->NextSiblingElement("spreadSchedule")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- spreadScheduleNode , address : " << spreadScheduleNode << std::endl;
          #endif
          if(spreadScheduleNode->Attribute("href") || spreadScheduleNode->Attribute("id"))
          {
              if(spreadScheduleNode->Attribute("id"))
              {
                  spreadScheduleIDRef_ = spreadScheduleNode->Attribute("id");
                  spreadSchedule_.push_back(boost::shared_ptr<CommoditySpreadSchedule>(new CommoditySpreadSchedule(spreadScheduleNode)));
                  spreadSchedule_.back()->setID(spreadScheduleIDRef_);
                  IDManager::instance().setID(spreadScheduleIDRef_, spreadSchedule_.back());
              }
              else if(spreadScheduleNode->Attribute("href")) { spreadScheduleIDRef_ = spreadScheduleNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { spreadSchedule_.push_back(boost::shared_ptr<CommoditySpreadSchedule>(new CommoditySpreadSchedule(spreadScheduleNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- spreadScheduleNode , address : " << spreadScheduleNode << std::endl;
       #endif
   }

   //spreadPercentageNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* spreadPercentageNode = xmlNode->FirstChildElement("spreadPercentage");

   if(spreadPercentageNode){spreadPercentageIsNull_ = false;}
   else{spreadPercentageIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- spreadPercentageNode , address : " << spreadPercentageNode << std::endl;
   #endif
   if(spreadPercentageNode)
   {
      if(spreadPercentageNode->Attribute("href") || spreadPercentageNode->Attribute("id"))
      {
          if(spreadPercentageNode->Attribute("id"))
          {
             spreadPercentageIDRef_ = spreadPercentageNode->Attribute("id");
             spreadPercentage_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(spreadPercentageNode));
             spreadPercentage_->setID(spreadPercentageIDRef_);
             IDManager::instance().setID(spreadPercentageIDRef_,spreadPercentage_);
          }
          else if(spreadPercentageNode->Attribute("href")) { spreadPercentageIDRef_ = spreadPercentageNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { spreadPercentage_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(spreadPercentageNode));}
   }

   //fxNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fxNode = xmlNode->FirstChildElement("fx");

   if(fxNode){fxIsNull_ = false;}
   else{fxIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fxNode , address : " << fxNode << std::endl;
   #endif
   if(fxNode)
   {
      if(fxNode->Attribute("href") || fxNode->Attribute("id"))
      {
          if(fxNode->Attribute("id"))
          {
             fxIDRef_ = fxNode->Attribute("id");
             fx_ = boost::shared_ptr<CommodityFx>(new CommodityFx(fxNode));
             fx_->setID(fxIDRef_);
             IDManager::instance().setID(fxIDRef_,fx_);
          }
          else if(fxNode->Attribute("href")) { fxIDRef_ = fxNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fx_ = boost::shared_ptr<CommodityFx>(new CommodityFx(fxNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CommodityPricingDates> FloatingLegCalculation::getPricingDates()
{
   if(!this->pricingDatesIsNull_){
        if(pricingDatesIDRef_ != ""){
             return boost::shared_static_cast<CommodityPricingDates>(IDManager::instance().getID(pricingDatesIDRef_));
        }else{
             return this->pricingDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityPricingDates>();
   }
}
boost::shared_ptr<AveragingMethodEnum> FloatingLegCalculation::getAveragingMethod()
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
boost::shared_ptr<XsdTypeDecimal> FloatingLegCalculation::getConversionFactor()
{
   if(!this->conversionFactorIsNull_){
        if(conversionFactorIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(conversionFactorIDRef_));
        }else{
             return this->conversionFactor_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<Rounding> FloatingLegCalculation::getRounding()
{
   if(!this->roundingIsNull_){
        if(roundingIDRef_ != ""){
             return boost::shared_static_cast<Rounding>(IDManager::instance().getID(roundingIDRef_));
        }else{
             return this->rounding_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Rounding>();
   }
}
boost::shared_ptr<CommoditySpread> FloatingLegCalculation::getSpread()
{
   if(!this->spreadIsNull_){
        if(spreadIDRef_ != ""){
             return boost::shared_static_cast<CommoditySpread>(IDManager::instance().getID(spreadIDRef_));
        }else{
             return this->spread_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommoditySpread>();
   }
}
std::vector<boost::shared_ptr<CommoditySpreadSchedule>> FloatingLegCalculation::getSpreadSchedule()
{
   if(!this->spreadScheduleIsNull_){
        if(spreadScheduleIDRef_ != ""){
             return this->spreadSchedule_;
        }else{
             return this->spreadSchedule_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<CommoditySpreadSchedule>>();
   }
}
boost::shared_ptr<XsdTypeDecimal> FloatingLegCalculation::getSpreadPercentage()
{
   if(!this->spreadPercentageIsNull_){
        if(spreadPercentageIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(spreadPercentageIDRef_));
        }else{
             return this->spreadPercentage_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<CommodityFx> FloatingLegCalculation::getFx()
{
   if(!this->fxIsNull_){
        if(fxIDRef_ != ""){
             return boost::shared_static_cast<CommodityFx>(IDManager::instance().getID(fxIDRef_));
        }else{
             return this->fx_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityFx>();
   }
}
}

