// InterestCalculation.cpp 
#include "InterestCalculation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

InterestCalculation::InterestCalculation(TiXmlNode* xmlNode)
: InterestAccrualsMethod(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //dayCountFractionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dayCountFractionNode = xmlNode->FirstChildElement("dayCountFraction");

   if(dayCountFractionNode){dayCountFractionIsNull_ = false;}
   else{dayCountFractionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dayCountFractionNode , address : " << dayCountFractionNode << std::endl;
   #endif
   if(dayCountFractionNode)
   {
      if(dayCountFractionNode->Attribute("href") || dayCountFractionNode->Attribute("id"))
      {
          if(dayCountFractionNode->Attribute("id"))
          {
             dayCountFractionIDRef_ = dayCountFractionNode->Attribute("id");
             dayCountFraction_ = boost::shared_ptr<DayCountFraction>(new DayCountFraction(dayCountFractionNode));
             dayCountFraction_->setID(dayCountFractionIDRef_);
             IDManager::instance().setID(dayCountFractionIDRef_,dayCountFraction_);
          }
          else if(dayCountFractionNode->Attribute("href")) { dayCountFractionIDRef_ = dayCountFractionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dayCountFraction_ = boost::shared_ptr<DayCountFraction>(new DayCountFraction(dayCountFractionNode));}
   }

   //compoundingNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* compoundingNode = xmlNode->FirstChildElement("compounding");

   if(compoundingNode){compoundingIsNull_ = false;}
   else{compoundingIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- compoundingNode , address : " << compoundingNode << std::endl;
   #endif
   if(compoundingNode)
   {
      if(compoundingNode->Attribute("href") || compoundingNode->Attribute("id"))
      {
          if(compoundingNode->Attribute("id"))
          {
             compoundingIDRef_ = compoundingNode->Attribute("id");
             compounding_ = boost::shared_ptr<Compounding>(new Compounding(compoundingNode));
             compounding_->setID(compoundingIDRef_);
             IDManager::instance().setID(compoundingIDRef_,compounding_);
          }
          else if(compoundingNode->Attribute("href")) { compoundingIDRef_ = compoundingNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { compounding_ = boost::shared_ptr<Compounding>(new Compounding(compoundingNode));}
   }

   //interpolationMethodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* interpolationMethodNode = xmlNode->FirstChildElement("interpolationMethod");

   if(interpolationMethodNode){interpolationMethodIsNull_ = false;}
   else{interpolationMethodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- interpolationMethodNode , address : " << interpolationMethodNode << std::endl;
   #endif
   if(interpolationMethodNode)
   {
      if(interpolationMethodNode->Attribute("href") || interpolationMethodNode->Attribute("id"))
      {
          if(interpolationMethodNode->Attribute("id"))
          {
             interpolationMethodIDRef_ = interpolationMethodNode->Attribute("id");
             interpolationMethod_ = boost::shared_ptr<InterpolationMethod>(new InterpolationMethod(interpolationMethodNode));
             interpolationMethod_->setID(interpolationMethodIDRef_);
             IDManager::instance().setID(interpolationMethodIDRef_,interpolationMethod_);
          }
          else if(interpolationMethodNode->Attribute("href")) { interpolationMethodIDRef_ = interpolationMethodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { interpolationMethod_ = boost::shared_ptr<InterpolationMethod>(new InterpolationMethod(interpolationMethodNode));}
   }

   //interpolationPeriodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* interpolationPeriodNode = xmlNode->FirstChildElement("interpolationPeriod");

   if(interpolationPeriodNode){interpolationPeriodIsNull_ = false;}
   else{interpolationPeriodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- interpolationPeriodNode , address : " << interpolationPeriodNode << std::endl;
   #endif
   if(interpolationPeriodNode)
   {
      if(interpolationPeriodNode->Attribute("href") || interpolationPeriodNode->Attribute("id"))
      {
          if(interpolationPeriodNode->Attribute("id"))
          {
             interpolationPeriodIDRef_ = interpolationPeriodNode->Attribute("id");
             interpolationPeriod_ = boost::shared_ptr<InterpolationPeriodEnum>(new InterpolationPeriodEnum(interpolationPeriodNode));
             interpolationPeriod_->setID(interpolationPeriodIDRef_);
             IDManager::instance().setID(interpolationPeriodIDRef_,interpolationPeriod_);
          }
          else if(interpolationPeriodNode->Attribute("href")) { interpolationPeriodIDRef_ = interpolationPeriodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { interpolationPeriod_ = boost::shared_ptr<InterpolationPeriodEnum>(new InterpolationPeriodEnum(interpolationPeriodNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<DayCountFraction> InterestCalculation::getDayCountFraction()
{
   if(!this->dayCountFractionIsNull_){
        if(dayCountFractionIDRef_ != ""){
             return boost::shared_static_cast<DayCountFraction>(IDManager::instance().getID(dayCountFractionIDRef_));
        }else{
             return this->dayCountFraction_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DayCountFraction>();
   }
}
boost::shared_ptr<Compounding> InterestCalculation::getCompounding()
{
   if(!this->compoundingIsNull_){
        if(compoundingIDRef_ != ""){
             return boost::shared_static_cast<Compounding>(IDManager::instance().getID(compoundingIDRef_));
        }else{
             return this->compounding_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Compounding>();
   }
}
boost::shared_ptr<InterpolationMethod> InterestCalculation::getInterpolationMethod()
{
   if(!this->interpolationMethodIsNull_){
        if(interpolationMethodIDRef_ != ""){
             return boost::shared_static_cast<InterpolationMethod>(IDManager::instance().getID(interpolationMethodIDRef_));
        }else{
             return this->interpolationMethod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<InterpolationMethod>();
   }
}
boost::shared_ptr<InterpolationPeriodEnum> InterestCalculation::getInterpolationPeriod()
{
   if(!this->interpolationPeriodIsNull_){
        if(interpolationPeriodIDRef_ != ""){
             return boost::shared_static_cast<InterpolationPeriodEnum>(IDManager::instance().getID(interpolationPeriodIDRef_));
        }else{
             return this->interpolationPeriod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<InterpolationPeriodEnum>();
   }
}
}

