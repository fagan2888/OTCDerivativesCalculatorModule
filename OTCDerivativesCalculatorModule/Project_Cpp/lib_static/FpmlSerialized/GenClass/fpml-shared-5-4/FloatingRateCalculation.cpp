// FloatingRateCalculation.cpp 
#include "FloatingRateCalculation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FloatingRateCalculation::FloatingRateCalculation(TiXmlNode* xmlNode)
: FloatingRate(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //initialRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* initialRateNode = xmlNode->FirstChildElement("initialRate");

   if(initialRateNode){initialRateIsNull_ = false;}
   else{initialRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- initialRateNode , address : " << initialRateNode << std::endl;
   #endif
   if(initialRateNode)
   {
      if(initialRateNode->Attribute("href") || initialRateNode->Attribute("id"))
      {
          if(initialRateNode->Attribute("id"))
          {
             initialRateIDRef_ = initialRateNode->Attribute("id");
             initialRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(initialRateNode));
             initialRate_->setID(initialRateIDRef_);
             IDManager::instance().setID(initialRateIDRef_,initialRate_);
          }
          else if(initialRateNode->Attribute("href")) { initialRateIDRef_ = initialRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { initialRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(initialRateNode));}
   }

   //finalRateRoundingNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* finalRateRoundingNode = xmlNode->FirstChildElement("finalRateRounding");

   if(finalRateRoundingNode){finalRateRoundingIsNull_ = false;}
   else{finalRateRoundingIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- finalRateRoundingNode , address : " << finalRateRoundingNode << std::endl;
   #endif
   if(finalRateRoundingNode)
   {
      if(finalRateRoundingNode->Attribute("href") || finalRateRoundingNode->Attribute("id"))
      {
          if(finalRateRoundingNode->Attribute("id"))
          {
             finalRateRoundingIDRef_ = finalRateRoundingNode->Attribute("id");
             finalRateRounding_ = boost::shared_ptr<Rounding>(new Rounding(finalRateRoundingNode));
             finalRateRounding_->setID(finalRateRoundingIDRef_);
             IDManager::instance().setID(finalRateRoundingIDRef_,finalRateRounding_);
          }
          else if(finalRateRoundingNode->Attribute("href")) { finalRateRoundingIDRef_ = finalRateRoundingNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { finalRateRounding_ = boost::shared_ptr<Rounding>(new Rounding(finalRateRoundingNode));}
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

   //negativeInterestRateTreatmentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* negativeInterestRateTreatmentNode = xmlNode->FirstChildElement("negativeInterestRateTreatment");

   if(negativeInterestRateTreatmentNode){negativeInterestRateTreatmentIsNull_ = false;}
   else{negativeInterestRateTreatmentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- negativeInterestRateTreatmentNode , address : " << negativeInterestRateTreatmentNode << std::endl;
   #endif
   if(negativeInterestRateTreatmentNode)
   {
      if(negativeInterestRateTreatmentNode->Attribute("href") || negativeInterestRateTreatmentNode->Attribute("id"))
      {
          if(negativeInterestRateTreatmentNode->Attribute("id"))
          {
             negativeInterestRateTreatmentIDRef_ = negativeInterestRateTreatmentNode->Attribute("id");
             negativeInterestRateTreatment_ = boost::shared_ptr<NegativeInterestRateTreatmentEnum>(new NegativeInterestRateTreatmentEnum(negativeInterestRateTreatmentNode));
             negativeInterestRateTreatment_->setID(negativeInterestRateTreatmentIDRef_);
             IDManager::instance().setID(negativeInterestRateTreatmentIDRef_,negativeInterestRateTreatment_);
          }
          else if(negativeInterestRateTreatmentNode->Attribute("href")) { negativeInterestRateTreatmentIDRef_ = negativeInterestRateTreatmentNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { negativeInterestRateTreatment_ = boost::shared_ptr<NegativeInterestRateTreatmentEnum>(new NegativeInterestRateTreatmentEnum(negativeInterestRateTreatmentNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDecimal> FloatingRateCalculation::getInitialRate()
{
   if(!this->initialRateIsNull_){
        if(initialRateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(initialRateIDRef_));
        }else{
             return this->initialRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<Rounding> FloatingRateCalculation::getFinalRateRounding()
{
   if(!this->finalRateRoundingIsNull_){
        if(finalRateRoundingIDRef_ != ""){
             return boost::shared_static_cast<Rounding>(IDManager::instance().getID(finalRateRoundingIDRef_));
        }else{
             return this->finalRateRounding_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Rounding>();
   }
}
boost::shared_ptr<AveragingMethodEnum> FloatingRateCalculation::getAveragingMethod()
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
boost::shared_ptr<NegativeInterestRateTreatmentEnum> FloatingRateCalculation::getNegativeInterestRateTreatment()
{
   if(!this->negativeInterestRateTreatmentIsNull_){
        if(negativeInterestRateTreatmentIDRef_ != ""){
             return boost::shared_static_cast<NegativeInterestRateTreatmentEnum>(IDManager::instance().getID(negativeInterestRateTreatmentIDRef_));
        }else{
             return this->negativeInterestRateTreatment_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NegativeInterestRateTreatmentEnum>();
   }
}
}

