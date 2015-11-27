// Excel_defaultCurve_para.cpp 
#include "Excel_defaultCurve_para.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_defaultCurve_para::Excel_defaultCurve_para(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //excel_defaultCurveNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_defaultCurveNode = xmlNode->FirstChildElement("excel_defaultCurve");

   if(excel_defaultCurveNode){excel_defaultCurveIsNull_ = false;}
   else{excel_defaultCurveIsNull_ = true;}

   if(excel_defaultCurveNode)
   {
      for(excel_defaultCurveNode; excel_defaultCurveNode; excel_defaultCurveNode = excel_defaultCurveNode->NextSiblingElement("excel_defaultCurve")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_defaultCurveNode , address : " << excel_defaultCurveNode << std::endl;
          #endif
          excel_defaultCurve_.push_back(boost::shared_ptr<Excel_defaultCurve>(new Excel_defaultCurve(excel_defaultCurveNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_defaultCurveNode , address : " << excel_defaultCurveNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<Excel_defaultCurve>> Excel_defaultCurve_para::getExcel_defaultCurve()
{
   if(!this->excel_defaultCurveIsNull_){
        return this->excel_defaultCurve_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Excel_defaultCurve>>();
   }
}
}

