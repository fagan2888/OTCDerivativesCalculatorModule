// Excel_complementReturnCalc.cpp 
#include "Excel_complementReturnCalc.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_complementReturnCalc::Excel_complementReturnCalc(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //excel_returnCalcInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_returnCalcInfoNode = xmlNode->FirstChildElement("excel_returnCalcInfo");

   if(excel_returnCalcInfoNode){excel_returnCalcInfoIsNull_ = false;}
   else{excel_returnCalcInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_returnCalcInfoNode , address : " << excel_returnCalcInfoNode << std::endl;
   #endif
   if(excel_returnCalcInfoNode)
   {
       excel_returnCalcInfo_ = boost::shared_ptr<Excel_returnCalcInfo>(new Excel_returnCalcInfo(excel_returnCalcInfoNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Excel_returnCalcInfo> Excel_complementReturnCalc::getExcel_returnCalcInfo()
{
   if(!this->excel_returnCalcInfoIsNull_){
        return this->excel_returnCalcInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_returnCalcInfo>();
   }
}
}

