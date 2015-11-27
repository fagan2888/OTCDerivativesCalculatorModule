// Excel_correlationInfo_para.cpp 
#include "Excel_correlationInfo_para.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_correlationInfo_para::Excel_correlationInfo_para(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //dimensionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dimensionNode = xmlNode->FirstChildElement("dimension");

   if(dimensionNode){dimensionIsNull_ = false;}
   else{dimensionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dimensionNode , address : " << dimensionNode << std::endl;
   #endif
   if(dimensionNode)
   {
       dimension_ = boost::shared_ptr<XsdTypeInteger>(new XsdTypeInteger(dimensionNode));
   }

   //excel_correlation_paraNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_correlation_paraNode = xmlNode->FirstChildElement("excel_correlation_para");

   if(excel_correlation_paraNode){excel_correlation_paraIsNull_ = false;}
   else{excel_correlation_paraIsNull_ = true;}

   if(excel_correlation_paraNode)
   {
      for(excel_correlation_paraNode; excel_correlation_paraNode; excel_correlation_paraNode = excel_correlation_paraNode->NextSiblingElement("excel_correlation_para")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_correlation_paraNode , address : " << excel_correlation_paraNode << std::endl;
          #endif
          excel_correlation_para_.push_back(boost::shared_ptr<Excel_correlation_para>(new Excel_correlation_para(excel_correlation_paraNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_correlation_paraNode , address : " << excel_correlation_paraNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeInteger> Excel_correlationInfo_para::getDimension()
{
   if(!this->dimensionIsNull_){
        return this->dimension_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeInteger>();
   }
}
std::vector<boost::shared_ptr<Excel_correlation_para>> Excel_correlationInfo_para::getExcel_correlation_para()
{
   if(!this->excel_correlation_paraIsNull_){
        return this->excel_correlation_para_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Excel_correlation_para>>();
   }
}
}

