// CommoditySettlementPeriodsNotionalQuantitySchedule.cpp 
#include "CommoditySettlementPeriodsNotionalQuantitySchedule.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CommoditySettlementPeriodsNotionalQuantitySchedule::CommoditySettlementPeriodsNotionalQuantitySchedule(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //settlementPeriodsNotionalQuantityStepNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementPeriodsNotionalQuantityStepNode = xmlNode->FirstChildElement("settlementPeriodsNotionalQuantityStep");

   if(settlementPeriodsNotionalQuantityStepNode){settlementPeriodsNotionalQuantityStepIsNull_ = false;}
   else{settlementPeriodsNotionalQuantityStepIsNull_ = true;}

   if(settlementPeriodsNotionalQuantityStepNode)
   {
      for(settlementPeriodsNotionalQuantityStepNode; settlementPeriodsNotionalQuantityStepNode; settlementPeriodsNotionalQuantityStepNode = settlementPeriodsNotionalQuantityStepNode->NextSiblingElement("settlementPeriodsNotionalQuantityStep")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementPeriodsNotionalQuantityStepNode , address : " << settlementPeriodsNotionalQuantityStepNode << std::endl;
          #endif
          if(settlementPeriodsNotionalQuantityStepNode->Attribute("href") || settlementPeriodsNotionalQuantityStepNode->Attribute("id"))
          {
              if(settlementPeriodsNotionalQuantityStepNode->Attribute("id"))
              {
                  settlementPeriodsNotionalQuantityStepIDRef_ = settlementPeriodsNotionalQuantityStepNode->Attribute("id");
                  settlementPeriodsNotionalQuantityStep_.push_back(boost::shared_ptr<CommodityNotionalQuantity>(new CommodityNotionalQuantity(settlementPeriodsNotionalQuantityStepNode)));
                  settlementPeriodsNotionalQuantityStep_.back()->setID(settlementPeriodsNotionalQuantityStepIDRef_);
                  IDManager::instance().setID(settlementPeriodsNotionalQuantityStepIDRef_, settlementPeriodsNotionalQuantityStep_.back());
              }
              else if(settlementPeriodsNotionalQuantityStepNode->Attribute("href")) { settlementPeriodsNotionalQuantityStepIDRef_ = settlementPeriodsNotionalQuantityStepNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { settlementPeriodsNotionalQuantityStep_.push_back(boost::shared_ptr<CommodityNotionalQuantity>(new CommodityNotionalQuantity(settlementPeriodsNotionalQuantityStepNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementPeriodsNotionalQuantityStepNode , address : " << settlementPeriodsNotionalQuantityStepNode << std::endl;
       #endif
   }

   //settlementPeriodsReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementPeriodsReferenceNode = xmlNode->FirstChildElement("settlementPeriodsReference");

   if(settlementPeriodsReferenceNode){settlementPeriodsReferenceIsNull_ = false;}
   else{settlementPeriodsReferenceIsNull_ = true;}

   if(settlementPeriodsReferenceNode)
   {
      for(settlementPeriodsReferenceNode; settlementPeriodsReferenceNode; settlementPeriodsReferenceNode = settlementPeriodsReferenceNode->NextSiblingElement("settlementPeriodsReference")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementPeriodsReferenceNode , address : " << settlementPeriodsReferenceNode << std::endl;
          #endif
          if(settlementPeriodsReferenceNode->Attribute("href") || settlementPeriodsReferenceNode->Attribute("id"))
          {
              if(settlementPeriodsReferenceNode->Attribute("id"))
              {
                  settlementPeriodsReferenceIDRef_ = settlementPeriodsReferenceNode->Attribute("id");
                  settlementPeriodsReference_.push_back(boost::shared_ptr<SettlementPeriodsReference>(new SettlementPeriodsReference(settlementPeriodsReferenceNode)));
                  settlementPeriodsReference_.back()->setID(settlementPeriodsReferenceIDRef_);
                  IDManager::instance().setID(settlementPeriodsReferenceIDRef_, settlementPeriodsReference_.back());
              }
              else if(settlementPeriodsReferenceNode->Attribute("href")) { settlementPeriodsReferenceIDRef_ = settlementPeriodsReferenceNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { settlementPeriodsReference_.push_back(boost::shared_ptr<SettlementPeriodsReference>(new SettlementPeriodsReference(settlementPeriodsReferenceNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementPeriodsReferenceNode , address : " << settlementPeriodsReferenceNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<CommodityNotionalQuantity>> CommoditySettlementPeriodsNotionalQuantitySchedule::getSettlementPeriodsNotionalQuantityStep()
{
   if(!this->settlementPeriodsNotionalQuantityStepIsNull_){
        if(settlementPeriodsNotionalQuantityStepIDRef_ != ""){
             return this->settlementPeriodsNotionalQuantityStep_;
        }else{
             return this->settlementPeriodsNotionalQuantityStep_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<CommodityNotionalQuantity>>();
   }
}
std::vector<boost::shared_ptr<SettlementPeriodsReference>> CommoditySettlementPeriodsNotionalQuantitySchedule::getSettlementPeriodsReference()
{
   if(!this->settlementPeriodsReferenceIsNull_){
        if(settlementPeriodsReferenceIDRef_ != ""){
             return this->settlementPeriodsReference_;
        }else{
             return this->settlementPeriodsReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<SettlementPeriodsReference>>();
   }
}
}

