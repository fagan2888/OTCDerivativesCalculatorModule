// Excel_defaultCurve.cpp 
#include "Excel_defaultCurve.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_defaultCurve::Excel_defaultCurve(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //codeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* codeNode = xmlNode->FirstChildElement("code");

   if(codeNode){codeIsNull_ = false;}
   else{codeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- codeNode , address : " << codeNode << std::endl;
   #endif
   if(codeNode)
   {
       code_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(codeNode));
   }

   //nameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nameNode = xmlNode->FirstChildElement("name");

   if(nameNode){nameIsNull_ = false;}
   else{nameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nameNode , address : " << nameNode << std::endl;
   #endif
   if(nameNode)
   {
       name_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(nameNode));
   }

   //recoveryNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* recoveryNode = xmlNode->FirstChildElement("recovery");

   if(recoveryNode){recoveryIsNull_ = false;}
   else{recoveryIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- recoveryNode , address : " << recoveryNode << std::endl;
   #endif
   if(recoveryNode)
   {
       recovery_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(recoveryNode));
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

   //excel_interpolationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_interpolationNode = xmlNode->FirstChildElement("excel_interpolation");

   if(excel_interpolationNode){excel_interpolationIsNull_ = false;}
   else{excel_interpolationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_interpolationNode , address : " << excel_interpolationNode << std::endl;
   #endif
   if(excel_interpolationNode)
   {
       excel_interpolation_ = boost::shared_ptr<Excel_interpolation>(new Excel_interpolation(excel_interpolationNode));
   }

   //excel_rateDataNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_rateDataNode = xmlNode->FirstChildElement("excel_rateData");

   if(excel_rateDataNode){excel_rateDataIsNull_ = false;}
   else{excel_rateDataIsNull_ = true;}

   if(excel_rateDataNode)
   {
      for(excel_rateDataNode; excel_rateDataNode; excel_rateDataNode = excel_rateDataNode->NextSiblingElement("excel_rateData")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_rateDataNode , address : " << excel_rateDataNode << std::endl;
          #endif
          excel_rateData_.push_back(boost::shared_ptr<Excel_rateData>(new Excel_rateData(excel_rateDataNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_rateDataNode , address : " << excel_rateDataNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_defaultCurve::getCode()
{
   if(!this->codeIsNull_){
        return this->code_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_defaultCurve::getName()
{
   if(!this->nameIsNull_){
        return this->name_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_defaultCurve::getRecovery()
{
   if(!this->recoveryIsNull_){
        return this->recovery_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_defaultCurve::getDescription()
{
   if(!this->descriptionIsNull_){
        return this->description_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_interpolation> Excel_defaultCurve::getExcel_interpolation()
{
   if(!this->excel_interpolationIsNull_){
        return this->excel_interpolation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_interpolation>();
   }
}
std::vector<boost::shared_ptr<Excel_rateData>> Excel_defaultCurve::getExcel_rateData()
{
   if(!this->excel_rateDataIsNull_){
        return this->excel_rateData_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Excel_rateData>>();
   }
}
}

