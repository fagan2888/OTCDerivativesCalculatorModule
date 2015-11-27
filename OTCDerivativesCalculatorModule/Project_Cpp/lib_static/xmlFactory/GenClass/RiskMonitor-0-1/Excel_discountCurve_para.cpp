// Excel_discountCurve_para.cpp 
#include "Excel_discountCurve_para.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_discountCurve_para::Excel_discountCurve_para(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //excel_yieldCurveNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_yieldCurveNode = xmlNode->FirstChildElement("excel_yieldCurve");

   if(excel_yieldCurveNode){excel_yieldCurveIsNull_ = false;}
   else{excel_yieldCurveIsNull_ = true;}

   if(excel_yieldCurveNode)
   {
      for(excel_yieldCurveNode; excel_yieldCurveNode; excel_yieldCurveNode = excel_yieldCurveNode->NextSiblingElement("excel_yieldCurve")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_yieldCurveNode , address : " << excel_yieldCurveNode << std::endl;
          #endif
          excel_yieldCurve_.push_back(boost::shared_ptr<Excel_yieldCurve>(new Excel_yieldCurve(excel_yieldCurveNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_yieldCurveNode , address : " << excel_yieldCurveNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<Excel_yieldCurve>> Excel_discountCurve_para::getExcel_yieldCurve()
{
   if(!this->excel_yieldCurveIsNull_){
        return this->excel_yieldCurve_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Excel_yieldCurve>>();
   }
}
}

