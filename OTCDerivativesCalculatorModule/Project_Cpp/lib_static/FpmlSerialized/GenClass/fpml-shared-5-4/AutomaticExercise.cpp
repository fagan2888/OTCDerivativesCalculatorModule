// AutomaticExercise.cpp 
#include "AutomaticExercise.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

AutomaticExercise::AutomaticExercise(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //thresholdRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* thresholdRateNode = xmlNode->FirstChildElement("thresholdRate");

   if(thresholdRateNode){thresholdRateIsNull_ = false;}
   else{thresholdRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- thresholdRateNode , address : " << thresholdRateNode << std::endl;
   #endif
   if(thresholdRateNode)
   {
      if(thresholdRateNode->Attribute("href") || thresholdRateNode->Attribute("id"))
      {
          if(thresholdRateNode->Attribute("id"))
          {
             thresholdRateIDRef_ = thresholdRateNode->Attribute("id");
             thresholdRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(thresholdRateNode));
             thresholdRate_->setID(thresholdRateIDRef_);
             IDManager::instance().setID(thresholdRateIDRef_,thresholdRate_);
          }
          else if(thresholdRateNode->Attribute("href")) { thresholdRateIDRef_ = thresholdRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { thresholdRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(thresholdRateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDecimal> AutomaticExercise::getThresholdRate()
{
   if(!this->thresholdRateIsNull_){
        if(thresholdRateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(thresholdRateIDRef_));
        }else{
             return this->thresholdRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
}

