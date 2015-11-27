// Excel_protectionTerms.cpp 
#include "Excel_protectionTerms.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_protectionTerms::Excel_protectionTerms(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //excel_creditEventsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_creditEventsNode = xmlNode->FirstChildElement("excel_creditEvents");

   if(excel_creditEventsNode){excel_creditEventsIsNull_ = false;}
   else{excel_creditEventsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_creditEventsNode , address : " << excel_creditEventsNode << std::endl;
   #endif
   if(excel_creditEventsNode)
   {
       excel_creditEvents_ = boost::shared_ptr<Excel_creditEvents>(new Excel_creditEvents(excel_creditEventsNode));
   }

   //excel_obligationsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_obligationsNode = xmlNode->FirstChildElement("excel_obligations");

   if(excel_obligationsNode){excel_obligationsIsNull_ = false;}
   else{excel_obligationsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_obligationsNode , address : " << excel_obligationsNode << std::endl;
   #endif
   if(excel_obligationsNode)
   {
       excel_obligations_ = boost::shared_ptr<Excel_obligations>(new Excel_obligations(excel_obligationsNode));
   }

   //accrualCouponNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* accrualCouponNode = xmlNode->FirstChildElement("accrualCoupon");

   if(accrualCouponNode){accrualCouponIsNull_ = false;}
   else{accrualCouponIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- accrualCouponNode , address : " << accrualCouponNode << std::endl;
   #endif
   if(accrualCouponNode)
   {
       accrualCoupon_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(accrualCouponNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Excel_creditEvents> Excel_protectionTerms::getExcel_creditEvents()
{
   if(!this->excel_creditEventsIsNull_){
        return this->excel_creditEvents_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_creditEvents>();
   }
}
boost::shared_ptr<Excel_obligations> Excel_protectionTerms::getExcel_obligations()
{
   if(!this->excel_obligationsIsNull_){
        return this->excel_obligations_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_obligations>();
   }
}
boost::shared_ptr<XsdTypeBoolean> Excel_protectionTerms::getAccrualCoupon()
{
   if(!this->accrualCouponIsNull_){
        return this->accrualCoupon_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

