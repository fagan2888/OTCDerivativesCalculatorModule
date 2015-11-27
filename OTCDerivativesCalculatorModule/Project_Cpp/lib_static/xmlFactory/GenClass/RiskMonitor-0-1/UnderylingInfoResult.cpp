// UnderylingInfoResult.cpp 
#include "UnderylingInfoResult.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

UnderylingInfoResult::UnderylingInfoResult(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //underylingResultNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* underylingResultNode = xmlNode->FirstChildElement("underylingResult");

   if(underylingResultNode){underylingResultIsNull_ = false;}
   else{underylingResultIsNull_ = true;}

   if(underylingResultNode)
   {
      for(underylingResultNode; underylingResultNode; underylingResultNode = underylingResultNode->NextSiblingElement("underylingResult")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- underylingResultNode , address : " << underylingResultNode << std::endl;
          #endif
          underylingResult_.push_back(boost::shared_ptr<UnderylingResult>(new UnderylingResult(underylingResultNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- underylingResultNode , address : " << underylingResultNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<UnderylingResult>> UnderylingInfoResult::getUnderylingResult()
{
   if(!this->underylingResultIsNull_){
        return this->underylingResult_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<UnderylingResult>>();
   }
}
}

