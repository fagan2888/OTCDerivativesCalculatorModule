// Excel_targetKiEventCalc.cpp 
#include "Excel_targetKiEventCalc.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_targetKiEventCalc::Excel_targetKiEventCalc(TiXmlNode* xmlNode)
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

   //targetCountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* targetCountNode = xmlNode->FirstChildElement("targetCount");

   if(targetCountNode){targetCountIsNull_ = false;}
   else{targetCountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- targetCountNode , address : " << targetCountNode << std::endl;
   #endif
   if(targetCountNode)
   {
       targetCount_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(targetCountNode));
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

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_targetKiEventCalc::getEventDate()
{
   if(!this->eventDateIsNull_){
        return this->eventDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_targetKiEventCalc::getVba_description()
{
   if(!this->vba_descriptionIsNull_){
        return this->vba_description_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_targetKiEventCalc::getTargetCount()
{
   if(!this->targetCountIsNull_){
        return this->targetCount_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_eventCalcInfo> Excel_targetKiEventCalc::getExcel_eventCalcInfo()
{
   if(!this->excel_eventCalcInfoIsNull_){
        return this->excel_eventCalcInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_eventCalcInfo>();
   }
}
}

