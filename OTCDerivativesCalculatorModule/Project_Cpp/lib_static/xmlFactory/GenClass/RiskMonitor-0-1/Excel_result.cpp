// Excel_result.cpp 
#include "Excel_result.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_result::Excel_result(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //calculationDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationDateNode = xmlNode->FirstChildElement("calculationDate");

   if(calculationDateNode){calculationDateIsNull_ = false;}
   else{calculationDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationDateNode , address : " << calculationDateNode << std::endl;
   #endif
   if(calculationDateNode)
   {
       calculationDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(calculationDateNode));
   }

   //excel_valueResultNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_valueResultNode = xmlNode->FirstChildElement("excel_valueResult");

   if(excel_valueResultNode){excel_valueResultIsNull_ = false;}
   else{excel_valueResultIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_valueResultNode , address : " << excel_valueResultNode << std::endl;
   #endif
   if(excel_valueResultNode)
   {
       excel_valueResult_ = boost::shared_ptr<Excel_valueResult>(new Excel_valueResult(excel_valueResultNode));
   }

   //excel_greekResultNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_greekResultNode = xmlNode->FirstChildElement("excel_greekResult");

   if(excel_greekResultNode){excel_greekResultIsNull_ = false;}
   else{excel_greekResultIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_greekResultNode , address : " << excel_greekResultNode << std::endl;
   #endif
   if(excel_greekResultNode)
   {
       excel_greekResult_ = boost::shared_ptr<Excel_greekResult>(new Excel_greekResult(excel_greekResultNode));
   }

   //excel_cashFlowsResultNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_cashFlowsResultNode = xmlNode->FirstChildElement("excel_cashFlowsResult");

   if(excel_cashFlowsResultNode){excel_cashFlowsResultIsNull_ = false;}
   else{excel_cashFlowsResultIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_cashFlowsResultNode , address : " << excel_cashFlowsResultNode << std::endl;
   #endif
   if(excel_cashFlowsResultNode)
   {
       excel_cashFlowsResult_ = boost::shared_ptr<Excel_cashFlowsResult>(new Excel_cashFlowsResult(excel_cashFlowsResultNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDate> Excel_result::getCalculationDate()
{
   if(!this->calculationDateIsNull_){
        return this->calculationDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<Excel_valueResult> Excel_result::getExcel_valueResult()
{
   if(!this->excel_valueResultIsNull_){
        return this->excel_valueResult_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_valueResult>();
   }
}
boost::shared_ptr<Excel_greekResult> Excel_result::getExcel_greekResult()
{
   if(!this->excel_greekResultIsNull_){
        return this->excel_greekResult_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_greekResult>();
   }
}
boost::shared_ptr<Excel_cashFlowsResult> Excel_result::getExcel_cashFlowsResult()
{
   if(!this->excel_cashFlowsResultIsNull_){
        return this->excel_cashFlowsResult_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_cashFlowsResult>();
   }
}
}

