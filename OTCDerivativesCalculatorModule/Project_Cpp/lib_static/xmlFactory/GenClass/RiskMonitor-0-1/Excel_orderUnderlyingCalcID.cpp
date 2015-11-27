// Excel_orderUnderlyingCalcID.cpp 
#include "Excel_orderUnderlyingCalcID.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_orderUnderlyingCalcID::Excel_orderUnderlyingCalcID(TiXmlNode* xmlNode)
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

   //nthNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nthNode = xmlNode->FirstChildElement("nth");

   if(nthNode){nthIsNull_ = false;}
   else{nthIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nthNode , address : " << nthNode << std::endl;
   #endif
   if(nthNode)
   {
       nth_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(nthNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<Excel_selectedUnderlying>> Excel_orderUnderlyingCalcID::getExcel_selectedUnderlying()
{
   if(!this->excel_selectedUnderlyingIsNull_){
        return this->excel_selectedUnderlying_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Excel_selectedUnderlying>>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_orderUnderlyingCalcID::getEventDate()
{
   if(!this->eventDateIsNull_){
        return this->eventDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_orderUnderlyingCalcID::getNth()
{
   if(!this->nthIsNull_){
        return this->nth_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

