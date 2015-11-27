// Excel_vanillaReturnCal.cpp 
#include "Excel_vanillaReturnCal.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_vanillaReturnCal::Excel_vanillaReturnCal(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //gearingNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* gearingNode = xmlNode->FirstChildElement("gearing");

   if(gearingNode){gearingIsNull_ = false;}
   else{gearingIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- gearingNode , address : " << gearingNode << std::endl;
   #endif
   if(gearingNode)
   {
       gearing_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(gearingNode));
   }

   //spreadNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* spreadNode = xmlNode->FirstChildElement("spread");

   if(spreadNode){spreadIsNull_ = false;}
   else{spreadIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- spreadNode , address : " << spreadNode << std::endl;
   #endif
   if(spreadNode)
   {
       spread_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(spreadNode));
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

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_vanillaReturnCal::getGearing()
{
   if(!this->gearingIsNull_){
        return this->gearing_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_vanillaReturnCal::getSpread()
{
   if(!this->spreadIsNull_){
        return this->spread_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_underlyingCalcID> Excel_vanillaReturnCal::getExcel_underlyingCalcID()
{
   if(!this->excel_underlyingCalcIDIsNull_){
        return this->excel_underlyingCalcID_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_underlyingCalcID>();
   }
}
}

