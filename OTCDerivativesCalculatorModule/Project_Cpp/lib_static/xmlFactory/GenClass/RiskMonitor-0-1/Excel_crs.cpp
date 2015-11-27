// Excel_crs.cpp 
#include "Excel_crs.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_crs::Excel_crs(TiXmlNode* xmlNode)
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

   if(excel_swapLegNode)
   {
      for(excel_swapLegNode; excel_swapLegNode; excel_swapLegNode = excel_swapLegNode->NextSiblingElement("excel_swapLeg")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_swapLegNode , address : " << excel_swapLegNode << std::endl;
          #endif
          excel_swapLeg_.push_back(boost::shared_ptr<Excel_swapLeg>(new Excel_swapLeg(excel_swapLegNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_swapLegNode , address : " << excel_swapLegNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<Excel_swapLeg>> Excel_crs::getExcel_swapLeg()
{
   if(!this->excel_swapLegIsNull_){
        return this->excel_swapLeg_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Excel_swapLeg>>();
   }
}
}

