// Excel_returnCalcInfo.cpp 
#include "Excel_returnCalcInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_returnCalcInfo::Excel_returnCalcInfo(TiXmlNode* xmlNode)
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

   //excel_constReturnCalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_constReturnCalNode = xmlNode->FirstChildElement("excel_constReturnCal");

   if(excel_constReturnCalNode){excel_constReturnCalIsNull_ = false;}
   else{excel_constReturnCalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_constReturnCalNode , address : " << excel_constReturnCalNode << std::endl;
   #endif
   if(excel_constReturnCalNode)
   {
       excel_constReturnCal_ = boost::shared_ptr<Excel_constReturnCal>(new Excel_constReturnCal(excel_constReturnCalNode));
   }

   //excel_vanillaReturnCalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_vanillaReturnCalNode = xmlNode->FirstChildElement("excel_vanillaReturnCal");

   if(excel_vanillaReturnCalNode){excel_vanillaReturnCalIsNull_ = false;}
   else{excel_vanillaReturnCalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_vanillaReturnCalNode , address : " << excel_vanillaReturnCalNode << std::endl;
   #endif
   if(excel_vanillaReturnCalNode)
   {
       excel_vanillaReturnCal_ = boost::shared_ptr<Excel_vanillaReturnCal>(new Excel_vanillaReturnCal(excel_vanillaReturnCalNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_returnCalcInfo::getExcel_type()
{
   if(!this->excel_typeIsNull_){
        return this->excel_type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_constReturnCal> Excel_returnCalcInfo::getExcel_constReturnCal()
{
   if(!this->excel_constReturnCalIsNull_){
        return this->excel_constReturnCal_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_constReturnCal>();
   }
}
boost::shared_ptr<Excel_vanillaReturnCal> Excel_returnCalcInfo::getExcel_vanillaReturnCal()
{
   if(!this->excel_vanillaReturnCalIsNull_){
        return this->excel_vanillaReturnCal_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_vanillaReturnCal>();
   }
}
}

