// Offset.cpp 
#include "Offset.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Offset::Offset(TiXmlNode* xmlNode)
: Period(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //dayTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dayTypeNode = xmlNode->FirstChildElement("dayType");

   if(dayTypeNode){dayTypeIsNull_ = false;}
   else{dayTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dayTypeNode , address : " << dayTypeNode << std::endl;
   #endif
   if(dayTypeNode)
   {
      if(dayTypeNode->Attribute("href") || dayTypeNode->Attribute("id"))
      {
          if(dayTypeNode->Attribute("id"))
          {
             dayTypeIDRef_ = dayTypeNode->Attribute("id");
             dayType_ = boost::shared_ptr<DayTypeEnum>(new DayTypeEnum(dayTypeNode));
             dayType_->setID(dayTypeIDRef_);
             IDManager::instance().setID(dayTypeIDRef_,dayType_);
          }
          else if(dayTypeNode->Attribute("href")) { dayTypeIDRef_ = dayTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dayType_ = boost::shared_ptr<DayTypeEnum>(new DayTypeEnum(dayTypeNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<DayTypeEnum> Offset::getDayType()
{
   if(!this->dayTypeIsNull_){
        if(dayTypeIDRef_ != ""){
             return boost::shared_static_cast<DayTypeEnum>(IDManager::instance().getID(dayTypeIDRef_));
        }else{
             return this->dayType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DayTypeEnum>();
   }
}
}

