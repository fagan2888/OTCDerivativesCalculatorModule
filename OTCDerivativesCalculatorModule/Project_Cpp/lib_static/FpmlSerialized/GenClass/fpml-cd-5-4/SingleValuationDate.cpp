// SingleValuationDate.cpp 
#include "SingleValuationDate.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SingleValuationDate::SingleValuationDate(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //businessDaysNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* businessDaysNode = xmlNode->FirstChildElement("businessDays");

   if(businessDaysNode){businessDaysIsNull_ = false;}
   else{businessDaysIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessDaysNode , address : " << businessDaysNode << std::endl;
   #endif
   if(businessDaysNode)
   {
      if(businessDaysNode->Attribute("href") || businessDaysNode->Attribute("id"))
      {
          if(businessDaysNode->Attribute("id"))
          {
             businessDaysIDRef_ = businessDaysNode->Attribute("id");
             businessDays_ = boost::shared_ptr<XsdTypeNonNegativeInteger>(new XsdTypeNonNegativeInteger(businessDaysNode));
             businessDays_->setID(businessDaysIDRef_);
             IDManager::instance().setID(businessDaysIDRef_,businessDays_);
          }
          else if(businessDaysNode->Attribute("href")) { businessDaysIDRef_ = businessDaysNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { businessDays_ = boost::shared_ptr<XsdTypeNonNegativeInteger>(new XsdTypeNonNegativeInteger(businessDaysNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeNonNegativeInteger> SingleValuationDate::getBusinessDays()
{
   if(!this->businessDaysIsNull_){
        if(businessDaysIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeNonNegativeInteger>(IDManager::instance().getID(businessDaysIDRef_));
        }else{
             return this->businessDays_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeNonNegativeInteger>();
   }
}
}

