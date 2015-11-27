// CommodityCalculationPeriodsSchedule.cpp 
#include "CommodityCalculationPeriodsSchedule.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CommodityCalculationPeriodsSchedule::CommodityCalculationPeriodsSchedule(TiXmlNode* xmlNode)
: Frequency(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //balanceOfFirstPeriodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* balanceOfFirstPeriodNode = xmlNode->FirstChildElement("balanceOfFirstPeriod");

   if(balanceOfFirstPeriodNode){balanceOfFirstPeriodIsNull_ = false;}
   else{balanceOfFirstPeriodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- balanceOfFirstPeriodNode , address : " << balanceOfFirstPeriodNode << std::endl;
   #endif
   if(balanceOfFirstPeriodNode)
   {
      if(balanceOfFirstPeriodNode->Attribute("href") || balanceOfFirstPeriodNode->Attribute("id"))
      {
          if(balanceOfFirstPeriodNode->Attribute("id"))
          {
             balanceOfFirstPeriodIDRef_ = balanceOfFirstPeriodNode->Attribute("id");
             balanceOfFirstPeriod_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(balanceOfFirstPeriodNode));
             balanceOfFirstPeriod_->setID(balanceOfFirstPeriodIDRef_);
             IDManager::instance().setID(balanceOfFirstPeriodIDRef_,balanceOfFirstPeriod_);
          }
          else if(balanceOfFirstPeriodNode->Attribute("href")) { balanceOfFirstPeriodIDRef_ = balanceOfFirstPeriodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { balanceOfFirstPeriod_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(balanceOfFirstPeriodNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeBoolean> CommodityCalculationPeriodsSchedule::getBalanceOfFirstPeriod()
{
   if(!this->balanceOfFirstPeriodIsNull_){
        if(balanceOfFirstPeriodIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(balanceOfFirstPeriodIDRef_));
        }else{
             return this->balanceOfFirstPeriod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

