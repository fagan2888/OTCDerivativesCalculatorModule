// Excel_couponSchedule.cpp 
#include "Excel_couponSchedule.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_couponSchedule::Excel_couponSchedule(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //excel_typeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_typeNode = xmlNode->FirstChildElement("excel_type");

   if(excel_typeNode){excel_typeIsNull_ = false;}
   else{excel_typeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_typeNode , address : " << excel_typeNode << std::endl;
   #endif
   if(excel_typeNode)
   {
       excel_type_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(excel_typeNode));
   }

   //excel_additionalOptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_additionalOptionNode = xmlNode->FirstChildElement("excel_additionalOption");

   if(excel_additionalOptionNode){excel_additionalOptionIsNull_ = false;}
   else{excel_additionalOptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_additionalOptionNode , address : " << excel_additionalOptionNode << std::endl;
   #endif
   if(excel_additionalOptionNode)
   {
       excel_additionalOption_ = boost::shared_ptr<Excel_additionalOption>(new Excel_additionalOption(excel_additionalOptionNode));
   }

   //excel_fixedCouponScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_fixedCouponScheduleNode = xmlNode->FirstChildElement("excel_fixedCouponSchedule");

   if(excel_fixedCouponScheduleNode){excel_fixedCouponScheduleIsNull_ = false;}
   else{excel_fixedCouponScheduleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_fixedCouponScheduleNode , address : " << excel_fixedCouponScheduleNode << std::endl;
   #endif
   if(excel_fixedCouponScheduleNode)
   {
       excel_fixedCouponSchedule_ = boost::shared_ptr<Excel_fixedCouponSchedule>(new Excel_fixedCouponSchedule(excel_fixedCouponScheduleNode));
   }

   //excel_vanillaFloatingCouponScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_vanillaFloatingCouponScheduleNode = xmlNode->FirstChildElement("excel_vanillaFloatingCouponSchedule");

   if(excel_vanillaFloatingCouponScheduleNode){excel_vanillaFloatingCouponScheduleIsNull_ = false;}
   else{excel_vanillaFloatingCouponScheduleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_vanillaFloatingCouponScheduleNode , address : " << excel_vanillaFloatingCouponScheduleNode << std::endl;
   #endif
   if(excel_vanillaFloatingCouponScheduleNode)
   {
       excel_vanillaFloatingCouponSchedule_ = boost::shared_ptr<Excel_vanillaFloatingCouponSchedule>(new Excel_vanillaFloatingCouponSchedule(excel_vanillaFloatingCouponScheduleNode));
   }

   //excel_floatingCouponScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_floatingCouponScheduleNode = xmlNode->FirstChildElement("excel_floatingCouponSchedule");

   if(excel_floatingCouponScheduleNode){excel_floatingCouponScheduleIsNull_ = false;}
   else{excel_floatingCouponScheduleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_floatingCouponScheduleNode , address : " << excel_floatingCouponScheduleNode << std::endl;
   #endif
   if(excel_floatingCouponScheduleNode)
   {
       excel_floatingCouponSchedule_ = boost::shared_ptr<Excel_floatingCouponSchedule>(new Excel_floatingCouponSchedule(excel_floatingCouponScheduleNode));
   }

   //excel_condi_structuredCouponScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_condi_structuredCouponScheduleNode = xmlNode->FirstChildElement("excel_condi_structuredCouponSchedule");

   if(excel_condi_structuredCouponScheduleNode){excel_condi_structuredCouponScheduleIsNull_ = false;}
   else{excel_condi_structuredCouponScheduleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_condi_structuredCouponScheduleNode , address : " << excel_condi_structuredCouponScheduleNode << std::endl;
   #endif
   if(excel_condi_structuredCouponScheduleNode)
   {
       excel_condi_structuredCouponSchedule_ = boost::shared_ptr<Excel_condi_structuredCouponSchedule>(new Excel_condi_structuredCouponSchedule(excel_condi_structuredCouponScheduleNode));
   }

   //excel_condi_structuredAccrualCouponScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_condi_structuredAccrualCouponScheduleNode = xmlNode->FirstChildElement("excel_condi_structuredAccrualCouponSchedule");

   if(excel_condi_structuredAccrualCouponScheduleNode){excel_condi_structuredAccrualCouponScheduleIsNull_ = false;}
   else{excel_condi_structuredAccrualCouponScheduleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_condi_structuredAccrualCouponScheduleNode , address : " << excel_condi_structuredAccrualCouponScheduleNode << std::endl;
   #endif
   if(excel_condi_structuredAccrualCouponScheduleNode)
   {
       excel_condi_structuredAccrualCouponSchedule_ = boost::shared_ptr<Excel_condi_structuredAccrualCouponSchedule>(new Excel_condi_structuredAccrualCouponSchedule(excel_condi_structuredAccrualCouponScheduleNode));
   }

   //excel_multiCondi_structuredCouponScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_multiCondi_structuredCouponScheduleNode = xmlNode->FirstChildElement("excel_multiCondi_structuredCouponSchedule");

   if(excel_multiCondi_structuredCouponScheduleNode){excel_multiCondi_structuredCouponScheduleIsNull_ = false;}
   else{excel_multiCondi_structuredCouponScheduleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_multiCondi_structuredCouponScheduleNode , address : " << excel_multiCondi_structuredCouponScheduleNode << std::endl;
   #endif
   if(excel_multiCondi_structuredCouponScheduleNode)
   {
       excel_multiCondi_structuredCouponSchedule_ = boost::shared_ptr<Excel_multiCondi_structuredCouponSchedule>(new Excel_multiCondi_structuredCouponSchedule(excel_multiCondi_structuredCouponScheduleNode));
   }

   //excel_multiCondi_structuredAccrualCouponScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_multiCondi_structuredAccrualCouponScheduleNode = xmlNode->FirstChildElement("excel_multiCondi_structuredAccrualCouponSchedule");

   if(excel_multiCondi_structuredAccrualCouponScheduleNode){excel_multiCondi_structuredAccrualCouponScheduleIsNull_ = false;}
   else{excel_multiCondi_structuredAccrualCouponScheduleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_multiCondi_structuredAccrualCouponScheduleNode , address : " << excel_multiCondi_structuredAccrualCouponScheduleNode << std::endl;
   #endif
   if(excel_multiCondi_structuredAccrualCouponScheduleNode)
   {
       excel_multiCondi_structuredAccrualCouponSchedule_ = boost::shared_ptr<Excel_multiCondi_structuredAccrualCouponSchedule>(new Excel_multiCondi_structuredAccrualCouponSchedule(excel_multiCondi_structuredAccrualCouponScheduleNode));
   }

   //excel_multiCondi_multiRng_structuredAccrualCouponScheduleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_multiCondi_multiRng_structuredAccrualCouponScheduleNode = xmlNode->FirstChildElement("excel_multiCondi_multiRng_structuredAccrualCouponSchedule");

   if(excel_multiCondi_multiRng_structuredAccrualCouponScheduleNode){excel_multiCondi_multiRng_structuredAccrualCouponScheduleIsNull_ = false;}
   else{excel_multiCondi_multiRng_structuredAccrualCouponScheduleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_multiCondi_multiRng_structuredAccrualCouponScheduleNode , address : " << excel_multiCondi_multiRng_structuredAccrualCouponScheduleNode << std::endl;
   #endif
   if(excel_multiCondi_multiRng_structuredAccrualCouponScheduleNode)
   {
       excel_multiCondi_multiRng_structuredAccrualCouponSchedule_ = boost::shared_ptr<Excel_multiCondi_multiRng_structuredAccrualCouponSchedule>(new Excel_multiCondi_multiRng_structuredAccrualCouponSchedule(excel_multiCondi_multiRng_structuredAccrualCouponScheduleNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_couponSchedule::getExcel_type()
{
   if(!this->excel_typeIsNull_){
        return this->excel_type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_additionalOption> Excel_couponSchedule::getExcel_additionalOption()
{
   if(!this->excel_additionalOptionIsNull_){
        return this->excel_additionalOption_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_additionalOption>();
   }
}
boost::shared_ptr<Excel_fixedCouponSchedule> Excel_couponSchedule::getExcel_fixedCouponSchedule()
{
   if(!this->excel_fixedCouponScheduleIsNull_){
        return this->excel_fixedCouponSchedule_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_fixedCouponSchedule>();
   }
}
boost::shared_ptr<Excel_vanillaFloatingCouponSchedule> Excel_couponSchedule::getExcel_vanillaFloatingCouponSchedule()
{
   if(!this->excel_vanillaFloatingCouponScheduleIsNull_){
        return this->excel_vanillaFloatingCouponSchedule_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_vanillaFloatingCouponSchedule>();
   }
}
boost::shared_ptr<Excel_floatingCouponSchedule> Excel_couponSchedule::getExcel_floatingCouponSchedule()
{
   if(!this->excel_floatingCouponScheduleIsNull_){
        return this->excel_floatingCouponSchedule_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_floatingCouponSchedule>();
   }
}
boost::shared_ptr<Excel_condi_structuredCouponSchedule> Excel_couponSchedule::getExcel_condi_structuredCouponSchedule()
{
   if(!this->excel_condi_structuredCouponScheduleIsNull_){
        return this->excel_condi_structuredCouponSchedule_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_condi_structuredCouponSchedule>();
   }
}
boost::shared_ptr<Excel_condi_structuredAccrualCouponSchedule> Excel_couponSchedule::getExcel_condi_structuredAccrualCouponSchedule()
{
   if(!this->excel_condi_structuredAccrualCouponScheduleIsNull_){
        return this->excel_condi_structuredAccrualCouponSchedule_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_condi_structuredAccrualCouponSchedule>();
   }
}
boost::shared_ptr<Excel_multiCondi_structuredCouponSchedule> Excel_couponSchedule::getExcel_multiCondi_structuredCouponSchedule()
{
   if(!this->excel_multiCondi_structuredCouponScheduleIsNull_){
        return this->excel_multiCondi_structuredCouponSchedule_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_multiCondi_structuredCouponSchedule>();
   }
}
boost::shared_ptr<Excel_multiCondi_structuredAccrualCouponSchedule> Excel_couponSchedule::getExcel_multiCondi_structuredAccrualCouponSchedule()
{
   if(!this->excel_multiCondi_structuredAccrualCouponScheduleIsNull_){
        return this->excel_multiCondi_structuredAccrualCouponSchedule_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_multiCondi_structuredAccrualCouponSchedule>();
   }
}
boost::shared_ptr<Excel_multiCondi_multiRng_structuredAccrualCouponSchedule> Excel_couponSchedule::getExcel_multiCondi_multiRng_structuredAccrualCouponSchedule()
{
   if(!this->excel_multiCondi_multiRng_structuredAccrualCouponScheduleIsNull_){
        return this->excel_multiCondi_multiRng_structuredAccrualCouponSchedule_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_multiCondi_multiRng_structuredAccrualCouponSchedule>();
   }
}
}

