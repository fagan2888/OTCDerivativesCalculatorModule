// ReturnLegValuationPrice.cpp 
#include "ReturnLegValuationPrice.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ReturnLegValuationPrice::ReturnLegValuationPrice(TiXmlNode* xmlNode)
: Price(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //valuationRulesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* valuationRulesNode = xmlNode->FirstChildElement("valuationRules");

   if(valuationRulesNode){valuationRulesIsNull_ = false;}
   else{valuationRulesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valuationRulesNode , address : " << valuationRulesNode << std::endl;
   #endif
   if(valuationRulesNode)
   {
      if(valuationRulesNode->Attribute("href") || valuationRulesNode->Attribute("id"))
      {
          if(valuationRulesNode->Attribute("id"))
          {
             valuationRulesIDRef_ = valuationRulesNode->Attribute("id");
             valuationRules_ = boost::shared_ptr<EquityValuation>(new EquityValuation(valuationRulesNode));
             valuationRules_->setID(valuationRulesIDRef_);
             IDManager::instance().setID(valuationRulesIDRef_,valuationRules_);
          }
          else if(valuationRulesNode->Attribute("href")) { valuationRulesIDRef_ = valuationRulesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { valuationRules_ = boost::shared_ptr<EquityValuation>(new EquityValuation(valuationRulesNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<EquityValuation> ReturnLegValuationPrice::getValuationRules()
{
   if(!this->valuationRulesIsNull_){
        if(valuationRulesIDRef_ != ""){
             return boost::shared_static_cast<EquityValuation>(IDManager::instance().getID(valuationRulesIDRef_));
        }else{
             return this->valuationRules_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EquityValuation>();
   }
}
}

