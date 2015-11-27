// WeatherCalculationPeriods.cpp 
#include "WeatherCalculationPeriods.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

WeatherCalculationPeriods::WeatherCalculationPeriods(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //calculationPeriodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationPeriodNode = xmlNode->FirstChildElement("calculationPeriod");

   if(calculationPeriodNode){calculationPeriodIsNull_ = false;}
   else{calculationPeriodIsNull_ = true;}

   if(calculationPeriodNode)
   {
      for(calculationPeriodNode; calculationPeriodNode; calculationPeriodNode = calculationPeriodNode->NextSiblingElement("calculationPeriod")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationPeriodNode , address : " << calculationPeriodNode << std::endl;
          #endif
          if(calculationPeriodNode->Attribute("href") || calculationPeriodNode->Attribute("id"))
          {
              if(calculationPeriodNode->Attribute("id"))
              {
                  calculationPeriodIDRef_ = calculationPeriodNode->Attribute("id");
                  calculationPeriod_.push_back(boost::shared_ptr<WeatherCalculationPeriod>(new WeatherCalculationPeriod(calculationPeriodNode)));
                  calculationPeriod_.back()->setID(calculationPeriodIDRef_);
                  IDManager::instance().setID(calculationPeriodIDRef_, calculationPeriod_.back());
              }
              else if(calculationPeriodNode->Attribute("href")) { calculationPeriodIDRef_ = calculationPeriodNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { calculationPeriod_.push_back(boost::shared_ptr<WeatherCalculationPeriod>(new WeatherCalculationPeriod(calculationPeriodNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationPeriodNode , address : " << calculationPeriodNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<WeatherCalculationPeriod>> WeatherCalculationPeriods::getCalculationPeriod()
{
   if(!this->calculationPeriodIsNull_){
        if(calculationPeriodIDRef_ != ""){
             return this->calculationPeriod_;
        }else{
             return this->calculationPeriod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<WeatherCalculationPeriod>>();
   }
}
}

