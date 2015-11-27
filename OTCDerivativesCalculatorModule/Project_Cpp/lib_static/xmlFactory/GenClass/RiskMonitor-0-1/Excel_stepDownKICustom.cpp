// Excel_stepDownKICustom.cpp 
#include "Excel_stepDownKICustom.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_stepDownKICustom::Excel_stepDownKICustom(TiXmlNode* xmlNode)
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

   //excel_underlyingCalcInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_underlyingCalcInfoNode = xmlNode->FirstChildElement("excel_underlyingCalcInfo");

   if(excel_underlyingCalcInfoNode){excel_underlyingCalcInfoIsNull_ = false;}
   else{excel_underlyingCalcInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_underlyingCalcInfoNode , address : " << excel_underlyingCalcInfoNode << std::endl;
   #endif
   if(excel_underlyingCalcInfoNode)
   {
       excel_underlyingCalcInfo_ = boost::shared_ptr<Excel_underlyingCalcInfo>(new Excel_underlyingCalcInfo(excel_underlyingCalcInfoNode));
   }

   //excel_hifive_subtypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_hifive_subtypeNode = xmlNode->FirstChildElement("excel_hifive_subtype");

   if(excel_hifive_subtypeNode){excel_hifive_subtypeIsNull_ = false;}
   else{excel_hifive_subtypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_hifive_subtypeNode , address : " << excel_hifive_subtypeNode << std::endl;
   #endif
   if(excel_hifive_subtypeNode)
   {
       excel_hifive_subtype_ = boost::shared_ptr<Excel_hifive_subtype>(new Excel_hifive_subtype(excel_hifive_subtypeNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Excel_issueInfo> Excel_stepDownKICustom::getExcel_issueInfo()
{
   if(!this->excel_issueInfoIsNull_){
        return this->excel_issueInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_issueInfo>();
   }
}
boost::shared_ptr<Excel_underlyingCalcInfo> Excel_stepDownKICustom::getExcel_underlyingCalcInfo()
{
   if(!this->excel_underlyingCalcInfoIsNull_){
        return this->excel_underlyingCalcInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_underlyingCalcInfo>();
   }
}
boost::shared_ptr<Excel_hifive_subtype> Excel_stepDownKICustom::getExcel_hifive_subtype()
{
   if(!this->excel_hifive_subtypeIsNull_){
        return this->excel_hifive_subtype_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_hifive_subtype>();
   }
}
}

