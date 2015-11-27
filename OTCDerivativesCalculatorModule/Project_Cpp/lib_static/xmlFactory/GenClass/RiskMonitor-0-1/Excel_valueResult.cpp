// Excel_valueResult.cpp 
#include "Excel_valueResult.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_valueResult::Excel_valueResult(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //excel_valueSideResultNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_valueSideResultNode = xmlNode->FirstChildElement("excel_valueSideResult");

   if(excel_valueSideResultNode){excel_valueSideResultIsNull_ = false;}
   else{excel_valueSideResultIsNull_ = true;}

   if(excel_valueSideResultNode)
   {
      for(excel_valueSideResultNode; excel_valueSideResultNode; excel_valueSideResultNode = excel_valueSideResultNode->NextSiblingElement("excel_valueSideResult")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_valueSideResultNode , address : " << excel_valueSideResultNode << std::endl;
          #endif
          excel_valueSideResult_.push_back(boost::shared_ptr<Excel_valueSideResult>(new Excel_valueSideResult(excel_valueSideResultNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_valueSideResultNode , address : " << excel_valueSideResultNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<Excel_valueSideResult>> Excel_valueResult::getExcel_valueSideResult()
{
   if(!this->excel_valueSideResultIsNull_){
        return this->excel_valueSideResult_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Excel_valueSideResult>>();
   }
}
}

