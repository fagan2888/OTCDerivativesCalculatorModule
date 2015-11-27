// HullWhiteGreekInfoResult.cpp 
#include "HullWhiteGreekInfoResult.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

HullWhiteGreekInfoResult::HullWhiteGreekInfoResult(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //hullWhiteGreekResultNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* hullWhiteGreekResultNode = xmlNode->FirstChildElement("hullWhiteGreekResult");

   if(hullWhiteGreekResultNode){hullWhiteGreekResultIsNull_ = false;}
   else{hullWhiteGreekResultIsNull_ = true;}

   if(hullWhiteGreekResultNode)
   {
      for(hullWhiteGreekResultNode; hullWhiteGreekResultNode; hullWhiteGreekResultNode = hullWhiteGreekResultNode->NextSiblingElement("hullWhiteGreekResult")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- hullWhiteGreekResultNode , address : " << hullWhiteGreekResultNode << std::endl;
          #endif
          hullWhiteGreekResult_.push_back(boost::shared_ptr<HullWhiteGreekResult>(new HullWhiteGreekResult(hullWhiteGreekResultNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- hullWhiteGreekResultNode , address : " << hullWhiteGreekResultNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<HullWhiteGreekResult>> HullWhiteGreekInfoResult::getHullWhiteGreekResult()
{
   if(!this->hullWhiteGreekResultIsNull_){
        return this->hullWhiteGreekResult_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<HullWhiteGreekResult>>();
   }
}
}

