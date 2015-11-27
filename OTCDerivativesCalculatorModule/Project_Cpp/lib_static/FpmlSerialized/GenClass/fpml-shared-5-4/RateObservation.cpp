// RateObservation.cpp 
#include "RateObservation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

RateObservation::RateObservation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //resetDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* resetDateNode = xmlNode->FirstChildElement("resetDate");

   if(resetDateNode){resetDateIsNull_ = false;}
   else{resetDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- resetDateNode , address : " << resetDateNode << std::endl;
   #endif
   if(resetDateNode)
   {
      if(resetDateNode->Attribute("href") || resetDateNode->Attribute("id"))
      {
          if(resetDateNode->Attribute("id"))
          {
             resetDateIDRef_ = resetDateNode->Attribute("id");
             resetDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(resetDateNode));
             resetDate_->setID(resetDateIDRef_);
             IDManager::instance().setID(resetDateIDRef_,resetDate_);
          }
          else if(resetDateNode->Attribute("href")) { resetDateIDRef_ = resetDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { resetDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(resetDateNode));}
   }

   //adjustedFixingDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* adjustedFixingDateNode = xmlNode->FirstChildElement("adjustedFixingDate");

   if(adjustedFixingDateNode){adjustedFixingDateIsNull_ = false;}
   else{adjustedFixingDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- adjustedFixingDateNode , address : " << adjustedFixingDateNode << std::endl;
   #endif
   if(adjustedFixingDateNode)
   {
      if(adjustedFixingDateNode->Attribute("href") || adjustedFixingDateNode->Attribute("id"))
      {
          if(adjustedFixingDateNode->Attribute("id"))
          {
             adjustedFixingDateIDRef_ = adjustedFixingDateNode->Attribute("id");
             adjustedFixingDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustedFixingDateNode));
             adjustedFixingDate_->setID(adjustedFixingDateIDRef_);
             IDManager::instance().setID(adjustedFixingDateIDRef_,adjustedFixingDate_);
          }
          else if(adjustedFixingDateNode->Attribute("href")) { adjustedFixingDateIDRef_ = adjustedFixingDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { adjustedFixingDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustedFixingDateNode));}
   }

   //observedRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* observedRateNode = xmlNode->FirstChildElement("observedRate");

   if(observedRateNode){observedRateIsNull_ = false;}
   else{observedRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- observedRateNode , address : " << observedRateNode << std::endl;
   #endif
   if(observedRateNode)
   {
      if(observedRateNode->Attribute("href") || observedRateNode->Attribute("id"))
      {
          if(observedRateNode->Attribute("id"))
          {
             observedRateIDRef_ = observedRateNode->Attribute("id");
             observedRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(observedRateNode));
             observedRate_->setID(observedRateIDRef_);
             IDManager::instance().setID(observedRateIDRef_,observedRate_);
          }
          else if(observedRateNode->Attribute("href")) { observedRateIDRef_ = observedRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { observedRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(observedRateNode));}
   }

   //treatedRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* treatedRateNode = xmlNode->FirstChildElement("treatedRate");

   if(treatedRateNode){treatedRateIsNull_ = false;}
   else{treatedRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- treatedRateNode , address : " << treatedRateNode << std::endl;
   #endif
   if(treatedRateNode)
   {
      if(treatedRateNode->Attribute("href") || treatedRateNode->Attribute("id"))
      {
          if(treatedRateNode->Attribute("id"))
          {
             treatedRateIDRef_ = treatedRateNode->Attribute("id");
             treatedRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(treatedRateNode));
             treatedRate_->setID(treatedRateIDRef_);
             IDManager::instance().setID(treatedRateIDRef_,treatedRate_);
          }
          else if(treatedRateNode->Attribute("href")) { treatedRateIDRef_ = treatedRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { treatedRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(treatedRateNode));}
   }

   //observationWeightNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* observationWeightNode = xmlNode->FirstChildElement("observationWeight");

   if(observationWeightNode){observationWeightIsNull_ = false;}
   else{observationWeightIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- observationWeightNode , address : " << observationWeightNode << std::endl;
   #endif
   if(observationWeightNode)
   {
      if(observationWeightNode->Attribute("href") || observationWeightNode->Attribute("id"))
      {
          if(observationWeightNode->Attribute("id"))
          {
             observationWeightIDRef_ = observationWeightNode->Attribute("id");
             observationWeight_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(observationWeightNode));
             observationWeight_->setID(observationWeightIDRef_);
             IDManager::instance().setID(observationWeightIDRef_,observationWeight_);
          }
          else if(observationWeightNode->Attribute("href")) { observationWeightIDRef_ = observationWeightNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { observationWeight_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(observationWeightNode));}
   }

   //rateReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* rateReferenceNode = xmlNode->FirstChildElement("rateReference");

   if(rateReferenceNode){rateReferenceIsNull_ = false;}
   else{rateReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rateReferenceNode , address : " << rateReferenceNode << std::endl;
   #endif
   if(rateReferenceNode)
   {
      if(rateReferenceNode->Attribute("href") || rateReferenceNode->Attribute("id"))
      {
          if(rateReferenceNode->Attribute("id"))
          {
             rateReferenceIDRef_ = rateReferenceNode->Attribute("id");
             rateReference_ = boost::shared_ptr<RateReference>(new RateReference(rateReferenceNode));
             rateReference_->setID(rateReferenceIDRef_);
             IDManager::instance().setID(rateReferenceIDRef_,rateReference_);
          }
          else if(rateReferenceNode->Attribute("href")) { rateReferenceIDRef_ = rateReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { rateReference_ = boost::shared_ptr<RateReference>(new RateReference(rateReferenceNode));}
   }

   //forecastRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* forecastRateNode = xmlNode->FirstChildElement("forecastRate");

   if(forecastRateNode){forecastRateIsNull_ = false;}
   else{forecastRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- forecastRateNode , address : " << forecastRateNode << std::endl;
   #endif
   if(forecastRateNode)
   {
      if(forecastRateNode->Attribute("href") || forecastRateNode->Attribute("id"))
      {
          if(forecastRateNode->Attribute("id"))
          {
             forecastRateIDRef_ = forecastRateNode->Attribute("id");
             forecastRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(forecastRateNode));
             forecastRate_->setID(forecastRateIDRef_);
             IDManager::instance().setID(forecastRateIDRef_,forecastRate_);
          }
          else if(forecastRateNode->Attribute("href")) { forecastRateIDRef_ = forecastRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { forecastRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(forecastRateNode));}
   }

   //treatedForecastRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* treatedForecastRateNode = xmlNode->FirstChildElement("treatedForecastRate");

   if(treatedForecastRateNode){treatedForecastRateIsNull_ = false;}
   else{treatedForecastRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- treatedForecastRateNode , address : " << treatedForecastRateNode << std::endl;
   #endif
   if(treatedForecastRateNode)
   {
      if(treatedForecastRateNode->Attribute("href") || treatedForecastRateNode->Attribute("id"))
      {
          if(treatedForecastRateNode->Attribute("id"))
          {
             treatedForecastRateIDRef_ = treatedForecastRateNode->Attribute("id");
             treatedForecastRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(treatedForecastRateNode));
             treatedForecastRate_->setID(treatedForecastRateIDRef_);
             IDManager::instance().setID(treatedForecastRateIDRef_,treatedForecastRate_);
          }
          else if(treatedForecastRateNode->Attribute("href")) { treatedForecastRateIDRef_ = treatedForecastRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { treatedForecastRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(treatedForecastRateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDate> RateObservation::getResetDate()
{
   if(!this->resetDateIsNull_){
        if(resetDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(resetDateIDRef_));
        }else{
             return this->resetDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> RateObservation::getAdjustedFixingDate()
{
   if(!this->adjustedFixingDateIsNull_){
        if(adjustedFixingDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(adjustedFixingDateIDRef_));
        }else{
             return this->adjustedFixingDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDecimal> RateObservation::getObservedRate()
{
   if(!this->observedRateIsNull_){
        if(observedRateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(observedRateIDRef_));
        }else{
             return this->observedRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDecimal> RateObservation::getTreatedRate()
{
   if(!this->treatedRateIsNull_){
        if(treatedRateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(treatedRateIDRef_));
        }else{
             return this->treatedRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypePositiveInteger> RateObservation::getObservationWeight()
{
   if(!this->observationWeightIsNull_){
        if(observationWeightIDRef_ != ""){
             return boost::shared_static_cast<XsdTypePositiveInteger>(IDManager::instance().getID(observationWeightIDRef_));
        }else{
             return this->observationWeight_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypePositiveInteger>();
   }
}
boost::shared_ptr<RateReference> RateObservation::getRateReference()
{
   if(!this->rateReferenceIsNull_){
        if(rateReferenceIDRef_ != ""){
             return boost::shared_static_cast<RateReference>(IDManager::instance().getID(rateReferenceIDRef_));
        }else{
             return this->rateReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RateReference>();
   }
}
boost::shared_ptr<XsdTypeDecimal> RateObservation::getForecastRate()
{
   if(!this->forecastRateIsNull_){
        if(forecastRateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(forecastRateIDRef_));
        }else{
             return this->forecastRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDecimal> RateObservation::getTreatedForecastRate()
{
   if(!this->treatedForecastRateIsNull_){
        if(treatedForecastRateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(treatedForecastRateIDRef_));
        }else{
             return this->treatedForecastRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
}

