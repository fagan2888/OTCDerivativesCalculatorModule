// Excel_vanillaFloatingBond_subtype.cpp 
#include "Excel_vanillaFloatingBond_subtype.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_vanillaFloatingBond_subtype::Excel_vanillaFloatingBond_subtype(TiXmlNode* xmlNode)
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

   //excel_vanillaFloatingBond_simpleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_vanillaFloatingBond_simpleNode = xmlNode->FirstChildElement("excel_vanillaFloatingBond_simple");

   if(excel_vanillaFloatingBond_simpleNode){excel_vanillaFloatingBond_simpleIsNull_ = false;}
   else{excel_vanillaFloatingBond_simpleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_vanillaFloatingBond_simpleNode , address : " << excel_vanillaFloatingBond_simpleNode << std::endl;
   #endif
   if(excel_vanillaFloatingBond_simpleNode)
   {
       excel_vanillaFloatingBond_simple_ = boost::shared_ptr<Excel_vanillaFloatingBond_simple>(new Excel_vanillaFloatingBond_simple(excel_vanillaFloatingBond_simpleNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_vanillaFloatingBond_subtype::getExcel_type()
{
   if(!this->excel_typeIsNull_){
        return this->excel_type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_vanillaFloatingBond_simple> Excel_vanillaFloatingBond_subtype::getExcel_vanillaFloatingBond_simple()
{
   if(!this->excel_vanillaFloatingBond_simpleIsNull_){
        return this->excel_vanillaFloatingBond_simple_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_vanillaFloatingBond_simple>();
   }
}
}

