// Excel_averageUnderlyingCalcID.cpp 
#include "Excel_averageUnderlyingCalcID.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_averageUnderlyingCalcID::Excel_averageUnderlyingCalcID(TiXmlNode* xmlNode)
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

   //weightNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* weightNode = xmlNode->FirstChildElement("weight");

   if(weightNode){weightIsNull_ = false;}
   else{weightIsNull_ = true;}

   if(weightNode)
   {
      for(weightNode; weightNode; weightNode = weightNode->NextSiblingElement("weight")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- weightNode , address : " << weightNode << std::endl;
          #endif
          weight_.push_back(boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(weightNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- weightNode , address : " << weightNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<Excel_selectedUnderlying>> Excel_averageUnderlyingCalcID::getExcel_selectedUnderlying()
{
   if(!this->excel_selectedUnderlyingIsNull_){
        return this->excel_selectedUnderlying_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Excel_selectedUnderlying>>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_averageUnderlyingCalcID::getEventDate()
{
   if(!this->eventDateIsNull_){
        return this->eventDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
std::vector<boost::shared_ptr<XsdTypeToken>> Excel_averageUnderlyingCalcID::getWeight()
{
   if(!this->weightIsNull_){
        return this->weight_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<XsdTypeToken>>();
   }
}
}

