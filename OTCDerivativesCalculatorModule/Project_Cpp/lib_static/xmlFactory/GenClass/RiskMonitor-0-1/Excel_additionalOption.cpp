// Excel_additionalOption.cpp 
#include "Excel_additionalOption.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_additionalOption::Excel_additionalOption(TiXmlNode* xmlNode)
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

   //excel_noneOptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_noneOptionNode = xmlNode->FirstChildElement("excel_noneOption");

   if(excel_noneOptionNode){excel_noneOptionIsNull_ = false;}
   else{excel_noneOptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_noneOptionNode , address : " << excel_noneOptionNode << std::endl;
   #endif
   if(excel_noneOptionNode)
   {
       excel_noneOption_ = boost::shared_ptr<Excel_noneOption>(new Excel_noneOption(excel_noneOptionNode));
   }

   //excel_callableOptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_callableOptionNode = xmlNode->FirstChildElement("excel_callableOption");

   if(excel_callableOptionNode){excel_callableOptionIsNull_ = false;}
   else{excel_callableOptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_callableOptionNode , address : " << excel_callableOptionNode << std::endl;
   #endif
   if(excel_callableOptionNode)
   {
       excel_callableOption_ = boost::shared_ptr<Excel_callableOption>(new Excel_callableOption(excel_callableOptionNode));
   }

   //excel_puttableOptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_puttableOptionNode = xmlNode->FirstChildElement("excel_puttableOption");

   if(excel_puttableOptionNode){excel_puttableOptionIsNull_ = false;}
   else{excel_puttableOptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_puttableOptionNode , address : " << excel_puttableOptionNode << std::endl;
   #endif
   if(excel_puttableOptionNode)
   {
       excel_puttableOption_ = boost::shared_ptr<Excel_puttableOption>(new Excel_puttableOption(excel_puttableOptionNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_additionalOption::getExcel_type()
{
   if(!this->excel_typeIsNull_){
        return this->excel_type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_noneOption> Excel_additionalOption::getExcel_noneOption()
{
   if(!this->excel_noneOptionIsNull_){
        return this->excel_noneOption_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_noneOption>();
   }
}
boost::shared_ptr<Excel_callableOption> Excel_additionalOption::getExcel_callableOption()
{
   if(!this->excel_callableOptionIsNull_){
        return this->excel_callableOption_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_callableOption>();
   }
}
boost::shared_ptr<Excel_puttableOption> Excel_additionalOption::getExcel_puttableOption()
{
   if(!this->excel_puttableOptionIsNull_){
        return this->excel_puttableOption_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_puttableOption>();
   }
}
}

