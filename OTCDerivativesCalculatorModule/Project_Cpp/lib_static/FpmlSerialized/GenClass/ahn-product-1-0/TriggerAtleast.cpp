// TriggerAtleast.cpp 
#include "TriggerAtleast.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

TriggerAtleast::TriggerAtleast(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //countNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* countNode = xmlNode->FirstChildElement("count");

   if(countNode){countIsNull_ = false;}
   else{countIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- countNode , address : " << countNode << std::endl;
   #endif
   if(countNode)
   {
      if(countNode->Attribute("href") || countNode->Attribute("id"))
      {
          if(countNode->Attribute("id"))
          {
             countIDRef_ = countNode->Attribute("id");
             count_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(countNode));
             count_->setID(countIDRef_);
             IDManager::instance().setID(countIDRef_,count_);
          }
          else if(countNode->Attribute("href")) { countIDRef_ = countNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { count_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(countNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDouble> TriggerAtleast::getCount()
{
   if(!this->countIsNull_){
        if(countIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDouble>(IDManager::instance().getID(countIDRef_));
        }else{
             return this->count_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
}

