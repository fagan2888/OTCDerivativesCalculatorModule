// Excel_referenceInfo_para.cpp 
#include "Excel_referenceInfo_para.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_referenceInfo_para::Excel_referenceInfo_para(TiXmlNode* xmlNode)
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

   //krCodeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* krCodeNode = xmlNode->FirstChildElement("krCode");

   if(krCodeNode){krCodeIsNull_ = false;}
   else{krCodeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- krCodeNode , address : " << krCodeNode << std::endl;
   #endif
   if(krCodeNode)
   {
       krCode_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(krCodeNode));
   }

   //referenceNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referenceNameNode = xmlNode->FirstChildElement("referenceName");

   if(referenceNameNode){referenceNameIsNull_ = false;}
   else{referenceNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceNameNode , address : " << referenceNameNode << std::endl;
   #endif
   if(referenceNameNode)
   {
       referenceName_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(referenceNameNode));
   }

   //modelNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* modelNode = xmlNode->FirstChildElement("model");

   if(modelNode){modelIsNull_ = false;}
   else{modelIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- modelNode , address : " << modelNode << std::endl;
   #endif
   if(modelNode)
   {
       model_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(modelNode));
   }

   //excel_defaultCurveNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_defaultCurveNode = xmlNode->FirstChildElement("excel_defaultCurve");

   if(excel_defaultCurveNode){excel_defaultCurveIsNull_ = false;}
   else{excel_defaultCurveIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_defaultCurveNode , address : " << excel_defaultCurveNode << std::endl;
   #endif
   if(excel_defaultCurveNode)
   {
       excel_defaultCurve_ = boost::shared_ptr<Excel_defaultCurve>(new Excel_defaultCurve(excel_defaultCurveNode));
   }

   //descriptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* descriptionNode = xmlNode->FirstChildElement("description");

   if(descriptionNode){descriptionIsNull_ = false;}
   else{descriptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- descriptionNode , address : " << descriptionNode << std::endl;
   #endif
   if(descriptionNode)
   {
       description_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(descriptionNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_referenceInfo_para::getExcel_type()
{
   if(!this->excel_typeIsNull_){
        return this->excel_type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_referenceInfo_para::getKrCode()
{
   if(!this->krCodeIsNull_){
        return this->krCode_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_referenceInfo_para::getReferenceName()
{
   if(!this->referenceNameIsNull_){
        return this->referenceName_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_referenceInfo_para::getModel()
{
   if(!this->modelIsNull_){
        return this->model_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_defaultCurve> Excel_referenceInfo_para::getExcel_defaultCurve()
{
   if(!this->excel_defaultCurveIsNull_){
        return this->excel_defaultCurve_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_defaultCurve>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_referenceInfo_para::getDescription()
{
   if(!this->descriptionIsNull_){
        return this->description_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

