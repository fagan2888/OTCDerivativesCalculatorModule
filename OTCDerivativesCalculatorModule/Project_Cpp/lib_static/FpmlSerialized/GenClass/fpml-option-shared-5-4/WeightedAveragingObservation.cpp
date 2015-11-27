// WeightedAveragingObservation.cpp 
#include "WeightedAveragingObservation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

WeightedAveragingObservation::WeightedAveragingObservation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //dateTimeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dateTimeNode = xmlNode->FirstChildElement("dateTime");

   if(dateTimeNode){dateTimeIsNull_ = false;}
   else{dateTimeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dateTimeNode , address : " << dateTimeNode << std::endl;
   #endif
   if(dateTimeNode)
   {
      if(dateTimeNode->Attribute("href") || dateTimeNode->Attribute("id"))
      {
          if(dateTimeNode->Attribute("id"))
          {
             dateTimeIDRef_ = dateTimeNode->Attribute("id");
             dateTime_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(dateTimeNode));
             dateTime_->setID(dateTimeIDRef_);
             IDManager::instance().setID(dateTimeIDRef_,dateTime_);
          }
          else if(dateTimeNode->Attribute("href")) { dateTimeIDRef_ = dateTimeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dateTime_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(dateTimeNode));}
   }

   //observationNumberNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* observationNumberNode = xmlNode->FirstChildElement("observationNumber");

   if(observationNumberNode){observationNumberIsNull_ = false;}
   else{observationNumberIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- observationNumberNode , address : " << observationNumberNode << std::endl;
   #endif
   if(observationNumberNode)
   {
      if(observationNumberNode->Attribute("href") || observationNumberNode->Attribute("id"))
      {
          if(observationNumberNode->Attribute("id"))
          {
             observationNumberIDRef_ = observationNumberNode->Attribute("id");
             observationNumber_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(observationNumberNode));
             observationNumber_->setID(observationNumberIDRef_);
             IDManager::instance().setID(observationNumberIDRef_,observationNumber_);
          }
          else if(observationNumberNode->Attribute("href")) { observationNumberIDRef_ = observationNumberNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { observationNumber_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(observationNumberNode));}
   }

   //weightNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* weightNode = xmlNode->FirstChildElement("weight");

   if(weightNode){weightIsNull_ = false;}
   else{weightIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- weightNode , address : " << weightNode << std::endl;
   #endif
   if(weightNode)
   {
      if(weightNode->Attribute("href") || weightNode->Attribute("id"))
      {
          if(weightNode->Attribute("id"))
          {
             weightIDRef_ = weightNode->Attribute("id");
             weight_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(weightNode));
             weight_->setID(weightIDRef_);
             IDManager::instance().setID(weightIDRef_,weight_);
          }
          else if(weightNode->Attribute("href")) { weightIDRef_ = weightNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { weight_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(weightNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDateTime> WeightedAveragingObservation::getDateTime()
{
   if(!this->dateTimeIsNull_){
        if(dateTimeIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDateTime>(IDManager::instance().getID(dateTimeIDRef_));
        }else{
             return this->dateTime_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDateTime>();
   }
}
boost::shared_ptr<XsdTypePositiveInteger> WeightedAveragingObservation::getObservationNumber()
{
   if(!this->observationNumberIsNull_){
        if(observationNumberIDRef_ != ""){
             return boost::shared_static_cast<XsdTypePositiveInteger>(IDManager::instance().getID(observationNumberIDRef_));
        }else{
             return this->observationNumber_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypePositiveInteger>();
   }
}
boost::shared_ptr<NonNegativeDecimal> WeightedAveragingObservation::getWeight()
{
   if(!this->weightIsNull_){
        if(weightIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeDecimal>(IDManager::instance().getID(weightIDRef_));
        }else{
             return this->weight_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeDecimal>();
   }
}
}

