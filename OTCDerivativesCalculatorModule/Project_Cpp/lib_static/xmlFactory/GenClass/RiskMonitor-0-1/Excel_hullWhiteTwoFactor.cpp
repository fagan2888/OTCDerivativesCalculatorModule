// Excel_hullWhiteTwoFactor.cpp 
#include "Excel_hullWhiteTwoFactor.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_hullWhiteTwoFactor::Excel_hullWhiteTwoFactor(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //currentValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* currentValueNode = xmlNode->FirstChildElement("currentValue");

   if(currentValueNode){currentValueIsNull_ = false;}
   else{currentValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- currentValueNode , address : " << currentValueNode << std::endl;
   #endif
   if(currentValueNode)
   {
       currentValue_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(currentValueNode));
   }

   //alphaNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* alphaNode = xmlNode->FirstChildElement("alpha");

   if(alphaNode){alphaIsNull_ = false;}
   else{alphaIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- alphaNode , address : " << alphaNode << std::endl;
   #endif
   if(alphaNode)
   {
       alpha_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(alphaNode));
   }

   //volatilityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* volatilityNode = xmlNode->FirstChildElement("volatility");

   if(volatilityNode){volatilityIsNull_ = false;}
   else{volatilityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- volatilityNode , address : " << volatilityNode << std::endl;
   #endif
   if(volatilityNode)
   {
       volatility_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(volatilityNode));
   }

   //excel_rateInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_rateInfoNode = xmlNode->FirstChildElement("excel_rateInfo");

   if(excel_rateInfoNode){excel_rateInfoIsNull_ = false;}
   else{excel_rateInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_rateInfoNode , address : " << excel_rateInfoNode << std::endl;
   #endif
   if(excel_rateInfoNode)
   {
       excel_rateInfo_ = boost::shared_ptr<Excel_rateInfo>(new Excel_rateInfo(excel_rateInfoNode));
   }

   //linkedCurveCodeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* linkedCurveCodeNode = xmlNode->FirstChildElement("linkedCurveCode");

   if(linkedCurveCodeNode){linkedCurveCodeIsNull_ = false;}
   else{linkedCurveCodeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- linkedCurveCodeNode , address : " << linkedCurveCodeNode << std::endl;
   #endif
   if(linkedCurveCodeNode)
   {
       linkedCurveCode_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(linkedCurveCodeNode));
   }

   //excel_yieldCurveNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_yieldCurveNode = xmlNode->FirstChildElement("excel_yieldCurve");

   if(excel_yieldCurveNode){excel_yieldCurveIsNull_ = false;}
   else{excel_yieldCurveIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_yieldCurveNode , address : " << excel_yieldCurveNode << std::endl;
   #endif
   if(excel_yieldCurveNode)
   {
       excel_yieldCurve_ = boost::shared_ptr<Excel_yieldCurve>(new Excel_yieldCurve(excel_yieldCurveNode));
   }

   //vba_descriptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* vba_descriptionNode = xmlNode->FirstChildElement("vba_description");

   if(vba_descriptionNode){vba_descriptionIsNull_ = false;}
   else{vba_descriptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- vba_descriptionNode , address : " << vba_descriptionNode << std::endl;
   #endif
   if(vba_descriptionNode)
   {
       vba_description_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(vba_descriptionNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_hullWhiteTwoFactor::getCurrentValue()
{
   if(!this->currentValueIsNull_){
        return this->currentValue_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_hullWhiteTwoFactor::getAlpha()
{
   if(!this->alphaIsNull_){
        return this->alpha_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_hullWhiteTwoFactor::getVolatility()
{
   if(!this->volatilityIsNull_){
        return this->volatility_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_rateInfo> Excel_hullWhiteTwoFactor::getExcel_rateInfo()
{
   if(!this->excel_rateInfoIsNull_){
        return this->excel_rateInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_rateInfo>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_hullWhiteTwoFactor::getLinkedCurveCode()
{
   if(!this->linkedCurveCodeIsNull_){
        return this->linkedCurveCode_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_yieldCurve> Excel_hullWhiteTwoFactor::getExcel_yieldCurve()
{
   if(!this->excel_yieldCurveIsNull_){
        return this->excel_yieldCurve_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_yieldCurve>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_hullWhiteTwoFactor::getVba_description()
{
   if(!this->vba_descriptionIsNull_){
        return this->vba_description_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

