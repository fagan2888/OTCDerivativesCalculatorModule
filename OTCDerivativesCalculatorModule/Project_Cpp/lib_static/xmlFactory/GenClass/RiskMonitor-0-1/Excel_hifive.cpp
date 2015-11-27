// Excel_hifive.cpp 
#include "Excel_hifive.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_hifive::Excel_hifive(TiXmlNode* xmlNode)
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

   //excel_scheduleListNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_scheduleListNode = xmlNode->FirstChildElement("excel_scheduleList");

   if(excel_scheduleListNode){excel_scheduleListIsNull_ = false;}
   else{excel_scheduleListIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_scheduleListNode , address : " << excel_scheduleListNode << std::endl;
   #endif
   if(excel_scheduleListNode)
   {
       excel_scheduleList_ = boost::shared_ptr<Excel_scheduleList>(new Excel_scheduleList(excel_scheduleListNode));
   }

   //excel_kiEventCalculationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_kiEventCalculationNode = xmlNode->FirstChildElement("excel_kiEventCalculation");

   if(excel_kiEventCalculationNode){excel_kiEventCalculationIsNull_ = false;}
   else{excel_kiEventCalculationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_kiEventCalculationNode , address : " << excel_kiEventCalculationNode << std::endl;
   #endif
   if(excel_kiEventCalculationNode)
   {
       excel_kiEventCalculation_ = boost::shared_ptr<Excel_kiEventCalculation>(new Excel_kiEventCalculation(excel_kiEventCalculationNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Excel_issueInfo> Excel_hifive::getExcel_issueInfo()
{
   if(!this->excel_issueInfoIsNull_){
        return this->excel_issueInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_issueInfo>();
   }
}
boost::shared_ptr<Excel_underlyingCalcInfo> Excel_hifive::getExcel_underlyingCalcInfo()
{
   if(!this->excel_underlyingCalcInfoIsNull_){
        return this->excel_underlyingCalcInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_underlyingCalcInfo>();
   }
}
boost::shared_ptr<Excel_hifive_subtype> Excel_hifive::getExcel_hifive_subtype()
{
   if(!this->excel_hifive_subtypeIsNull_){
        return this->excel_hifive_subtype_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_hifive_subtype>();
   }
}
boost::shared_ptr<Excel_scheduleList> Excel_hifive::getExcel_scheduleList()
{
   if(!this->excel_scheduleListIsNull_){
        return this->excel_scheduleList_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_scheduleList>();
   }
}
boost::shared_ptr<Excel_kiEventCalculation> Excel_hifive::getExcel_kiEventCalculation()
{
   if(!this->excel_kiEventCalculationIsNull_){
        return this->excel_kiEventCalculation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_kiEventCalculation>();
   }
}
}

