// Excel_forwardModel.cpp 
#include "Excel_forwardModel.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_forwardModel::Excel_forwardModel(TiXmlNode* xmlNode)
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
boost::shared_ptr<XsdTypeToken> Excel_forwardModel::getCurrentValue()
{
   if(!this->currentValueIsNull_){
        return this->currentValue_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_forwardModel::getTenor()
{
   if(!this->tenorIsNull_){
        return this->tenor_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_forwardModel::getLinkedCurveCode()
{
   if(!this->linkedCurveCodeIsNull_){
        return this->linkedCurveCode_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_yieldCurve> Excel_forwardModel::getExcel_yieldCurve()
{
   if(!this->excel_yieldCurveIsNull_){
        return this->excel_yieldCurve_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_yieldCurve>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_forwardModel::getVba_description()
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

