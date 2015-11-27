// YieldCurve.cpp 
#include "YieldCurve.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

YieldCurve::YieldCurve(TiXmlNode* xmlNode)
: PricingStructure(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //algorithmNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* algorithmNode = xmlNode->FirstChildElement("algorithm");

   if(algorithmNode){algorithmIsNull_ = false;}
   else{algorithmIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- algorithmNode , address : " << algorithmNode << std::endl;
   #endif
   if(algorithmNode)
   {
      if(algorithmNode->Attribute("href") || algorithmNode->Attribute("id"))
      {
          if(algorithmNode->Attribute("id"))
          {
             algorithmIDRef_ = algorithmNode->Attribute("id");
             algorithm_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(algorithmNode));
             algorithm_->setID(algorithmIDRef_);
             IDManager::instance().setID(algorithmIDRef_,algorithm_);
          }
          else if(algorithmNode->Attribute("href")) { algorithmIDRef_ = algorithmNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { algorithm_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(algorithmNode));}
   }

   //forecastRateIndexNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* forecastRateIndexNode = xmlNode->FirstChildElement("forecastRateIndex");

   if(forecastRateIndexNode){forecastRateIndexIsNull_ = false;}
   else{forecastRateIndexIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- forecastRateIndexNode , address : " << forecastRateIndexNode << std::endl;
   #endif
   if(forecastRateIndexNode)
   {
      if(forecastRateIndexNode->Attribute("href") || forecastRateIndexNode->Attribute("id"))
      {
          if(forecastRateIndexNode->Attribute("id"))
          {
             forecastRateIndexIDRef_ = forecastRateIndexNode->Attribute("id");
             forecastRateIndex_ = boost::shared_ptr<ForecastRateIndex>(new ForecastRateIndex(forecastRateIndexNode));
             forecastRateIndex_->setID(forecastRateIndexIDRef_);
             IDManager::instance().setID(forecastRateIndexIDRef_,forecastRateIndex_);
          }
          else if(forecastRateIndexNode->Attribute("href")) { forecastRateIndexIDRef_ = forecastRateIndexNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { forecastRateIndex_ = boost::shared_ptr<ForecastRateIndex>(new ForecastRateIndex(forecastRateIndexNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeString> YieldCurve::getAlgorithm()
{
   if(!this->algorithmIsNull_){
        if(algorithmIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(algorithmIDRef_));
        }else{
             return this->algorithm_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
boost::shared_ptr<ForecastRateIndex> YieldCurve::getForecastRateIndex()
{
   if(!this->forecastRateIndexIsNull_){
        if(forecastRateIndexIDRef_ != ""){
             return boost::shared_static_cast<ForecastRateIndex>(IDManager::instance().getID(forecastRateIndexIDRef_));
        }else{
             return this->forecastRateIndex_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ForecastRateIndex>();
   }
}
}

