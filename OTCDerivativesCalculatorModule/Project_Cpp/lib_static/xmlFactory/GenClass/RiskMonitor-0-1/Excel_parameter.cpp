// Excel_parameter.cpp 
#include "Excel_parameter.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_parameter::Excel_parameter(TiXmlNode* xmlNode)
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

   //excel_resultNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_resultNode = xmlNode->FirstChildElement("excel_result");

   if(excel_resultNode){excel_resultIsNull_ = false;}
   else{excel_resultIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_resultNode , address : " << excel_resultNode << std::endl;
   #endif
   if(excel_resultNode)
   {
       excel_result_ = boost::shared_ptr<Excel_result>(new Excel_result(excel_resultNode));
   }

   //excel_standardParaNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_standardParaNode = xmlNode->FirstChildElement("excel_standardPara");

   if(excel_standardParaNode){excel_standardParaIsNull_ = false;}
   else{excel_standardParaIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_standardParaNode , address : " << excel_standardParaNode << std::endl;
   #endif
   if(excel_standardParaNode)
   {
       excel_standardPara_ = boost::shared_ptr<Excel_standardPara>(new Excel_standardPara(excel_standardParaNode));
   }

   //excel_standardSwapParaNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_standardSwapParaNode = xmlNode->FirstChildElement("excel_standardSwapPara");

   if(excel_standardSwapParaNode){excel_standardSwapParaIsNull_ = false;}
   else{excel_standardSwapParaIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_standardSwapParaNode , address : " << excel_standardSwapParaNode << std::endl;
   #endif
   if(excel_standardSwapParaNode)
   {
       excel_standardSwapPara_ = boost::shared_ptr<Excel_standardSwapPara>(new Excel_standardSwapPara(excel_standardSwapParaNode));
   }

   //excel_standardHifiveParaNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_standardHifiveParaNode = xmlNode->FirstChildElement("excel_standardHifivePara");

   if(excel_standardHifiveParaNode){excel_standardHifiveParaIsNull_ = false;}
   else{excel_standardHifiveParaIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_standardHifiveParaNode , address : " << excel_standardHifiveParaNode << std::endl;
   #endif
   if(excel_standardHifiveParaNode)
   {
       excel_standardHifivePara_ = boost::shared_ptr<Excel_standardHifivePara>(new Excel_standardHifivePara(excel_standardHifiveParaNode));
   }

   //excel_standardCreditParaNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_standardCreditParaNode = xmlNode->FirstChildElement("excel_standardCreditPara");

   if(excel_standardCreditParaNode){excel_standardCreditParaIsNull_ = false;}
   else{excel_standardCreditParaIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_standardCreditParaNode , address : " << excel_standardCreditParaNode << std::endl;
   #endif
   if(excel_standardCreditParaNode)
   {
       excel_standardCreditPara_ = boost::shared_ptr<Excel_standardCreditPara>(new Excel_standardCreditPara(excel_standardCreditParaNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_parameter::getExcel_type()
{
   if(!this->excel_typeIsNull_){
        return this->excel_type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_result> Excel_parameter::getExcel_result()
{
   if(!this->excel_resultIsNull_){
        return this->excel_result_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_result>();
   }
}
boost::shared_ptr<Excel_standardPara> Excel_parameter::getExcel_standardPara()
{
   if(!this->excel_standardParaIsNull_){
        return this->excel_standardPara_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_standardPara>();
   }
}
boost::shared_ptr<Excel_standardSwapPara> Excel_parameter::getExcel_standardSwapPara()
{
   if(!this->excel_standardSwapParaIsNull_){
        return this->excel_standardSwapPara_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_standardSwapPara>();
   }
}
boost::shared_ptr<Excel_standardHifivePara> Excel_parameter::getExcel_standardHifivePara()
{
   if(!this->excel_standardHifiveParaIsNull_){
        return this->excel_standardHifivePara_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_standardHifivePara>();
   }
}
boost::shared_ptr<Excel_standardCreditPara> Excel_parameter::getExcel_standardCreditPara()
{
   if(!this->excel_standardCreditParaIsNull_){
        return this->excel_standardCreditPara_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_standardCreditPara>();
   }
}
}

