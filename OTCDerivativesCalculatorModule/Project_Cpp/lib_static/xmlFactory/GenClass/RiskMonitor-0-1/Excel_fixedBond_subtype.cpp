// Excel_fixedBond_subtype.cpp 
#include "Excel_fixedBond_subtype.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_fixedBond_subtype::Excel_fixedBond_subtype(TiXmlNode* xmlNode)
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

   //excel_fixedBond_constantRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_fixedBond_constantRateNode = xmlNode->FirstChildElement("excel_fixedBond_constantRate");

   if(excel_fixedBond_constantRateNode){excel_fixedBond_constantRateIsNull_ = false;}
   else{excel_fixedBond_constantRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_fixedBond_constantRateNode , address : " << excel_fixedBond_constantRateNode << std::endl;
   #endif
   if(excel_fixedBond_constantRateNode)
   {
       excel_fixedBond_constantRate_ = boost::shared_ptr<Excel_fixedBond_constantRate>(new Excel_fixedBond_constantRate(excel_fixedBond_constantRateNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_fixedBond_subtype::getExcel_type()
{
   if(!this->excel_typeIsNull_){
        return this->excel_type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_fixedBond_constantRate> Excel_fixedBond_subtype::getExcel_fixedBond_constantRate()
{
   if(!this->excel_fixedBond_constantRateIsNull_){
        return this->excel_fixedBond_constantRate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_fixedBond_constantRate>();
   }
}
}

