// Excel_hifive_subtype.cpp 
#include "Excel_hifive_subtype.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_hifive_subtype::Excel_hifive_subtype(TiXmlNode* xmlNode)
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

   //excel_hifive_stepDown_kiNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_hifive_stepDown_kiNode = xmlNode->FirstChildElement("excel_hifive_stepDown_ki");

   if(excel_hifive_stepDown_kiNode){excel_hifive_stepDown_kiIsNull_ = false;}
   else{excel_hifive_stepDown_kiIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_hifive_stepDown_kiNode , address : " << excel_hifive_stepDown_kiNode << std::endl;
   #endif
   if(excel_hifive_stepDown_kiNode)
   {
       excel_hifive_stepDown_ki_ = boost::shared_ptr<Excel_hifive_stepDown_ki>(new Excel_hifive_stepDown_ki(excel_hifive_stepDown_kiNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_hifive_subtype::getExcel_type()
{
   if(!this->excel_typeIsNull_){
        return this->excel_type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_hifive_stepDown_ki> Excel_hifive_subtype::getExcel_hifive_stepDown_ki()
{
   if(!this->excel_hifive_stepDown_kiIsNull_){
        return this->excel_hifive_stepDown_ki_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_hifive_stepDown_ki>();
   }
}
}

