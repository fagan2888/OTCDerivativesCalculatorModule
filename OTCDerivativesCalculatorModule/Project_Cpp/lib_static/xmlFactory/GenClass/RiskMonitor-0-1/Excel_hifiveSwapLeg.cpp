// Excel_hifiveSwapLeg.cpp 
#include "Excel_hifiveSwapLeg.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_hifiveSwapLeg::Excel_hifiveSwapLeg(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //excel_swapLegInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_swapLegInfoNode = xmlNode->FirstChildElement("excel_swapLegInfo");

   if(excel_swapLegInfoNode){excel_swapLegInfoIsNull_ = false;}
   else{excel_swapLegInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_swapLegInfoNode , address : " << excel_swapLegInfoNode << std::endl;
   #endif
   if(excel_swapLegInfoNode)
   {
       excel_swapLegInfo_ = boost::shared_ptr<Excel_swapLegInfo>(new Excel_swapLegInfo(excel_swapLegInfoNode));
   }

   //excel_interfaceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_interfaceNode = xmlNode->FirstChildElement("excel_interface");

   if(excel_interfaceNode){excel_interfaceIsNull_ = false;}
   else{excel_interfaceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_interfaceNode , address : " << excel_interfaceNode << std::endl;
   #endif
   if(excel_interfaceNode)
   {
       excel_interface_ = boost::shared_ptr<Excel_interface>(new Excel_interface(excel_interfaceNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Excel_swapLegInfo> Excel_hifiveSwapLeg::getExcel_swapLegInfo()
{
   if(!this->excel_swapLegInfoIsNull_){
        return this->excel_swapLegInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_swapLegInfo>();
   }
}
boost::shared_ptr<Excel_interface> Excel_hifiveSwapLeg::getExcel_interface()
{
   if(!this->excel_interfaceIsNull_){
        return this->excel_interface_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_interface>();
   }
}
}

