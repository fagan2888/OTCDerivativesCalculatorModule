// DateList.cpp 
#include "DateList.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

DateList::DateList(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //dateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dateNode = xmlNode->FirstChildElement("date");

   if(dateNode){dateIsNull_ = false;}
   else{dateIsNull_ = true;}

   if(dateNode)
   {
      for(dateNode; dateNode; dateNode = dateNode->NextSiblingElement("date")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dateNode , address : " << dateNode << std::endl;
          #endif
          date_.push_back(boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(dateNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dateNode , address : " << dateNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<XsdTypeDate>> DateList::getDate()
{
   if(!this->dateIsNull_){
        return this->date_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<XsdTypeDate>>();
   }
}
}

