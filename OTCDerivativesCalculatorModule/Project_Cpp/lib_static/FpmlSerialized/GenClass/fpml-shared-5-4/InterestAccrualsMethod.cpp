// InterestAccrualsMethod.cpp 
#include "InterestAccrualsMethod.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

InterestAccrualsMethod::InterestAccrualsMethod(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //floatingRateCalculationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* floatingRateCalculationNode = xmlNode->FirstChildElement("floatingRateCalculation");

   if(floatingRateCalculationNode){floatingRateCalculationIsNull_ = false;}
   else{floatingRateCalculationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- floatingRateCalculationNode , address : " << floatingRateCalculationNode << std::endl;
   #endif
   if(floatingRateCalculationNode)
   {
      if(floatingRateCalculationNode->Attribute("href") || floatingRateCalculationNode->Attribute("id"))
      {
          if(floatingRateCalculationNode->Attribute("id"))
          {
             floatingRateCalculationIDRef_ = floatingRateCalculationNode->Attribute("id");
             floatingRateCalculation_ = boost::shared_ptr<FloatingRateCalculation>(new FloatingRateCalculation(floatingRateCalculationNode));
             floatingRateCalculation_->setID(floatingRateCalculationIDRef_);
             IDManager::instance().setID(floatingRateCalculationIDRef_,floatingRateCalculation_);
          }
          else if(floatingRateCalculationNode->Attribute("href")) { floatingRateCalculationIDRef_ = floatingRateCalculationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { floatingRateCalculation_ = boost::shared_ptr<FloatingRateCalculation>(new FloatingRateCalculation(floatingRateCalculationNode));}
   }

   //fixedRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixedRateNode = xmlNode->FirstChildElement("fixedRate");

   if(fixedRateNode){fixedRateIsNull_ = false;}
   else{fixedRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixedRateNode , address : " << fixedRateNode << std::endl;
   #endif
   if(fixedRateNode)
   {
      if(fixedRateNode->Attribute("href") || fixedRateNode->Attribute("id"))
      {
          if(fixedRateNode->Attribute("id"))
          {
             fixedRateIDRef_ = fixedRateNode->Attribute("id");
             fixedRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(fixedRateNode));
             fixedRate_->setID(fixedRateIDRef_);
             IDManager::instance().setID(fixedRateIDRef_,fixedRate_);
          }
          else if(fixedRateNode->Attribute("href")) { fixedRateIDRef_ = fixedRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fixedRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(fixedRateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<FloatingRateCalculation> InterestAccrualsMethod::getFloatingRateCalculation()
{
   if(!this->floatingRateCalculationIsNull_){
        if(floatingRateCalculationIDRef_ != ""){
             return boost::shared_static_cast<FloatingRateCalculation>(IDManager::instance().getID(floatingRateCalculationIDRef_));
        }else{
             return this->floatingRateCalculation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FloatingRateCalculation>();
   }
}
boost::shared_ptr<XsdTypeDecimal> InterestAccrualsMethod::getFixedRate()
{
   if(!this->fixedRateIsNull_){
        if(fixedRateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(fixedRateIDRef_));
        }else{
             return this->fixedRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
}

