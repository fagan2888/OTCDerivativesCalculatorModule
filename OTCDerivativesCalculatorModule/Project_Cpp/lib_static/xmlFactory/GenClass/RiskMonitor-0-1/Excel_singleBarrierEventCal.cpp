// Excel_singleBarrierEventCal.cpp 
#include "Excel_singleBarrierEventCal.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_singleBarrierEventCal::Excel_singleBarrierEventCal(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //lowerTriggerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* lowerTriggerNode = xmlNode->FirstChildElement("lowerTrigger");

   if(lowerTriggerNode){lowerTriggerIsNull_ = false;}
   else{lowerTriggerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- lowerTriggerNode , address : " << lowerTriggerNode << std::endl;
   #endif
   if(lowerTriggerNode)
   {
       lowerTrigger_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(lowerTriggerNode));
   }

   //upperTriggerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* upperTriggerNode = xmlNode->FirstChildElement("upperTrigger");

   if(upperTriggerNode){upperTriggerIsNull_ = false;}
   else{upperTriggerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- upperTriggerNode , address : " << upperTriggerNode << std::endl;
   #endif
   if(upperTriggerNode)
   {
       upperTrigger_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(upperTriggerNode));
   }

   //excel_underlyingCalcIDNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_underlyingCalcIDNode = xmlNode->FirstChildElement("excel_underlyingCalcID");

   if(excel_underlyingCalcIDNode){excel_underlyingCalcIDIsNull_ = false;}
   else{excel_underlyingCalcIDIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_underlyingCalcIDNode , address : " << excel_underlyingCalcIDNode << std::endl;
   #endif
   if(excel_underlyingCalcIDNode)
   {
       excel_underlyingCalcID_ = boost::shared_ptr<Excel_underlyingCalcID>(new Excel_underlyingCalcID(excel_underlyingCalcIDNode));
   }

   //observationStartDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* observationStartDateNode = xmlNode->FirstChildElement("observationStartDate");

   if(observationStartDateNode){observationStartDateIsNull_ = false;}
   else{observationStartDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- observationStartDateNode , address : " << observationStartDateNode << std::endl;
   #endif
   if(observationStartDateNode)
   {
       observationStartDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(observationStartDateNode));
   }

   //observationEndDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* observationEndDateNode = xmlNode->FirstChildElement("observationEndDate");

   if(observationEndDateNode){observationEndDateIsNull_ = false;}
   else{observationEndDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- observationEndDateNode , address : " << observationEndDateNode << std::endl;
   #endif
   if(observationEndDateNode)
   {
       observationEndDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(observationEndDateNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_singleBarrierEventCal::getLowerTrigger()
{
   if(!this->lowerTriggerIsNull_){
        return this->lowerTrigger_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_singleBarrierEventCal::getUpperTrigger()
{
   if(!this->upperTriggerIsNull_){
        return this->upperTrigger_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_underlyingCalcID> Excel_singleBarrierEventCal::getExcel_underlyingCalcID()
{
   if(!this->excel_underlyingCalcIDIsNull_){
        return this->excel_underlyingCalcID_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_underlyingCalcID>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_singleBarrierEventCal::getObservationStartDate()
{
   if(!this->observationStartDateIsNull_){
        return this->observationStartDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_singleBarrierEventCal::getObservationEndDate()
{
   if(!this->observationEndDateIsNull_){
        return this->observationEndDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

