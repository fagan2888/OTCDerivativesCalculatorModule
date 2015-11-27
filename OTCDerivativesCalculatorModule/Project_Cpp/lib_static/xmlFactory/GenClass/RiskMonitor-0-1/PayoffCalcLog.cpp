// PayoffCalcLog.cpp 
#include "PayoffCalcLog.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PayoffCalcLog::PayoffCalcLog(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //pathDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* pathDateNode = xmlNode->FirstChildElement("pathDate");

   if(pathDateNode){pathDateIsNull_ = false;}
   else{pathDateIsNull_ = true;}

   if(pathDateNode)
   {
      for(pathDateNode; pathDateNode; pathDateNode = pathDateNode->NextSiblingElement("pathDate")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- pathDateNode , address : " << pathDateNode << std::endl;
          #endif
          if(pathDateNode->Attribute("href") || pathDateNode->Attribute("id"))
          {
              if(pathDateNode->Attribute("id"))
              {
                  pathDateIDRef_ = pathDateNode->Attribute("id");
                  pathDate_.push_back(boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(pathDateNode)));
                  pathDate_.back()->setID(pathDateIDRef_);
                  IDManager::instance().setID(pathDateIDRef_, pathDate_.back());
              }
              else if(pathDateNode->Attribute("href")) { pathDateIDRef_ = pathDateNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { pathDate_.push_back(boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(pathDateNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- pathDateNode , address : " << pathDateNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<XsdTypeToken>> PayoffCalcLog::getPathDate()
{
   if(!this->pathDateIsNull_){
        if(pathDateIDRef_ != ""){
             return this->pathDate_;
        }else{
             return this->pathDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<XsdTypeToken>>();
   }
}
}

