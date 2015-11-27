// Excel_referenceCalcInfo_para.cpp 
#include "Excel_referenceCalcInfo_para.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_referenceCalcInfo_para::Excel_referenceCalcInfo_para(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //excel_referenceInfo_paraNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_referenceInfo_paraNode = xmlNode->FirstChildElement("excel_referenceInfo_para");

   if(excel_referenceInfo_paraNode){excel_referenceInfo_paraIsNull_ = false;}
   else{excel_referenceInfo_paraIsNull_ = true;}

   if(excel_referenceInfo_paraNode)
   {
      for(excel_referenceInfo_paraNode; excel_referenceInfo_paraNode; excel_referenceInfo_paraNode = excel_referenceInfo_paraNode->NextSiblingElement("excel_referenceInfo_para")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_referenceInfo_paraNode , address : " << excel_referenceInfo_paraNode << std::endl;
          #endif
          excel_referenceInfo_para_.push_back(boost::shared_ptr<Excel_referenceInfo_para>(new Excel_referenceInfo_para(excel_referenceInfo_paraNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_referenceInfo_paraNode , address : " << excel_referenceInfo_paraNode << std::endl;
       #endif
   }

   //coupula_correlationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* coupula_correlationNode = xmlNode->FirstChildElement("coupula_correlation");

   if(coupula_correlationNode){coupula_correlationIsNull_ = false;}
   else{coupula_correlationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- coupula_correlationNode , address : " << coupula_correlationNode << std::endl;
   #endif
   if(coupula_correlationNode)
   {
       coupula_correlation_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(coupula_correlationNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<Excel_referenceInfo_para>> Excel_referenceCalcInfo_para::getExcel_referenceInfo_para()
{
   if(!this->excel_referenceInfo_paraIsNull_){
        return this->excel_referenceInfo_para_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Excel_referenceInfo_para>>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_referenceCalcInfo_para::getCoupula_correlation()
{
   if(!this->coupula_correlationIsNull_){
        return this->coupula_correlation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

