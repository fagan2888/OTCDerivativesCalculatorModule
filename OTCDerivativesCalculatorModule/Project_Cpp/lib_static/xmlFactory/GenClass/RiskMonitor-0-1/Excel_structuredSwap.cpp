// Excel_structuredSwap.cpp 
#include "Excel_structuredSwap.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_structuredSwap::Excel_structuredSwap(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //excel_issueInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_issueInfoNode = xmlNode->FirstChildElement("excel_issueInfo");

   if(excel_issueInfoNode){excel_issueInfoIsNull_ = false;}
   else{excel_issueInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_issueInfoNode , address : " << excel_issueInfoNode << std::endl;
   #endif
   if(excel_issueInfoNode)
   {
       excel_issueInfo_ = boost::shared_ptr<Excel_issueInfo>(new Excel_issueInfo(excel_issueInfoNode));
   }

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
boost::shared_ptr<Excel_issueInfo> Excel_structuredSwap::getExcel_issueInfo()
{
   if(!this->excel_issueInfoIsNull_){
        return this->excel_issueInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_issueInfo>();
   }
}
std::vector<boost::shared_ptr<Excel_swapLeg>> Excel_structuredSwap::getExcel_swapLeg()
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

