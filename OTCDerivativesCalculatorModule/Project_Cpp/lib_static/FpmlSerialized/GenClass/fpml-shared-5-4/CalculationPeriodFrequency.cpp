// CalculationPeriodFrequency.cpp 
#include "CalculationPeriodFrequency.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CalculationPeriodFrequency::CalculationPeriodFrequency(TiXmlNode* xmlNode)
: Frequency(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //rollConventionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* rollConventionNode = xmlNode->FirstChildElement("rollConvention");

   if(rollConventionNode){rollConventionIsNull_ = false;}
   else{rollConventionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rollConventionNode , address : " << rollConventionNode << std::endl;
   #endif
   if(rollConventionNode)
   {
      if(rollConventionNode->Attribute("href") || rollConventionNode->Attribute("id"))
      {
          if(rollConventionNode->Attribute("id"))
          {
             rollConventionIDRef_ = rollConventionNode->Attribute("id");
             rollConvention_ = boost::shared_ptr<RollConventionEnum>(new RollConventionEnum(rollConventionNode));
             rollConvention_->setID(rollConventionIDRef_);
             IDManager::instance().setID(rollConventionIDRef_,rollConvention_);
          }
          else if(rollConventionNode->Attribute("href")) { rollConventionIDRef_ = rollConventionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { rollConvention_ = boost::shared_ptr<RollConventionEnum>(new RollConventionEnum(rollConventionNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<RollConventionEnum> CalculationPeriodFrequency::getRollConvention()
{
   if(!this->rollConventionIsNull_){
        if(rollConventionIDRef_ != ""){
             return boost::shared_static_cast<RollConventionEnum>(IDManager::instance().getID(rollConventionIDRef_));
        }else{
             return this->rollConvention_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RollConventionEnum>();
   }
}
}

