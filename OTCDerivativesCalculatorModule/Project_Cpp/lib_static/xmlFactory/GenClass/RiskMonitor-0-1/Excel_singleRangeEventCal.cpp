// Excel_singleRangeEventCal.cpp 
#include "Excel_singleRangeEventCal.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_singleRangeEventCal::Excel_singleRangeEventCal(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //lowerRngNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* lowerRngNode = xmlNode->FirstChildElement("lowerRng");

   if(lowerRngNode){lowerRngIsNull_ = false;}
   else{lowerRngIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- lowerRngNode , address : " << lowerRngNode << std::endl;
   #endif
   if(lowerRngNode)
   {
       lowerRng_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(lowerRngNode));
   }

   //upperRngNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* upperRngNode = xmlNode->FirstChildElement("upperRng");

   if(upperRngNode){upperRngIsNull_ = false;}
   else{upperRngIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- upperRngNode , address : " << upperRngNode << std::endl;
   #endif
   if(upperRngNode)
   {
       upperRng_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(upperRngNode));
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
boost::shared_ptr<XsdTypeToken> Excel_singleRangeEventCal::getLowerRng()
{
   if(!this->lowerRngIsNull_){
        return this->lowerRng_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_singleRangeEventCal::getUpperRng()
{
   if(!this->upperRngIsNull_){
        return this->upperRng_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_underlyingCalcID> Excel_singleRangeEventCal::getExcel_underlyingCalcID()
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

