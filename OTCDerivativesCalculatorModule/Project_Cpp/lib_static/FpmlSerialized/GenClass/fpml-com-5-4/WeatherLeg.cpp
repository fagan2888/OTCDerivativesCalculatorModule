// WeatherLeg.cpp 
#include "WeatherLeg.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

WeatherLeg::WeatherLeg(TiXmlNode* xmlNode)
: FinancialSwapLeg(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //weatherIndexLevelNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* weatherIndexLevelNode = xmlNode->FirstChildElement("weatherIndexLevel");

   if(weatherIndexLevelNode){weatherIndexLevelIsNull_ = false;}
   else{weatherIndexLevelIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- weatherIndexLevelNode , address : " << weatherIndexLevelNode << std::endl;
   #endif
   if(weatherIndexLevelNode)
   {
      if(weatherIndexLevelNode->Attribute("href") || weatherIndexLevelNode->Attribute("id"))
      {
          if(weatherIndexLevelNode->Attribute("id"))
          {
             weatherIndexLevelIDRef_ = weatherIndexLevelNode->Attribute("id");
             weatherIndexLevel_ = boost::shared_ptr<WeatherIndex>(new WeatherIndex(weatherIndexLevelNode));
             weatherIndexLevel_->setID(weatherIndexLevelIDRef_);
             IDManager::instance().setID(weatherIndexLevelIDRef_,weatherIndexLevel_);
          }
          else if(weatherIndexLevelNode->Attribute("href")) { weatherIndexLevelIDRef_ = weatherIndexLevelNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { weatherIndexLevel_ = boost::shared_ptr<WeatherIndex>(new WeatherIndex(weatherIndexLevelNode));}
   }

   //weatherCalculationPeriodsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* weatherCalculationPeriodsNode = xmlNode->FirstChildElement("weatherCalculationPeriods");

   if(weatherCalculationPeriodsNode){weatherCalculationPeriodsIsNull_ = false;}
   else{weatherCalculationPeriodsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- weatherCalculationPeriodsNode , address : " << weatherCalculationPeriodsNode << std::endl;
   #endif
   if(weatherCalculationPeriodsNode)
   {
      if(weatherCalculationPeriodsNode->Attribute("href") || weatherCalculationPeriodsNode->Attribute("id"))
      {
          if(weatherCalculationPeriodsNode->Attribute("id"))
          {
             weatherCalculationPeriodsIDRef_ = weatherCalculationPeriodsNode->Attribute("id");
             weatherCalculationPeriods_ = boost::shared_ptr<WeatherCalculationPeriods>(new WeatherCalculationPeriods(weatherCalculationPeriodsNode));
             weatherCalculationPeriods_->setID(weatherCalculationPeriodsIDRef_);
             IDManager::instance().setID(weatherCalculationPeriodsIDRef_,weatherCalculationPeriods_);
          }
          else if(weatherCalculationPeriodsNode->Attribute("href")) { weatherCalculationPeriodsIDRef_ = weatherCalculationPeriodsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { weatherCalculationPeriods_ = boost::shared_ptr<WeatherCalculationPeriods>(new WeatherCalculationPeriods(weatherCalculationPeriodsNode));}
   }

   //weatherCalculationPeriodsReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* weatherCalculationPeriodsReferenceNode = xmlNode->FirstChildElement("weatherCalculationPeriodsReference");

   if(weatherCalculationPeriodsReferenceNode){weatherCalculationPeriodsReferenceIsNull_ = false;}
   else{weatherCalculationPeriodsReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- weatherCalculationPeriodsReferenceNode , address : " << weatherCalculationPeriodsReferenceNode << std::endl;
   #endif
   if(weatherCalculationPeriodsReferenceNode)
   {
      if(weatherCalculationPeriodsReferenceNode->Attribute("href") || weatherCalculationPeriodsReferenceNode->Attribute("id"))
      {
          if(weatherCalculationPeriodsReferenceNode->Attribute("id"))
          {
             weatherCalculationPeriodsReferenceIDRef_ = weatherCalculationPeriodsReferenceNode->Attribute("id");
             weatherCalculationPeriodsReference_ = boost::shared_ptr<CalculationPeriodsReference>(new CalculationPeriodsReference(weatherCalculationPeriodsReferenceNode));
             weatherCalculationPeriodsReference_->setID(weatherCalculationPeriodsReferenceIDRef_);
             IDManager::instance().setID(weatherCalculationPeriodsReferenceIDRef_,weatherCalculationPeriodsReference_);
          }
          else if(weatherCalculationPeriodsReferenceNode->Attribute("href")) { weatherCalculationPeriodsReferenceIDRef_ = weatherCalculationPeriodsReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { weatherCalculationPeriodsReference_ = boost::shared_ptr<CalculationPeriodsReference>(new CalculationPeriodsReference(weatherCalculationPeriodsReferenceNode));}
   }

   //weatherNotionalAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* weatherNotionalAmountNode = xmlNode->FirstChildElement("weatherNotionalAmount");

   if(weatherNotionalAmountNode){weatherNotionalAmountIsNull_ = false;}
   else{weatherNotionalAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- weatherNotionalAmountNode , address : " << weatherNotionalAmountNode << std::endl;
   #endif
   if(weatherNotionalAmountNode)
   {
      if(weatherNotionalAmountNode->Attribute("href") || weatherNotionalAmountNode->Attribute("id"))
      {
          if(weatherNotionalAmountNode->Attribute("id"))
          {
             weatherNotionalAmountIDRef_ = weatherNotionalAmountNode->Attribute("id");
             weatherNotionalAmount_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(weatherNotionalAmountNode));
             weatherNotionalAmount_->setID(weatherNotionalAmountIDRef_);
             IDManager::instance().setID(weatherNotionalAmountIDRef_,weatherNotionalAmount_);
          }
          else if(weatherNotionalAmountNode->Attribute("href")) { weatherNotionalAmountIDRef_ = weatherNotionalAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { weatherNotionalAmount_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(weatherNotionalAmountNode));}
   }

   //calculationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationNode = xmlNode->FirstChildElement("calculation");

   if(calculationNode){calculationIsNull_ = false;}
   else{calculationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationNode , address : " << calculationNode << std::endl;
   #endif
   if(calculationNode)
   {
      if(calculationNode->Attribute("href") || calculationNode->Attribute("id"))
      {
          if(calculationNode->Attribute("id"))
          {
             calculationIDRef_ = calculationNode->Attribute("id");
             calculation_ = boost::shared_ptr<WeatherLegCalculation>(new WeatherLegCalculation(calculationNode));
             calculation_->setID(calculationIDRef_);
             IDManager::instance().setID(calculationIDRef_,calculation_);
          }
          else if(calculationNode->Attribute("href")) { calculationIDRef_ = calculationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculation_ = boost::shared_ptr<WeatherLegCalculation>(new WeatherLegCalculation(calculationNode));}
   }

   //paymentDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentDatesNode = xmlNode->FirstChildElement("paymentDates");

   if(paymentDatesNode){paymentDatesIsNull_ = false;}
   else{paymentDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentDatesNode , address : " << paymentDatesNode << std::endl;
   #endif
   if(paymentDatesNode)
   {
      if(paymentDatesNode->Attribute("href") || paymentDatesNode->Attribute("id"))
      {
          if(paymentDatesNode->Attribute("id"))
          {
             paymentDatesIDRef_ = paymentDatesNode->Attribute("id");
             paymentDates_ = boost::shared_ptr<CommodityRelativePaymentDates>(new CommodityRelativePaymentDates(paymentDatesNode));
             paymentDates_->setID(paymentDatesIDRef_);
             IDManager::instance().setID(paymentDatesIDRef_,paymentDates_);
          }
          else if(paymentDatesNode->Attribute("href")) { paymentDatesIDRef_ = paymentDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { paymentDates_ = boost::shared_ptr<CommodityRelativePaymentDates>(new CommodityRelativePaymentDates(paymentDatesNode));}
   }

   //weatherIndexDataNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* weatherIndexDataNode = xmlNode->FirstChildElement("weatherIndexData");

   if(weatherIndexDataNode){weatherIndexDataIsNull_ = false;}
   else{weatherIndexDataIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- weatherIndexDataNode , address : " << weatherIndexDataNode << std::endl;
   #endif
   if(weatherIndexDataNode)
   {
      if(weatherIndexDataNode->Attribute("href") || weatherIndexDataNode->Attribute("id"))
      {
          if(weatherIndexDataNode->Attribute("id"))
          {
             weatherIndexDataIDRef_ = weatherIndexDataNode->Attribute("id");
             weatherIndexData_ = boost::shared_ptr<WeatherIndexData>(new WeatherIndexData(weatherIndexDataNode));
             weatherIndexData_->setID(weatherIndexDataIDRef_);
             IDManager::instance().setID(weatherIndexDataIDRef_,weatherIndexData_);
          }
          else if(weatherIndexDataNode->Attribute("href")) { weatherIndexDataIDRef_ = weatherIndexDataNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { weatherIndexData_ = boost::shared_ptr<WeatherIndexData>(new WeatherIndexData(weatherIndexDataNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<WeatherIndex> WeatherLeg::getWeatherIndexLevel()
{
   if(!this->weatherIndexLevelIsNull_){
        if(weatherIndexLevelIDRef_ != ""){
             return boost::shared_static_cast<WeatherIndex>(IDManager::instance().getID(weatherIndexLevelIDRef_));
        }else{
             return this->weatherIndexLevel_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<WeatherIndex>();
   }
}
boost::shared_ptr<WeatherCalculationPeriods> WeatherLeg::getWeatherCalculationPeriods()
{
   if(!this->weatherCalculationPeriodsIsNull_){
        if(weatherCalculationPeriodsIDRef_ != ""){
             return boost::shared_static_cast<WeatherCalculationPeriods>(IDManager::instance().getID(weatherCalculationPeriodsIDRef_));
        }else{
             return this->weatherCalculationPeriods_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<WeatherCalculationPeriods>();
   }
}
boost::shared_ptr<CalculationPeriodsReference> WeatherLeg::getWeatherCalculationPeriodsReference()
{
   if(!this->weatherCalculationPeriodsReferenceIsNull_){
        if(weatherCalculationPeriodsReferenceIDRef_ != ""){
             return boost::shared_static_cast<CalculationPeriodsReference>(IDManager::instance().getID(weatherCalculationPeriodsReferenceIDRef_));
        }else{
             return this->weatherCalculationPeriodsReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CalculationPeriodsReference>();
   }
}
boost::shared_ptr<NonNegativeMoney> WeatherLeg::getWeatherNotionalAmount()
{
   if(!this->weatherNotionalAmountIsNull_){
        if(weatherNotionalAmountIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeMoney>(IDManager::instance().getID(weatherNotionalAmountIDRef_));
        }else{
             return this->weatherNotionalAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeMoney>();
   }
}
boost::shared_ptr<WeatherLegCalculation> WeatherLeg::getCalculation()
{
   if(!this->calculationIsNull_){
        if(calculationIDRef_ != ""){
             return boost::shared_static_cast<WeatherLegCalculation>(IDManager::instance().getID(calculationIDRef_));
        }else{
             return this->calculation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<WeatherLegCalculation>();
   }
}
boost::shared_ptr<CommodityRelativePaymentDates> WeatherLeg::getPaymentDates()
{
   if(!this->paymentDatesIsNull_){
        if(paymentDatesIDRef_ != ""){
             return boost::shared_static_cast<CommodityRelativePaymentDates>(IDManager::instance().getID(paymentDatesIDRef_));
        }else{
             return this->paymentDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityRelativePaymentDates>();
   }
}
boost::shared_ptr<WeatherIndexData> WeatherLeg::getWeatherIndexData()
{
   if(!this->weatherIndexDataIsNull_){
        if(weatherIndexDataIDRef_ != ""){
             return boost::shared_static_cast<WeatherIndexData>(IDManager::instance().getID(weatherIndexDataIDRef_));
        }else{
             return this->weatherIndexData_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<WeatherIndexData>();
   }
}
}

