// FloatingRate.cpp 
#include "FloatingRate.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FloatingRate::FloatingRate(TiXmlNode* xmlNode)
: Rate(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //floatingRateIndexNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* floatingRateIndexNode = xmlNode->FirstChildElement("floatingRateIndex");

   if(floatingRateIndexNode){floatingRateIndexIsNull_ = false;}
   else{floatingRateIndexIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- floatingRateIndexNode , address : " << floatingRateIndexNode << std::endl;
   #endif
   if(floatingRateIndexNode)
   {
      if(floatingRateIndexNode->Attribute("href") || floatingRateIndexNode->Attribute("id"))
      {
          if(floatingRateIndexNode->Attribute("id"))
          {
             floatingRateIndexIDRef_ = floatingRateIndexNode->Attribute("id");
             floatingRateIndex_ = boost::shared_ptr<FloatingRateIndex>(new FloatingRateIndex(floatingRateIndexNode));
             floatingRateIndex_->setID(floatingRateIndexIDRef_);
             IDManager::instance().setID(floatingRateIndexIDRef_,floatingRateIndex_);
          }
          else if(floatingRateIndexNode->Attribute("href")) { floatingRateIndexIDRef_ = floatingRateIndexNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { floatingRateIndex_ = boost::shared_ptr<FloatingRateIndex>(new FloatingRateIndex(floatingRateIndexNode));}
   }

   //indexTenorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* indexTenorNode = xmlNode->FirstChildElement("indexTenor");

   if(indexTenorNode){indexTenorIsNull_ = false;}
   else{indexTenorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- indexTenorNode , address : " << indexTenorNode << std::endl;
   #endif
   if(indexTenorNode)
   {
      if(indexTenorNode->Attribute("href") || indexTenorNode->Attribute("id"))
      {
          if(indexTenorNode->Attribute("id"))
          {
             indexTenorIDRef_ = indexTenorNode->Attribute("id");
             indexTenor_ = boost::shared_ptr<Period>(new Period(indexTenorNode));
             indexTenor_->setID(indexTenorIDRef_);
             IDManager::instance().setID(indexTenorIDRef_,indexTenor_);
          }
          else if(indexTenorNode->Attribute("href")) { indexTenorIDRef_ = indexTenorNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { indexTenor_ = boost::shared_ptr<Period>(new Period(indexTenorNode));}
   }

   //floatingRateMultiplierScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* floatingRateMultiplierScheduleNode = xmlNode->FirstChildElement("floatingRateMultiplierSchedule");

   if(floatingRateMultiplierScheduleNode){floatingRateMultiplierScheduleIsNull_ = false;}
   else{floatingRateMultiplierScheduleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- floatingRateMultiplierScheduleNode , address : " << floatingRateMultiplierScheduleNode << std::endl;
   #endif
   if(floatingRateMultiplierScheduleNode)
   {
      if(floatingRateMultiplierScheduleNode->Attribute("href") || floatingRateMultiplierScheduleNode->Attribute("id"))
      {
          if(floatingRateMultiplierScheduleNode->Attribute("id"))
          {
             floatingRateMultiplierScheduleIDRef_ = floatingRateMultiplierScheduleNode->Attribute("id");
             floatingRateMultiplierSchedule_ = boost::shared_ptr<Schedule>(new Schedule(floatingRateMultiplierScheduleNode));
             floatingRateMultiplierSchedule_->setID(floatingRateMultiplierScheduleIDRef_);
             IDManager::instance().setID(floatingRateMultiplierScheduleIDRef_,floatingRateMultiplierSchedule_);
          }
          else if(floatingRateMultiplierScheduleNode->Attribute("href")) { floatingRateMultiplierScheduleIDRef_ = floatingRateMultiplierScheduleNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { floatingRateMultiplierSchedule_ = boost::shared_ptr<Schedule>(new Schedule(floatingRateMultiplierScheduleNode));}
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
                  spreadSchedule_.push_back(boost::shared_ptr<SpreadSchedule>(new SpreadSchedule(spreadScheduleNode)));
                  spreadSchedule_.back()->setID(spreadScheduleIDRef_);
                  IDManager::instance().setID(spreadScheduleIDRef_, spreadSchedule_.back());
              }
              else if(spreadScheduleNode->Attribute("href")) { spreadScheduleIDRef_ = spreadScheduleNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { spreadSchedule_.push_back(boost::shared_ptr<SpreadSchedule>(new SpreadSchedule(spreadScheduleNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- spreadScheduleNode , address : " << spreadScheduleNode << std::endl;
       #endif
   }

   //rateTreatmentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* rateTreatmentNode = xmlNode->FirstChildElement("rateTreatment");

   if(rateTreatmentNode){rateTreatmentIsNull_ = false;}
   else{rateTreatmentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rateTreatmentNode , address : " << rateTreatmentNode << std::endl;
   #endif
   if(rateTreatmentNode)
   {
      if(rateTreatmentNode->Attribute("href") || rateTreatmentNode->Attribute("id"))
      {
          if(rateTreatmentNode->Attribute("id"))
          {
             rateTreatmentIDRef_ = rateTreatmentNode->Attribute("id");
             rateTreatment_ = boost::shared_ptr<RateTreatmentEnum>(new RateTreatmentEnum(rateTreatmentNode));
             rateTreatment_->setID(rateTreatmentIDRef_);
             IDManager::instance().setID(rateTreatmentIDRef_,rateTreatment_);
          }
          else if(rateTreatmentNode->Attribute("href")) { rateTreatmentIDRef_ = rateTreatmentNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { rateTreatment_ = boost::shared_ptr<RateTreatmentEnum>(new RateTreatmentEnum(rateTreatmentNode));}
   }

   //capRateScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* capRateScheduleNode = xmlNode->FirstChildElement("capRateSchedule");

   if(capRateScheduleNode){capRateScheduleIsNull_ = false;}
   else{capRateScheduleIsNull_ = true;}

   if(capRateScheduleNode)
   {
      for(capRateScheduleNode; capRateScheduleNode; capRateScheduleNode = capRateScheduleNode->NextSiblingElement("capRateSchedule")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- capRateScheduleNode , address : " << capRateScheduleNode << std::endl;
          #endif
          if(capRateScheduleNode->Attribute("href") || capRateScheduleNode->Attribute("id"))
          {
              if(capRateScheduleNode->Attribute("id"))
              {
                  capRateScheduleIDRef_ = capRateScheduleNode->Attribute("id");
                  capRateSchedule_.push_back(boost::shared_ptr<StrikeSchedule>(new StrikeSchedule(capRateScheduleNode)));
                  capRateSchedule_.back()->setID(capRateScheduleIDRef_);
                  IDManager::instance().setID(capRateScheduleIDRef_, capRateSchedule_.back());
              }
              else if(capRateScheduleNode->Attribute("href")) { capRateScheduleIDRef_ = capRateScheduleNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { capRateSchedule_.push_back(boost::shared_ptr<StrikeSchedule>(new StrikeSchedule(capRateScheduleNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- capRateScheduleNode , address : " << capRateScheduleNode << std::endl;
       #endif
   }

   //floorRateScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* floorRateScheduleNode = xmlNode->FirstChildElement("floorRateSchedule");

   if(floorRateScheduleNode){floorRateScheduleIsNull_ = false;}
   else{floorRateScheduleIsNull_ = true;}

   if(floorRateScheduleNode)
   {
      for(floorRateScheduleNode; floorRateScheduleNode; floorRateScheduleNode = floorRateScheduleNode->NextSiblingElement("floorRateSchedule")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- floorRateScheduleNode , address : " << floorRateScheduleNode << std::endl;
          #endif
          if(floorRateScheduleNode->Attribute("href") || floorRateScheduleNode->Attribute("id"))
          {
              if(floorRateScheduleNode->Attribute("id"))
              {
                  floorRateScheduleIDRef_ = floorRateScheduleNode->Attribute("id");
                  floorRateSchedule_.push_back(boost::shared_ptr<StrikeSchedule>(new StrikeSchedule(floorRateScheduleNode)));
                  floorRateSchedule_.back()->setID(floorRateScheduleIDRef_);
                  IDManager::instance().setID(floorRateScheduleIDRef_, floorRateSchedule_.back());
              }
              else if(floorRateScheduleNode->Attribute("href")) { floorRateScheduleIDRef_ = floorRateScheduleNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { floorRateSchedule_.push_back(boost::shared_ptr<StrikeSchedule>(new StrikeSchedule(floorRateScheduleNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- floorRateScheduleNode , address : " << floorRateScheduleNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<FloatingRateIndex> FloatingRate::getFloatingRateIndex()
{
   if(!this->floatingRateIndexIsNull_){
        if(floatingRateIndexIDRef_ != ""){
             return boost::shared_static_cast<FloatingRateIndex>(IDManager::instance().getID(floatingRateIndexIDRef_));
        }else{
             return this->floatingRateIndex_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FloatingRateIndex>();
   }
}
boost::shared_ptr<Period> FloatingRate::getIndexTenor()
{
   if(!this->indexTenorIsNull_){
        if(indexTenorIDRef_ != ""){
             return boost::shared_static_cast<Period>(IDManager::instance().getID(indexTenorIDRef_));
        }else{
             return this->indexTenor_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Period>();
   }
}
boost::shared_ptr<Schedule> FloatingRate::getFloatingRateMultiplierSchedule()
{
   if(!this->floatingRateMultiplierScheduleIsNull_){
        if(floatingRateMultiplierScheduleIDRef_ != ""){
             return boost::shared_static_cast<Schedule>(IDManager::instance().getID(floatingRateMultiplierScheduleIDRef_));
        }else{
             return this->floatingRateMultiplierSchedule_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Schedule>();
   }
}
std::vector<boost::shared_ptr<SpreadSchedule>> FloatingRate::getSpreadSchedule()
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
      return std::vector<boost::shared_ptr<SpreadSchedule>>();
   }
}
boost::shared_ptr<RateTreatmentEnum> FloatingRate::getRateTreatment()
{
   if(!this->rateTreatmentIsNull_){
        if(rateTreatmentIDRef_ != ""){
             return boost::shared_static_cast<RateTreatmentEnum>(IDManager::instance().getID(rateTreatmentIDRef_));
        }else{
             return this->rateTreatment_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RateTreatmentEnum>();
   }
}
std::vector<boost::shared_ptr<StrikeSchedule>> FloatingRate::getCapRateSchedule()
{
   if(!this->capRateScheduleIsNull_){
        if(capRateScheduleIDRef_ != ""){
             return this->capRateSchedule_;
        }else{
             return this->capRateSchedule_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<StrikeSchedule>>();
   }
}
std::vector<boost::shared_ptr<StrikeSchedule>> FloatingRate::getFloorRateSchedule()
{
   if(!this->floorRateScheduleIsNull_){
        if(floorRateScheduleIDRef_ != ""){
             return this->floorRateSchedule_;
        }else{
             return this->floorRateSchedule_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<StrikeSchedule>>();
   }
}
}

