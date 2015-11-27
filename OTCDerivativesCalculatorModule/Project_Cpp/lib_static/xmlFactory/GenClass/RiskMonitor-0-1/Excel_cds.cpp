// Excel_cds.cpp 
#include "Excel_cds.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_cds::Excel_cds(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //excel_swapLegNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_swapLegNode = xmlNode->FirstChildElement("excel_swapLeg");

   if(excel_swapLegNode){excel_swapLegIsNull_ = false;}
   else{excel_swapLegIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_swapLegNode , address : " << excel_swapLegNode << std::endl;
   #endif
   if(excel_swapLegNode)
   {
       excel_swapLeg_ = boost::shared_ptr<Excel_swapLeg>(new Excel_swapLeg(excel_swapLegNode));
   }

   //excel_creditEventSwapLegNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_creditEventSwapLegNode = xmlNode->FirstChildElement("excel_creditEventSwapLeg");

   if(excel_creditEventSwapLegNode){excel_creditEventSwapLegIsNull_ = false;}
   else{excel_creditEventSwapLegIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_creditEventSwapLegNode , address : " << excel_creditEventSwapLegNode << std::endl;
   #endif
   if(excel_creditEventSwapLegNode)
   {
       excel_creditEventSwapLeg_ = boost::shared_ptr<Excel_creditEventSwapLeg>(new Excel_creditEventSwapLeg(excel_creditEventSwapLegNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Excel_swapLeg> Excel_cds::getExcel_swapLeg()
{
   if(!this->excel_swapLegIsNull_){
        return this->excel_swapLeg_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_swapLeg>();
   }
}
boost::shared_ptr<Excel_creditEventSwapLeg> Excel_cds::getExcel_creditEventSwapLeg()
{
   if(!this->excel_creditEventSwapLegIsNull_){
        return this->excel_creditEventSwapLeg_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_creditEventSwapLeg>();
   }
}
}

