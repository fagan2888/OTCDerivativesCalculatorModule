// ParametricAdjustmentPoint.cpp 
#include "ParametricAdjustmentPoint.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ParametricAdjustmentPoint::ParametricAdjustmentPoint(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //parameterValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* parameterValueNode = xmlNode->FirstChildElement("parameterValue");

   if(parameterValueNode){parameterValueIsNull_ = false;}
   else{parameterValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- parameterValueNode , address : " << parameterValueNode << std::endl;
   #endif
   if(parameterValueNode)
   {
      if(parameterValueNode->Attribute("href") || parameterValueNode->Attribute("id"))
      {
          if(parameterValueNode->Attribute("id"))
          {
             parameterValueIDRef_ = parameterValueNode->Attribute("id");
             parameterValue_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(parameterValueNode));
             parameterValue_->setID(parameterValueIDRef_);
             IDManager::instance().setID(parameterValueIDRef_,parameterValue_);
          }
          else if(parameterValueNode->Attribute("href")) { parameterValueIDRef_ = parameterValueNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { parameterValue_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(parameterValueNode));}
   }

   //adjustmentValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* adjustmentValueNode = xmlNode->FirstChildElement("adjustmentValue");

   if(adjustmentValueNode){adjustmentValueIsNull_ = false;}
   else{adjustmentValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- adjustmentValueNode , address : " << adjustmentValueNode << std::endl;
   #endif
   if(adjustmentValueNode)
   {
      if(adjustmentValueNode->Attribute("href") || adjustmentValueNode->Attribute("id"))
      {
          if(adjustmentValueNode->Attribute("id"))
          {
             adjustmentValueIDRef_ = adjustmentValueNode->Attribute("id");
             adjustmentValue_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(adjustmentValueNode));
             adjustmentValue_->setID(adjustmentValueIDRef_);
             IDManager::instance().setID(adjustmentValueIDRef_,adjustmentValue_);
          }
          else if(adjustmentValueNode->Attribute("href")) { adjustmentValueIDRef_ = adjustmentValueNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { adjustmentValue_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(adjustmentValueNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDecimal> ParametricAdjustmentPoint::getParameterValue()
{
   if(!this->parameterValueIsNull_){
        if(parameterValueIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(parameterValueIDRef_));
        }else{
             return this->parameterValue_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDecimal> ParametricAdjustmentPoint::getAdjustmentValue()
{
   if(!this->adjustmentValueIsNull_){
        if(adjustmentValueIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(adjustmentValueIDRef_));
        }else{
             return this->adjustmentValue_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
}

