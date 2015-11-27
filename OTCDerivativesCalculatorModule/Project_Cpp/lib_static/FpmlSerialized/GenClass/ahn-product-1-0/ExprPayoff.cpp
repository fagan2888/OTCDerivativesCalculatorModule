// ExprPayoff.cpp 
#include "ExprPayoff.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ExprPayoff::ExprPayoff(TiXmlNode* xmlNode)
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
          if(dateNode->Attribute("href") || dateNode->Attribute("id"))
          {
              if(dateNode->Attribute("id"))
              {
                  dateIDRef_ = dateNode->Attribute("id");
                  date_.push_back(boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(dateNode)));
                  date_.back()->setID(dateIDRef_);
                  IDManager::instance().setID(dateIDRef_, date_.back());
              }
              else if(dateNode->Attribute("href")) { dateIDRef_ = dateNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { date_.push_back(boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(dateNode)));}
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
std::vector<boost::shared_ptr<XsdTypeDate>> ExprPayoff::getDate()
{
   if(!this->dateIsNull_){
        if(dateIDRef_ != ""){
             return this->date_;
        }else{
             return this->date_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<XsdTypeDate>>();
   }
}
}

