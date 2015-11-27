// EventDate.cpp 
#include "EventDate.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EventDate::EventDate(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //dateSingleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dateSingleNode = xmlNode->FirstChildElement("dateSingle");

   if(dateSingleNode){dateSingleIsNull_ = false;}
   else{dateSingleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dateSingleNode , address : " << dateSingleNode << std::endl;
   #endif
   if(dateSingleNode)
   {
      if(dateSingleNode->Attribute("href") || dateSingleNode->Attribute("id"))
      {
          if(dateSingleNode->Attribute("id"))
          {
             dateSingleIDRef_ = dateSingleNode->Attribute("id");
             dateSingle_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(dateSingleNode));
             dateSingle_->setID(dateSingleIDRef_);
             IDManager::instance().setID(dateSingleIDRef_,dateSingle_);
          }
          else if(dateSingleNode->Attribute("href")) { dateSingleIDRef_ = dateSingleNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dateSingle_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(dateSingleNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDate> EventDate::getDateSingle()
{
   if(!this->dateSingleIsNull_){
        if(dateSingleIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(dateSingleIDRef_));
        }else{
             return this->dateSingle_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
}

