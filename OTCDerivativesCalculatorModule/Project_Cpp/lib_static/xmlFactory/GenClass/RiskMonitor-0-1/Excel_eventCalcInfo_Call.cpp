// Excel_eventCalcInfo_Call.cpp 
#include "Excel_eventCalcInfo_Call.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_eventCalcInfo_Call::Excel_eventCalcInfo_Call(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //excel_eventCalcInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_eventCalcInfoNode = xmlNode->FirstChildElement("excel_eventCalcInfo");

   if(excel_eventCalcInfoNode){excel_eventCalcInfoIsNull_ = false;}
   else{excel_eventCalcInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_eventCalcInfoNode , address : " << excel_eventCalcInfoNode << std::endl;
   #endif
   if(excel_eventCalcInfoNode)
   {
       excel_eventCalcInfo_ = boost::shared_ptr<Excel_eventCalcInfo>(new Excel_eventCalcInfo(excel_eventCalcInfoNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Excel_eventCalcInfo> Excel_eventCalcInfo_Call::getExcel_eventCalcInfo()
{
   if(!this->excel_eventCalcInfoIsNull_){
        return this->excel_eventCalcInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_eventCalcInfo>();
   }
}
}

