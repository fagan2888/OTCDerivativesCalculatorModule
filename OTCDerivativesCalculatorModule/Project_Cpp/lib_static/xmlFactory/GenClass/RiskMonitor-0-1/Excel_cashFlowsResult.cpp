// Excel_cashFlowsResult.cpp 
#include "Excel_cashFlowsResult.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_cashFlowsResult::Excel_cashFlowsResult(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //excel_cashFlowResultNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_cashFlowResultNode = xmlNode->FirstChildElement("excel_cashFlowResult");

   if(excel_cashFlowResultNode){excel_cashFlowResultIsNull_ = false;}
   else{excel_cashFlowResultIsNull_ = true;}

   if(excel_cashFlowResultNode)
   {
      for(excel_cashFlowResultNode; excel_cashFlowResultNode; excel_cashFlowResultNode = excel_cashFlowResultNode->NextSiblingElement("excel_cashFlowResult")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_cashFlowResultNode , address : " << excel_cashFlowResultNode << std::endl;
          #endif
          excel_cashFlowResult_.push_back(boost::shared_ptr<Excel_cashFlowResult>(new Excel_cashFlowResult(excel_cashFlowResultNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_cashFlowResultNode , address : " << excel_cashFlowResultNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<Excel_cashFlowResult>> Excel_cashFlowsResult::getExcel_cashFlowResult()
{
   if(!this->excel_cashFlowResultIsNull_){
        return this->excel_cashFlowResult_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Excel_cashFlowResult>>();
   }
}
}

