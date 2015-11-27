// Excel_structuredBond_subtype.cpp 
#include "Excel_structuredBond_subtype.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_structuredBond_subtype::Excel_structuredBond_subtype(TiXmlNode* xmlNode)
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

   //excel_structuredBond_fixedAccrualNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_structuredBond_fixedAccrualNode = xmlNode->FirstChildElement("excel_structuredBond_fixedAccrual");

   if(excel_structuredBond_fixedAccrualNode){excel_structuredBond_fixedAccrualIsNull_ = false;}
   else{excel_structuredBond_fixedAccrualIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_structuredBond_fixedAccrualNode , address : " << excel_structuredBond_fixedAccrualNode << std::endl;
   #endif
   if(excel_structuredBond_fixedAccrualNode)
   {
       excel_structuredBond_fixedAccrual_ = boost::shared_ptr<Excel_structuredBond_fixedAccrual>(new Excel_structuredBond_fixedAccrual(excel_structuredBond_fixedAccrualNode));
   }

   //excel_structuredBond_floatingAccrualNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_structuredBond_floatingAccrualNode = xmlNode->FirstChildElement("excel_structuredBond_floatingAccrual");

   if(excel_structuredBond_floatingAccrualNode){excel_structuredBond_floatingAccrualIsNull_ = false;}
   else{excel_structuredBond_floatingAccrualIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_structuredBond_floatingAccrualNode , address : " << excel_structuredBond_floatingAccrualNode << std::endl;
   #endif
   if(excel_structuredBond_floatingAccrualNode)
   {
       excel_structuredBond_floatingAccrual_ = boost::shared_ptr<Excel_structuredBond_floatingAccrual>(new Excel_structuredBond_floatingAccrual(excel_structuredBond_floatingAccrualNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_structuredBond_subtype::getExcel_type()
{
   if(!this->excel_typeIsNull_){
        return this->excel_type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_structuredBond_fixedAccrual> Excel_structuredBond_subtype::getExcel_structuredBond_fixedAccrual()
{
   if(!this->excel_structuredBond_fixedAccrualIsNull_){
        return this->excel_structuredBond_fixedAccrual_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_structuredBond_fixedAccrual>();
   }
}
boost::shared_ptr<Excel_structuredBond_floatingAccrual> Excel_structuredBond_subtype::getExcel_structuredBond_floatingAccrual()
{
   if(!this->excel_structuredBond_floatingAccrualIsNull_){
        return this->excel_structuredBond_floatingAccrual_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_structuredBond_floatingAccrual>();
   }
}
}

