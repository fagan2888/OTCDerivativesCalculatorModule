// PassThrough.cpp 
#include "PassThrough.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PassThrough::PassThrough(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //passThroughItemNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* passThroughItemNode = xmlNode->FirstChildElement("passThroughItem");

   if(passThroughItemNode){passThroughItemIsNull_ = false;}
   else{passThroughItemIsNull_ = true;}

   if(passThroughItemNode)
   {
      for(passThroughItemNode; passThroughItemNode; passThroughItemNode = passThroughItemNode->NextSiblingElement("passThroughItem")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- passThroughItemNode , address : " << passThroughItemNode << std::endl;
          #endif
          if(passThroughItemNode->Attribute("href") || passThroughItemNode->Attribute("id"))
          {
              if(passThroughItemNode->Attribute("id"))
              {
                  passThroughItemIDRef_ = passThroughItemNode->Attribute("id");
                  passThroughItem_.push_back(boost::shared_ptr<PassThroughItem>(new PassThroughItem(passThroughItemNode)));
                  passThroughItem_.back()->setID(passThroughItemIDRef_);
                  IDManager::instance().setID(passThroughItemIDRef_, passThroughItem_.back());
              }
              else if(passThroughItemNode->Attribute("href")) { passThroughItemIDRef_ = passThroughItemNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { passThroughItem_.push_back(boost::shared_ptr<PassThroughItem>(new PassThroughItem(passThroughItemNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- passThroughItemNode , address : " << passThroughItemNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<PassThroughItem>> PassThrough::getPassThroughItem()
{
   if(!this->passThroughItemIsNull_){
        if(passThroughItemIDRef_ != ""){
             return this->passThroughItem_;
        }else{
             return this->passThroughItem_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<PassThroughItem>>();
   }
}
}

