// Excel_fixedBond.cpp 
#include "Excel_fixedBond.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_fixedBond::Excel_fixedBond(TiXmlNode* xmlNode)
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

   //excel_fixedCouponScheduleListNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_fixedCouponScheduleListNode = xmlNode->FirstChildElement("excel_fixedCouponScheduleList");

   if(excel_fixedCouponScheduleListNode){excel_fixedCouponScheduleListIsNull_ = false;}
   else{excel_fixedCouponScheduleListIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_fixedCouponScheduleListNode , address : " << excel_fixedCouponScheduleListNode << std::endl;
   #endif
   if(excel_fixedCouponScheduleListNode)
   {
       excel_fixedCouponScheduleList_ = boost::shared_ptr<Excel_fixedCouponScheduleList>(new Excel_fixedCouponScheduleList(excel_fixedCouponScheduleListNode));
   }

   //excel_fixedBond_subtypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_fixedBond_subtypeNode = xmlNode->FirstChildElement("excel_fixedBond_subtype");

   if(excel_fixedBond_subtypeNode){excel_fixedBond_subtypeIsNull_ = false;}
   else{excel_fixedBond_subtypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_fixedBond_subtypeNode , address : " << excel_fixedBond_subtypeNode << std::endl;
   #endif
   if(excel_fixedBond_subtypeNode)
   {
       excel_fixedBond_subtype_ = boost::shared_ptr<Excel_fixedBond_subtype>(new Excel_fixedBond_subtype(excel_fixedBond_subtypeNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Excel_issueInfo> Excel_fixedBond::getExcel_issueInfo()
{
   if(!this->excel_issueInfoIsNull_){
        return this->excel_issueInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_issueInfo>();
   }
}
boost::shared_ptr<Excel_fixedCouponScheduleList> Excel_fixedBond::getExcel_fixedCouponScheduleList()
{
   if(!this->excel_fixedCouponScheduleListIsNull_){
        return this->excel_fixedCouponScheduleList_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_fixedCouponScheduleList>();
   }
}
boost::shared_ptr<Excel_fixedBond_subtype> Excel_fixedBond::getExcel_fixedBond_subtype()
{
   if(!this->excel_fixedBond_subtypeIsNull_){
        return this->excel_fixedBond_subtype_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_fixedBond_subtype>();
   }
}
}

