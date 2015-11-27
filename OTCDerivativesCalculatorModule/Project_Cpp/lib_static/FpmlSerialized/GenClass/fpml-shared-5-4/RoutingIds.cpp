// RoutingIds.cpp 
#include "RoutingIds.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

RoutingIds::RoutingIds(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //routingIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* routingIdNode = xmlNode->FirstChildElement("routingId");

   if(routingIdNode){routingIdIsNull_ = false;}
   else{routingIdIsNull_ = true;}

   if(routingIdNode)
   {
      for(routingIdNode; routingIdNode; routingIdNode = routingIdNode->NextSiblingElement("routingId")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- routingIdNode , address : " << routingIdNode << std::endl;
          #endif
          if(routingIdNode->Attribute("href") || routingIdNode->Attribute("id"))
          {
              if(routingIdNode->Attribute("id"))
              {
                  routingIdIDRef_ = routingIdNode->Attribute("id");
                  routingId_.push_back(boost::shared_ptr<RoutingId>(new RoutingId(routingIdNode)));
                  routingId_.back()->setID(routingIdIDRef_);
                  IDManager::instance().setID(routingIdIDRef_, routingId_.back());
              }
              else if(routingIdNode->Attribute("href")) { routingIdIDRef_ = routingIdNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { routingId_.push_back(boost::shared_ptr<RoutingId>(new RoutingId(routingIdNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- routingIdNode , address : " << routingIdNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<RoutingId>> RoutingIds::getRoutingId()
{
   if(!this->routingIdIsNull_){
        if(routingIdIDRef_ != ""){
             return this->routingId_;
        }else{
             return this->routingId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<RoutingId>>();
   }
}
}

