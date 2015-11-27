// Excel_underlyingInfo_para.cpp 
#include "Excel_underlyingInfo_para.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_underlyingInfo_para::Excel_underlyingInfo_para(TiXmlNode* xmlNode)
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

   //currencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* currencyNode = xmlNode->FirstChildElement("currency");

   if(currencyNode){currencyIsNull_ = false;}
   else{currencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- currencyNode , address : " << currencyNode << std::endl;
   #endif
   if(currencyNode)
   {
       currency_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(currencyNode));
   }

   //underNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* underNameNode = xmlNode->FirstChildElement("underName");

   if(underNameNode){underNameIsNull_ = false;}
   else{underNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- underNameNode , address : " << underNameNode << std::endl;
   #endif
   if(underNameNode)
   {
       underName_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(underNameNode));
   }

   //basePriceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* basePriceNode = xmlNode->FirstChildElement("basePrice");

   if(basePriceNode){basePriceIsNull_ = false;}
   else{basePriceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- basePriceNode , address : " << basePriceNode << std::endl;
   #endif
   if(basePriceNode)
   {
       basePrice_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(basePriceNode));
   }

   //sub_typeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sub_typeNode = xmlNode->FirstChildElement("sub_type");

   if(sub_typeNode){sub_typeIsNull_ = false;}
   else{sub_typeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sub_typeNode , address : " << sub_typeNode << std::endl;
   #endif
   if(sub_typeNode)
   {
       sub_type_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(sub_typeNode));
   }

   //rate_typeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* rate_typeNode = xmlNode->FirstChildElement("rate_type");

   if(rate_typeNode){rate_typeIsNull_ = false;}
   else{rate_typeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rate_typeNode , address : " << rate_typeNode << std::endl;
   #endif
   if(rate_typeNode)
   {
       rate_type_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(rate_typeNode));
   }

   //tenorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tenorNode = xmlNode->FirstChildElement("tenor");

   if(tenorNode){tenorIsNull_ = false;}
   else{tenorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tenorNode , address : " << tenorNode << std::endl;
   #endif
   if(tenorNode)
   {
       tenor_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(tenorNode));
   }

   //legTenorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* legTenorNode = xmlNode->FirstChildElement("legTenor");

   if(legTenorNode){legTenorIsNull_ = false;}
   else{legTenorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- legTenorNode , address : " << legTenorNode << std::endl;
   #endif
   if(legTenorNode)
   {
       legTenor_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(legTenorNode));
   }

   //linkedCurveNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* linkedCurveNode = xmlNode->FirstChildElement("linkedCurve");

   if(linkedCurveNode){linkedCurveIsNull_ = false;}
   else{linkedCurveIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- linkedCurveNode , address : " << linkedCurveNode << std::endl;
   #endif
   if(linkedCurveNode)
   {
       linkedCurve_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(linkedCurveNode));
   }

   //excel_underlyingModel_paraNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_underlyingModel_paraNode = xmlNode->FirstChildElement("excel_underlyingModel_para");

   if(excel_underlyingModel_paraNode){excel_underlyingModel_paraIsNull_ = false;}
   else{excel_underlyingModel_paraIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_underlyingModel_paraNode , address : " << excel_underlyingModel_paraNode << std::endl;
   #endif
   if(excel_underlyingModel_paraNode)
   {
       excel_underlyingModel_para_ = boost::shared_ptr<Excel_underlyingModel_para>(new Excel_underlyingModel_para(excel_underlyingModel_paraNode));
   }

   //valueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* valueNode = xmlNode->FirstChildElement("value");

   if(valueNode){valueIsNull_ = false;}
   else{valueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valueNode , address : " << valueNode << std::endl;
   #endif
   if(valueNode)
   {
       value_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(valueNode));
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
boost::shared_ptr<XsdTypeToken> Excel_underlyingInfo_para::getExcel_type()
{
   if(!this->excel_typeIsNull_){
        return this->excel_type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_underlyingInfo_para::getKrCode()
{
   if(!this->krCodeIsNull_){
        return this->krCode_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_underlyingInfo_para::getCurrency()
{
   if(!this->currencyIsNull_){
        return this->currency_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_underlyingInfo_para::getUnderName()
{
   if(!this->underNameIsNull_){
        return this->underName_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_underlyingInfo_para::getBasePrice()
{
   if(!this->basePriceIsNull_){
        return this->basePrice_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_underlyingInfo_para::getSub_type()
{
   if(!this->sub_typeIsNull_){
        return this->sub_type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_underlyingInfo_para::getRate_type()
{
   if(!this->rate_typeIsNull_){
        return this->rate_type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_underlyingInfo_para::getTenor()
{
   if(!this->tenorIsNull_){
        return this->tenor_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_underlyingInfo_para::getLegTenor()
{
   if(!this->legTenorIsNull_){
        return this->legTenor_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_underlyingInfo_para::getLinkedCurve()
{
   if(!this->linkedCurveIsNull_){
        return this->linkedCurve_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_underlyingModel_para> Excel_underlyingInfo_para::getExcel_underlyingModel_para()
{
   if(!this->excel_underlyingModel_paraIsNull_){
        return this->excel_underlyingModel_para_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_underlyingModel_para>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_underlyingInfo_para::getValue()
{
   if(!this->valueIsNull_){
        return this->value_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_underlyingInfo_para::getDescription()
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

