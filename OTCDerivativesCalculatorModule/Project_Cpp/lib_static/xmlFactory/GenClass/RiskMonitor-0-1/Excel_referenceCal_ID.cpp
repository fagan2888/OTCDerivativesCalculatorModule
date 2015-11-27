// Excel_referenceCal_ID.cpp 
#include "Excel_referenceCal_ID.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_referenceCal_ID::Excel_referenceCal_ID(TiXmlNode* xmlNode)
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

   //excel_referSimpleCalculationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_referSimpleCalculationNode = xmlNode->FirstChildElement("excel_referSimpleCalculation");

   if(excel_referSimpleCalculationNode){excel_referSimpleCalculationIsNull_ = false;}
   else{excel_referSimpleCalculationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_referSimpleCalculationNode , address : " << excel_referSimpleCalculationNode << std::endl;
   #endif
   if(excel_referSimpleCalculationNode)
   {
       excel_referSimpleCalculation_ = boost::shared_ptr<Excel_referSimpleCalculation>(new Excel_referSimpleCalculation(excel_referSimpleCalculationNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_referenceCal_ID::getExcel_type()
{
   if(!this->excel_typeIsNull_){
        return this->excel_type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_referSimpleCalculation> Excel_referenceCal_ID::getExcel_referSimpleCalculation()
{
   if(!this->excel_referSimpleCalculationIsNull_){
        return this->excel_referSimpleCalculation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_referSimpleCalculation>();
   }
}
}

