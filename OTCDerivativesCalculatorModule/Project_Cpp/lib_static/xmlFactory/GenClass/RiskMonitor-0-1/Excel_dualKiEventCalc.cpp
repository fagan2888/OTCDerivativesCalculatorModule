// Excel_dualKiEventCalc.cpp 
#include "Excel_dualKiEventCalc.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_dualKiEventCalc::Excel_dualKiEventCalc(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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

   if(excel_eventCalcInfoNode)
   {
      for(excel_eventCalcInfoNode; excel_eventCalcInfoNode; excel_eventCalcInfoNode = excel_eventCalcInfoNode->NextSiblingElement("excel_eventCalcInfo")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_eventCalcInfoNode , address : " << excel_eventCalcInfoNode << std::endl;
          #endif
          excel_eventCalcInfo_.push_back(boost::shared_ptr<Excel_eventCalcInfo>(new Excel_eventCalcInfo(excel_eventCalcInfoNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_eventCalcInfoNode , address : " << excel_eventCalcInfoNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_dualKiEventCalc::getVba_description()
{
   if(!this->vba_descriptionIsNull_){
        return this->vba_description_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
std::vector<boost::shared_ptr<Excel_eventCalcInfo>> Excel_dualKiEventCalc::getExcel_eventCalcInfo()
{
   if(!this->excel_eventCalcInfoIsNull_){
        return this->excel_eventCalcInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Excel_eventCalcInfo>>();
   }
}
}

