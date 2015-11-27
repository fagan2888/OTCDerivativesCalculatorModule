// Excel_simpleCalculation.cpp 
#include "Excel_simpleCalculation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_simpleCalculation::Excel_simpleCalculation(TiXmlNode* xmlNode)
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

   //descriptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* descriptionNode = xmlNode->FirstChildElement("description");

   if(descriptionNode){descriptionIsNull_ = false;}
   else{descriptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- descriptionNode , address : " << descriptionNode << std::endl;
   #endif
   if(descriptionNode)
   {
       description_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(descriptionNode));
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

   //excel_returnCalcInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_returnCalcInfoNode = xmlNode->FirstChildElement("excel_returnCalcInfo");

   if(excel_returnCalcInfoNode){excel_returnCalcInfoIsNull_ = false;}
   else{excel_returnCalcInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_returnCalcInfoNode , address : " << excel_returnCalcInfoNode << std::endl;
   #endif
   if(excel_returnCalcInfoNode)
   {
       excel_returnCalcInfo_ = boost::shared_ptr<Excel_returnCalcInfo>(new Excel_returnCalcInfo(excel_returnCalcInfoNode));
   }

   //excel_complementReturnCalcNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_complementReturnCalcNode = xmlNode->FirstChildElement("excel_complementReturnCalc");

   if(excel_complementReturnCalcNode){excel_complementReturnCalcIsNull_ = false;}
   else{excel_complementReturnCalcIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_complementReturnCalcNode , address : " << excel_complementReturnCalcNode << std::endl;
   #endif
   if(excel_complementReturnCalcNode)
   {
       excel_complementReturnCalc_ = boost::shared_ptr<Excel_complementReturnCalc>(new Excel_complementReturnCalc(excel_complementReturnCalcNode));
   }

   //excel_eventCalcInfo_CallNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_eventCalcInfo_CallNode = xmlNode->FirstChildElement("excel_eventCalcInfo_Call");

   if(excel_eventCalcInfo_CallNode){excel_eventCalcInfo_CallIsNull_ = false;}
   else{excel_eventCalcInfo_CallIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_eventCalcInfo_CallNode , address : " << excel_eventCalcInfo_CallNode << std::endl;
   #endif
   if(excel_eventCalcInfo_CallNode)
   {
       excel_eventCalcInfo_Call_ = boost::shared_ptr<Excel_eventCalcInfo_Call>(new Excel_eventCalcInfo_Call(excel_eventCalcInfo_CallNode));
   }

   //excel_returnCalcInfo_CallNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_returnCalcInfo_CallNode = xmlNode->FirstChildElement("excel_returnCalcInfo_Call");

   if(excel_returnCalcInfo_CallNode){excel_returnCalcInfo_CallIsNull_ = false;}
   else{excel_returnCalcInfo_CallIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_returnCalcInfo_CallNode , address : " << excel_returnCalcInfo_CallNode << std::endl;
   #endif
   if(excel_returnCalcInfo_CallNode)
   {
       excel_returnCalcInfo_Call_ = boost::shared_ptr<Excel_returnCalcInfo_Call>(new Excel_returnCalcInfo_Call(excel_returnCalcInfo_CallNode));
   }

   //excel_complementReturnCalc_CallNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_complementReturnCalc_CallNode = xmlNode->FirstChildElement("excel_complementReturnCalc_Call");

   if(excel_complementReturnCalc_CallNode){excel_complementReturnCalc_CallIsNull_ = false;}
   else{excel_complementReturnCalc_CallIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_complementReturnCalc_CallNode , address : " << excel_complementReturnCalc_CallNode << std::endl;
   #endif
   if(excel_complementReturnCalc_CallNode)
   {
       excel_complementReturnCalc_Call_ = boost::shared_ptr<Excel_complementReturnCalc_Call>(new Excel_complementReturnCalc_Call(excel_complementReturnCalc_CallNode));
   }

   //excel_returnCalcInfo_CallableOptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_returnCalcInfo_CallableOptionNode = xmlNode->FirstChildElement("excel_returnCalcInfo_CallableOption");

   if(excel_returnCalcInfo_CallableOptionNode){excel_returnCalcInfo_CallableOptionIsNull_ = false;}
   else{excel_returnCalcInfo_CallableOptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_returnCalcInfo_CallableOptionNode , address : " << excel_returnCalcInfo_CallableOptionNode << std::endl;
   #endif
   if(excel_returnCalcInfo_CallableOptionNode)
   {
       excel_returnCalcInfo_CallableOption_ = boost::shared_ptr<Excel_returnCalcInfo_CallableOption>(new Excel_returnCalcInfo_CallableOption(excel_returnCalcInfo_CallableOptionNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_simpleCalculation::getEventDate()
{
   if(!this->eventDateIsNull_){
        return this->eventDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_simpleCalculation::getPayoffDate()
{
   if(!this->payoffDateIsNull_){
        return this->payoffDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_simpleCalculation::getDescription()
{
   if(!this->descriptionIsNull_){
        return this->description_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_simpleCalculation::getVba_description()
{
   if(!this->vba_descriptionIsNull_){
        return this->vba_description_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_eventCalcInfo> Excel_simpleCalculation::getExcel_eventCalcInfo()
{
   if(!this->excel_eventCalcInfoIsNull_){
        return this->excel_eventCalcInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_eventCalcInfo>();
   }
}
boost::shared_ptr<Excel_returnCalcInfo> Excel_simpleCalculation::getExcel_returnCalcInfo()
{
   if(!this->excel_returnCalcInfoIsNull_){
        return this->excel_returnCalcInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_returnCalcInfo>();
   }
}
boost::shared_ptr<Excel_complementReturnCalc> Excel_simpleCalculation::getExcel_complementReturnCalc()
{
   if(!this->excel_complementReturnCalcIsNull_){
        return this->excel_complementReturnCalc_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_complementReturnCalc>();
   }
}
boost::shared_ptr<Excel_eventCalcInfo_Call> Excel_simpleCalculation::getExcel_eventCalcInfo_Call()
{
   if(!this->excel_eventCalcInfo_CallIsNull_){
        return this->excel_eventCalcInfo_Call_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_eventCalcInfo_Call>();
   }
}
boost::shared_ptr<Excel_returnCalcInfo_Call> Excel_simpleCalculation::getExcel_returnCalcInfo_Call()
{
   if(!this->excel_returnCalcInfo_CallIsNull_){
        return this->excel_returnCalcInfo_Call_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_returnCalcInfo_Call>();
   }
}
boost::shared_ptr<Excel_complementReturnCalc_Call> Excel_simpleCalculation::getExcel_complementReturnCalc_Call()
{
   if(!this->excel_complementReturnCalc_CallIsNull_){
        return this->excel_complementReturnCalc_Call_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_complementReturnCalc_Call>();
   }
}
boost::shared_ptr<Excel_returnCalcInfo_CallableOption> Excel_simpleCalculation::getExcel_returnCalcInfo_CallableOption()
{
   if(!this->excel_returnCalcInfo_CallableOptionIsNull_){
        return this->excel_returnCalcInfo_CallableOption_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_returnCalcInfo_CallableOption>();
   }
}
}

