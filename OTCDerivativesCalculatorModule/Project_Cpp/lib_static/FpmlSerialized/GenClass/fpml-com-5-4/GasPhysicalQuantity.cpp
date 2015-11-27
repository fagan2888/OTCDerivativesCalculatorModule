// GasPhysicalQuantity.cpp 
#include "GasPhysicalQuantity.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

GasPhysicalQuantity::GasPhysicalQuantity(TiXmlNode* xmlNode)
: CommodityPhysicalQuantityBase(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //physicalQuantityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* physicalQuantityNode = xmlNode->FirstChildElement("physicalQuantity");

   if(physicalQuantityNode){physicalQuantityIsNull_ = false;}
   else{physicalQuantityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- physicalQuantityNode , address : " << physicalQuantityNode << std::endl;
   #endif
   if(physicalQuantityNode)
   {
      if(physicalQuantityNode->Attribute("href") || physicalQuantityNode->Attribute("id"))
      {
          if(physicalQuantityNode->Attribute("id"))
          {
             physicalQuantityIDRef_ = physicalQuantityNode->Attribute("id");
             physicalQuantity_ = boost::shared_ptr<CommodityNotionalQuantity>(new CommodityNotionalQuantity(physicalQuantityNode));
             physicalQuantity_->setID(physicalQuantityIDRef_);
             IDManager::instance().setID(physicalQuantityIDRef_,physicalQuantity_);
          }
          else if(physicalQuantityNode->Attribute("href")) { physicalQuantityIDRef_ = physicalQuantityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { physicalQuantity_ = boost::shared_ptr<CommodityNotionalQuantity>(new CommodityNotionalQuantity(physicalQuantityNode));}
   }

   //physicalQuantityScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* physicalQuantityScheduleNode = xmlNode->FirstChildElement("physicalQuantitySchedule");

   if(physicalQuantityScheduleNode){physicalQuantityScheduleIsNull_ = false;}
   else{physicalQuantityScheduleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- physicalQuantityScheduleNode , address : " << physicalQuantityScheduleNode << std::endl;
   #endif
   if(physicalQuantityScheduleNode)
   {
      if(physicalQuantityScheduleNode->Attribute("href") || physicalQuantityScheduleNode->Attribute("id"))
      {
          if(physicalQuantityScheduleNode->Attribute("id"))
          {
             physicalQuantityScheduleIDRef_ = physicalQuantityScheduleNode->Attribute("id");
             physicalQuantitySchedule_ = boost::shared_ptr<CommodityPhysicalQuantitySchedule>(new CommodityPhysicalQuantitySchedule(physicalQuantityScheduleNode));
             physicalQuantitySchedule_->setID(physicalQuantityScheduleIDRef_);
             IDManager::instance().setID(physicalQuantityScheduleIDRef_,physicalQuantitySchedule_);
          }
          else if(physicalQuantityScheduleNode->Attribute("href")) { physicalQuantityScheduleIDRef_ = physicalQuantityScheduleNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { physicalQuantitySchedule_ = boost::shared_ptr<CommodityPhysicalQuantitySchedule>(new CommodityPhysicalQuantitySchedule(physicalQuantityScheduleNode));}
   }

   //totalPhysicalQuantityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* totalPhysicalQuantityNode = xmlNode->FirstChildElement("totalPhysicalQuantity");

   if(totalPhysicalQuantityNode){totalPhysicalQuantityIsNull_ = false;}
   else{totalPhysicalQuantityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- totalPhysicalQuantityNode , address : " << totalPhysicalQuantityNode << std::endl;
   #endif
   if(totalPhysicalQuantityNode)
   {
      if(totalPhysicalQuantityNode->Attribute("href") || totalPhysicalQuantityNode->Attribute("id"))
      {
          if(totalPhysicalQuantityNode->Attribute("id"))
          {
             totalPhysicalQuantityIDRef_ = totalPhysicalQuantityNode->Attribute("id");
             totalPhysicalQuantity_ = boost::shared_ptr<UnitQuantity>(new UnitQuantity(totalPhysicalQuantityNode));
             totalPhysicalQuantity_->setID(totalPhysicalQuantityIDRef_);
             IDManager::instance().setID(totalPhysicalQuantityIDRef_,totalPhysicalQuantity_);
          }
          else if(totalPhysicalQuantityNode->Attribute("href")) { totalPhysicalQuantityIDRef_ = totalPhysicalQuantityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { totalPhysicalQuantity_ = boost::shared_ptr<UnitQuantity>(new UnitQuantity(totalPhysicalQuantityNode));}
   }

   //minPhysicalQuantityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* minPhysicalQuantityNode = xmlNode->FirstChildElement("minPhysicalQuantity");

   if(minPhysicalQuantityNode){minPhysicalQuantityIsNull_ = false;}
   else{minPhysicalQuantityIsNull_ = true;}

   if(minPhysicalQuantityNode)
   {
      for(minPhysicalQuantityNode; minPhysicalQuantityNode; minPhysicalQuantityNode = minPhysicalQuantityNode->NextSiblingElement("minPhysicalQuantity")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- minPhysicalQuantityNode , address : " << minPhysicalQuantityNode << std::endl;
          #endif
          if(minPhysicalQuantityNode->Attribute("href") || minPhysicalQuantityNode->Attribute("id"))
          {
              if(minPhysicalQuantityNode->Attribute("id"))
              {
                  minPhysicalQuantityIDRef_ = minPhysicalQuantityNode->Attribute("id");
                  minPhysicalQuantity_.push_back(boost::shared_ptr<CommodityNotionalQuantity>(new CommodityNotionalQuantity(minPhysicalQuantityNode)));
                  minPhysicalQuantity_.back()->setID(minPhysicalQuantityIDRef_);
                  IDManager::instance().setID(minPhysicalQuantityIDRef_, minPhysicalQuantity_.back());
              }
              else if(minPhysicalQuantityNode->Attribute("href")) { minPhysicalQuantityIDRef_ = minPhysicalQuantityNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { minPhysicalQuantity_.push_back(boost::shared_ptr<CommodityNotionalQuantity>(new CommodityNotionalQuantity(minPhysicalQuantityNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- minPhysicalQuantityNode , address : " << minPhysicalQuantityNode << std::endl;
       #endif
   }

   //maxPhysicalQuantityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* maxPhysicalQuantityNode = xmlNode->FirstChildElement("maxPhysicalQuantity");

   if(maxPhysicalQuantityNode){maxPhysicalQuantityIsNull_ = false;}
   else{maxPhysicalQuantityIsNull_ = true;}

   if(maxPhysicalQuantityNode)
   {
      for(maxPhysicalQuantityNode; maxPhysicalQuantityNode; maxPhysicalQuantityNode = maxPhysicalQuantityNode->NextSiblingElement("maxPhysicalQuantity")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- maxPhysicalQuantityNode , address : " << maxPhysicalQuantityNode << std::endl;
          #endif
          if(maxPhysicalQuantityNode->Attribute("href") || maxPhysicalQuantityNode->Attribute("id"))
          {
              if(maxPhysicalQuantityNode->Attribute("id"))
              {
                  maxPhysicalQuantityIDRef_ = maxPhysicalQuantityNode->Attribute("id");
                  maxPhysicalQuantity_.push_back(boost::shared_ptr<CommodityNotionalQuantity>(new CommodityNotionalQuantity(maxPhysicalQuantityNode)));
                  maxPhysicalQuantity_.back()->setID(maxPhysicalQuantityIDRef_);
                  IDManager::instance().setID(maxPhysicalQuantityIDRef_, maxPhysicalQuantity_.back());
              }
              else if(maxPhysicalQuantityNode->Attribute("href")) { maxPhysicalQuantityIDRef_ = maxPhysicalQuantityNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { maxPhysicalQuantity_.push_back(boost::shared_ptr<CommodityNotionalQuantity>(new CommodityNotionalQuantity(maxPhysicalQuantityNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- maxPhysicalQuantityNode , address : " << maxPhysicalQuantityNode << std::endl;
       #endif
   }

   //electingPartyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* electingPartyNode = xmlNode->FirstChildElement("electingParty");

   if(electingPartyNode){electingPartyIsNull_ = false;}
   else{electingPartyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- electingPartyNode , address : " << electingPartyNode << std::endl;
   #endif
   if(electingPartyNode)
   {
      if(electingPartyNode->Attribute("href") || electingPartyNode->Attribute("id"))
      {
          if(electingPartyNode->Attribute("id"))
          {
             electingPartyIDRef_ = electingPartyNode->Attribute("id");
             electingParty_ = boost::shared_ptr<PartyReference>(new PartyReference(electingPartyNode));
             electingParty_->setID(electingPartyIDRef_);
             IDManager::instance().setID(electingPartyIDRef_,electingParty_);
          }
          else if(electingPartyNode->Attribute("href")) { electingPartyIDRef_ = electingPartyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { electingParty_ = boost::shared_ptr<PartyReference>(new PartyReference(electingPartyNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CommodityNotionalQuantity> GasPhysicalQuantity::getPhysicalQuantity()
{
   if(!this->physicalQuantityIsNull_){
        if(physicalQuantityIDRef_ != ""){
             return boost::shared_static_cast<CommodityNotionalQuantity>(IDManager::instance().getID(physicalQuantityIDRef_));
        }else{
             return this->physicalQuantity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityNotionalQuantity>();
   }
}
boost::shared_ptr<CommodityPhysicalQuantitySchedule> GasPhysicalQuantity::getPhysicalQuantitySchedule()
{
   if(!this->physicalQuantityScheduleIsNull_){
        if(physicalQuantityScheduleIDRef_ != ""){
             return boost::shared_static_cast<CommodityPhysicalQuantitySchedule>(IDManager::instance().getID(physicalQuantityScheduleIDRef_));
        }else{
             return this->physicalQuantitySchedule_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityPhysicalQuantitySchedule>();
   }
}
boost::shared_ptr<UnitQuantity> GasPhysicalQuantity::getTotalPhysicalQuantity()
{
   if(!this->totalPhysicalQuantityIsNull_){
        if(totalPhysicalQuantityIDRef_ != ""){
             return boost::shared_static_cast<UnitQuantity>(IDManager::instance().getID(totalPhysicalQuantityIDRef_));
        }else{
             return this->totalPhysicalQuantity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<UnitQuantity>();
   }
}
std::vector<boost::shared_ptr<CommodityNotionalQuantity>> GasPhysicalQuantity::getMinPhysicalQuantity()
{
   if(!this->minPhysicalQuantityIsNull_){
        if(minPhysicalQuantityIDRef_ != ""){
             return this->minPhysicalQuantity_;
        }else{
             return this->minPhysicalQuantity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<CommodityNotionalQuantity>>();
   }
}
std::vector<boost::shared_ptr<CommodityNotionalQuantity>> GasPhysicalQuantity::getMaxPhysicalQuantity()
{
   if(!this->maxPhysicalQuantityIsNull_){
        if(maxPhysicalQuantityIDRef_ != ""){
             return this->maxPhysicalQuantity_;
        }else{
             return this->maxPhysicalQuantity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<CommodityNotionalQuantity>>();
   }
}
boost::shared_ptr<PartyReference> GasPhysicalQuantity::getElectingParty()
{
   if(!this->electingPartyIsNull_){
        if(electingPartyIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(electingPartyIDRef_));
        }else{
             return this->electingParty_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
}

