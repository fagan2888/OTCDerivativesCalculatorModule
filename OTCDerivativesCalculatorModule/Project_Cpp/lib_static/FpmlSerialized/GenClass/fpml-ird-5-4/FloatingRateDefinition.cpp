// FloatingRateDefinition.cpp 
#include "FloatingRateDefinition.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FloatingRateDefinition::FloatingRateDefinition(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //calculatedRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculatedRateNode = xmlNode->FirstChildElement("calculatedRate");

   if(calculatedRateNode){calculatedRateIsNull_ = false;}
   else{calculatedRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculatedRateNode , address : " << calculatedRateNode << std::endl;
   #endif
   if(calculatedRateNode)
   {
      if(calculatedRateNode->Attribute("href") || calculatedRateNode->Attribute("id"))
      {
          if(calculatedRateNode->Attribute("id"))
          {
             calculatedRateIDRef_ = calculatedRateNode->Attribute("id");
             calculatedRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(calculatedRateNode));
             calculatedRate_->setID(calculatedRateIDRef_);
             IDManager::instance().setID(calculatedRateIDRef_,calculatedRate_);
          }
          else if(calculatedRateNode->Attribute("href")) { calculatedRateIDRef_ = calculatedRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculatedRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(calculatedRateNode));}
   }

   //rateObservationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* rateObservationNode = xmlNode->FirstChildElement("rateObservation");

   if(rateObservationNode){rateObservationIsNull_ = false;}
   else{rateObservationIsNull_ = true;}

   if(rateObservationNode)
   {
      for(rateObservationNode; rateObservationNode; rateObservationNode = rateObservationNode->NextSiblingElement("rateObservation")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rateObservationNode , address : " << rateObservationNode << std::endl;
          #endif
          if(rateObservationNode->Attribute("href") || rateObservationNode->Attribute("id"))
          {
              if(rateObservationNode->Attribute("id"))
              {
                  rateObservationIDRef_ = rateObservationNode->Attribute("id");
                  rateObservation_.push_back(boost::shared_ptr<RateObservation>(new RateObservation(rateObservationNode)));
                  rateObservation_.back()->setID(rateObservationIDRef_);
                  IDManager::instance().setID(rateObservationIDRef_, rateObservation_.back());
              }
              else if(rateObservationNode->Attribute("href")) { rateObservationIDRef_ = rateObservationNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { rateObservation_.push_back(boost::shared_ptr<RateObservation>(new RateObservation(rateObservationNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rateObservationNode , address : " << rateObservationNode << std::endl;
       #endif
   }

   //floatingRateMultiplierNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* floatingRateMultiplierNode = xmlNode->FirstChildElement("floatingRateMultiplier");

   if(floatingRateMultiplierNode){floatingRateMultiplierIsNull_ = false;}
   else{floatingRateMultiplierIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- floatingRateMultiplierNode , address : " << floatingRateMultiplierNode << std::endl;
   #endif
   if(floatingRateMultiplierNode)
   {
      if(floatingRateMultiplierNode->Attribute("href") || floatingRateMultiplierNode->Attribute("id"))
      {
          if(floatingRateMultiplierNode->Attribute("id"))
          {
             floatingRateMultiplierIDRef_ = floatingRateMultiplierNode->Attribute("id");
             floatingRateMultiplier_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(floatingRateMultiplierNode));
             floatingRateMultiplier_->setID(floatingRateMultiplierIDRef_);
             IDManager::instance().setID(floatingRateMultiplierIDRef_,floatingRateMultiplier_);
          }
          else if(floatingRateMultiplierNode->Attribute("href")) { floatingRateMultiplierIDRef_ = floatingRateMultiplierNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { floatingRateMultiplier_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(floatingRateMultiplierNode));}
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
             spread_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(spreadNode));
             spread_->setID(spreadIDRef_);
             IDManager::instance().setID(spreadIDRef_,spread_);
          }
          else if(spreadNode->Attribute("href")) { spreadIDRef_ = spreadNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { spread_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(spreadNode));}
   }

   //capRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* capRateNode = xmlNode->FirstChildElement("capRate");

   if(capRateNode){capRateIsNull_ = false;}
   else{capRateIsNull_ = true;}

   if(capRateNode)
   {
      for(capRateNode; capRateNode; capRateNode = capRateNode->NextSiblingElement("capRate")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- capRateNode , address : " << capRateNode << std::endl;
          #endif
          if(capRateNode->Attribute("href") || capRateNode->Attribute("id"))
          {
              if(capRateNode->Attribute("id"))
              {
                  capRateIDRef_ = capRateNode->Attribute("id");
                  capRate_.push_back(boost::shared_ptr<Strike>(new Strike(capRateNode)));
                  capRate_.back()->setID(capRateIDRef_);
                  IDManager::instance().setID(capRateIDRef_, capRate_.back());
              }
              else if(capRateNode->Attribute("href")) { capRateIDRef_ = capRateNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { capRate_.push_back(boost::shared_ptr<Strike>(new Strike(capRateNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- capRateNode , address : " << capRateNode << std::endl;
       #endif
   }

   //floorRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* floorRateNode = xmlNode->FirstChildElement("floorRate");

   if(floorRateNode){floorRateIsNull_ = false;}
   else{floorRateIsNull_ = true;}

   if(floorRateNode)
   {
      for(floorRateNode; floorRateNode; floorRateNode = floorRateNode->NextSiblingElement("floorRate")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- floorRateNode , address : " << floorRateNode << std::endl;
          #endif
          if(floorRateNode->Attribute("href") || floorRateNode->Attribute("id"))
          {
              if(floorRateNode->Attribute("id"))
              {
                  floorRateIDRef_ = floorRateNode->Attribute("id");
                  floorRate_.push_back(boost::shared_ptr<Strike>(new Strike(floorRateNode)));
                  floorRate_.back()->setID(floorRateIDRef_);
                  IDManager::instance().setID(floorRateIDRef_, floorRate_.back());
              }
              else if(floorRateNode->Attribute("href")) { floorRateIDRef_ = floorRateNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { floorRate_.push_back(boost::shared_ptr<Strike>(new Strike(floorRateNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- floorRateNode , address : " << floorRateNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDecimal> FloatingRateDefinition::getCalculatedRate()
{
   if(!this->calculatedRateIsNull_){
        if(calculatedRateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(calculatedRateIDRef_));
        }else{
             return this->calculatedRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
std::vector<boost::shared_ptr<RateObservation>> FloatingRateDefinition::getRateObservation()
{
   if(!this->rateObservationIsNull_){
        if(rateObservationIDRef_ != ""){
             return this->rateObservation_;
        }else{
             return this->rateObservation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<RateObservation>>();
   }
}
boost::shared_ptr<XsdTypeDecimal> FloatingRateDefinition::getFloatingRateMultiplier()
{
   if(!this->floatingRateMultiplierIsNull_){
        if(floatingRateMultiplierIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(floatingRateMultiplierIDRef_));
        }else{
             return this->floatingRateMultiplier_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDecimal> FloatingRateDefinition::getSpread()
{
   if(!this->spreadIsNull_){
        if(spreadIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(spreadIDRef_));
        }else{
             return this->spread_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
std::vector<boost::shared_ptr<Strike>> FloatingRateDefinition::getCapRate()
{
   if(!this->capRateIsNull_){
        if(capRateIDRef_ != ""){
             return this->capRate_;
        }else{
             return this->capRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Strike>>();
   }
}
std::vector<boost::shared_ptr<Strike>> FloatingRateDefinition::getFloorRate()
{
   if(!this->floorRateIsNull_){
        if(floorRateIDRef_ != ""){
             return this->floorRate_;
        }else{
             return this->floorRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Strike>>();
   }
}
}

