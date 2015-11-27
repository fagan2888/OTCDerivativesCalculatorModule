// ElectricityDeliveryPeriods.cpp 
#include "ElectricityDeliveryPeriods.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ElectricityDeliveryPeriods::ElectricityDeliveryPeriods(TiXmlNode* xmlNode)
: CommodityDeliveryPeriods(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //settlementPeriodsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementPeriodsNode = xmlNode->FirstChildElement("settlementPeriods");

   if(settlementPeriodsNode){settlementPeriodsIsNull_ = false;}
   else{settlementPeriodsIsNull_ = true;}

   if(settlementPeriodsNode)
   {
      for(settlementPeriodsNode; settlementPeriodsNode; settlementPeriodsNode = settlementPeriodsNode->NextSiblingElement("settlementPeriods")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementPeriodsNode , address : " << settlementPeriodsNode << std::endl;
          #endif
          if(settlementPeriodsNode->Attribute("href") || settlementPeriodsNode->Attribute("id"))
          {
              if(settlementPeriodsNode->Attribute("id"))
              {
                  settlementPeriodsIDRef_ = settlementPeriodsNode->Attribute("id");
                  settlementPeriods_.push_back(boost::shared_ptr<SettlementPeriods>(new SettlementPeriods(settlementPeriodsNode)));
                  settlementPeriods_.back()->setID(settlementPeriodsIDRef_);
                  IDManager::instance().setID(settlementPeriodsIDRef_, settlementPeriods_.back());
              }
              else if(settlementPeriodsNode->Attribute("href")) { settlementPeriodsIDRef_ = settlementPeriodsNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { settlementPeriods_.push_back(boost::shared_ptr<SettlementPeriods>(new SettlementPeriods(settlementPeriodsNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementPeriodsNode , address : " << settlementPeriodsNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<SettlementPeriods>> ElectricityDeliveryPeriods::getSettlementPeriods()
{
   if(!this->settlementPeriodsIsNull_){
        if(settlementPeriodsIDRef_ != ""){
             return this->settlementPeriods_;
        }else{
             return this->settlementPeriods_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<SettlementPeriods>>();
   }
}
}

