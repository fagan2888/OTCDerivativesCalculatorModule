// AverageDailyTradingVolumeLimit.cpp 
#include "AverageDailyTradingVolumeLimit.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

AverageDailyTradingVolumeLimit::AverageDailyTradingVolumeLimit(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //limitationPercentageNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* limitationPercentageNode = xmlNode->FirstChildElement("limitationPercentage");

   if(limitationPercentageNode){limitationPercentageIsNull_ = false;}
   else{limitationPercentageIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- limitationPercentageNode , address : " << limitationPercentageNode << std::endl;
   #endif
   if(limitationPercentageNode)
   {
      if(limitationPercentageNode->Attribute("href") || limitationPercentageNode->Attribute("id"))
      {
          if(limitationPercentageNode->Attribute("id"))
          {
             limitationPercentageIDRef_ = limitationPercentageNode->Attribute("id");
             limitationPercentage_ = boost::shared_ptr<RestrictedPercentage>(new RestrictedPercentage(limitationPercentageNode));
             limitationPercentage_->setID(limitationPercentageIDRef_);
             IDManager::instance().setID(limitationPercentageIDRef_,limitationPercentage_);
          }
          else if(limitationPercentageNode->Attribute("href")) { limitationPercentageIDRef_ = limitationPercentageNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { limitationPercentage_ = boost::shared_ptr<RestrictedPercentage>(new RestrictedPercentage(limitationPercentageNode));}
   }

   //limitationPeriodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* limitationPeriodNode = xmlNode->FirstChildElement("limitationPeriod");

   if(limitationPeriodNode){limitationPeriodIsNull_ = false;}
   else{limitationPeriodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- limitationPeriodNode , address : " << limitationPeriodNode << std::endl;
   #endif
   if(limitationPeriodNode)
   {
      if(limitationPeriodNode->Attribute("href") || limitationPeriodNode->Attribute("id"))
      {
          if(limitationPeriodNode->Attribute("id"))
          {
             limitationPeriodIDRef_ = limitationPeriodNode->Attribute("id");
             limitationPeriod_ = boost::shared_ptr<XsdTypeNonNegativeInteger>(new XsdTypeNonNegativeInteger(limitationPeriodNode));
             limitationPeriod_->setID(limitationPeriodIDRef_);
             IDManager::instance().setID(limitationPeriodIDRef_,limitationPeriod_);
          }
          else if(limitationPeriodNode->Attribute("href")) { limitationPeriodIDRef_ = limitationPeriodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { limitationPeriod_ = boost::shared_ptr<XsdTypeNonNegativeInteger>(new XsdTypeNonNegativeInteger(limitationPeriodNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<RestrictedPercentage> AverageDailyTradingVolumeLimit::getLimitationPercentage()
{
   if(!this->limitationPercentageIsNull_){
        if(limitationPercentageIDRef_ != ""){
             return boost::shared_static_cast<RestrictedPercentage>(IDManager::instance().getID(limitationPercentageIDRef_));
        }else{
             return this->limitationPercentage_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RestrictedPercentage>();
   }
}
boost::shared_ptr<XsdTypeNonNegativeInteger> AverageDailyTradingVolumeLimit::getLimitationPeriod()
{
   if(!this->limitationPeriodIsNull_){
        if(limitationPeriodIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeNonNegativeInteger>(IDManager::instance().getID(limitationPeriodIDRef_));
        }else{
             return this->limitationPeriod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeNonNegativeInteger>();
   }
}
}

