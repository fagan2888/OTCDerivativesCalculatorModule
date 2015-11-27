// Lag.cpp 
#include "Lag.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Lag::Lag(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //lagDurationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* lagDurationNode = xmlNode->FirstChildElement("lagDuration");

   if(lagDurationNode){lagDurationIsNull_ = false;}
   else{lagDurationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- lagDurationNode , address : " << lagDurationNode << std::endl;
   #endif
   if(lagDurationNode)
   {
      if(lagDurationNode->Attribute("href") || lagDurationNode->Attribute("id"))
      {
          if(lagDurationNode->Attribute("id"))
          {
             lagDurationIDRef_ = lagDurationNode->Attribute("id");
             lagDuration_ = boost::shared_ptr<Period>(new Period(lagDurationNode));
             lagDuration_->setID(lagDurationIDRef_);
             IDManager::instance().setID(lagDurationIDRef_,lagDuration_);
          }
          else if(lagDurationNode->Attribute("href")) { lagDurationIDRef_ = lagDurationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { lagDuration_ = boost::shared_ptr<Period>(new Period(lagDurationNode));}
   }

   //firstObservationDateOffsetNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* firstObservationDateOffsetNode = xmlNode->FirstChildElement("firstObservationDateOffset");

   if(firstObservationDateOffsetNode){firstObservationDateOffsetIsNull_ = false;}
   else{firstObservationDateOffsetIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- firstObservationDateOffsetNode , address : " << firstObservationDateOffsetNode << std::endl;
   #endif
   if(firstObservationDateOffsetNode)
   {
      if(firstObservationDateOffsetNode->Attribute("href") || firstObservationDateOffsetNode->Attribute("id"))
      {
          if(firstObservationDateOffsetNode->Attribute("id"))
          {
             firstObservationDateOffsetIDRef_ = firstObservationDateOffsetNode->Attribute("id");
             firstObservationDateOffset_ = boost::shared_ptr<Period>(new Period(firstObservationDateOffsetNode));
             firstObservationDateOffset_->setID(firstObservationDateOffsetIDRef_);
             IDManager::instance().setID(firstObservationDateOffsetIDRef_,firstObservationDateOffset_);
          }
          else if(firstObservationDateOffsetNode->Attribute("href")) { firstObservationDateOffsetIDRef_ = firstObservationDateOffsetNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { firstObservationDateOffset_ = boost::shared_ptr<Period>(new Period(firstObservationDateOffsetNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Period> Lag::getLagDuration()
{
   if(!this->lagDurationIsNull_){
        if(lagDurationIDRef_ != ""){
             return boost::shared_static_cast<Period>(IDManager::instance().getID(lagDurationIDRef_));
        }else{
             return this->lagDuration_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Period>();
   }
}
boost::shared_ptr<Period> Lag::getFirstObservationDateOffset()
{
   if(!this->firstObservationDateOffsetIsNull_){
        if(firstObservationDateOffsetIDRef_ != ""){
             return boost::shared_static_cast<Period>(IDManager::instance().getID(firstObservationDateOffsetIDRef_));
        }else{
             return this->firstObservationDateOffset_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Period>();
   }
}
}

