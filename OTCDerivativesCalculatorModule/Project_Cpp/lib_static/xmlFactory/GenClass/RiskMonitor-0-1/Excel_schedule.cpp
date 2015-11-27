// Excel_schedule.cpp 
#include "Excel_schedule.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_schedule::Excel_schedule(TiXmlNode* xmlNode)
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

   //excel_additionalOptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_additionalOptionNode = xmlNode->FirstChildElement("excel_additionalOption");

   if(excel_additionalOptionNode){excel_additionalOptionIsNull_ = false;}
   else{excel_additionalOptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_additionalOptionNode , address : " << excel_additionalOptionNode << std::endl;
   #endif
   if(excel_additionalOptionNode)
   {
       excel_additionalOption_ = boost::shared_ptr<Excel_additionalOption>(new Excel_additionalOption(excel_additionalOptionNode));
   }

   //excel_simpleCalculationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_simpleCalculationNode = xmlNode->FirstChildElement("excel_simpleCalculation");

   if(excel_simpleCalculationNode){excel_simpleCalculationIsNull_ = false;}
   else{excel_simpleCalculationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_simpleCalculationNode , address : " << excel_simpleCalculationNode << std::endl;
   #endif
   if(excel_simpleCalculationNode)
   {
       excel_simpleCalculation_ = boost::shared_ptr<Excel_simpleCalculation>(new Excel_simpleCalculation(excel_simpleCalculationNode));
   }

   //excel_choiceReturnCalculationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_choiceReturnCalculationNode = xmlNode->FirstChildElement("excel_choiceReturnCalculation");

   if(excel_choiceReturnCalculationNode){excel_choiceReturnCalculationIsNull_ = false;}
   else{excel_choiceReturnCalculationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_choiceReturnCalculationNode , address : " << excel_choiceReturnCalculationNode << std::endl;
   #endif
   if(excel_choiceReturnCalculationNode)
   {
       excel_choiceReturnCalculation_ = boost::shared_ptr<Excel_choiceReturnCalculation>(new Excel_choiceReturnCalculation(excel_choiceReturnCalculationNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_schedule::getExcel_type()
{
   if(!this->excel_typeIsNull_){
        return this->excel_type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_additionalOption> Excel_schedule::getExcel_additionalOption()
{
   if(!this->excel_additionalOptionIsNull_){
        return this->excel_additionalOption_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_additionalOption>();
   }
}
boost::shared_ptr<Excel_simpleCalculation> Excel_schedule::getExcel_simpleCalculation()
{
   if(!this->excel_simpleCalculationIsNull_){
        return this->excel_simpleCalculation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_simpleCalculation>();
   }
}
boost::shared_ptr<Excel_choiceReturnCalculation> Excel_schedule::getExcel_choiceReturnCalculation()
{
   if(!this->excel_choiceReturnCalculationIsNull_){
        return this->excel_choiceReturnCalculation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_choiceReturnCalculation>();
   }
}
}

