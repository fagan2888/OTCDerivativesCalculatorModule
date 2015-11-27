// SpreadSchedule.cpp 
#include "SpreadSchedule.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SpreadSchedule::SpreadSchedule(TiXmlNode* xmlNode)
: Schedule(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //typeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* typeNode = xmlNode->FirstChildElement("type");

   if(typeNode){typeIsNull_ = false;}
   else{typeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- typeNode , address : " << typeNode << std::endl;
   #endif
   if(typeNode)
   {
      if(typeNode->Attribute("href") || typeNode->Attribute("id"))
      {
          if(typeNode->Attribute("id"))
          {
             typeIDRef_ = typeNode->Attribute("id");
             type_ = boost::shared_ptr<SpreadScheduleType>(new SpreadScheduleType(typeNode));
             type_->setID(typeIDRef_);
             IDManager::instance().setID(typeIDRef_,type_);
          }
          else if(typeNode->Attribute("href")) { typeIDRef_ = typeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { type_ = boost::shared_ptr<SpreadScheduleType>(new SpreadScheduleType(typeNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<SpreadScheduleType> SpreadSchedule::getType()
{
   if(!this->typeIsNull_){
        if(typeIDRef_ != ""){
             return boost::shared_static_cast<SpreadScheduleType>(IDManager::instance().getID(typeIDRef_));
        }else{
             return this->type_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SpreadScheduleType>();
   }
}
}

