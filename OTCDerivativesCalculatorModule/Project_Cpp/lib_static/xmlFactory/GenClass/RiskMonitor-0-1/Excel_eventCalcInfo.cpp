// Excel_eventCalcInfo.cpp 
#include "Excel_eventCalcInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_eventCalcInfo::Excel_eventCalcInfo(TiXmlNode* xmlNode)
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

   //excel_singleRangeEventCalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_singleRangeEventCalNode = xmlNode->FirstChildElement("excel_singleRangeEventCal");

   if(excel_singleRangeEventCalNode){excel_singleRangeEventCalIsNull_ = false;}
   else{excel_singleRangeEventCalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_singleRangeEventCalNode , address : " << excel_singleRangeEventCalNode << std::endl;
   #endif
   if(excel_singleRangeEventCalNode)
   {
       excel_singleRangeEventCal_ = boost::shared_ptr<Excel_singleRangeEventCal>(new Excel_singleRangeEventCal(excel_singleRangeEventCalNode));
   }

   //excel_dualRangeEventCalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_dualRangeEventCalNode = xmlNode->FirstChildElement("excel_dualRangeEventCal");

   if(excel_dualRangeEventCalNode){excel_dualRangeEventCalIsNull_ = false;}
   else{excel_dualRangeEventCalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_dualRangeEventCalNode , address : " << excel_dualRangeEventCalNode << std::endl;
   #endif
   if(excel_dualRangeEventCalNode)
   {
       excel_dualRangeEventCal_ = boost::shared_ptr<Excel_dualRangeEventCal>(new Excel_dualRangeEventCal(excel_dualRangeEventCalNode));
   }

   //excel_singleBarrierEventCalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_singleBarrierEventCalNode = xmlNode->FirstChildElement("excel_singleBarrierEventCal");

   if(excel_singleBarrierEventCalNode){excel_singleBarrierEventCalIsNull_ = false;}
   else{excel_singleBarrierEventCalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_singleBarrierEventCalNode , address : " << excel_singleBarrierEventCalNode << std::endl;
   #endif
   if(excel_singleBarrierEventCalNode)
   {
       excel_singleBarrierEventCal_ = boost::shared_ptr<Excel_singleBarrierEventCal>(new Excel_singleBarrierEventCal(excel_singleBarrierEventCalNode));
   }

   //excel_dualBarrierEventCalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_dualBarrierEventCalNode = xmlNode->FirstChildElement("excel_dualBarrierEventCal");

   if(excel_dualBarrierEventCalNode){excel_dualBarrierEventCalIsNull_ = false;}
   else{excel_dualBarrierEventCalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_dualBarrierEventCalNode , address : " << excel_dualBarrierEventCalNode << std::endl;
   #endif
   if(excel_dualBarrierEventCalNode)
   {
       excel_dualBarrierEventCal_ = boost::shared_ptr<Excel_dualBarrierEventCal>(new Excel_dualBarrierEventCal(excel_dualBarrierEventCalNode));
   }

   //excel_identityEventCalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_identityEventCalNode = xmlNode->FirstChildElement("excel_identityEventCal");

   if(excel_identityEventCalNode){excel_identityEventCalIsNull_ = false;}
   else{excel_identityEventCalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_identityEventCalNode , address : " << excel_identityEventCalNode << std::endl;
   #endif
   if(excel_identityEventCalNode)
   {
       excel_identityEventCal_ = boost::shared_ptr<Excel_identityEventCal>(new Excel_identityEventCal(excel_identityEventCalNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_eventCalcInfo::getExcel_type()
{
   if(!this->excel_typeIsNull_){
        return this->excel_type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_singleRangeEventCal> Excel_eventCalcInfo::getExcel_singleRangeEventCal()
{
   if(!this->excel_singleRangeEventCalIsNull_){
        return this->excel_singleRangeEventCal_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_singleRangeEventCal>();
   }
}
boost::shared_ptr<Excel_dualRangeEventCal> Excel_eventCalcInfo::getExcel_dualRangeEventCal()
{
   if(!this->excel_dualRangeEventCalIsNull_){
        return this->excel_dualRangeEventCal_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_dualRangeEventCal>();
   }
}
boost::shared_ptr<Excel_singleBarrierEventCal> Excel_eventCalcInfo::getExcel_singleBarrierEventCal()
{
   if(!this->excel_singleBarrierEventCalIsNull_){
        return this->excel_singleBarrierEventCal_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_singleBarrierEventCal>();
   }
}
boost::shared_ptr<Excel_dualBarrierEventCal> Excel_eventCalcInfo::getExcel_dualBarrierEventCal()
{
   if(!this->excel_dualBarrierEventCalIsNull_){
        return this->excel_dualBarrierEventCal_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_dualBarrierEventCal>();
   }
}
boost::shared_ptr<Excel_identityEventCal> Excel_eventCalcInfo::getExcel_identityEventCal()
{
   if(!this->excel_identityEventCalIsNull_){
        return this->excel_identityEventCal_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_identityEventCal>();
   }
}
}

