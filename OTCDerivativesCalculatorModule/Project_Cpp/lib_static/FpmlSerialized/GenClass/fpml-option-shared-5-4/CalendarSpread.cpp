// CalendarSpread.cpp 
#include "CalendarSpread.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CalendarSpread::CalendarSpread(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //expirationDateTwoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* expirationDateTwoNode = xmlNode->FirstChildElement("expirationDateTwo");

   if(expirationDateTwoNode){expirationDateTwoIsNull_ = false;}
   else{expirationDateTwoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- expirationDateTwoNode , address : " << expirationDateTwoNode << std::endl;
   #endif
   if(expirationDateTwoNode)
   {
      if(expirationDateTwoNode->Attribute("href") || expirationDateTwoNode->Attribute("id"))
      {
          if(expirationDateTwoNode->Attribute("id"))
          {
             expirationDateTwoIDRef_ = expirationDateTwoNode->Attribute("id");
             expirationDateTwo_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(expirationDateTwoNode));
             expirationDateTwo_->setID(expirationDateTwoIDRef_);
             IDManager::instance().setID(expirationDateTwoIDRef_,expirationDateTwo_);
          }
          else if(expirationDateTwoNode->Attribute("href")) { expirationDateTwoIDRef_ = expirationDateTwoNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { expirationDateTwo_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(expirationDateTwoNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AdjustableOrRelativeDate> CalendarSpread::getExpirationDateTwo()
{
   if(!this->expirationDateTwoIsNull_){
        if(expirationDateTwoIDRef_ != ""){
             return boost::shared_static_cast<AdjustableOrRelativeDate>(IDManager::instance().getID(expirationDateTwoIDRef_));
        }else{
             return this->expirationDateTwo_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableOrRelativeDate>();
   }
}
}

