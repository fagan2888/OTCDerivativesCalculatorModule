// Excel_simpleKiEventCalc.cpp 
#include "Excel_simpleKiEventCalc.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_simpleKiEventCalc::Excel_simpleKiEventCalc(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //eventDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* eventDateNode = xmlNode->FirstChildElement("eventDate");

   if(eventDateNode){eventDateIsNull_ = false;}
   else{eventDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eventDateNode , address : " << eventDateNode << std::endl;
   #endif
   if(eventDateNode)
   {
       eventDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(eventDateNode));
   }

   //payoffDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* payoffDateNode = xmlNode->FirstChildElement("payoffDate");

   if(payoffDateNode){payoffDateIsNull_ = false;}
   else{payoffDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- payoffDateNode , address : " << payoffDateNode << std::endl;
   #endif
   if(payoffDateNode)
   {
       payoffDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(payoffDateNode));
   }

   //vba_descriptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* vba_descriptionNode = xmlNode->FirstChildElement("vba_description");

   if(vba_descriptionNode){vba_descriptionIsNull_ = false;}
   else{vba_descriptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- vba_descriptionNode , address : " << vba_descriptionNode << std::endl;
   #endif
   if(vba_descriptionNode)
   {
       vba_description_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(vba_descriptionNode));
   }

   //excel_eventCalcInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_eventCalcInfoNode = xmlNode->FirstChildElement("excel_eventCalcInfo");

   if(excel_eventCalcInfoNode){excel_eventCalcInfoIsNull_ = false;}
   else{excel_eventCalcInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_eventCalcInfoNode , address : " << excel_eventCalcInfoNode << std::endl;
   #endif
   if(excel_eventCalcInfoNode)
   {
       excel_eventCalcInfo_ = boost::shared_ptr<Excel_eventCalcInfo>(new Excel_eventCalcInfo(excel_eventCalcInfoNode));
   }

   //excel_occReturnCalcInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_occReturnCalcInfoNode = xmlNode->FirstChildElement("excel_occReturnCalcInfo");

   if(excel_occReturnCalcInfoNode){excel_occReturnCalcInfoIsNull_ = false;}
   else{excel_occReturnCalcInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_occReturnCalcInfoNode , address : " << excel_occReturnCalcInfoNode << std::endl;
   #endif
   if(excel_occReturnCalcInfoNode)
   {
       excel_occReturnCalcInfo_ = boost::shared_ptr<Excel_occReturnCalcInfo>(new Excel_occReturnCalcInfo(excel_occReturnCalcInfoNode));
   }

   //excel_noOccReturnCalcInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_noOccReturnCalcInfoNode = xmlNode->FirstChildElement("excel_noOccReturnCalcInfo");

   if(excel_noOccReturnCalcInfoNode){excel_noOccReturnCalcInfoIsNull_ = false;}
   else{excel_noOccReturnCalcInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_noOccReturnCalcInfoNode , address : " << excel_noOccReturnCalcInfoNode << std::endl;
   #endif
   if(excel_noOccReturnCalcInfoNode)
   {
       excel_noOccReturnCalcInfo_ = boost::shared_ptr<Excel_noOccReturnCalcInfo>(new Excel_noOccReturnCalcInfo(excel_noOccReturnCalcInfoNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_simpleKiEventCalc::getEventDate()
{
   if(!this->eventDateIsNull_){
        return this->eventDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_simpleKiEventCalc::getPayoffDate()
{
   if(!this->payoffDateIsNull_){
        return this->payoffDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_simpleKiEventCalc::getVba_description()
{
   if(!this->vba_descriptionIsNull_){
        return this->vba_description_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_eventCalcInfo> Excel_simpleKiEventCalc::getExcel_eventCalcInfo()
{
   if(!this->excel_eventCalcInfoIsNull_){
        return this->excel_eventCalcInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_eventCalcInfo>();
   }
}
boost::shared_ptr<Excel_occReturnCalcInfo> Excel_simpleKiEventCalc::getExcel_occReturnCalcInfo()
{
   if(!this->excel_occReturnCalcInfoIsNull_){
        return this->excel_occReturnCalcInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_occReturnCalcInfo>();
   }
}
boost::shared_ptr<Excel_noOccReturnCalcInfo> Excel_simpleKiEventCalc::getExcel_noOccReturnCalcInfo()
{
   if(!this->excel_noOccReturnCalcInfoIsNull_){
        return this->excel_noOccReturnCalcInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_noOccReturnCalcInfo>();
   }
}
}

