// Excel_vanillaFloatingBond.cpp 
#include "Excel_vanillaFloatingBond.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_vanillaFloatingBond::Excel_vanillaFloatingBond(TiXmlNode* xmlNode)
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

   //excel_vanillaFloatingCouponScheduleListNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_vanillaFloatingCouponScheduleListNode = xmlNode->FirstChildElement("excel_vanillaFloatingCouponScheduleList");

   if(excel_vanillaFloatingCouponScheduleListNode){excel_vanillaFloatingCouponScheduleListIsNull_ = false;}
   else{excel_vanillaFloatingCouponScheduleListIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_vanillaFloatingCouponScheduleListNode , address : " << excel_vanillaFloatingCouponScheduleListNode << std::endl;
   #endif
   if(excel_vanillaFloatingCouponScheduleListNode)
   {
       excel_vanillaFloatingCouponScheduleList_ = boost::shared_ptr<Excel_vanillaFloatingCouponScheduleList>(new Excel_vanillaFloatingCouponScheduleList(excel_vanillaFloatingCouponScheduleListNode));
   }

   //excel_vanillaFloatingBond_subtypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_vanillaFloatingBond_subtypeNode = xmlNode->FirstChildElement("excel_vanillaFloatingBond_subtype");

   if(excel_vanillaFloatingBond_subtypeNode){excel_vanillaFloatingBond_subtypeIsNull_ = false;}
   else{excel_vanillaFloatingBond_subtypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_vanillaFloatingBond_subtypeNode , address : " << excel_vanillaFloatingBond_subtypeNode << std::endl;
   #endif
   if(excel_vanillaFloatingBond_subtypeNode)
   {
       excel_vanillaFloatingBond_subtype_ = boost::shared_ptr<Excel_vanillaFloatingBond_subtype>(new Excel_vanillaFloatingBond_subtype(excel_vanillaFloatingBond_subtypeNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Excel_issueInfo> Excel_vanillaFloatingBond::getExcel_issueInfo()
{
   if(!this->excel_issueInfoIsNull_){
        return this->excel_issueInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_issueInfo>();
   }
}
boost::shared_ptr<Excel_underlyingCalcInfo> Excel_vanillaFloatingBond::getExcel_underlyingCalcInfo()
{
   if(!this->excel_underlyingCalcInfoIsNull_){
        return this->excel_underlyingCalcInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_underlyingCalcInfo>();
   }
}
boost::shared_ptr<Excel_vanillaFloatingCouponScheduleList> Excel_vanillaFloatingBond::getExcel_vanillaFloatingCouponScheduleList()
{
   if(!this->excel_vanillaFloatingCouponScheduleListIsNull_){
        return this->excel_vanillaFloatingCouponScheduleList_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_vanillaFloatingCouponScheduleList>();
   }
}
boost::shared_ptr<Excel_vanillaFloatingBond_subtype> Excel_vanillaFloatingBond::getExcel_vanillaFloatingBond_subtype()
{
   if(!this->excel_vanillaFloatingBond_subtypeIsNull_){
        return this->excel_vanillaFloatingBond_subtype_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_vanillaFloatingBond_subtype>();
   }
}
}

