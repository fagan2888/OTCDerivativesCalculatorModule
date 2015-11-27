// Excel_kiEventCalculation.cpp 
#include "Excel_kiEventCalculation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_kiEventCalculation::Excel_kiEventCalculation(TiXmlNode* xmlNode)
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

   //excel_simpleKiEventCalcNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_simpleKiEventCalcNode = xmlNode->FirstChildElement("excel_simpleKiEventCalc");

   if(excel_simpleKiEventCalcNode){excel_simpleKiEventCalcIsNull_ = false;}
   else{excel_simpleKiEventCalcIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_simpleKiEventCalcNode , address : " << excel_simpleKiEventCalcNode << std::endl;
   #endif
   if(excel_simpleKiEventCalcNode)
   {
       excel_simpleKiEventCalc_ = boost::shared_ptr<Excel_simpleKiEventCalc>(new Excel_simpleKiEventCalc(excel_simpleKiEventCalcNode));
   }

   //excel_dualKiEventCalcNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_dualKiEventCalcNode = xmlNode->FirstChildElement("excel_dualKiEventCalc");

   if(excel_dualKiEventCalcNode){excel_dualKiEventCalcIsNull_ = false;}
   else{excel_dualKiEventCalcIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_dualKiEventCalcNode , address : " << excel_dualKiEventCalcNode << std::endl;
   #endif
   if(excel_dualKiEventCalcNode)
   {
       excel_dualKiEventCalc_ = boost::shared_ptr<Excel_dualKiEventCalc>(new Excel_dualKiEventCalc(excel_dualKiEventCalcNode));
   }

   //excel_targetKiEventCalcNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_targetKiEventCalcNode = xmlNode->FirstChildElement("excel_targetKiEventCalc");

   if(excel_targetKiEventCalcNode){excel_targetKiEventCalcIsNull_ = false;}
   else{excel_targetKiEventCalcIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_targetKiEventCalcNode , address : " << excel_targetKiEventCalcNode << std::endl;
   #endif
   if(excel_targetKiEventCalcNode)
   {
       excel_targetKiEventCalc_ = boost::shared_ptr<Excel_targetKiEventCalc>(new Excel_targetKiEventCalc(excel_targetKiEventCalcNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_kiEventCalculation::getExcel_type()
{
   if(!this->excel_typeIsNull_){
        return this->excel_type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_simpleKiEventCalc> Excel_kiEventCalculation::getExcel_simpleKiEventCalc()
{
   if(!this->excel_simpleKiEventCalcIsNull_){
        return this->excel_simpleKiEventCalc_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_simpleKiEventCalc>();
   }
}
boost::shared_ptr<Excel_dualKiEventCalc> Excel_kiEventCalculation::getExcel_dualKiEventCalc()
{
   if(!this->excel_dualKiEventCalcIsNull_){
        return this->excel_dualKiEventCalc_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_dualKiEventCalc>();
   }
}
boost::shared_ptr<Excel_targetKiEventCalc> Excel_kiEventCalculation::getExcel_targetKiEventCalc()
{
   if(!this->excel_targetKiEventCalcIsNull_){
        return this->excel_targetKiEventCalc_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_targetKiEventCalc>();
   }
}
}

