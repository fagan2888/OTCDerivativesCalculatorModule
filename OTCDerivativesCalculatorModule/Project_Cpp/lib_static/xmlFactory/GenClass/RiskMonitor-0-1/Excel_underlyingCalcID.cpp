// Excel_underlyingCalcID.cpp 
#include "Excel_underlyingCalcID.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_underlyingCalcID::Excel_underlyingCalcID(TiXmlNode* xmlNode)
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

   //calcIDNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calcIDNode = xmlNode->FirstChildElement("calcID");

   if(calcIDNode){calcIDIsNull_ = false;}
   else{calcIDIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calcIDNode , address : " << calcIDNode << std::endl;
   #endif
   if(calcIDNode)
   {
       calcID_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(calcIDNode));
   }

   //excel_choiceUnderlyingCalcIDNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_choiceUnderlyingCalcIDNode = xmlNode->FirstChildElement("excel_choiceUnderlyingCalcID");

   if(excel_choiceUnderlyingCalcIDNode){excel_choiceUnderlyingCalcIDIsNull_ = false;}
   else{excel_choiceUnderlyingCalcIDIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_choiceUnderlyingCalcIDNode , address : " << excel_choiceUnderlyingCalcIDNode << std::endl;
   #endif
   if(excel_choiceUnderlyingCalcIDNode)
   {
       excel_choiceUnderlyingCalcID_ = boost::shared_ptr<Excel_choiceUnderlyingCalcID>(new Excel_choiceUnderlyingCalcID(excel_choiceUnderlyingCalcIDNode));
   }

   //excel_maximumUnderlyingCalcIDNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_maximumUnderlyingCalcIDNode = xmlNode->FirstChildElement("excel_maximumUnderlyingCalcID");

   if(excel_maximumUnderlyingCalcIDNode){excel_maximumUnderlyingCalcIDIsNull_ = false;}
   else{excel_maximumUnderlyingCalcIDIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_maximumUnderlyingCalcIDNode , address : " << excel_maximumUnderlyingCalcIDNode << std::endl;
   #endif
   if(excel_maximumUnderlyingCalcIDNode)
   {
       excel_maximumUnderlyingCalcID_ = boost::shared_ptr<Excel_maximumUnderlyingCalcID>(new Excel_maximumUnderlyingCalcID(excel_maximumUnderlyingCalcIDNode));
   }

   //excel_minimumUnderlyingCalcIDNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_minimumUnderlyingCalcIDNode = xmlNode->FirstChildElement("excel_minimumUnderlyingCalcID");

   if(excel_minimumUnderlyingCalcIDNode){excel_minimumUnderlyingCalcIDIsNull_ = false;}
   else{excel_minimumUnderlyingCalcIDIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_minimumUnderlyingCalcIDNode , address : " << excel_minimumUnderlyingCalcIDNode << std::endl;
   #endif
   if(excel_minimumUnderlyingCalcIDNode)
   {
       excel_minimumUnderlyingCalcID_ = boost::shared_ptr<Excel_minimumUnderlyingCalcID>(new Excel_minimumUnderlyingCalcID(excel_minimumUnderlyingCalcIDNode));
   }

   //excel_averageUnderlyingCalcIDNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_averageUnderlyingCalcIDNode = xmlNode->FirstChildElement("excel_averageUnderlyingCalcID");

   if(excel_averageUnderlyingCalcIDNode){excel_averageUnderlyingCalcIDIsNull_ = false;}
   else{excel_averageUnderlyingCalcIDIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_averageUnderlyingCalcIDNode , address : " << excel_averageUnderlyingCalcIDNode << std::endl;
   #endif
   if(excel_averageUnderlyingCalcIDNode)
   {
       excel_averageUnderlyingCalcID_ = boost::shared_ptr<Excel_averageUnderlyingCalcID>(new Excel_averageUnderlyingCalcID(excel_averageUnderlyingCalcIDNode));
   }

   //excel_orderUnderlyingCalcIDNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_orderUnderlyingCalcIDNode = xmlNode->FirstChildElement("excel_orderUnderlyingCalcID");

   if(excel_orderUnderlyingCalcIDNode){excel_orderUnderlyingCalcIDIsNull_ = false;}
   else{excel_orderUnderlyingCalcIDIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_orderUnderlyingCalcIDNode , address : " << excel_orderUnderlyingCalcIDNode << std::endl;
   #endif
   if(excel_orderUnderlyingCalcIDNode)
   {
       excel_orderUnderlyingCalcID_ = boost::shared_ptr<Excel_orderUnderlyingCalcID>(new Excel_orderUnderlyingCalcID(excel_orderUnderlyingCalcIDNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_underlyingCalcID::getExcel_type()
{
   if(!this->excel_typeIsNull_){
        return this->excel_type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_underlyingCalcID::getCalcID()
{
   if(!this->calcIDIsNull_){
        return this->calcID_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_choiceUnderlyingCalcID> Excel_underlyingCalcID::getExcel_choiceUnderlyingCalcID()
{
   if(!this->excel_choiceUnderlyingCalcIDIsNull_){
        return this->excel_choiceUnderlyingCalcID_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_choiceUnderlyingCalcID>();
   }
}
boost::shared_ptr<Excel_maximumUnderlyingCalcID> Excel_underlyingCalcID::getExcel_maximumUnderlyingCalcID()
{
   if(!this->excel_maximumUnderlyingCalcIDIsNull_){
        return this->excel_maximumUnderlyingCalcID_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_maximumUnderlyingCalcID>();
   }
}
boost::shared_ptr<Excel_minimumUnderlyingCalcID> Excel_underlyingCalcID::getExcel_minimumUnderlyingCalcID()
{
   if(!this->excel_minimumUnderlyingCalcIDIsNull_){
        return this->excel_minimumUnderlyingCalcID_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_minimumUnderlyingCalcID>();
   }
}
boost::shared_ptr<Excel_averageUnderlyingCalcID> Excel_underlyingCalcID::getExcel_averageUnderlyingCalcID()
{
   if(!this->excel_averageUnderlyingCalcIDIsNull_){
        return this->excel_averageUnderlyingCalcID_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_averageUnderlyingCalcID>();
   }
}
boost::shared_ptr<Excel_orderUnderlyingCalcID> Excel_underlyingCalcID::getExcel_orderUnderlyingCalcID()
{
   if(!this->excel_orderUnderlyingCalcIDIsNull_){
        return this->excel_orderUnderlyingCalcID_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_orderUnderlyingCalcID>();
   }
}
}

