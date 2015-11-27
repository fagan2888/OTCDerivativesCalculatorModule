// DateRange.cpp 
#include "DateRange.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

DateRange::DateRange(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //unadjustedFirstDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* unadjustedFirstDateNode = xmlNode->FirstChildElement("unadjustedFirstDate");

   if(unadjustedFirstDateNode){unadjustedFirstDateIsNull_ = false;}
   else{unadjustedFirstDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- unadjustedFirstDateNode , address : " << unadjustedFirstDateNode << std::endl;
   #endif
   if(unadjustedFirstDateNode)
   {
      if(unadjustedFirstDateNode->Attribute("href") || unadjustedFirstDateNode->Attribute("id"))
      {
          if(unadjustedFirstDateNode->Attribute("id"))
          {
             unadjustedFirstDateIDRef_ = unadjustedFirstDateNode->Attribute("id");
             unadjustedFirstDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(unadjustedFirstDateNode));
             unadjustedFirstDate_->setID(unadjustedFirstDateIDRef_);
             IDManager::instance().setID(unadjustedFirstDateIDRef_,unadjustedFirstDate_);
          }
          else if(unadjustedFirstDateNode->Attribute("href")) { unadjustedFirstDateIDRef_ = unadjustedFirstDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { unadjustedFirstDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(unadjustedFirstDateNode));}
   }

   //unadjustedLastDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* unadjustedLastDateNode = xmlNode->FirstChildElement("unadjustedLastDate");

   if(unadjustedLastDateNode){unadjustedLastDateIsNull_ = false;}
   else{unadjustedLastDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- unadjustedLastDateNode , address : " << unadjustedLastDateNode << std::endl;
   #endif
   if(unadjustedLastDateNode)
   {
      if(unadjustedLastDateNode->Attribute("href") || unadjustedLastDateNode->Attribute("id"))
      {
          if(unadjustedLastDateNode->Attribute("id"))
          {
             unadjustedLastDateIDRef_ = unadjustedLastDateNode->Attribute("id");
             unadjustedLastDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(unadjustedLastDateNode));
             unadjustedLastDate_->setID(unadjustedLastDateIDRef_);
             IDManager::instance().setID(unadjustedLastDateIDRef_,unadjustedLastDate_);
          }
          else if(unadjustedLastDateNode->Attribute("href")) { unadjustedLastDateIDRef_ = unadjustedLastDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { unadjustedLastDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(unadjustedLastDateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDate> DateRange::getUnadjustedFirstDate()
{
   if(!this->unadjustedFirstDateIsNull_){
        if(unadjustedFirstDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(unadjustedFirstDateIDRef_));
        }else{
             return this->unadjustedFirstDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> DateRange::getUnadjustedLastDate()
{
   if(!this->unadjustedLastDateIsNull_){
        if(unadjustedLastDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(unadjustedLastDateIDRef_));
        }else{
             return this->unadjustedLastDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
}

