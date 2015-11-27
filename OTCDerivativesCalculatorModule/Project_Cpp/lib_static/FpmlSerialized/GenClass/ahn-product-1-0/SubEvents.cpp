// SubEvents.cpp 
#include "SubEvents.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SubEvents::SubEvents(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //refEventNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* refEventNode = xmlNode->FirstChildElement("refEvent");

   if(refEventNode){refEventIsNull_ = false;}
   else{refEventIsNull_ = true;}

   if(refEventNode)
   {
      for(refEventNode; refEventNode; refEventNode = refEventNode->NextSiblingElement("refEvent")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- refEventNode , address : " << refEventNode << std::endl;
          #endif
          if(refEventNode->Attribute("href") || refEventNode->Attribute("id"))
          {
              if(refEventNode->Attribute("id"))
              {
                  refEventIDRef_ = refEventNode->Attribute("id");
                  refEvent_.push_back(boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(refEventNode)));
                  refEvent_.back()->setID(refEventIDRef_);
                  IDManager::instance().setID(refEventIDRef_, refEvent_.back());
              }
              else if(refEventNode->Attribute("href")) { refEventIDRef_ = refEventNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { refEvent_.push_back(boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(refEventNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- refEventNode , address : " << refEventNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<XsdTypeToken>> SubEvents::getRefEvent()
{
   if(!this->refEventIsNull_){
        if(refEventIDRef_ != ""){
             return this->refEvent_;
        }else{
             return this->refEvent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<XsdTypeToken>>();
   }
}
}

