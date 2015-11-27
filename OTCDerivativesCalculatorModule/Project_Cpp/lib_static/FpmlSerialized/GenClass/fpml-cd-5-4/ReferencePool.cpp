// ReferencePool.cpp 
#include "ReferencePool.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ReferencePool::ReferencePool(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //referencePoolItemNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referencePoolItemNode = xmlNode->FirstChildElement("referencePoolItem");

   if(referencePoolItemNode){referencePoolItemIsNull_ = false;}
   else{referencePoolItemIsNull_ = true;}

   if(referencePoolItemNode)
   {
      for(referencePoolItemNode; referencePoolItemNode; referencePoolItemNode = referencePoolItemNode->NextSiblingElement("referencePoolItem")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referencePoolItemNode , address : " << referencePoolItemNode << std::endl;
          #endif
          if(referencePoolItemNode->Attribute("href") || referencePoolItemNode->Attribute("id"))
          {
              if(referencePoolItemNode->Attribute("id"))
              {
                  referencePoolItemIDRef_ = referencePoolItemNode->Attribute("id");
                  referencePoolItem_.push_back(boost::shared_ptr<ReferencePoolItem>(new ReferencePoolItem(referencePoolItemNode)));
                  referencePoolItem_.back()->setID(referencePoolItemIDRef_);
                  IDManager::instance().setID(referencePoolItemIDRef_, referencePoolItem_.back());
              }
              else if(referencePoolItemNode->Attribute("href")) { referencePoolItemIDRef_ = referencePoolItemNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { referencePoolItem_.push_back(boost::shared_ptr<ReferencePoolItem>(new ReferencePoolItem(referencePoolItemNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referencePoolItemNode , address : " << referencePoolItemNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<ReferencePoolItem>> ReferencePool::getReferencePoolItem()
{
   if(!this->referencePoolItemIsNull_){
        if(referencePoolItemIDRef_ != ""){
             return this->referencePoolItem_;
        }else{
             return this->referencePoolItem_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ReferencePoolItem>>();
   }
}
}

