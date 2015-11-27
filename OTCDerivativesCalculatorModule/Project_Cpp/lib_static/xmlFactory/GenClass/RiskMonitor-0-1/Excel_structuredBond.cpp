// Excel_structuredBond.cpp 
#include "Excel_structuredBond.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_structuredBond::Excel_structuredBond(TiXmlNode* xmlNode)
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

   //excel_couponScheduleListNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_couponScheduleListNode = xmlNode->FirstChildElement("excel_couponScheduleList");

   if(excel_couponScheduleListNode){excel_couponScheduleListIsNull_ = false;}
   else{excel_couponScheduleListIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_couponScheduleListNode , address : " << excel_couponScheduleListNode << std::endl;
   #endif
   if(excel_couponScheduleListNode)
   {
       excel_couponScheduleList_ = boost::shared_ptr<Excel_couponScheduleList>(new Excel_couponScheduleList(excel_couponScheduleListNode));
   }

   //excel_structuredBond_subtypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_structuredBond_subtypeNode = xmlNode->FirstChildElement("excel_structuredBond_subtype");

   if(excel_structuredBond_subtypeNode){excel_structuredBond_subtypeIsNull_ = false;}
   else{excel_structuredBond_subtypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_structuredBond_subtypeNode , address : " << excel_structuredBond_subtypeNode << std::endl;
   #endif
   if(excel_structuredBond_subtypeNode)
   {
       excel_structuredBond_subtype_ = boost::shared_ptr<Excel_structuredBond_subtype>(new Excel_structuredBond_subtype(excel_structuredBond_subtypeNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Excel_issueInfo> Excel_structuredBond::getExcel_issueInfo()
{
   if(!this->excel_issueInfoIsNull_){
        return this->excel_issueInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_issueInfo>();
   }
}
boost::shared_ptr<Excel_underlyingCalcInfo> Excel_structuredBond::getExcel_underlyingCalcInfo()
{
   if(!this->excel_underlyingCalcInfoIsNull_){
        return this->excel_underlyingCalcInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_underlyingCalcInfo>();
   }
}
boost::shared_ptr<Excel_couponScheduleList> Excel_structuredBond::getExcel_couponScheduleList()
{
   if(!this->excel_couponScheduleListIsNull_){
        return this->excel_couponScheduleList_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_couponScheduleList>();
   }
}
boost::shared_ptr<Excel_structuredBond_subtype> Excel_structuredBond::getExcel_structuredBond_subtype()
{
   if(!this->excel_structuredBond_subtypeIsNull_){
        return this->excel_structuredBond_subtype_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_structuredBond_subtype>();
   }
}
}

