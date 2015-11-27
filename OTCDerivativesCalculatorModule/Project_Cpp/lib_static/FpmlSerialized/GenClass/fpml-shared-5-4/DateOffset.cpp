// DateOffset.cpp 
#include "DateOffset.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

DateOffset::DateOffset(TiXmlNode* xmlNode)
: Offset(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //businessDayConventionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* businessDayConventionNode = xmlNode->FirstChildElement("businessDayConvention");

   if(businessDayConventionNode){businessDayConventionIsNull_ = false;}
   else{businessDayConventionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessDayConventionNode , address : " << businessDayConventionNode << std::endl;
   #endif
   if(businessDayConventionNode)
   {
      if(businessDayConventionNode->Attribute("href") || businessDayConventionNode->Attribute("id"))
      {
          if(businessDayConventionNode->Attribute("id"))
          {
             businessDayConventionIDRef_ = businessDayConventionNode->Attribute("id");
             businessDayConvention_ = boost::shared_ptr<BusinessDayConventionEnum>(new BusinessDayConventionEnum(businessDayConventionNode));
             businessDayConvention_->setID(businessDayConventionIDRef_);
             IDManager::instance().setID(businessDayConventionIDRef_,businessDayConvention_);
          }
          else if(businessDayConventionNode->Attribute("href")) { businessDayConventionIDRef_ = businessDayConventionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { businessDayConvention_ = boost::shared_ptr<BusinessDayConventionEnum>(new BusinessDayConventionEnum(businessDayConventionNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<BusinessDayConventionEnum> DateOffset::getBusinessDayConvention()
{
   if(!this->businessDayConventionIsNull_){
        if(businessDayConventionIDRef_ != ""){
             return boost::shared_static_cast<BusinessDayConventionEnum>(IDManager::instance().getID(businessDayConventionIDRef_));
        }else{
             return this->businessDayConvention_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessDayConventionEnum>();
   }
}
}

