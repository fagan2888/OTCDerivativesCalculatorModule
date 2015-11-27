// DirectionalLegUnderlyerValuation.cpp 
#include "DirectionalLegUnderlyerValuation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

DirectionalLegUnderlyerValuation::DirectionalLegUnderlyerValuation(TiXmlNode* xmlNode)
: DirectionalLegUnderlyer(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //valuationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* valuationNode = xmlNode->FirstChildElement("valuation");

   if(valuationNode){valuationIsNull_ = false;}
   else{valuationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valuationNode , address : " << valuationNode << std::endl;
   #endif
   if(valuationNode)
   {
      if(valuationNode->Attribute("href") || valuationNode->Attribute("id"))
      {
          if(valuationNode->Attribute("id"))
          {
             valuationIDRef_ = valuationNode->Attribute("id");
             valuation_ = boost::shared_ptr<EquityValuation>(new EquityValuation(valuationNode));
             valuation_->setID(valuationIDRef_);
             IDManager::instance().setID(valuationIDRef_,valuation_);
          }
          else if(valuationNode->Attribute("href")) { valuationIDRef_ = valuationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { valuation_ = boost::shared_ptr<EquityValuation>(new EquityValuation(valuationNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<EquityValuation> DirectionalLegUnderlyerValuation::getValuation()
{
   if(!this->valuationIsNull_){
        if(valuationIDRef_ != ""){
             return boost::shared_static_cast<EquityValuation>(IDManager::instance().getID(valuationIDRef_));
        }else{
             return this->valuation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EquityValuation>();
   }
}
}

