// GbmGreekInfoResult.cpp 
#include "GbmGreekInfoResult.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

GbmGreekInfoResult::GbmGreekInfoResult(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //gbmGreekResultNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* gbmGreekResultNode = xmlNode->FirstChildElement("gbmGreekResult");

   if(gbmGreekResultNode){gbmGreekResultIsNull_ = false;}
   else{gbmGreekResultIsNull_ = true;}

   if(gbmGreekResultNode)
   {
      for(gbmGreekResultNode; gbmGreekResultNode; gbmGreekResultNode = gbmGreekResultNode->NextSiblingElement("gbmGreekResult")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- gbmGreekResultNode , address : " << gbmGreekResultNode << std::endl;
          #endif
          gbmGreekResult_.push_back(boost::shared_ptr<GbmGreekResult>(new GbmGreekResult(gbmGreekResultNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- gbmGreekResultNode , address : " << gbmGreekResultNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<GbmGreekResult>> GbmGreekInfoResult::getGbmGreekResult()
{
   if(!this->gbmGreekResultIsNull_){
        return this->gbmGreekResult_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<GbmGreekResult>>();
   }
}
}

