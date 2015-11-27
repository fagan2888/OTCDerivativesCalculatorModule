// PaymentCalculationPeriod.cpp 
#include "PaymentCalculationPeriod.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PaymentCalculationPeriod::PaymentCalculationPeriod(TiXmlNode* xmlNode)
: PaymentBase(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //unadjustedPaymentDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* unadjustedPaymentDateNode = xmlNode->FirstChildElement("unadjustedPaymentDate");

   if(unadjustedPaymentDateNode){unadjustedPaymentDateIsNull_ = false;}
   else{unadjustedPaymentDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- unadjustedPaymentDateNode , address : " << unadjustedPaymentDateNode << std::endl;
   #endif
   if(unadjustedPaymentDateNode)
   {
      if(unadjustedPaymentDateNode->Attribute("href") || unadjustedPaymentDateNode->Attribute("id"))
      {
          if(unadjustedPaymentDateNode->Attribute("id"))
          {
             unadjustedPaymentDateIDRef_ = unadjustedPaymentDateNode->Attribute("id");
             unadjustedPaymentDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(unadjustedPaymentDateNode));
             unadjustedPaymentDate_->setID(unadjustedPaymentDateIDRef_);
             IDManager::instance().setID(unadjustedPaymentDateIDRef_,unadjustedPaymentDate_);
          }
          else if(unadjustedPaymentDateNode->Attribute("href")) { unadjustedPaymentDateIDRef_ = unadjustedPaymentDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { unadjustedPaymentDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(unadjustedPaymentDateNode));}
   }

   //adjustedPaymentDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* adjustedPaymentDateNode = xmlNode->FirstChildElement("adjustedPaymentDate");

   if(adjustedPaymentDateNode){adjustedPaymentDateIsNull_ = false;}
   else{adjustedPaymentDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- adjustedPaymentDateNode , address : " << adjustedPaymentDateNode << std::endl;
   #endif
   if(adjustedPaymentDateNode)
   {
      if(adjustedPaymentDateNode->Attribute("href") || adjustedPaymentDateNode->Attribute("id"))
      {
          if(adjustedPaymentDateNode->Attribute("id"))
          {
             adjustedPaymentDateIDRef_ = adjustedPaymentDateNode->Attribute("id");
             adjustedPaymentDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustedPaymentDateNode));
             adjustedPaymentDate_->setID(adjustedPaymentDateIDRef_);
             IDManager::instance().setID(adjustedPaymentDateIDRef_,adjustedPaymentDate_);
          }
          else if(adjustedPaymentDateNode->Attribute("href")) { adjustedPaymentDateIDRef_ = adjustedPaymentDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { adjustedPaymentDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustedPaymentDateNode));}
   }

   //calculationPeriodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationPeriodNode = xmlNode->FirstChildElement("calculationPeriod");

   if(calculationPeriodNode){calculationPeriodIsNull_ = false;}
   else{calculationPeriodIsNull_ = true;}

   if(calculationPeriodNode)
   {
      for(calculationPeriodNode; calculationPeriodNode; calculationPeriodNode = calculationPeriodNode->NextSiblingElement("calculationPeriod")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationPeriodNode , address : " << calculationPeriodNode << std::endl;
          #endif
          if(calculationPeriodNode->Attribute("href") || calculationPeriodNode->Attribute("id"))
          {
              if(calculationPeriodNode->Attribute("id"))
              {
                  calculationPeriodIDRef_ = calculationPeriodNode->Attribute("id");
                  calculationPeriod_.push_back(boost::shared_ptr<CalculationPeriod>(new CalculationPeriod(calculationPeriodNode)));
                  calculationPeriod_.back()->setID(calculationPeriodIDRef_);
                  IDManager::instance().setID(calculationPeriodIDRef_, calculationPeriod_.back());
              }
              else if(calculationPeriodNode->Attribute("href")) { calculationPeriodIDRef_ = calculationPeriodNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { calculationPeriod_.push_back(boost::shared_ptr<CalculationPeriod>(new CalculationPeriod(calculationPeriodNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationPeriodNode , address : " << calculationPeriodNode << std::endl;
       #endif
   }

   //fixedPaymentAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixedPaymentAmountNode = xmlNode->FirstChildElement("fixedPaymentAmount");

   if(fixedPaymentAmountNode){fixedPaymentAmountIsNull_ = false;}
   else{fixedPaymentAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixedPaymentAmountNode , address : " << fixedPaymentAmountNode << std::endl;
   #endif
   if(fixedPaymentAmountNode)
   {
      if(fixedPaymentAmountNode->Attribute("href") || fixedPaymentAmountNode->Attribute("id"))
      {
          if(fixedPaymentAmountNode->Attribute("id"))
          {
             fixedPaymentAmountIDRef_ = fixedPaymentAmountNode->Attribute("id");
             fixedPaymentAmount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(fixedPaymentAmountNode));
             fixedPaymentAmount_->setID(fixedPaymentAmountIDRef_);
             IDManager::instance().setID(fixedPaymentAmountIDRef_,fixedPaymentAmount_);
          }
          else if(fixedPaymentAmountNode->Attribute("href")) { fixedPaymentAmountIDRef_ = fixedPaymentAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fixedPaymentAmount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(fixedPaymentAmountNode));}
   }

   //discountFactorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* discountFactorNode = xmlNode->FirstChildElement("discountFactor");

   if(discountFactorNode){discountFactorIsNull_ = false;}
   else{discountFactorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- discountFactorNode , address : " << discountFactorNode << std::endl;
   #endif
   if(discountFactorNode)
   {
      if(discountFactorNode->Attribute("href") || discountFactorNode->Attribute("id"))
      {
          if(discountFactorNode->Attribute("id"))
          {
             discountFactorIDRef_ = discountFactorNode->Attribute("id");
             discountFactor_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(discountFactorNode));
             discountFactor_->setID(discountFactorIDRef_);
             IDManager::instance().setID(discountFactorIDRef_,discountFactor_);
          }
          else if(discountFactorNode->Attribute("href")) { discountFactorIDRef_ = discountFactorNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { discountFactor_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(discountFactorNode));}
   }

   //forecastPaymentAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* forecastPaymentAmountNode = xmlNode->FirstChildElement("forecastPaymentAmount");

   if(forecastPaymentAmountNode){forecastPaymentAmountIsNull_ = false;}
   else{forecastPaymentAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- forecastPaymentAmountNode , address : " << forecastPaymentAmountNode << std::endl;
   #endif
   if(forecastPaymentAmountNode)
   {
      if(forecastPaymentAmountNode->Attribute("href") || forecastPaymentAmountNode->Attribute("id"))
      {
          if(forecastPaymentAmountNode->Attribute("id"))
          {
             forecastPaymentAmountIDRef_ = forecastPaymentAmountNode->Attribute("id");
             forecastPaymentAmount_ = boost::shared_ptr<Money>(new Money(forecastPaymentAmountNode));
             forecastPaymentAmount_->setID(forecastPaymentAmountIDRef_);
             IDManager::instance().setID(forecastPaymentAmountIDRef_,forecastPaymentAmount_);
          }
          else if(forecastPaymentAmountNode->Attribute("href")) { forecastPaymentAmountIDRef_ = forecastPaymentAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { forecastPaymentAmount_ = boost::shared_ptr<Money>(new Money(forecastPaymentAmountNode));}
   }

   //presentValueAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* presentValueAmountNode = xmlNode->FirstChildElement("presentValueAmount");

   if(presentValueAmountNode){presentValueAmountIsNull_ = false;}
   else{presentValueAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- presentValueAmountNode , address : " << presentValueAmountNode << std::endl;
   #endif
   if(presentValueAmountNode)
   {
      if(presentValueAmountNode->Attribute("href") || presentValueAmountNode->Attribute("id"))
      {
          if(presentValueAmountNode->Attribute("id"))
          {
             presentValueAmountIDRef_ = presentValueAmountNode->Attribute("id");
             presentValueAmount_ = boost::shared_ptr<Money>(new Money(presentValueAmountNode));
             presentValueAmount_->setID(presentValueAmountIDRef_);
             IDManager::instance().setID(presentValueAmountIDRef_,presentValueAmount_);
          }
          else if(presentValueAmountNode->Attribute("href")) { presentValueAmountIDRef_ = presentValueAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { presentValueAmount_ = boost::shared_ptr<Money>(new Money(presentValueAmountNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDate> PaymentCalculationPeriod::getUnadjustedPaymentDate()
{
   if(!this->unadjustedPaymentDateIsNull_){
        if(unadjustedPaymentDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(unadjustedPaymentDateIDRef_));
        }else{
             return this->unadjustedPaymentDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> PaymentCalculationPeriod::getAdjustedPaymentDate()
{
   if(!this->adjustedPaymentDateIsNull_){
        if(adjustedPaymentDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(adjustedPaymentDateIDRef_));
        }else{
             return this->adjustedPaymentDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
std::vector<boost::shared_ptr<CalculationPeriod>> PaymentCalculationPeriod::getCalculationPeriod()
{
   if(!this->calculationPeriodIsNull_){
        if(calculationPeriodIDRef_ != ""){
             return this->calculationPeriod_;
        }else{
             return this->calculationPeriod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<CalculationPeriod>>();
   }
}
boost::shared_ptr<XsdTypeDecimal> PaymentCalculationPeriod::getFixedPaymentAmount()
{
   if(!this->fixedPaymentAmountIsNull_){
        if(fixedPaymentAmountIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(fixedPaymentAmountIDRef_));
        }else{
             return this->fixedPaymentAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDecimal> PaymentCalculationPeriod::getDiscountFactor()
{
   if(!this->discountFactorIsNull_){
        if(discountFactorIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(discountFactorIDRef_));
        }else{
             return this->discountFactor_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<Money> PaymentCalculationPeriod::getForecastPaymentAmount()
{
   if(!this->forecastPaymentAmountIsNull_){
        if(forecastPaymentAmountIDRef_ != ""){
             return boost::shared_static_cast<Money>(IDManager::instance().getID(forecastPaymentAmountIDRef_));
        }else{
             return this->forecastPaymentAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Money>();
   }
}
boost::shared_ptr<Money> PaymentCalculationPeriod::getPresentValueAmount()
{
   if(!this->presentValueAmountIsNull_){
        if(presentValueAmountIDRef_ != ""){
             return boost::shared_static_cast<Money>(IDManager::instance().getID(presentValueAmountIDRef_));
        }else{
             return this->presentValueAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Money>();
   }
}
}

