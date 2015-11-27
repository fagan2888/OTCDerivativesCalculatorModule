// Excel_underlyingCalcInfo_para.cpp 
#include "Excel_underlyingCalcInfo_para.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_underlyingCalcInfo_para::Excel_underlyingCalcInfo_para(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //excel_underlyingInfo_paraNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_underlyingInfo_paraNode = xmlNode->FirstChildElement("excel_underlyingInfo_para");

   if(excel_underlyingInfo_paraNode){excel_underlyingInfo_paraIsNull_ = false;}
   else{excel_underlyingInfo_paraIsNull_ = true;}

   if(excel_underlyingInfo_paraNode)
   {
      for(excel_underlyingInfo_paraNode; excel_underlyingInfo_paraNode; excel_underlyingInfo_paraNode = excel_underlyingInfo_paraNode->NextSiblingElement("excel_underlyingInfo_para")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_underlyingInfo_paraNode , address : " << excel_underlyingInfo_paraNode << std::endl;
          #endif
          excel_underlyingInfo_para_.push_back(boost::shared_ptr<Excel_underlyingInfo_para>(new Excel_underlyingInfo_para(excel_underlyingInfo_paraNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_underlyingInfo_paraNode , address : " << excel_underlyingInfo_paraNode << std::endl;
       #endif
   }

   //excel_correlationInfo_paraNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_correlationInfo_paraNode = xmlNode->FirstChildElement("excel_correlationInfo_para");

   if(excel_correlationInfo_paraNode){excel_correlationInfo_paraIsNull_ = false;}
   else{excel_correlationInfo_paraIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_correlationInfo_paraNode , address : " << excel_correlationInfo_paraNode << std::endl;
   #endif
   if(excel_correlationInfo_paraNode)
   {
       excel_correlationInfo_para_ = boost::shared_ptr<Excel_correlationInfo_para>(new Excel_correlationInfo_para(excel_correlationInfo_paraNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<Excel_underlyingInfo_para>> Excel_underlyingCalcInfo_para::getExcel_underlyingInfo_para()
{
   if(!this->excel_underlyingInfo_paraIsNull_){
        return this->excel_underlyingInfo_para_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Excel_underlyingInfo_para>>();
   }
}
boost::shared_ptr<Excel_correlationInfo_para> Excel_underlyingCalcInfo_para::getExcel_correlationInfo_para()
{
   if(!this->excel_correlationInfo_paraIsNull_){
        return this->excel_correlationInfo_para_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_correlationInfo_para>();
   }
}
}

