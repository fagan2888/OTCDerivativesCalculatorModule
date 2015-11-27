// Excel_underlyingCalcInfo.cpp 
#include "Excel_underlyingCalcInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_underlyingCalcInfo::Excel_underlyingCalcInfo(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //excel_underlyingInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_underlyingInfoNode = xmlNode->FirstChildElement("excel_underlyingInfo");

   if(excel_underlyingInfoNode){excel_underlyingInfoIsNull_ = false;}
   else{excel_underlyingInfoIsNull_ = true;}

   if(excel_underlyingInfoNode)
   {
      for(excel_underlyingInfoNode; excel_underlyingInfoNode; excel_underlyingInfoNode = excel_underlyingInfoNode->NextSiblingElement("excel_underlyingInfo")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_underlyingInfoNode , address : " << excel_underlyingInfoNode << std::endl;
          #endif
          excel_underlyingInfo_.push_back(boost::shared_ptr<Excel_underlyingInfo>(new Excel_underlyingInfo(excel_underlyingInfoNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_underlyingInfoNode , address : " << excel_underlyingInfoNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<Excel_underlyingInfo>> Excel_underlyingCalcInfo::getExcel_underlyingInfo()
{
   if(!this->excel_underlyingInfoIsNull_){
        return this->excel_underlyingInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Excel_underlyingInfo>>();
   }
}
}

