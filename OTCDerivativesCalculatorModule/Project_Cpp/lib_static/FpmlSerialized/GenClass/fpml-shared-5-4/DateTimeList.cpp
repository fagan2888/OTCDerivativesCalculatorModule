// DateTimeList.cpp 
#include "DateTimeList.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

DateTimeList::DateTimeList(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //dateTimeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dateTimeNode = xmlNode->FirstChildElement("dateTime");

   if(dateTimeNode){dateTimeIsNull_ = false;}
   else{dateTimeIsNull_ = true;}

   if(dateTimeNode)
   {
      for(dateTimeNode; dateTimeNode; dateTimeNode = dateTimeNode->NextSiblingElement("dateTime")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dateTimeNode , address : " << dateTimeNode << std::endl;
          #endif
          if(dateTimeNode->Attribute("href") || dateTimeNode->Attribute("id"))
          {
              if(dateTimeNode->Attribute("id"))
              {
                  dateTimeIDRef_ = dateTimeNode->Attribute("id");
                  dateTime_.push_back(boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(dateTimeNode)));
                  dateTime_.back()->setID(dateTimeIDRef_);
                  IDManager::instance().setID(dateTimeIDRef_, dateTime_.back());
              }
              else if(dateTimeNode->Attribute("href")) { dateTimeIDRef_ = dateTimeNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { dateTime_.push_back(boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(dateTimeNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dateTimeNode , address : " << dateTimeNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<XsdTypeDateTime>> DateTimeList::getDateTime()
{
   if(!this->dateTimeIsNull_){
        if(dateTimeIDRef_ != ""){
             return this->dateTime_;
        }else{
             return this->dateTime_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<XsdTypeDateTime>>();
   }
}
}

