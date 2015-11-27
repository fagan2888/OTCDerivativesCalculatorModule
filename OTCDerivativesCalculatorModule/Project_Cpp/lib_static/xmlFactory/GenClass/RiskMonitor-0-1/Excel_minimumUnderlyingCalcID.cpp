// Excel_minimumUnderlyingCalcID.cpp 
#include "Excel_minimumUnderlyingCalcID.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_minimumUnderlyingCalcID::Excel_minimumUnderlyingCalcID(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //excel_selectedUnderlyingNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_selectedUnderlyingNode = xmlNode->FirstChildElement("excel_selectedUnderlying");

   if(excel_selectedUnderlyingNode){excel_selectedUnderlyingIsNull_ = false;}
   else{excel_selectedUnderlyingIsNull_ = true;}

   if(excel_selectedUnderlyingNode)
   {
      for(excel_selectedUnderlyingNode; excel_selectedUnderlyingNode; excel_selectedUnderlyingNode = excel_selectedUnderlyingNode->NextSiblingElement("excel_selectedUnderlying")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_selectedUnderlyingNode , address : " << excel_selectedUnderlyingNode << std::endl;
          #endif
          excel_selectedUnderlying_.push_back(boost::shared_ptr<Excel_selectedUnderlying>(new Excel_selectedUnderlying(excel_selectedUnderlyingNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_selectedUnderlyingNode , address : " << excel_selectedUnderlyingNode << std::endl;
       #endif
   }

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

   //averageDaysNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* averageDaysNode = xmlNode->FirstChildElement("averageDays");

   if(averageDaysNode){averageDaysIsNull_ = false;}
   else{averageDaysIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- averageDaysNode , address : " << averageDaysNode << std::endl;
   #endif
   if(averageDaysNode)
   {
       averageDays_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(averageDaysNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<Excel_selectedUnderlying>> Excel_minimumUnderlyingCalcID::getExcel_selectedUnderlying()
{
   if(!this->excel_selectedUnderlyingIsNull_){
        return this->excel_selectedUnderlying_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Excel_selectedUnderlying>>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_minimumUnderlyingCalcID::getEventDate()
{
   if(!this->eventDateIsNull_){
        return this->eventDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_minimumUnderlyingCalcID::getAverageDays()
{
   if(!this->averageDaysIsNull_){
        return this->averageDays_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

