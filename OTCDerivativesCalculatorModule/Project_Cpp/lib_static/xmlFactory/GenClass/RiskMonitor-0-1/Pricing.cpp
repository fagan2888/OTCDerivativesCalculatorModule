// Pricing.cpp 
#include "Pricing.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Pricing::Pricing(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //evaluationTimeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* evaluationTimeNode = xmlNode->FirstChildElement("evaluationTime");

   if(evaluationTimeNode){evaluationTimeIsNull_ = false;}
   else{evaluationTimeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- evaluationTimeNode , address : " << evaluationTimeNode << std::endl;
   #endif
   if(evaluationTimeNode)
   {
       evaluationTime_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(evaluationTimeNode));
   }

   //excel_parameterNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_parameterNode = xmlNode->FirstChildElement("excel_parameter");

   if(excel_parameterNode){excel_parameterIsNull_ = false;}
   else{excel_parameterIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_parameterNode , address : " << excel_parameterNode << std::endl;
   #endif
   if(excel_parameterNode)
   {
       excel_parameter_ = boost::shared_ptr<Excel_parameter>(new Excel_parameter(excel_parameterNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDate> Pricing::getEvaluationTime()
{
   if(!this->evaluationTimeIsNull_){
        return this->evaluationTime_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<Excel_parameter> Pricing::getExcel_parameter()
{
   if(!this->excel_parameterIsNull_){
        return this->excel_parameter_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_parameter>();
   }
}
}

