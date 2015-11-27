// BaseIndexes.cpp 
#include "BaseIndexes.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

BaseIndexes::BaseIndexes(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //underlyingIndexNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* underlyingIndexNode = xmlNode->FirstChildElement("underlyingIndex");

   if(underlyingIndexNode){underlyingIndexIsNull_ = false;}
   else{underlyingIndexIsNull_ = true;}

   if(underlyingIndexNode)
   {
      for(underlyingIndexNode; underlyingIndexNode; underlyingIndexNode = underlyingIndexNode->NextSiblingElement("underlyingIndex")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- underlyingIndexNode , address : " << underlyingIndexNode << std::endl;
          #endif
          if(underlyingIndexNode->Attribute("href") || underlyingIndexNode->Attribute("id"))
          {
              if(underlyingIndexNode->Attribute("id"))
              {
                  underlyingIndexIDRef_ = underlyingIndexNode->Attribute("id");
                  underlyingIndex_.push_back(boost::shared_ptr<UnderlyingIndex>(new UnderlyingIndex(underlyingIndexNode)));
                  underlyingIndex_.back()->setID(underlyingIndexIDRef_);
                  IDManager::instance().setID(underlyingIndexIDRef_, underlyingIndex_.back());
              }
              else if(underlyingIndexNode->Attribute("href")) { underlyingIndexIDRef_ = underlyingIndexNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { underlyingIndex_.push_back(boost::shared_ptr<UnderlyingIndex>(new UnderlyingIndex(underlyingIndexNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- underlyingIndexNode , address : " << underlyingIndexNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<UnderlyingIndex>> BaseIndexes::getUnderlyingIndex()
{
   if(!this->underlyingIndexIsNull_){
        if(underlyingIndexIDRef_ != ""){
             return this->underlyingIndex_;
        }else{
             return this->underlyingIndex_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<UnderlyingIndex>>();
   }
}
}

