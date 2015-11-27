// Excel_creditEventSwapLeg.cpp 
#include "Excel_creditEventSwapLeg.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_creditEventSwapLeg::Excel_creditEventSwapLeg(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //excel_creditEventInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_creditEventInfoNode = xmlNode->FirstChildElement("excel_creditEventInfo");

   if(excel_creditEventInfoNode){excel_creditEventInfoIsNull_ = false;}
   else{excel_creditEventInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_creditEventInfoNode , address : " << excel_creditEventInfoNode << std::endl;
   #endif
   if(excel_creditEventInfoNode)
   {
       excel_creditEventInfo_ = boost::shared_ptr<Excel_creditEventInfo>(new Excel_creditEventInfo(excel_creditEventInfoNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Excel_creditEventInfo> Excel_creditEventSwapLeg::getExcel_creditEventInfo()
{
   if(!this->excel_creditEventInfoIsNull_){
        return this->excel_creditEventInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_creditEventInfo>();
   }
}
}

