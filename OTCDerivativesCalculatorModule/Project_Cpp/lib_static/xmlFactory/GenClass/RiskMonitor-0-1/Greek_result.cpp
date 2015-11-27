// Greek_result.cpp 
#include "Greek_result.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Greek_result::Greek_result(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //greek_underlyingNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* greek_underlyingNode = xmlNode->FirstChildElement("greek_underlying");

   if(greek_underlyingNode){greek_underlyingIsNull_ = false;}
   else{greek_underlyingIsNull_ = true;}

   if(greek_underlyingNode)
   {
      for(greek_underlyingNode; greek_underlyingNode; greek_underlyingNode = greek_underlyingNode->NextSiblingElement("greek_underlying")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- greek_underlyingNode , address : " << greek_underlyingNode << std::endl;
          #endif
          greek_underlying_.push_back(boost::shared_ptr<Greek_underlying>(new Greek_underlying(greek_underlyingNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- greek_underlyingNode , address : " << greek_underlyingNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<Greek_underlying>> Greek_result::getGreek_underlying()
{
   if(!this->greek_underlyingIsNull_){
        return this->greek_underlying_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Greek_underlying>>();
   }
}
}

