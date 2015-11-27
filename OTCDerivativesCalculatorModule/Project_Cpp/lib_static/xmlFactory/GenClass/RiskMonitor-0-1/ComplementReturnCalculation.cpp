// ComplementReturnCalculation.cpp 
#include "ComplementReturnCalculation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ComplementReturnCalculation::ComplementReturnCalculation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //returnCalculationInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* returnCalculationInfoNode = xmlNode->FirstChildElement("returnCalculationInfo");

   if(returnCalculationInfoNode){returnCalculationInfoIsNull_ = false;}
   else{returnCalculationInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- returnCalculationInfoNode , address : " << returnCalculationInfoNode << std::endl;
   #endif
   if(returnCalculationInfoNode)
   {
       returnCalculationInfo_ = boost::shared_ptr<ReturnCalculationInfo>(new ReturnCalculationInfo(returnCalculationInfoNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<ReturnCalculationInfo> ComplementReturnCalculation::getReturnCalculationInfo()
{
   if(!this->returnCalculationInfoIsNull_){
        return this->returnCalculationInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReturnCalculationInfo>();
   }
}
}

