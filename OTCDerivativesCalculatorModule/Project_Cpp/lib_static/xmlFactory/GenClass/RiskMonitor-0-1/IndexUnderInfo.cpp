// IndexUnderInfo.cpp 
#include "IndexUnderInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

IndexUnderInfo::IndexUnderInfo(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //indexNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* indexNode = xmlNode->FirstChildElement("index");

   if(indexNode){indexIsNull_ = false;}
   else{indexIsNull_ = true;}

   if(indexNode)
   {
      for(indexNode; indexNode; indexNode = indexNode->NextSiblingElement("index")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- indexNode , address : " << indexNode << std::endl;
          #endif
          index_.push_back(boost::shared_ptr<Index>(new Index(indexNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- indexNode , address : " << indexNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<Index>> IndexUnderInfo::getIndex()
{
   if(!this->indexIsNull_){
        return this->index_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Index>>();
   }
}
}

